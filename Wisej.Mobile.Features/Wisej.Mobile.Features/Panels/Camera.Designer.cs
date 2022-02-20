namespace Wisej.Mobile.Features.Panels
{
	partial class Camera
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
			this.pictureBoxImage = new Wisej.Web.PictureBox();
			this.buttonPicture = new Wisej.Web.Button();
			this.trackBarQuality = new Wisej.Web.TrackBar();
			this.label1 = new Wisej.Web.Label();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.pictureBoxImage.Dock = Wisej.Web.DockStyle.Top;
			this.pictureBoxImage.Location = new System.Drawing.Point(16, 128);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(618, 192);
			this.pictureBoxImage.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// buttonPicture
			// 
			this.buttonPicture.Dock = Wisej.Web.DockStyle.Top;
			this.buttonPicture.Location = new System.Drawing.Point(16, 414);
			this.buttonPicture.Name = "buttonPicture";
			this.buttonPicture.Size = new System.Drawing.Size(618, 40);
			this.buttonPicture.TabIndex = 0;
			this.buttonPicture.Text = "Take Picture";
			this.buttonPicture.Click += new System.EventHandler(this.buttonPicture_Click);
			// 
			// trackBarQuality
			// 
			this.trackBarQuality.Dock = Wisej.Web.DockStyle.Top;
			this.trackBarQuality.Location = new System.Drawing.Point(16, 360);
			this.trackBarQuality.Name = "trackBarQuality";
			this.trackBarQuality.Size = new System.Drawing.Size(618, 34);
			this.trackBarQuality.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = Wisej.Web.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(16, 340);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(618, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Compression Quality";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 320);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 394);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// Camera
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonPicture);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.trackBarQuality);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.pictureBoxImage);
			this.Name = "Camera";
			this.Controls.SetChildIndex(this.pictureBoxImage, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.trackBarQuality, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.buttonPicture, 0);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Web.PictureBox pictureBoxImage;
		private Web.Button buttonPicture;
		private Web.TrackBar trackBarQuality;
		private Web.Label label1;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
	}
}
