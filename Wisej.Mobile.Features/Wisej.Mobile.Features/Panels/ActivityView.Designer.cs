namespace Wisej.Mobile.Features.Panels
{
	partial class ActivityView
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
			this.buttonActivity = new Wisej.Web.Button();
			this.label1 = new Wisej.Web.Label();
			this.buttonText = new Wisej.Web.Button();
			this.buttonURL = new Wisej.Web.Button();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.spacer3 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonActivity
			// 
			this.buttonActivity.Dock = Wisej.Web.DockStyle.Top;
			this.buttonActivity.Location = new System.Drawing.Point(16, 226);
			this.buttonActivity.Name = "buttonActivity";
			this.buttonActivity.Size = new System.Drawing.Size(618, 40);
			this.buttonActivity.TabIndex = 0;
			this.buttonActivity.Text = "Show Activity View (Image)";
			this.buttonActivity.Click += new System.EventHandler(this.buttonImage_Click);
			// 
			// label1
			// 
			this.label1.Dock = Wisej.Web.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(16, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(618, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "iOS Only";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonText
			// 
			this.buttonText.Dock = Wisej.Web.DockStyle.Top;
			this.buttonText.Location = new System.Drawing.Point(16, 166);
			this.buttonText.Name = "buttonText";
			this.buttonText.Size = new System.Drawing.Size(618, 40);
			this.buttonText.TabIndex = 2;
			this.buttonText.Text = "Show Activity View (Text)";
			this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
			// 
			// buttonURL
			// 
			this.buttonURL.Dock = Wisej.Web.DockStyle.Top;
			this.buttonURL.Location = new System.Drawing.Point(16, 286);
			this.buttonURL.Name = "buttonURL";
			this.buttonURL.Size = new System.Drawing.Size(618, 40);
			this.buttonURL.TabIndex = 3;
			this.buttonURL.Text = "Show Activity View (URL)";
			this.buttonURL.Click += new System.EventHandler(this.buttonURL_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 146);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 206);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer3
			// 
			this.spacer3.Dock = Wisej.Web.DockStyle.Top;
			this.spacer3.Location = new System.Drawing.Point(16, 266);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new System.Drawing.Size(618, 20);
			// 
			// ActivityView
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonURL);
			this.Controls.Add(this.spacer3);
			this.Controls.Add(this.buttonActivity);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.buttonText);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.label1);
			this.Name = "ActivityView";
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonText, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.buttonActivity, 0);
			this.Controls.SetChildIndex(this.spacer3, 0);
			this.Controls.SetChildIndex(this.buttonURL, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonActivity;
		private Web.Label label1;
		private Web.Button buttonText;
		private Web.Button buttonURL;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
		private Web.Spacer spacer3;
	}
}
