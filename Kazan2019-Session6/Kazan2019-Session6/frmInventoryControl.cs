using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kazan2019_Session6
{
    public partial class frmInventoryControl : Form
    {
        public frmInventoryControl()
        {
            InitializeComponent();
        }

        void LoadLanguagePack()
        {
            this.Text = GlobalVariables.GetText("InventoryControl.FormTitle");
            gbSearchForParts.Text = GlobalVariables.GetText("InventoryControl.PanelTitle.SearchForParts");
            gbAllocatedParts.Text = GlobalVariables.GetText("InventoryControl.PanelTitle.AllocatedParts");
            gbAssignedParts.Text = GlobalVariables.GetText("InventoryControl.PanelTitle.AssignedParts");
            
            btnAllocate.Text = GlobalVariables.GetText("InventoryControl.Button.Allocate");
            btnAssignToEM.Text = GlobalVariables.GetText("InventoryControl.Button.AssignToEM");
            btnSubmit.Text = GlobalVariables.GetText("InventoryControl.Button.Submit");
            btnCancel.Text = GlobalVariables.GetText("InventoryControl.Button.Cancel");

            lblAssetNumberEMNumber.Text = GlobalVariables.GetText("InventoryControl.Label.AssetNumberEMNumber");
            lblDate.Text = GlobalVariables.GetText("InventoryControl.Label.Date");
            lblWarehouse.Text = GlobalVariables.GetText("InventoryControl.Label.Warehouse");
            lblPartName.Text = GlobalVariables.GetText("InventoryControl.Label.PartName");
            lblAmount.Text = GlobalVariables.GetText("InventoryControl.Label.Amount");
            lblAllocationMethod.Text = GlobalVariables.GetText("InventoryControl.Label.AllocationMethod");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //This creates the order and assigns it to the selected EM
            var strEM_ID = cbAssetNumberEMNumber.SelectedItem.ToString();
            strEM_ID = strEM_ID.Substring(strEM_ID.LastIndexOf("(") + 1);
            
            var EM_ID = Convert.ToInt64(strEM_ID.Substring(0, strEM_ID.Length - 1));
            var WarehouseID = Convert.ToInt64(cbWarehouse.SelectedValue);
            using (var db = new Session6Entities())
            {
                var theOrder = new Order()
                {
                    Date = dtpDate.Value,
                    EmergencyMaintenancesID = EM_ID,
                    SourceWarehouseID = WarehouseID,
                    Time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second),
                    TransactionTypeID = 3
                };
                db.Orders.Add(theOrder);
                db.SaveChanges();

                //After saving, theOrder.ID will be populated
                foreach(var r in AssignedParts)
                {
                    db.OrderItems.Add(new OrderItem()
                    {
                        Amount = r.Amount,
                        BatchNumber = r.BatchNumber,
                        OrderID = theOrder.ID,
                        PartID = r.PartID,
                        UnitPrice = r.UnitPrice
                    });
                }
                db.SaveChanges();
            }

            MessageBox.Show("Changes saved", "Operation Success", MessageBoxButtons.OK);
        }

        private void frmInventoryControl_Load(object sender, EventArgs e)
        {
            LoadLanguagePack();

            dtpDate.Value = DateTime.Now;
            cbAllocationMethod.SelectedIndex = 0;

            using (var db = new Session6Entities())
            {
                cbAssetNumberEMNumber.Items.AddRange((from p in db.EmergencyMaintenances
                                                    where p.EMStartDate.HasValue && !p.EMEndDate.HasValue
                                                    select p.Asset.AssetName + " (" + p.ID + ")").ToArray());

                cbWarehouse.DataSource = (from p in db.Warehouses
                                          orderby p.Name
                                          select new IDStringPair() { ID = p.ID, Value = p.Name }).ToList();
                cbWarehouse.DisplayMember = "Value";
                cbWarehouse.ValueMember = "ID";

                UpdatePartsCombobox();
            }
        }

        private void cbAssetNumberEMNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAllocate.Enabled = true;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            UpdatePartsCombobox();
        }

        private void cbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePartsCombobox();
        }

        void UpdatePartsCombobox()
        {
            if (cbWarehouse.SelectedValue == null || !(cbWarehouse.SelectedValue is long)) return;
            /*parts in stock at the warehouse before the date picked
             * Assumption here is to just list all those with TransactionTypeID=1 aka PurchaseOrders
            */
            using (var db = new Session6Entities())
            {
                var WarehouseID = Convert.ToInt64(cbWarehouse.SelectedValue);
                cbPartName.DataSource = (from p in db.OrderItems
                                         where p.Order.TransactionTypeID == 1 && p.Order.DestinationWarehouseID == WarehouseID
                                         group p by new {p.Part.Name, p.PartID} into q
                                         select new IDStringPair()
                                         {
                                             ID = q.Key.PartID,
                                             Value = q.Key.Name,
                                             Params = q.Sum(p => p.Amount)
                                         }).ToList();
                cbPartName.DisplayMember = "Value";
                cbPartName.ValueMember = "ID";
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Max = Convert.ToDecimal((cbPartName.SelectedItem as IDStringPair).Params);
            toolTip1.SetToolTip(txtAmount, $"Cannot be more than {Max.ToString("0")}");
            txtAmount.Tag = Max;
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            var Max = (decimal)txtAmount.Tag;
            var Req = Convert.ToDecimal(txtAmount.Text);
            if (Req > Max)
                MessageBox.Show($"Amount to transfer cannot be more than {txtAmount.Tag}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                using (var db = new Session6Entities())
                {
                    var WarehouseID = Convert.ToInt64(cbWarehouse.SelectedValue);
                    var PartID = (cbPartName.SelectedItem as IDStringPair).ID;

                    var rec = (from p in db.OrderItems
                               where p.PartID == PartID && p.Order.TransactionTypeID == 1 && p.Order.DestinationWarehouseID == WarehouseID
                               select new { OrderItem = p, Order = p.Order });

                    switch (cbAllocationMethod.SelectedItem.ToString())
                    {
                        case "FIFO (First in First Out)":
                            rec = (from q in rec
                                   orderby q.Order.Date
                                   select q);
                            break;
                        case "LIFO(Last in First Out)":
                            rec = (from q in rec
                                   orderby q.Order.Date descending
                                   select q);
                            break;
                        case "Minimum First":
                            rec = (from q in rec
                                   orderby q.OrderItem.UnitPrice
                                   select q);
                            break;
                    }

                    //As i cannot tell how many is needed, take x records where x = amount needed (assuming each record has only 1)
                    //This is an assumption as there isnt an optimal method of tracking current inventory based on the system design
                    var DS = (from p in rec
                              select new dAllocatedParts()
                              {
                                  PartName = p.OrderItem.Part.Name,
                                  BatchNumber = p.OrderItem.BatchNumber,
                                  UnitPrice = p.OrderItem.UnitPrice.Value,
                                  Amount = p.OrderItem.Amount,
                                  PartID = p.OrderItem.PartID
                              }).Take(Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(txtAmount.Text))));

                    var lAllocatedParts = new List<dAllocatedParts>();
                    decimal CurrentAmount = 0;
                    
                    foreach(var r in DS)
                    {
                        CurrentAmount += r.Amount;
                        if (CurrentAmount > Req)
                        {
                            r.Amount -= (CurrentAmount - Req);
                            lAllocatedParts.Add(r);
                            break;
                        }
                        else if (CurrentAmount == Req)
                        {
                            lAllocatedParts.Add(r);
                            break;
                        }
                        else
                        {
                            lAllocatedParts.Add(r);
                        }
                    }

                    dgvAllocatedParts.DataSource = lAllocatedParts;

                    btnAssignToEM.Enabled = lAllocatedParts.Count() > 0;
                }
            }
        }

        List<dAllocatedParts> AssignedParts = new List<dAllocatedParts>();
        void BindAssignedGrid()
        {
            var BS = new BindingSource();
            BS.DataSource = AssignedParts;
            dgvAssignedParts.DataSource = BS;
            btnSubmit.Enabled = AssignedParts.Count() > 0;
        }

        private void btnAssignToEM_Click(object sender, EventArgs e)
        {
            AssignedParts.AddRange((dgvAllocatedParts.DataSource as List<dAllocatedParts>));
            BindAssignedGrid();
        }

        private void dgvAssignedParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ideally check e.ColumnIndex, but since there is only 1, no need to bother
            AssignedParts.RemoveAt(e.RowIndex);
            BindAssignedGrid();
        }
    }

    public class IDStringPair
    {
        public long ID { get; set; }
        public string Value { get; set; }
        public decimal Params { get; set; }
    }

    public class dAllocatedParts
    {
        public long PartID { get; set; }
        public string PartName { get; set; }
        public string BatchNumber { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
    }
}
