using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Wisej.Web;

namespace Wisej.JSWidgets
{
    public class AppData
    {

        public delegate void CustomEventHandler(object sender, Models.MessageEventArgs args);
        public static event EventHandler<Models.MessageEventArgs> RaiseNewMessage;
        private static object SyncLock = new object();

        private static IEnumerable<Models.User> _connectedUser;
        /// <value>
        /// Get all connected user
        /// </value>
        public static IEnumerable<Models.User> ConnectedUser
        {
            get
            {
                if (_connectedUser == null)
                    _connectedUser = new List<Models.User>();

                return _connectedUser;
            }
        }

        /// <summary>
        /// Add user to connected user.
        /// </summary>
        /// <param name="user">User we want to add.</param>
        public static void AddUser(Models.User user)
        {
            var existingUser = ConnectedUser.FirstOrDefault(u => u.SessionId == user.SessionId || u.Username == user.Username);
            if (existingUser != null)
                throw new Exception("User already exist");
            ((List<Models.User>)ConnectedUser).Add(user);
        }

        private static BindingList<Models.Message> _messages;
        /// <value>
        /// Get all Messages sended.
        /// </value>
        public static BindingList<Models.Message> Messages
        {
            get
            {
                if (_messages == null)
                    _messages = new BindingList<Models.Message>();

                return _messages;
            }
        }
        /// <summary>
        /// Add new message send.
        /// </summary>
        /// <param name="message">Message we want to send.</param>
        public static void AddMessage(Models.Message message)
        {
            lock (SyncLock)
            {
                var userExist = ConnectedUser.FirstOrDefault(u => u.SessionId == message.Sender.SessionId
                                                    && u.Username == message.Sender.Username);
                if (userExist == null)
                    throw new Exception("User not found");

                Messages.Add(message);
                RaiseNewMessage(userExist, new Models.MessageEventArgs(message));
            };
            
        }
    }
}