using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Bay.ERP.Web.UI
{
    public partial class TemplateRole : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (this.Page.User.Identity.IsAuthenticated == true)
            {
                if (Roles.IsUserInRole(this.Page.User.Identity.Name, "SiteUser") == true)
                {
                    SiteMapDataSource1.SiteMapProvider = "siteSiteMapProvider";
                }
            }

            // Activate the JavaScript waiting loop.
            if (this.Page.User.Identity.Name != null)
            {
                //string userName = (string)Session["S_Nitification_UserName"];

                // Call JavaScript method waitEvent to start the wait loop.
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ActivateWaitingLoop", "waitEvent();", true);
            }
        }
    }
}