namespace Wisej.OrgChart
{
	partial class Page1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
			Wisej.Web.Widget.Package package4 = new Wisej.Web.Widget.Package();
			Wisej.Web.Widget.Package package5 = new Wisej.Web.Widget.Package();
			Wisej.Web.Widget.Package package6 = new Wisej.Web.Widget.Package();
			this.widget1 = new Wisej.Web.Widget();
			this.button1 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// widget1
			// 
			this.widget1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.widget1.InitScript = resources.GetString("widget1.InitScript");
			this.widget1.Location = new System.Drawing.Point(136, 137);
			this.widget1.Name = "widget1";
			package4.Name = "jquery.js";
			package4.Source = "https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js";
			package5.Name = "orgchart.js";
			package5.Source = "https://rawgit.com/dabeng/OrgChart/master/dist/js/jquery.orgchart.js";
			package6.Name = "orgchart.css";
			package6.Source = "https://rawgit.com/dabeng/OrgChart/master/dist/css/jquery.orgchart.css";
			this.widget1.Packages.Add(package4);
			this.widget1.Packages.Add(package5);
			this.widget1.Packages.Add(package6);
			this.widget1.Size = new System.Drawing.Size(661, 523);
			this.widget1.TabIndex = 0;
			this.widget1.Text = "widget1";
			this.widget1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.widget1_WidgetEvent);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(141, 53);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 47);
			this.button1.TabIndex = 1;
			this.button1.Text = "Change Data";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.widget1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1288, 874);
			this.Text = "Page1";
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Widget widget1;
		private Web.Button button1;
	}
}

