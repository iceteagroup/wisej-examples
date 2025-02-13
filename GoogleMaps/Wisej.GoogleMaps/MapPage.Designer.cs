namespace Wisej.GoogleMaps
{
	partial class MapPage
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.checkBoxStreetView = new Wisej.Web.CheckBox();
			this.checkBoxFullScreen = new Wisej.Web.CheckBox();
			this.checkBoxZoom = new Wisej.Web.CheckBox();
			this.checkBoxMapType = new Wisej.Web.CheckBox();
			this.googleMap1 = new Wisej.Web.Ext.GoogleMaps.GoogleMap();
			this.panel4 = new Wisej.Web.Panel();
			this.flexLayoutPanel2 = new Wisej.Web.FlexLayoutPanel();
			this.radioButtonRoadmap = new Wisej.Web.RadioButton();
			this.radioButtonHybrid = new Wisej.Web.RadioButton();
			this.radioButtonSatellite = new Wisej.Web.RadioButton();
			this.radioButtonTerrain = new Wisej.Web.RadioButton();
			this.label7 = new Wisej.Web.Label();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.buttonZoomOut = new Wisej.Web.Button();
			this.buttonZoomIn = new Wisej.Web.Button();
			this.buttonCenter = new Wisej.Web.Button();
			this.buttonAddMarker = new Wisej.Web.Button();
			this.buttonClearMarkers = new Wisej.Web.Button();
			this.buttonTheme = new Wisej.Web.Button();
			this.panel4.SuspendLayout();
			this.flexLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.flexLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxStreetView
			// 
			this.checkBoxStreetView.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxStreetView.Location = new System.Drawing.Point(295, 3);
			this.checkBoxStreetView.Margin = new Wisej.Web.Padding(3, 3, 24, 3);
			this.checkBoxStreetView.Name = "checkBoxStreetView";
			this.checkBoxStreetView.Size = new System.Drawing.Size(95, 34);
			this.checkBoxStreetView.TabIndex = 3;
			this.checkBoxStreetView.Text = "Street View";
			this.checkBoxStreetView.CheckedChanged += new System.EventHandler(this.StreetView_CheckedChanged);
			// 
			// checkBoxFullScreen
			// 
			this.checkBoxFullScreen.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxFullScreen.Location = new System.Drawing.Point(187, 3);
			this.checkBoxFullScreen.Name = "checkBoxFullScreen";
			this.checkBoxFullScreen.Size = new System.Drawing.Size(92, 34);
			this.checkBoxFullScreen.TabIndex = 2;
			this.checkBoxFullScreen.Text = "Full Screen";
			this.checkBoxFullScreen.CheckedChanged += new System.EventHandler(this.checkBoxFullScreen_CheckedChanged);
			// 
			// checkBoxZoom
			// 
			this.checkBoxZoom.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxZoom.Location = new System.Drawing.Point(107, 3);
			this.checkBoxZoom.Name = "checkBoxZoom";
			this.checkBoxZoom.Size = new System.Drawing.Size(64, 34);
			this.checkBoxZoom.TabIndex = 1;
			this.checkBoxZoom.Text = "Zoom";
			this.checkBoxZoom.CheckedChanged += new System.EventHandler(this.checkBoxZoom_CheckedChanged);
			// 
			// checkBoxMapType
			// 
			this.checkBoxMapType.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxMapType.Location = new System.Drawing.Point(3, 3);
			this.checkBoxMapType.Name = "checkBoxMapType";
			this.checkBoxMapType.Size = new System.Drawing.Size(88, 34);
			this.checkBoxMapType.TabIndex = 0;
			this.checkBoxMapType.Text = "Map Type";
			this.checkBoxMapType.CheckedChanged += new System.EventHandler(this.checkBoxMapType_CheckedChanged);
			// 
			// googleMap1
			// 
			this.googleMap1.Dock = Wisej.Web.DockStyle.Fill;
			this.googleMap1.Location = new System.Drawing.Point(40, 40);
			this.googleMap1.MinimumSize = new System.Drawing.Size(0, 400);
			this.googleMap1.Name = "googleMap1";
			this.googleMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"center\":{\"lat\":37.7749,\"lng\":-122.4194},\"zoom\":4}")));
			this.googleMap1.Size = new System.Drawing.Size(1832, 874);
			this.googleMap1.TabIndex = 0;
			this.googleMap1.Text = "googleMap1";
			this.googleMap1.MapClick += new Wisej.Web.Ext.GoogleMaps.MapMouseEventHandler(this.googleMap1_MapClick);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromName("@toolbar");
			this.panel4.Controls.Add(this.flexLayoutPanel2);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.pictureBox1);
			this.panel4.Dock = Wisej.Web.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1872, 40);
			this.panel4.TabIndex = 7;
			// 
			// flexLayoutPanel2
			// 
			this.flexLayoutPanel2.Controls.Add(this.checkBoxMapType);
			this.flexLayoutPanel2.Controls.Add(this.checkBoxZoom);
			this.flexLayoutPanel2.Controls.Add(this.checkBoxFullScreen);
			this.flexLayoutPanel2.Controls.Add(this.checkBoxStreetView);
			this.flexLayoutPanel2.Controls.Add(this.radioButtonRoadmap);
			this.flexLayoutPanel2.Controls.Add(this.radioButtonHybrid);
			this.flexLayoutPanel2.Controls.Add(this.radioButtonSatellite);
			this.flexLayoutPanel2.Controls.Add(this.radioButtonTerrain);
			this.flexLayoutPanel2.Dock = Wisej.Web.DockStyle.Right;
			this.flexLayoutPanel2.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
			this.flexLayoutPanel2.Location = new System.Drawing.Point(1091, 0);
			this.flexLayoutPanel2.Name = "flexLayoutPanel2";
			this.flexLayoutPanel2.Size = new System.Drawing.Size(781, 40);
			this.flexLayoutPanel2.TabIndex = 2;
			// 
			// radioButtonRoadmap
			// 
			this.radioButtonRoadmap.Checked = true;
			this.radioButtonRoadmap.Location = new System.Drawing.Point(427, 3);
			this.radioButtonRoadmap.Name = "radioButtonRoadmap";
			this.radioButtonRoadmap.Size = new System.Drawing.Size(86, 34);
			this.radioButtonRoadmap.TabIndex = 0;
			this.radioButtonRoadmap.TabStop = true;
			this.radioButtonRoadmap.Text = "Roadmap";
			this.radioButtonRoadmap.CheckedChanged += new System.EventHandler(this.radioButtonMapType_CheckedChanged);
			// 
			// radioButtonHybrid
			// 
			this.radioButtonHybrid.Location = new System.Drawing.Point(529, 3);
			this.radioButtonHybrid.Name = "radioButtonHybrid";
			this.radioButtonHybrid.Size = new System.Drawing.Size(69, 34);
			this.radioButtonHybrid.TabIndex = 1;
			this.radioButtonHybrid.Text = "Hybrid";
			this.radioButtonHybrid.CheckedChanged += new System.EventHandler(this.radioButtonMapType_CheckedChanged);
			// 
			// radioButtonSatellite
			// 
			this.radioButtonSatellite.Location = new System.Drawing.Point(614, 3);
			this.radioButtonSatellite.Name = "radioButtonSatellite";
			this.radioButtonSatellite.Size = new System.Drawing.Size(76, 34);
			this.radioButtonSatellite.TabIndex = 2;
			this.radioButtonSatellite.Text = "Satellite";
			this.radioButtonSatellite.CheckedChanged += new System.EventHandler(this.radioButtonMapType_CheckedChanged);
			// 
			// radioButtonTerrain
			// 
			this.radioButtonTerrain.Location = new System.Drawing.Point(706, 3);
			this.radioButtonTerrain.Name = "radioButtonTerrain";
			this.radioButtonTerrain.Size = new System.Drawing.Size(70, 34);
			this.radioButtonTerrain.TabIndex = 3;
			this.radioButtonTerrain.Text = "Terrain";
			this.radioButtonTerrain.CheckedChanged += new System.EventHandler(this.radioButtonMapType_CheckedChanged);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label7.Location = new System.Drawing.Point(51, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(282, 30);
			this.label7.TabIndex = 1;
			this.label7.Text = "Wisej.NET Google Maps Integration";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.ImageSource = "Images\\wisej.png";
			this.pictureBox1.Location = new System.Drawing.Point(7, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(30, 30);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.BackColor = System.Drawing.Color.FromName("@toolbar");
			this.flexLayoutPanel1.Controls.Add(this.buttonZoomOut);
			this.flexLayoutPanel1.Controls.Add(this.buttonZoomIn);
			this.flexLayoutPanel1.Controls.Add(this.buttonCenter);
			this.flexLayoutPanel1.Controls.Add(this.buttonAddMarker);
			this.flexLayoutPanel1.Controls.Add(this.buttonClearMarkers);
			this.flexLayoutPanel1.Controls.Add(this.buttonTheme);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Left;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(0, 40);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(40, 874);
			this.flexLayoutPanel1.TabIndex = 8;
			// 
			// buttonZoomOut
			// 
			this.buttonZoomOut.BackColor = System.Drawing.Color.Transparent;
			this.buttonZoomOut.Focusable = false;
			this.buttonZoomOut.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/zoom-out.svg";
			this.buttonZoomOut.Location = new System.Drawing.Point(3, 3);
			this.buttonZoomOut.Name = "buttonZoomOut";
			this.buttonZoomOut.Size = new System.Drawing.Size(34, 34);
			this.buttonZoomOut.TabIndex = 0;
			this.buttonZoomOut.ToolTipText = "Zoom Out";
			this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
			// 
			// buttonZoomIn
			// 
			this.buttonZoomIn.BackColor = System.Drawing.Color.Transparent;
			this.buttonZoomIn.Focusable = false;
			this.buttonZoomIn.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/zoom-in.svg";
			this.buttonZoomIn.Location = new System.Drawing.Point(3, 53);
			this.buttonZoomIn.Name = "buttonZoomIn";
			this.buttonZoomIn.Size = new System.Drawing.Size(34, 34);
			this.buttonZoomIn.TabIndex = 1;
			this.buttonZoomIn.ToolTipText = "Zoom In";
			this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
			// 
			// buttonCenter
			// 
			this.buttonCenter.BackColor = System.Drawing.Color.Transparent;
			this.buttonCenter.Focusable = false;
			this.buttonCenter.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/bullseye.svg";
			this.buttonCenter.Location = new System.Drawing.Point(3, 103);
			this.buttonCenter.Name = "buttonCenter";
			this.buttonCenter.Size = new System.Drawing.Size(34, 34);
			this.buttonCenter.TabIndex = 3;
			this.buttonCenter.ToolTipText = "Center Map";
			this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
			// 
			// buttonAddMarker
			// 
			this.buttonAddMarker.BackColor = System.Drawing.Color.Transparent;
			this.buttonAddMarker.Focusable = false;
			this.buttonAddMarker.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/pin-map.svg";
			this.buttonAddMarker.Location = new System.Drawing.Point(3, 153);
			this.buttonAddMarker.Name = "buttonAddMarker";
			this.buttonAddMarker.Size = new System.Drawing.Size(34, 34);
			this.buttonAddMarker.TabIndex = 2;
			this.buttonAddMarker.ToolTipText = "Add Marker";
			this.buttonAddMarker.Click += new System.EventHandler(this.buttonAddMarker_Click);
			// 
			// buttonClearMarkers
			// 
			this.buttonClearMarkers.BackColor = System.Drawing.Color.Transparent;
			this.buttonClearMarkers.Focusable = false;
			this.buttonClearMarkers.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/trash.svg";
			this.buttonClearMarkers.Location = new System.Drawing.Point(3, 203);
			this.buttonClearMarkers.Name = "buttonClearMarkers";
			this.buttonClearMarkers.Size = new System.Drawing.Size(34, 34);
			this.buttonClearMarkers.TabIndex = 4;
			this.buttonClearMarkers.ToolTipText = "Delete Markers";
			this.buttonClearMarkers.Click += new System.EventHandler(this.buttonClearMarkers_Click_1);
			// 
			// buttonTheme
			// 
			this.buttonTheme.BackColor = System.Drawing.Color.Transparent;
			this.buttonTheme.Focusable = false;
			this.buttonTheme.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/cloud-moon.svg";
			this.buttonTheme.Location = new System.Drawing.Point(3, 253);
			this.buttonTheme.Name = "buttonTheme";
			this.buttonTheme.Size = new System.Drawing.Size(34, 34);
			this.buttonTheme.TabIndex = 5;
			this.buttonTheme.ToolTipText = "Delete Markers";
			this.buttonTheme.Click += new System.EventHandler(this.buttonTheme_Click);
			// 
			// MapPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.googleMap1);
			this.Controls.Add(this.flexLayoutPanel1);
			this.Controls.Add(this.panel4);
			this.Name = "MapPage";
			this.Size = new System.Drawing.Size(1872, 914);
			this.panel4.ResumeLayout(false);
			this.flexLayoutPanel2.ResumeLayout(false);
			this.flexLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.flexLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.GoogleMaps.GoogleMap googleMap1;
		private Web.CheckBox checkBoxFullScreen;
		private Web.CheckBox checkBoxZoom;
		private Web.CheckBox checkBoxMapType;
		private Web.CheckBox checkBoxStreetView;
		private Web.Panel panel4;
		private Web.Label label7;
		private Web.PictureBox pictureBox1;
		private Web.FlexLayoutPanel flexLayoutPanel1;
		private Web.FlexLayoutPanel flexLayoutPanel2;
		private Web.Button buttonZoomOut;
		private Web.Button buttonZoomIn;
		private Web.RadioButton radioButtonRoadmap;
		private Web.RadioButton radioButtonHybrid;
		private Web.RadioButton radioButtonSatellite;
		private Web.RadioButton radioButtonTerrain;
		private Web.Button buttonAddMarker;
		private Web.Button buttonCenter;
		private Web.Button buttonClearMarkers;
		private Web.Button buttonTheme;
	}
}
