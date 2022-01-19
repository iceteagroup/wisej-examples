namespace Wisej.ReportingViewers
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
            this.listBox1 = new Wisej.Web.ListBox();
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.LabelText = "Select a report";
            this.listBox1.Location = new System.Drawing.Point(36, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 391);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Use PdfReportViewer";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Use AspNetReportViewer";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1403, 837);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.ListBox listBox1;
        private Web.Button button1;
        private Web.Button button2;
    }
}

