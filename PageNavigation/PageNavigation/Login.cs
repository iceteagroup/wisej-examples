using System;
using Wisej.Web;

namespace PageNavigation
{
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            credentialsError.Visible = false;

            if (username.Text == password.Text)
            {
                Application.Session.Username = username.Text;
                Navigation.WorkspaceNavigate("Main Page");
                password.Text = string.Empty;
            }
            else
                credentialsError.Visible = true;
        }
    }
}