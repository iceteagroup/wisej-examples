
namespace WiseJ.DataGridViewSummaryRows
{
    partial class frmSummaryHugeData1
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMaster = new Wisej.Web.DataGridView();
            this.colVendorID = new Wisej.Web.DataGridViewColumn();
            this.colSubTotal = new Wisej.Web.DataGridViewColumn();
            this.colTaxAmt = new Wisej.Web.DataGridViewColumn();
            this.colFreight = new Wisej.Web.DataGridViewColumn();
            this.colTotalDue = new Wisej.Web.DataGridViewColumn();
            this.btnLoadData = new Wisej.Web.Button();
            this.btnAddSummaryRow = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.lblTotalDue = new Wisej.Web.Label();
            this.label6 = new Wisej.Web.Label();
            this.lblFreight = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.lblTaxAmnt = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.lblSubTotal = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.lblHeaderCount = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaster
            // 
            this.dgvMaster.AutoGenerateColumns = false;
            this.dgvMaster.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colVendorID,
            this.colSubTotal,
            this.colTaxAmt,
            this.colFreight,
            this.colTotalDue});
            this.dgvMaster.Dock = Wisej.Web.DockStyle.Top;
            this.dgvMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.Size = new System.Drawing.Size(1040, 345);
            this.dgvMaster.TabIndex = 1;
            // 
            // colVendorID
            // 
            this.colVendorID.DataPropertyName = "VendorID";
            this.colVendorID.HeaderText = "VendorID";
            this.colVendorID.Name = "colVendorID";
            // 
            // colSubTotal
            // 
            this.colSubTotal.DataPropertyName = "SubTotal";
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            // 
            // colTaxAmt
            // 
            this.colTaxAmt.DataPropertyName = "TaxAmt";
            this.colTaxAmt.HeaderText = "TaxAmount";
            this.colTaxAmt.Name = "colTaxAmt";
            // 
            // colFreight
            // 
            this.colFreight.DataPropertyName = "Freight";
            this.colFreight.HeaderText = "Freight";
            this.colFreight.Name = "colFreight";
            // 
            // colTotalDue
            // 
            this.colTotalDue.DataPropertyName = "TotalDue";
            this.colTotalDue.HeaderText = "TotalDue";
            this.colTotalDue.Name = "colTotalDue";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.btnLoadData.Location = new System.Drawing.Point(43, 368);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(177, 27);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnAddSummaryRow
            // 
            this.btnAddSummaryRow.Location = new System.Drawing.Point(43, 401);
            this.btnAddSummaryRow.Name = "btnAddSummaryRow";
            this.btnAddSummaryRow.Size = new System.Drawing.Size(177, 27);
            this.btnAddSummaryRow.TabIndex = 5;
            this.btnAddSummaryRow.Text = "Add Summary Total";
            this.btnAddSummaryRow.Click += new System.EventHandler(this.btnAddSummaryRow_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Summary by VendorID";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalDue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblFreight);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTaxAmnt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSubTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblHeaderCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(258, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 175);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.Text = "Just for compare with summary";
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Location = new System.Drawing.Point(135, 141);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(11, 15);
            this.lblTotalDue.TabIndex = 23;
            this.lblTotalDue.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "TotalDue: ";
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.Location = new System.Drawing.Point(135, 111);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(11, 15);
            this.lblFreight.TabIndex = 21;
            this.lblFreight.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Freight: ";
            // 
            // lblTaxAmnt
            // 
            this.lblTaxAmnt.AutoSize = true;
            this.lblTaxAmnt.Location = new System.Drawing.Point(135, 81);
            this.lblTaxAmnt.Name = "lblTaxAmnt";
            this.lblTaxAmnt.Size = new System.Drawing.Size(11, 15);
            this.lblTaxAmnt.TabIndex = 19;
            this.lblTaxAmnt.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "TaxAmount: ";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(135, 51);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(11, 15);
            this.lblSubTotal.TabIndex = 17;
            this.lblSubTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "SubTotal: ";
            // 
            // lblHeaderCount
            // 
            this.lblHeaderCount.AutoSize = true;
            this.lblHeaderCount.Location = new System.Drawing.Point(135, 21);
            this.lblHeaderCount.Name = "lblHeaderCount";
            this.lblHeaderCount.Size = new System.Drawing.Size(11, 15);
            this.lblHeaderCount.TabIndex = 15;
            this.lblHeaderCount.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rows count: ";
            // 
            // frmSummaryHugeData1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddSummaryRow);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dgvMaster);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSummaryHugeData1";
            this.Text = "Window1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataGridView dgvMaster;
        private Wisej.Web.Button btnLoadData;
        private Wisej.Web.Button btnAddSummaryRow;
        private Wisej.Web.DataGridViewColumn colSubTotal;
        private Wisej.Web.DataGridViewColumn colTaxAmt;
        private Wisej.Web.DataGridViewColumn colFreight;
        private Wisej.Web.DataGridViewColumn colTotalDue;
        private Wisej.Web.DataGridViewColumn colVendorID;
        private Wisej.Web.Button button1;
        private Wisej.Web.GroupBox groupBox1;
        private Wisej.Web.Label lblTotalDue;
        private Wisej.Web.Label label6;
        private Wisej.Web.Label lblFreight;
        private Wisej.Web.Label label5;
        private Wisej.Web.Label lblTaxAmnt;
        private Wisej.Web.Label label4;
        private Wisej.Web.Label lblSubTotal;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label lblHeaderCount;
        private Wisej.Web.Label label1;
    }
}

