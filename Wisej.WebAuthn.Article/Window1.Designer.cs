namespace Wisej.WebAuthn.Article
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
            this.buttonRegister = new Wisej.Web.Button();
            this.buttonGet = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(191, 131);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(231, 37);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Register Credentials";
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonGet
            // 
            this.buttonGet.Enabled = false;
            this.buttonGet.Location = new System.Drawing.Point(191, 264);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(231, 37);
            this.buttonGet.TabIndex = 1;
            this.buttonGet.Text = "Get and Validate Signature";
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 432);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.buttonRegister);
            this.KeepCentered = true;
            this.Name = "Window1";
            this.Text = "WebAuthn";
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Button buttonRegister;
        private Web.Button buttonGet;
    }
}

