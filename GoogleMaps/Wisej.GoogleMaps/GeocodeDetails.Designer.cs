namespace Wisej.GoogleMaps
{
    partial class GeocodeDetails
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
            this.treeView = new Wisej.Web.TreeView();
            this.buttonExpandAll = new Wisej.Web.Button();
            this.buttonCollapseAll = new Wisej.Web.Button();
            this.title = new Wisej.Web.Label();
            this.buttonExpandRoot = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(0, 79);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(608, 356);
            this.treeView.TabIndex = 0;
            // 
            // buttonExpandAll
            // 
            this.buttonExpandAll.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.buttonExpandAll.Location = new System.Drawing.Point(438, 454);
            this.buttonExpandAll.Name = "buttonExpandAll";
            this.buttonExpandAll.Size = new System.Drawing.Size(120, 27);
            this.buttonExpandAll.TabIndex = 1;
            this.buttonExpandAll.Text = "Expand All";
            this.buttonExpandAll.Click += new System.EventHandler(this.buttonExpandAll_Click);
            // 
            // buttonCollapseAll
            // 
            this.buttonCollapseAll.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.buttonCollapseAll.Location = new System.Drawing.Point(50, 454);
            this.buttonCollapseAll.Name = "buttonCollapseAll";
            this.buttonCollapseAll.Size = new System.Drawing.Size(120, 27);
            this.buttonCollapseAll.TabIndex = 2;
            this.buttonCollapseAll.Text = "Collapse All";
            this.buttonCollapseAll.Click += new System.EventHandler(this.buttonCollapseAll_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.title.Location = new System.Drawing.Point(10, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(50, 30);
            this.title.TabIndex = 3;
            this.title.Text = "title";
            // 
            // buttonExpandRoot
            // 
            this.buttonExpandRoot.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonExpandRoot.Location = new System.Drawing.Point(247, 454);
            this.buttonExpandRoot.Name = "buttonExpandRoot";
            this.buttonExpandRoot.Size = new System.Drawing.Size(120, 27);
            this.buttonExpandRoot.TabIndex = 4;
            this.buttonExpandRoot.Text = "Expand Root";
            this.buttonExpandRoot.Click += new System.EventHandler(this.buttonExpandRoot_Click);
            // 
            // GeocodeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 505);
            this.Controls.Add(this.buttonExpandRoot);
            this.Controls.Add(this.title);
            this.Controls.Add(this.buttonCollapseAll);
            this.Controls.Add(this.buttonExpandAll);
            this.Controls.Add(this.treeView);
            this.Name = "GeocodeDetails";
            this.Text = "GeocodeDetails";
            this.Load += new System.EventHandler(this.GeocodeDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.TreeView treeView;
        private Web.Button buttonExpandAll;
        private Web.Button buttonCollapseAll;
        private Web.Label title;
        private Web.Button buttonExpandRoot;
    }
}