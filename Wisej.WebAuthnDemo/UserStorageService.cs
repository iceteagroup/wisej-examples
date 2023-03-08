using System.Collections.Generic;
using Wisej.Ext.WebAuthn;

namespace Wisej.WebAuthnDemo
{
	public class UserStorageService
	{
		private static Dictionary<string, string> _storage = new Dictionary<string, string>();

		public void RegisterUserPublicKey(string userName, string json)
		{
			lock (_storage)
			{
				_storage[userName] = json;
			}
		}

		public PublicKey GetUserPublicKey(string userName)
		{
			lock (_storage)
			{
				if (_storage.TryGetValue(userName, out string json))
					return new PublicKey(json);

				return null;
			}
		}
	}
}
