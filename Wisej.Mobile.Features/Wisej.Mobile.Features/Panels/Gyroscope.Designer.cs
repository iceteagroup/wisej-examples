﻿namespace Wisej.Mobile.Features.Panels
{
	partial class Gyroscope
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
			this.labelX = new Wisej.Web.Label();
			this.labelY = new Wisej.Web.Label();
			this.labelZ = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// labelX
			// 
			this.labelX.Anchor = Wisej.Web.AnchorStyles.None;
			this.labelX.Location = new System.Drawing.Point(171, 185);
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size(308, 15);
			this.labelX.TabIndex = 0;
			this.labelX.Text = "X";
			this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelY
			// 
			this.labelY.Anchor = Wisej.Web.AnchorStyles.None;
			this.labelY.Location = new System.Drawing.Point(171, 232);
			this.labelY.Name = "labelY";
			this.labelY.Size = new System.Drawing.Size(308, 15);
			this.labelY.TabIndex = 1;
			this.labelY.Text = "Y";
			this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelZ
			// 
			this.labelZ.Anchor = Wisej.Web.AnchorStyles.None;
			this.labelZ.Location = new System.Drawing.Point(171, 279);
			this.labelZ.Name = "labelZ";
			this.labelZ.Size = new System.Drawing.Size(308, 15);
			this.labelZ.TabIndex = 2;
			this.labelZ.Text = "Z";
			this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Gyroscope
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.labelZ);
			this.Controls.Add(this.labelY);
			this.Controls.Add(this.labelX);
			this.Name = "Gyroscope";
			this.Load += new System.EventHandler(this.Gyroscope_Load);
			this.Disposed += new System.EventHandler(this.Gyroscope_Disposed);
			this.Appear += new System.EventHandler(this.Gyroscope_Appear);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Label labelX;
		private Web.Label labelY;
		private Web.Label labelZ;
	}
}
