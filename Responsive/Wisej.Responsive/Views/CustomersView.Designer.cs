namespace Wisej.Responsive.Views
{
	partial class CustomersView
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
			this.dataGridView1 = new Wisej.Web.DataGridView();
			this.Column3 = new Wisej.Web.DataGridViewButtonColumn();
			this.colName = new Wisej.Web.DataGridViewColumn();
			this.colLastName = new Wisej.Web.DataGridViewColumn();
			this.colPurchases = new Wisej.Web.DataGridViewColumn();
			this.toolBar1 = new Wisej.Web.ToolBar();
			this.toolBarButton1 = new Wisej.Web.ToolBarButton();
			this.toolBarButton2 = new Wisej.Web.ToolBarButton();
			this.toolBarButton3 = new Wisej.Web.ToolBarButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.Column3,
            this.colName,
            this.colLastName,
            this.colPurchases});
			this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 82);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersMinimumWidth = 2;
			this.dataGridView1.Size = new System.Drawing.Size(740, 560);
			this.dataGridView1.TabIndex = 2;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Column3";
			this.Column3.Name = "Column3";
			this.Column3.Text = "Edit";
			this.Column3.UseColumnTextForButtonValue = true;
			// 
			// colName
			// 
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			this.colName.Width = 200;
			// 
			// colLastName
			// 
			this.colLastName.HeaderText = "Last Name";
			this.colLastName.Name = "colLastName";
			this.colLastName.Width = 200;
			// 
			// colPurchases
			// 
			this.colPurchases.HeaderText = "Purchases";
			this.colPurchases.Name = "colPurchases";
			this.colPurchases.Width = 150;
			// 
			// toolBar1
			// 
			this.toolBar1.BackColor = System.Drawing.Color.Transparent;
			this.toolBar1.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3});
			this.toolBar1.Location = new System.Drawing.Point(0, 33);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Size = new System.Drawing.Size(740, 49);
			this.toolBar1.TabIndex = 3;
			this.toolBar1.TabStop = false;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/add-user-button.svg";
			this.toolBarButton1.Margin = new Wisej.Web.Padding(5, 0, 5, 0);
			this.toolBarButton1.Name = "toolBarButton1";
			this.toolBarButton1.Padding = new Wisej.Web.Padding(5);
			this.toolBarButton1.Text = "New";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/close-button.svg";
			this.toolBarButton2.Margin = new Wisej.Web.Padding(5, 0, 5, 0);
			this.toolBarButton2.Name = "toolBarButton2";
			this.toolBarButton2.Padding = new Wisej.Web.Padding(5);
			this.toolBarButton2.Text = "Delete";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/searching-magnifying-glass.svg";
			this.toolBarButton3.Margin = new Wisej.Web.Padding(5, 0, 5, 0);
			this.toolBarButton3.Name = "toolBarButton3";
			this.toolBarButton3.Padding = new Wisej.Web.Padding(5);
			this.toolBarButton3.Text = "Search";
			// 
			// CustomersView
			// 
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.toolBar1);
			this.Name = "CustomersView";
			this.Title = "Customers";
			this.Controls.SetChildIndex(this.toolBar1, 0);
			this.Controls.SetChildIndex(this.dataGridView1, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.DataGridView dataGridView1;
		private Web.DataGridViewButtonColumn Column3;
		private Web.DataGridViewColumn colName;
		private Web.DataGridViewColumn colLastName;
		private Web.DataGridViewColumn colPurchases;
		private Web.ToolBar toolBar1;
		private Web.ToolBarButton toolBarButton1;
		private Web.ToolBarButton toolBarButton2;
		private Web.ToolBarButton toolBarButton3;
	}
}
