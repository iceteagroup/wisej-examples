namespace UploadFiles
{
	partial class Window1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pictureBox = new Wisej.Web.PictureBox();
			this.label1 = new Wisej.Web.Label();
			this.upload1 = new Wisej.Web.Upload();
			this.label2 = new Wisej.Web.Label();
			this.flowLayoutPanel = new Wisej.Web.FlowLayoutPanel();
			this.upload2 = new Wisej.Web.Upload();
			this.buttonClear = new Wisej.Web.Button();
			this.helpTip = new Wisej.Web.HelpTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.AllowDrop = true;
			this.pictureBox.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
			this.pictureBox.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.helpTip.SetHelpTip(this.pictureBox, null);
			this.pictureBox.Location = new System.Drawing.Point(22, 53);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(258, 372);
			this.pictureBox.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 6;
			this.pictureBox.TabStop = false;
			this.pictureBox.DragDrop += new Wisej.Web.DragEventHandler(this.pictureBox_DragDrop);
			this.pictureBox.DragEnter += new Wisej.Web.DragEventHandler(this.pictureBox_DragEnter);
			// 
			// label1
			// 
			this.label1.AllowHtml = true;
			this.helpTip.SetHelpTip(this.label1, null);
			this.label1.Location = new System.Drawing.Point(22, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "PictureBox <b>(Drop Target)</b>";
			// 
			// upload1
			// 
			this.upload1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
			this.helpTip.SetHelpTip(this.upload1, null);
			this.upload1.HideValue = true;
			this.upload1.Location = new System.Drawing.Point(22, 441);
			this.upload1.Name = "upload1";
			this.upload1.Size = new System.Drawing.Size(258, 43);
			this.upload1.TabIndex = 2;
			this.upload1.AllowedFileTypes = "image/*";
			this.upload1.Text = "Click to upload a new image";
			this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
			// 
			// label2
			// 
			this.label2.AllowHtml = true;
			this.helpTip.SetHelpTip(this.label2, null);
			this.label2.Location = new System.Drawing.Point(295, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(322, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "FlowLayoutPanel <b>(Multiple Files Drop Target)</b>";
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.AllowDrop = true;
			this.flowLayoutPanel.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanel.AutoScroll = true;
			this.flowLayoutPanel.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.helpTip.SetHelpTip(this.flowLayoutPanel, "Click on an image to download it.");
			this.flowLayoutPanel.Location = new System.Drawing.Point(295, 53);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(438, 372);
			this.flowLayoutPanel.TabIndex = 4;
			this.flowLayoutPanel.DragDrop += new Wisej.Web.DragEventHandler(this.flowLayoutPanel_DragDrop);
			this.flowLayoutPanel.DragEnter += new Wisej.Web.DragEventHandler(this.flowLayoutPanel_DragEnter);
			// 
			// upload2
			// 
			this.upload2.AllowMultipleFiles = true;
			this.upload2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.helpTip.SetHelpTip(this.upload2, null);
			this.upload2.HideValue = true;
			this.upload2.Location = new System.Drawing.Point(295, 441);
			this.upload2.Name = "upload2";
			this.upload2.Size = new System.Drawing.Size(309, 43);
			this.upload2.TabIndex = 5;
			this.upload2.Text = "Click to upload multiple images";
			this.upload2.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload2_Uploaded);
			// 
			// buttonClear
			// 
			this.buttonClear.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.helpTip.SetHelpTip(this.buttonClear, null);
			this.buttonClear.Location = new System.Drawing.Point(621, 441);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(112, 43);
			this.buttonClear.TabIndex = 7;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// Window1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 505);
			this.ControlBox = false;
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.upload2);
			this.Controls.Add(this.flowLayoutPanel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.upload1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox);
			this.helpTip.SetHelpTip(this, null);
			this.Name = "Window1";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "Window1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.PictureBox pictureBox;
		private Wisej.Web.Label label1;
		private Wisej.Web.Upload upload1;
		private Wisej.Web.Label label2;
		private Wisej.Web.FlowLayoutPanel flowLayoutPanel;
		private Wisej.Web.Upload upload2;
		private Wisej.Web.Button buttonClear;
		private Wisej.Web.HelpTip helpTip;


	}
}

