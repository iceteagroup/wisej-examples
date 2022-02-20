namespace Wisej.MobileTest.Panels
{
	partial class Picker
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
			this.SuspendLayout();
			// 
			// buttonShow
			// 
			this.buttonShow.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.buttonShow.Location = new System.Drawing.Point(25, 400);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(300, 40);
			this.buttonShow.TabIndex = 0;
			this.buttonShow.Text = "Show Picker";
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// comboBoxFormat
			// 
			this.comboBoxFormat.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxFormat.AutoSize = false;
			this.comboBoxFormat.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxFormat.Label.Size = 50;
			this.comboBoxFormat.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBoxFormat.LabelText = "Format";
			this.comboBoxFormat.Location = new System.Drawing.Point(25, 315);
			this.comboBoxFormat.Name = "comboBoxFormat";
			this.comboBoxFormat.Size = new System.Drawing.Size(300, 53);
			this.comboBoxFormat.TabIndex = 1;
			// 
			// textBoxMin
			// 
			this.textBoxMin.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxMin.AutoSize = false;
			this.textBoxMin.InputType.Type = Wisej.Web.TextBoxType.DatetimeLocal;
			this.textBoxMin.Label.Size = 50;
			this.textBoxMin.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxMin.LabelText = "Minimum Date";
			this.textBoxMin.Location = new System.Drawing.Point(25, 145);
			this.textBoxMin.Name = "textBoxMin";
			this.textBoxMin.Size = new System.Drawing.Size(300, 53);
			this.textBoxMin.TabIndex = 2;
			// 
			// textBoxMax
			// 
			this.textBoxMax.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxMax.AutoSize = false;
			this.textBoxMax.InputType.Type = Wisej.Web.TextBoxType.DatetimeLocal;
			this.textBoxMax.Label.Size = 50;
			this.textBoxMax.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxMax.LabelText = "Maximum Date";
			this.textBoxMax.Location = new System.Drawing.Point(25, 230);
			this.textBoxMax.Name = "textBoxMax";
			this.textBoxMax.Size = new System.Drawing.Size(300, 53);
			this.textBoxMax.TabIndex = 3;
			// 
			// textBoxStart
			// 
			this.textBoxStart.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxStart.AutoSize = false;
			this.textBoxStart.InputType.Type = Wisej.Web.TextBoxType.DatetimeLocal;
			this.textBoxStart.Label.Size = 50;
			this.textBoxStart.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxStart.LabelText = "Start Date";
			this.textBoxStart.Location = new System.Drawing.Point(25, 60);
			this.textBoxStart.Name = "textBoxStart";
			this.textBoxStart.Size = new System.Drawing.Size(300, 53);
			this.textBoxStart.TabIndex = 4;
			// 
			// Picker
			// 
			this.Controls.Add(this.textBoxStart);
			this.Controls.Add(this.textBoxMax);
			this.Controls.Add(this.textBoxMin);
			this.Controls.Add(this.comboBoxFormat);
			this.Controls.Add(this.buttonShow);
			this.Name = "Picker";
			this.Size = new System.Drawing.Size(350, 500);
			this.Load += new System.EventHandler(this.Picker_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonShow;
		private Web.ComboBox comboBoxFormat;
		private Web.TextBox textBoxMin;
		private Web.TextBox textBoxMax;
		private Web.TextBox textBoxStart;
	}
}
