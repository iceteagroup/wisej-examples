namespace Wisej.Mobile.Features.Panels
{
	public partial class AppItemView
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
			this.labelTitle = new Wisej.Web.Label();
			this.labelDescription = new Wisej.Web.Label();
			this.pictureBoxIcon = new Wisej.Web.PictureBox();
			this.buttonMenu = new Wisej.Web.Button();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.labelTitle.Anonymous = true;
			this.labelTitle.AutoSize = true;
			this.flowLayoutPanel1.SetFillWeight(this.labelTitle, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.labelTitle, true);
			this.labelTitle.Font = new System.Drawing.Font("@menu", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelTitle.Location = new System.Drawing.Point(3, 49);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(134, 18);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Features tes test test";
			// 
			// labelDescription
			// 
			this.labelDescription.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.labelDescription.Anonymous = true;
			this.labelDescription.CssStyle = "overflow: hidden;\r\ntext-overflow: ellipsis;\r\ndisplay: -webkit-box;\r\n-webkit-line-" +
    "clamp: 3;\r\n-webkit-box-orient: vertical;";
			this.flowLayoutPanel1.SetFillWeight(this.labelDescription, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.labelDescription, true);
			this.labelDescription.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(151, 151, 151);
			this.labelDescription.Location = new System.Drawing.Point(3, 73);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(134, 41);
			this.labelDescription.TabIndex = 1;
			this.labelDescription.Text = "test tes ttest t ajf;ldjaldkjff adjkf adlkjflakd jflak fdjakl df";
			// 
			// pictureBoxIcon
			// 
			this.pictureBoxIcon.Anonymous = true;
			this.pictureBoxIcon.ImageSource = "Images\\test.png";
			this.pictureBoxIcon.Location = new System.Drawing.Point(3, 3);
			this.pictureBoxIcon.Name = "pictureBoxIcon";
			this.pictureBoxIcon.Size = new System.Drawing.Size(40, 40);
			this.pictureBoxIcon.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// buttonMenu
			// 
			this.buttonMenu.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonMenu.Anonymous = true;
			this.buttonMenu.BackColor = System.Drawing.Color.Transparent;
			this.flowLayoutPanel1.SetFillWeight(this.buttonMenu, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.buttonMenu, true);
			this.buttonMenu.Focusable = false;
			this.buttonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonMenu.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/show-more-button-with-three-dots.svg?color=#" +
    "979797";
			this.buttonMenu.InitScript = "this.setShowArrow(false);";
			this.buttonMenu.Location = new System.Drawing.Point(49, 3);
			this.buttonMenu.Name = "buttonMenu";
			this.buttonMenu.Size = new System.Drawing.Size(88, 40);
			this.buttonMenu.TabIndex = 2;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anonymous = true;
			this.flowLayoutPanel1.Controls.Add(this.pictureBoxIcon);
			this.flowLayoutPanel1.Controls.Add(this.buttonMenu);
			this.flowLayoutPanel1.Controls.Add(this.labelTitle);
			this.flowLayoutPanel1.Controls.Add(this.labelDescription);
			this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 148);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// AppItemView
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.flowLayoutPanel1);
			this.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;";
			this.Margin = new Wisej.Web.Padding(10);
			this.Name = "AppItemView";
			this.Padding = new Wisej.Web.Padding(10);
			this.Size = new System.Drawing.Size(160, 168);
			this.Load += new System.EventHandler(this.AppItem_Load);
			this.Click += new System.EventHandler(this.AppItemView_Click);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Label labelTitle;
		private Web.Label labelDescription;
		private Web.PictureBox pictureBoxIcon;
		private Web.Button buttonMenu;
		private Web.FlowLayoutPanel flowLayoutPanel1;
	}
}
