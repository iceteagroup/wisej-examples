namespace Wisej.Mobile.Features.Panels
{
	partial class Notifications
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
			this.buttonPushNotification = new Wisej.Web.Button();
			this.textBoxToken = new Wisej.Web.TextBox();
			this.textBoxMessage = new Wisej.Web.TextBox();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.numericUpDownBadge = new Wisej.Web.NumericUpDown();
			this.checkBoxSound = new Wisej.Web.CheckBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.spacer3 = new Wisej.Web.Spacer();
			this.spacer4 = new Wisej.Web.Spacer();
			this.spacer5 = new Wisej.Web.Spacer();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBadge)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonPushNotification
			// 
			this.buttonPushNotification.Dock = Wisej.Web.DockStyle.Top;
			this.buttonPushNotification.Location = new System.Drawing.Point(16, 488);
			this.buttonPushNotification.Name = "buttonPushNotification";
			this.buttonPushNotification.Size = new System.Drawing.Size(618, 40);
			this.buttonPushNotification.TabIndex = 0;
			this.buttonPushNotification.Text = "Send Notification";
			this.buttonPushNotification.Click += new System.EventHandler(this.buttonPushNotification_Click);
			// 
			// textBoxToken
			// 
			this.textBoxToken.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxToken.LabelText = "Device Notification Token";
			this.textBoxToken.Location = new System.Drawing.Point(16, 128);
			this.textBoxToken.Name = "textBoxToken";
			this.textBoxToken.ReadOnly = true;
			this.textBoxToken.Size = new System.Drawing.Size(618, 55);
			this.textBoxToken.TabIndex = 1;
			this.textBoxToken.Watermark = "No Token";
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxMessage.LabelText = "Send Message";
			this.textBoxMessage.Location = new System.Drawing.Point(16, 278);
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(618, 55);
			this.textBoxMessage.TabIndex = 2;
			this.textBoxMessage.Text = "Hello, World!";
			this.textBoxMessage.Watermark = "Message...";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxTitle.LabelText = "Title";
			this.textBoxTitle.Location = new System.Drawing.Point(16, 203);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(618, 55);
			this.textBoxTitle.TabIndex = 3;
			this.textBoxTitle.Text = "Wisej Mobile Demo";
			this.textBoxTitle.Watermark = "Message...";
			// 
			// numericUpDownBadge
			// 
			this.numericUpDownBadge.Dock = Wisej.Web.DockStyle.Top;
			this.numericUpDownBadge.LabelText = "Badge Number";
			this.numericUpDownBadge.Location = new System.Drawing.Point(16, 353);
			this.numericUpDownBadge.Name = "numericUpDownBadge";
			this.numericUpDownBadge.Size = new System.Drawing.Size(618, 55);
			this.numericUpDownBadge.TabIndex = 4;
			this.numericUpDownBadge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// checkBoxSound
			// 
			this.checkBoxSound.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxSound.AutoSize = false;
			this.checkBoxSound.Checked = true;
			this.checkBoxSound.Dock = Wisej.Web.DockStyle.Top;
			this.checkBoxSound.Location = new System.Drawing.Point(16, 428);
			this.checkBoxSound.Name = "checkBoxSound";
			this.checkBoxSound.Size = new System.Drawing.Size(618, 40);
			this.checkBoxSound.TabIndex = 5;
			this.checkBoxSound.Text = "Sound";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 183);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 258);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer3
			// 
			this.spacer3.Dock = Wisej.Web.DockStyle.Top;
			this.spacer3.Location = new System.Drawing.Point(16, 333);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer4
			// 
			this.spacer4.Dock = Wisej.Web.DockStyle.Top;
			this.spacer4.Location = new System.Drawing.Point(16, 408);
			this.spacer4.Name = "spacer4";
			this.spacer4.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer5
			// 
			this.spacer5.Dock = Wisej.Web.DockStyle.Top;
			this.spacer5.Location = new System.Drawing.Point(16, 468);
			this.spacer5.Name = "spacer5";
			this.spacer5.Size = new System.Drawing.Size(618, 20);
			// 
			// Notifications
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonPushNotification);
			this.Controls.Add(this.spacer5);
			this.Controls.Add(this.checkBoxSound);
			this.Controls.Add(this.spacer4);
			this.Controls.Add(this.numericUpDownBadge);
			this.Controls.Add(this.spacer3);
			this.Controls.Add(this.textBoxMessage);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBoxToken);
			this.Name = "Notifications";
			this.Size = new System.Drawing.Size(650, 556);
			this.Load += new System.EventHandler(this.Notifications_Load);
			this.Controls.SetChildIndex(this.textBoxToken, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.textBoxTitle, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.textBoxMessage, 0);
			this.Controls.SetChildIndex(this.spacer3, 0);
			this.Controls.SetChildIndex(this.numericUpDownBadge, 0);
			this.Controls.SetChildIndex(this.spacer4, 0);
			this.Controls.SetChildIndex(this.checkBoxSound, 0);
			this.Controls.SetChildIndex(this.spacer5, 0);
			this.Controls.SetChildIndex(this.buttonPushNotification, 0);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBadge)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Button buttonPushNotification;
		private Web.TextBox textBoxToken;
		private Web.TextBox textBoxMessage;
		private Web.TextBox textBoxTitle;
		private Web.NumericUpDown numericUpDownBadge;
		private Web.CheckBox checkBoxSound;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
		private Web.Spacer spacer3;
		private Web.Spacer spacer4;
		private Web.Spacer spacer5;
	}
}
