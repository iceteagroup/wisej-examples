namespace Wisej.Mobile.Features.Panels
{
	partial class Permissions
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
			this.buttonCamera = new Wisej.Web.Button();
			this.buttonPhoto = new Wisej.Web.Button();
			this.buttonLocation = new Wisej.Web.Button();
			this.buttonMicrophone = new Wisej.Web.Button();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.spacer3 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonCamera
			// 
			this.buttonCamera.Dock = Wisej.Web.DockStyle.Top;
			this.buttonCamera.Location = new System.Drawing.Point(16, 128);
			this.buttonCamera.Name = "buttonCamera";
			this.buttonCamera.Size = new System.Drawing.Size(618, 40);
			this.buttonCamera.TabIndex = 0;
			this.buttonCamera.Text = "Camera";
			this.buttonCamera.Click += new System.EventHandler(this.button_Click);
			// 
			// buttonPhoto
			// 
			this.buttonPhoto.Dock = Wisej.Web.DockStyle.Top;
			this.buttonPhoto.Location = new System.Drawing.Point(16, 188);
			this.buttonPhoto.Name = "buttonPhoto";
			this.buttonPhoto.Size = new System.Drawing.Size(618, 40);
			this.buttonPhoto.TabIndex = 1;
			this.buttonPhoto.Text = "Photos";
			this.buttonPhoto.Click += new System.EventHandler(this.button_Click);
			// 
			// buttonLocation
			// 
			this.buttonLocation.Dock = Wisej.Web.DockStyle.Top;
			this.buttonLocation.Location = new System.Drawing.Point(16, 248);
			this.buttonLocation.Name = "buttonLocation";
			this.buttonLocation.Size = new System.Drawing.Size(618, 40);
			this.buttonLocation.TabIndex = 2;
			this.buttonLocation.Text = "Location";
			this.buttonLocation.Click += new System.EventHandler(this.button_Click);
			// 
			// buttonMicrophone
			// 
			this.buttonMicrophone.Dock = Wisej.Web.DockStyle.Top;
			this.buttonMicrophone.Location = new System.Drawing.Point(16, 308);
			this.buttonMicrophone.Name = "buttonMicrophone";
			this.buttonMicrophone.Size = new System.Drawing.Size(618, 40);
			this.buttonMicrophone.TabIndex = 3;
			this.buttonMicrophone.Text = "Microphone";
			this.buttonMicrophone.Click += new System.EventHandler(this.button_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 168);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 228);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer3
			// 
			this.spacer3.Dock = Wisej.Web.DockStyle.Top;
			this.spacer3.Location = new System.Drawing.Point(16, 288);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new System.Drawing.Size(618, 20);
			// 
			// Permissions
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonMicrophone);
			this.Controls.Add(this.spacer3);
			this.Controls.Add(this.buttonLocation);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.buttonPhoto);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.buttonCamera);
			this.MinimumSize = new System.Drawing.Size(350, 394);
			this.Name = "Permissions";
			this.Controls.SetChildIndex(this.buttonCamera, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonPhoto, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.buttonLocation, 0);
			this.Controls.SetChildIndex(this.spacer3, 0);
			this.Controls.SetChildIndex(this.buttonMicrophone, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonCamera;
		private Web.Button buttonPhoto;
		private Web.Button buttonLocation;
		private Web.Button buttonMicrophone;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
		private Web.Spacer spacer3;
	}
}
