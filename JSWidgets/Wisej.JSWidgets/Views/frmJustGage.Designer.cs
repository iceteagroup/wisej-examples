
namespace Wisej.JSWidgets.Views
{
    partial class frmJustGage
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
            this.justGageTest = new Wisej.Web.Ext.JustGage.JustGage();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.numericUpDown2 = new Wisej.Web.NumericUpDown();
            this.trackBarGageChange = new Wisej.Web.TrackBar();
            this.chkDonut = new Wisej.Web.CheckBox();
            this.chkHumanFriendly = new Wisej.Web.CheckBox();
            this.cbAnimationType = new Wisej.Web.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGageChange)).BeginInit();
            this.SuspendLayout();
            // 
            // justGageTest
            // 
            this.justGageTest.Location = new System.Drawing.Point(127, 3);
            this.justGageTest.Maximum = 1001;
            this.justGageTest.Name = "justGageTest";
            this.justGageTest.Size = new System.Drawing.Size(365, 241);
            this.justGageTest.TabIndex = 0;
            this.justGageTest.Text = "justGage Test";
            this.justGageTest.Value = 12F;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.LabelText = "Minimun";
            this.numericUpDown1.Location = new System.Drawing.Point(127, 271);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 42);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.LabelText = "Maximun";
            this.numericUpDown2.Location = new System.Drawing.Point(310, 271);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 42);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // trackBarGageChange
            // 
            this.trackBarGageChange.Location = new System.Drawing.Point(127, 473);
            this.trackBarGageChange.Name = "trackBarGageChange";
            this.trackBarGageChange.Size = new System.Drawing.Size(365, 34);
            this.trackBarGageChange.TabIndex = 3;
            this.trackBarGageChange.ValueChanged += new System.EventHandler(this.trackBarGageChange_ValueChanged);
            // 
            // chkDonut
            // 
            this.chkDonut.Location = new System.Drawing.Point(127, 345);
            this.chkDonut.Name = "chkDonut";
            this.chkDonut.Size = new System.Drawing.Size(67, 22);
            this.chkDonut.TabIndex = 4;
            this.chkDonut.Text = "Donut";
            this.chkDonut.CheckedChanged += new System.EventHandler(this.chkDonut_CheckedChanged);
            // 
            // chkHumanFriendly
            // 
            this.chkHumanFriendly.Location = new System.Drawing.Point(310, 345);
            this.chkHumanFriendly.Name = "chkHumanFriendly";
            this.chkHumanFriendly.Size = new System.Drawing.Size(124, 22);
            this.chkHumanFriendly.TabIndex = 6;
            this.chkHumanFriendly.Text = "Human Friendly";
            this.chkHumanFriendly.CheckedChanged += new System.EventHandler(this.chkHumanFriendly_CheckedChanged);
            // 
            // cbAnimationType
            // 
            this.cbAnimationType.LabelText = "Animation Type";
            this.cbAnimationType.Location = new System.Drawing.Point(127, 392);
            this.cbAnimationType.Name = "cbAnimationType";
            this.cbAnimationType.Size = new System.Drawing.Size(156, 42);
            this.cbAnimationType.TabIndex = 7;
            this.cbAnimationType.SelectedIndexChanged += new System.EventHandler(this.cbAnimationType_SelectedIndexChanged);
            // 
            // frmJustGaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 546);
            this.Controls.Add(this.cbAnimationType);
            this.Controls.Add(this.chkHumanFriendly);
            this.Controls.Add(this.chkDonut);
            this.Controls.Add(this.trackBarGageChange);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.justGageTest);
            this.Name = "frmJustGaje";
            this.Text = "frmJustGaje";
            this.Load += new System.EventHandler(this.frmJustGage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGageChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Ext.JustGage.JustGage justGageTest;
        private Web.NumericUpDown numericUpDown1;
        private Web.NumericUpDown numericUpDown2;
        private Web.TrackBar trackBarGageChange;
        private Web.CheckBox chkDonut;
        private Web.CheckBox chkHumanFriendly;
        private Web.ComboBox cbAnimationType;
    }
}