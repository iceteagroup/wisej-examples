namespace Wisej.Mobile.Features.Panels
{
	partial class HapticFeedback
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
			Wisej.Web.JavaScript.ClientEvent clientEvent1 = new Wisej.Web.JavaScript.ClientEvent();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HapticFeedback));
			this.buttonServerSide = new Wisej.Web.Button();
			this.buttonJavascript = new Wisej.Web.Button();
			this.comboBoxHapticType = new Wisej.Web.ComboBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonServerSide
			// 
			this.buttonServerSide.Dock = Wisej.Web.DockStyle.Top;
			this.buttonServerSide.Location = new System.Drawing.Point(16, 203);
			this.buttonServerSide.Name = "buttonServerSide";
			this.buttonServerSide.Size = new System.Drawing.Size(618, 40);
			this.buttonServerSide.TabIndex = 1;
			this.buttonServerSide.Text = "Call From Server";
			this.buttonServerSide.Click += new System.EventHandler(this.buttonServerSide_Click);
			// 
			// buttonJavascript
			// 
			clientEvent1.Event = "tap";
			clientEvent1.JavaScript = resources.GetString("clientEvent1.JavaScript");
			this.buttonJavascript.ClientEvents.Add(clientEvent1);
			this.buttonJavascript.Dock = Wisej.Web.DockStyle.Top;
			this.buttonJavascript.Location = new System.Drawing.Point(16, 263);
			this.buttonJavascript.Name = "buttonJavascript";
			this.buttonJavascript.Size = new System.Drawing.Size(618, 40);
			this.buttonJavascript.TabIndex = 3;
			this.buttonJavascript.Text = "Call From Client";
			// 
			// comboBoxHapticType
			// 
			this.comboBoxHapticType.Dock = Wisej.Web.DockStyle.Top;
			this.comboBoxHapticType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxHapticType.Items.AddRange(new object[] {
            "Error",
            "Success",
            "Warning"});
			this.comboBoxHapticType.LabelText = "Haptic Feedback";
			this.comboBoxHapticType.Location = new System.Drawing.Point(16, 128);
			this.comboBoxHapticType.Name = "comboBoxHapticType";
			this.comboBoxHapticType.Size = new System.Drawing.Size(618, 55);
			this.comboBoxHapticType.TabIndex = 4;
			this.comboBoxHapticType.Tag = "";
			this.comboBoxHapticType.Text = "Success";
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
			this.spacer2.Location = new System.Drawing.Point(16, 243);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// HapticFeedback
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonJavascript);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.buttonServerSide);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.comboBoxHapticType);
			this.Name = "HapticFeedback";
			this.Controls.SetChildIndex(this.comboBoxHapticType, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonServerSide, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.buttonJavascript, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Button buttonServerSide;
		private Web.Button buttonJavascript;
		private Web.ComboBox comboBoxHapticType;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
	}
}
