
namespace Wisej.Wallpaper
{
    partial class MyDesktop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bingWallpaper = new Wisej.Web.Ext.BingWallpaper.BingWallpaper(this.components);
            this.nudPictureCount = new Wisej.Web.NumericUpDown();
            this.btnPictureCount = new Wisej.Web.Button();
            this.nudRotationInterval = new Wisej.Web.NumericUpDown();
            this.btnRotationInterval = new Wisej.Web.Button();
            this.nudFadingInterval = new Wisej.Web.NumericUpDown();
            this.btnFadingInterval = new Wisej.Web.Button();
            this.checkBox1 = new Wisej.Web.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPictureCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotationInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadingInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // bingWallpaper
            // 
            this.bingWallpaper.Control = this;
            this.bingWallpaper.EnableAnimation = false;
            this.bingWallpaper.RotationInterval = 2000;
            // 
            // nudPictureCount
            // 
            this.nudPictureCount.Location = new System.Drawing.Point(3, 46);
            this.nudPictureCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPictureCount.Name = "nudPictureCount";
            this.nudPictureCount.Size = new System.Drawing.Size(334, 22);
            this.nudPictureCount.TabIndex = 0;
            // 
            // btnPictureCount
            // 
            this.btnPictureCount.AutoSize = true;
            this.btnPictureCount.Location = new System.Drawing.Point(353, 43);
            this.btnPictureCount.Name = "btnPictureCount";
            this.btnPictureCount.Size = new System.Drawing.Size(170, 27);
            this.btnPictureCount.TabIndex = 1;
            this.btnPictureCount.Text = "Apply Picture Count";
            this.btnPictureCount.Click += new System.EventHandler(this.btnPictureCount_Click);
            // 
            // nudRotationInterval
            // 
            this.nudRotationInterval.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRotationInterval.Location = new System.Drawing.Point(3, 89);
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
            this.nudRotationInterval.TabIndex = 0;
            this.nudRotationInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnRotationInterval
            // 
            this.btnRotationInterval.AutoSize = true;
            this.btnRotationInterval.Location = new System.Drawing.Point(353, 86);
            this.btnRotationInterval.Name = "btnRotationInterval";
            this.btnRotationInterval.Size = new System.Drawing.Size(170, 27);
            this.btnRotationInterval.TabIndex = 1;
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
            this.nudFadingInterval.Location = new System.Drawing.Point(3, 135);
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
            this.nudFadingInterval.TabIndex = 0;
            this.nudFadingInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnFadingInterval
            // 
            this.btnFadingInterval.AutoSize = true;
            this.btnFadingInterval.Location = new System.Drawing.Point(353, 133);
            this.btnFadingInterval.Name = "btnFadingInterval";
            this.btnFadingInterval.Size = new System.Drawing.Size(170, 27);
            this.btnFadingInterval.TabIndex = 1;
            this.btnFadingInterval.Text = "Apply Fading Interval";
            this.btnFadingInterval.Click += new System.EventHandler(this.btnFadingInterval_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.checkBox1.Location = new System.Drawing.Point(3, 178);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(277, 26);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Enable / Disable Fading Animation";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MyDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnFadingInterval);
            this.Controls.Add(this.btnRotationInterval);
            this.Controls.Add(this.btnPictureCount);
            this.Controls.Add(this.nudFadingInterval);
            this.Controls.Add(this.nudRotationInterval);
            this.Controls.Add(this.nudPictureCount);
            this.Name = "MyDesktop";
            this.Size = new System.Drawing.Size(1312, 904);
            this.Text = "Wisej BingWallpaper Sample";
            ((System.ComponentModel.ISupportInitialize)(this.nudPictureCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotationInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadingInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Ext.BingWallpaper.BingWallpaper bingWallpaper;
        private Web.Button btnFadingInterval;
        private Web.Button btnRotationInterval;
        private Web.Button btnPictureCount;
        private Web.NumericUpDown nudFadingInterval;
        private Web.NumericUpDown nudRotationInterval;
        private Web.NumericUpDown nudPictureCount;
        private Web.CheckBox checkBox1;
    }
}
