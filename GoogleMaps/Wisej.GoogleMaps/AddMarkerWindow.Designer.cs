namespace Wisej.GoogleMaps
{
	partial class AddMarkerWindow
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

		#region Wisej.NET Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonAdd = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.groupBoxCoordinates = new Wisej.Web.GroupBox();
			this.textBoxLat = new Wisej.Web.TextBox();
			this.textBoxLng = new Wisej.Web.TextBox();
			this.groupBoxAddress = new Wisej.Web.GroupBox();
			this.textBoxAddress = new Wisej.Web.TextBox();
			this.label1 = new Wisej.Web.Label();
			this.groupBoxCoordinates.SuspendLayout();
			this.groupBoxAddress.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonAdd.AppearanceKey = "button-ok";
			this.buttonAdd.Location = new System.Drawing.Point(468, 298);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(100, 37);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(362, 298);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 37);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// groupBoxCoordinates
			// 
			this.groupBoxCoordinates.BackColor = System.Drawing.Color.FromName("@toolbar");
			this.groupBoxCoordinates.Controls.Add(this.textBoxLat);
			this.groupBoxCoordinates.Controls.Add(this.textBoxLng);
			this.groupBoxCoordinates.Location = new System.Drawing.Point(31, 64);
			this.groupBoxCoordinates.Name = "groupBoxCoordinates";
			this.groupBoxCoordinates.Padding = new Wisej.Web.Padding(8);
			this.groupBoxCoordinates.ShowCheckBox = true;
			this.groupBoxCoordinates.Size = new System.Drawing.Size(225, 152);
			this.groupBoxCoordinates.TabIndex = 2;
			this.groupBoxCoordinates.Text = " Coordinates";
			this.groupBoxCoordinates.CheckedChanged += new System.EventHandler(this.groupBoxCoordinates_CheckedChanged);
			// 
			// textBoxLat
			// 
			this.textBoxLat.InputType.Type = Wisej.Web.TextBoxType.Number;
			this.textBoxLat.LabelText = "Latitude";
			this.textBoxLat.Location = new System.Drawing.Point(11, 23);
			this.textBoxLat.Name = "textBoxLat";
			this.textBoxLat.Size = new System.Drawing.Size(201, 53);
			this.textBoxLat.TabIndex = 1;
			// 
			// textBoxLng
			// 
			this.textBoxLng.InputType.Type = Wisej.Web.TextBoxType.Number;
			this.textBoxLng.LabelText = "Longitude";
			this.textBoxLng.Location = new System.Drawing.Point(11, 84);
			this.textBoxLng.Name = "textBoxLng";
			this.textBoxLng.Size = new System.Drawing.Size(201, 53);
			this.textBoxLng.TabIndex = 2;
			// 
			// groupBoxAddress
			// 
			this.groupBoxAddress.BackColor = System.Drawing.Color.FromName("@toolbar");
			this.groupBoxAddress.Checked = false;
			this.groupBoxAddress.Controls.Add(this.textBoxAddress);
			this.groupBoxAddress.Location = new System.Drawing.Point(349, 64);
			this.groupBoxAddress.Name = "groupBoxAddress";
			this.groupBoxAddress.Padding = new Wisej.Web.Padding(8);
			this.groupBoxAddress.ShowCheckBox = true;
			this.groupBoxAddress.Size = new System.Drawing.Size(219, 152);
			this.groupBoxAddress.TabIndex = 3;
			this.groupBoxAddress.Text = "Location";
			this.groupBoxAddress.CheckedChanged += new System.EventHandler(this.groupBoxAddress_CheckedChanged);
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.LabelText = "Address";
			this.textBoxAddress.Location = new System.Drawing.Point(11, 23);
			this.textBoxAddress.Multiline = true;
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(195, 114);
			this.textBoxAddress.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(291, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "OR";
			// 
			// AddMarkerWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 351);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBoxCoordinates);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.groupBoxAddress);
			this.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/pin-map.svg";
			this.KeepCentered = true;
			this.KeepOnScreen = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddMarkerWindow";
			this.Text = "Add Marker";
			this.groupBoxCoordinates.ResumeLayout(false);
			this.groupBoxCoordinates.PerformLayout();
			this.groupBoxAddress.ResumeLayout(false);
			this.groupBoxAddress.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Button buttonAdd;
		private Web.Button buttonCancel;
		private Web.GroupBox groupBoxCoordinates;
		private Web.TextBox textBoxLat;
		private Web.TextBox textBoxLng;
		private Web.GroupBox groupBoxAddress;
		private Web.TextBox textBoxAddress;
		private Web.Label label1;
	}
}