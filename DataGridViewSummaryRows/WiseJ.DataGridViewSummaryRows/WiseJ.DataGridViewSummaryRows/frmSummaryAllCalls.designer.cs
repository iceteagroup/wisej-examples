namespace WiseJ.DataGridViewSummaryRows
{
	partial class frmSummaryAllCalls
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            this.label1 = new Wisej.Web.Label();
            this.dataGrid = new Wisej.Web.DataGridView();
            this.buttonEdit = new Wisej.Web.Button();
            this.buttonAdd = new Wisej.Web.Button();
            this.btnLoadFromDataSource = new Wisej.Web.Button();
            this.btnLoadData = new Wisej.Web.Button();
            this.btnSummary1 = new Wisej.Web.Button();
            this.btnSummary2 = new Wisej.Web.Button();
            this.btnSummary3 = new Wisej.Web.Button();
            this.btnSummary4 = new Wisej.Web.Button();
            this.btnSummary8 = new Wisej.Web.Button();
            this.btnSummary7 = new Wisej.Web.Button();
            this.btnSummary6 = new Wisej.Web.Button();
            this.btnSummary5 = new Wisej.Web.Button();
            this.btnRemoveSumary = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Margin = new Wisej.Web.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Data:";
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.LiveResize = true;
            this.dataGrid.Location = new System.Drawing.Point(36, 176);
            this.dataGrid.Margin = new Wisej.Web.Padding(4, 3, 4, 3);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.ShowColumnVisibilityMenu = false;
            this.dataGrid.Size = new System.Drawing.Size(811, 390);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.buttonEdit.AppearanceKey = "button-ok";
            this.buttonEdit.Location = new System.Drawing.Point(779, 38);
            this.buttonEdit.Margin = new Wisej.Web.Padding(4, 3, 4, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(74, 43);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.buttonAdd.AppearanceKey = "button";
            this.buttonAdd.Location = new System.Drawing.Point(656, 38);
            this.buttonAdd.Margin = new Wisej.Web.Padding(4, 3, 4, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 43);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add New";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // btnLoadFromDataSource
            // 
            this.btnLoadFromDataSource.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadFromDataSource.Location = new System.Drawing.Point(173, 46);
            this.btnLoadFromDataSource.Name = "btnLoadFromDataSource";
            this.btnLoadFromDataSource.Size = new System.Drawing.Size(143, 35);
            this.btnLoadFromDataSource.TabIndex = 5;
            this.btnLoadFromDataSource.Text = "Load from DataSource";
            this.btnLoadFromDataSource.Click += new System.EventHandler(this.btnLoadFromDataSource_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadData.Location = new System.Drawing.Point(322, 46);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(143, 35);
            this.btnLoadData.TabIndex = 6;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnSummary1
            // 
            this.btnSummary1.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSummary1.Location = new System.Drawing.Point(36, 96);
            this.btnSummary1.Name = "btnSummary1";
            this.btnSummary1.Size = new System.Drawing.Size(105, 35);
            this.btnSummary1.TabIndex = 7;
            this.btnSummary1.Text = "Summary type 1";
            this.btnSummary1.Click += new System.EventHandler(this.btnSummary1_Click);
            // 
            // btnSummary2
            // 
            this.btnSummary2.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSummary2.Location = new System.Drawing.Point(144, 96);
            this.btnSummary2.Name = "btnSummary2";
            this.btnSummary2.Size = new System.Drawing.Size(105, 35);
            this.btnSummary2.TabIndex = 8;
            this.btnSummary2.Text = "Summary type 2";
            this.btnSummary2.Click += new System.EventHandler(this.btnSummary2_Click);
            // 
            // btnSummary3
            // 
            this.btnSummary3.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSummary3.Location = new System.Drawing.Point(252, 96);
            this.btnSummary3.Name = "btnSummary3";
            this.btnSummary3.Size = new System.Drawing.Size(105, 35);
            this.btnSummary3.TabIndex = 9;
            this.btnSummary3.Text = "Summary type 3";
            this.btnSummary3.Click += new System.EventHandler(this.btnSummary3_Click);
            // 
            // btnSummary4
            // 
            this.btnSummary4.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSummary4.Location = new System.Drawing.Point(360, 96);
            this.btnSummary4.Name = "btnSummary4";
            this.btnSummary4.Size = new System.Drawing.Size(105, 35);
            this.btnSummary4.TabIndex = 10;
            this.btnSummary4.Text = "Summary type 4";
            this.btnSummary4.Click += new System.EventHandler(this.btnSummary4_Click);
            // 
            // btnSummary8
            // 
            this.btnSummary8.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSummary8.Location = new System.Drawing.Point(360, 135);
            this.btnSummary8.Name = "btnSummary8";
            this.btnSummary8.Size = new System.Drawing.Size(105, 35);
            this.btnSummary8.TabIndex = 14;
            this.btnSummary8.Text = "Summary type 8";
            this.btnSummary8.Click += new System.EventHandler(this.btnSummary8_Click);
            // 
            // btnSummary7
            // 
            this.btnSummary7.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSummary7.Location = new System.Drawing.Point(252, 135);
            this.btnSummary7.Name = "btnSummary7";
            this.btnSummary7.Size = new System.Drawing.Size(105, 35);
            this.btnSummary7.TabIndex = 13;
            this.btnSummary7.Text = "Summary type 7";
            this.btnSummary7.Click += new System.EventHandler(this.btnSummary7_Click);
            // 
            // btnSummary6
            // 
            this.btnSummary6.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSummary6.Location = new System.Drawing.Point(144, 135);
            this.btnSummary6.Name = "btnSummary6";
            this.btnSummary6.Size = new System.Drawing.Size(105, 35);
            this.btnSummary6.TabIndex = 12;
            this.btnSummary6.Text = "Summary type 6";
            this.btnSummary6.Click += new System.EventHandler(this.btnSummary6_Click);
            // 
            // btnSummary5
            // 
            this.btnSummary5.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSummary5.Location = new System.Drawing.Point(36, 135);
            this.btnSummary5.Name = "btnSummary5";
            this.btnSummary5.Size = new System.Drawing.Size(105, 35);
            this.btnSummary5.TabIndex = 11;
            this.btnSummary5.Text = "Summary type 5";
            this.btnSummary5.Click += new System.EventHandler(this.btnSummary5_Click);
            // 
            // btnRemoveSumary
            // 
            this.btnRemoveSumary.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveSumary.Location = new System.Drawing.Point(471, 135);
            this.btnRemoveSumary.Name = "btnRemoveSumary";
            this.btnRemoveSumary.Size = new System.Drawing.Size(111, 35);
            this.btnRemoveSumary.TabIndex = 15;
            this.btnRemoveSumary.Text = "Remove Summary";
            this.btnRemoveSumary.Click += new System.EventHandler(this.btnRemoveSumary_Click);
            // 
            // frmSummaryAllCalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 593);
            this.Controls.Add(this.btnRemoveSumary);
            this.Controls.Add(this.btnSummary8);
            this.Controls.Add(this.btnSummary7);
            this.Controls.Add(this.btnSummary6);
            this.Controls.Add(this.btnSummary5);
            this.Controls.Add(this.btnSummary4);
            this.Controls.Add(this.btnSummary3);
            this.Controls.Add(this.btnSummary2);
            this.Controls.Add(this.btnSummary1);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnLoadFromDataSource);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Helvetica", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new Wisej.Web.Padding(9, 0, 9, 0);
            this.MinimizeBox = false;
            this.Name = "frmSummaryAllCalls";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Window1";
            this.Load += new System.EventHandler(this.Window1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Label label1;
		private Wisej.Web.DataGridView dataGrid;
		private Wisej.Web.Button buttonEdit;
		private Wisej.Web.Button buttonAdd;
        private Wisej.Web.Button btnLoadFromDataSource;
        private Wisej.Web.Button btnLoadData;
        private Wisej.Web.Button btnSummary1;
        private Wisej.Web.Button btnSummary2;
        private Wisej.Web.Button btnSummary3;
        private Wisej.Web.Button btnSummary4;
        private Wisej.Web.Button btnSummary8;
        private Wisej.Web.Button btnSummary7;
        private Wisej.Web.Button btnSummary6;
        private Wisej.Web.Button btnSummary5;
        private Wisej.Web.Button btnRemoveSumary;
    }
}

