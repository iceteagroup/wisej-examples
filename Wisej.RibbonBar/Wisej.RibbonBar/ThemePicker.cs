using System;
using Wisej.Web;

namespace Wisej.RibbonBar
{
	public partial class ThemePicker : Wisej.Web.UserControl
	{
		public ThemePicker()
		{
			InitializeComponent();
		}

		public event EventHandler ThemeClicked;

		private void pictureBox_Click(object sender, EventArgs e)
		{
			this.SelectedTheme = ((PictureBox)sender).ImageSource;

			this.ThemeClicked?.Invoke(this, e);
		}

		public string SelectedTheme
		{
			get;
			private set;
		}
	}
}
