namespace PageApplication
{
    partial class SwitchForm
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
            this.button1 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Switch Page";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 156);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Name = "SwitchForm";
            this.StartPosition = Wisej.Web.FormStartPosition.Manual;
            this.Text = "Switch Form";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Button button1;
    }
}