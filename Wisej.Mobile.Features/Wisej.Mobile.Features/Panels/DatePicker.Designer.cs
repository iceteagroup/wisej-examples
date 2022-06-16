namespace Wisej.Mobile.Features.Panels
{
	partial class DatePicker
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
			this.buttonShow = new Wisej.Web.Button();
			this.comboBoxFormat = new Wisej.Web.ComboBox();
			this.textBoxMin = new Wisej.Web.TextBox();
			this.textBoxMax = new Wisej.Web.TextBox();
			this.textBoxStart = new Wisej.Web.TextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.spacer3 = new Wisej.Web.Spacer();
			this.spacer4 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonShow
			// 
			this.buttonShow.Dock = Wisej.Web.DockStyle.Top;
			this.buttonShow.Location = new System.Drawing.Point(16, 468);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(618, 40);
			this.buttonShow.TabIndex = 0;
			this.buttonShow.Text = "Show Picker";
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// comboBoxFormat
			// 
			this.comboBoxFormat.AutoSize = false;
			this.comboBoxFormat.Dock = Wisej.Web.DockStyle.Top;
			this.comboBoxFormat.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxFormat.Label.Size = 50;
			this.comboBoxFormat.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBoxFormat.LabelText = "Format";
			this.comboBoxFormat.Location = new System.Drawing.Point(16, 383);
			this.comboBoxFormat.Name = "comboBoxFormat";
			this.comboBoxFormat.Size = new System.Drawing.Size(618, 65);
			this.comboBoxFormat.TabIndex = 1;
			// 
			// textBoxMin
			// 
			this.textBoxMin.AutoSize = false;
			this.textBoxMin.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxMin.InputType.Type = Wisej.Web.TextBoxType.DatetimeLocal;
			this.textBoxMin.Label.Size = 50;
			this.textBoxMin.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxMin.LabelText = "Minimum Date";
			this.textBoxMin.Location = new System.Drawing.Point(16, 213);
			this.textBoxMin.Name = "textBoxMin";
			this.textBoxMin.Size = new System.Drawing.Size(618, 65);
			this.textBoxMin.TabIndex = 2;
			// 
			// textBoxMax
			// 
			this.textBoxMax.AutoSize = false;
			this.textBoxMax.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxMax.InputType.Type = Wisej.Web.TextBoxType.DatetimeLocal;
			this.textBoxMax.Label.Size = 50;
			this.textBoxMax.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxMax.LabelText = "Maximum Date";
			this.textBoxMax.Location = new System.Drawing.Point(16, 298);
			this.textBoxMax.Name = "textBoxMax";
			this.textBoxMax.Size = new System.Drawing.Size(618, 65);
			this.textBoxMax.TabIndex = 3;
			// 
			// textBoxStart
			// 
			this.textBoxStart.AutoSize = false;
			this.textBoxStart.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxStart.InputType.Type = Wisej.Web.TextBoxType.DatetimeLocal;
			this.textBoxStart.Label.Size = 50;
			this.textBoxStart.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxStart.LabelText = "Start Date";
			this.textBoxStart.Location = new System.Drawing.Point(16, 128);
			this.textBoxStart.Name = "textBoxStart";
			this.textBoxStart.Size = new System.Drawing.Size(618, 65);
			this.textBoxStart.TabIndex = 4;
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 193);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 278);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer3
			// 
			this.spacer3.Dock = Wisej.Web.DockStyle.Top;
			this.spacer3.Location = new System.Drawing.Point(16, 363);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer4
			// 
			this.spacer4.Dock = Wisej.Web.DockStyle.Top;
			this.spacer4.Location = new System.Drawing.Point(16, 448);
			this.spacer4.Name = "spacer4";
			this.spacer4.Size = new System.Drawing.Size(618, 20);
			// 
			// DatePicker
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonShow);
			this.Controls.Add(this.spacer4);
			this.Controls.Add(this.comboBoxFormat);
			this.Controls.Add(this.spacer3);
			this.Controls.Add(this.textBoxMax);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.textBoxMin);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBoxStart);
			this.Name = "DatePicker";
			this.Size = new System.Drawing.Size(650, 523);
			this.Load += new System.EventHandler(this.Picker_Load);
			this.Controls.SetChildIndex(this.textBoxStart, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.textBoxMin, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.textBoxMax, 0);
			this.Controls.SetChildIndex(this.spacer3, 0);
			this.Controls.SetChildIndex(this.comboBoxFormat, 0);
			this.Controls.SetChildIndex(this.spacer4, 0);
			this.Controls.SetChildIndex(this.buttonShow, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonShow;
		private Web.ComboBox comboBoxFormat;
		private Web.TextBox textBoxMin;
		private Web.TextBox textBoxMax;
		private Web.TextBox textBoxStart;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
		private Web.Spacer spacer3;
		private Web.Spacer spacer4;
	}
}
