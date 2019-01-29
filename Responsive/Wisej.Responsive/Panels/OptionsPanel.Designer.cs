using Wisej.Web;

namespace Wisej.Responsive.Panels
{
	partial class OptionsPanel
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
			this.buttonProducts = new Wisej.Web.Button();
			this.imageList = new Wisej.Web.ImageList(this.components);
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.label1 = new Wisej.Web.Label();
			this.buttonCustomers = new Wisej.Web.Button();
			this.buttonDashboard = new Wisej.Web.Button();
			this.styleSheet = new Wisej.Web.StyleSheet(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonProducts
			// 
			this.buttonProducts.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.buttonProducts.ImageList = this.imageList;
			this.buttonProducts.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/shopping-cart.svg";
			this.buttonProducts.Location = new System.Drawing.Point(0, 119);
			this.buttonProducts.Name = "buttonProducts";
			this.buttonProducts.Size = new System.Drawing.Size(250, 77);
			this.buttonProducts.TabIndex = 0;
			this.buttonProducts.Text = "Products";
			this.buttonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonProducts.Click += new System.EventHandler(this.button_Click);
			// 
			// imageList
			// 
			this.imageList.ImageSize = new System.Drawing.Size(32, 32);
			// 
			// pictureBox1
			// 
			this.pictureBox1.ImageSource = "Images/Wisej-Logo-64x64.png";
			this.pictureBox1.Location = new System.Drawing.Point(16, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(65, 69);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AllowHtml = true;
			this.label1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(113, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 69);
			this.label1.TabIndex = 2;
			this.label1.Text = "ACME\r\nHardware\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonCustomers
			// 
			this.buttonCustomers.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.buttonCustomers.ImageList = this.imageList;
			this.buttonCustomers.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/users-social-symbol.svg";
			this.buttonCustomers.Location = new System.Drawing.Point(0, 196);
			this.buttonCustomers.Name = "buttonCustomers";
			this.buttonCustomers.Size = new System.Drawing.Size(250, 77);
			this.buttonCustomers.TabIndex = 3;
			this.buttonCustomers.Text = "Customers";
			this.buttonCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCustomers.Click += new System.EventHandler(this.button_Click);
			// 
			// buttonDashboard
			// 
			this.buttonDashboard.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.buttonDashboard.ImageList = this.imageList;
			this.buttonDashboard.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/medium-wifi-signal-with-two-bars.svg";
			this.buttonDashboard.Location = new System.Drawing.Point(0, 273);
			this.buttonDashboard.Name = "buttonDashboard";
			this.buttonDashboard.Size = new System.Drawing.Size(250, 77);
			this.buttonDashboard.TabIndex = 4;
			this.buttonDashboard.Text = "Dashboard";
			this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonDashboard.Click += new System.EventHandler(this.button_Click);
			// 
			// styleSheet
			// 
			this.styleSheet.Styles = ".active\r\n{\r\n    border-bottom: 4px solid yellow;\r\n}";
			// 
			// OptionsPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(191)))), ((int)(((byte)(179)))));
			this.Controls.Add(this.buttonDashboard);
			this.Controls.Add(this.buttonCustomers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonProducts);
			this.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "OptionsPanel";
			this.Size = new System.Drawing.Size(250, 680);
			this.Load += new System.EventHandler(this.OptionsPanel_Load);
			this.ResponsiveProfileChanged += new ResponsiveProfileChangedEventHandler(this.OptionsPanel_ResponsiveProfileChanged);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonProducts;
		private Web.PictureBox pictureBox1;
		private Web.Label label1;
		private Web.ImageList imageList;
		private Web.Button buttonCustomers;
		private Web.Button buttonDashboard;
		private Web.StyleSheet styleSheet;
	}
}
