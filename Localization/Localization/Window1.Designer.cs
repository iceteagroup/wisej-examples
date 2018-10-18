namespace Localization
{
	partial class Window1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window1));
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.labelCurrency = new Wisej.Web.Label();
			this.labelDateTime = new Wisej.Web.Label();
			this.label5 = new Wisej.Web.Label();
			this.labelNumber = new Wisej.Web.Label();
			this.label4 = new Wisej.Web.Label();
			this.button1 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			resources.GetString("comboBox1.Items"),
			resources.GetString("comboBox1.Items1"),
			resources.GetString("comboBox1.Items2"),
			resources.GetString("comboBox1.Items3"),
			resources.GetString("comboBox1.Items4"),
			resources.GetString("comboBox1.Items5")});
			resources.ApplyResources(this.comboBox1, "comboBox1");
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// labelCurrency
			// 
			resources.ApplyResources(this.labelCurrency, "labelCurrency");
			this.labelCurrency.Name = "labelCurrency";
			// 
			// labelDateTime
			// 
			resources.ApplyResources(this.labelDateTime, "labelDateTime");
			this.labelDateTime.Name = "labelDateTime";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// labelNumber
			// 
			resources.ApplyResources(this.labelNumber, "labelNumber");
			this.labelNumber.Name = "labelNumber";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.Name = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Window1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelNumber);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelDateTime);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelCurrency);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Window1";
			this.Load += new System.EventHandler(this.Window1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.ComboBox comboBox1;
		private Wisej.Web.Label label1;
		private Wisej.Web.Label label2;
		private Wisej.Web.Label labelCurrency;
		private Wisej.Web.Label labelDateTime;
		private Wisej.Web.Label label5;
		private Wisej.Web.Label labelNumber;
		private Wisej.Web.Label label4;
		private Wisej.Web.Button button1;
	}
}

