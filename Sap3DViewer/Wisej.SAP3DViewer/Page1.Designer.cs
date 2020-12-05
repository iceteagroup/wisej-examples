namespace Wisej.SAP3DViewer
{
	partial class Page1
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
			Wisej.Core.FileSystemProvider fileSystemProvider1 = new Wisej.Core.FileSystemProvider();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
			this.button1 = new Wisej.Web.Button();
			this.openFileDialog = new Wisej.Web.OpenFileDialog(this.components);
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.button2 = new Wisej.Web.Button();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.upload1 = new Wisej.Web.Upload();
			this.groupBox1 = new Wisej.Web.GroupBox();
			this.label1 = new Wisej.Web.Label();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.flexLayoutPanel2 = new Wisej.Web.FlexLayoutPanel();
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.widget1 = new Wisej.SAP3DViewer.VdsViewer();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flexLayoutPanel2.SuspendLayout();
			this.flexLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 101);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(568, 57);
			this.button1.TabIndex = 1;
			this.button1.Text = "Load Server File";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "VDS (*.vds)|*.vds|All files (*.*)|*.*";
			this.openFileDialog.InitialDirectory = "Project Files";
			fileSystemProvider1.Name = "Project Files";
			fileSystemProvider1.Root = "~\\Samples\\";
			this.openFileDialog.Roots.Add(fileSystemProvider1);
			this.openFileDialog.Title = "Select a VDS file.";
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.comboBox1.AutoSize = false;
			this.comboBox1.DisplayMember = "name";
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Enabled = false;
			this.comboBox1.Location = new System.Drawing.Point(16, 34);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(546, 43);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.ValueMember = "id";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button2
			// 
			this.button2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.button2.Display = Wisej.Web.Display.Icon;
			this.button2.Enabled = false;
			this.button2.ImageSource = "node-closed";
			this.button2.Location = new System.Drawing.Point(515, 100);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(47, 43);
			this.button2.TabIndex = 3;
			this.button2.Text = "Play";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.comboBox2.AutoSize = false;
			this.comboBox2.DisplayMember = "name";
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox2.Enabled = false;
			this.comboBox2.Location = new System.Drawing.Point(16, 100);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(493, 43);
			this.comboBox2.TabIndex = 4;
			this.comboBox2.ValueMember = "id";
			// 
			// upload1
			// 
			this.upload1.HideValue = true;
			this.upload1.Location = new System.Drawing.Point(3, 35);
			this.upload1.Name = "upload1";
			this.upload1.Size = new System.Drawing.Size(568, 50);
			this.upload1.TabIndex = 5;
			this.upload1.Text = "Load Client File";
			this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Location = new System.Drawing.Point(3, 174);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(568, 173);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.Text = "Play Steps";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(567, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "Drag & Drop a VDS file";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.flexLayoutPanel2);
			this.flowLayoutPanel1.Controls.Add(this.flexLayoutPanel1);
			this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flowLayoutPanel1.ResponsiveProfiles"))));
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1159, 647);
			this.flowLayoutPanel1.TabIndex = 8;
			this.flowLayoutPanel1.TabStop = true;
			// 
			// flexLayoutPanel2
			// 
			this.flexLayoutPanel2.AutoSize = true;
			this.flexLayoutPanel2.Controls.Add(this.label1);
			this.flexLayoutPanel2.Controls.Add(this.widget1);
			this.flowLayoutPanel1.SetFillWeight(this.flexLayoutPanel2, 1);
			this.flexLayoutPanel2.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.flexLayoutPanel2.MinimumSize = new System.Drawing.Size(300, 0);
			this.flexLayoutPanel2.Name = "flexLayoutPanel2";
			this.flexLayoutPanel2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flexLayoutPanel2.ResponsiveProfiles"))));
			this.flexLayoutPanel2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flexLayoutPanel2.ResponsiveProfiles1"))));
			this.flexLayoutPanel2.Size = new System.Drawing.Size(573, 641);
			this.flexLayoutPanel2.Spacing = 4;
			this.flexLayoutPanel2.TabIndex = 8;
			this.flexLayoutPanel2.TabStop = true;
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.AutoSize = true;
			this.flexLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
			this.flexLayoutPanel1.Controls.Add(this.upload1);
			this.flexLayoutPanel1.Controls.Add(this.button1);
			this.flexLayoutPanel1.Controls.Add(this.groupBox1);
			this.flexLayoutPanel1.CssStyle = "transition:top 150ms, left 150ms";
			this.flowLayoutPanel1.SetFillWeight(this.flexLayoutPanel1, 1);
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(582, 3);
			this.flexLayoutPanel1.MinimumSize = new System.Drawing.Size(300, 0);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Padding = new Wisej.Web.Padding(0, 32, 0, 0);
			this.flexLayoutPanel1.Size = new System.Drawing.Size(574, 350);
			this.flexLayoutPanel1.TabIndex = 9;
			this.flexLayoutPanel1.TabStop = true;
			// 
			// widget1
			// 
			this.widget1.AllowDrop = true;
			this.widget1.Location = new System.Drawing.Point(3, 38);
			this.widget1.Name = "widget1";
			this.widget1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("widget1.ResponsiveProfiles"))));
			this.widget1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("widget1.ResponsiveProfiles1"))));
			this.widget1.Size = new System.Drawing.Size(567, 600);
			this.widget1.TabIndex = 0;
			this.widget1.Text = "widget1";
			this.widget1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.widget1_WidgetEvent);
			this.widget1.WebRequest += new Wisej.Web.WebRequestHandler(this.widget1_WebRequest);
			this.widget1.DragDrop += new Wisej.Web.DragEventHandler(this.widget1_DragDrop);
			this.widget1.DragEnter += new Wisej.Web.DragEventHandler(this.widget1_DragEnter);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Page1";
			this.Padding = new Wisej.Web.Padding(5);
			this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
			this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles1"))));
			this.Size = new System.Drawing.Size(1169, 480);
			this.Text = "Page1";
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flexLayoutPanel2.ResumeLayout(false);
			this.flexLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private VdsViewer widget1;
		private Web.Button button1;
		private Web.OpenFileDialog openFileDialog;
		private Web.ComboBox comboBox1;
		private Web.Button button2;
		private Web.ComboBox comboBox2;
		private Web.Upload upload1;
		private Web.GroupBox groupBox1;
		private Web.Label label1;
		private Web.FlowLayoutPanel flowLayoutPanel1;
		private Web.FlexLayoutPanel flexLayoutPanel2;
		private Web.FlexLayoutPanel flexLayoutPanel1;
	}
}

