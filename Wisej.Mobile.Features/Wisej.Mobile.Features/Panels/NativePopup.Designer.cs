namespace Wisej.Mobile.Features.Panels
{
	partial class NativePopup
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
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.groupBox1 = new Wisej.Web.GroupBox();
			this.textBoxName1 = new Wisej.Web.TextBox();
			this.textBoxOption1 = new Wisej.Web.TextBox();
			this.comboBoxOption1 = new Wisej.Web.ComboBox();
			this.textBoxName2 = new Wisej.Web.TextBox();
			this.textBoxOption2 = new Wisej.Web.TextBox();
			this.comboBoxOption2 = new Wisej.Web.ComboBox();
			this.textBoxName3 = new Wisej.Web.TextBox();
			this.textBoxOption3 = new Wisej.Web.TextBox();
			this.comboBoxOption3 = new Wisej.Web.ComboBox();
			this.comboBoxPopupType = new Wisej.Web.ComboBox();
			this.textBoxMessage = new Wisej.Web.TextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.spacer3 = new Wisej.Web.Spacer();
			this.spacer4 = new Wisej.Web.Spacer();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonShow
			// 
			this.buttonShow.Dock = Wisej.Web.DockStyle.Top;
			this.buttonShow.Location = new System.Drawing.Point(16, 492);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(618, 40);
			this.buttonShow.TabIndex = 2;
			this.buttonShow.Text = "Show";
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.AutoSize = false;
			this.textBoxTitle.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxTitle.Location = new System.Drawing.Point(16, 128);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(618, 40);
			this.textBoxTitle.TabIndex = 0;
			this.textBoxTitle.Text = "Title";
			this.textBoxTitle.Watermark = "Message";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxName1);
			this.groupBox1.Controls.Add(this.textBoxOption1);
			this.groupBox1.Controls.Add(this.comboBoxOption1);
			this.groupBox1.Controls.Add(this.textBoxName2);
			this.groupBox1.Controls.Add(this.textBoxOption2);
			this.groupBox1.Controls.Add(this.comboBoxOption2);
			this.groupBox1.Controls.Add(this.textBoxName3);
			this.groupBox1.Controls.Add(this.textBoxOption3);
			this.groupBox1.Controls.Add(this.comboBoxOption3);
			this.groupBox1.Dock = Wisej.Web.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(16, 248);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(618, 164);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.Text = "Options";
			// 
			// textBoxName1
			// 
			this.textBoxName1.AutoSize = false;
			this.textBoxName1.Location = new System.Drawing.Point(6, 35);
			this.textBoxName1.Name = "textBoxName1";
			this.textBoxName1.Size = new System.Drawing.Size(81, 30);
			this.textBoxName1.TabIndex = 0;
			this.textBoxName1.Text = "1";
			this.textBoxName1.Watermark = "Name";
			// 
			// textBoxOption1
			// 
			this.textBoxOption1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxOption1.AutoSize = false;
			this.textBoxOption1.Location = new System.Drawing.Point(93, 34);
			this.textBoxOption1.Name = "textBoxOption1";
			this.textBoxOption1.Size = new System.Drawing.Size(402, 30);
			this.textBoxOption1.TabIndex = 1;
			this.textBoxOption1.Text = "John";
			this.textBoxOption1.Watermark = "Text";
			// 
			// comboBoxOption1
			// 
			this.comboBoxOption1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxOption1.AutoSize = false;
			this.comboBoxOption1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOption1.Items.AddRange(new object[] {
            "Default",
            "Cancel",
            "Destructive"});
			this.comboBoxOption1.Location = new System.Drawing.Point(501, 33);
			this.comboBoxOption1.Name = "comboBoxOption1";
			this.comboBoxOption1.Size = new System.Drawing.Size(97, 30);
			this.comboBoxOption1.TabIndex = 2;
			this.comboBoxOption1.Text = "Default";
			// 
			// textBoxName2
			// 
			this.textBoxName2.AutoSize = false;
			this.textBoxName2.Location = new System.Drawing.Point(6, 79);
			this.textBoxName2.Name = "textBoxName2";
			this.textBoxName2.Size = new System.Drawing.Size(81, 30);
			this.textBoxName2.TabIndex = 3;
			this.textBoxName2.Text = "2";
			this.textBoxName2.Watermark = "Name";
			// 
			// textBoxOption2
			// 
			this.textBoxOption2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxOption2.AutoSize = false;
			this.textBoxOption2.Location = new System.Drawing.Point(93, 78);
			this.textBoxOption2.Name = "textBoxOption2";
			this.textBoxOption2.Size = new System.Drawing.Size(402, 30);
			this.textBoxOption2.TabIndex = 4;
			this.textBoxOption2.Text = "Jane";
			this.textBoxOption2.Watermark = "Text";
			// 
			// comboBoxOption2
			// 
			this.comboBoxOption2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxOption2.AutoSize = false;
			this.comboBoxOption2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOption2.Items.AddRange(new object[] {
            "Default",
            "Cancel",
            "Destructive"});
			this.comboBoxOption2.Location = new System.Drawing.Point(501, 77);
			this.comboBoxOption2.Name = "comboBoxOption2";
			this.comboBoxOption2.Size = new System.Drawing.Size(97, 30);
			this.comboBoxOption2.TabIndex = 5;
			this.comboBoxOption2.Text = "Default";
			// 
			// textBoxName3
			// 
			this.textBoxName3.AutoSize = false;
			this.textBoxName3.Location = new System.Drawing.Point(6, 122);
			this.textBoxName3.Name = "textBoxName3";
			this.textBoxName3.Size = new System.Drawing.Size(81, 30);
			this.textBoxName3.TabIndex = 6;
			this.textBoxName3.Text = "3";
			this.textBoxName3.Watermark = "Name";
			// 
			// textBoxOption3
			// 
			this.textBoxOption3.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxOption3.AutoSize = false;
			this.textBoxOption3.Location = new System.Drawing.Point(93, 122);
			this.textBoxOption3.Name = "textBoxOption3";
			this.textBoxOption3.Size = new System.Drawing.Size(402, 30);
			this.textBoxOption3.TabIndex = 7;
			this.textBoxOption3.Text = "Cancel";
			this.textBoxOption3.Watermark = "Text";
			// 
			// comboBoxOption3
			// 
			this.comboBoxOption3.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxOption3.AutoSize = false;
			this.comboBoxOption3.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOption3.Items.AddRange(new object[] {
            "Default",
            "Cancel",
            "Destructive"});
			this.comboBoxOption3.Location = new System.Drawing.Point(501, 121);
			this.comboBoxOption3.Name = "comboBoxOption3";
			this.comboBoxOption3.Size = new System.Drawing.Size(97, 30);
			this.comboBoxOption3.TabIndex = 8;
			this.comboBoxOption3.Text = "Cancel";
			// 
			// comboBoxPopupType
			// 
			this.comboBoxPopupType.AutoSize = false;
			this.comboBoxPopupType.Dock = Wisej.Web.DockStyle.Top;
			this.comboBoxPopupType.Items.AddRange(new object[] {
            "Alert",
            "Prompt"});
			this.comboBoxPopupType.Location = new System.Drawing.Point(16, 432);
			this.comboBoxPopupType.Name = "comboBoxPopupType";
			this.comboBoxPopupType.Size = new System.Drawing.Size(618, 40);
			this.comboBoxPopupType.TabIndex = 3;
			this.comboBoxPopupType.Text = "Alert";
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.AutoSize = false;
			this.textBoxMessage.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxMessage.Location = new System.Drawing.Point(16, 188);
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(618, 40);
			this.textBoxMessage.TabIndex = 4;
			this.textBoxMessage.Text = "Message";
			this.textBoxMessage.Watermark = "Message";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 472);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 228);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer3
			// 
			this.spacer3.Dock = Wisej.Web.DockStyle.Top;
			this.spacer3.Location = new System.Drawing.Point(16, 412);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer4
			// 
			this.spacer4.Dock = Wisej.Web.DockStyle.Top;
			this.spacer4.Location = new System.Drawing.Point(16, 168);
			this.spacer4.Name = "spacer4";
			this.spacer4.Size = new System.Drawing.Size(618, 20);
			// 
			// NativePopup
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
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.comboBoxPopupType);
			this.Controls.Add(this.spacer3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.textBoxMessage);
			this.Controls.Add(this.spacer4);
			this.Controls.Add(this.textBoxTitle);
			this.Name = "NativePopup";
			this.Size = new System.Drawing.Size(650, 593);
			this.Controls.SetChildIndex(this.textBoxTitle, 0);
			this.Controls.SetChildIndex(this.spacer4, 0);
			this.Controls.SetChildIndex(this.textBoxMessage, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.spacer3, 0);
			this.Controls.SetChildIndex(this.comboBoxPopupType, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonShow, 0);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonShow;
		private Web.TextBox textBoxTitle;
		private Web.GroupBox groupBox1;
		private Web.TextBox textBoxOption3;
		private Web.ComboBox comboBoxOption2;
		private Web.TextBox textBoxOption2;
		private Web.ComboBox comboBoxOption1;
		private Web.TextBox textBoxOption1;
		private Web.ComboBox comboBoxOption3;
		private Web.TextBox textBoxName3;
		private Web.TextBox textBoxName2;
		private Web.TextBox textBoxName1;
		private Web.ComboBox comboBoxPopupType;
		private Web.TextBox textBoxMessage;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
		private Web.Spacer spacer3;
		private Web.Spacer spacer4;
	}
}
