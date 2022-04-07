
namespace Wisej.Sample.ClrScript
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
            this.menuBar1 = new Wisej.Web.MenuBar();
            this.menuItem1 = new Wisej.Web.MenuItem();
            this.menuItem2 = new Wisej.Web.MenuItem();
            this.lblWisejExtention = new Wisej.Web.Label();
            this.lblMicrosoftRepo = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // menuBar1
            // 
            this.menuBar1.Dock = Wisej.Web.DockStyle.Top;
            this.menuBar1.Font = new System.Drawing.Font("menu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(1312, 28);
            this.menuBar1.TabIndex = 0;
            this.menuBar1.TabStop = false;
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Text = "Command Line";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Text = "Events";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // lblWisejExtention
            // 
            this.lblWisejExtention.AllowHtml = true;
            this.lblWisejExtention.AutoSize = true;
            this.lblWisejExtention.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWisejExtention.Location = new System.Drawing.Point(12, 45);
            this.lblWisejExtention.Name = "lblWisejExtention";
            this.lblWisejExtention.Size = new System.Drawing.Size(977, 19);
            this.lblWisejExtention.TabIndex = 1;
            this.lblWisejExtention.Text = "<a href=\"https://github.com/iceteagroup/wisej-extensions/tree/2.2/Wisej.Ext.Clear" +
    "Script\" target=\"_blank\">Wisej ClearScript Extension</a>";
            // 
            // lblMicrosoftRepo
            // 
            this.lblMicrosoftRepo.AllowHtml = true;
            this.lblMicrosoftRepo.AutoSize = true;
            this.lblMicrosoftRepo.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMicrosoftRepo.Location = new System.Drawing.Point(12, 93);
            this.lblMicrosoftRepo.Name = "lblMicrosoftRepo";
            this.lblMicrosoftRepo.Size = new System.Drawing.Size(1057, 19);
            this.lblMicrosoftRepo.TabIndex = 3;
            this.lblMicrosoftRepo.Text = "For additional information, <a href=\"https://microsoft.github.io/ClearScript/Refe" +
    "rence/html/R_Project_Reference.htm\" target=\"_blank\">Click here!</a>";
            // 
            // label1
            // 
            this.label1.AllowHtml = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1053, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Watch a sample video, <a href=\"https://wisej.s3.amazonaws.com/downloads/Examples/" +
    "clearscript%20sample.mp4\" target=\"_blank\">Click here!</a>";
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackgroundImage = global::Wisej.Sample.ClrScript.Properties.Resources.bg;
            this.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMicrosoftRepo);
            this.Controls.Add(this.lblWisejExtention);
            this.Controls.Add(this.menuBar1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1312, 987);
            this.Text = " Wisej ClearScript Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.MenuBar menuBar1;
        private Web.MenuItem menuItem1;
        private Web.MenuItem menuItem2;
        private Web.Label lblWisejExtention;
        private Web.Label lblMicrosoftRepo;
        private Web.Label label1;
    }
}

