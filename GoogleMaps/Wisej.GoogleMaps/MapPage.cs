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

		private void MapPage_Load(object sender, EventArgs e)
		{
			this.comboBoxMapType.SelectedIndex = 0;
			this.checkedListBoxMapType.SetItemChecked(0, true);
			this.checkedListBoxMapType.SetItemChecked(1, true);
			this.checkedListBoxMapType.SetItemChecked(2, true);
			this.checkedListBoxMapType.SetItemChecked(3, true);
		}

		private void checkBoxMapType_CheckedChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.mapTypeControl = this.checkBoxMapType.Checked;
			this.googleMap1.Update();
		}

		private void checkBoxZoom_CheckedChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.zoomControl = this.checkBoxZoom.Checked;
			this.googleMap1.Update();
		}

		private void checkBoxFullScreen_CheckedChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.fullscreenControl = this.checkBoxFullScreen.Checked;
			this.googleMap1.Update();
		}

		private void StreetView_CheckedChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.streeViewControl = this.checkBoxStreetView.Checked;
			this.googleMap1.Update();
		}

		private void checkedListBoxMapType_AfterItemCheck(object sender, ItemCheckEventArgs e)
		{
			string[] ids = new string[this.checkedListBoxMapType.CheckedItems.Count];
			for (int i = 0; i < ids.Length; i++)
			{
				ids[i] = this.checkedListBoxMapType.CheckedItems[i].ToString().ToLowerInvariant();
			}

			this.googleMap1.Options.mapTypeControlOptions.mapTypeIds = ids;
			this.googleMap1.Update();
		}

		private void numericUpDownMinZoom_ValueChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.minZoom = this.numericUpDownMinZoom.Value;
			this.googleMap1.Update();
		}

		private void numericUpDownMaxZoom_ValueChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.maxZoom = this.numericUpDownMaxZoom.Value;
			this.googleMap1.Update();
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.zoom = this.trackBar1.Value;
			this.googleMap1.Update();
		}

		private void buttonAddMarker_Click(object sender, EventArgs e)
		{
			if (this.maskedTextBoxID.Text != "")
			{
				this.maskedTextBoxID.Invalid = false;

				if (this.textBoxAddress.Text != "")
				{
					this.googleMap1.AddMarker(this.maskedTextBoxID.Text, this.textBoxAddress.Text.Replace("\r\n", ","));
				}
				else
				{
					this.googleMap1.AddMarker(this.maskedTextBoxID.Text, double.Parse(this.maskedTextBoxLat.Text),
						double.Parse(this.maskedTextBoxLng.Text));
				}
			}
			else
			{
				this.maskedTextBoxID.Invalid = true;
				MessageBox.Show("Enter the marker's name.", modal: false, icon: MessageBoxIcon.Error);
			}
		}

		private void buttonRemoveMarker_Click(object sender, EventArgs e)
		{
			this.googleMap1.RemoveMarker(this.maskedTextBoxID.Text);
		}

		private void buttonClearMarkers_Click(object sender, EventArgs e)
		{
			this.googleMap1.ClearMarkers();
		}

		private void googleMap1_MapClick(object sender, Web.Ext.GoogleMaps.MapMouseEventArgs e)
		{
			if (e.Marker == null)
				AlertBox.Show("You clicked location: " + e.Location.ToString(),
					alignment: System.Drawing.ContentAlignment.BottomRight);
			else
				AlertBox.Show("You clicked marker: " + e.Marker + "  at location: " + e.Location.ToString(),
					alignment: System.Drawing.ContentAlignment.TopRight);
		}

		private void comboBoxMatType_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.googleMap1.Options.mapTypeId = this.comboBoxMapType.Text.ToLowerInvariant();
			this.googleMap1.Update();
		}

		private void googleMap1_MapPropertyChanged(object sender, Web.Ext.GoogleMaps.MapPropertyChangedEventArgs e)
		{
			switch (e.Name)
			{
				case "zoom":
					this.trackBar1.Value = (int) e.Value;
					break;
			}
		}

		private void buttonCenterMap_Click(object sender, EventArgs e)
		{
			// remove the center from the initialization options.
			this.googleMap1.Options.Delete("center");

			if (this.textBoxAddress.Text != "")
			{
				this.googleMap1.CenterMap(this.textBoxAddress.Text.Replace("\r\n", ","));
			}
			else
			{
				this.googleMap1.CenterMap(double.Parse(this.maskedTextBoxLat.Text),
					double.Parse(this.maskedTextBoxLng.Text));
			}
		}

		private async void currentLocationButton_Click(object sender, EventArgs e)
		{
			var position = await geolocation.GetCurrentPositionAsync();
			this.maskedTextBoxLat.Text = position.Latitude.ToString();
			this.maskedTextBoxLng.Text = position.Longitude.ToString();
		}

		private void coordsFromAddressButton_Click(object sender, EventArgs e)
		{
			CoordsFromAddress();
		}

		private void coordsFromAddressButton_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
		{
			CoordsFromAddress();
		}

		private void addressFromCoordsButton_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
		{
			AddressFromCoords();
		}

		private void addressFromCoordsButton_Click(object sender, EventArgs e)
		{
			AddressFromCoords();
		}

		private async void CoordsFromAddress()
		{
			var geocodes = await googleMap1.GetGeocodeAsync(this.textBoxAddress.Text.Replace("\r\n", ","));

			if (geocodes[0].IsError)
			{
				MessageBox.Show($"Received error {geocodes[0].ResultCode}",
					"Search Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			else
			{
				this.maskedTextBoxLat.Text = geocodes[0].GeocodeGeometry.Location.Lat.ToString();
				this.maskedTextBoxLng.Text = geocodes[0].GeocodeGeometry.Location.Lng.ToString();
			}
		}

		private async void AddressFromCoords()
		{
			var geocodes = await googleMap1.GetGeocodeAsync(double.Parse(this.maskedTextBoxLat.Text),
				double.Parse(this.maskedTextBoxLng.Text));

			if (geocodes[0].IsError)
			{
				MessageBox.Show($"Received error {geocodes[0].ResultCode}",
					"Search Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			else
			{
				this.textBoxAddress.Text = geocodes[0].FormattedAddress;
			}
		}
	}
}