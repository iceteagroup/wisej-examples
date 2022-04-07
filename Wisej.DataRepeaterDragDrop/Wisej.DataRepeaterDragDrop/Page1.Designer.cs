namespace Wisej.DataRepeaterDragDrop
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
            this.components = new System.ComponentModel.Container();
            this.dataRepeater1 = new Wisej.Web.DataRepeater();
            this.textBox1 = new Wisej.Web.TextBox();
            this.modelBindingSource = new Wisej.Web.BindingSource(this.components);
            this.label1 = new Wisej.Web.Label();
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).BeginInit();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.AllowDrag = true;
            this.dataRepeater1.AllowDrop = true;
            this.dataRepeater1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.dataRepeater1.ItemSize = new System.Drawing.Size(200, 100);
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Controls.Add(this.textBox1);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label1);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(393, 100);
            this.dataRepeater1.Location = new System.Drawing.Point(44, 43);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(395, 658);
            this.dataRepeater1.TabIndex = 0;
            this.dataRepeater1.Text = "dataRepeater1";
            this.dataRepeater1.ItemSelected += new Wisej.Web.DataRepeaterItemEventHandler(this.dataRepeater1_ItemSelected);
            this.dataRepeater1.DragDrop += new Wisej.Web.DragEventHandler(this.dataRepeater1_DragDrop);
            this.dataRepeater1.DragEnter += new Wisej.Web.DragEventHandler(this.dataRepeater1_DragEnter);
            this.dataRepeater1.DragStart += new System.EventHandler(this.dataRepeater1_DragStart);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.modelBindingSource, "Name", true));
            this.textBox1.LabelText = "Name";
            this.textBox1.Location = new System.Drawing.Point(24, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 42);
            this.textBox1.TabIndex = 1;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(Wisej.DataRepeaterDragDrop.Model);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new Wisej.Web.Binding("Text", this.modelBindingSource, "ID", true));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Display = Wisej.Web.Display.Icon;
            this.button1.Enabled = false;
            this.button1.ImageSource = "icon-up";
            this.button1.Location = new System.Drawing.Point(465, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Display = Wisej.Web.Display.Icon;
            this.button2.Enabled = false;
            this.button2.ImageSource = "icon-down";
            this.button2.Location = new System.Drawing.Point(465, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataRepeater1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(999, 736);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).EndInit();
            this.dataRepeater1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Web.DataRepeater dataRepeater1;
		private Web.TextBox textBox1;
		private Web.Label label1;
		private Web.BindingSource modelBindingSource;
		private Web.Button button1;
		private Web.Button button2;
	}
}

