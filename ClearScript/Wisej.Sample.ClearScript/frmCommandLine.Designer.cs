
namespace Wisej.Sample.ClrScript
{
    partial class frmCommandLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommandLine));
            this.txtCommandLine = new Wisej.Web.TextBox();
            this.SuspendLayout();
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.AcceptsReturn = true;
            this.txtCommandLine.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            this.txtCommandLine.BorderStyle = Wisej.Web.BorderStyle.None;
            this.txtCommandLine.Dock = Wisej.Web.DockStyle.Fill;
            this.txtCommandLine.Font = new System.Drawing.Font("default, Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCommandLine.ForeColor = System.Drawing.Color.FromArgb(63, 191, 107);
            this.txtCommandLine.Location = new System.Drawing.Point(0, 0);
            this.txtCommandLine.Multiline = true;
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(1107, 715);
            this.txtCommandLine.TabIndex = 0;
            this.txtCommandLine.Text = resources.GetString("txtCommandLine.Text");
            this.txtCommandLine.KeyPress += new Wisej.Web.KeyPressEventHandler(this.txtCommandLine_KeyPress);
            // 
            // frmCommandLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 715);
            this.Controls.Add(this.txtCommandLine);
            this.Name = "frmCommandLine";
            this.Text = "Command Line";
            this.Load += new System.EventHandler(this.frmCommandLine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.TextBox txtCommandLine;
    }
}