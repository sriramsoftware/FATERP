using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Web.UI.Notifciation;
using System.Web.UI.WebControls.WebParts;


namespace Bay.ERP.Web.UI
{
    public partial class SiteMapPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            //// Create a message entity to contain all necessary data.
            //NotificationMessage message = new NotificationMessage();
            //message.RecipientName = "Admin";
            //message.MessageContent = "This is a test notificatiopn" + DateTime.Now.ToLongTimeString();

            //if (!string.IsNullOrWhiteSpace(message.RecipientName) && !string.IsNullOrEmpty(message.MessageContent))
            //{
            //    // Call the client adapter to send the message to the particular recipient instantly.
            //    NotificationClientAdapter.Instance.SendMessage(message);
            //}


            // Create a message entity to contain all necessary data.
            NotificationMessageLive message = new NotificationMessageLive();
            message.RecipientName = "raju";
            message.MessageContent = "This is a test notificatiopn" + DateTime.Now.ToLongTimeString();

            if (!string.IsNullOrWhiteSpace(message.RecipientName) && !string.IsNullOrEmpty(message.MessageContent))
            {
                // Call the client adapter to send the message to the particular recipient instantly.
                NotificationAdapterLive.Instance.SendMessage(message);
            }
        }

        
    }
}