namespace MultiHtml
{
    partial class DefaultPage
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
            this.administration = new Wisej.Web.Button();
            this.administrationHtml = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.url = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // administration
            // 
            this.administration.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.administration.Location = new System.Drawing.Point(100, 100);
            this.administration.Name = "administration";
            this.administration.Size = new System.Drawing.Size(300, 40);
            this.administration.TabIndex = 0;
            this.administration.Text = "Navigate to Administration";
            this.administration.Click += new System.EventHandler(this.administration_Click);
            // 
            // administrationHtml
            // 
            this.administrationHtml.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.administrationHtml.Location = new System.Drawing.Point(100, 200);
            this.administrationHtml.Name = "administrationHtml";
            this.administrationHtml.Size = new System.Drawing.Size(300, 40);
            this.administrationHtml.TabIndex = 1;
            this.administrationHtml.Text = "Navigate to Administration.html";
            this.administrationHtml.Click += new System.EventHandler(this.administrationHtml_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(100, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Default sub-Application";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(100, 50);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(601, 16);
            this.url.TabIndex = 3;
            this.url.Text = "url";
            // 
            // DefaultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.url);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.administrationHtml);
            this.Controls.Add(this.administration);
            this.Name = "DefaultPage";
            this.Size = new System.Drawing.Size(941, 804);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.DefaultPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Button administration;
        private Wisej.Web.Button administrationHtml;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label url;
    }
}

