using Wisej.Web;

namespace Wisej.Responsive.Views
{
	partial class LoginPage
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
			this.label1 = new Wisej.Web.Label();
			this.animation = new Wisej.Web.Animation(this.components);
			this.textBoxUserName = new Wisej.Web.TextBox();
			this.textBoxPassword = new Wisej.Web.TextBox();
			this.buttonLogin = new Wisej.Web.Button();
			this.helpTip = new Wisej.Web.HelpTip(this.components);
			this.errorProvider = new Wisej.Web.ErrorProvider(this.components);
			this.panel = new Wisej.Web.Panel();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.animation.GetAnimation(this.label1).Event = "appear";
			this.animation.GetAnimation(this.label1).Name = "bounce";
			this.label1.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.ImageSource = "Images/Wisej-Logo-64x64.png";
			this.label1.Location = new System.Drawing.Point(20, 4);
			this.label1.Margin = new Wisej.Web.Padding(4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(380, 200);
			this.label1.TabIndex = 0;
			this.label1.Text = "ACME Hardware";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxUserName.AutoComplete = Wisej.Web.AutoComplete.Off;
			this.textBoxUserName.AutoSize = false;
			this.helpTip.SetHelpTip(this.textBoxUserName, "User your name or email address.");
			this.errorProvider.SetIconAlignment(this.textBoxUserName, Wisej.Web.ErrorIconAlignment.MiddleLeft);
			this.textBoxUserName.Location = new System.Drawing.Point(35, 212);
			this.textBoxUserName.Margin = new Wisej.Web.Padding(4);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(350, 48);
			this.textBoxUserName.TabIndex = 1;
			this.textBoxUserName.Watermark = "User Name";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxPassword.AutoComplete = Wisej.Web.AutoComplete.Off;
			this.textBoxPassword.AutoSize = false;
			this.helpTip.SetHelpTip(this.textBoxPassword, "Enter \"demo\"");
			this.errorProvider.SetIconAlignment(this.textBoxPassword, Wisej.Web.ErrorIconAlignment.MiddleLeft);
			this.textBoxPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
			this.textBoxPassword.Location = new System.Drawing.Point(35, 289);
			this.textBoxPassword.Margin = new Wisej.Web.Padding(4);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(350, 48);
			this.textBoxPassword.TabIndex = 2;
			this.textBoxPassword.Watermark = "Password";
			// 
			// buttonLogin
			// 
			this.buttonLogin.Anchor = Wisej.Web.AnchorStyles.Bottom;
			this.buttonLogin.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/locked-padlock.svg";
			this.buttonLogin.Location = new System.Drawing.Point(128, 381);
			this.buttonLogin.Margin = new Wisej.Web.Padding(4);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(175, 62);
			this.buttonLogin.TabIndex = 3;
			this.buttonLogin.Text = "&LOGIN";
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.BlinkAnimation = Wisej.Web.ErrorAnimationType.Bounce;
			this.errorProvider.ContainerControl = this;
			this.errorProvider.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/round-error-symbol.svg";
			// 
			// panel
			// 
			this.panel.Anchor = Wisej.Web.AnchorStyles.None;
			this.panel.BackColor = System.Drawing.Color.Transparent;
			this.panel.Controls.Add(this.buttonLogin);
			this.panel.Controls.Add(this.textBoxPassword);
			this.panel.Controls.Add(this.textBoxUserName);
			this.panel.Controls.Add(this.label1);
			this.panel.Location = new System.Drawing.Point(359, 141);
			this.panel.Margin = new Wisej.Web.Padding(4);
			this.panel.MaximumSize = new System.Drawing.Size(420, 460);
			this.panel.MinimumSize = new System.Drawing.Size(320, 320);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(420, 460);
			this.panel.TabIndex = 4;
			// 
			// LoginPage
			// 
			this.Accelerators = new Wisej.Web.Keys[] {
        Wisej.Web.Keys.Return};
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.BackgroundImageLayout = Wisej.Web.ImageLayout.BestFit;
			this.BackgroundImageSource = "Images/Background.jpg";
			this.Controls.Add(this.panel);
			this.Font = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new Wisej.Web.Padding(4);
			this.Name = "LoginPage";
			this.Size = new System.Drawing.Size(1139, 742);
			this.Text = "ACME Hardware - Login";
			this.Load += new System.EventHandler(this.LoginPage_Load);
			this.ResponsiveProfileChanged += new ResponsiveProfileChangedEventHandler(this.LoginPage_ResponsiveProfileChanged);
			this.Accelerator += new Wisej.Web.AcceleratorEventHandler(this.LoginPage_Accelerator);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Label label1;
		private Web.Animation animation;
		private Web.TextBox textBoxUserName;
		private Web.TextBox textBoxPassword;
		private Web.Button buttonLogin;
		private Web.HelpTip helpTip;
		private Web.ErrorProvider errorProvider;
		private Web.Panel panel;
	}
}
