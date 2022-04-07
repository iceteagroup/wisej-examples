namespace Wisej.LazyLoadingPanel
{
	partial class Page1
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
            this.containerPanel1 = new Wisej.LazyLoadingPanel.ContainerPanel();
            this.SuspendLayout();
            // 
            // containerPanel1
            // 
            this.containerPanel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.containerPanel1.Location = new System.Drawing.Point(100, 74);
            this.containerPanel1.Name = "containerPanel1";
            this.containerPanel1.Size = new System.Drawing.Size(384, 582);
            this.containerPanel1.TabIndex = 0;
            this.containerPanel1.LoadPanels += new System.EventHandler(this.containerPanel1_LoadPanels);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.containerPanel1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1064, 807);
            this.Text = "Page1";
            this.ResumeLayout(false);

		}

		#endregion

		private ContainerPanel containerPanel1;
	}
}

