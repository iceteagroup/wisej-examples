namespace PageNavigation
{
    partial class ErrorPage
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
            this.titleLabel = new Wisej.Web.Label();
            this.continueButton = new Wisej.Web.Button();
            this.details = new Wisej.Web.Label();
            this.exit = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.titleLabel.BackColor = System.Drawing.Color.FromName("@invalid");
            this.titleLabel.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.titleLabel.ForeColor = System.Drawing.Color.FromName("@buttonText");
            this.titleLabel.Location = new System.Drawing.Point(138, 85);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(719, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Application error";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.continueButton.Location = new System.Drawing.Point(138, 395);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(200, 40);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // details
            // 
            this.details.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.details.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.details.Location = new System.Drawing.Point(138, 200);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(719, 126);
            this.details.TabIndex = 3;
            this.details.Text = "There was a serious application error. The cause of the error is unknown at this " +
    "time.\r\n\r\nWe should display some details of the error here.";
            // 
            // exit
            // 
            this.exit.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.exit.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exit.Location = new System.Drawing.Point(657, 395);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(200, 40);
            this.exit.TabIndex = 4;
            this.exit.Text = "Give up";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ErrorPage
            // 
            this.AcceptButton = this.continueButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.details);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "ErrorPage";
            this.Size = new System.Drawing.Size(938, 804);
            this.Appear += new System.EventHandler(this.ErrorPage_Appear);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Label titleLabel;
        private Wisej.Web.Button continueButton;
        private Wisej.Web.Label details;
        private Wisej.Web.Button exit;
    }
}
