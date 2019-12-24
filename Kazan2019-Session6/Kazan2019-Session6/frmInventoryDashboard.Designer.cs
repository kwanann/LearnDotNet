namespace Kazan2019_Session6
{
    partial class frmInventoryDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PanelOperations = new System.Windows.Forms.Panel();
            this.lblLang = new System.Windows.Forms.Label();
            this.cbLanguages = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInventoryControl = new System.Windows.Forms.Button();
            this.gbMonthlyReportOfCostlyAssets = new System.Windows.Forms.GroupBox();
            this.dgvMonthlyReportOfCostlyAssets = new System.Windows.Forms.DataGridView();
            this.gbMonthlyReportForMostUsedParts = new System.Windows.Forms.GroupBox();
            this.dgvMonthlyReportForMostUsedParts = new System.Windows.Forms.DataGridView();
            this.gbEMSpendingByDepartment = new System.Windows.Forms.GroupBox();
            this.dgvEMSpendingByDepartment = new System.Windows.Forms.DataGridView();
            this.gbMonthlyDepartmentSpending = new System.Windows.Forms.GroupBox();
            this.chMonthlyDepartmentSpending = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbDepartmentSpendingRatio = new System.Windows.Forms.GroupBox();
            this.chDepartmentSpendingRatio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PanelOperations.SuspendLayout();
            this.gbMonthlyReportOfCostlyAssets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReportOfCostlyAssets)).BeginInit();
            this.gbMonthlyReportForMostUsedParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReportForMostUsedParts)).BeginInit();
            this.gbEMSpendingByDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMSpendingByDepartment)).BeginInit();
            this.gbMonthlyDepartmentSpending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chMonthlyDepartmentSpending)).BeginInit();
            this.gbDepartmentSpendingRatio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chDepartmentSpendingRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelRight
            // 
            this.PanelRight.Location = new System.Drawing.Point(844, 44);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(222, 539);
            this.PanelRight.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PanelOperations);
            this.splitContainer1.Panel1.Controls.Add(this.gbMonthlyReportOfCostlyAssets);
            this.splitContainer1.Panel1.Controls.Add(this.gbMonthlyReportForMostUsedParts);
            this.splitContainer1.Panel1.Controls.Add(this.gbEMSpendingByDepartment);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbMonthlyDepartmentSpending);
            this.splitContainer1.Panel2.Controls.Add(this.gbDepartmentSpendingRatio);
            this.splitContainer1.Size = new System.Drawing.Size(950, 511);
            this.splitContainer1.SplitterDistance = 641;
            this.splitContainer1.TabIndex = 3;
            // 
            // PanelOperations
            // 
            this.PanelOperations.Controls.Add(this.lblLang);
            this.PanelOperations.Controls.Add(this.cbLanguages);
            this.PanelOperations.Controls.Add(this.btnClose);
            this.PanelOperations.Controls.Add(this.btnInventoryControl);
            this.PanelOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOperations.Location = new System.Drawing.Point(0, 450);
            this.PanelOperations.Name = "PanelOperations";
            this.PanelOperations.Size = new System.Drawing.Size(641, 61);
            this.PanelOperations.TabIndex = 8;
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(354, 12);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(41, 13);
            this.lblLang.TabIndex = 3;
            this.lblLang.Text = "lblLang";
            // 
            // cbLanguages
            // 
            this.cbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguages.FormattingEnabled = true;
            this.cbLanguages.Location = new System.Drawing.Point(438, 9);
            this.cbLanguages.Name = "cbLanguages";
            this.cbLanguages.Size = new System.Drawing.Size(134, 21);
            this.cbLanguages.TabIndex = 2;
            this.cbLanguages.SelectedIndexChanged += new System.EventHandler(this.cbLanguages_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInventoryControl
            // 
            this.btnInventoryControl.Location = new System.Drawing.Point(13, 7);
            this.btnInventoryControl.Name = "btnInventoryControl";
            this.btnInventoryControl.Size = new System.Drawing.Size(158, 23);
            this.btnInventoryControl.TabIndex = 0;
            this.btnInventoryControl.Text = "btnInventoryControl";
            this.btnInventoryControl.UseVisualStyleBackColor = true;
            this.btnInventoryControl.Click += new System.EventHandler(this.btnInventoryControl_Click);
            // 
            // gbMonthlyReportOfCostlyAssets
            // 
            this.gbMonthlyReportOfCostlyAssets.Controls.Add(this.dgvMonthlyReportOfCostlyAssets);
            this.gbMonthlyReportOfCostlyAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMonthlyReportOfCostlyAssets.Location = new System.Drawing.Point(0, 300);
            this.gbMonthlyReportOfCostlyAssets.Name = "gbMonthlyReportOfCostlyAssets";
            this.gbMonthlyReportOfCostlyAssets.Size = new System.Drawing.Size(641, 150);
            this.gbMonthlyReportOfCostlyAssets.TabIndex = 7;
            this.gbMonthlyReportOfCostlyAssets.TabStop = false;
            this.gbMonthlyReportOfCostlyAssets.Text = "gbMonthlyReportOfCostlyAssets";
            // 
            // dgvMonthlyReportOfCostlyAssets
            // 
            this.dgvMonthlyReportOfCostlyAssets.AllowUserToAddRows = false;
            this.dgvMonthlyReportOfCostlyAssets.AllowUserToDeleteRows = false;
            this.dgvMonthlyReportOfCostlyAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyReportOfCostlyAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonthlyReportOfCostlyAssets.Location = new System.Drawing.Point(3, 16);
            this.dgvMonthlyReportOfCostlyAssets.Name = "dgvMonthlyReportOfCostlyAssets";
            this.dgvMonthlyReportOfCostlyAssets.ReadOnly = true;
            this.dgvMonthlyReportOfCostlyAssets.Size = new System.Drawing.Size(635, 131);
            this.dgvMonthlyReportOfCostlyAssets.TabIndex = 1;
            // 
            // gbMonthlyReportForMostUsedParts
            // 
            this.gbMonthlyReportForMostUsedParts.Controls.Add(this.dgvMonthlyReportForMostUsedParts);
            this.gbMonthlyReportForMostUsedParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMonthlyReportForMostUsedParts.Location = new System.Drawing.Point(0, 150);
            this.gbMonthlyReportForMostUsedParts.Name = "gbMonthlyReportForMostUsedParts";
            this.gbMonthlyReportForMostUsedParts.Size = new System.Drawing.Size(641, 150);
            this.gbMonthlyReportForMostUsedParts.TabIndex = 6;
            this.gbMonthlyReportForMostUsedParts.TabStop = false;
            this.gbMonthlyReportForMostUsedParts.Text = "gbMonthlyReportForMostUsedParts";
            // 
            // dgvMonthlyReportForMostUsedParts
            // 
            this.dgvMonthlyReportForMostUsedParts.AllowUserToAddRows = false;
            this.dgvMonthlyReportForMostUsedParts.AllowUserToDeleteRows = false;
            this.dgvMonthlyReportForMostUsedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyReportForMostUsedParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonthlyReportForMostUsedParts.Location = new System.Drawing.Point(3, 16);
            this.dgvMonthlyReportForMostUsedParts.Name = "dgvMonthlyReportForMostUsedParts";
            this.dgvMonthlyReportForMostUsedParts.ReadOnly = true;
            this.dgvMonthlyReportForMostUsedParts.Size = new System.Drawing.Size(635, 131);
            this.dgvMonthlyReportForMostUsedParts.TabIndex = 1;
            // 
            // gbEMSpendingByDepartment
            // 
            this.gbEMSpendingByDepartment.Controls.Add(this.dgvEMSpendingByDepartment);
            this.gbEMSpendingByDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEMSpendingByDepartment.Location = new System.Drawing.Point(0, 0);
            this.gbEMSpendingByDepartment.Name = "gbEMSpendingByDepartment";
            this.gbEMSpendingByDepartment.Size = new System.Drawing.Size(641, 150);
            this.gbEMSpendingByDepartment.TabIndex = 5;
            this.gbEMSpendingByDepartment.TabStop = false;
            this.gbEMSpendingByDepartment.Text = "EM Spending By Department";
            // 
            // dgvEMSpendingByDepartment
            // 
            this.dgvEMSpendingByDepartment.AllowUserToAddRows = false;
            this.dgvEMSpendingByDepartment.AllowUserToDeleteRows = false;
            this.dgvEMSpendingByDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMSpendingByDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEMSpendingByDepartment.Location = new System.Drawing.Point(3, 16);
            this.dgvEMSpendingByDepartment.Name = "dgvEMSpendingByDepartment";
            this.dgvEMSpendingByDepartment.ReadOnly = true;
            this.dgvEMSpendingByDepartment.Size = new System.Drawing.Size(635, 131);
            this.dgvEMSpendingByDepartment.TabIndex = 0;
            // 
            // gbMonthlyDepartmentSpending
            // 
            this.gbMonthlyDepartmentSpending.Controls.Add(this.chMonthlyDepartmentSpending);
            this.gbMonthlyDepartmentSpending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMonthlyDepartmentSpending.Location = new System.Drawing.Point(0, 249);
            this.gbMonthlyDepartmentSpending.Name = "gbMonthlyDepartmentSpending";
            this.gbMonthlyDepartmentSpending.Size = new System.Drawing.Size(305, 262);
            this.gbMonthlyDepartmentSpending.TabIndex = 3;
            this.gbMonthlyDepartmentSpending.TabStop = false;
            this.gbMonthlyDepartmentSpending.Text = "gbMonthlyDepartmentSpending";
            // 
            // chMonthlyDepartmentSpending
            // 
            chartArea5.Name = "ChartArea1";
            this.chMonthlyDepartmentSpending.ChartAreas.Add(chartArea5);
            this.chMonthlyDepartmentSpending.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chMonthlyDepartmentSpending.Legends.Add(legend5);
            this.chMonthlyDepartmentSpending.Location = new System.Drawing.Point(3, 16);
            this.chMonthlyDepartmentSpending.Name = "chMonthlyDepartmentSpending";
            this.chMonthlyDepartmentSpending.Size = new System.Drawing.Size(299, 243);
            this.chMonthlyDepartmentSpending.TabIndex = 1;
            this.chMonthlyDepartmentSpending.Text = "chart1";
            // 
            // gbDepartmentSpendingRatio
            // 
            this.gbDepartmentSpendingRatio.Controls.Add(this.chDepartmentSpendingRatio);
            this.gbDepartmentSpendingRatio.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDepartmentSpendingRatio.Location = new System.Drawing.Point(0, 0);
            this.gbDepartmentSpendingRatio.Name = "gbDepartmentSpendingRatio";
            this.gbDepartmentSpendingRatio.Size = new System.Drawing.Size(305, 249);
            this.gbDepartmentSpendingRatio.TabIndex = 2;
            this.gbDepartmentSpendingRatio.TabStop = false;
            this.gbDepartmentSpendingRatio.Text = "gbDepartmentSpendingRatio";
            // 
            // chDepartmentSpendingRatio
            // 
            chartArea6.Name = "ChartArea1";
            this.chDepartmentSpendingRatio.ChartAreas.Add(chartArea6);
            this.chDepartmentSpendingRatio.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chDepartmentSpendingRatio.Legends.Add(legend6);
            this.chDepartmentSpendingRatio.Location = new System.Drawing.Point(3, 16);
            this.chDepartmentSpendingRatio.Name = "chDepartmentSpendingRatio";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chDepartmentSpendingRatio.Series.Add(series3);
            this.chDepartmentSpendingRatio.Size = new System.Drawing.Size(299, 230);
            this.chDepartmentSpendingRatio.TabIndex = 0;
            this.chDepartmentSpendingRatio.Text = "chart1";
            // 
            // frmInventoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 511);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.PanelRight);
            this.Name = "frmInventoryDashboard";
            this.Text = "*Inventory Dashboard";
            this.Load += new System.EventHandler(this.frmInventoryDashboard_Load);
            this.Resize += new System.EventHandler(this.frmInventoryDashboard_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PanelOperations.ResumeLayout(false);
            this.PanelOperations.PerformLayout();
            this.gbMonthlyReportOfCostlyAssets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReportOfCostlyAssets)).EndInit();
            this.gbMonthlyReportForMostUsedParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReportForMostUsedParts)).EndInit();
            this.gbEMSpendingByDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMSpendingByDepartment)).EndInit();
            this.gbMonthlyDepartmentSpending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chMonthlyDepartmentSpending)).EndInit();
            this.gbDepartmentSpendingRatio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chDepartmentSpendingRatio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel PanelOperations;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox cbLanguages;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInventoryControl;
        private System.Windows.Forms.GroupBox gbMonthlyReportOfCostlyAssets;
        private System.Windows.Forms.DataGridView dgvMonthlyReportOfCostlyAssets;
        private System.Windows.Forms.GroupBox gbMonthlyReportForMostUsedParts;
        private System.Windows.Forms.DataGridView dgvMonthlyReportForMostUsedParts;
        private System.Windows.Forms.GroupBox gbEMSpendingByDepartment;
        private System.Windows.Forms.DataGridView dgvEMSpendingByDepartment;
        private System.Windows.Forms.GroupBox gbMonthlyDepartmentSpending;
        private System.Windows.Forms.DataVisualization.Charting.Chart chMonthlyDepartmentSpending;
        private System.Windows.Forms.GroupBox gbDepartmentSpendingRatio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDepartmentSpendingRatio;
    }
}

