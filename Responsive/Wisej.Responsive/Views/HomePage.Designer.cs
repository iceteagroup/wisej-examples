namespace Wisej.Responsive.Views
{
	partial class HomePage
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
			this.optionsPanel1 = new Wisej.Responsive.Panels.OptionsPanel();
			this.workspacePanel = new Wisej.Responsive.Panels.WorkspacePanel();
			this.SuspendLayout();
			// 
			// optionsPanel1
			// 
			this.optionsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(191)))), ((int)(((byte)(179)))));
			this.optionsPanel1.Dock = Wisej.Web.DockStyle.Left;
			this.optionsPanel1.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.optionsPanel1.Location = new System.Drawing.Point(0, 0);
			this.optionsPanel1.Name = "optionsPanel1";
			this.optionsPanel1.Size = new System.Drawing.Size(250, 874);
			this.optionsPanel1.TabIndex = 0;
			this.optionsPanel1.OptionClick += new Wisej.Responsive.Panels.OptionsPanel.OptionClickedEventHandler(this.optionsPanel1_OptionClick);
			// 
			// workspacePanel
			// 
			this.workspacePanel.BackgroundImageLayout = Wisej.Web.ImageLayout.BestFit;
			this.workspacePanel.BackgroundImageSource = "Images/Background.jpg";
			this.workspacePanel.Dock = Wisej.Web.DockStyle.Fill;
			this.workspacePanel.Location = new System.Drawing.Point(250, 0);
			this.workspacePanel.Name = "workspacePanel";
			this.workspacePanel.Size = new System.Drawing.Size(1182, 874);
			this.workspacePanel.TabIndex = 1;
			// 
			// HomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.workspacePanel);
			this.Controls.Add(this.optionsPanel1);
			this.Name = "HomePage";
			this.Size = new System.Drawing.Size(1432, 874);
			this.ResumeLayout(false);

		}

		#endregion

		private Panels.OptionsPanel optionsPanel1;
		private Panels.WorkspacePanel workspacePanel;
	}
}
