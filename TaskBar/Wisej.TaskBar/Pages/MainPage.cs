using System;
using System.IO;
using Wisej.Web;


namespace Wisej.TaskBar.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var basePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var window = new Apps.FileExplorerWindow.FileExplorer(basePath);
            window.Show();
        }
        private void btnSimpleWindow_Click(object sender, EventArgs e)
        {
            var window = new SimpleWindow();
            window.Show();
        }
    }
}
