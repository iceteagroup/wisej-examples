using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Portal
{
	public class App
	{
		public App(string url, string title, string icon, string color)
		{
			this.URL = url;
			this.Icon = icon;
			this.Color = color;
			this.Title = title;

			this.ID = Guid.NewGuid().ToString();
		}

		/// <summary>
		/// The unique id of the app.
		/// </summary>
		public string ID { get; set; }

		/// <summary>
		/// The name of the app.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// The URL of the app.
		/// </summary>
		public string URL { get; set; }
		
		/// <summary>
		/// The app icon.
		/// </summary>
		public string Icon { get; set; }

		/// <summary>
		/// The app icon color.
		/// </summary>
		public string Color { get; set; }

		#region Methods

		public static List<App> Load()
		{
			return JsonConvert.DeserializeObject<List<App>>((string)Device.UserData["Apps"] ?? "") ?? new List<App>();
		}

		/// <summary>
		/// Saves the app to the device.
		/// </summary>
		public void Save()
		{
			var apps = Load();
			apps.Add(this);

			Device.UserData["Apps"] = JsonConvert.SerializeObject(apps);
		}

		public void Delete()
		{
			var apps = Load();
			if (apps == null)
				return;

			apps.RemoveAll(item => item.ID == this.ID);

			Device.UserData["Apps"] = JsonConvert.SerializeObject(apps.ToArray());
		}

		#endregion
	}
}