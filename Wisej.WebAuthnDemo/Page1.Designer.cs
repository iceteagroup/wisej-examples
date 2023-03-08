namespace Wisej.WebAuthnDemo
{
	partial class Page1
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
			Wisej.Web.ComponentTool componentTool3 = new Wisej.Web.ComponentTool();
			this.textBoxUserName = new Wisej.Web.TextBox();
			this.textBoxPassword = new Wisej.Web.TextBox();
			this.helpTip = new Wisej.Web.HelpTip(this.components);
			this.buttonRegister = new Wisej.Web.Button();
			this.buttonWebAuth = new Wisej.Web.Button();
			this.checkBoxRememberMe = new Wisej.Web.CheckBox();
			this.panel1 = new Wisej.Web.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxUserName
			// 
			this.textBoxUserName.InvalidMessage = "Required.";
			this.textBoxUserName.LabelText = "User name";
			this.textBoxUserName.Location = new System.Drawing.Point(33, 23);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new System.Drawing.Size(274, 53);
			this.textBoxUserName.TabIndex = 0;
			this.textBoxUserName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUserName_Validating);
			// 
			// textBoxPassword
			// 
			this.helpTip.SetHelpTip(this.textBoxPassword, "Use \"password\".");
			this.textBoxPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
			this.textBoxPassword.LabelText = "Password";
			this.textBoxPassword.Location = new System.Drawing.Point(33, 96);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(274, 53);
			this.textBoxPassword.TabIndex = 1;
			componentTool3.ImageSource = "Images\\show-password.png";
			componentTool3.Name = "ShowPassword";
			this.textBoxPassword.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool3});
			this.textBoxPassword.ToolClick += new Wisej.Web.ToolClickEventHandler(this.textBoxPassword_ToolClick);
			this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
			// 
			// buttonRegister
			// 
			this.buttonRegister.Location = new System.Drawing.Point(33, 212);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Size = new System.Drawing.Size(274, 42);
			this.buttonRegister.TabIndex = 3;
			this.buttonRegister.Text = "Register";
			this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
			// 
			// buttonWebAuth
			// 
			this.buttonWebAuth.Display = Wisej.Web.Display.Icon;
			this.buttonWebAuth.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonWebAuth.ImageSource = "Images\\webauthn-color.png";
			this.buttonWebAuth.Location = new System.Drawing.Point(33, 274);
			this.buttonWebAuth.Name = "buttonWebAuth";
			this.buttonWebAuth.Size = new System.Drawing.Size(274, 42);
			this.buttonWebAuth.TabIndex = 4;
			this.buttonWebAuth.Text = "Login";
			this.buttonWebAuth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonWebAuth.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
			this.buttonWebAuth.Click += new System.EventHandler(this.buttonWebAuthn_Click);
			// 
			// checkBoxRememberMe
			// 
			this.checkBoxRememberMe.Location = new System.Drawing.Point(33, 169);
			this.checkBoxRememberMe.Name = "checkBoxRememberMe";
			this.checkBoxRememberMe.Size = new System.Drawing.Size(115, 23);
			this.checkBoxRememberMe.TabIndex = 2;
			this.checkBoxRememberMe.Text = "Remember Me";
			// 
			// panel1
			// 
			this.panel1.Anchor = Wisej.Web.AnchorStyles.None;
			this.panel1.Controls.Add(this.checkBoxRememberMe);
			this.panel1.Controls.Add(this.buttonWebAuth);
			this.panel1.Controls.Add(this.buttonRegister);
			this.panel1.Controls.Add(this.textBoxPassword);
			this.panel1.Controls.Add(this.textBoxUserName);
			this.panel1.Location = new System.Drawing.Point(351, 196);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(339, 353);
			this.panel1.TabIndex = 5;
			// 
			// Page1
			// 
			this.AcceptButton = this.buttonRegister;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.AutoValidate = Wisej.Web.AutoValidate.EnableAllowFocusChange;
			this.Controls.Add(this.panel1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1040, 745);
			this.Load += new System.EventHandler(this.Page1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.TextBox textBoxUserName;
		private Web.TextBox textBoxPassword;
		private Web.HelpTip helpTip;
		private Web.Button buttonRegister;
		private Web.Button buttonWebAuth;
		private Web.CheckBox checkBoxRememberMe;
		private Web.Panel panel1;
	}
}

