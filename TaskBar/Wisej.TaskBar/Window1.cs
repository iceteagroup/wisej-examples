
using System;
using Wisej.Web;

namespace Wisej.TaskBar
{
    public partial class SimpleWindow : Form
    {
        Wisej.Web.Ext.TaskBar.TaskBar TaskBar;
        public SimpleWindow()
        {
            InitializeComponent();
            TaskBar = new Web.Ext.TaskBar.TaskBar();
        }
    }
}
