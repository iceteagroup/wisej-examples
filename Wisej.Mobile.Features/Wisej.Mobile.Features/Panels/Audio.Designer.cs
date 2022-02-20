namespace Wisej.Mobile.Features.Panels
{
	partial class Audio
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
			this.buttonPlayAudio = new Wisej.Web.Button();
			this.label1 = new Wisej.Web.Label();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonPlayAudio
			// 
			this.buttonPlayAudio.Dock = Wisej.Web.DockStyle.Top;
			this.buttonPlayAudio.Location = new System.Drawing.Point(16, 168);
			this.buttonPlayAudio.Name = "buttonPlayAudio";
			this.buttonPlayAudio.Size = new System.Drawing.Size(618, 30);
			this.buttonPlayAudio.TabIndex = 0;
			this.buttonPlayAudio.Text = "Play Audio";
			this.buttonPlayAudio.Click += new System.EventHandler(this.buttonPlayAudio_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = Wisej.Web.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(16, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(618, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Make sure your device is off \"silent\" mode";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 148);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// Audio
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonPlayAudio);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.label1);
			this.Name = "Audio";
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonPlayAudio, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Button buttonPlayAudio;
		private Web.Label label1;
		private Web.Spacer spacer1;
	}
}
