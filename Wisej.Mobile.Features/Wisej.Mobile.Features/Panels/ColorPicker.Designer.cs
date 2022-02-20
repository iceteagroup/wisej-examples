namespace Wisej.Mobile.Features.Panels
{
	partial class ColorPicker
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
			this.buttonSelect = new Wisej.Web.Button();
			this.panelColor = new Wisej.Web.Panel();
			this.label1 = new Wisej.Web.Label();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonSelect
			// 
			this.buttonSelect.Dock = Wisej.Web.DockStyle.Top;
			this.buttonSelect.Location = new System.Drawing.Point(16, 257);
			this.buttonSelect.Name = "buttonSelect";
			this.buttonSelect.Size = new System.Drawing.Size(618, 40);
			this.buttonSelect.TabIndex = 0;
			this.buttonSelect.Text = "Select Color";
			this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
			// 
			// panelColor
			// 
			this.panelColor.BackColor = System.Drawing.Color.White;
			this.panelColor.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panelColor.Dock = Wisej.Web.DockStyle.Top;
			this.panelColor.Location = new System.Drawing.Point(16, 148);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new System.Drawing.Size(618, 89);
			this.panelColor.TabIndex = 1;
			this.panelColor.TabStop = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = Wisej.Web.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(16, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(618, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Selected Color";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 237);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// ColorPicker
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonSelect);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.panelColor);
			this.Controls.Add(this.label1);
			this.Name = "ColorPicker";
			this.Load += new System.EventHandler(this.ColorPicker_Load);
			this.Disposed += new System.EventHandler(this.ColorPicker_Disposed);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.panelColor, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonSelect, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Button buttonSelect;
		private Web.Panel panelColor;
		private Web.Label label1;
		private Web.Spacer spacer1;
	}
}
