using System;
using Wisej.Web;
using Wisej.Web.Ext.GoogleMaps;

namespace Wisej.GoogleMaps
{
	public partial class AddMarkerWindow : Form
	{
		private GoogleMap _map;

		public AddMarkerWindow()
		{
			InitializeComponent();
		}

		public AddMarkerWindow(GoogleMap map) : this()
		{
			this._map = map;
		}

		private void AddMarkerWindow_Load(object sender, EventArgs e)
		{
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void groupBoxAddress_CheckedChanged(object sender, EventArgs e)
		{
			var enabled = this.groupBoxAddress.Checked;

			this.groupBoxAddress.Checked = enabled;
			this.groupBoxCoordinates.Checked = !enabled;
		}

		private void groupBoxCoordinates_CheckedChanged(object sender, EventArgs e)
		{
			var enabled = this.groupBoxCoordinates.Checked;

			this.groupBoxAddress.Checked = !enabled;
			this.groupBoxCoordinates.Checked = enabled;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var id = Guid.NewGuid().ToString();

			if (this.groupBoxCoordinates.Checked)
			{
				this._map.AddMarker(id, double.Parse(this.textBoxLat.Text), double.Parse(this.textBoxLng.Text));
			}
			else
			{
				this._map.AddMarker(id, this.textBoxAddress.Text);
			}

			this.Dispose();
		}
	}
}
