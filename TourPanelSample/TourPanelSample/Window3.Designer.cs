namespace TourPanelSample
{
	partial class Window3
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
			Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
			this.dataGridView1 = new Wisej.Web.DataGridView();
			this.colID = new Wisej.Web.DataGridViewColumn();
			this.colFIRSTNAME = new Wisej.Web.DataGridViewColumn();
			this.colNAME = new Wisej.Web.DataGridViewColumn();
			this.colACTIVE = new Wisej.Web.DataGridViewCheckBoxColumn();
			this.colDEPARTMENT = new Wisej.Web.DataGridViewComboBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colID,
            this.colFIRSTNAME,
            this.colNAME,
            this.colACTIVE,
            this.colDEPARTMENT});
			this.dataGridView1.Location = new System.Drawing.Point(27, 27);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(594, 356);
			this.dataGridView1.TabIndex = 0;
			componentTool2.ImageSource = "spinner-plus";
			componentTool2.Position = Wisej.Web.LeftRightAlignment.Left;
			componentTool2.ToolTipText = "Add new row";
			this.dataGridView1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
			this.dataGridView1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.dataGridView1_ToolClick);
			// 
			// colID
			// 
			this.colID.HeaderText = "ID";
			this.colID.Name = "colID";
			this.colID.Width = 70;
			// 
			// colFIRSTNAME
			// 
			this.colFIRSTNAME.HeaderText = "First Name";
			this.colFIRSTNAME.Name = "colFIRSTNAME";
			this.colFIRSTNAME.Width = 200;
			// 
			// colNAME
			// 
			this.colNAME.HeaderText = "Name";
			this.colNAME.Name = "colNAME";
			this.colNAME.SortMode = Wisej.Web.DataGridViewColumnSortMode.Automatic;
			this.colNAME.Width = 200;
			// 
			// colACTIVE
			// 
			this.colACTIVE.HeaderText = "Active";
			this.colACTIVE.Name = "colACTIVE";
			this.colACTIVE.Width = 70;
			// 
			// colDEPARTMENT
			// 
			this.colDEPARTMENT.HeaderText = "Department";
			this.colDEPARTMENT.Items.AddRange(new object[] {
            "IT",
            "Finance",
            "Administration"});
			this.colDEPARTMENT.Name = "colDEPARTMENT";
			// 
			// Window3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 417);
			this.CloseBox = false;
			this.Controls.Add(this.dataGridView1);
			this.Location = new System.Drawing.Point(100, 100);
			this.Name = "Window3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Window3_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.DataGridView dataGridView1;
		private Wisej.Web.DataGridViewColumn colID;
		private Wisej.Web.DataGridViewColumn colFIRSTNAME;
		private Wisej.Web.DataGridViewColumn colNAME;
		private Wisej.Web.DataGridViewCheckBoxColumn colACTIVE;
		private Wisej.Web.DataGridViewComboBoxColumn colDEPARTMENT;
	}
}

