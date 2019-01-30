namespace Wisej.LazyLoadingPanel
{
	partial class ItemPanel
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
			this.icon = new Wisej.Web.PictureBox();
			this.title = new Wisej.Web.Label();
			this.text = new Wisej.Web.Label();
			this.action = new Wisej.Web.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.action)).BeginInit();
			this.SuspendLayout();
			// 
			// icon
			// 
			this.icon.Location = new System.Drawing.Point(14, 18);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(64, 64);
			this.icon.TabIndex = 0;
			// 
			// title
			// 
			this.title.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.title.AutoEllipsis = true;
			this.title.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.title.Location = new System.Drawing.Point(95, 18);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(382, 20);
			this.title.TabIndex = 1;
			this.title.Text = "label1";
			this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// text
			// 
			this.text.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.text.Location = new System.Drawing.Point(95, 44);
			this.text.Name = "text";
			this.text.Size = new System.Drawing.Size(412, 38);
			this.text.TabIndex = 2;
			this.text.Text = "label1";
			// 
			// action
			// 
			this.action.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.action.Cursor = Wisej.Web.Cursors.Hand;
			this.action.ImageSource = "icon-right";
			this.action.Location = new System.Drawing.Point(491, 18);
			this.action.Name = "action";
			this.action.Size = new System.Drawing.Size(16, 16);
			this.action.TabIndex = 3;
			this.action.Click += new System.EventHandler(this.action_Click);
			// 
			// ItemPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.action);
			this.Controls.Add(this.text);
			this.Controls.Add(this.title);
			this.Controls.Add(this.icon);
			this.Name = "ItemPanel";
			this.Size = new System.Drawing.Size(525, 101);
			((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.action)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.PictureBox icon;
		private Web.Label title;
		private Web.Label text;
		private Web.PictureBox action;
	}
}
