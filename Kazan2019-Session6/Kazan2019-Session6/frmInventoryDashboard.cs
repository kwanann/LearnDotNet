using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kazan2019_Session6
{
    public partial class frmInventoryDashboard : Form
    {
        public frmInventoryDashboard()
        {
            InitializeComponent();
        }

        private void frmInventoryDashboard_Load(object sender, EventArgs e)
        {
            cbLanguages.Items.AddRange(GlobalVariables.Language_GetAvailable.ToArray());
            cbLanguages.SelectedItem = GlobalVariables.Language_Current;
            LoadLanguagePack();

            using (var db = new Session6Entities())
            {
                #region EM Spending by Department
                //Trigger the SQL query to change it to list for c# processing
                var DS_EM_Spending_By_Department1 = (from p in db.Orders
                                                   where p.EmergencyMaintenance.EMStartDate != null & p.EmergencyMaintenance.EMEndDate != null
                                                   select new
                                                   {
                                                       DeptName = p.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name,
                                                       //DeptID = p.EmergencyMaintenance.Asset.DepartmentLocation.Department.ID,
                                                       theDate = p.Date,
                                                       Spending = p.OrderItems.Sum(q => q.Amount * q.UnitPrice)
                                                   }).ToList();

                //Tostring function only works when it is a list and not within SQL
                var DS_EM_Spending_By_Department = (from p in DS_EM_Spending_By_Department1
                                                    select new
                                                    {
                                                        p.DeptName,
                                                        p.Spending,
                                                        theDate = p.theDate.ToString("yyyy-MM")
                                                    }
                                                    ).ToList();

                //Eventually, Department / Year-Month

                /*
                 * Grab the last 10 Year-Month columns
                 * NOTE DateColumns is used by ALL the DGV
                 */
                var DateColumns = (from p in DS_EM_Spending_By_Department
                               orderby p.theDate descending
                               select p.theDate).Distinct();

                if (DateColumns.Count() > 10) DateColumns = DateColumns.Take(10);

                var theDepartments = (from p in DS_EM_Spending_By_Department
                                      orderby p.DeptName
                                      select p.DeptName).Distinct();

                /* Ideally the binding will be done using a custom built sql script which maps to a data table
                 * but this is messy, so go old school and build a data table using linq and code
                 */
                
                var DTEMSpendingByDepartment = new DataTable();
                
                //Map first column in DT to first column in DGV
                DTEMSpendingByDepartment.Columns.Add("DeptName");

                //Add the first column to grid
                dgvEMSpendingByDepartment.Columns.Clear();
                dgvEMSpendingByDepartment.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "DeptName",
                    HeaderText = "Department / Month"
                });

                //Define the entire table along with the grid
                foreach (var DC in DateColumns)
                {
                    DTEMSpendingByDepartment.Columns.Add(DC);
                    var DCCol = new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = DC,
                        HeaderText = DC,
                    };
                    DCCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dgvEMSpendingByDepartment.Columns.Add(DCCol);
                }

                foreach(var Dept in theDepartments)
                {
                    var dr = DTEMSpendingByDepartment.NewRow();
                    dr["DeptName"] = Dept;

                    foreach (var DC in DateColumns)
                    {
                        dr[DC] = (from p in DS_EM_Spending_By_Department
                                  where p.DeptName == Dept && p.theDate == DC
                                  select p.Spending).Sum().Value.ToString("0");
                    }

                    DTEMSpendingByDepartment.Rows.Add(dr);
                }
                dgvEMSpendingByDepartment.DataSource = DTEMSpendingByDepartment;

                //need to annotate Red highest spending, green lowest spending
                #endregion

                #region Department Spending Ratio Chart
                //uses same data as DS_EM_Spending_By_Department
                var DS_DepartmentSpendingRatio = (from p in DS_EM_Spending_By_Department
                                                  group p by p.DeptName into q
                                                  select new
                                                  {
                                                      DeptName = q.Key,
                                                      Total = q.Sum(p => p.Spending)
                                                  });

                chDepartmentSpendingRatio.Series[0].Points.Clear();
                foreach (var r in DS_DepartmentSpendingRatio)
                {
                    //Pie chart only has Y values
                    var idx = chDepartmentSpendingRatio.Series[0].Points.AddY(r.Total);

                    chDepartmentSpendingRatio.Series[0].Points[idx].Label = r.DeptName;
                }
                #endregion

                #region Monthly Department Spending
                //uses same data as DS_EM_Spending_By_Department
                var DS_MonthlyDepartmentSpendingRatio = (from p in DS_EM_Spending_By_Department1
                                                  group p by new { p.theDate, p.DeptName } into q
                                                  orderby q.Key.theDate, q.Key.DeptName
                                                  select new
                                                  {
                                                      q.Key.DeptName,
                                                      q.Key.theDate,
                                                      Total = q.Sum(p => p.Spending)
                                                  });

                chMonthlyDepartmentSpending.Series.Clear();
                foreach (var DeptName in DS_MonthlyDepartmentSpendingRatio.Select(p => p.DeptName).Distinct())
                {
                    //Add each deptname as a series
                    chMonthlyDepartmentSpending.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series(DeptName) { });
                }

                var curDate = DateTime.MaxValue;
                var DateIdx = 0;
                foreach (var r in DS_MonthlyDepartmentSpendingRatio)
                {
                    if (curDate != r.theDate)
                    {
                        curDate = r.theDate;
                        DateIdx++;
                    }
                    var idx = chMonthlyDepartmentSpending.Series[r.DeptName].Points.AddXY(DateIdx, r.Total);
                    chMonthlyDepartmentSpending.Series[r.DeptName].Points[idx].AxisLabel = r.theDate.ToString("yyyy-MM");
                    chMonthlyDepartmentSpending.Series[r.DeptName].Points[idx].Label = r.Total.Value.ToString("#,##0");
                }                
                #endregion

                #region Monthly Report for Most-used Parts
                //Highest cost and most number
                var DS_MonthlyReport_MostUsed_Parts1 = (from p in db.OrderItems
                                                     where p.Order.EmergencyMaintenance.EMStartDate != null & p.Order.EmergencyMaintenance.EMEndDate != null
                                                     select new
                                                     {
                                                         theDate = p.Order.Date,
                                                         p.Amount,
                                                         TotalCost = p.UnitPrice * p.Amount,
                                                         PartName = p.Part.Name
                                                     }).ToList();

                //Tostring function only works when it is a list and not within SQL
                var DS_MonthlyReport_MostUsed_Parts = (from p in DS_MonthlyReport_MostUsed_Parts1
                                                       select new
                                                    {
                                                        p.PartName,
                                                        p.Amount,
                                                        p.TotalCost,
                                                        theDate = p.theDate.ToString("yyyy-MM")
                                                    }
                                                    ).ToList();

                var DTMonthlyReportForMostUsedParts = new DataTable();

                //Map first column in DT to first column in DGV
                DTMonthlyReportForMostUsedParts.Columns.Add("Notes");

                //Add the first column to grid
                dgvMonthlyReportForMostUsedParts.Columns.Clear();
                dgvMonthlyReportForMostUsedParts.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Notes",
                    HeaderText = "Notes / Month"
                });

                //Define the entire table along with the grid
                foreach (var DC in DateColumns)
                {
                    DTMonthlyReportForMostUsedParts.Columns.Add(DC);

                    dgvMonthlyReportForMostUsedParts.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = DC,
                        HeaderText = DC,
                    });
                }

                //Now populate the Data table
                var DRMonthlyReportForMostUsedParts_HighestCost = DTMonthlyReportForMostUsedParts.NewRow();
                DRMonthlyReportForMostUsedParts_HighestCost["Notes"] = "Highest Cost";

                var DS_MonthlyReport_MostUsed_Parts_HighestCost = (from p in DS_MonthlyReport_MostUsed_Parts
                                                                   group p by new { p.theDate, p.PartName } into q
                                                                   select new {
                                                                       q.Key.PartName,
                                                                       q.Key.theDate,
                                                                       TotalCost = q.Sum(p => p.TotalCost)
                                                                   }
                                                                   );

                foreach (var DC in DateColumns)
                {
                    var MaxCost = (from p in DS_MonthlyReport_MostUsed_Parts_HighestCost
                                   where p.theDate == DC
                                   orderby p.TotalCost descending
                                   select p.TotalCost).FirstOrDefault();

                    DRMonthlyReportForMostUsedParts_HighestCost[DC] = String.Join(",", (from p in DS_MonthlyReport_MostUsed_Parts_HighestCost
                                                                       where p.theDate == DC && p.TotalCost == MaxCost
                                                                                        orderby p.PartName descending
                                                                                        select p.PartName));
                }

                var DRMonthlyReportForMostUsedParts_MostNumber = DTMonthlyReportForMostUsedParts.NewRow();
                DRMonthlyReportForMostUsedParts_MostNumber["Notes"] = "Most Number";

                var DS_MonthlyReport_MostUsed_Parts_MostNumber = (from p in DS_MonthlyReport_MostUsed_Parts
                                                                   group p by new { p.theDate, p.PartName } into q
                                                                   select new
                                                                   {
                                                                       q.Key.PartName,
                                                                       q.Key.theDate,
                                                                       TotalQuantity = q.Sum(p => p.Amount)
                                                                   }
                                                                   );

                foreach (var DC in DateColumns)
                {
                    var MaxParts = (from p in DS_MonthlyReport_MostUsed_Parts_MostNumber
                                    where p.theDate == DC
                                    orderby p.TotalQuantity descending
                                    select p.TotalQuantity).FirstOrDefault();

                    DRMonthlyReportForMostUsedParts_MostNumber[DC] = String.Join(",", (from p in DS_MonthlyReport_MostUsed_Parts_MostNumber
                                                                       where p.theDate == DC && p.TotalQuantity == MaxParts
                                                                       orderby p.PartName descending
                                                                       select p.PartName));
                }

                DTMonthlyReportForMostUsedParts.Rows.Add(DRMonthlyReportForMostUsedParts_HighestCost);
                DTMonthlyReportForMostUsedParts.Rows.Add(DRMonthlyReportForMostUsedParts_MostNumber);

                dgvMonthlyReportForMostUsedParts.DataSource = DTMonthlyReportForMostUsedParts;
                #endregion

                #region Monthly Report of Costly assets
                //for each department, highest spend per item
                var DS_MonthlyReportOfCostlyAssets1 = (from p in db.OrderItems
                                                       where p.Order.EmergencyMaintenance.EMStartDate != null & p.Order.EmergencyMaintenance.EMEndDate != null
                                                       select new
                                                       {
                                                           theDate = p.Order.Date,
                                                           DeptName = p.Order.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name,
                                                           TotalCost = p.UnitPrice * p.Amount,
                                                           PartName = p.Part.Name
                                                       }).ToList();
                var DS_MonthlyReportOfCostlyAssets = (from p in DS_MonthlyReportOfCostlyAssets1
                                                      select new
                                                      {
                                                          p.DeptName,
                                                          p.TotalCost,
                                                          p.PartName,
                                                          theDate = p.theDate.ToString("yyyy-MM")
                                                      });

                var DT_MonthlyReportOfCostlyAssets = new DataTable();
                DT_MonthlyReportOfCostlyAssets.Columns.Add("Notes");

                //Add the first column to grid
                dgvMonthlyReportOfCostlyAssets.Columns.Clear();
                dgvMonthlyReportOfCostlyAssets.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Notes",
                    HeaderText = "Asset Name / Month"
                });

                //Define the entire table along with the grid
                foreach (var DC in DateColumns)
                {
                    DT_MonthlyReportOfCostlyAssets.Columns.Add(DC);

                    dgvMonthlyReportOfCostlyAssets.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = DC,
                        HeaderText = DC,
                    });
                }

                //the manager wants to identify which assets have been costing the company the most each month
                var DS_MonthlyReportOfCostlyAssets_HighestCost = (from p in DS_MonthlyReportOfCostlyAssets
                                                                  group p by new { p.theDate, p.PartName,p.DeptName } into q
                                                                  select new
                                                                  {
                                                                      q.Key.PartName,
                                                                      q.Key.theDate,
                                                                      q.Key.DeptName,
                                                                      Total = q.Sum(p => p.TotalCost),                                                                      
                                                                  }
                                                                  );

                var DR_MonthlyReportOfCostlyAssets_PartName = DT_MonthlyReportOfCostlyAssets.NewRow();
                DR_MonthlyReportOfCostlyAssets_PartName["Notes"] = "Asset";

                var DR_MonthlyReportOfCostlyAssets_DeptName = DT_MonthlyReportOfCostlyAssets.NewRow();
                DR_MonthlyReportOfCostlyAssets_DeptName["Notes"] = "Department";
                
                foreach (var DC in DateColumns)
                {
                    var HighestCost = (from p in DS_MonthlyReportOfCostlyAssets_HighestCost
                                       where p.theDate == DC
                                       orderby p.Total
                                       select p.Total).FirstOrDefault();

                    DR_MonthlyReportOfCostlyAssets_PartName[DC] = String.Join(",", (from p in DS_MonthlyReportOfCostlyAssets_HighestCost
                                                                                    where p.Total == HighestCost
                                                                                    select p.PartName));

                    DR_MonthlyReportOfCostlyAssets_DeptName[DC] = String.Join(",", (from p in DS_MonthlyReportOfCostlyAssets_HighestCost
                                                                                    where p.Total == HighestCost
                                                                                    select p.DeptName));
                }

                DT_MonthlyReportOfCostlyAssets.Rows.Add(DR_MonthlyReportOfCostlyAssets_PartName);
                DT_MonthlyReportOfCostlyAssets.Rows.Add(DR_MonthlyReportOfCostlyAssets_DeptName);

                dgvMonthlyReportOfCostlyAssets.DataSource = DT_MonthlyReportOfCostlyAssets;
                #endregion
            }
        }

        void LoadLanguagePack()
        {
            this.Text = GlobalVariables.GetText("InventoryDashboard.FormTitle");
            gbEMSpendingByDepartment.Text = GlobalVariables.GetText("InventoryDashboard.PanelTitle.EMSpendingByDepartment");
            gbMonthlyReportForMostUsedParts.Text = GlobalVariables.GetText("InventoryDashboard.PanelTitle.MonthlyReportMostUsedParts");
            gbMonthlyReportOfCostlyAssets.Text = GlobalVariables.GetText("InventoryDashboard.PanelTitle.MonthlyReportCostlyAssets");
            gbDepartmentSpendingRatio.Text = GlobalVariables.GetText("InventoryDashboard.PanelTitle.DepartmentSpendingRatio");
            gbMonthlyDepartmentSpending.Text = GlobalVariables.GetText("InventoryDashboard.PanelTitle.MonthlyDepartmentSpending");
            btnInventoryControl.Text = GlobalVariables.GetText("InventoryDashboard.Button.InventoryControl");
            btnClose.Text = GlobalVariables.GetText("InventoryDashboard.Button.Close");
            lblLang.Text = GlobalVariables.GetText("InventoryDashboard.Label.lang");
        }

        private void cbLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVariables.Language_Current = cbLanguages.SelectedItem.ToString();
            LoadLanguagePack();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventoryControl_Click(object sender, EventArgs e)
        {
            (new frmInventoryControl()).ShowDialog();

            this.BringToFront();

            //Reload the page and data source
            frmInventoryDashboard_Load(null, null);
        }

        private void dgvEMSpendingByDepartment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Grid has been completely databinded
            var DGV = (DataGridView)sender;

            //Loop thru each column and highlight red for highest, green for lowest, excluding 0
            var TotalColumns = DGV.Rows[0].Cells.Count;
            
            for(var i=1;i< TotalColumns; i++)
            {
                decimal Lo = int.MaxValue;
                int LowRow = -1;
                decimal Hi = int.MinValue;
                int HiRow = -1;

                //Get the hi/lo per column
                for(var j=0;j<DGV.Rows.Count;j++)
                {
                    var Value = Convert.ToDecimal(DGV.Rows[j].Cells[i].Value);

                    if (Value > 0)
                    {
                        if (Value < Lo)
                        {
                            Lo = Value;
                            LowRow = j;
                        }

                        if (Value > Hi)
                        {
                            Hi = Value;
                            HiRow = j;
                        }
                    }
                }

                //Now set the color
                if (LowRow == -1 && HiRow == -1)
                {
                    //Do nothing
                }
                else if (LowRow == HiRow)
                {
                    DGV.Rows[HiRow].Cells[i].Style.ForeColor = Color.Red;
                    DGV.Rows[LowRow].Cells[i].Style.ForeColor = Color.Red;
                }
                else
                {
                    if (HiRow > -1) DGV.Rows[HiRow].Cells[i].Style.ForeColor = Color.Red;
                    if (LowRow > -1) DGV.Rows[LowRow].Cells[i].Style.ForeColor = Color.Green;
                }
            }
            
        }

        private void frmInventoryDashboard_Resize(object sender, EventArgs e)
        {
            //Setting each of the group box height is sufficient as they are using docking to align themselves
            //remaining space will be taken up by the operations box
            gbEMSpendingByDepartment.Height = gbMonthlyReportForMostUsedParts.Height = gbMonthlyReportOfCostlyAssets.Height = (splitContainer1.Panel1.Height - 60) / 3;
        }
    }
}
