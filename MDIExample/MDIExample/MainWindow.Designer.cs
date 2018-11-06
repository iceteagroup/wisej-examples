namespace MDIExample
{
    partial class MainWindow
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
            this.toolBar1 = new Wisej.Web.ToolBar();
            this.addMdiChild = new Wisej.Web.ToolBarButton();
            this.closeMdiChild = new Wisej.Web.ToolBarButton();
            this.activateFirstMdiChild = new Wisej.Web.ToolBarButton();
            this.separator1 = new Wisej.Web.ToolBarButton();
            this.showModeless = new Wisej.Web.ToolBarButton();
            this.separator2 = new Wisej.Web.ToolBarButton();
            this.showHideThumbnails = new Wisej.Web.ToolBarButton();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.AutoSize = false;
            this.toolBar1.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
            this.addMdiChild,
            this.closeMdiChild,
            this.activateFirstMdiChild,
            this.separator1,
            this.showModeless,
            this.separator2,
            this.showHideThumbnails});
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(676, 51);
            this.toolBar1.TabIndex = 1;
            this.toolBar1.TabStop = false;
            this.toolBar1.ButtonClick += new Wisej.Web.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // addMdiChild
            // 
            this.addMdiChild.ImageSource = "window-maximize";
            this.addMdiChild.Name = "addMdiChild";
            this.addMdiChild.Text = "Create MDI";
            // 
            // closeMdiChild
            // 
            this.closeMdiChild.ImageSource = "window-minimize";
            this.closeMdiChild.Name = "closeMdiChild";
            this.closeMdiChild.Text = "Close MDI";
            // 
            // activateFirstMdiChild
            // 
            this.activateFirstMdiChild.ImageSource = "window-icon";
            this.activateFirstMdiChild.Name = "activateFirstMdiChild";
            this.activateFirstMdiChild.Text = "Activate First MDI";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Style = Wisej.Web.ToolBarButtonStyle.Separator;
            // 
            // showModeless
            // 
            this.showModeless.ImageSource = "icon-file";
            this.showModeless.Name = "showModeless";
            this.showModeless.Text = "Show Modeless";
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            this.separator2.Style = Wisej.Web.ToolBarButtonStyle.Separator;
            // 
            // showHideThumbnails
            // 
            this.showHideThumbnails.ImageSource = "icon-preview";
            this.showHideThumbnails.Name = "showHideThumbnails";
            this.showHideThumbnails.Text = "Hide Thumbnails Buttom";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 472);
            this.CloseBox = false;
            this.ControlBox = false;
            this.Controls.Add(this.toolBar1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "MainWindow";
            this.Text = "Window1";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.ToolBar toolBar1;
        private Wisej.Web.ToolBarButton addMdiChild;
        private Wisej.Web.ToolBarButton closeMdiChild;
        private Wisej.Web.ToolBarButton activateFirstMdiChild;
        private Wisej.Web.ToolBarButton showModeless;
        private Wisej.Web.ToolBarButton separator1;
        private Wisej.Web.ToolBarButton separator2;
        private Wisej.Web.ToolBarButton showHideThumbnails;
    }
}

