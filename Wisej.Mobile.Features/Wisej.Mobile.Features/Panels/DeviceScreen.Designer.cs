namespace Wisej.Mobile.Features.Panels
{
	partial class DeviceScreen
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
			this.checkBoxIdle = new Wisej.Web.CheckBox();
			this.trackBarBrightness = new Wisej.Web.TrackBar();
			this.label1 = new Wisej.Web.Label();
			this.comboBoxOrientation = new Wisej.Web.ComboBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
			this.SuspendLayout();
			// 
			// checkBoxIdle
			// 
			this.checkBoxIdle.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxIdle.AutoSize = false;
			this.checkBoxIdle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxIdle.Dock = Wisej.Web.DockStyle.Top;
			this.checkBoxIdle.Location = new System.Drawing.Point(16, 128);
			this.checkBoxIdle.MinimumSize = new System.Drawing.Size(180, 0);
			this.checkBoxIdle.Name = "checkBoxIdle";
			this.checkBoxIdle.Size = new System.Drawing.Size(618, 40);
			this.checkBoxIdle.TabIndex = 0;
			this.checkBoxIdle.Text = "Idle Timer Disabled";
			this.checkBoxIdle.CheckedChanged += new System.EventHandler(this.checkBoxIdle_CheckedChanged);
			// 
			// trackBarBrightness
			// 
			this.trackBarBrightness.AutoSize = false;
			this.trackBarBrightness.Dock = Wisej.Web.DockStyle.Top;
			this.trackBarBrightness.Location = new System.Drawing.Point(16, 208);
			this.trackBarBrightness.Maximum = 100;
			this.trackBarBrightness.MinimumSize = new System.Drawing.Size(180, 0);
			this.trackBarBrightness.Name = "trackBarBrightness";
			this.trackBarBrightness.Size = new System.Drawing.Size(618, 40);
			this.trackBarBrightness.TabIndex = 1;
			this.trackBarBrightness.TickStyle = Wisej.Web.TickStyle.None;
			this.trackBarBrightness.ValueChanged += new System.EventHandler(this.trackBarBrightness_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = Wisej.Web.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(16, 188);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(618, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Brightness";
			// 
			// comboBoxOrientation
			// 
			this.comboBoxOrientation.AutoSize = false;
			this.comboBoxOrientation.Dock = Wisej.Web.DockStyle.Top;
			this.comboBoxOrientation.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOrientation.LabelText = "Orientation Lock";
			this.comboBoxOrientation.Location = new System.Drawing.Point(16, 268);
			this.comboBoxOrientation.Name = "comboBoxOrientation";
			this.comboBoxOrientation.Size = new System.Drawing.Size(618, 50);
			this.comboBoxOrientation.TabIndex = 3;
			this.comboBoxOrientation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrientation_SelectedIndexChanged);
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
			this.spacer2.Location = new System.Drawing.Point(16, 248);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// DeviceScreen
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.comboBoxOrientation);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.trackBarBrightness);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.checkBoxIdle);
			this.Name = "DeviceScreen";
			this.Load += new System.EventHandler(this.DeviceScreen_Load);
			this.Disposed += new System.EventHandler(this.DeviceScreen_Disposed);
			this.Controls.SetChildIndex(this.checkBoxIdle, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.trackBarBrightness, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.comboBoxOrientation, 0);
			((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.CheckBox checkBoxIdle;
		private Web.TrackBar trackBarBrightness;
		private Web.Label label1;
		private Web.ComboBox comboBoxOrientation;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
	}
}
