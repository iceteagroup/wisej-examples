namespace TourPanelSample
{
	partial class Window5
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
			this.accordion1 = new Wisej.Web.Accordion();
			this.accordionPanelGreen = new Wisej.Web.AccordionPanel();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.accordionPanelRed = new Wisej.Web.AccordionPanel();
			this.textBoxWatermark = new Wisej.Web.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.accordion1)).BeginInit();
			this.accordion1.SuspendLayout();
			this.accordionPanelGreen.SuspendLayout();
			this.SuspendLayout();
			// 
			// accordion1
			// 
			this.accordion1.Controls.Add(this.accordionPanelGreen);
			this.accordion1.Controls.Add(this.accordionPanelRed);
			this.accordion1.Location = new System.Drawing.Point(14, 12);
			this.accordion1.Name = "accordion1";
			this.accordion1.SelectedIndex = 0;
			this.accordion1.Size = new System.Drawing.Size(801, 229);
			this.accordion1.TabIndex = 0;
			// 
			// accordionPanelGreen
			// 
			this.accordionPanelGreen.BackColor = System.Drawing.Color.Chartreuse;
			this.accordionPanelGreen.Controls.Add(this.checkBox1);
			this.accordionPanelGreen.Location = new System.Drawing.Point(0, 201);
			this.accordionPanelGreen.Name = "accordionPanelGreen";
			this.accordionPanelGreen.RestoreBounds = new System.Drawing.Rectangle(0, 201, 801, 201);
			this.accordionPanelGreen.Size = new System.Drawing.Size(801, 28);
			this.accordionPanelGreen.Text = "green Panel";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(17, 20);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(91, 23);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "checkBox1";
			// 
			// accordionPanelRed
			// 
			this.accordionPanelRed.BackColor = System.Drawing.Color.DarkRed;
			this.accordionPanelRed.Location = new System.Drawing.Point(0, 0);
			this.accordionPanelRed.Name = "accordionPanelRed";
			this.accordionPanelRed.Size = new System.Drawing.Size(801, 201);
			this.accordionPanelRed.Text = "red Panel";
			// 
			// textBoxWatermark
			// 
			this.textBoxWatermark.Location = new System.Drawing.Point(14, 260);
			this.textBoxWatermark.Name = "textBoxWatermark";
			this.textBoxWatermark.Size = new System.Drawing.Size(342, 22);
			this.textBoxWatermark.TabIndex = 1;
			this.textBoxWatermark.Watermark = "Type your text here";
			// 
			// Window5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 325);
			this.CloseBox = false;
			this.Controls.Add(this.textBoxWatermark);
			this.Controls.Add(this.accordion1);
			this.Location = new System.Drawing.Point(100, 100);
			this.Name = "Window5";
			this.Text = "Form5";
			((System.ComponentModel.ISupportInitialize)(this.accordion1)).EndInit();
			this.accordion1.ResumeLayout(false);
			this.accordionPanelGreen.ResumeLayout(false);
			this.accordionPanelGreen.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Accordion accordion1;
		private Wisej.Web.AccordionPanel accordionPanelRed;
		private Wisej.Web.AccordionPanel accordionPanelGreen;
		private Wisej.Web.CheckBox checkBox1;
		public Wisej.Web.TextBox textBoxWatermark;
	}
}

