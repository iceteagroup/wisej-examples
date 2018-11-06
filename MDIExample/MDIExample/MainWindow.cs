using System;
using System.Drawing;
using Wisej.Web;

namespace MDIExample
{
    public partial class MainWindow : Form
    {
        private Modeless modeless;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            AddMdiChild();
            AddMdiChild();
            AddMdiChild();

            // uncomment the line below to hide the Show thumbnais button
            //this.MdiTabProperties.ShowThumbnails = false;
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == this.addMdiChild)
            {
                AddMdiChild();
            }
            else if (e.Button == this.closeMdiChild)
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
            }
            else if (e.Button == this.activateFirstMdiChild)
            {
                if (this.MdiChildren.Length > 0)
                {
                    this.MdiChildren[0].Visible = true;
                    this.MdiChildren[0].Activate();
                }
            }
            else if (e.Button == this.showModeless)
            {
                ShowModeless();
            }
            else if (e.Button == this.showHideThumbnails)
            {
                if (this.MdiTabProperties.ShowThumbnails)
                {
                    this.MdiTabProperties.ShowThumbnails = false;
                    this.showHideThumbnails.Text = "Show Thumbnails Buttom";
                }
                else
                {
                    this.MdiTabProperties.ShowThumbnails = true;
                    this.showHideThumbnails.Text = "Hide Thumbnails Buttom";
                }
            }
        }

        private void AddMdiChild()
        {
            var name = "Form " + (this.MdiChildren.Length + 1);
            Form form = new ChildMdi(name) {Text = name, MdiParent = this};
            form.Show();
        }

        private void ShowModeless()
        {
            if (modeless == null)
            {
                modeless = new Modeless();
                modeless.Location = new Point(this.Width - modeless.Width-10, this.Height - modeless.Height-10);
                modeless.TopMost = true;
            }

            modeless.Show();
        }
    }
}