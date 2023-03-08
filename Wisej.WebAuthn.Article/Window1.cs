
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Wisej.Ext.WebAuthn;
using Wisej.Web;

namespace Wisej.WebAuthn.Article
{
	public partial class Window1 : Form
	{
		/// <summary>
		/// Random challenge for uniquely identifying the registration / authentication requests.
		/// </summary>
		private byte[] challenge = Encoding.UTF8.GetBytes(Guid.NewGuid().ToString());

		/// <summary>
		/// The identifier of the relying party, usually the domain.
		/// </summary>
		private readonly string relyingPartyId = Application.StartupUri.Host;

		public Window1()
		{
			InitializeComponent();
		}

		private async void buttonRegister_Click(object sender, EventArgs e)
		{
			// checks whether a platform authenticator is available for use on the device.
			var canAuthenticate = await Ext.WebAuthn.WebAuthn.IsUserVerifyingPlatformAuthenticatorAvailableAsync();
			if (!canAuthenticate)
			{
				MessageBox.Show("No Platform Detector Found");
				return;
			}

			// asks for a username from the client.
			var username = await Application.PromptAsync("Enter Username", "JohnDoe1");
            var displayName = await Application.PromptAsync("Enter Display Name", "John Doe");
            var user = new PublicKeyCredentialUserEntity
            {
                Id = "1",
                Name = username,
                DisplayName = displayName
            };

            // specifies the organization requesting the authentication information.
            var relyingParty = new RelyingParty(this.relyingPartyId, "My Wisej.NET Application");
			
			// specify the accepted key types.
			var publicKeyCredentials = new PublicKeyCredentialParameters[]
			{
				new PublicKeyCredentialParameters(COSEAlgorithmIdentifier.RS256),
				new PublicKeyCredentialParameters(COSEAlgorithmIdentifier.ES256)
			};

			// specify whether the authenticator can be at the OS-level or needs to be externally attached.
			var authenticatorCriteria = new AuthenticatorSelectionCriteria(AuthenticatorAttachment.Platform);

			// specify whether the server's attestation preference during credential generation.
			var attestation = AttestationConveyancePreference.None;

			var credentials = await Ext.WebAuthn.WebAuthn.CreateAsync(
			challenge: Convert.ToBase64String(this.challenge),
			rp: relyingParty,
			user: user,
			publicKeyCredentialParameters: publicKeyCredentials,
			authenticatorSelection: authenticatorCriteria,
			timeout: 60000,
			attestation: attestation);

            ValidateRegistration(credentials);
		}

		private void ValidateRegistration(CredentialsResponse credentials)
        {
			// basic registration validation starting with #7.
			// see: https://www.w3.org/TR/webauthn-2/#sctn-registering-a-new-credential.

			var clientData = credentials.ClientData;

			// 1. check that the action is a registration.
			if (clientData.Type != "webauthn.create")
				throw new Exception("Incorrect client data type");

			// 2. ensure that the challenge is the same.
			byte[] registrationChallenge = clientData.Challenge;
			if (!this.challenge.SequenceEqual(registrationChallenge))
				throw new Exception("Incorrect challenge.");

			// 3. check that the origin matches.
			if (clientData.Origin != GetOrigin())
				throw new Exception("Incorrect origin");

			// 4. Check that the provided credentialId is not already in use.
			var credentialId = credentials.AuthenticatorData.PublicKey.CredentialID;
			// ... check  against stored values in db.

			// 5. Save the generated public key and credential id with the user in the database.
			// for this demo, we'll save it in the Application Session Storage:
            Application.Session["myPublicKey"] = credentials.AuthenticatorData.PublicKey.ToJSON(false);

			// 6. Show an AlertBox for successful registration.
			AlertBox.Show($"Registration Successful!");
			this.buttonGet.Enabled = true;
		}

		private string GetOrigin()
        {
			string origin = $"{Application.StartupUri.Scheme}://{Application.StartupUri.Host}";
			var host = Application.StartupUri.Host;

			// localhost requires the port.
			if (host == "localhost")
				origin = origin += $":{Application.StartupUri.Port}";

			return origin;
		}

        private async void buttonGet_Click(object sender, EventArgs e)
        {
			// retrieve public key data stored in DB.
			// in this case it's stored in Application.Session["myPublicKey"].
			var myPublicKeyJSON = Application.Session["myPublicKey"];
			
			// restore to an instance of WebAuthn.PublicKey.
			var publicKey = new PublicKey(myPublicKeyJSON);

			// use the credential identifier we created earlier to 
			// let the authenticator know which key should be used for signing.
			var allowCredentials = new PublicKeyCredentialDescriptor
			{
				Id = publicKey.CredentialID,
				Transports = new AuthenticatorTransport[]
				{
					AuthenticatorTransport.Internal
				}
			};

			var credentials = await Ext.WebAuthn.WebAuthn.GetAsync(
				challenge: Convert.ToBase64String(this.challenge),
				allowCredentials: allowCredentials,
				timeout: 60000);

			ValidateSignature(credentials, publicKey);
        }

		private void ValidateSignature(CredentialsResponse response, PublicKey publicKey)
        {
			// perform basic signature validation starting with step #11.
			// see https://www.w3.org/TR/webauthn-2/#sctn-verifying-assertion.

			var clientData = response.ClientData;
			var authenticatorData = response.AuthenticatorData;

			// 1. check that the action is a credential get request.
			if (clientData.Type != "webauthn.get")
				throw new Exception("Incorrect client data type");

			// 2. ensure that the challenge is the same.
			byte[] registrationChallenge = clientData.Challenge;
			if (!this.challenge.SequenceEqual(registrationChallenge))
				throw new Exception("Incorrect challenge.");

			// 3. check that the origin matches.
			if (clientData.Origin != GetOrigin())
				throw new Exception("Incorrect origin");

			// 4. verify the relying party identifier is the same.
			var hasher = SHA256.Create();

			byte[] savedRpIdHashBytes = Encoding.UTF8.GetBytes(this.relyingPartyId);
			var computedRpIdHash = hasher.ComputeHash(savedRpIdHashBytes);

			var rpIdHash = authenticatorData.RPIDHash;
			if (!rpIdHash.SequenceEqual(computedRpIdHash))
				throw new Exception("Incorrect RP ID");

			// 5. verify the user is present.
			var userPresent = authenticatorData.UserPresent;
			if (!userPresent)
				throw new Exception("User not present");

			// 6. finally, validate the signature.
			var authBase64 = response.AuthenticatorData.Base64;
			var clientBase64 = response.ClientData.Base64;
			var signature = response.Signature;

			var isValidated = Ext.WebAuthn.WebAuthn.Validate(
				publicKey: publicKey,
				authenticatorDataBase64: authBase64,
				clientDataBase64: clientBase64,
				signature: signature);

			// show successful or failure of signature validation.
			AlertBox.Show($"Validation Successful: {isValidated}");
		}
    }
}
