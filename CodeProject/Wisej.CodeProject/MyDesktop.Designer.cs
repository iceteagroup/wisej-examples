namespace Wisej.CodeProject
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
			this.bingWallpaper = new Wisej.Web.Ext.BingWallpaper.BingWallpaper(this.components);
			this.desktopStart = new Wisej.Web.DesktopTaskBarItem();
			this.desktopDateTime = new Wisej.Web.DesktopTaskBarItemDateTime();
			this.justGage1 = new Wisej.Web.Ext.JustGage.JustGage();
			this.desktopCPU = new Wisej.Web.DesktopTaskBarItemControl();
			this.coolClock1 = new Wisej.Web.Ext.CoolClock.CoolClock();
			this.speechSynthesis = new Wisej.Web.Ext.Speech.SpeechSynthesis();
			this.SuspendLayout();
			// 
			// desktopStart
			// 
			this.desktopStart.ImageSource = "icon-preview";
			this.desktopStart.Name = "desktopStart";
			this.desktopStart.ToolTipText = "Start";
			// 
			// desktopDateTime
			// 
			this.desktopDateTime.Name = "desktopDateTime";
			// 
			// justGage1
			// 
			this.justGage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.justGage1.ForeColor = System.Drawing.Color.White;
			this.justGage1.Label = null;
			this.justGage1.Location = new System.Drawing.Point(957, 629);
			this.justGage1.Name = "justGage1";
			this.justGage1.ShowMinMax = false;
			this.justGage1.ShowPointer = true;
			this.justGage1.Size = new System.Drawing.Size(60, 60);
			this.justGage1.Symbol = "%";
			this.justGage1.TabIndex = 0;
			this.justGage1.Text = "CPU%";
			this.justGage1.Value = 50F;
			this.justGage1.ValueColor = System.Drawing.Color.White;
			this.justGage1.Click += new System.EventHandler(this.justGage1_Click);
			// 
			// desktopCPU
			// 
			this.desktopCPU.Control = this.justGage1;
			this.desktopCPU.Name = "desktopCPU";
			this.desktopCPU.Position = Wisej.Web.LeftRightAlignment.Right;
			// 
			// coolClock1
			// 
			this.coolClock1.AppearanceKey = "coolclock";
			this.coolClock1.BackColor = System.Drawing.Color.Transparent;
			this.coolClock1.Location = new System.Drawing.Point(33, 32);
			this.coolClock1.Name = "coolClock1";
			this.coolClock1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
			this.coolClock1.Size = new System.Drawing.Size(104, 103);
			this.coolClock1.Skin = Wisej.Web.Ext.CoolClock.CoolClockSkin.Fancy;
			this.coolClock1.TabIndex = 0;
			this.coolClock1.Text = "coolClock1";
			// 
			// MyDesktop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.coolClock1);
			this.Items.AddRange(new Wisej.Web.DesktopTaskBarItem[] {
            this.desktopStart,
            this.desktopCPU,
            this.desktopDateTime});
			this.Name = "MyDesktop";
			this.Size = new System.Drawing.Size(1308, 791);
			this.Load += new System.EventHandler(this.MyDesktop_Load);
			this.ItemClick += new Wisej.Web.DesktopTaskBarItemClickEventHandler(this.MyDesktop_ItemClick);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.BingWallpaper.BingWallpaper bingWallpaper;
		private Web.DesktopTaskBarItem desktopStart;
		private Web.DesktopTaskBarItemDateTime desktopDateTime;
		private Web.DesktopTaskBarItemControl desktopCPU;
		private Web.Ext.JustGage.JustGage justGage1;
		private Web.Ext.CoolClock.CoolClock coolClock1;
		private Web.Ext.Speech.SpeechSynthesis speechSynthesis;
	}
}
