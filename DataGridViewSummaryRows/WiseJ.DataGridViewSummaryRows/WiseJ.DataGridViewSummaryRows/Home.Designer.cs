
namespace WiseJ.DataGridViewSummaryRows
{
    partial class Home
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
            this.btnCase1 = new Wisej.Web.Button();
            this.btnCase2 = new Wisej.Web.Button();
            this.btnSummaryGroup = new Wisej.Web.Button();
            this.btnAllCallsSummary = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // btnCase1
            // 
            this.btnCase1.Location = new System.Drawing.Point(55, 194);
            this.btnCase1.Name = "btnCase1";
            this.btnCase1.Size = new System.Drawing.Size(227, 54);
            this.btnCase1.TabIndex = 0;
            this.btnCase1.Text = "Huge Data 1";
            this.btnCase1.Click += new System.EventHandler(this.btnCase1_Click);
            // 
            // btnCase2
            // 
            this.btnCase2.Location = new System.Drawing.Point(55, 254);
            this.btnCase2.Name = "btnCase2";
            this.btnCase2.Size = new System.Drawing.Size(227, 53);
            this.btnCase2.TabIndex = 1;
            this.btnCase2.Text = "Huge Data 2";
            this.btnCase2.Click += new System.EventHandler(this.btnCase2_Click);
            // 
            // btnSummaryGroup
            // 
            this.btnSummaryGroup.Location = new System.Drawing.Point(55, 135);
            this.btnSummaryGroup.Name = "btnSummaryGroup";
            this.btnSummaryGroup.Size = new System.Drawing.Size(227, 53);
            this.btnSummaryGroup.TabIndex = 2;
            this.btnSummaryGroup.Text = "Sumamry Group";
            this.btnSummaryGroup.Click += new System.EventHandler(this.btnSummaryGroup_Click);
            // 
            // btnAllCallsSummary
            // 
            this.btnAllCallsSummary.Location = new System.Drawing.Point(55, 76);
            this.btnAllCallsSummary.Name = "btnAllCallsSummary";
            this.btnAllCallsSummary.Size = new System.Drawing.Size(227, 53);
            this.btnAllCallsSummary.TabIndex = 3;
            this.btnAllCallsSummary.Text = "All Calls for Summary";
            this.btnAllCallsSummary.Click += new System.EventHandler(this.btnAllCallsSummary_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.btnAllCallsSummary);
            this.Controls.Add(this.btnSummaryGroup);
            this.Controls.Add(this.btnCase2);
            this.Controls.Add(this.btnCase1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(811, 669);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Button btnCase1;
        private Wisej.Web.Button btnCase2;
        private Wisej.Web.Button btnSummaryGroup;
        private Wisej.Web.Button btnAllCallsSummary;
    }
}
