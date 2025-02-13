namespace Wisej.ChatControl
{
	partial class MenuOptions
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
			this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
			this.button3 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.button1 = new Wisej.Web.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
			this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 40);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// button3
			// 
			this.button3.Dock = Wisej.Web.DockStyle.Fill;
			this.button3.Location = new System.Drawing.Point(231, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(108, 34);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.Click += new System.EventHandler(this.button_Click);
			// 
			// button2
			// 
			this.button2.Dock = Wisej.Web.DockStyle.Fill;
			this.button2.Location = new System.Drawing.Point(117, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(108, 34);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.Click += new System.EventHandler(this.button_Click);
			// 
			// button1
			// 
			this.button1.Dock = Wisej.Web.DockStyle.Fill;
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button_Click);
			// 
			// MenuOptions
			// 
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(300, 40);
			this.Name = "MenuOptions";
			this.Size = new System.Drawing.Size(342, 40);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.TableLayoutPanel tableLayoutPanel1;
		private Web.Button button3;
		private Web.Button button2;
		private Web.Button button1;
	}
}
