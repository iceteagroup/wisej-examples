using System;
using Wisej.Web;

namespace ComponentMixin
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            treeView1.AppearanceKey = "my-tree";
            listBox1.AppearanceKey = "my-list";
        }
    }
}
