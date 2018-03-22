using System;
using Wisej.Web;

namespace DesktopApplication
{
    public partial class SwitchForm : Form
    {
        public SwitchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.Desktop.GetType() == typeof(SecondaryDesktop))
                Application.Desktop = Program.DesktopPrimary;
            else
                Application.Desktop = Program.DesktopSecondary;
        }
    }
}
