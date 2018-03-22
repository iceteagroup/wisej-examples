
using System;

namespace Wisej.ChatServer
{
	public class SimpleChatServerEventArgs : EventArgs
	{
		public SimpleChatServerEventArgs(string from, DateTime timeStamp, string message)
		{
			this.From = from;
			this.TimeStamp = timeStamp;
			this.Message = message;
		}

		public DateTime TimeStamp
		{
			get;
			private set;
		}

		public string From
		{
			get;
			private set;
		}

		public string Message
		{
			get;
			private set;
		}
	}
}