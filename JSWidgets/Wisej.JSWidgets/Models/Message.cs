using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wisej.JSWidgets.Models
{
    public class Message
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public User Sender { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Sender.Username} FROM {Sender.SessionId}  AT {Date} : {Content}";
        }
    }

    public class MessageEventArgs: EventArgs
    {
        public Message Message { get; set; }
        public MessageEventArgs(Message message)
        {
            Message = message;
        }
    }
}