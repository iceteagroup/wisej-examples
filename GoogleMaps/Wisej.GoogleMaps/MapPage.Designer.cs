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
            this.coordsFromAddressButton = new Wisej.Web.Button();
            this.addressFromCoordsButton = new Wisej.Web.Button();
            this.currentLocationButton = new Wisej.Web.Button();
            this.panel3 = new Wisej.Web.Panel();
            this.buttonCenterMap = new Wisej.Web.Button();
            this.buttonClearMarkers = new Wisej.Web.Button();
            this.buttonAddMarker = new Wisej.Web.Button();
            this.buttonRemoveMarker = new Wisej.Web.Button();
            this.panel2 = new Wisej.Web.Panel();
            this.label3 = new Wisej.Web.Label();
            this.textBoxAddress = new Wisej.Web.TextBox();
            this.panel1 = new Wisej.Web.Panel();
            this.maskedTextBoxLng = new Wisej.Web.MaskedTextBox();
            this.label4 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.maskedTextBoxLat = new Wisej.Web.MaskedTextBox();
            this.maskedTextBoxID = new Wisej.Web.MaskedTextBox();
            this.label6 = new Wisej.Web.Label();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
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
            this.groupBox1.MinimumSize = new System.Drawing.Size(150, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "Controls";
            this.groupBox1.UseMnemonic = false;
            // 
            // checkBoxStreetView
            // 
            this.checkBoxStreetView.Checked = true;
            this.checkBoxStreetView.CheckState = ((Wisej.Web.CheckState)(Wisej.Web.CheckState.Checked));
            this.checkBoxStreetView.Location = new System.Drawing.Point(16, 115);
            this.checkBoxStreetView.Name = "checkBoxStreetView";
            this.checkBoxStreetView.Size = new System.Drawing.Size(94, 23);
            this.checkBoxStreetView.TabIndex = 3;
            this.checkBoxStreetView.Text = "Street View";
            this.checkBoxStreetView.CheckedChanged += new System.EventHandler(this.StreetView_CheckedChanged);
            // 
            // checkBoxFullScreen
            // 
            this.checkBoxFullScreen.Location = new System.Drawing.Point(16, 85);
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
            this.checkBoxZoom.Location = new System.Drawing.Point(16, 55);
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
            this.groupBox2.Location = new System.Drawing.Point(344, 3);
            this.groupBox2.MinimumSize = new System.Drawing.Size(150, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 172);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.Text = "Map Type";
            this.groupBox2.UseMnemonic = false;
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxMapType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxMapType.Items.AddRange(new object[] {
            "Roadmap",
            "Hybrid",
            "Satellite",
            "Terrain"});
            this.comboBoxMapType.Location = new System.Drawing.Point(18, 25);
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.comboBoxMapType.Size = new System.Drawing.Size(69, 22);
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
            this.checkedListBoxMapType.Location = new System.Drawing.Point(18, 53);
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
            this.googleMap1.Location = new System.Drawing.Point(48, 453);
            this.googleMap1.MaximumSize = new System.Drawing.Size(1024, 0);
            this.googleMap1.MinimumSize = new System.Drawing.Size(0, 400);
            this.googleMap1.Name = "googleMap1";
            this.googleMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"zoom\":4,\"center\":{\"lat\":0,\"lng\":0},\"mapTypeId\":\"roadmap\",\"mapTypeControlOptions" +
        "\":{\"style\":2,\"mapTypeIds\":[\"roadmap\",\"hybrid\",\"satellite\",\"terrain\"]}}")));
            this.googleMap1.Size = new System.Drawing.Size(1024, 400);
            this.googleMap1.TabIndex = 0;
            this.googleMap1.Text = "googleMap1";
            this.googleMap1.MapClick += new Wisej.Web.Ext.GoogleMaps.MapMouseEventHandler(this.googleMap1_MapClick);
            this.googleMap1.MapPropertyChanged += new Wisej.Web.Ext.GoogleMaps.MapPropertyChangedEventHandler(this.googleMap1_MapPropertyChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(22, 105);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(298, 34);
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
            this.groupBox3.Location = new System.Drawing.Point(685, 3);
            this.groupBox3.MinimumSize = new System.Drawing.Size(210, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 172);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.Text = "Zoom";
            this.groupBox3.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max:";
            // 
            // numericUpDownMaxZoom
            // 
            this.numericUpDownMaxZoom.Location = new System.Drawing.Point(71, 57);
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
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min:";
            // 
            // numericUpDownMinZoom
            // 
            this.numericUpDownMinZoom.Location = new System.Drawing.Point(71, 26);
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
            this.groupBox4.Location = new System.Drawing.Point(3, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1018, 207);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1012, 185);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.coordsFromAddressButton);
            this.panel4.Controls.Add(this.addressFromCoordsButton);
            this.panel4.Controls.Add(this.currentLocationButton);
            this.panel4.Dock = Wisej.Web.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 64);
            this.panel4.TabIndex = 3;
            // 
            // coordsFromAddressBtton
            // 
            this.coordsFromAddressButton.Anchor = Wisej.Web.AnchorStyles.Left;
            this.coordsFromAddressButton.Location = new System.Drawing.Point(202, 11);
            this.coordsFromAddressButton.Name = "coordsFromAddressButton";
            this.coordsFromAddressButton.Size = new System.Drawing.Size(97, 43);
            this.coordsFromAddressButton.TabIndex = 13;
            this.coordsFromAddressButton.Text = "Coords from Address";
            this.coordsFromAddressButton.Click += new System.EventHandler(this.coordsFromAddressButton_Click);
            // 
            // addressFromCoordsButton
            // 
            this.addressFromCoordsButton.Anchor = Wisej.Web.AnchorStyles.Right;
            this.addressFromCoordsButton.Location = new System.Drawing.Point(374, 11);
            this.addressFromCoordsButton.Name = "addressFromCoordsButton";
            this.addressFromCoordsButton.Size = new System.Drawing.Size(97, 43);
            this.addressFromCoordsButton.TabIndex = 12;
            this.addressFromCoordsButton.Text = "Address from Coords";
            this.addressFromCoordsButton.Click += new System.EventHandler(this.addressFromCoordsButton_Click);
            // 
            // currentLocationButton
            // 
            this.currentLocationButton.Anchor = Wisej.Web.AnchorStyles.Left;
            this.currentLocationButton.Location = new System.Drawing.Point(11, 11);
            this.currentLocationButton.Name = "currentLocationButton";
            this.currentLocationButton.Size = new System.Drawing.Size(97, 43);
            this.currentLocationButton.TabIndex = 11;
            this.currentLocationButton.Text = "Current Location";
            this.currentLocationButton.Click += new System.EventHandler(this.currentLocationButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCenterMap);
            this.panel3.Controls.Add(this.buttonClearMarkers);
            this.panel3.Controls.Add(this.buttonAddMarker);
            this.panel3.Controls.Add(this.buttonRemoveMarker);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(509, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 64);
            this.panel3.TabIndex = 2;
            // 
            // buttonCenterMap
            // 
            this.buttonCenterMap.Anchor = Wisej.Web.AnchorStyles.Right;
            this.buttonCenterMap.Location = new System.Drawing.Point(88, 11);
            this.buttonCenterMap.Name = "buttonCenterMap";
            this.buttonCenterMap.Size = new System.Drawing.Size(97, 43);
            this.buttonCenterMap.TabIndex = 11;
            this.buttonCenterMap.Text = "Center Map";
            this.buttonCenterMap.Click += new System.EventHandler(this.buttonCenterMap_Click);
            // 
            // buttonClearMarkers
            // 
            this.buttonClearMarkers.Anchor = Wisej.Web.AnchorStyles.Right;
            this.buttonClearMarkers.Location = new System.Drawing.Point(397, 11);
            this.buttonClearMarkers.Name = "buttonClearMarkers";
            this.buttonClearMarkers.Size = new System.Drawing.Size(97, 43);
            this.buttonClearMarkers.TabIndex = 10;
            this.buttonClearMarkers.Text = "Clear";
            this.buttonClearMarkers.Click += new System.EventHandler(this.buttonClearMarkers_Click);
            // 
            // buttonAddMarker
            // 
            this.buttonAddMarker.Anchor = Wisej.Web.AnchorStyles.Right;
            this.buttonAddMarker.Location = new System.Drawing.Point(191, 11);
            this.buttonAddMarker.Name = "buttonAddMarker";
            this.buttonAddMarker.Size = new System.Drawing.Size(97, 43);
            this.buttonAddMarker.TabIndex = 8;
            this.buttonAddMarker.Text = "Add";
            this.buttonAddMarker.Click += new System.EventHandler(this.buttonAddMarker_Click);
            // 
            // buttonRemoveMarker
            // 
            this.buttonRemoveMarker.Anchor = Wisej.Web.AnchorStyles.Right;
            this.buttonRemoveMarker.Location = new System.Drawing.Point(294, 11);
            this.buttonRemoveMarker.Name = "buttonRemoveMarker";
            this.buttonRemoveMarker.Size = new System.Drawing.Size(97, 43);
            this.buttonRemoveMarker.TabIndex = 9;
            this.buttonRemoveMarker.Text = "Remove";
            this.buttonRemoveMarker.Click += new System.EventHandler(this.buttonRemoveMarker_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxAddress);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(509, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 109);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 11);
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
            this.textBoxAddress.Location = new System.Drawing.Point(89, 11);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(402, 95);
            this.textBoxAddress.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBoxLng);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.maskedTextBoxLat);
            this.panel1.Controls.Add(this.maskedTextBoxID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 109);
            this.panel1.TabIndex = 0;
            // 
            // maskedTextBoxLng
            // 
            this.maskedTextBoxLng.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.maskedTextBoxLng.Location = new System.Drawing.Point(90, 65);
            this.maskedTextBoxLng.Name = "maskedTextBoxLng";
            this.maskedTextBoxLng.Size = new System.Drawing.Size(381, 22);
            this.maskedTextBoxLng.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Latitude:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Longitude:";
            // 
            // maskedTextBoxLat
            // 
            this.maskedTextBoxLat.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.maskedTextBoxLat.Location = new System.Drawing.Point(90, 37);
            this.maskedTextBoxLat.Name = "maskedTextBoxLat";
            this.maskedTextBoxLat.Size = new System.Drawing.Size(381, 22);
            this.maskedTextBoxLat.TabIndex = 4;
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Location = new System.Drawing.Point(90, 9);
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(77, 22);
            this.maskedTextBoxID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(48, 46);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(1024, 388);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1024, 388);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // geolocation
            // 
            this.geolocation.MaximumAge = ((long)(-1));
            this.geolocation.Timeout = ((long)(-1));
            // 
            // MapPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.googleMap1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MapPage";
            this.Size = new System.Drawing.Size(922, 696);
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
        private Web.Button currentLocationButton;
        private Ext.Geolocation.Geolocation geolocation;
        private Web.Button addressFromCoordsButton;
        private Web.Button coordsFromAddressButton;
    }
}
