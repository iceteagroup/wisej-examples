namespace Wisej.CodeProject.Examples
{
	partial class MediaExample
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
			this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
			this.panel1 = new Wisej.Web.Panel();
			this.label2 = new Wisej.Web.Label();
			this.label1 = new Wisej.Web.Label();
			this.button2 = new Wisej.Web.Button();
			this.button1 = new Wisej.Web.Button();
			this.audio1 = new Wisej.Web.Audio();
			this.video1 = new Wisej.Web.Video();
			this.pdfViewer1 = new Wisej.Web.PdfViewer();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.video1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pdfViewer1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 599);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.CollapseSide = Wisej.Web.HeaderPosition.Left;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.audio1);
			this.panel1.Dock = Wisej.Web.DockStyle.Fill;
			this.panel1.HeaderPosition = Wisej.Web.HeaderPosition.Left;
			this.panel1.Location = new System.Drawing.Point(452, 302);
			this.panel1.Name = "panel1";
			this.panel1.ShowCloseButton = false;
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(444, 294);
			this.panel1.TabIndex = 2;
			this.panel1.Text = "Audio Sample";
			// 
			// label2
			// 
			this.label2.AllowHtml = true;
			this.label2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(186, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 51);
			this.label2.TabIndex = 4;
			this.label2.Text = "Position:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AllowHtml = true;
			this.label1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(186, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 51);
			this.label1.TabIndex = 3;
			this.label1.Text = "Audio Status: Paused";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button2
			// 
			this.button2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/stop-button.svg";
			this.button2.Location = new System.Drawing.Point(16, 81);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(154, 51);
			this.button2.TabIndex = 2;
			this.button2.Text = "Stop";
			this.button2.Enabled = false;
			this.button2.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/play-slideshow-button.svg";
			this.button1.Location = new System.Drawing.Point(16, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(154, 51);
			this.button1.TabIndex = 1;
			this.button1.Text = "Play";
			this.button1.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// audio1
			// 
			this.audio1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.audio1.AutoPlay = false;
			this.audio1.Location = new System.Drawing.Point(16, 205);
			this.audio1.Name = "audio1";
			this.audio1.Size = new System.Drawing.Size(383, 74);
			this.audio1.SourceURL = "http://www.thesoundarchive.com/starwars/imperial_march.mp3";
			this.audio1.TabIndex = 0;
			this.audio1.Volume = 0.5D;
			this.audio1.CurrentTimeChanged += new System.EventHandler(this.audio1_CurrentTimeChanged);
			this.audio1.Paused += new System.EventHandler(this.audio1_Paused);
			this.audio1.Playing += new System.EventHandler(this.audio1_Playing);
			// 
			// video1
			// 
			this.video1.Dock = Wisej.Web.DockStyle.Fill;
			this.video1.Location = new System.Drawing.Point(452, 3);
			this.video1.Name = "video1";
			this.video1.Size = new System.Drawing.Size(444, 293);
			this.video1.SourceURL = "https://dl3.webmfiles.org/big-buck-bunny_trailer.webm";
			this.video1.TabIndex = 1;
			this.video1.Volume = 0.5D;
			this.video1.AutoPlay = true;
			// 
			// pdfViewer1
			// 
			this.pdfViewer1.Dock = Wisej.Web.DockStyle.Fill;
			this.pdfViewer1.Location = new System.Drawing.Point(3, 3);
			this.pdfViewer1.Name = "pdfViewer1";
			this.pdfViewer1.PdfSource = "Files\\Wisej-Datasheet-V2.3.pdf";
			this.tableLayoutPanel1.SetRowSpan(this.pdfViewer1, 2);
			this.pdfViewer1.Size = new System.Drawing.Size(443, 593);
			this.pdfViewer1.TabIndex = 0;
			this.pdfViewer1.ViewerType = Wisej.Web.PdfViewerType.Mozilla;
			// 
			// MediaExample
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(953, 653);
			this.Controls.Add(this.tableLayoutPanel1);
			this.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/film-roll.svg?color=#7FBF3F";
			this.Name = "MediaExample";
			this.Text = "Media Example";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.TableLayoutPanel tableLayoutPanel1;
		private Web.PdfViewer pdfViewer1;
		private Web.Video video1;
		private Web.Panel panel1;
		private Web.Button button2;
		private Web.Button button1;
		private Web.Label label2;
		private Web.Label label1;
		private Web.Audio audio1;
	}
}