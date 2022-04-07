namespace Wisej.CodeProject.Examples
{
	partial class CustomPainting
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
			this.mandelbrotPanel1 = new Wisej.CodeProject.Examples.MandelbrotPanel();
			this.panel1 = new Wisej.Web.Panel();
			this.panel2 = new Wisej.Web.Panel();
			this.canvas1 = new Wisej.Web.Canvas();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mandelbrotPanel1
			// 
			this.mandelbrotPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.mandelbrotPanel1.Focusable = false;
			this.mandelbrotPanel1.Location = new System.Drawing.Point(0, 0);
			this.mandelbrotPanel1.Name = "mandelbrotPanel1";
			this.mandelbrotPanel1.Size = new System.Drawing.Size(369, 373);
			this.mandelbrotPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.CollapseSide = Wisej.Web.HeaderPosition.Left;
			this.panel1.Controls.Add(this.mandelbrotPanel1);
			this.panel1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(63)))), ((int)(((byte)(191)))));
			this.panel1.HeaderSize = 38;
			this.panel1.Location = new System.Drawing.Point(24, 33);
			this.panel1.Name = "panel1";
			this.panel1.ShowCloseButton = false;
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(369, 411);
			this.panel1.TabIndex = 1;
			this.panel1.Text = "Mandelbrot";
			// 
			// panel2
			// 
			this.panel2.CollapseSide = Wisej.Web.HeaderPosition.Left;
			this.panel2.Controls.Add(this.canvas1);
			this.panel2.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
			this.panel2.HeaderSize = 38;
			this.panel2.Location = new System.Drawing.Point(425, 33);
			this.panel2.Name = "panel2";
			this.panel2.ShowCloseButton = false;
			this.panel2.ShowHeader = true;
			this.panel2.Size = new System.Drawing.Size(369, 411);
			this.panel2.TabIndex = 2;
			this.panel2.Text = "Canvas";
			// 
			// canvas1
			// 
			this.canvas1.Dock = Wisej.Web.DockStyle.Fill;
			this.canvas1.Location = new System.Drawing.Point(0, 0);
			this.canvas1.Name = "canvas1";
			this.canvas1.Size = new System.Drawing.Size(369, 373);
			this.canvas1.Redraw += new System.EventHandler(this.canvas1_Redraw);
			// 
			// CustomPainting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 477);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/painter-palette.svg?color=#00FCFF";
			this.Name = "CustomPainting";
			this.Text = "Custom Painting Example";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MandelbrotPanel mandelbrotPanel1;
		private Web.Panel panel1;
		private Web.Panel panel2;
		private Web.Canvas canvas1;
	}
}