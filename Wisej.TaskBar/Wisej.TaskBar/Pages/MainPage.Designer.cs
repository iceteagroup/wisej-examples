
namespace Wisej.TaskBar.Pages
{
    partial class MainPage
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
            this.taskBar1 = new Wisej.Web.Ext.TaskBar.TaskBar();
            this.panel1 = new Wisej.Web.Panel();
            this.btnSimpleWindow = new Wisej.Web.Button();
            this.btnFileExplorer = new Wisej.Web.Button();
            this.panel2 = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskBar1
            // 
            this.taskBar1.Location = new System.Drawing.Point(0, 627);
            this.taskBar1.Name = "taskBar1";
            this.taskBar1.Size = new System.Drawing.Size(1511, 42);
            this.taskBar1.TabIndex = 0;
            this.taskBar1.Text = "taskBar1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSimpleWindow);
            this.panel1.Controls.Add(this.btnFileExplorer);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1511, 588);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // btnSimpleWindow
            // 
            this.btnSimpleWindow.Image = global::Wisej.TaskBar.Properties.Resources.icons8_statistics_96px;
            this.btnSimpleWindow.ImageSpacing = 0;
            this.btnSimpleWindow.Location = new System.Drawing.Point(189, 16);
            this.btnSimpleWindow.Name = "btnSimpleWindow";
            this.btnSimpleWindow.Padding = new Wisej.Web.Padding(20);
            this.btnSimpleWindow.Size = new System.Drawing.Size(150, 130);
            this.btnSimpleWindow.TabIndex = 2;
            this.btnSimpleWindow.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            this.btnSimpleWindow.ToolTipText = "Simple window";
            this.btnSimpleWindow.Click += new System.EventHandler(this.btnSimpleWindow_Click);
            // 
            // btnFileExplorer
            // 
            this.btnFileExplorer.Image = global::Wisej.TaskBar.Properties.Resources.icons8_folder_96px;
            this.btnFileExplorer.ImageSpacing = 0;
            this.btnFileExplorer.Location = new System.Drawing.Point(16, 16);
            this.btnFileExplorer.Name = "btnFileExplorer";
            this.btnFileExplorer.Padding = new Wisej.Web.Padding(20);
            this.btnFileExplorer.Size = new System.Drawing.Size(150, 130);
            this.btnFileExplorer.TabIndex = 1;
            this.btnFileExplorer.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            this.btnFileExplorer.ToolTipText = "File Explorer";
            this.btnFileExplorer.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Dock = Wisej.Web.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1234, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 588);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Wisej.Web.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new Wisej.Web.Padding(13);
            this.label1.Name = "label1";
            this.label1.Padding = new Wisej.Web.Padding(10, 10, 10, 0);
            this.label1.Size = new System.Drawing.Size(1511, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apps";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskBar1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1511, 669);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Ext.TaskBar.TaskBar taskBar1;
        private Web.Panel panel1;
        private Web.Panel panel2;
        private Web.Button btnFileExplorer;
        private Web.Label label1;
        private Web.Button btnSimpleWindow;
    }
}
