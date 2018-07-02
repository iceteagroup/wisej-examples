namespace PageNavigation
{
    partial class Login
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
            this.usernameLabel = new Wisej.Web.Label();
            this.username = new Wisej.Web.TextBox();
            this.passwordLabel = new Wisej.Web.Label();
            this.password = new Wisej.Web.TextBox();
            this.loginButton = new Wisej.Web.Button();
            this.credentialsError = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameLabel.Location = new System.Drawing.Point(150, 105);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(105, 25);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.username.Location = new System.Drawing.Point(349, 105);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(150, 25);
            this.username.TabIndex = 1;
            this.username.Watermark = "username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordLabel.Location = new System.Drawing.Point(150, 167);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(101, 25);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.password.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.password.Location = new System.Drawing.Point(349, 167);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(150, 25);
            this.password.TabIndex = 3;
            this.password.Watermark = "password";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginButton.Location = new System.Drawing.Point(150, 280);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(200, 40);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // credentialsError
            // 
            this.credentialsError.AutoSize = true;
            this.credentialsError.ForeColor = System.Drawing.Color.FromName("@invalid");
            this.credentialsError.Location = new System.Drawing.Point(150, 214);
            this.credentialsError.Name = "credentialsError";
            this.credentialsError.Size = new System.Drawing.Size(187, 16);
            this.credentialsError.TabIndex = 5;
            this.credentialsError.Text = "Wrong username or password";
            this.credentialsError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username and password must be equal.";
            // 
            // Login
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.credentialsError);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.username);
            this.Controls.Add(this.usernameLabel);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(938, 804);
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label usernameLabel;
        private Wisej.Web.Label passwordLabel;
        private Wisej.Web.TextBox password;
        private Wisej.Web.Button loginButton;
        internal Wisej.Web.TextBox username;
        private Wisej.Web.Label credentialsError;
        private Wisej.Web.Label label1;
    }
}

