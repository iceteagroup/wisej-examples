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
			((System.ComponentModel.ISupportInitialize)(this.dataRepeaterDocument)).BeginInit();
			this.dataRepeaterDocument.ItemTemplate.SuspendLayout();
			this.dataRepeaterDocument.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
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
			this.dataRepeaterDocument.ItemTemplate.Size = new System.Drawing.Size(616, 249);
			this.dataRepeaterDocument.Location = new System.Drawing.Point(16, 128);
			this.dataRepeaterDocument.Name = "dataRepeaterDocument";
			this.dataRepeaterDocument.Size = new System.Drawing.Size(618, 282);
			this.dataRepeaterDocument.TabIndex = 0;
			this.dataRepeaterDocument.Text = "dataRepeater1";
			// 
			// pictureBoxPage
			// 
			this.pictureBoxPage.Dock = Wisej.Web.DockStyle.Fill;
			this.pictureBoxPage.Location = new System.Drawing.Point(8, 8);
			this.pictureBoxPage.Name = "pictureBoxPage";
			this.pictureBoxPage.Size = new System.Drawing.Size(600, 233);
			this.pictureBoxPage.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// buttonScan
			// 
			this.buttonScan.Dock = Wisej.Web.DockStyle.Top;
			this.buttonScan.Location = new System.Drawing.Point(16, 430);
			this.buttonScan.Name = "buttonScan";
			this.buttonScan.Size = new System.Drawing.Size(618, 40);
			this.buttonScan.TabIndex = 1;
			this.buttonScan.Text = "Scan Documents";
			this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 410);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
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
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.dataRepeaterDocument);
			this.Name = "DocumentScanner";
			this.Size = new System.Drawing.Size(650, 504);
			this.Load += new System.EventHandler(this.DocumentScanner_Load);
			this.Controls.SetChildIndex(this.dataRepeaterDocument, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonScan, 0);
			this.dataRepeaterDocument.ItemTemplate.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataRepeaterDocument)).EndInit();
			this.dataRepeaterDocument.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.DataRepeater dataRepeaterDocument;
		private Web.Button buttonScan;
		private Web.PictureBox pictureBoxPage;
		private Web.Spacer spacer1;
	}
}
