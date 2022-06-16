namespace Wisej.Mobile.Features.Panels
{
	partial class StatusBar
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
			this.checkBoxStatusbar = new Wisej.Web.CheckBox();
			this.textBoxBackColor = new Wisej.Web.TextBox();
			this.label1 = new Wisej.Web.Label();
			this.comboBoxTextColor = new Wisej.Web.ComboBox();
			this.SuspendLayout();
			// 
			// checkBoxStatusbar
			// 
			this.checkBoxStatusbar.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.checkBoxStatusbar.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxStatusbar.AutoSize = false;
			this.checkBoxStatusbar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxStatusbar.Checked = true;
			this.checkBoxStatusbar.Location = new System.Drawing.Point(26, 116);
			this.checkBoxStatusbar.MinimumSize = new System.Drawing.Size(180, 0);
			this.checkBoxStatusbar.Name = "checkBoxStatusbar";
			this.checkBoxStatusbar.Size = new System.Drawing.Size(599, 40);
			this.checkBoxStatusbar.TabIndex = 0;
			this.checkBoxStatusbar.Text = "Show Statusbar";
			this.checkBoxStatusbar.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
			// 
			// textBoxBackColor
			// 
			this.textBoxBackColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.textBoxBackColor.AutoSize = false;
			this.textBoxBackColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxBackColor.Location = new System.Drawing.Point(525, 213);
			this.textBoxBackColor.Name = "textBoxBackColor";
			this.textBoxBackColor.Size = new System.Drawing.Size(100, 34);
			this.textBoxBackColor.TabIndex = 2;
			this.textBoxBackColor.Text = "#000000";
			this.textBoxBackColor.TextChanged += new System.EventHandler(this.textBoxBackColor_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(26, 213);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 33);
			this.label1.TabIndex = 3;
			this.label1.Text = "Background Color";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBoxTextColor
			// 
			this.comboBoxTextColor.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxTextColor.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxTextColor.Items.AddRange(new object[] {
            "Black",
            "White"});
			this.comboBoxTextColor.LabelText = "Text Color (can\'t set if device is in \"Dark Mode\")";
			this.comboBoxTextColor.Location = new System.Drawing.Point(26, 307);
			this.comboBoxTextColor.Name = "comboBoxTextColor";
			this.comboBoxTextColor.Size = new System.Drawing.Size(599, 55);
			this.comboBoxTextColor.TabIndex = 6;
			this.comboBoxTextColor.Text = "black";
			this.comboBoxTextColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxTextColor_SelectedIndexChanged);
			// 
			// StatusBar
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.comboBoxTextColor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxBackColor);
			this.Controls.Add(this.checkBoxStatusbar);
			this.Name = "StatusBar";
			this.Disposed += new System.EventHandler(this.StatusBar_Disposed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.CheckBox checkBoxStatusbar;
		private Web.TextBox textBoxBackColor;
		private Web.Label label1;
		private Web.ComboBox comboBoxTextColor;
	}
}
