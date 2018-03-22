
using System;
using System.Resources;
using Wisej.Web;

namespace Localization
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void Window1_Load(object sender, EventArgs e)
		{
			SetValues();

			// get notified when the browser is refreshed.
			Application.ApplicationRefresh += Application_ApplicationRefresh;
		}

		void Application_ApplicationRefresh(object sender, EventArgs e)
		{
			SetValues();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// refresh the browser using the new language.
			string[] languages = {"auto","en","de", "it", "fr", "es"};
			Application.Navigate(Application.StartupUri.ToString() + "?lang=" + languages[this.comboBox1.SelectedIndex]);
		}

		private void SetValues()
		{
			this.labelNumber.Text = 12345678.ToString("c");
			this.labelCurrency.Text = 12345678.ToString("c");
			this.labelDateTime.Text = DateTime.Now.ToString("F");

			var RS = new ResourceManager("Localization.Resources", this.GetType().Assembly);
			this.Text = RS.GetString("Title");
			this.button1.Text = RS.GetString("ShowMessageBox");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("The buttons are localized", buttons: MessageBoxButtons.YesNoCancel, modal: false);
		}
	}
}
