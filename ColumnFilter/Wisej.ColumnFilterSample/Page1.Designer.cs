namespace Wisej.ColumnFilterSample
{
	partial class Page1
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new Wisej.Web.Label();
			this.dataGridView1 = new Wisej.Web.DataGridView();
			this.Column0 = new Wisej.Web.DataGridViewTextBoxColumn();
			this.Column1 = new Wisej.Web.DataGridViewTextBoxColumn();
			this.Column2 = new Wisej.Web.DataGridViewTextBoxColumn();
			this.Column3 = new Wisej.Web.DataGridViewTextBoxColumn();
			this.Column4 = new Wisej.Web.DataGridViewCheckBoxColumn();
			this.SimpleColumnFilter = new Wisej.Web.Ext.ColumnFilter.ColumnFilter(this.components);
			this.WhereColumnFilter = new Wisej.Web.Ext.ColumnFilter.ColumnFilter(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SimpleColumnFilter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WhereColumnFilter)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AllowHtml = true;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "<big>Wisej ColumnFilter sample</big>";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dataGridView1.Location = new System.Drawing.Point(23, 79);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(868, 432);
			this.dataGridView1.TabIndex = 1;
			// 
			// Column0
			// 
			this.Column0.HeaderText = "Name";
			this.Column0.Name = "Column0";
			this.SimpleColumnFilter.SetShowFilter(this.Column0, true);
			this.Column0.ValueType = typeof(string);
			this.Column0.Width = 200;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Last Name";
			this.Column1.Name = "Column1";
			this.WhereColumnFilter.SetShowFilter(this.Column1, true);
			this.Column1.ValueType = typeof(string);
			this.Column1.Width = 200;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Birth Date";
			this.Column2.Name = "Column2";
			this.WhereColumnFilter.SetShowFilter(this.Column2, true);
			this.Column2.ValueType = typeof(System.DateTime);
			this.Column2.Width = 200;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "ID";
			this.Column3.Name = "Column3";
			this.WhereColumnFilter.SetShowFilter(this.Column3, true);
			this.Column3.ValueType = typeof(int);
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Active";
			this.Column4.Name = "Column4";
			this.SimpleColumnFilter.SetShowFilter(this.Column4, true);
			this.Column4.ValueType = typeof(bool);
			// 
			// SimpleColumnFilter
			// 
			this.SimpleColumnFilter.FilteredImageSource = "icon-search?color=#FF1700";
			this.SimpleColumnFilter.FilterPanelType = typeof(Wisej.Web.Ext.ColumnFilter.SimpleColumnFilterPanel);
			this.SimpleColumnFilter.ImageSource = "icon-search";
			// 
			// WhereColumnFilter
			// 
			this.WhereColumnFilter.FilteredImageSource = "table-row-editing?color=#FF1700";
			this.WhereColumnFilter.FilterPanelType = typeof(Wisej.Web.Ext.ColumnFilter.WhereColumnFilterPanel);
			this.WhereColumnFilter.ImageSource = "table-row-editing";
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1221, 720);
			this.Text = "Page1";
			this.Load += new System.EventHandler(this.Page1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SimpleColumnFilter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WhereColumnFilter)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Label label1;
		private Web.DataGridView dataGridView1;
		private Web.DataGridViewTextBoxColumn Column0;
		private Web.DataGridViewTextBoxColumn Column1;
		private Web.DataGridViewTextBoxColumn Column2;
		private Web.DataGridViewTextBoxColumn Column3;
		private Web.Ext.ColumnFilter.ColumnFilter SimpleColumnFilter;
		private Web.Ext.ColumnFilter.ColumnFilter WhereColumnFilter;
		private Web.DataGridViewCheckBoxColumn Column4;
	}
}

