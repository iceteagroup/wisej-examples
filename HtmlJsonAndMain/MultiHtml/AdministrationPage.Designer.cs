namespace MultiHtml
{
    partial class AdministrationPage
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
            this.defaultApplication = new Wisej.Web.Button();
            this.url = new Wisej.Web.Label();
            this.button1 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(100, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administration sub-Application";
            // 
            // defaultApplication
            // 
            this.defaultApplication.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.defaultApplication.Location = new System.Drawing.Point(100, 200);
            this.defaultApplication.Name = "defaultApplication";
            this.defaultApplication.Size = new System.Drawing.Size(300, 40);
            this.defaultApplication.TabIndex = 1;
            this.defaultApplication.Text = "Navigate to Default";
            this.defaultApplication.Click += new System.EventHandler(this.defaultApplication_Click);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(100, 50);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(601, 16);
            this.url.TabIndex = 3;
            this.url.Text = "url";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.Location = new System.Drawing.Point(100, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Navigate to Default.html";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdministrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.url);
            this.Controls.Add(this.defaultApplication);
            this.Controls.Add(this.label1);
            this.Name = "AdministrationPage";
            this.Size = new System.Drawing.Size(941, 804);
            this.Load += new System.EventHandler(this.AdministrationPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label label1;
        private Wisej.Web.Button defaultApplication;
        private Wisej.Web.Label url;
        private Wisej.Web.Button button1;
    }
}
