using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using Wisej.Web;

namespace Wisej.TaskBar.Apps.FileExplorerWindow
{
    public class FileExplorerContext: Models.BaseContext
    {
        public BindingList<Models.Item> Items { get; set; } = new BindingList<Models.Item>();
        private string _currentPath;
        public string CurrentPath
        {
            get => _currentPath;
            set
            {
                _currentPath = value;
                OnPropertyChanged("CurrentPath");
            }
        }
        public FileExplorerContext(string path)
        {
            CurrentPath = path;
            LoadAllItem();

        }

        public void LoadAllItem()
        {
            try
            {
                Items.Clear();
                var directories = Directory.GetDirectories(CurrentPath);
                var files = Directory.GetFiles(CurrentPath);
                foreach (var directory in directories)
                {
                    var currentDirectory = new DirectoryInfo(directory);
                    Items.Add(new Models.Item
                    {
                        Extension = null,
                        Id = Guid.NewGuid().ToString(),
                        Name = currentDirectory.Name,
                        Type = Models.ItemType.Folder,
                        Path = currentDirectory.FullName,
                        Size = ""
                    });
                }
                foreach (var file in files)
                {
                    var currentFile = new FileInfo(file);
                    Items.Add(new Models.Item
                    {
                        Extension = currentFile.Extension,
                        Id = Guid.NewGuid().ToString(),
                        Name = currentFile.Name,
                        Type = Models.ItemType.File,
                        Path = currentFile.FullName,
                        Size = currentFile.Length < 1000 ? string.Format("{0:0.00}", currentFile.Length) + " octets" : (currentFile.Length < 1000000 ? string.Format("{0:0.00}", currentFile.Length / 1000) + " Ko" : string.Format("{0:0.00}", currentFile.Length / 1000000) + " Mo")
                    });
                }

            }
            catch (Exception e)
            {
                AlertBox.Show($"{e.Message}", MessageBoxIcon.Error);
            }
              
        }
    }
}