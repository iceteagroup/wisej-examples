namespace TourPanelSample
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Wisej.Web.ComponentTool componentTool3 = new Wisej.Web.ComponentTool();
			this.mainMenu1 = new Wisej.Web.MainMenu(this.components);
			this.menuItem1 = new Wisej.Web.MenuItem();
			this.menuItem3 = new Wisej.Web.MenuItem();
			this.menuItem2 = new Wisej.Web.MenuItem();
			this.menuItem4 = new Wisej.Web.MenuItem();
			this.menuItem6 = new Wisej.Web.MenuItem();
			this.menuItem7 = new Wisej.Web.MenuItem();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.label3 = new Wisej.Web.Label();
			this.panel1 = new Wisej.Web.Panel();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.txtFirstName = new Wisej.Web.TextBox();
			this.txtName = new Wisej.Web.TextBox();
			this.cmbInterest = new Wisej.Web.ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuItem6});
			this.mainMenu1.Name = "mainMenu1";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem3,
            this.menuItem2,
            this.menuItem4});
			this.menuItem1.Name = "menuItem1";
			this.menuItem1.Text = "File";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Name = "menuItem3";
			this.menuItem3.Text = "New";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Name = "menuItem2";
			this.menuItem2.Text = "Open";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Name = "menuItem4";
			this.menuItem4.Text = "Save";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem7});
			this.menuItem6.Name = "menuItem6";
			this.menuItem6.Text = "Help";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 0;
			this.menuItem7.Name = "menuItem7";
			this.menuItem7.Text = "About";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name *";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name *";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Interests";
			// 
			// panel1
			// 
			this.panel1.Collapsed = true;
			this.panel1.Controls.Add(this.checkBox2);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(8, 132);
			this.panel1.Name = "panel1";
			this.panel1.RestoreBounds = new System.Drawing.Rectangle(8, 132, 159, 119);
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(159, 28);
			this.panel1.TabIndex = 3;
			this.panel1.Text = "More information";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(12, 51);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(123, 23);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Special discount";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(12, 22);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(106, 23);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "VIP customer";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(104, 15);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(265, 22);
			this.txtFirstName.TabIndex = 4;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(104, 51);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(265, 22);
			this.txtName.TabIndex = 5;
			// 
			// cmbInterest
			// 
			this.cmbInterest.Items.AddRange(new object[] {
            "Swimming",
            "Cooking",
            "Reading",
            "Football"});
			this.cmbInterest.Location = new System.Drawing.Point(104, 88);
			this.cmbInterest.Name = "cmbInterest";
			this.cmbInterest.Size = new System.Drawing.Size(264, 22);
			this.cmbInterest.TabIndex = 6;
			componentTool3.ImageSource = "window-maximize";
			this.cmbInterest.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool3});
			this.cmbInterest.ToolClick += new Wisej.Web.ToolClickEventHandler(this.comboBox1_ToolClick);
			// 
			// Window1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1010, 673);
			this.CloseBox = false;
			this.Controls.Add(this.cmbInterest);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Location = new System.Drawing.Point(100, 100);
			this.Menu = this.mainMenu1;
			this.Name = "Window1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.MainMenu mainMenu1;
		private Wisej.Web.MenuItem menuItem1;
		private Wisej.Web.MenuItem menuItem3;
		private Wisej.Web.MenuItem menuItem2;
		private Wisej.Web.MenuItem menuItem4;
		private Wisej.Web.MenuItem menuItem6;
		private Wisej.Web.MenuItem menuItem7;
		private Wisej.Web.Label label1;
		private Wisej.Web.Label label2;
		private Wisej.Web.Label label3;
		private Wisej.Web.Panel panel1;
		private Wisej.Web.CheckBox checkBox2;
		private Wisej.Web.CheckBox checkBox1;
		private Wisej.Web.TextBox txtFirstName;
		private Wisej.Web.TextBox txtName;
		private Wisej.Web.ComboBox cmbInterest;
	}
}

