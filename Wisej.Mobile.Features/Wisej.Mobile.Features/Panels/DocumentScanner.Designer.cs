namespace Wisej.Mobile.Features.Panels
{
	partial class DocumentScanner
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
            this.dataRepeaterDocument = new Wisej.Web.DataRepeater();
            this.pictureBoxPage = new Wisej.Web.PictureBox();
            this.buttonScan = new Wisej.Web.Button();
            this.spacer1 = new Wisej.Web.Spacer();
            this.trackBarQuality = new Wisej.Web.TrackBar();
            this.spacer2 = new Wisej.Web.Spacer();
            this.label1 = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeaterDocument)).BeginInit();
            this.dataRepeaterDocument.ItemTemplate.SuspendLayout();
            this.dataRepeaterDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRepeaterDocument
            // 
            this.dataRepeaterDocument.Dock = Wisej.Web.DockStyle.Top;
            this.dataRepeaterDocument.ItemHeaderVisible = false;
            this.dataRepeaterDocument.ItemSize = new System.Drawing.Size(200, 249);
            // 
            // dataRepeaterDocument.ItemTemplate
            // 
            this.dataRepeaterDocument.ItemTemplate.Controls.Add(this.pictureBoxPage);
            this.dataRepeaterDocument.ItemTemplate.Padding = new Wisej.Web.Padding(8);
            this.dataRepeaterDocument.ItemTemplate.Size = new System.Drawing.Size(618, 249);
            this.dataRepeaterDocument.Location = new System.Drawing.Point(16, 128);
            this.dataRepeaterDocument.Name = "dataRepeaterDocument";
            this.dataRepeaterDocument.Size = new System.Drawing.Size(620, 282);
            this.dataRepeaterDocument.TabIndex = 0;
            this.dataRepeaterDocument.Text = "dataRepeater1";
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.Dock = Wisej.Web.DockStyle.Fill;
            this.pictureBoxPage.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(602, 233);
            this.pictureBoxPage.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // buttonScan
            // 
            this.buttonScan.Dock = Wisej.Web.DockStyle.Top;
            this.buttonScan.Location = new System.Drawing.Point(16, 504);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(620, 40);
            this.buttonScan.TabIndex = 1;
            this.buttonScan.Text = "Scan Documents";
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // spacer1
            // 
            this.spacer1.Dock = Wisej.Web.DockStyle.Top;
            this.spacer1.Location = new System.Drawing.Point(16, 410);
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(620, 20);
            // 
            // trackBarQuality
            // 
            this.trackBarQuality.Dock = Wisej.Web.DockStyle.Top;
            this.trackBarQuality.LargeChange = 1;
            this.trackBarQuality.Location = new System.Drawing.Point(16, 450);
            this.trackBarQuality.Maximum = 100;
            this.trackBarQuality.Name = "trackBarQuality";
            this.trackBarQuality.Size = new System.Drawing.Size(620, 34);
            this.trackBarQuality.TabIndex = 20;
            this.trackBarQuality.TickFrequency = 20;
            this.trackBarQuality.TickStyle = Wisej.Web.TickStyle.None;
            this.trackBarQuality.Value = 1;
            // 
            // spacer2
            // 
            this.spacer2.Dock = Wisej.Web.DockStyle.Top;
            this.spacer2.Location = new System.Drawing.Point(16, 484);
            this.spacer2.Name = "spacer2";
            this.spacer2.Size = new System.Drawing.Size(620, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Wisej.Web.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(16, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Compression Quality";
            // 
            // DocumentScanner
            // 
            this.animation1.GetAnimation(this).Duration = 350;
            this.animation1.GetAnimation(this).Event = "appear";
            this.animation1.GetAnimation(this).Name = "slideRightIn";
            this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.animation2.GetAnimation(this).Duration = 350;
            this.animation2.GetAnimation(this).Event = "disappear";
            this.animation2.GetAnimation(this).Name = "slideRightOut";
            this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.spacer2);
            this.Controls.Add(this.trackBarQuality);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spacer1);
            this.Controls.Add(this.dataRepeaterDocument);
            this.Name = "DocumentScanner";
            this.Size = new System.Drawing.Size(652, 550);
            this.Load += new System.EventHandler(this.DocumentScanner_Load);
            this.Controls.SetChildIndex(this.dataRepeaterDocument, 0);
            this.Controls.SetChildIndex(this.spacer1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.trackBarQuality, 0);
            this.Controls.SetChildIndex(this.spacer2, 0);
            this.Controls.SetChildIndex(this.buttonScan, 0);
            this.dataRepeaterDocument.ItemTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeaterDocument)).EndInit();
            this.dataRepeaterDocument.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.DataRepeater dataRepeaterDocument;
		private Web.Button buttonScan;
		private Web.PictureBox pictureBoxPage;
		private Web.Spacer spacer1;
		private Web.TrackBar trackBarQuality;
		private Web.Spacer spacer2;
        private Web.Label label1;
    }
}
