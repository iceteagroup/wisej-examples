namespace Wisej.DGVUserPaint
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
			this.label1 = new Wisej.Web.Label();
			this.dataGridView1 = new Wisej.Web.DataGridView();
			this.Column0 = new Wisej.Web.DataGridViewTextBoxColumn();
			this.Column2 = new Wisej.Web.DataGridViewComboBoxColumn();
			this.Column1 = new Wisej.Web.DataGridViewColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AllowHtml = true;
			this.label1.Location = new System.Drawing.Point(40, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(577, 116);
			this.label1.TabIndex = 0;
			this.label1.Text = "<span style=\"font-size:6em\">User Paint Cells</span>";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
			| Wisej.Web.AnchorStyles.Left) 
			| Wisej.Web.AnchorStyles.Right)));
			this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.Column0,
			this.Column2,
			this.Column1});
			this.dataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditOnEnter;
			this.dataGridView1.Location = new System.Drawing.Point(40, 178);
			this.dataGridView1.MinimumSize = new System.Drawing.Size(200, 450);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersMinimumWidth = 2;
			this.dataGridView1.Size = new System.Drawing.Size(806, 450);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
			this.dataGridView1.CellPaint += new Wisej.Web.DataGridViewCellPaintEventHandler(this.dataGridView1_CellPaint);
			// 
			// Column0
			// 
			this.Column0.HeaderText = "Values";
			this.Column0.Name = "Column0";
			this.Column0.Width = 300;
			// 
			// Column2
			// 
			this.Column2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.Column2.HeaderText = "Type";
			this.Column2.Items.AddRange(new object[] {
			"Bar",
			"Area",
			"Line",
			"Spline",
			"Column"});
			this.Column2.Name = "Column2";
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.HeaderText = "Sparkline";
			this.Column1.MinimumWidth = 100;
			this.Column1.Name = "Column1";
			this.Column1.UserPaint = true;
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
			this.BackgroundImageSource = "Images/background.jpg";
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1082, 874);
			this.Text = "Page1";
			this.Load += new System.EventHandler(this.Page1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Label label1;
		private Web.DataGridView dataGridView1;
		private Web.DataGridViewTextBoxColumn Column0;
		private Web.DataGridViewColumn Column1;
		private Web.DataGridViewComboBoxColumn Column2;
	}
}

