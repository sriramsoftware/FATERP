using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bay.ERP.Web.UI.Helper;

namespace Bay.ERP.Web.UI
{
    public partial class TemplateIssue : IssueBaseMasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MenuItem munIssueInfo = new MenuItem();
                munIssueInfo.Text = "Issue Info";
                munIssueInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTIssueEditor.aspx", string.Empty, UrlConstants.OVERVIEW_ISSUE_ID, this.OverviewIssueID.ToString()).ToString();

                MenuItem munIssueUploads = new MenuItem();
                munIssueUploads.Text = "Issue Uploads";
                munIssueUploads.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTIssueUploadInfo.aspx", string.Empty, UrlConstants.OVERVIEW_ISSUE_ID, this.OverviewIssueID.ToString()).ToString();

                MenuItem munIssueResources = new MenuItem();
                munIssueResources.Text = "Issue Resources";
                munIssueResources.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTIssueAssignedResource.aspx", string.Empty, UrlConstants.OVERVIEW_ISSUE_ID, this.OverviewIssueID.ToString()).ToString();
                
                MenuItem munIssueWatchList = new MenuItem();
                munIssueWatchList.Text = "Issue Watch List";
                munIssueWatchList.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTIssueWatchList.aspx", string.Empty, UrlConstants.OVERVIEW_ISSUE_ID, this.OverviewIssueID.ToString()).ToString();

                //menuProject.Items.Add(munIssueInfo);
                //menuProject.Items.Add(munIssueUploads);
                //menuProject.Items.Add(munIssueResources);
                //menuProject.Items.Add(munIssueWatchList);
            }

            lblOverviewIssue.Text = this.OverviewIssue.Title;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            // Activate the JavaScript waiting loop.
            if (this.Page.User.Identity.Name != null)
            {
                //string userName = (string)Session["S_Nitification_UserName"];

                // Call JavaScript method waitEvent to start the wait loop.
                this.Page.ClientScript.RegisterStartupScript(this.GetType(),"ActivateWaitingLoop", "waitEvent();", true);
            }
        }

        protected void mnuMain_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            e.Item.NavigateUrl = UrlHelper.BuildSecureUrl(e.Item.NavigateUrl, string.Empty, UrlConstants.OVERVIEW_ISSUE_ID, this.OverviewIssueID.ToString()).ToString();
        }
    }
}