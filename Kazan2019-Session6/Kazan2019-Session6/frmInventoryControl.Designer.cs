namespace Kazan2019_Session6
{
    partial class frmInventoryControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbSearchForParts = new System.Windows.Forms.GroupBox();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.cbAllocationMethod = new System.Windows.Forms.ComboBox();
            this.lblAllocationMethod = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cbPartName = new System.Windows.Forms.ComboBox();
            this.lblPartName = new System.Windows.Forms.Label();
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbAssetNumberEMNumber = new System.Windows.Forms.ComboBox();
            this.lblAssetNumberEMNumber = new System.Windows.Forms.Label();
            this.gbAllocatedParts = new System.Windows.Forms.GroupBox();
            this.dgvAllocatedParts = new System.Windows.Forms.DataGridView();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAssignToEM = new System.Windows.Forms.Button();
            this.gbAssignedParts = new System.Windows.Forms.GroupBox();
            this.dgvAssignedParts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PartName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PartID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSearchForParts.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.gbAllocatedParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocatedParts)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbAssignedParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedParts)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchForParts
            // 
            this.gbSearchForParts.Controls.Add(this.btnAllocate);
            this.gbSearchForParts.Controls.Add(this.cbAllocationMethod);
            this.gbSearchForParts.Controls.Add(this.lblAllocationMethod);
            this.gbSearchForParts.Controls.Add(this.txtAmount);
            this.gbSearchForParts.Controls.Add(this.lblAmount);
            this.gbSearchForParts.Controls.Add(this.cbPartName);
            this.gbSearchForParts.Controls.Add(this.lblPartName);
            this.gbSearchForParts.Controls.Add(this.cbWarehouse);
            this.gbSearchForParts.Controls.Add(this.lblWarehouse);
            this.gbSearchForParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchForParts.Location = new System.Drawing.Point(0, 60);
            this.gbSearchForParts.Name = "gbSearchForParts";
            this.gbSearchForParts.Size = new System.Drawing.Size(800, 92);
            this.gbSearchForParts.TabIndex = 4;
            this.gbSearchForParts.TabStop = false;
            this.gbSearchForParts.Text = "gbSearchForParts";
            // 
            // btnAllocate
            // 
            this.btnAllocate.Enabled = false;
            this.btnAllocate.Location = new System.Drawing.Point(701, 57);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(75, 23);
            this.btnAllocate.TabIndex = 16;
            this.btnAllocate.Text = "btnAllocate";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // cbAllocationMethod
            // 
            this.cbAllocationMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllocationMethod.FormattingEnabled = true;
            this.cbAllocationMethod.Items.AddRange(new object[] {
            "FIFO (First in First Out)",
            "LIFO (Last in First Out)",
            "Minimum First"});
            this.cbAllocationMethod.Location = new System.Drawing.Point(515, 57);
            this.cbAllocationMethod.Name = "cbAllocationMethod";
            this.cbAllocationMethod.Size = new System.Drawing.Size(160, 21);
            this.cbAllocationMethod.TabIndex = 15;
            // 
            // lblAllocationMethod
            // 
            this.lblAllocationMethod.AutoSize = true;
            this.lblAllocationMethod.Location = new System.Drawing.Point(410, 57);
            this.lblAllocationMethod.Name = "lblAllocationMethod";
            this.lblAllocationMethod.Size = new System.Drawing.Size(99, 13);
            this.lblAllocationMethod.TabIndex = 14;
            this.lblAllocationMethod.Text = "lblAllocationMethod";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(304, 54);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 13;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(244, 57);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 13);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "lblAmount";
            // 
            // cbPartName
            // 
            this.cbPartName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartName.FormattingEnabled = true;
            this.cbPartName.Location = new System.Drawing.Point(97, 54);
            this.cbPartName.Name = "cbPartName";
            this.cbPartName.Size = new System.Drawing.Size(140, 21);
            this.cbPartName.TabIndex = 11;
            this.cbPartName.SelectedIndexChanged += new System.EventHandler(this.cbPartName_SelectedIndexChanged);
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(19, 54);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(64, 13);
            this.lblPartName.TabIndex = 10;
            this.lblPartName.Text = "lblPartName";
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouse.FormattingEnabled = true;
            this.cbWarehouse.Location = new System.Drawing.Point(100, 19);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(234, 21);
            this.cbWarehouse.TabIndex = 9;
            this.cbWarehouse.SelectedIndexChanged += new System.EventHandler(this.cbWarehouse_SelectedIndexChanged);
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(22, 19);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(72, 13);
            this.lblWarehouse.TabIndex = 5;
            this.lblWarehouse.Text = "lblWarehouse";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblDate);
            this.panelTop.Controls.Add(this.dtpDate);
            this.panelTop.Controls.Add(this.cbAssetNumberEMNumber);
            this.panelTop.Controls.Add(this.lblAssetNumberEMNumber);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 60);
            this.panelTop.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(444, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "lblDate";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(499, 14);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 6;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // cbAssetNumberEMNumber
            // 
            this.cbAssetNumberEMNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssetNumberEMNumber.FormattingEnabled = true;
            this.cbAssetNumberEMNumber.Location = new System.Drawing.Point(162, 14);
            this.cbAssetNumberEMNumber.Name = "cbAssetNumberEMNumber";
            this.cbAssetNumberEMNumber.Size = new System.Drawing.Size(234, 21);
            this.cbAssetNumberEMNumber.TabIndex = 5;
            this.cbAssetNumberEMNumber.SelectedIndexChanged += new System.EventHandler(this.cbAssetNumberEMNumber_SelectedIndexChanged);
            // 
            // lblAssetNumberEMNumber
            // 
            this.lblAssetNumberEMNumber.AutoSize = true;
            this.lblAssetNumberEMNumber.Location = new System.Drawing.Point(22, 14);
            this.lblAssetNumberEMNumber.Name = "lblAssetNumberEMNumber";
            this.lblAssetNumberEMNumber.Size = new System.Drawing.Size(133, 13);
            this.lblAssetNumberEMNumber.TabIndex = 4;
            this.lblAssetNumberEMNumber.Text = "lblAssetNumberEMNumber";
            // 
            // gbAllocatedParts
            // 
            this.gbAllocatedParts.Controls.Add(this.dgvAllocatedParts);
            this.gbAllocatedParts.Controls.Add(this.panel1);
            this.gbAllocatedParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAllocatedParts.Location = new System.Drawing.Point(0, 152);
            this.gbAllocatedParts.Name = "gbAllocatedParts";
            this.gbAllocatedParts.Size = new System.Drawing.Size(800, 164);
            this.gbAllocatedParts.TabIndex = 6;
            this.gbAllocatedParts.TabStop = false;
            this.gbAllocatedParts.Text = "gbAllocatedParts";
            // 
            // dgvAllocatedParts
            // 
            this.dgvAllocatedParts.AllowUserToAddRows = false;
            this.dgvAllocatedParts.AllowUserToDeleteRows = false;
            this.dgvAllocatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllocatedParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName,
            this.BatchNumber,
            this.UnitPrice,
            this.Amount});
            this.dgvAllocatedParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllocatedParts.Location = new System.Drawing.Point(3, 16);
            this.dgvAllocatedParts.Name = "dgvAllocatedParts";
            this.dgvAllocatedParts.ReadOnly = true;
            this.dgvAllocatedParts.Size = new System.Drawing.Size(675, 145);
            this.dgvAllocatedParts.TabIndex = 0;
            // 
            // PartName
            // 
            this.PartName.DataPropertyName = "PartName";
            this.PartName.HeaderText = "Part Name";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // BatchNumber
            // 
            this.BatchNumber.DataPropertyName = "BatchNumber";
            this.BatchNumber.HeaderText = "Batch Number";
            this.BatchNumber.Name = "BatchNumber";
            this.BatchNumber.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Format = "N0";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAssignToEM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(678, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 145);
            this.panel1.TabIndex = 1;
            // 
            // btnAssignToEM
            // 
            this.btnAssignToEM.Enabled = false;
            this.btnAssignToEM.Location = new System.Drawing.Point(11, 17);
            this.btnAssignToEM.Name = "btnAssignToEM";
            this.btnAssignToEM.Size = new System.Drawing.Size(99, 23);
            this.btnAssignToEM.TabIndex = 17;
            this.btnAssignToEM.Text = "btnAssignToEM";
            this.btnAssignToEM.UseVisualStyleBackColor = true;
            this.btnAssignToEM.Click += new System.EventHandler(this.btnAssignToEM_Click);
            // 
            // gbAssignedParts
            // 
            this.gbAssignedParts.Controls.Add(this.dgvAssignedParts);
            this.gbAssignedParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAssignedParts.Location = new System.Drawing.Point(0, 316);
            this.gbAssignedParts.Name = "gbAssignedParts";
            this.gbAssignedParts.Size = new System.Drawing.Size(800, 137);
            this.gbAssignedParts.TabIndex = 7;
            this.gbAssignedParts.TabStop = false;
            this.gbAssignedParts.Text = "gbAssignedParts";
            // 
            // dgvAssignedParts
            // 
            this.dgvAssignedParts.AllowUserToAddRows = false;
            this.dgvAssignedParts.AllowUserToDeleteRows = false;
            this.dgvAssignedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName2,
            this.BatchNumber2,
            this.UnitPrice2,
            this.Amount2,
            this.Action2,
            this.PartID2});
            this.dgvAssignedParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignedParts.Location = new System.Drawing.Point(3, 16);
            this.dgvAssignedParts.Name = "dgvAssignedParts";
            this.dgvAssignedParts.ReadOnly = true;
            this.dgvAssignedParts.Size = new System.Drawing.Size(794, 118);
            this.dgvAssignedParts.TabIndex = 1;
            this.dgvAssignedParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignedParts_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 71);
            this.panel2.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(351, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(198, 24);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 23);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // PartName2
            // 
            this.PartName2.DataPropertyName = "PartName";
            this.PartName2.HeaderText = "Part Name";
            this.PartName2.Name = "PartName2";
            this.PartName2.ReadOnly = true;
            // 
            // BatchNumber2
            // 
            this.BatchNumber2.DataPropertyName = "BatchNumber";
            this.BatchNumber2.HeaderText = "Batch Number";
            this.BatchNumber2.Name = "BatchNumber2";
            this.BatchNumber2.ReadOnly = true;
            // 
            // UnitPrice2
            // 
            this.UnitPrice2.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle3.Format = "N0";
            this.UnitPrice2.DefaultCellStyle = dataGridViewCellStyle3;
            this.UnitPrice2.HeaderText = "Unit Price";
            this.UnitPrice2.Name = "UnitPrice2";
            this.UnitPrice2.ReadOnly = true;
            // 
            // Amount2
            // 
            this.Amount2.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Format = "N0";
            this.Amount2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Amount2.HeaderText = "Amount";
            this.Amount2.Name = "Amount2";
            this.Amount2.ReadOnly = true;
            // 
            // Action2
            // 
            this.Action2.HeaderText = "Action";
            this.Action2.Name = "Action2";
            this.Action2.ReadOnly = true;
            this.Action2.Text = "Remove";
            this.Action2.UseColumnTextForLinkValue = true;
            // 
            // PartID2
            // 
            this.PartID2.DataPropertyName = "PartID";
            this.PartID2.HeaderText = "PartID";
            this.PartID2.Name = "PartID2";
            this.PartID2.ReadOnly = true;
            this.PartID2.Visible = false;
            // 
            // frmInventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.gbAssignedParts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbAllocatedParts);
            this.Controls.Add(this.gbSearchForParts);
            this.Controls.Add(this.panelTop);
            this.Name = "frmInventoryControl";
            this.Text = "frmInventoryControl";
            this.Load += new System.EventHandler(this.frmInventoryControl_Load);
            this.gbSearchForParts.ResumeLayout(false);
            this.gbSearchForParts.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.gbAllocatedParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocatedParts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbAssignedParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedParts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchForParts;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbAssetNumberEMNumber;
        private System.Windows.Forms.Label lblAssetNumberEMNumber;
        private System.Windows.Forms.GroupBox gbAllocatedParts;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cbPartName;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.ComboBox cbWarehouse;
        private System.Windows.Forms.ComboBox cbAllocationMethod;
        private System.Windows.Forms.Label lblAllocationMethod;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAssignToEM;
        private System.Windows.Forms.DataGridView dgvAllocatedParts;
        private System.Windows.Forms.GroupBox gbAssignedParts;
        private System.Windows.Forms.DataGridView dgvAssignedParts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount2;
        private System.Windows.Forms.DataGridViewLinkColumn Action2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID2;
    }
}