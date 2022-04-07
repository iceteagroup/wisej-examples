namespace Wisej.CodeProject.Examples
{
	partial class MandelbrotPanel
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
			this.SuspendLayout();
			// 
			// MandelbrotPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Name = "MandelbrotPanel";
			this.Size = new System.Drawing.Size(355, 288);
			this.Paint += new Wisej.Web.PaintEventHandler(this.MandelbrotPanel_Paint);
			this.ResumeLayout(false);

		}

		#endregion
	}
}
