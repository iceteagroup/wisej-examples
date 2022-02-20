namespace Wisej.Mobile.Features.Panels
{
	partial class ProgressBar
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
			this.checkBoxVisible = new Wisej.Web.CheckBox();
			this.trackBarValue = new Wisej.Web.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.trackBarValue)).BeginInit();
			this.SuspendLayout();
			// 
			// checkBoxVisible
			// 
			this.checkBoxVisible.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxVisible.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxVisible.Location = new System.Drawing.Point(280, 182);
			this.checkBoxVisible.Name = "checkBoxVisible";
			this.checkBoxVisible.Size = new System.Drawing.Size(95, 24);
			this.checkBoxVisible.TabIndex = 0;
			this.checkBoxVisible.Text = "Visible";
			this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
			// 
			// trackBarValue
			// 
			this.trackBarValue.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.trackBarValue.Location = new System.Drawing.Point(33, 262);
			this.trackBarValue.Maximum = 100;
			this.trackBarValue.Name = "trackBarValue";
			this.trackBarValue.Size = new System.Drawing.Size(584, 34);
			this.trackBarValue.TabIndex = 1;
			this.trackBarValue.TickFrequency = 10;
			this.trackBarValue.ValueChanged += new System.EventHandler(this.trackBarValue_ValueChanged);
			// 
			// ProgressBar
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.trackBarValue);
			this.Controls.Add(this.checkBoxVisible);
			this.Name = "ProgressBar";
			this.Disposed += new System.EventHandler(this.ProgressBar_Disposed);
			this.Controls.SetChildIndex(this.checkBoxVisible, 0);
			this.Controls.SetChildIndex(this.trackBarValue, 0);
			((System.ComponentModel.ISupportInitialize)(this.trackBarValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.CheckBox checkBoxVisible;
		private Web.TrackBar trackBarValue;
	}
}
