namespace Wisej.Mobile.Features.Panels
{
	partial class BackColor
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
			this.textBoxBackColor = new Wisej.Web.TextBox();
			this.SuspendLayout();
			// 
			// textBoxBackColor
			// 
			this.textBoxBackColor.AutoSize = false;
			this.textBoxBackColor.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxBackColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxBackColor.LabelText = "Device BackgroundColor";
			this.textBoxBackColor.Location = new System.Drawing.Point(16, 128);
			this.textBoxBackColor.Name = "textBoxBackColor";
			this.textBoxBackColor.Size = new System.Drawing.Size(618, 65);
			this.textBoxBackColor.TabIndex = 0;
			this.textBoxBackColor.Text = "#FFFFFF";
			this.textBoxBackColor.TextChanged += new System.EventHandler(this.textBoxBackColor_TextChanged);
			// 
			// BackColor
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.textBoxBackColor);
			this.Name = "BackColor";
			this.Disposed += new System.EventHandler(this.BackColor_Disposed);
			this.Controls.SetChildIndex(this.textBoxBackColor, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.TextBox textBoxBackColor;
	}
}
