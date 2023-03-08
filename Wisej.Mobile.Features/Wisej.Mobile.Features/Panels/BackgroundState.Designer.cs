namespace Wisej.Mobile.Features.Panels
{
    partial class BackgroundState
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
            this.textBoxBackColor = new Wisej.Web.TextBox();
            this.spacer1 = new Wisej.Web.Spacer();
            this.pictureBoxImage = new Wisej.Web.PictureBox();
            this.uploadImage = new Wisej.Web.Upload();
            this.spacer2 = new Wisej.Web.Spacer();
            this.comboBoxImageSizeMode = new Wisej.Web.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBackColor
            // 
            this.textBoxBackColor.Dock = Wisej.Web.DockStyle.Top;
            this.textBoxBackColor.InputType.Type = Wisej.Web.TextBoxType.Color;
            this.textBoxBackColor.LabelText = "Background Color";
            this.textBoxBackColor.Location = new System.Drawing.Point(16, 128);
            this.textBoxBackColor.Name = "textBoxBackColor";
            this.textBoxBackColor.Size = new System.Drawing.Size(618, 55);
            this.textBoxBackColor.TabIndex = 19;
            this.textBoxBackColor.Text = "#FFFFFF";
            this.textBoxBackColor.TextChanged += new System.EventHandler(this.textBoxBackColor_TextChanged);
            // 
            // spacer1
            // 
            this.spacer1.Dock = Wisej.Web.DockStyle.Top;
            this.spacer1.Location = new System.Drawing.Point(16, 183);
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(618, 20);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Dock = Wisej.Web.DockStyle.Top;
            this.pictureBoxImage.ImageSource = "Images\\wisej.png";
            this.pictureBoxImage.Location = new System.Drawing.Point(16, 203);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(618, 100);
            this.pictureBoxImage.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // uploadImage
            // 
            this.uploadImage.AllowedFileTypes = "image/*";
            this.uploadImage.Dock = Wisej.Web.DockStyle.Top;
            this.uploadImage.Location = new System.Drawing.Point(16, 303);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(618, 30);
            this.uploadImage.TabIndex = 23;
            this.uploadImage.Text = "Upload Image";
            this.uploadImage.Uploaded += new Wisej.Web.UploadedEventHandler(this.uploadImage_Uploaded);
            // 
            // spacer2
            // 
            this.spacer2.Dock = Wisej.Web.DockStyle.Top;
            this.spacer2.Location = new System.Drawing.Point(16, 333);
            this.spacer2.Name = "spacer2";
            this.spacer2.Size = new System.Drawing.Size(618, 20);
            // 
            // comboBoxImageSizeMode
            // 
            this.comboBoxImageSizeMode.Dock = Wisej.Web.DockStyle.Top;
            this.comboBoxImageSizeMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxImageSizeMode.LabelText = "Image Mode";
            this.comboBoxImageSizeMode.Location = new System.Drawing.Point(16, 353);
            this.comboBoxImageSizeMode.Name = "comboBoxImageSizeMode";
            this.comboBoxImageSizeMode.Size = new System.Drawing.Size(618, 55);
            this.comboBoxImageSizeMode.TabIndex = 26;
            this.comboBoxImageSizeMode.Text = "Center";
            this.comboBoxImageSizeMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxImageSizeMode_SelectedIndexChanged);
            // 
            // BackgroundState
            // 
            this.animation1.GetAnimation(this).Duration = 350;
            this.animation1.GetAnimation(this).Event = "appear";
            this.animation1.GetAnimation(this).Name = "slideRightIn";
            this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.animation2.GetAnimation(this).Duration = 350;
            this.animation2.GetAnimation(this).Event = "disappear";
            this.animation2.GetAnimation(this).Name = "slideRightOut";
            this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.Controls.Add(this.comboBoxImageSizeMode);
            this.Controls.Add(this.spacer2);
            this.Controls.Add(this.uploadImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.spacer1);
            this.Controls.Add(this.textBoxBackColor);
            this.Name = "BackgroundState";
            this.Load += new System.EventHandler(this.BackgroundState_Load);
            this.Disposed += new System.EventHandler(this.BackgroundState_Disposed);
            this.Controls.SetChildIndex(this.textBoxBackColor, 0);
            this.Controls.SetChildIndex(this.spacer1, 0);
            this.Controls.SetChildIndex(this.pictureBoxImage, 0);
            this.Controls.SetChildIndex(this.uploadImage, 0);
            this.Controls.SetChildIndex(this.spacer2, 0);
            this.Controls.SetChildIndex(this.comboBoxImageSizeMode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.TextBox textBoxBackColor;
        private Web.Spacer spacer1;
        private Web.PictureBox pictureBoxImage;
        private Web.Upload uploadImage;
        private Web.Spacer spacer2;
        private Web.ComboBox comboBoxImageSizeMode;
    }
}
