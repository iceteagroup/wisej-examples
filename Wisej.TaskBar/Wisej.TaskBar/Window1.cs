
using System;
using Wisej.Web;

namespace Wisej.TaskBar
{
    public partial class SimpleWindow : Form
    {
        Wisej.Web.TaskBar TaskBar;
        public SimpleWindow()
        {
            InitializeComponent();
            TaskBar = new Wisej.Web.TaskBar();
        }
    }
}
