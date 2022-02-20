namespace Wisej.Mobile.Portal.Views
{
	partial class ViewBase
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
			this.animation1 = new Wisej.Web.Animation(this.components);
			this.animation2 = new Wisej.Web.Animation(this.components);
			this.labelTitle = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.CssStyle = "transition: font-size 0.25s;";
			this.labelTitle.Dock = Wisej.Web.DockStyle.Top;
			this.labelTitle.Font = new System.Drawing.Font("@windowTitle", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelTitle.Location = new System.Drawing.Point(16, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.labelTitle.Size = new System.Drawing.Size(618, 128);
			this.labelTitle.TabIndex = 18;
			this.labelTitle.Text = "ViewBase";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ViewBase
			// 
			this.Controls.Add(this.labelTitle);
			this.Name = "ViewBase";
			this.Padding = new Wisej.Web.Padding(16, 0, 16, 0);
			this.Size = new System.Drawing.Size(650, 478);
			this.Load += new System.EventHandler(this.ViewBase_Load);
			this.ResumeLayout(false);

		}

		#endregion

		public Web.Animation animation2;
		public Web.Animation animation1;
		public Web.Label labelTitle;
	}
}
