
namespace Wisej.JSWidgets.Views
{
    partial class frmCoolClock
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
            this.coolClock1 = new Wisej.Web.Ext.CoolClock.CoolClock();
            this.cbClockSkin = new Wisej.Web.ComboBox();
            this.cbClockType = new Wisej.Web.ComboBox();
            this.SuspendLayout();
            // 
            // coolClock1
            // 
            this.coolClock1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.coolClock1.BorderStyle = Wisej.Web.BorderStyle.Double;
            this.coolClock1.Location = new System.Drawing.Point(228, 63);
            this.coolClock1.Name = "coolClock1";
            this.coolClock1.Size = new System.Drawing.Size(257, 241);
            this.coolClock1.Skin = Wisej.Web.Ext.CoolClock.CoolClockSkin.SwissRail;
            this.coolClock1.Text = "coolClock1";
            // 
            // cbClockSkin
            // 
            this.cbClockSkin.LabelText = "Clock Skin";
            this.cbClockSkin.Location = new System.Drawing.Point(30, 63);
            this.cbClockSkin.Name = "cbClockSkin";
            this.cbClockSkin.Size = new System.Drawing.Size(174, 42);
            this.cbClockSkin.TabIndex = 1;
            this.cbClockSkin.SelectedIndexChanged += new System.EventHandler(this.cbClockSkin_SelectedIndexChanged);
            // 
            // cbClockType
            // 
            this.cbClockType.LabelText = "Clock Type";
            this.cbClockType.Location = new System.Drawing.Point(30, 133);
            this.cbClockType.Name = "cbClockType";
            this.cbClockType.Size = new System.Drawing.Size(174, 42);
            this.cbClockType.TabIndex = 2;
            this.cbClockType.SelectedIndexChanged += new System.EventHandler(this.cbClockType_SelectedIndexChanged);
            // 
            // frmCoolClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 471);
            this.Controls.Add(this.cbClockType);
            this.Controls.Add(this.cbClockSkin);
            this.Controls.Add(this.coolClock1);
            this.Name = "frmCoolClock";
            this.Text = "frmCoolClock";
            this.Load += new System.EventHandler(this.frmCoolClock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Ext.CoolClock.CoolClock coolClock1;
        private Web.ComboBox cbClockSkin;
        private Web.ComboBox cbClockType;
    }
}