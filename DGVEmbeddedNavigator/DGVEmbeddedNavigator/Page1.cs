using System;
using Wisej.Web;


namespace DGVEmbeddedNavigator
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void buttonEmbeddedBindingNavigator_Click(object sender, EventArgs e)
        {
            using (var window = new EmbeddedBindingNavigator())
            {
                window.ShowDialog();
            }
        }

        private void buttonNavigationPanel_Click(object sender, EventArgs e)
        {
            using (var window = new NavigationPanel())
            {
                window.ShowDialog();
            }

        }
    }
}
