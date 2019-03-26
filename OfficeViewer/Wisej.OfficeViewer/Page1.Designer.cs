namespace Wisej.OfficeViewer
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
			this.panel1 = new Wisej.Web.Panel();
			this.button3 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.button1 = new Wisej.Web.Button();
			this.docViewer = new Wisej.Web.Ext.OfficeViewer.OfficeViewer();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = Wisej.Web.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new Wisej.Web.Padding(10);
			this.panel1.Size = new System.Drawing.Size(166, 803);
			this.panel1.TabIndex = 0;
			// 
			// button3
			// 
			this.button3.Dock = Wisej.Web.DockStyle.Top;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.ImageSource = "Images/powerpoint.svg";
			this.button3.Location = new System.Drawing.Point(10, 150);
			this.button3.Name = "button3";
			this.button3.Padding = new Wisej.Web.Padding(20, 0, 10, 0);
			this.button3.Size = new System.Drawing.Size(146, 70);
			this.button3.TabIndex = 2;
			this.button3.Text = "PowerPoint";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Dock = Wisej.Web.DockStyle.Top;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.ImageSource = "Images/excel.svg";
			this.button2.Location = new System.Drawing.Point(10, 80);
			this.button2.Name = "button2";
			this.button2.Padding = new Wisej.Web.Padding(20, 0, 10, 0);
			this.button2.Size = new System.Drawing.Size(146, 70);
			this.button2.TabIndex = 1;
			this.button2.Text = "Excel";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Dock = Wisej.Web.DockStyle.Top;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.ImageSource = "Images/word.svg";
			this.button1.Location = new System.Drawing.Point(10, 10);
			this.button1.Name = "button1";
			this.button1.Padding = new Wisej.Web.Padding(20, 0, 10, 0);
			this.button1.Size = new System.Drawing.Size(146, 70);
			this.button1.TabIndex = 0;
			this.button1.Text = "Word";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// docViewer
			// 
			this.docViewer.Dock = Wisej.Web.DockStyle.Fill;
			this.docViewer.Location = new System.Drawing.Point(166, 0);
			this.docViewer.Name = "docViewer";
			this.docViewer.Size = new System.Drawing.Size(1055, 803);
			this.docViewer.TabIndex = 1;
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.docViewer);
			this.Controls.Add(this.panel1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1221, 803);
			this.Text = "Page1";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Panel panel1;
		private Web.Ext.OfficeViewer.OfficeViewer docViewer;
		private Web.Button button3;
		private Web.Button button2;
		private Web.Button button1;
	}
}

