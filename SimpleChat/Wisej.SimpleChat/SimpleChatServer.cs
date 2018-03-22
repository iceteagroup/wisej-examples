using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wisej.ChatServer
{
	public static class SimpleChatServer
	{
		private const string ADMIN = "Admin";
		private static object SyncLock = new object();
		private static List<string> UserNames = new List<string>();

		public static event SimpleChatServerEventHandler IncomingMessage;

		public static void Join(string name)
		{
			lock (SyncLock)
			{
				if (String.Equals(name, ADMIN, StringComparison.InvariantCulture))
					throw new Exception($"\"{name}\" is reserved.");

				// just make sure it's a unique name. It's not really necessary in this case, but it's a nice thing to do...
				if (UserNames.Contains(name))
					throw new Exception($"User \"{name}\" has already joined.");

				UserNames.Add(name);
				SendMessage(ADMIN, $"\"{name}\" joined the chat.");
			}
		}

		public static void Leave(string name)
		{
			lock (SyncLock)
			{
				UserNames.Remove(name);
				SendMessage(ADMIN, $"\"{name}\" left the chat.");
			}
		}

		public static void SendMessage(string from, string text)
		{
			if (IncomingMessage != null)
				IncomingMessage(new SimpleChatServerEventArgs(from, DateTime.Now, text));
		}
	}
}