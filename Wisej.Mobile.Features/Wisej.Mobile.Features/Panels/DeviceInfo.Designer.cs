namespace Wisej.Mobile.Features.Panels
{
	partial class DeviceInfo
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
			this.propertyGridInfo = new Wisej.Web.PropertyGrid();
			this.SuspendLayout();
			// 
			// propertyGridInfo
			// 
			this.propertyGridInfo.Dock = Wisej.Web.DockStyle.Fill;
			this.propertyGridInfo.Enabled = false;
			this.propertyGridInfo.HelpVisible = false;
			this.propertyGridInfo.Location = new System.Drawing.Point(16, 128);
			this.propertyGridInfo.Name = "propertyGridInfo";
			this.propertyGridInfo.PropertySort = Wisej.Web.PropertySort.Alphabetical;
			this.propertyGridInfo.Size = new System.Drawing.Size(618, 350);
			this.propertyGridInfo.TabIndex = 0;
			// 
			// 
			// 
			this.propertyGridInfo.ToolBar.Enabled = true;
			// 
			// DeviceInfo
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.propertyGridInfo);
			this.Name = "DeviceInfo";
			this.Load += new System.EventHandler(this.DeviceInfo_Load);
			this.Disposed += new System.EventHandler(this.DeviceInfo_Disposed);
			this.Controls.SetChildIndex(this.propertyGridInfo, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.PropertyGrid propertyGridInfo;
	}
}
