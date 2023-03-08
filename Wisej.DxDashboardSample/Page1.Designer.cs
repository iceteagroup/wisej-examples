namespace Wisej.DxDashboardSample
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
			this.dxDashboard1 = new Wisej.Web.Ext.DxDashboard.DxDashboard();
			this.buttonWorkingMode = new Wisej.Web.Button();
			this.label1 = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// dxDashboard1
			// 
			this.dxDashboard1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxDashboard1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.dxDashboard1.Location = new System.Drawing.Point(410, 160);
			this.dxDashboard1.Name = "dxDashboard1";
			this.dxDashboard1.Size = new System.Drawing.Size(1086, 542);
			this.dxDashboard1.TabIndex = 0;
			this.dxDashboard1.Text = "dxDashboard1";
			this.dxDashboard1.WebRequest += new Wisej.Web.WebRequestHandler(this.dxDashboard1_WebRequest);
			// 
			// buttonWorkingMode
			// 
			this.buttonWorkingMode.Anchor = Wisej.Web.AnchorStyles.Left;
			this.buttonWorkingMode.Location = new System.Drawing.Point(123, 413);
			this.buttonWorkingMode.Name = "buttonWorkingMode";
			this.buttonWorkingMode.Size = new System.Drawing.Size(156, 37);
			this.buttonWorkingMode.TabIndex = 1;
			this.buttonWorkingMode.Text = "Toggle Working Mode";
			this.buttonWorkingMode.Click += new System.EventHandler(this.buttonWorkingMode_Click);
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(712, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(458, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Restore /Data/nwind.mdb to a SQL database and update the connection string.";
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonWorkingMode);
			this.Controls.Add(this.dxDashboard1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1882, 862);
			this.Load += new System.EventHandler(this.Page1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Web.Ext.DxDashboard.DxDashboard dxDashboard1;
        private Web.Button buttonWorkingMode;
		private Web.Label label1;
	}
}

