namespace UserDesktop
{
	partial class MyDesktop
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyDesktop));
			this.button1 = new Wisej.Web.Button();
			this.imageList1 = new Wisej.Web.ImageList(this.components);
			this.bingWallpaper = new Wisej.Web.Ext.BingWallpaper.BingWallpaper(this.components);
			this.themesPanel = new Wisej.Web.Panel();
			this.buttonTheme8 = new Wisej.Web.RadioButton();
			this.buttonTheme7 = new Wisej.Web.RadioButton();
			this.buttonTheme6 = new Wisej.Web.RadioButton();
			this.buttonTheme5 = new Wisej.Web.RadioButton();
			this.buttonTheme4 = new Wisej.Web.RadioButton();
			this.buttonTheme3 = new Wisej.Web.RadioButton();
			this.buttonTheme2 = new Wisej.Web.RadioButton();
			this.buttonTheme1 = new Wisej.Web.RadioButton();
			this.javaScript1 = new Wisej.Web.JavaScript(this.components);
			this.themesPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.AppearanceKey = "button-ok";
			this.button1.ImageList = this.imageList1;
			this.button1.ImageSource = "Images/Edit-File-32.png";
			this.button1.Location = new System.Drawing.Point(226, 39);
			this.button1.Movable = true;
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(151, 112);
			this.button1.TabIndex = 0;
			this.button1.Text = "Notepad";
			this.button1.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
			// 
			// themesPanel
			// 
			this.themesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.themesPanel.Controls.Add(this.buttonTheme8);
			this.themesPanel.Controls.Add(this.buttonTheme7);
			this.themesPanel.Controls.Add(this.buttonTheme6);
			this.themesPanel.Controls.Add(this.buttonTheme5);
			this.themesPanel.Controls.Add(this.buttonTheme4);
			this.themesPanel.Controls.Add(this.buttonTheme3);
			this.themesPanel.Controls.Add(this.buttonTheme2);
			this.themesPanel.Controls.Add(this.buttonTheme1);
			this.themesPanel.Dock = Wisej.Web.DockStyle.Left;
			this.themesPanel.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center;
			this.themesPanel.Location = new System.Drawing.Point(0, 0);
			this.themesPanel.Name = "themesPanel";
			this.themesPanel.ShowCloseButton = false;
			this.themesPanel.ShowHeader = true;
			this.themesPanel.Size = new System.Drawing.Size(165, 743);
			this.themesPanel.TabIndex = 1;
			this.themesPanel.Text = "Select Theme";
			// 
			// buttonTheme8
			// 
			this.buttonTheme8.AppearanceKey = "theme-button";
			this.buttonTheme8.AutoSize = false;
			this.buttonTheme8.Dock = Wisej.Web.DockStyle.Top;
			this.buttonTheme8.Location = new System.Drawing.Point(0, 280);
			this.buttonTheme8.Name = "buttonTheme8";
			this.buttonTheme8.Size = new System.Drawing.Size(165, 40);
			this.buttonTheme8.TabIndex = 7;
			this.buttonTheme8.TabStop = false;
			this.buttonTheme8.Text = "Material-3";
			this.buttonTheme8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonTheme8.CheckedChanged += new System.EventHandler(this.buttonTheme_CheckedChanged);
			// 
			// buttonTheme7
			// 
			this.buttonTheme7.AppearanceKey = "theme-button";
			this.buttonTheme7.AutoSize = false;
			this.buttonTheme7.Dock = Wisej.Web.DockStyle.Top;
			this.buttonTheme7.Location = new System.Drawing.Point(0, 240);
			this.buttonTheme7.Name = "buttonTheme7";
			this.buttonTheme7.Size = new System.Drawing.Size(165, 40);
			this.buttonTheme7.TabIndex = 6;
			this.buttonTheme7.TabStop = false;
			this.buttonTheme7.Text = "Classic-2";
			this.buttonTheme7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonTheme7.CheckedChanged += new System.EventHandler(this.buttonTheme_CheckedChanged);
			// 
			// buttonTheme6
			// 
			this.buttonTheme6.AppearanceKey = "theme-button";
			this.buttonTheme6.AutoSize = false;
			this.buttonTheme6.Dock = Wisej.Web.DockStyle.Top;
			this.buttonTheme6.Location = new System.Drawing.Point(0, 200);
			this.buttonTheme6.Name = "buttonTheme6";
			this.buttonTheme6.Size = new System.Drawing.Size(165, 40);
			this.buttonTheme6.TabIndex = 5;
			this.buttonTheme6.TabStop = false;
			this.buttonTheme6.Text = "Clear-3";
			this.buttonTheme6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonTheme6.CheckedChanged += new System.EventHandler(this.buttonTheme_CheckedChanged);
			// 
			// buttonTheme5
			// 
			this.buttonTheme5.AppearanceKey = "theme-button";
			this.buttonTheme5.AutoSize = false;
			this.buttonTheme5.Dock = Wisej.Web.DockStyle.Top;
			this.buttonTheme5.Location = new System.Drawing.Point(0, 160);
			this.buttonTheme5.Name = "buttonTheme5";
			this.buttonTheme5.Size = new System.Drawing.Size(165, 40);
			this.buttonTheme5.TabIndex = 4;
			this.buttonTheme5.TabStop = false;
			this.buttonTheme5.Text = "Clear-2";
			this.buttonTheme5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonTheme5.CheckedChanged += new System.EventHandler(this.buttonTheme_CheckedChanged);
			// 
			// buttonTheme4
			// 
			this.buttonTheme4.AppearanceKey = "theme-button";
			this.buttonTheme4.AutoSize = false;
			this.buttonTheme4.Dock = Wisej.Web.DockStyle.Top;
			this.buttonTheme4.Location = new System.Drawing.Point(0, 120);
			this.buttonTheme4.Name = "buttonTheme4";
			this.buttonTheme4.Size = new System.Drawing.Size(165, 40);
			this.buttonTheme4.TabIndex = 3;
			this.buttonTheme4.TabStop = false;
			this.buttonTheme4.Text = "Clear-1";
			this.buttonTheme4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonTheme4.CheckedChanged += new System.EventHandler(this.buttonTheme_CheckedChanged);
			// 
			// buttonTheme3
			// 
			this.buttonTheme3.AppearanceKey = "theme-button";
			this.buttonTheme3.AutoSize = false;
			this.buttonTheme3.Dock = Wisej.Web.DockStyle.Top;
			this.buttonTheme3.Location = new System.Drawing.Point(0, 80);
			this.buttonTheme3.Name = "buttonTheme3";
			this.buttonTheme3.Size = new System.Drawing.Size(165, 40);
			this.buttonTheme3.TabIndex = 2;
			this.buttonTheme3.TabStop = false;
			this.buttonTheme3.Text = "Blue-3";
			this.buttonTheme3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonTheme3.CheckedChanged += new System.EventHandler(this.buttonTheme_CheckedChanged);
			// 
			// buttonTheme2
			// 
			this.buttonTheme2.AppearanceKey = "theme-button";
			this.buttonTheme2.AutoSize = false;
			this.buttonTheme2.Dock = Wisej.Web.DockStyle.Top;
			this.buttonTheme2.Location = new System.Drawing.Point(0, 40);
			this.buttonTheme2.Name = "buttonTheme2";
			this.buttonTheme2.Size = new System.Drawing.Size(165, 40);
			this.buttonTheme2.TabIndex = 1;
			this.buttonTheme2.TabStop = false;
			this.buttonTheme2.Text = "Blue-2";
			this.buttonTheme2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonTheme2.CheckedChanged += new System.EventHandler(this.buttonTheme_CheckedChanged);
			// 
			// buttonTheme1
			// 
			this.buttonTheme1.AppearanceKey = "theme-button";
			this.buttonTheme1.AutoSize = false;
			this.buttonTheme1.Dock = Wisej.Web.DockStyle.Top;
			this.buttonTheme1.Location = new System.Drawing.Point(0, 0);
			this.buttonTheme1.Name = "buttonTheme1";
			this.buttonTheme1.Size = new System.Drawing.Size(165, 40);
			this.buttonTheme1.TabIndex = 0;
			this.buttonTheme1.TabStop = false;
			this.buttonTheme1.Text = "Blue-1";
			this.buttonTheme1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonTheme1.CheckedChanged += new System.EventHandler(this.buttonTheme_CheckedChanged);
			// 
			// MyDesktop
			// 
			this.Controls.Add(this.themesPanel);
			this.Controls.Add(this.button1);
			this.javaScript1.SetJavaScript(this, resources.GetString("$this.JavaScript"));
			this.Name = "MyDesktop";
			this.Size = new System.Drawing.Size(1432, 791);
			this.themesPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Button button1;
		private Wisej.Web.Ext.BingWallpaper.BingWallpaper bingWallpaper;
		private Wisej.Web.Panel themesPanel;
		private Wisej.Web.RadioButton buttonTheme8;
		private Wisej.Web.RadioButton buttonTheme7;
		private Wisej.Web.RadioButton buttonTheme6;
		private Wisej.Web.RadioButton buttonTheme5;
		private Wisej.Web.RadioButton buttonTheme4;
		private Wisej.Web.RadioButton buttonTheme3;
		private Wisej.Web.RadioButton buttonTheme2;
		private Wisej.Web.RadioButton buttonTheme1;
		private Wisej.Web.ImageList imageList1;
		private Wisej.Web.JavaScript javaScript1;
	}
}
