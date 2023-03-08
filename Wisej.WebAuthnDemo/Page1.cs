using System;
using System.CodeDom;
using Wisej.Ext.WebAuthn;
using Wisej.Services;
using Wisej.Web;

namespace Wisej.WebAuthnDemo
{
	public partial class Page1 : Page
	{
		private const string COOKIE_USERNAME = "WebAuthn.UserName";

		public Page1()
		{
			InitializeComponent();
		}

		[Inject]
		private UserStorageService UserStorageService{ get; set; }

		private void Page1_Load(object sender, System.EventArgs e)
		{
			ReloadUserName();

			CheckWebAuthnIsAvailable();
		}

		private async void CheckWebAuthnIsAvailable()
		{
			var canAuthenticate = await WebAuthn.IsUserVerifyingPlatformAuthenticatorAvailableAsync();
			if (!canAuthenticate)
			{
				MessageBox.Show("No Platform Detector Found");
				this.buttonRegister.Enabled = false;
				this.buttonWebAuth.Enabled = false;
				return;
			}
		}

		private void ReloadUserName()
		{
			this.textBoxUserName.Text = Application.Cookies[COOKIE_USERNAME];

			if (this.textBoxPassword.Text != "")
				this.AcceptButton = this.buttonWebAuth;
		}

		private void buttonRegister_Click(object sender, System.EventArgs e)
		{
			SaveOrRemoveUserName();
			
			if (ValidatePassword())
			{
				RegisterWebAuthn();
			}
		}

		private async void RegisterWebAuthn()
		{
			var userName = this.textBoxUserName.Text;

			string challenge = Guid.NewGuid().ToString();

			var relyingParty = new RelyingParty(Application.StartupUri.Host, "My Wisej.NET Application");

			var userCredentials = new PublicKeyCredentialUserEntity
			{
				Id = userName,
				Name = userName,
				DisplayName = userName
			};

			var attestation = AttestationConveyancePreference.None;

			var authenticatorSelection = new AuthenticatorSelectionCriteria(AuthenticatorAttachment.Platform);

			var publicKeyCredentialParameters = new PublicKeyCredentialParameters[]
			{
				new PublicKeyCredentialParameters(COSEAlgorithmIdentifier.RS256),
				new PublicKeyCredentialParameters(COSEAlgorithmIdentifier.ES256)
			};

			this.ShowLoader = true;

			try
			{
				var registration = await WebAuthn.CreateAsync(
					challenge,
					relyingParty,
					userCredentials,
					publicKeyCredentialParameters,
					authenticatorSelection,
					-1,
					attestation);

				this.ShowLoader = false;
				UserStorageService.RegisterUserPublicKey(userName, registration.AuthenticatorData.PublicKey.ToJSON());
				AlertBox.Show($"User {userName} registered successfully!", icon: MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				this.ShowLoader = false;
				AlertBox.Show(ex.Message, icon: MessageBoxIcon.Error);
			}
		}

		private bool ValidatePassword()
		{
			return this.textBoxPassword.Text == "password";
		}

		private void SaveOrRemoveUserName()
		{
			if (this.checkBoxRememberMe.Checked)
				Application.Cookies[COOKIE_USERNAME] = this.textBoxUserName.Text;
			else
				Application.Cookies.Remove(COOKIE_USERNAME);
		}

		private async void buttonWebAuthn_Click(object sender, System.EventArgs e)
		{
			var userName = this.textBoxUserName.Text;

			string challenge = Guid.NewGuid().ToString();

			var publicKey = UserStorageService.GetUserPublicKey(userName);

			if (publicKey == null)
			{
				AlertBox.Show("Unknown user.", icon: MessageBoxIcon.Error);
				return;
			}

			var credential = new PublicKeyCredentialDescriptor
			{
				Id = publicKey.CredentialID,
				Transports = new AuthenticatorTransport[] { AuthenticatorTransport.Internal }
			};

			try
			{
				var response = await WebAuthn.GetAsync(challenge, credential, -1);

				if (WebAuthn.Validate(publicKey, response.AuthenticatorData.Base64, response.ClientData.Base64, response.Signature))
					AlertBox.Show($"User {response.UserHandle} authenticated.", icon: MessageBoxIcon.Information);
				else
					AlertBox.Show("Invalid user!", icon: MessageBoxIcon.Stop);
			}
			catch (Exception ex)
			{
				AlertBox.Show(ex.Message, icon: MessageBoxIcon.Error);
			}
		}

		private void textBoxPassword_ToolClick(object sender, ToolClickEventArgs e)
		{
			if (e.Tool.Name == "ShowPassword")
			{
				if (this.textBoxPassword.InputType.Type == TextBoxType.Text)
					this.textBoxPassword.InputType.Type = TextBoxType.Password;
				else
					this.textBoxPassword.InputType.Type = TextBoxType.Text;
			}
		}

		private void textBoxUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = this.textBoxUserName.Text == "";
		}

		private void textBoxPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (this.textBoxPassword.Text == "")
			{
				e.Cancel = true;
				this.textBoxPassword.InvalidMessage = "Required.";
			}
			else if (!ValidatePassword())
			{
				e.Cancel = true;
				this.textBoxPassword.InvalidMessage = "Invalid password.";
			}
		}
	}
}
