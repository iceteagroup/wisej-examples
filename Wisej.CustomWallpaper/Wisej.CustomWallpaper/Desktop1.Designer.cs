
namespace Wisej.CustomWallpaper
{
    partial class Desktop1
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
            this.customWallpaper = new Wisej.Web.Ext.CustomWallpaper.CustomWallpaper(this.components);
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.btnFadingInterval = new Wisej.Web.Button();
            this.btnRotationInterval = new Wisej.Web.Button();
            this.nudFadingInterval = new Wisej.Web.NumericUpDown();
            this.nudRotationInterval = new Wisej.Web.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadingInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotationInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // customWallpaper
            // 
            this.customWallpaper.FadeTime = 3300;
            this.customWallpaper.RotationInterval = 3000;
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.checkBox2.Location = new System.Drawing.Point(26, 111);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(277, 26);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Enable / Disable Fading Animation";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnFadingInterval
            // 
            this.btnFadingInterval.AutoSize = true;
            this.btnFadingInterval.Location = new System.Drawing.Point(376, 60);
            this.btnFadingInterval.Name = "btnFadingInterval";
            this.btnFadingInterval.Size = new System.Drawing.Size(170, 27);
            this.btnFadingInterval.TabIndex = 8;
            this.btnFadingInterval.Text = "Apply Fading Interval";
            this.btnFadingInterval.Click += new System.EventHandler(this.btnFadingInterval_Click);
            // 
            // btnRotationInterval
            // 
            this.btnRotationInterval.AutoSize = true;
            this.btnRotationInterval.Location = new System.Drawing.Point(376, 13);
            this.btnRotationInterval.Name = "btnRotationInterval";
            this.btnRotationInterval.Size = new System.Drawing.Size(170, 27);
            this.btnRotationInterval.TabIndex = 9;
            this.btnRotationInterval.Text = "Apply Rotation Interval";
            this.btnRotationInterval.Click += new System.EventHandler(this.btnRotationInterval_Click);
            // 
            // nudFadingInterval
            // 
            this.nudFadingInterval.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFadingInterval.Location = new System.Drawing.Point(26, 62);
            this.nudFadingInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFadingInterval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFadingInterval.Name = "nudFadingInterval";
            this.nudFadingInterval.Size = new System.Drawing.Size(334, 22);
            this.nudFadingInterval.TabIndex = 6;
            this.nudFadingInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudRotationInterval
            // 
            this.nudRotationInterval.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRotationInterval.Location = new System.Drawing.Point(26, 16);
            this.nudRotationInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRotationInterval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRotationInterval.Name = "nudRotationInterval";
            this.nudRotationInterval.Size = new System.Drawing.Size(334, 22);
            this.nudRotationInterval.TabIndex = 7;
            this.nudRotationInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Desktop1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.btnFadingInterval);
            this.Controls.Add(this.btnRotationInterval);
            this.Controls.Add(this.nudFadingInterval);
            this.Controls.Add(this.nudRotationInterval);
            this.Controls.Add(this.checkBox2);
            this.Name = "Desktop1";
            this.Size = new System.Drawing.Size(1814, 710);
            this.Text = "Wisej Sample CustomWallpaper";
            this.Load += new System.EventHandler(this.Desktop1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFadingInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotationInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Ext.CustomWallpaper.CustomWallpaper customWallpaper;
        private Web.CheckBox checkBox2;
        private Web.Button btnFadingInterval;
        private Web.Button btnRotationInterval;
        private Web.NumericUpDown nudFadingInterval;
        private Web.NumericUpDown nudRotationInterval;
    }
}
