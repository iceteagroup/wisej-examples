namespace Wisej.SlideBar
{
	partial class UserControl1
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
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.panel1 = new Wisej.Web.Panel();
			this.button1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.button3 = new Wisej.Web.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AllowHtml = true;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "<b>User Control</b>";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(10, 37);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(76, 23);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Option 1";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(10, 66);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(76, 23);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "Option 2";
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(10, 95);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(76, 23);
			this.checkBox3.TabIndex = 3;
			this.checkBox3.Text = "Option 3";
			// 
			// checkBox4
			// 
			this.checkBox4.Location = new System.Drawing.Point(10, 124);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(76, 23);
			this.checkBox4.TabIndex = 4;
			this.checkBox4.Text = "Option 3";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = Wisej.Web.BorderStyle.Double;
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(101, 29);
			this.panel1.Name = "panel1";
			this.panel1.ShowCloseButton = false;
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(111, 125);
			this.panel1.TabIndex = 5;
			this.panel1.Text = "Actions";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(11, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 21);
			this.button1.TabIndex = 0;
			this.button1.Text = "Action 1";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(11, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 21);
			this.button2.TabIndex = 1;
			this.button2.Text = "Action 2";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(11, 69);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(88, 21);
			this.button3.TabIndex = 2;
			this.button3.Text = "Action 3";
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label1);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(225, 172);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Label label1;
		private Web.CheckBox checkBox1;
		private Web.CheckBox checkBox2;
		private Web.CheckBox checkBox3;
		private Web.CheckBox checkBox4;
		private Web.Panel panel1;
		private Web.Button button3;
		private Web.Button button2;
		private Web.Button button1;
	}
}
