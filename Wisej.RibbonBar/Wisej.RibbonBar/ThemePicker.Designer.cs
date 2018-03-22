namespace Wisej.RibbonBar
{
	partial class ThemePicker
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
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.pictureBox2 = new Wisej.Web.PictureBox();
			this.pictureBox3 = new Wisej.Web.PictureBox();
			this.pictureBox4 = new Wisej.Web.PictureBox();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox4);
			this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 70);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = Wisej.Web.Cursors.Hand;
			this.pictureBox1.ImageSource = "Images/Blue-1.png";
			this.pictureBox1.Location = new System.Drawing.Point(10, 10);
			this.pictureBox1.Margin = new Wisej.Web.Padding(10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 45);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Cursor = Wisej.Web.Cursors.Hand;
			this.pictureBox2.ImageSource = "Images/Clear-2.png";
			this.pictureBox2.Location = new System.Drawing.Point(94, 10);
			this.pictureBox2.Margin = new Wisej.Web.Padding(10);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(64, 45);
			this.pictureBox2.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Cursor = Wisej.Web.Cursors.Hand;
			this.pictureBox3.ImageSource = "Images/Material-3.png";
			this.pictureBox3.Location = new System.Drawing.Point(178, 10);
			this.pictureBox3.Margin = new Wisej.Web.Padding(10);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(64, 45);
			this.pictureBox3.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Cursor = Wisej.Web.Cursors.Hand;
			this.pictureBox4.ImageSource = "Images/Classic-2.png";
			this.pictureBox4.Location = new System.Drawing.Point(262, 10);
			this.pictureBox4.Margin = new Wisej.Web.Padding(10);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(64, 45);
			this.pictureBox4.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// ThemePicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "ThemePicker";
			this.Size = new System.Drawing.Size(340, 70);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.FlowLayoutPanel flowLayoutPanel1;
		private Web.PictureBox pictureBox1;
		private Web.PictureBox pictureBox2;
		private Web.PictureBox pictureBox3;
		private Web.PictureBox pictureBox4;
	}
}
