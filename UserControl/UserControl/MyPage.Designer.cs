namespace UserControl
{
	partial class MyPage
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
			this.label1 = new Wisej.Web.Label();
			this.colorPanel = new Wisej.Web.Panel();
			this.label2 = new Wisej.Web.Label();
			this.colorSlider = new UserControl.ColorSlider();
			this.checkBoxShowValueBubble = new Wisej.Web.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(158, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Color Panel";
			// 
			// colorPanel
			// 
			this.colorPanel.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.colorPanel.Location = new System.Drawing.Point(49, 112);
			this.colorPanel.Name = "colorPanel";
			this.colorPanel.Size = new System.Drawing.Size(295, 228);
			this.colorPanel.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(492, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Color Slider";
			// 
			// colorSlider
			// 
			this.colorSlider.Location = new System.Drawing.Point(383, 112);
			this.colorSlider.Name = "colorSlider";
			this.colorSlider.Size = new System.Drawing.Size(295, 228);
			this.colorSlider.TabIndex = 4;
			this.colorSlider.ValueChanged += new System.EventHandler(this.colorSlider_ValueChanged);
			// 
			// checkBoxShowValueBubble
			// 
			this.checkBoxShowValueBubble.Checked = true;
			this.checkBoxShowValueBubble.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxShowValueBubble.Location = new System.Drawing.Point(459, 365);
			this.checkBoxShowValueBubble.Name = "checkBoxShowValueBubble";
			this.checkBoxShowValueBubble.Size = new System.Drawing.Size(143, 27);
			this.checkBoxShowValueBubble.TabIndex = 5;
			this.checkBoxShowValueBubble.Text = "Show Value Bubble";
			this.checkBoxShowValueBubble.CheckedChanged += new System.EventHandler(this.checkBoxShowValueBubble_CheckedChanged);
			// 
			// MyPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.checkBoxShowValueBubble);
			this.Controls.Add(this.colorSlider);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.colorPanel);
			this.Controls.Add(this.label1);
			this.Name = "MyPage";
			this.Size = new System.Drawing.Size(1037, 874);
			this.Load += new System.EventHandler(this.MyPage_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label label1;
		private Wisej.Web.Panel colorPanel;
		private Wisej.Web.Label label2;
		private ColorSlider colorSlider;
		private Wisej.Web.CheckBox checkBoxShowValueBubble;
	}
}
