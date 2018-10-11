namespace Wisej.Pannellum
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
			this.panel1 = new Wisej.Web.Panel();
			this.button5 = new Wisej.Web.Button();
			this.button4 = new Wisej.Web.Button();
			this.button3 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.button1 = new Wisej.Web.Button();
			this.pannellum1 = new Wisej.Web.Ext.Pannellum.Pannellum();
			this.panel2 = new Wisej.Web.Panel();
			this.panel3 = new Wisej.Web.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoShow = Wisej.Web.PanelAutoShowMode.OnPointerOver;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
			this.panel1.CollapseSide = Wisej.Web.HeaderPosition.Left;
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = Wisej.Web.DockStyle.Left;
			this.panel1.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center;
			this.panel1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.panel1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.panel1.HeaderSize = 48;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(157, 874);
			this.panel1.TabIndex = 0;
			this.panel1.Text = "Examples";
			// 
			// button5
			// 
			this.button5.Dock = Wisej.Web.DockStyle.Top;
			this.button5.Location = new System.Drawing.Point(0, 256);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(157, 64);
			this.button5.TabIndex = 4;
			this.button5.Text = "Mutlires";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Dock = Wisej.Web.DockStyle.Top;
			this.button4.Location = new System.Drawing.Point(0, 192);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(157, 64);
			this.button4.TabIndex = 3;
			this.button4.Text = "Hot spots";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Dock = Wisej.Web.DockStyle.Top;
			this.button3.Location = new System.Drawing.Point(0, 128);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(157, 64);
			this.button3.TabIndex = 2;
			this.button3.Text = "Cube Map";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Dock = Wisej.Web.DockStyle.Top;
			this.button2.Location = new System.Drawing.Point(0, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(157, 64);
			this.button2.TabIndex = 1;
			this.button2.Text = "Auto Rotate";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Dock = Wisej.Web.DockStyle.Top;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 64);
			this.button1.TabIndex = 0;
			this.button1.Text = "Simple";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pannellum1
			// 
			this.pannellum1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.pannellum1.Dock = Wisej.Web.DockStyle.Fill;
			this.pannellum1.Location = new System.Drawing.Point(5, 5);
			this.pannellum1.Name = "pannellum1";
			this.pannellum1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("pannellum1.Options"))));
			this.pannellum1.Size = new System.Drawing.Size(1036, 864);
			this.pannellum1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Dock = Wisej.Web.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1203, 874);
			this.panel2.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.pannellum1);
			this.panel3.Dock = Wisej.Web.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(157, 0);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new Wisej.Web.Padding(5);
			this.panel3.Size = new System.Drawing.Size(1046, 874);
			this.panel3.TabIndex = 1;
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1203, 874);
			this.Text = "Page1";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Panel panel1;
		private Web.Button button1;
		private Web.Ext.Pannellum.Pannellum pannellum1;
		private Web.Button button4;
		private Web.Button button3;
		private Web.Button button2;
		private Web.Button button5;
		private Web.Panel panel2;
		private Web.Panel panel3;
	}
}

