using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EmailNotificationMessage
/// </summary>
/// 
namespace Bay.ERP.Common.BusinessEntities
{
    public class NotificationMessageEmail : NotificationMessage
    {
        public String EmailAddress { get; set; }

        public String Subject { get; set; }

        public String Body { get; set; }

        public NotificationMessageEmail()
        {
            EmailAddress = String.Empty;
            Subject = String.Empty;
            Body = String.Empty;
        }
    }
}