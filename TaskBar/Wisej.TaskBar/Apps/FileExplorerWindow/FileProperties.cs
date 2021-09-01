using System;
using System.IO;
using Wisej.Web;

namespace Wisej.TaskBar.Apps.FileExplorerWindow
{
    public partial class FileProperties : Form
    {
        private FileInfo CurrentFileInfo { get; set; }
        private string CurrentPath { get; set; }
        public FileProperties(Models.Item item)
        {
            InitializeComponent();
            CurrentPath = item.Path;
            CurrentFileInfo = new FileInfo(item.Path);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (!CurrentFileInfo.Exists)
                    throw new Exception($"Path {CurrentPath} not found");


                txtbxPath.Text = CurrentFileInfo.FullName;
                lblSize.Text = CurrentFileInfo.Length < 1000 ? string.Format("{0:0.00}", CurrentFileInfo.Length) + " octets" : 
                    (CurrentFileInfo.Length < 1000000 ? string.Format("{0:0.00}", CurrentFileInfo.Length / (1024)) + " Ko" : 
                    string.Format("{0:0.00}", CurrentFileInfo.Length / (1024*1024)) + " Mo");
                lblCreationDate.Text = CurrentFileInfo.CreationTime.ToLongDateString();
                lblPath.Text = CurrentFileInfo.FullName;
                lblType.Text = CurrentFileInfo.Extension;
                lblType2.Text = CurrentFileInfo.Extension.ToUpper();

            }
            catch (Exception e)
            {
                AlertBox.Show(e.Message, MessageBoxIcon.Error);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
