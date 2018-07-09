using System;
using Wisej.Web;

namespace MDIExample
{
    public partial class MainWindow : Form
    {
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
        }

        private void AddMdiChild()
        {
            Form form = new Form() {Text = "Form " + (this.MdiChildren.Length + 1), MdiParent = this};
            form.Show();
        }
    }
}