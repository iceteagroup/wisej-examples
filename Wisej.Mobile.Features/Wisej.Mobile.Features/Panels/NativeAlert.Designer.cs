namespace Wisej.Mobile.Features.Panels
{
	partial class NativeAlert
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
			this.buttonShow = new Wisej.Web.Button();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.textBoxMessage = new Wisej.Web.TextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonShow
			// 
			this.buttonShow.Dock = Wisej.Web.DockStyle.Top;
			this.buttonShow.Location = new System.Drawing.Point(16, 280);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(618, 40);
			this.buttonShow.TabIndex = 1;
			this.buttonShow.Text = "Show";
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.AutoSize = false;
			this.textBoxTitle.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxTitle.Label.MinSize = 20;
			this.textBoxTitle.Label.Padding = new Wisej.Web.Padding(0);
			this.textBoxTitle.Label.SizeType = Wisej.Web.SizeType.Absolute;
			this.textBoxTitle.LabelText = "Alert Title";
			this.textBoxTitle.Location = new System.Drawing.Point(16, 128);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(618, 56);
			this.textBoxTitle.TabIndex = 2;
			this.textBoxTitle.Text = "ALERT";
			this.textBoxTitle.Watermark = "Message";
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.AutoSize = false;
			this.textBoxMessage.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxMessage.Label.MinSize = 20;
			this.textBoxMessage.Label.Padding = new Wisej.Web.Padding(0);
			this.textBoxMessage.Label.SizeType = Wisej.Web.SizeType.Absolute;
			this.textBoxMessage.LabelText = "Alert Message";
			this.textBoxMessage.Location = new System.Drawing.Point(16, 204);
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(618, 56);
			this.textBoxMessage.TabIndex = 3;
			this.textBoxMessage.Text = "ALERT";
			this.textBoxMessage.Watermark = "Message";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 184);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 260);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// NativeAlert
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonShow);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.textBoxMessage);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBoxTitle);
			this.Name = "NativeAlert";
			this.Controls.SetChildIndex(this.textBoxTitle, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.textBoxMessage, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.buttonShow, 0);
			this.ResumeLayout(false);

		}

		#endregion
		private Web.Button buttonShow;
		private Web.TextBox textBoxTitle;
		private Web.TextBox textBoxMessage;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
	}
}
