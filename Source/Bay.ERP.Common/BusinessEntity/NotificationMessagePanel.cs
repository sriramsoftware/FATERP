using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PanelNotificationMessage
/// </summary>
/// 
namespace Bay.ERP.Common.BusinessEntities
{
    public class NotificationMessagePanel : NotificationMessage
    {
        public String EssentialNotes { get; set; }

        public String EssentialLink { get; set; }

        public String NotifiedColor { get; set; }

        public String NotificationHeader { get; set; }

        public String Priority { get; set; }

        public NotificationMessagePanel()
        {
            EssentialNotes = String.Empty;
            EssentialLink = String.Empty;
            NotificationHeader = String.Empty;
            Priority = String.Empty;
            NotifiedColor = String.Empty;
        }
    }
}