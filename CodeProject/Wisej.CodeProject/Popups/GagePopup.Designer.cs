namespace Wisej.CodeProject.Popups
{
	partial class GagePopup
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
			this.justGage1 = new Wisej.Web.Ext.JustGage.JustGage();
			this.SuspendLayout();
			// 
			// justGage1
			// 
			this.justGage1.BackColor = System.Drawing.Color.White;
			this.justGage1.Dock = Wisej.Web.DockStyle.Fill;
			this.justGage1.ForeColor = System.Drawing.Color.White;
			this.justGage1.LabelColor = System.Drawing.Color.GhostWhite;
			this.justGage1.Location = new System.Drawing.Point(0, 0);
			this.justGage1.Name = "justGage1";
			this.justGage1.Size = new System.Drawing.Size(188, 181);
			this.justGage1.TabIndex = 0;
			this.justGage1.Text = "CPU%";
			this.justGage1.Symbol = "%";
			this.justGage1.Value = 10F;
			this.justGage1.ValueColor = System.Drawing.Color.Moccasin;
			// 
			// GagePopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(63)))), ((int)(((byte)(154)))), ((int)(((byte)(191)))));
			this.Controls.Add(this.justGage1);
			this.Name = "GagePopup";
			this.Size = new System.Drawing.Size(188, 181);
			this.VisibleChanged += new System.EventHandler(this.GagePopup_VisibleChanged);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.JustGage.JustGage justGage1;
	}
}
