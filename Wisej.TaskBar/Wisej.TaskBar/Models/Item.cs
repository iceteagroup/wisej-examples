using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wisej.TaskBar.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public ItemType Type { get; set; }
        public string Extension { get; set; } = null;
        public string Size { get; set; } 
    }
    public enum ItemType
    {
        Folder, File, Shortcut
    }
}