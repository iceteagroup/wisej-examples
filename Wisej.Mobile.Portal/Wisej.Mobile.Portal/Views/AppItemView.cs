using System;
using System.Drawing;
using System.IO;
using Wisej.Web;

namespace Wisej.Mobile.Portal.Views
{
	public partial class AppItemView : UserControl
	{
		private App app;

		private Random random = new Random((int)DateTime.Now.Ticks);

		public AppItemView()
		{
			InitializeComponent();
		}

		public AppItemView(App app)
		{
			InitializeComponent();

			this.app = app;
		}

		public AppItemView(string title, string url, string icon="", string color="")
		{
			InitializeComponent();

			if (String.IsNullOrEmpty(icon))
				icon = GetRandomIcon();

			if (String.IsNullOrEmpty(color))
				color = GetRandomColor();

			this.app = new App(url, title, icon, color);
		}

		private void AppItem_Load(object sender, EventArgs e)
		{
			this.labelURL.Text = this.app.URL;
			this.labelTitle.Text = this.app.Title;

			var color = this.app.Color ?? GetRandomColor();
			this.pictureBoxIcon.ImageSource = $"Images/Animals/{this.app.Icon}?color={color}";
		}

		private string GetRandomIcon()
		{
			var animals = Directory.GetFiles(Application.MapPath("Images/Animals"));

			return $"{Path.GetFileName(animals[random.Next(animals.Length - 1)])}";
		}

		private string GetRandomColor()
		{
			var color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
			return ColorTranslator.ToHtml(color);
		}

		private void AppItem_Click(object sender, EventArgs e)
		{
			Application.Navigate(this.app.URL);
		}

		private void buttonMenu_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
		{
			if (e.Item.Text == "Delete")
			{
				Delete();
			}
		}

		/// <summary>
		/// Saves the app to the device.
		/// </summary>
		public void Save()
		{
			this.app.Save();
		}

		/// <summary>
		/// Deletes the App from the device.
		/// </summary>
		public void Delete()
		{
			this.app.Delete();
			this.Dispose();
		}
	}
}
