using System;
using System.IO;
using System.Threading.Tasks;
using Wisej.Web;

namespace Wisej.TaskBar.Apps.FileExplorerWindow
{
    public partial class FolderProperties : Form
    {
        private DirectoryInfo CurrentFolder { get; set; }
        public FolderProperties(Models.Item folder)
        {
            InitializeComponent();
            CurrentFolder = new DirectoryInfo(folder.Path);
            InitializeData();
            LoadFolderSizeAsync();
        }

        private async void LoadFolderSizeAsync()
        {
            await Application.StartTask(async () =>
            {
                FileInfo[] files = CurrentFolder.GetFiles("*.*", SearchOption.AllDirectories);
                double size = 0;
                foreach(var file in files)
                {
                    size += file.Length;
                    lblSize.Text = size <1000 ? string.Format("{0:0.00}", size)+" octets": (size<1000000 ? string.Format("{0:0.00}", size/1000)+" Ko" : string.Format("{0:0.00}", size/1000000)+" Mo");
                    Application.Update(this);
                }
            });
        }

        private void InitializeData()
        {
            lblCreationDate.Text = CurrentFolder.CreationTime.ToLongDateString();
            txtbxPath.Text = CurrentFolder.FullName;
            lblPath.Text = CurrentFolder.FullName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
