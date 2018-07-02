namespace PageNavigation
{
    partial class Settings
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
            this.textBox1 = new Wisej.Web.TextBox();
            this.textBox2 = new Wisej.Web.TextBox();
            this.label2 = new Wisej.Web.Label();
            this.textBox3 = new Wisej.Web.TextBox();
            this.label3 = new Wisej.Web.Label();
            this.textBox4 = new Wisej.Web.TextBox();
            this.label4 = new Wisej.Web.Label();
            this.titleLabel = new Wisej.Web.Label();
            this.save = new Wisej.Web.Button();
            this.close = new Wisej.Web.Button();
            this.errorButton = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 228);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 293);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(300, 22);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telephone";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromName("@buttonFace");
            this.titleLabel.Dock = Wisej.Web.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(938, 40);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "User settings";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(50, 390);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(200, 40);
            this.save.TabIndex = 9;
            this.save.Text = "Save";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(300, 390);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(200, 40);
            this.close.TabIndex = 10;
            this.close.Text = "Close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // errorButton
            // 
            this.errorButton.Location = new System.Drawing.Point(300, 466);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(200, 40);
            this.errorButton.TabIndex = 11;
            this.errorButton.Text = "Unknown Issue";
            this.errorButton.Click += new System.EventHandler(this.errorButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.errorButton);
            this.Controls.Add(this.close);
            this.Controls.Add(this.save);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(938, 804);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label label1;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.TextBox textBox2;
        private Wisej.Web.Label label2;
        private Wisej.Web.TextBox textBox3;
        private Wisej.Web.Label label3;
        private Wisej.Web.TextBox textBox4;
        private Wisej.Web.Label label4;
        private Wisej.Web.Label titleLabel;
        private Wisej.Web.Button save;
        private Wisej.Web.Button close;
        private Wisej.Web.Button errorButton;
    }
}
