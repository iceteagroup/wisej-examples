namespace AspNetAuthentication.WisejViews
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
            this.isAuthenticated = new Wisej.Web.Label();
            this.identity = new Wisej.Web.Label();
            this.checkButton = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // isAuthenticated
            // 
            this.isAuthenticated.AutoSize = true;
            this.isAuthenticated.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isAuthenticated.Location = new System.Drawing.Point(150, 100);
            this.isAuthenticated.Name = "isAuthenticated";
            this.isAuthenticated.Size = new System.Drawing.Size(201, 33);
            this.isAuthenticated.TabIndex = 2;
            this.isAuthenticated.Text = "isAuthenticated";
            // 
            // identity
            // 
            this.identity.AutoSize = true;
            this.identity.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.identity.Location = new System.Drawing.Point(150, 150);
            this.identity.Name = "identity";
            this.identity.Size = new System.Drawing.Size(100, 33);
            this.identity.TabIndex = 1;
            this.identity.Text = "identity";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(150, 300);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(197, 63);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Check";
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.identity);
            this.Controls.Add(this.isAuthenticated);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(910, 804);
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label isAuthenticated;
        private Wisej.Web.Label identity;
        private Wisej.Web.Button checkButton;
    }
}
