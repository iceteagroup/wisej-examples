namespace Wisej.Mobile.Portal.Views
{
	partial class AppItemView
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
			this.labelURL = new Wisej.Web.Label();
			this.pictureBoxIcon = new Wisej.Web.PictureBox();
			this.buttonMenu = new Wisej.Web.Button();
			this.menuItem3 = new Wisej.Web.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.labelTitle.Anonymous = true;
			this.labelTitle.AutoEllipsis = true;
			this.labelTitle.Font = new System.Drawing.Font("@menu", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelTitle.Location = new System.Drawing.Point(21, 60);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(126, 36);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Features";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelURL
			// 
			this.labelURL.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.labelURL.Anonymous = true;
			this.labelURL.CssStyle = "overflow: hidden;\r\ntext-overflow: ellipsis;\r\ndisplay: -webkit-box;\r\n-webkit-line-" +
    "clamp: 3;\r\n-webkit-box-orient: vertical;";
			this.labelURL.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelURL.ForeColor = System.Drawing.Color.FromArgb(151, 151, 151);
			this.labelURL.Location = new System.Drawing.Point(22, 93);
			this.labelURL.Name = "labelURL";
			this.labelURL.Size = new System.Drawing.Size(125, 61);
			this.labelURL.TabIndex = 1;
			this.labelURL.Text = "test tes ttest t ajf;ldjaldkjff adjkf adlkjflakd jflak fdjakl df";
			// 
			// pictureBoxIcon
			// 
			this.pictureBoxIcon.ImageSource = "Images\\test.png";
			this.pictureBoxIcon.Location = new System.Drawing.Point(19, 15);
			this.pictureBoxIcon.Name = "pictureBoxIcon";
			this.pictureBoxIcon.Size = new System.Drawing.Size(40, 40);
			this.pictureBoxIcon.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// buttonMenu
			// 
			this.buttonMenu.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonMenu.BackColor = System.Drawing.Color.FromName("@window");
			this.buttonMenu.Focusable = false;
			this.buttonMenu.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/show-more-button-with-three-dots.svg?color=#" +
    "979797";
			this.buttonMenu.InitScript = "this.setShowArrow(false);";
			this.buttonMenu.Location = new System.Drawing.Point(112, 15);
			this.buttonMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem3});
			this.buttonMenu.Name = "buttonMenu";
			this.buttonMenu.Size = new System.Drawing.Size(35, 40);
			this.buttonMenu.TabIndex = 2;
			this.buttonMenu.ItemClicked += new Wisej.Web.MenuButtonItemClickedEventHandler(this.buttonMenu_ItemClicked);
			// 
			// menuItem3
			// 
			this.menuItem3.ForeColor = System.Drawing.Color.FromName("@danger");
			this.menuItem3.Index = 0;
			this.menuItem3.Name = "menuItem3";
			this.menuItem3.Text = "Delete";
			// 
			// AppItemView
			// 
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.buttonMenu);
			this.Controls.Add(this.pictureBoxIcon);
			this.Controls.Add(this.labelURL);
			this.Controls.Add(this.labelTitle);
			this.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;";
			this.Margin = new Wisej.Web.Padding(10);
			this.Name = "AppItemView";
			this.Padding = new Wisej.Web.Padding(10);
			this.Size = new System.Drawing.Size(160, 168);
			this.Load += new System.EventHandler(this.AppItem_Load);
			this.Click += new System.EventHandler(this.AppItem_Click);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Label labelTitle;
		private Web.Label labelURL;
		private Web.PictureBox pictureBoxIcon;
		private Web.Button buttonMenu;
		private Web.MenuItem menuItem3;
	}
}
