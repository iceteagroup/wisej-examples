namespace Wisej.Buttons
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
            Wisej.Web.ImageListEntry imageListEntry3 = new Wisej.Web.ImageListEntry("https://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/96/MetroUI-Apps-Ca" +
        "lculator-Alt-icon.png", "MetroUI-Calculator");
            Wisej.Web.ImageListEntry imageListEntry4 = new Wisej.Web.ImageListEntry("https://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/96/MetroUI-Apps-Bl" +
        "uetooth-icon.png", "MetroUI-Apps-Bluetooth-icon");
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.button3 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.button5 = new Wisej.Web.Button();
            this.button4 = new Wisej.Web.Button();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.groupBox4 = new Wisej.Web.GroupBox();
            this.button9 = new Wisej.Web.Button();
            this.button10 = new Wisej.Web.Button();
            this.groupBox5 = new Wisej.Web.GroupBox();
            this.button11 = new Wisej.Web.Button();
            this.imageList1 = new Wisej.Web.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(40, 40);
            this.groupBox1.Margin = new Wisej.Web.Padding(40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "Buttons with Image Resources (png)";
            this.groupBox1.UseMnemonic = false;
            // 
            // button3
            // 
            this.button3.Image = global::Wisej.Buttons.Properties.Resources.Error_64;
            this.button3.Location = new System.Drawing.Point(146, 32);
            this.button3.Name = "button3";
            this.button3.Padding = new Wisej.Web.Padding(0, 0, 0, 30);
            this.button3.Size = new System.Drawing.Size(238, 132);
            this.button3.TabIndex = 2;
            this.button3.Text = "ERROR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            // 
            // button2
            // 
            this.button2.Image = global::Wisej.Buttons.Properties.Resources.rss;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(17, 89);
            this.button2.Name = "button2";
            this.button2.Padding = new Wisej.Web.Padding(10, 10, 10, 11);
            this.button2.Size = new System.Drawing.Size(110, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Subscribe";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            // 
            // button1
            // 
            this.button1.Image = global::Wisej.Buttons.Properties.Resources.Ok_24;
            this.button1.Location = new System.Drawing.Point(17, 32);
            this.button1.Name = "button1";
            this.button1.Padding = new Wisej.Web.Padding(10, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(532, 40);
            this.groupBox2.Margin = new Wisej.Web.Padding(40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 191);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.Text = "Buttons with Background";
            this.groupBox2.UseMnemonic = false;
            // 
            // button5
            // 
            this.button5.AllowHtml = true;
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Wisej.Buttons.Properties.Resources.oval_background;
            this.button5.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(176, 36);
            this.button5.Name = "button5";
            this.button5.Padding = new Wisej.Web.Padding(10, 0, 10, 0);
            this.button5.Size = new System.Drawing.Size(218, 136);
            this.button5.TabIndex = 4;
            this.button5.Text = "<b>THIS IS</b><br/>\r\n<i>HTML TEXT</i>";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Wisej.Buttons.Properties.Resources.blank_glossy_round_button_pv;
            this.button4.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(17, 36);
            this.button4.Name = "button4";
            this.button4.Padding = new Wisej.Web.Padding(10, 0, 10, 0);
            this.button4.Size = new System.Drawing.Size(142, 136);
            this.button4.TabIndex = 3;
            this.button4.Text = "OK";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1027, 727);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Location = new System.Drawing.Point(40, 311);
            this.groupBox4.Margin = new Wisej.Web.Padding(40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 191);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.Text = "Buttons with Double Images";
            this.groupBox4.UseMnemonic = false;
            // 
            // button9
            // 
            this.button9.AllowHtml = true;
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = global::Wisej.Buttons.Properties.Resources.oval_background;
            this.button9.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.ImageSource = "icon-comment";
            this.button9.Location = new System.Drawing.Point(176, 36);
            this.button9.Name = "button9";
            this.button9.Padding = new Wisej.Web.Padding(10, 0, 30, 0);
            this.button9.Size = new System.Drawing.Size(218, 136);
            this.button9.TabIndex = 4;
            this.button9.Text = "<b>THIS IS</b><br/>\r\n<i>HTML TEXT</i>";
            this.button9.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImage = global::Wisej.Buttons.Properties.Resources.blank_glossy_round_button_pv;
            this.button10.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.button10.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.ImageSource = "ajax-loader";
            this.button10.Location = new System.Drawing.Point(17, 36);
            this.button10.Name = "button10";
            this.button10.Padding = new Wisej.Web.Padding(10, 0, 10, 0);
            this.button10.Size = new System.Drawing.Size(142, 136);
            this.button10.TabIndex = 3;
            this.button10.Text = "Load";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Location = new System.Drawing.Point(531, 311);
            this.groupBox5.Margin = new Wisej.Web.Padding(40);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(412, 191);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.Text = "Buttons with Image List";
            this.groupBox5.UseMnemonic = false;
            // 
            // button11
            // 
            this.button11.AppearanceKey = "button-alert";
            this.button11.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button11.ImageKey = "MetroUI-Calculator";
            this.button11.ImageList = this.imageList1;
            this.button11.Location = new System.Drawing.Point(18, 36);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(377, 132);
            this.button11.TabIndex = 2;
            this.button11.Text = "Image Size Set in Image List";
            this.button11.ToolTipText = "Click to change icon...";
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // imageList1
            // 
            this.imageList1.Images.AddRange(new Wisej.Web.ImageListEntry[] {
            imageListEntry3,
            imageListEntry4});
            this.imageList1.ImageSize = new System.Drawing.Size(96, 96);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1027, 727);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Button button1;
		private Web.GroupBox groupBox1;
		private Web.Button button2;
		private Web.Button button3;
		private Web.GroupBox groupBox2;
		private Web.Button button4;
		private Web.Button button5;
		private Web.FlowLayoutPanel flowLayoutPanel1;
		private Web.GroupBox groupBox4;
		private Web.Button button9;
		private Web.Button button10;
		private Web.GroupBox groupBox5;
		private Web.Button button11;
		private Web.ImageList imageList1;
	}
}
