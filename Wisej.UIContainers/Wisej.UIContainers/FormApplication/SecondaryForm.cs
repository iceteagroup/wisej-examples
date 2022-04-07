using System;
using SharedControl;
using Wisej.Web;

namespace FormApplication
{
	public partial class SecondaryForm : Form, IDataSupplier
	{
		public SecondaryForm()
		{
			InitializeComponent();
		}

		private void SecondaryForm_Load(object sender, EventArgs e)
		{
			var stats = new StatsPanel(this);
			Controls.Add(stats);
			stats.Dock = DockStyle.Fill;
		}

		public void Fill(StatsPanel statsPanel)
		{
			statsPanel.formActiveFormText.Text = Form.ActiveForm.Text;

			if (Application.MainPage != null)
			{
				statsPanel.mainPageText.Text = Application.MainPage.Text;
				statsPanel.mainPageControlsCount.Text = Application.MainPage.Controls.Count.ToString();
				if (Application.MainPage.Controls.Count == 3)
					statsPanel.mainPageControlsCount.Text = Application.MainPage.Controls.Count + @" (1 label + 2 buttons)";
				else
					statsPanel.mainPageControlsCount.Text = Application.MainPage.Controls.Count.ToString();
				if (Application.MainPage.ActiveControl != null)
					statsPanel.mainPageActiveControlText.Text = Application.MainPage.ActiveControl.Text + @" (ActiveControl is per page)";
				else
					statsPanel.mainPageActiveControlText.Text = @"NULL (ActiveControl is per page)";
			}
			else
			{
				statsPanel.mainPageText.Text = @"NULL";
				statsPanel.mainPageControlsCount.Text = @"NULL";
				statsPanel.mainPageActiveControlText.Text = @"NULL";
			}

			if (Application.Desktop != null)
			{
				statsPanel.desktopText.Text = Application.Desktop.Text;
				if (Application.Desktop.Controls.Count == 4)
					statsPanel.desktopControlsCount.Text = Application.Desktop.Controls.Count + @" (1 label + 1 clock + 2 buttons)";
				else
					statsPanel.desktopControlsCount.Text = Application.Desktop.Controls.Count.ToString();
				if (Application.Desktop.ActiveControl != null)
					statsPanel.desktopActiveControlText.Text = Application.Desktop.ActiveControl.Text + @" (ActiveControl is per desktop)";
				else
					statsPanel.desktopActiveControlText.Text = @"NULL (ActiveControl is per desktop)";
			}
			else
			{
				statsPanel.desktopText.Text = @"NULL";
				statsPanel.desktopControlsCount.Text = @"NULL";
				statsPanel.desktopActiveControlText.Text = @"NULL";
			}

			statsPanel.applicationOpenForms.Text = Application.OpenForms.Count.ToString();
			statsPanel.applicationOpenPages.Text = Application.OpenPages.Count.ToString();
		}
	}
}