using System;
using System.Drawing;
using System.IO;
using Wisej.Web;

namespace Wisej.TaskBar.Apps.FileExplorerWindow
{
    public partial class FileExplorer : Form
    {
        private string UriBackup { get; set; }
        FileExplorerContext Context { get; set; }
        public FileExplorer(string path)
        {
            InitializeComponent();
            Context = new FileExplorerContext(path);
            txtbxCurrentPath.DataBindings.Add(new Binding("Text", Context, "CurrentPath"));
            UriBackup = path;
            RefreshView();
        }


        private void RefreshView()
        {
            list.Items.Clear();
            foreach(var item in Context.Items)
            {
                var listViewItem = new ListViewItem();
                if(item.Type == Models.ItemType.Folder)
                {
                    listViewItem.ContextMenu = new ContextMenu(new MenuItem[] {
                        new MenuItem{
                            Text = "Open in new window",
                            Tag = new Tuple<string,Models.Item>( "open-new-window", item)
                        },
                        new MenuItem{
                            Text = "Open",
                            Tag = new Tuple<string,Models.Item>("open", item),
                        },
                        new MenuItem{
                            Text = "Properties",
                            Tag = new Tuple<string,Models.Item>("properties", item)
                        }
                    });
                }
                else
                {
                    listViewItem.ContextMenu = new ContextMenu(new MenuItem[] {
                        new MenuItem{
                            Text = "Properties",
                            Tag = new Tuple<string,Models.Item>("details", item)
                        }
                    });
                }
                
                listViewItem.ContextMenu.MenuItemClicked += ContextMenu_MenuItemClicked;
                listViewItem.Tag  = item;
                listViewItem.ImageSource = item.Type == Models.ItemType.Folder ?"/Resources/icons8_folder_96px.png": "/Resources/icons8_file_96px.png";
                listViewItem.Text = item.Name;
                listViewItem.ToolTipText = item.Name;
                listViewItem.SubItems.Add(item.Size);
                list.Items.Add(listViewItem);
            }
        }

        private void ContextMenu_MenuItemClicked(object sender, MenuItemEventArgs e)
        {
            try
            {
                var data = (Tuple<string, Models.Item>)e.MenuItem.Tag;
                if (data.Item1 == "open")
                {
                    Context.CurrentPath = data.Item2.Path;
                    RefreshView();
                    UriBackup = Context.CurrentPath;
                }
                else if (data.Item1 == "open-new-window")
                {
                    var window = new FileExplorer(data.Item2.Path);
                    window.Show();
                }
                else if (data.Item1 == "properties")
                {
                    var window = new FolderProperties(data.Item2);
                    window.ShowDialog();
                }
                else if (data.Item1 == "details")
                {
                    var window = new FileProperties(data.Item2);
                    window.ShowDialog();
                }
                else
                    return;

            }
            catch (Exception ex)
            {

                AlertBox.Show(ex.Message, MessageBoxIcon.Error);
                Context.CurrentPath = UriBackup;
            }
        }

        private void list_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Context.CurrentPath = ((Models.Item)e.Item.Tag).Path;
                Context.LoadAllItem();
                RefreshView();

            }
            catch (Exception ex)
            {

                AlertBox.Show(ex.Message, MessageBoxIcon.Error);
                Context.CurrentPath = UriBackup;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(txtbxCurrentPath.Text);
                if (!directory.Exists)
                    throw new Exception(txtbxCurrentPath.Text+" doesn't exist");
                Context.CurrentPath = directory.FullName;
                Context.LoadAllItem();
                RefreshView();
            }
            catch (Exception ex)
            {
                AlertBox.Show(ex.Message,MessageBoxIcon.Error);
                Context.CurrentPath = UriBackup;
            }
        }

        private void btnParentFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var currentDirectory = new DirectoryInfo(Context.CurrentPath);
                if (currentDirectory.Parent == null)
                    throw new Exception("Parent not found");

                Context.CurrentPath = currentDirectory.Parent.FullName;
                Context.LoadAllItem();
                RefreshView();
            }
            catch (Exception ex)
            {
                AlertBox.Show(ex.Message, MessageBoxIcon.Error);
            }

        }
    }
}
