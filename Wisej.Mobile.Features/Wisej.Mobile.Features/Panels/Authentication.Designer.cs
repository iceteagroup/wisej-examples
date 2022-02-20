namespace Wisej.Mobile.Features.Panels
{
	partial class Authentication
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
			this.pictureBoxAuthenticate = new Wisej.Web.PictureBox();
			this.buttonAuthenticate = new Wisej.Web.Button();
			this.textBoxReason = new Wisej.Web.TextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthenticate)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxAuthenticate
			// 
			this.pictureBoxAuthenticate.Dock = Wisej.Web.DockStyle.Top;
			this.pictureBoxAuthenticate.Location = new System.Drawing.Point(16, 128);
			this.pictureBoxAuthenticate.Name = "pictureBoxAuthenticate";
			this.pictureBoxAuthenticate.Size = new System.Drawing.Size(618, 128);
			this.pictureBoxAuthenticate.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// buttonAuthenticate
			// 
			this.buttonAuthenticate.Dock = Wisej.Web.DockStyle.Top;
			this.buttonAuthenticate.Location = new System.Drawing.Point(16, 336);
			this.buttonAuthenticate.Name = "buttonAuthenticate";
			this.buttonAuthenticate.Size = new System.Drawing.Size(618, 40);
			this.buttonAuthenticate.TabIndex = 1;
			this.buttonAuthenticate.Text = "Authenticate";
			this.buttonAuthenticate.Click += new System.EventHandler(this.buttonAuthenticate_Click);
			// 
			// textBoxReason
			// 
			this.textBoxReason.AutoSize = false;
			this.textBoxReason.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxReason.Location = new System.Drawing.Point(16, 276);
			this.textBoxReason.Name = "textBoxReason";
			this.textBoxReason.Size = new System.Drawing.Size(618, 40);
			this.textBoxReason.TabIndex = 2;
			this.textBoxReason.Watermark = "Authentication Message";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 256);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 316);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// Authentication
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonAuthenticate);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.textBoxReason);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.pictureBoxAuthenticate);
			this.Name = "Authentication";
			this.Load += new System.EventHandler(this.Authentication_Load);
			this.Controls.SetChildIndex(this.pictureBoxAuthenticate, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.textBoxReason, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.buttonAuthenticate, 0);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthenticate)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.PictureBox pictureBoxAuthenticate;
		private Web.Button buttonAuthenticate;
		private Web.TextBox textBoxReason;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
	}
}
