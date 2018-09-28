using System;
using System.Drawing;
using Microsoft.AspNet.Identity;
using Wisej.Web;

namespace AspNetAuthentication.WisejViews
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            Application.BrowserTabActivated += Application_BrowserTabActivated;

            var name = Application.User.Identity.GetUserName();
            identity.Text = name;
            isAuthenticated.Text =
                "You are " + (Application.IsAuthenticated ? string.Empty : "not ") + "authenticated.";
        }

        private void Application_BrowserTabActivated(object sender, EventArgs e)
        {
            var name = Application.User.Identity.GetUserName();
            this.identity.Text = name;
            this.isAuthenticated.Text =
                "You are " + (Application.IsAuthenticated ? string.Empty : "not ") + "authenticated.";
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (Application.IsAuthenticated)
            {
                var name = Application.User.Identity.GetUserName();
                AlertBox.Show($"You are authenticated as {name}", alignment: ContentAlignment.MiddleCenter);
            }
            else
            {
                AlertBox.Show("You are NOT authenticated.", alignment: ContentAlignment.MiddleCenter);
            }
        }
    }
}