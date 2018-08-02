namespace DGVEmbeddedNavigator
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
            this.buttonEmbeddedBindingNavigator = new Wisej.Web.Button();
            this.buttonNavigationPanel = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // buttonEmbeddedBindingNavigator
            // 
            this.buttonEmbeddedBindingNavigator.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonEmbeddedBindingNavigator.Location = new System.Drawing.Point(100, 100);
            this.buttonEmbeddedBindingNavigator.Name = "buttonEmbeddedBindingNavigator";
            this.buttonEmbeddedBindingNavigator.Size = new System.Drawing.Size(300, 40);
            this.buttonEmbeddedBindingNavigator.TabIndex = 0;
            this.buttonEmbeddedBindingNavigator.Text = "Embedded BindingNavigator";
            this.buttonEmbeddedBindingNavigator.Click += new System.EventHandler(this.buttonEmbeddedBindingNavigator_Click);
            // 
            // buttonNavigationPanel
            // 
            this.buttonNavigationPanel.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonNavigationPanel.Location = new System.Drawing.Point(100, 230);
            this.buttonNavigationPanel.Name = "buttonNavigationPanel";
            this.buttonNavigationPanel.Size = new System.Drawing.Size(300, 40);
            this.buttonNavigationPanel.TabIndex = 1;
            this.buttonNavigationPanel.Text = "Navigation Panel";
            this.buttonNavigationPanel.Click += new System.EventHandler(this.buttonNavigationPanel_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNavigationPanel);
            this.Controls.Add(this.buttonEmbeddedBindingNavigator);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(917, 779);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Button buttonEmbeddedBindingNavigator;
        private Wisej.Web.Button buttonNavigationPanel;
    }
}
