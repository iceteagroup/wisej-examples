using System;
using Wisej.Web;

namespace MDIExample
{
    public partial class ChildMdi : Form
    {
        public ChildMdi(string label)
        {
            InitializeComponent();

            label1.Text = "MDI Child is "+label;
        }
    }
}
