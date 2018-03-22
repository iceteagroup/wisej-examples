namespace KeyboardHandling
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window1));
			this.columnProperty = new Wisej.Web.DataGridViewColumn();
			this.columnValue = new Wisej.Web.DataGridViewColumn();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.textBox1 = new Wisej.Web.TextBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.javaScript = new Wisej.Web.JavaScript(this.components);
			this.SuspendLayout();
			// 
			// columnProperty
			// 
			this.columnProperty.HeaderText = "Property";
			this.columnProperty.Name = "columnProperty";
			this.columnProperty.Width = 200;
			// 
			// columnValue
			// 
			this.columnValue.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.columnValue.HeaderText = "Value";
			this.columnValue.Name = "columnValue";
			// 
			// label1
			// 
			this.label1.AllowHtml = true;
			this.label1.AutoSize = false;
			this.label1.Location = new System.Drawing.Point(21, 31);
			this.label1.Margin = new Wisej.Web.Padding(-1, -1, -1, -1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 276);
			this.label1.TabIndex = 4;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// label2
			// 
			this.label2.AutoSize = false;
			this.label2.BorderStyle = Wisej.Web.BorderStyle.Dotted;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(330, 193);
			this.label2.Margin = new Wisej.Web.Padding(3, 4, 3, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(241, 98);
			this.label2.TabIndex = 1;
			this.label2.Text = "A";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.AutoSize = false;
			this.javaScript.SetJavaScript(this.textBox1, resources.GetString("textBox1.JavaScript"));
			this.textBox1.Location = new System.Drawing.Point(330, 36);
			this.textBox1.Margin = new Wisej.Web.Padding(3, 4, 3, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(241, 48);
			this.textBox1.TabIndex = 2;
			this.textBox1.Watermark = "Type here";
			this.textBox1.KeyPress += new Wisej.Web.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(330, 116);
			this.checkBox1.Margin = new Wisej.Web.Padding(3, 4, 3, 4);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 31);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Handle \"A\" on the client";
			// 
			// Window1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 328);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.Margin = new Wisej.Web.Padding(7, 0, 7, 0);
			this.MinimizeBox = false;
			this.Name = "Window1";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "Window1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.DataGridViewColumn columnProperty;
		private Wisej.Web.DataGridViewColumn columnValue;
		private Wisej.Web.Label label1;
		private Wisej.Web.Label label2;
		private Wisej.Web.TextBox textBox1;
		private Wisej.Web.CheckBox checkBox1;
		private Wisej.Web.JavaScript javaScript;
	}
}

