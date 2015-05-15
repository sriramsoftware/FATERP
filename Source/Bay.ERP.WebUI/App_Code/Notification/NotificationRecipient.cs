using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NotificationReceipent
/// </summary>
namespace Bay.ERP.Web.UI.Notifciation
{
    public class NotificationRecipient
    {
        public String RecipientName { get; set; }

        public String NotificationMessageContent { get; set; }

        public String UserName { get; set; }

        public String UserID { get; set; }

        public NotificationRecipient()
        {
            RecipientName = String.Empty;
            NotificationMessageContent = String.Empty;
            UserName = String.Empty;
            UserID = String.Empty;
        }
    }
}