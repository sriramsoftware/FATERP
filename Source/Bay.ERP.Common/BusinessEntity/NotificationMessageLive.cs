using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LiveNotificationMessage
/// </summary>
/// 
namespace Bay.ERP.Common.BusinessEntities
{
    public class NotificationMessageLive : NotificationMessage
    {
        public String NoticationColor { get; set; }

        public Int32 NotifiedPeriodSecond { get; set; }

        public NotificationMessageLive()
        {
            NoticationColor = String.Empty;
            NotifiedPeriodSecond = 5;
        }
    }
}