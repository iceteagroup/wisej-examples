namespace Wisej.Mobile.Portal.Views
{
	partial class Apps
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
			this.flowLayoutPanelApps = new Wisej.Web.FlowLayoutPanel();
			this.button1 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Text = "Wisej Portal";
			// 
			// flowLayoutPanelApps
			// 
			this.flowLayoutPanelApps.AutoScroll = true;
			this.flowLayoutPanelApps.AutoScrollMargin = new System.Drawing.Size(0, 20);
			this.flowLayoutPanelApps.CssStyle = "transition: 0.5s;";
			this.flowLayoutPanelApps.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanelApps.Location = new System.Drawing.Point(16, 128);
			this.flowLayoutPanelApps.Name = "flowLayoutPanelApps";
			this.flowLayoutPanelApps.ScrollBars = Wisej.Web.ScrollBars.Hidden;
			this.flowLayoutPanelApps.Size = new System.Drawing.Size(618, 350);
			this.flowLayoutPanelApps.TabIndex = 19;
			this.flowLayoutPanelApps.TabStop = true;
			this.flowLayoutPanelApps.Scroll += new Wisej.Web.ScrollEventHandler(this.flowLayoutPanelApps_Scroll);
			// 
			// button1
			// 
			this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.FromName("@accent");
			this.button1.CssStyle = "border-radius: 100px;\r\nborder-color: #6087E7;\r\nbox-shadow: rgba(99, 99, 99, 0.2) " +
    "0px 2px 8px 0px;";
			this.button1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/add-plus-button.svg?color=#FFFFFF";
			this.button1.Location = new System.Drawing.Point(566, 393);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 75);
			this.button1.TabIndex = 0;
			this.button1.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// Apps
			// 
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideLeftOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideLeftIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.flowLayoutPanelApps);
			this.Name = "Apps";
			this.Load += new System.EventHandler(this.Apps_Load);
			this.Controls.SetChildIndex(this.labelTitle, 0);
			this.Controls.SetChildIndex(this.flowLayoutPanelApps, 0);
			this.Controls.SetChildIndex(this.button1, 0);
			this.ResumeLayout(false);

		}

		#endregion
		private Web.FlowLayoutPanel flowLayoutPanelApps;
		private Web.Button button1;
	}
}
