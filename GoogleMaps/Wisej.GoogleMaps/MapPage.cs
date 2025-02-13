using System;
using Wisej.Web;
using Wisej.Web.Ext.GoogleMaps;

namespace Wisej.GoogleMaps
{
	public partial class MapPage : Page
	{
		public MapPage()
		{
			InitializeComponent();
		}

		private void checkBoxMapType_CheckedChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.mapTypeControl = this.checkBoxMapType.Checked;
		}

		private void checkBoxZoom_CheckedChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.zoomControl = this.checkBoxZoom.Checked;
		}

		private void checkBoxFullScreen_CheckedChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.fullscreenControl = this.checkBoxFullScreen.Checked;
		}

		private void StreetView_CheckedChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.streetViewControl = this.checkBoxStreetView.Checked;
		}

		private void googleMap1_MapClick(object sender, MapMouseEventArgs e)
		{
			if (e.Marker == null)
				AlertBox.Show($"Clicked: {e.Location}");
			else
				AlertBox.Show($"Clicked: {e.Marker} at location: {e.Location}");
		}

		private void radioButtonMapType_CheckedChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.mapTypeId = ((Control)sender).Text.ToLower();
		}

		private void buttonZoomOut_Click(object sender, EventArgs e)
		{
			this.googleMap1.Options.zoom -= 1;
		}

		private void buttonZoomIn_Click(object sender, EventArgs e)
		{
			this.googleMap1.Options.zoom += 1;
		}

		private void buttonClearMarkers_Click_1(object sender, EventArgs e)
		{
			this.googleMap1.ClearMarkers();
		}

		private void buttonCenter_Click(object sender, EventArgs e)
		{
			this.googleMap1.CenterMap(37.7749, -122.4194);
		}

		private void buttonAddMarker_Click(object sender, EventArgs e)
		{
			new AddMarkerWindow(this.googleMap1).Show();
		}

		private void buttonTheme_Click(object sender, EventArgs e)
		{
			var theme = Application.Theme.Name;

			switch (theme) 
			{
				case "Bootstrap-4":
					Application.LoadTheme("BootstrapDark-4");
					this.radioButtonSatellite.Checked = true;
					break;

				case "BootstrapDark-4":
					Application.LoadTheme("Bootstrap-4");
					this.radioButtonTerrain.Checked = true;
					break;
			}
		}
	}
}
