using System;
using System.Drawing;
using Wisej.Web;


namespace Wisej.Responsive.Views
{
	public partial class LoginPage : Page
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		private void LoginPage_Accelerator(object sender, AcceleratorEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.buttonLogin.PerformClick();
			}
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void Login()
		{
			bool valid = true;

			this.errorProvider.SetError(this.textBoxUserName, null);
			this.errorProvider.SetError(this.textBoxPassword, null);

			if (String.IsNullOrEmpty(this.textBoxUserName.Text))
			{
				valid = false;
				this.errorProvider.SetError(this.textBoxUserName, "Enter your user name.");
			}

			if (String.IsNullOrEmpty(this.textBoxPassword.Text))
			{
				valid = false;
				this.errorProvider.SetError(this.textBoxPassword, "Enter a valid password.");
			}
			else if (this.textBoxPassword.Text != "demo")
			{
				valid = false;
				this.errorProvider.SetError(this.textBoxPassword, "Invalid password.");
			}

			if (valid)
			{
				new HomePage().Show();
				Dispose();
			}
		}

		private void LoginPage_ResponsiveProfileChanged(object sender, ResponsiveProfileChangedEventArgs e)
		{
			if (this.Width <= 450)
			{
				// Phone
				this.helpTip.Active = false;
				this.panel.Width = 320;
				this.panel.Left = (this.Width - this.panel.Width) / 2;
			}
			else
			{
				// Phone Landscape, Tablet and Desktop
				this.helpTip.Active = true;
				this.panel.Width = 420;
				this.panel.Left = (this.Width - this.panel.Width) / 2;
			}

			if (this.Height <= 450)
			{
				// Phone Landscape
				this.panel.Height = 320;
				this.label1.ImageAlign = ContentAlignment.MiddleLeft;
				this.panel.Top = (this.Height - this.panel.Height) / 2;
			}
			else
			{
				// Phone Portrait, Tablet and Desktop
				this.panel.Height = 460;
				this.label1.ImageAlign = ContentAlignment.TopCenter;
				this.panel.Top = (this.Height - this.panel.Height) / 2;
			}

		}

        private void LoginPage_Load(object sender, EventArgs e)
        {
            MessageBox.Show("To test Wisej responsive features, activate Developer Tools in your browser and try device emulation.\r\n Enter an arbitrary user name to login.\r\nPassword is \"demo\"", "Wisej Reponsive Features", MessageBoxButtons.OK);
        }
    }
}
