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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapPage));
			this.groupBox1 = new Wisej.Web.GroupBox();
			this.checkBoxStreetView = new Wisej.Web.CheckBox();
			this.checkBoxFullScreen = new Wisej.Web.CheckBox();
			this.checkBoxZoom = new Wisej.Web.CheckBox();
			this.checkBoxMapType = new Wisej.Web.CheckBox();
			this.groupBox2 = new Wisej.Web.GroupBox();
			this.comboBoxMapType = new Wisej.Web.ComboBox();
			this.checkedListBoxMapType = new Wisej.Web.CheckedListBox();
			this.googleMap1 = new Wisej.Web.Ext.GoogleMaps.GoogleMap();
			this.trackBar1 = new Wisej.Web.TrackBar();
			this.groupBox3 = new Wisej.Web.GroupBox();
			this.label2 = new Wisej.Web.Label();
			this.numericUpDownMaxZoom = new Wisej.Web.NumericUpDown();
			this.label1 = new Wisej.Web.Label();
			this.numericUpDownMinZoom = new Wisej.Web.NumericUpDown();
			this.groupBox4 = new Wisej.Web.GroupBox();
			this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
			this.panel4 = new Wisej.Web.Panel();
			this.buttonCurrentLocation = new Wisej.Web.Button();
			this.panel3 = new Wisej.Web.Panel();
			this.buttonCenterMap = new Wisej.Web.Button();
			this.buttonClearMarkers = new Wisej.Web.Button();
			this.buttonAddMarker = new Wisej.Web.Button();
			this.buttonRemoveMarker = new Wisej.Web.Button();
			this.panel2 = new Wisej.Web.Panel();
			this.label3 = new Wisej.Web.Label();
			this.textBoxAddress = new Wisej.Web.TextBox();
			this.panel1 = new Wisej.Web.Panel();
			this.checkBoxDraggableMarker = new Wisej.Web.CheckBox();
			this.maskedTextBoxLng = new Wisej.Web.MaskedTextBox();
			this.label4 = new Wisej.Web.Label();
			this.label5 = new Wisej.Web.Label();
			this.maskedTextBoxLat = new Wisej.Web.MaskedTextBox();
			this.maskedTextBoxID = new Wisej.Web.MaskedTextBox();
			this.label6 = new Wisej.Web.Label();
			this.buttonCoordsFromAddress = new Wisej.Web.Button();
			this.buttonAddressFromCoords = new Wisej.Web.Button();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.groupBox5 = new Wisej.Web.GroupBox();
			this.buttonCopyToMarkers = new Wisej.Web.Button();
			this.buttonShowDetails = new Wisej.Web.Button();
			this.label9 = new Wisej.Web.Label();
			this.geocodeLng = new Wisej.Web.TextBox();
			this.label8 = new Wisej.Web.Label();
			this.geocodeLat = new Wisej.Web.TextBox();
			this.label7 = new Wisej.Web.Label();
			this.geocodeAddress = new Wisej.Web.TextBox();
			this.geolocation = new Wisej.Ext.Geolocation.Geolocation(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxZoom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinZoom)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxStreetView);
			this.groupBox1.Controls.Add(this.checkBoxFullScreen);
			this.groupBox1.Controls.Add(this.checkBoxZoom);
			this.groupBox1.Controls.Add(this.checkBoxMapType);
			this.flowLayoutPanel1.SetFillWeight(this.groupBox1, 33);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.MinimumSize = new System.Drawing.Size(152, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(405, 140);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.Text = "Controls";
			this.groupBox1.UseMnemonic = false;
			// 
			// checkBoxStreetView
			// 
			this.checkBoxStreetView.Checked = true;
			this.checkBoxStreetView.CheckState = ((Wisej.Web.CheckState)(Wisej.Web.CheckState.Checked));
			this.checkBoxStreetView.Location = new System.Drawing.Point(16, 100);
			this.checkBoxStreetView.Name = "checkBoxStreetView";
			this.checkBoxStreetView.Size = new System.Drawing.Size(94, 23);
			this.checkBoxStreetView.TabIndex = 3;
			this.checkBoxStreetView.Text = "Street View";
			this.checkBoxStreetView.CheckedChanged += new System.EventHandler(this.StreetView_CheckedChanged);
			// 
			// checkBoxFullScreen
			// 
			this.checkBoxFullScreen.Location = new System.Drawing.Point(16, 75);
			this.checkBoxFullScreen.Name = "checkBoxFullScreen";
			this.checkBoxFullScreen.Size = new System.Drawing.Size(94, 23);
			this.checkBoxFullScreen.TabIndex = 2;
			this.checkBoxFullScreen.Text = "Full Screen";
			this.checkBoxFullScreen.CheckedChanged += new System.EventHandler(this.checkBoxFullScreen_CheckedChanged);
			// 
			// checkBoxZoom
			// 
			this.checkBoxZoom.Checked = true;
			this.checkBoxZoom.CheckState = ((Wisej.Web.CheckState)(Wisej.Web.CheckState.Checked));
			this.checkBoxZoom.Location = new System.Drawing.Point(16, 50);
			this.checkBoxZoom.Name = "checkBoxZoom";
			this.checkBoxZoom.Size = new System.Drawing.Size(60, 23);
			this.checkBoxZoom.TabIndex = 1;
			this.checkBoxZoom.Text = "Zoom";
			this.checkBoxZoom.CheckedChanged += new System.EventHandler(this.checkBoxZoom_CheckedChanged);
			// 
			// checkBoxMapType
			// 
			this.checkBoxMapType.Checked = true;
			this.checkBoxMapType.CheckState = ((Wisej.Web.CheckState)(Wisej.Web.CheckState.Checked));
			this.checkBoxMapType.Location = new System.Drawing.Point(16, 25);
			this.checkBoxMapType.Name = "checkBoxMapType";
			this.checkBoxMapType.Size = new System.Drawing.Size(85, 23);
			this.checkBoxMapType.TabIndex = 0;
			this.checkBoxMapType.Text = "Map Type";
			this.checkBoxMapType.CheckedChanged += new System.EventHandler(this.checkBoxMapType_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBoxMapType);
			this.groupBox2.Controls.Add(this.checkedListBoxMapType);
			this.flowLayoutPanel1.SetFillWeight(this.groupBox2, 33);
			this.groupBox2.Location = new System.Drawing.Point(414, 3);
			this.groupBox2.MinimumSize = new System.Drawing.Size(152, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(405, 140);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.Text = "Map Type";
			this.groupBox2.UseMnemonic = false;
			// 
			// comboBoxMapType
			// 
			this.comboBoxMapType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxMapType.Items.AddRange(new object[] {
            "Roadmap",
            "Hybrid",
            "Satellite",
            "Terrain"});
			this.comboBoxMapType.Location = new System.Drawing.Point(18, 25);
			this.comboBoxMapType.Name = "comboBoxMapType";
			this.comboBoxMapType.Size = new System.Drawing.Size(106, 22);
			this.comboBoxMapType.TabIndex = 1;
			this.comboBoxMapType.Text = "Map";
			this.comboBoxMapType.SelectedIndexChanged += new System.EventHandler(this.comboBoxMatType_SelectedIndexChanged);
			// 
			// checkedListBoxMapType
			// 
			this.checkedListBoxMapType.BorderStyle = Wisej.Web.BorderStyle.None;
			this.checkedListBoxMapType.Items.AddRange(new object[] {
            "Roadmap",
            "Hybrid",
            "Satellite",
            "Terrain"});
			this.checkedListBoxMapType.Location = new System.Drawing.Point(130, 20);
			this.checkedListBoxMapType.Name = "checkedListBoxMapType";
			this.checkedListBoxMapType.Size = new System.Drawing.Size(139, 113);
			this.checkedListBoxMapType.TabIndex = 0;
			this.checkedListBoxMapType.AfterItemCheck += new Wisej.Web.ItemCheckEventHandler(this.checkedListBoxMapType_AfterItemCheck);
			// 
			// googleMap1
			// 
			this.googleMap1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.googleMap1.ApiKey = "AIzaSyDJ13giW35qbt9Qsznjy_CFqMJMQlAjoSw";
			this.googleMap1.Location = new System.Drawing.Point(40, 515);
			this.googleMap1.MinimumSize = new System.Drawing.Size(0, 400);
			this.googleMap1.Name = "googleMap1";
			this.googleMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"zoom\":4,\"center\":{\"lat\":0,\"lng\":0},\"mapTypeId\":\"roadmap\",\"mapTypeControlOptions" +
        "\":{\"style\":2,\"mapTypeIds\":[\"roadmap\",\"hybrid\",\"satellite\",\"terrain\"]}}")));
			this.googleMap1.Size = new System.Drawing.Size(1234, 400);
			this.googleMap1.TabIndex = 0;
			this.googleMap1.Text = "googleMap1";
			this.googleMap1.MapClick += new Wisej.Web.Ext.GoogleMaps.MapMouseEventHandler(this.googleMap1_MapClick);
			this.googleMap1.MapPropertyChanged += new Wisej.Web.Ext.GoogleMaps.MapPropertyChangedEventHandler(this.googleMap1_MapPropertyChanged);
			this.googleMap1.MarkerDragEnd += new Wisej.Web.Ext.GoogleMaps.MarkerDragEventHandler(this.googleMap1_MarkerDragEnd);
			this.googleMap1.MapDragEnd += new System.EventHandler(this.googleMap1_MapDragEnd);
			// 
			// trackBar1
			// 
			this.trackBar1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.trackBar1.Location = new System.Drawing.Point(21, 98);
			this.trackBar1.Maximum = 20;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(368, 34);
			this.trackBar1.TabIndex = 3;
			this.trackBar1.TickStyle = Wisej.Web.TickStyle.Both;
			this.trackBar1.Value = 10;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.trackBar1);
			this.groupBox3.Controls.Add(this.numericUpDownMaxZoom);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.numericUpDownMinZoom);
			this.flowLayoutPanel1.SetFillWeight(this.groupBox3, 33);
			this.flowLayoutPanel1.SetFlowBreak(this.groupBox3, true);
			this.groupBox3.Location = new System.Drawing.Point(825, 3);
			this.groupBox3.MinimumSize = new System.Drawing.Size(210, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(405, 140);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.Text = "Zoom";
			this.groupBox3.UseMnemonic = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Max:";
			// 
			// numericUpDownMaxZoom
			// 
			this.numericUpDownMaxZoom.Location = new System.Drawing.Point(70, 54);
            this.numericUpDownMaxZoom.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownMaxZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownMaxZoom.Name = "numericUpDownMaxZoom";
			this.numericUpDownMaxZoom.Size = new System.Drawing.Size(104, 22);
			this.numericUpDownMaxZoom.TabIndex = 2;
            this.numericUpDownMaxZoom.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDownMaxZoom.ValueChanged += new System.EventHandler(this.numericUpDownMaxZoom_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Min:";
			// 
			// numericUpDownMinZoom
			// 
			this.numericUpDownMinZoom.Location = new System.Drawing.Point(70, 23);
            this.numericUpDownMinZoom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMinZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownMinZoom.Name = "numericUpDownMinZoom";
			this.numericUpDownMinZoom.Size = new System.Drawing.Size(104, 22);
			this.numericUpDownMinZoom.TabIndex = 0;
            this.numericUpDownMinZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownMinZoom.ValueChanged += new System.EventHandler(this.numericUpDownMinZoom_ValueChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.tableLayoutPanel1);
			this.flowLayoutPanel1.SetFillWeight(this.groupBox4, 100);
			this.flowLayoutPanel1.SetFlowBreak(this.groupBox4, true);
			this.groupBox4.Location = new System.Drawing.Point(3, 149);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1228, 160);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.Text = "Markers";
			this.groupBox4.UseMnemonic = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 85F));
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1222, 139);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.buttonCurrentLocation);
			this.panel4.Dock = Wisej.Web.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(3, 88);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(605, 48);
			this.panel4.TabIndex = 3;
			// 
			// buttonCurrentLocation
			// 
			this.buttonCurrentLocation.Anchor = Wisej.Web.AnchorStyles.Left;
			this.buttonCurrentLocation.Location = new System.Drawing.Point(90, 1);
			this.buttonCurrentLocation.Name = "buttonCurrentLocation";
			this.buttonCurrentLocation.Size = new System.Drawing.Size(200, 40);
			this.buttonCurrentLocation.TabIndex = 11;
			this.buttonCurrentLocation.Text = "Current Location";
			this.buttonCurrentLocation.Click += new System.EventHandler(this.buttonCurrentLocation_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.buttonCenterMap);
			this.panel3.Controls.Add(this.buttonClearMarkers);
			this.panel3.Controls.Add(this.buttonAddMarker);
			this.panel3.Controls.Add(this.buttonRemoveMarker);
			this.panel3.Dock = Wisej.Web.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(614, 88);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(605, 48);
			this.panel3.TabIndex = 2;
			// 
			// buttonCenterMap
			// 
			this.buttonCenterMap.Anchor = Wisej.Web.AnchorStyles.Right;
			this.buttonCenterMap.Location = new System.Drawing.Point(193, 1);
			this.buttonCenterMap.Name = "buttonCenterMap";
			this.buttonCenterMap.Size = new System.Drawing.Size(97, 40);
			this.buttonCenterMap.TabIndex = 11;
			this.buttonCenterMap.Text = "Center Map";
			this.buttonCenterMap.Click += new System.EventHandler(this.buttonCenterMap_Click);
			// 
			// buttonClearMarkers
			// 
			this.buttonClearMarkers.Anchor = Wisej.Web.AnchorStyles.Right;
			this.buttonClearMarkers.Location = new System.Drawing.Point(502, 1);
			this.buttonClearMarkers.Name = "buttonClearMarkers";
			this.buttonClearMarkers.Size = new System.Drawing.Size(97, 40);
			this.buttonClearMarkers.TabIndex = 10;
			this.buttonClearMarkers.Text = "Clear";
			this.buttonClearMarkers.Click += new System.EventHandler(this.buttonClearMarkers_Click);
			// 
			// buttonAddMarker
			// 
			this.buttonAddMarker.Anchor = Wisej.Web.AnchorStyles.Right;
			this.buttonAddMarker.Location = new System.Drawing.Point(296, 1);
			this.buttonAddMarker.Name = "buttonAddMarker";
			this.buttonAddMarker.Size = new System.Drawing.Size(97, 40);
			this.buttonAddMarker.TabIndex = 8;
			this.buttonAddMarker.Text = "Add";
			this.buttonAddMarker.Click += new System.EventHandler(this.buttonAddMarker_Click);
			// 
			// buttonRemoveMarker
			// 
			this.buttonRemoveMarker.Anchor = Wisej.Web.AnchorStyles.Right;
			this.buttonRemoveMarker.Location = new System.Drawing.Point(399, 1);
			this.buttonRemoveMarker.Name = "buttonRemoveMarker";
			this.buttonRemoveMarker.Size = new System.Drawing.Size(97, 40);
			this.buttonRemoveMarker.TabIndex = 9;
			this.buttonRemoveMarker.Text = "Remove";
			this.buttonRemoveMarker.Click += new System.EventHandler(this.buttonRemoveMarker_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.textBoxAddress);
			this.panel2.Dock = Wisej.Web.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(614, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(605, 79);
			this.panel2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Address:";
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxAddress.Location = new System.Drawing.Point(89, 3);
			this.textBoxAddress.Multiline = true;
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(507, 76);
			this.textBoxAddress.TabIndex = 1;
			this.textBoxAddress.Watermark = "Type Piccadilly Circus";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBoxDraggableMarker);
			this.panel1.Controls.Add(this.maskedTextBoxLng);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.maskedTextBoxLat);
			this.panel1.Controls.Add(this.maskedTextBoxID);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Dock = Wisej.Web.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(605, 79);
			this.panel1.TabIndex = 0;
			// 
			// checkBoxDraggableMarker
			// 
			this.checkBoxDraggableMarker.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.checkBoxDraggableMarker.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxDraggableMarker.Location = new System.Drawing.Point(441, 3);
			this.checkBoxDraggableMarker.Name = "checkBoxDraggableMarker";
			this.checkBoxDraggableMarker.Size = new System.Drawing.Size(133, 23);
			this.checkBoxDraggableMarker.TabIndex = 8;
			this.checkBoxDraggableMarker.Text = "Draggable Marker";
			// 
			// maskedTextBoxLng
			// 
			this.maskedTextBoxLng.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.maskedTextBoxLng.Location = new System.Drawing.Point(90, 55);
			this.maskedTextBoxLng.Name = "maskedTextBoxLng";
			this.maskedTextBoxLng.Size = new System.Drawing.Size(486, 22);
			this.maskedTextBoxLng.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Latitude:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "Longitude:";
			// 
			// maskedTextBoxLat
			// 
			this.maskedTextBoxLat.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.maskedTextBoxLat.Location = new System.Drawing.Point(90, 29);
			this.maskedTextBoxLat.Name = "maskedTextBoxLat";
			this.maskedTextBoxLat.Size = new System.Drawing.Size(486, 22);
			this.maskedTextBoxLat.TabIndex = 4;
			// 
			// maskedTextBoxID
			// 
			this.maskedTextBoxID.Location = new System.Drawing.Point(90, 3);
			this.maskedTextBoxID.Name = "maskedTextBoxID";
			this.maskedTextBoxID.Size = new System.Drawing.Size(77, 22);
			this.maskedTextBoxID.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 7);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(25, 16);
			this.label6.TabIndex = 6;
			this.label6.Text = "ID:";
			// 
			// buttonCoordsFromAddress
			// 
			this.buttonCoordsFromAddress.Anchor = Wisej.Web.AnchorStyles.Left;
			this.buttonCoordsFromAddress.Location = new System.Drawing.Point(16, 79);
			this.buttonCoordsFromAddress.Name = "buttonCoordsFromAddress";
			this.buttonCoordsFromAddress.Size = new System.Drawing.Size(150, 32);
			this.buttonCoordsFromAddress.TabIndex = 13;
			this.buttonCoordsFromAddress.Text = "Coords from Address";
			this.buttonCoordsFromAddress.Click += new System.EventHandler(this.buttonCoordsFromAddress_Click);
			// 
			// buttonAddressFromCoords
			// 
			this.buttonAddressFromCoords.Anchor = Wisej.Web.AnchorStyles.Left;
			this.buttonAddressFromCoords.Location = new System.Drawing.Point(16, 35);
			this.buttonAddressFromCoords.Name = "buttonAddressFromCoords";
			this.buttonAddressFromCoords.Size = new System.Drawing.Size(150, 32);
			this.buttonAddressFromCoords.TabIndex = 12;
			this.buttonAddressFromCoords.Text = "Address from Coords";
			this.buttonAddressFromCoords.Click += new System.EventHandler(this.buttonAddressFromCoords_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.groupBox1);
			this.flowLayoutPanel1.Controls.Add(this.groupBox2);
			this.flowLayoutPanel1.Controls.Add(this.groupBox3);
			this.flowLayoutPanel1.Controls.Add(this.groupBox4);
			this.flowLayoutPanel1.Controls.Add(this.groupBox5);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 34);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1234, 451);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.buttonCopyToMarkers);
			this.groupBox5.Controls.Add(this.buttonShowDetails);
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.geocodeLng);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.geocodeLat);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.buttonCoordsFromAddress);
			this.groupBox5.Controls.Add(this.geocodeAddress);
			this.groupBox5.Controls.Add(this.buttonAddressFromCoords);
			this.flowLayoutPanel1.SetFillWeight(this.groupBox5, 100);
			this.groupBox5.Location = new System.Drawing.Point(3, 315);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(1228, 125);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.Text = "Reverse Geocode";
			// 
			// buttonCopyToMarkers
			// 
			this.buttonCopyToMarkers.Anchor = Wisej.Web.AnchorStyles.Right;
			this.buttonCopyToMarkers.Location = new System.Drawing.Point(1119, 35);
			this.buttonCopyToMarkers.Name = "buttonCopyToMarkers";
			this.buttonCopyToMarkers.Size = new System.Drawing.Size(97, 35);
			this.buttonCopyToMarkers.TabIndex = 18;
			this.buttonCopyToMarkers.Text = "To Markers";
			this.buttonCopyToMarkers.Click += new System.EventHandler(this.buttonCopyToMarkers_Click);
			// 
			// buttonShowDetails
			// 
			this.buttonShowDetails.Anchor = Wisej.Web.AnchorStyles.Right;
			this.buttonShowDetails.Location = new System.Drawing.Point(1119, 79);
			this.buttonShowDetails.Name = "buttonShowDetails";
			this.buttonShowDetails.Size = new System.Drawing.Size(97, 35);
			this.buttonShowDetails.TabIndex = 11;
			this.buttonShowDetails.Text = "Show Details";
			this.buttonShowDetails.Click += new System.EventHandler(this.buttonShowDetails_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(659, 69);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 16);
			this.label9.TabIndex = 16;
			this.label9.Text = "Latiude:";
			// 
			// geocodeLng
			// 
			this.geocodeLng.Location = new System.Drawing.Point(659, 89);
			this.geocodeLng.Name = "geocodeLng";
			this.geocodeLng.Size = new System.Drawing.Size(200, 22);
			this.geocodeLng.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(659, 15);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 16);
			this.label8.TabIndex = 14;
			this.label8.Text = "Latiude:";
			// 
			// geocodeLat
			// 
			this.geocodeLat.Location = new System.Drawing.Point(659, 35);
			this.geocodeLat.Name = "geocodeLat";
			this.geocodeLat.Size = new System.Drawing.Size(200, 22);
			this.geocodeLat.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(208, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 16);
			this.label7.TabIndex = 2;
			this.label7.Text = "Address:";
			// 
			// geocodeAddress
			// 
			this.geocodeAddress.Location = new System.Drawing.Point(208, 35);
			this.geocodeAddress.Multiline = true;
			this.geocodeAddress.Name = "geocodeAddress";
			this.geocodeAddress.Size = new System.Drawing.Size(400, 76);
			this.geocodeAddress.TabIndex = 3;
			// 
			// geolocation
			// 
			this.geolocation.MaximumAge = ((long)(-1));
			this.geolocation.Timeout = ((long)(-1));
			// 
			// MapPage
			// 
			this.AutoScroll = true;
			this.AutoScrollMargin = new System.Drawing.Size(0, 20);
			this.Controls.Add(this.googleMap1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "MapPage";
			this.Size = new System.Drawing.Size(1312, 797);
			this.Load += new System.EventHandler(this.MapPage_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxZoom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinZoom)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private Web.Ext.GoogleMaps.GoogleMap googleMap1;
        private Web.GroupBox groupBox1;
        private Web.CheckBox checkBoxFullScreen;
        private Web.CheckBox checkBoxZoom;
        private Web.CheckBox checkBoxMapType;
        private Web.GroupBox groupBox2;
        private Web.CheckedListBox checkedListBoxMapType;
        private Web.CheckBox checkBoxStreetView;
        private Web.TrackBar trackBar1;
        private Web.GroupBox groupBox3;
        private Web.Label label2;
        private Web.NumericUpDown numericUpDownMaxZoom;
        private Web.Label label1;
        private Web.NumericUpDown numericUpDownMinZoom;
        private Web.GroupBox groupBox4;
        private Web.MaskedTextBox maskedTextBoxLat;
        private Web.Label label5;
        private Web.Label label4;
        private Web.TextBox textBoxAddress;
        private Web.Label label3;
        private Web.MaskedTextBox maskedTextBoxID;
        private Web.Label label6;
        private Web.MaskedTextBox maskedTextBoxLng;
        private Web.Button buttonClearMarkers;
        private Web.Button buttonRemoveMarker;
        private Web.Button buttonAddMarker;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.TableLayoutPanel tableLayoutPanel1;
        private Web.Panel panel3;
        private Web.Panel panel2;
        private Web.Panel panel1;
        private Web.ComboBox comboBoxMapType;
        private Web.Button buttonCenterMap;
        private Web.Panel panel4;
        private Web.Button buttonCurrentLocation;
        private Ext.Geolocation.Geolocation geolocation;
        private Web.Button buttonAddressFromCoords;
        private Web.Button buttonCoordsFromAddress;
        private Web.GroupBox groupBox5;
        private Web.Label label9;
        private Web.TextBox geocodeLng;
        private Web.Label label8;
        private Web.TextBox geocodeLat;
        private Web.Label label7;
        private Web.TextBox geocodeAddress;
        private Web.Button buttonShowDetails;
        private Web.Button buttonCopyToMarkers;
        private Web.CheckBox checkBoxDraggableMarker;
    }
}
