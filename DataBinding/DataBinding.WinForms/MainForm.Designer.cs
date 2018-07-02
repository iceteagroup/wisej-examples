namespace DataBinding
{
    partial class MainForm
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
            this.textBoxBindingButton = new System.Windows.Forms.Button();
            this.dataGridBindingButton = new System.Windows.Forms.Button();
            this.allBindingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBindingButton
            // 
            this.textBoxBindingButton.BackColor = System.Drawing.Color.SeaGreen;
            this.textBoxBindingButton.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBindingButton.ForeColor = System.Drawing.Color.White;
            this.textBoxBindingButton.Location = new System.Drawing.Point(72, 90);
            this.textBoxBindingButton.Name = "textBoxBindingButton";
            this.textBoxBindingButton.Size = new System.Drawing.Size(175, 37);
            this.textBoxBindingButton.TabIndex = 0;
            this.textBoxBindingButton.Text = "Text Box Binding";
            this.textBoxBindingButton.UseVisualStyleBackColor = false;
            this.textBoxBindingButton.Click += new System.EventHandler(this.textBoxBindingButton_Click);
            // 
            // dataGridBindingButton
            // 
            this.dataGridBindingButton.BackColor = System.Drawing.Color.SteelBlue;
            this.dataGridBindingButton.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridBindingButton.ForeColor = System.Drawing.Color.White;
            this.dataGridBindingButton.Location = new System.Drawing.Point(72, 160);
            this.dataGridBindingButton.Name = "dataGridBindingButton";
            this.dataGridBindingButton.Size = new System.Drawing.Size(175, 37);
            this.dataGridBindingButton.TabIndex = 1;
            this.dataGridBindingButton.Text = "DataGrid Binding";
            this.dataGridBindingButton.UseVisualStyleBackColor = false;
            this.dataGridBindingButton.Click += new System.EventHandler(this.dataGridBindingButton_Click);
            // 
            // allBindingsButton
            // 
            this.allBindingsButton.BackColor = System.Drawing.Color.Orange;
            this.allBindingsButton.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allBindingsButton.ForeColor = System.Drawing.Color.White;
            this.allBindingsButton.Location = new System.Drawing.Point(72, 230);
            this.allBindingsButton.Name = "allBindingsButton";
            this.allBindingsButton.Size = new System.Drawing.Size(175, 37);
            this.allBindingsButton.TabIndex = 2;
            this.allBindingsButton.Text = "All Bindings";
            this.allBindingsButton.UseVisualStyleBackColor = false;
            this.allBindingsButton.Click += new System.EventHandler(this.allBindingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 548);
            this.Controls.Add(this.allBindingsButton);
            this.Controls.Add(this.dataGridBindingButton);
            this.Controls.Add(this.textBoxBindingButton);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button textBoxBindingButton;
        private System.Windows.Forms.Button dataGridBindingButton;
        private System.Windows.Forms.Button allBindingsButton;
    }
}

