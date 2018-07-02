using System;
using Wisej.Web;

namespace PageNavigation
{
    public partial class Workspace : Page
    {
        private readonly string _previousPage;

        public Workspace(string workspaceName)
        {
            InitializeComponent();

            Name = workspaceName;
            _previousPage = Navigation.PreviousPage.Name;
        }

        private void Workspace_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = Application.Session.Username;
            workspaceLabel.Text = Name;

            if (Name == "Main Page")
            {
                customerName.Text = "Mr. Joe Bloggs";
                backButton.Text = "Logout";
                errorButton.Text = "Database Error";
            }
            else
            {
                customerName.Text = "Mrs. Jane Smith";
                newWorkspace.Visible = false;
                errorButton.Text = "Server Overloaded";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (Name == "Main Page")
            {
                Application.Session.Username = string.Empty;
                Navigation.Navigate(typeof(Login));
            }
            else
            {
                Navigation.WorkspaceNavigate(_previousPage);
            }
        }

        private void newWorkspace_Click(object sender, EventArgs e)
        {
            Navigation.WorkspaceNavigate("Page 1");
            newWorkspace.Text = "To Page 1";
        }


        private void settingsButton_Click(object sender, EventArgs e)
        {
            Navigation.Navigate(typeof(Settings));
        }
        private void errorButton_Click(object sender, EventArgs e)
        {
            throw new Exception(errorButton.Text);
        }
    }
}