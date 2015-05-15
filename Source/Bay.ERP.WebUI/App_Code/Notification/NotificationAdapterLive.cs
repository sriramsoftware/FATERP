/****************************** Module Header ******************************\
* Module Name:    ClientAdapter.cs
* Project:        CSASPNETReverseAJAX
* Copyright (c) Microsoft Corporation
*
* ClientAdapter class manages multiple client instances. The presentation layer 
* calls its methods to easily send and receive messages.
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
* All other rights reserved.
*
\*****************************************************************************/

using System.Collections.Generic;
using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.Web.UI.Notifciation
{
    /// <summary>
    /// This class is used to send events/messages to multiple clients.
    /// </summary>
    public class NotificationAdapterLive
    {
        /// <summary>
        /// The recipient list.
        /// </summary>
        private Dictionary<string, NotificationRecipientLive> recipients = new Dictionary<string,NotificationRecipientLive>();

        /// <summary>
        /// Send a message to a particular recipient.
        /// </summary>
        public void SendMessage(NotificationMessageLive message)
        {
            if (recipients.ContainsKey(message.RecipientName))
            {
                NotificationRecipientLive client = recipients[message.RecipientName];

                client.EnqueueMessage(message);
            }
        }

        /// <summary>
        /// Called by a individual recipient to wait and receive a message.
        /// </summary>
        /// <returns>The message content</returns>
        public string GetMessage(string userName)
        {
            string messageContent = string.Empty;

            if (recipients.ContainsKey(userName))
            {
                NotificationRecipientLive client = recipients[userName];

                messageContent = client.DequeueMessage().MessageContent + "this is from bay notification" + System.DateTime.Now.ToString();
            }

            return messageContent;
        }

        /// <summary>
        /// Join a user to the recipient list.
        /// </summary>
        public void Join(string userName)
        {
            recipients[userName] = new NotificationRecipientLive();
        }

        /// <summary>
        /// Singleton pattern.
        /// This pattern will ensure there is only one instance of this class in the system.
        /// </summary>
        public static NotificationAdapterLive Instance = new NotificationAdapterLive();
        private NotificationAdapterLive() { }
    }
}