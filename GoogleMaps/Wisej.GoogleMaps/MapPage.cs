using System;
using Wisej.Web;
using Wisej.Web.Ext.GoogleMaps;

namespace Wisej.GoogleMaps
{
    public partial class MapPage : Page
    {
        private string _lastQuery;

        private GeocoderResult[] _geocodes;

        public GeocoderResult[] Geocodes
        {
            get { return _geocodes; }
            private set
            {
                _geocodes = value;
                this.buttonCopyToMarkers.Enabled = _geocodes != null;
                this.buttonShowDetails.Enabled = _geocodes != null;
            }
        }

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
            this.buttonCopyToMarkers.Enabled = false;
            this.buttonShowDetails.Enabled = false;
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
            var draggable = this.checkBoxDraggableMarker.Checked;

            if (this.maskedTextBoxID.Text != "")
            {
                this.maskedTextBoxID.Invalid = false;

                if (this.textBoxAddress.Text != "")
                {
                    this.googleMap1.AddMarker(this.maskedTextBoxID.Text, this.textBoxAddress.Text.Replace("\r\n", ","),
                        draggable ? new {Draggable = true} : null);
                }
                else
                {
                    this.googleMap1.AddMarker(this.maskedTextBoxID.Text, double.Parse(this.maskedTextBoxLat.Text),
                        double.Parse(this.maskedTextBoxLng.Text), draggable ? new {Draggable = true} : null);
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

        private void googleMap1_MapDragEnd(object sender, EventArgs e)
        {
            AlertBox.Show("You dragged the map",
                alignment: System.Drawing.ContentAlignment.TopRight);
        }

        private void googleMap1_MarkerDragEnd(object sender, MarkerDragEventArgs e)
        {
            AlertBox.Show(
                $"You dragged marker: {e.Marker} to\r\nLat: {e.Location.Lat}\r\nLng: {e.Location.Lng}\r\nat position {e.Position}",
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

        private async void buttonCurrentLocation_Click(object sender, EventArgs e)
        {
            var position = await geolocation.GetCurrentPositionAsync();
            this.maskedTextBoxLat.Text = position.Latitude.ToString();
            this.maskedTextBoxLng.Text = position.Longitude.ToString();
        }

        private async void buttonCoordsFromAddress_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxAddress.Text))
                return;

            _lastQuery = this.textBoxAddress.Text.Replace("\n", ", ");
            _lastQuery = _lastQuery.Replace("\r\n", ", ");
            Geocodes = await googleMap1.GetGeocodeAsync(_lastQuery);

            if (Geocodes[0].IsError)
            {
                MessageBox.Show($"Received error {Geocodes[0].ResultCode}",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Geocodes = null;
            }
            else
            {
                this.geocodeAddress.Text = Geocodes[0].FormattedAddress;
                this.geocodeLat.Text = Geocodes[0].GeocodeGeometry.Location.Lat.ToString();
                this.geocodeLng.Text = Geocodes[0].GeocodeGeometry.Location.Lng.ToString();
            }
        }

        private async void buttonAddressFromCoords_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.maskedTextBoxLat.Text) ||
                string.IsNullOrWhiteSpace(this.maskedTextBoxLng.Text))
                return;

            _lastQuery = $"Lat: {this.maskedTextBoxLat.Text} Lng:{this.maskedTextBoxLng.Text}";
            Geocodes = await googleMap1.GetGeocodeAsync(double.Parse(this.maskedTextBoxLat.Text),
                double.Parse(this.maskedTextBoxLng.Text));

            if (Geocodes[0].IsError)
            {
                MessageBox.Show($"Received error {Geocodes[0].ResultCode}",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Geocodes = null;
            }
            else
            {
                this.geocodeAddress.Text = Geocodes[0].FormattedAddress;
                this.geocodeLat.Text = Geocodes[0].GeocodeGeometry.Location.Lat.ToString();
                this.geocodeLng.Text = Geocodes[0].GeocodeGeometry.Location.Lng.ToString();
            }
        }


        private void buttonCopyToMarkers_Click(object sender, EventArgs e)
        {
            this.textBoxAddress.Text = this.geocodeAddress.Text;
            this.maskedTextBoxLat.Text = this.geocodeLat.Text;
            this.maskedTextBoxLng.Text = this.geocodeLng.Text;
        }

        private void buttonShowDetails_Click(object sender, EventArgs e)
        {
            using (var geocodeDetails = new GeocodeDetails(Geocodes, _lastQuery))
            {
                geocodeDetails.ShowDialog();
            }
        }
    }
}