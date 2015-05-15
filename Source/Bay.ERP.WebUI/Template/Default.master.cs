using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Bay.ERP.Web.UI.Helper;

namespace Bay.ERP.Web.UI
{
    public partial class TemplateDefault : System.Web.UI.MasterPage
    {
        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMachineIP.Text = System.Web.HttpContext.Current.Request.UserHostAddress;//MiscUtil.GetLocalIP();// 

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (this.Page.User.Identity.IsAuthenticated == true)
            {
                MembershipUser currentUser = Membership.GetUser(false);

                if (currentUser != null)
                {
                    Guid userId = (Guid)currentUser.ProviderUserKey;
                    //hypTimeLine.NavigateUrl = UrlHelper.BuildSecureUrl("~/Security/ActivityLog.aspx", string.Empty, UrlConstants.OVERVIEW_ASP_NET_USER_ID, currentUser.ProviderUserKey.ToString()).ToString();
                    //hypTimeLine.Target = "_blank";

                    //hypArtGellaryEvent.NavigateUrl = UrlHelper.BuildSecureUrl("~/Common/CMNEventSchedule.aspx", string.Empty, UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID, MasterDataConstants.CMNMDEventIdentityCategory.ART_GALLERY_EVENT.ToString()).ToString();
                    //hypArtGellaryEvent.Target = "_blank";
                    //hypOfficialEvent.NavigateUrl = UrlHelper.BuildSecureUrl("~/Common/CMNEventSchedule.aspx", string.Empty, UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID, MasterDataConstants.CMNMDEventIdentityCategory.BAY_S_OFFICIAL_EVENT.ToString()).ToString();
                    //hypOfficialEvent.Target = "_blank";
                }

                //if (Roles.IsUserInRole(this.Page.User.Identity.Name, "SiteUser") == true)
                //{
                //    //SiteMapDataSource1.SiteMapProvider = "siteSiteMapProvider";
                //}
            }
        }

        #endregion

        #region Button Event

        protected void LoginStatus_LoggedOut(Object sender, System.EventArgs e)
        {
            Session.Abandon();
        }

        #endregion
    }
}