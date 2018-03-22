namespace Wisej.Responsive.Views
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
			this.buttonClose = new Wisej.Web.Button();
			this.labelTitle = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonClose.ImageSource = "icon-close";
			this.buttonClose.Location = new System.Drawing.Point(688, 0);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(50, 33);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// labelTitle
			// 
			this.labelTitle.BackColor = System.Drawing.Color.FromName("@buttonFace");
			this.labelTitle.Dock = Wisej.Web.DockStyle.Top;
			this.labelTitle.ForeColor = System.Drawing.Color.FromName("@buttonText");
			this.labelTitle.Location = new System.Drawing.Point(0, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(740, 33);
			this.labelTitle.TabIndex = 1;
			this.labelTitle.Text = "label1";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ViewBase
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.labelTitle);
			this.Name = "ViewBase";
			this.Size = new System.Drawing.Size(740, 642);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonClose;
		private Web.Label labelTitle;
	}
}
