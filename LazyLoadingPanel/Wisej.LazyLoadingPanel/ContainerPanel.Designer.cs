namespace Wisej.LazyLoadingPanel
{
	partial class ContainerPanel
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
			this.ajaxLoader = new Wisej.Web.PictureBox();
			this.loaderPanel = new Wisej.Web.Panel();
			this.label1 = new Wisej.Web.Label();
			((System.ComponentModel.ISupportInitialize)(this.ajaxLoader)).BeginInit();
			this.loaderPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ajaxLoader
			// 
			this.ajaxLoader.Anchor = Wisej.Web.AnchorStyles.None;
			this.ajaxLoader.ImageSource = "ajax-loader";
			this.ajaxLoader.Location = new System.Drawing.Point(76, 18);
			this.ajaxLoader.Name = "ajaxLoader";
			this.ajaxLoader.Size = new System.Drawing.Size(83, 47);
			this.ajaxLoader.SizeMode = Wisej.Web.PictureBoxSizeMode.CenterImage;
			this.ajaxLoader.TabIndex = 0;
			// 
			// loaderPanel
			// 
			this.loaderPanel.Controls.Add(this.label1);
			this.loaderPanel.Controls.Add(this.ajaxLoader);
			this.loaderPanel.Dock = Wisej.Web.DockStyle.Top;
			this.loaderPanel.Location = new System.Drawing.Point(0, 0);
			this.loaderPanel.Name = "loaderPanel";
			this.loaderPanel.Size = new System.Drawing.Size(341, 78);
			this.loaderPanel.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.None;
			this.label1.Location = new System.Drawing.Point(182, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 47);
			this.label1.TabIndex = 1;
			this.label1.Text = "Loading...";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ContainerPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.loaderPanel);
			this.ResizableEdges = Web.AnchorStyles.Bottom | Web.AnchorStyles.Right;
			this.MinimumSize = new System.Drawing.Size(340, 500);
			this.ScrollBars = Web.ScrollBars.Vertical;
			this.Name = "ContainerPanel";
			this.Size = new System.Drawing.Size(340, 143);
			this.Load += new System.EventHandler(this.ContainerPanel_Load);
			this.Scroll += new Wisej.Web.ScrollEventHandler(this.ContainerPanel_Scroll);
			this.Resize += new System.EventHandler(this.ContainerPanel_Resize);
			((System.ComponentModel.ISupportInitialize)(this.ajaxLoader)).EndInit();
			this.loaderPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.PictureBox ajaxLoader;
		private Web.Panel loaderPanel;
		private Web.Label label1;
	}
}
