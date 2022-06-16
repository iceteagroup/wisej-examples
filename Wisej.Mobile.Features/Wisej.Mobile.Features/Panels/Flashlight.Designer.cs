namespace Wisej.Mobile.Features.Panels
{
	partial class Flashlight
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
			this.buttonOn = new Wisej.Web.Button();
			this.buttonOff = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// buttonOn
			// 
			this.buttonOn.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonOn.Location = new System.Drawing.Point(175, 170);
			this.buttonOn.Name = "buttonOn";
			this.buttonOn.Size = new System.Drawing.Size(300, 40);
			this.buttonOn.TabIndex = 0;
			this.buttonOn.Text = "On";
			this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
			// 
			// buttonOff
			// 
			this.buttonOff.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonOff.Location = new System.Drawing.Point(175, 269);
			this.buttonOff.Name = "buttonOff";
			this.buttonOff.Size = new System.Drawing.Size(300, 40);
			this.buttonOff.TabIndex = 1;
			this.buttonOff.Text = "Off";
			this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
			// 
			// Flashlight
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonOff);
			this.Controls.Add(this.buttonOn);
			this.Name = "Flashlight";
			this.Disposed += new System.EventHandler(this.Flashlight_Disposed);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonOn;
		private Web.Button buttonOff;
	}
}
