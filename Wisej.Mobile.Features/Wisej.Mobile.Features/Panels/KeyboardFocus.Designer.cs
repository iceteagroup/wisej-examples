namespace Wisej.Mobile.Features.Panels
{
	partial class KeyboardFocus
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
			this.textBoxInput = new Wisej.Web.TextBox();
			this.SuspendLayout();
			// 
			// textBoxInput
			// 
			this.textBoxInput.AutoSize = false;
			this.textBoxInput.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxInput.Location = new System.Drawing.Point(16, 128);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(618, 40);
			this.textBoxInput.TabIndex = 2;
			this.textBoxInput.Text = "The textbox gets focus without user interaction on the element";
			this.textBoxInput.Watermark = "Message";
			// 
			// KeyboardFocus
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.textBoxInput);
			this.Name = "KeyboardFocus";
			this.Appear += new System.EventHandler(this.KeyboardFocus_Appear);
			this.Controls.SetChildIndex(this.textBoxInput, 0);
			this.ResumeLayout(false);

		}

		#endregion
		private Web.TextBox textBoxInput;
	}
}
