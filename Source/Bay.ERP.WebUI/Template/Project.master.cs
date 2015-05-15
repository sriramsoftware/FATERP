using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bay.ERP.Web.UI.Helper;

namespace Bay.ERP.Web.UI
{
    public partial class TemplateProject : ProjectBaseMasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MenuItem munProjectInfo = new MenuItem();
                munProjectInfo.Text = "Project Info";
                munProjectInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectEditor.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem munProjectOtherInfo = new MenuItem();
                munProjectOtherInfo.Text = "Project OtherInfo";
                munProjectOtherInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectOtherInfo.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem munProjectAddressInfo = new MenuItem();
                munProjectAddressInfo.Text = "Project AddressInfo";
                munProjectAddressInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectAddressInfo.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();
                
                MenuItem munProjectAssignedPerson = new MenuItem();
                munProjectAssignedPerson.Text = "Project Assigned Person";
                munProjectAssignedPerson.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectAssignedPerson.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem munProjectFloorInfo = new MenuItem();
                munProjectFloorInfo.Text = "Project Floor Info";
                munProjectFloorInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectFloor.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem munProjectHistory = new MenuItem();
                munProjectHistory.Text = "Project History";
                munProjectHistory.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectHistory.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem munProjectCollectedDocumentSetup = new MenuItem();
                munProjectCollectedDocumentSetup.Text = "Project Document Setup";
                munProjectCollectedDocumentSetup.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectCollectedDocumentSetup.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem munProjectCollectedDocumentInfo = new MenuItem();
                munProjectCollectedDocumentInfo.Text = "Project Documents";
                munProjectCollectedDocumentInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectCollectedDocumentInfo.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem munProjectPreBOQInfo = new MenuItem();
                munProjectPreBOQInfo.Text = "Project PreBOQ Info";
                munProjectPreBOQInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMPreBOQInfo.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem munProjectPreBOQSetup = new MenuItem();
                munProjectPreBOQSetup.Text = "Project PreBOQ Setup";
                munProjectPreBOQSetup.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMPreBOQSetup.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem munProjectPreBOQ = new MenuItem();
                munProjectPreBOQ.Text = "Project PreBOQ";
                munProjectPreBOQ.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMPreBOQDetail.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem munREQRequisiton = new MenuItem();
                munREQRequisiton.Text = "Requisition";
                munREQRequisiton.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectRequisitionMaster.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem munREQRequisitonList = new MenuItem();
                munREQRequisitonList.Text = "Requisition List";
                munREQRequisitonList.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectRequisitionListMaster.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem mnuProjectIssue = new MenuItem();
                mnuProjectIssue.Text = "Project Issue Setup";
                mnuProjectIssue.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMProjectScheduleTemplateIssue.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem mnuProjectIssueTreeview = new MenuItem();
                mnuProjectIssueTreeview.Text = "Project Issue Treeview";
                mnuProjectIssueTreeview.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectIssue.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem mnuProjectMilestoneView = new MenuItem();
                mnuProjectMilestoneView.Text = "Project Milestone View";
                mnuProjectMilestoneView.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMProjectMilestoneView.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();
               

                MenuItem mnuItemReport = new MenuItem();
                mnuItemReport.Text = "Item Report";
                mnuItemReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "ItemReport", UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();
                mnuItemReport.Target = "_blank";

                MenuItem mnuProjectMilestone= new MenuItem();
                mnuProjectMilestone.Text = "Project Milestone";
                mnuProjectMilestone.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMProjectMilestone.aspx", string.Empty,UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                MenuItem mnuProjectMilestoneSetup = new MenuItem();
                mnuProjectMilestoneSetup.Text = "Project Milestone Setup";
                mnuProjectMilestoneSetup.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectMilestoneSetup.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

                //menuProject.Items.Add(munProjectInfo);
                //menuProject.Items.Add(mnuProjectMilestoneView);
                //menuProject.Items.Add(munProjectOtherInfo);
                //menuProject.Items.Add(munProjectAddressInfo);                
                //menuProject.Items.Add(munProjectAssignedPerson);
                //menuProject.Items.Add(munProjectFloorInfo);
                //menuProject.Items.Add(munProjectHistory);                
                //menuProject.Items.Add(munProjectCollectedDocumentInfo);
                //menuProject.Items.Add(munProjectPreBOQInfo);
                //menuProject.Items.Add(munProjectPreBOQ);
                //menuProject.Items.Add(munProjectCollectedDocumentSetup);
                //menuProject.Items.Add(munProjectPreBOQSetup);
                //menuProject.Items.Add(mnuProjectIssue);
                //menuProject.Items.Add(mnuProjectIssueTreeview);
                //menuProject.Items.Add(mnuProjectMilestoneSetup);
                //menuProject.Items.Add(munREQRequisiton);
                //menuProject.Items.Add(munREQRequisitonList);
                //menuProject.Items.Add(mnuItemReport);
                //menuProject.Items.Add(mnuProjectMilestone);
                
            }

            lblProjectName.Text = this.OverviewProject.ProjectName;
        }

        protected void mnuMain_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            e.Item.NavigateUrl = UrlHelper.BuildSecureUrl(e.Item.NavigateUrl, string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();

            if (e.Item.Text == "Project History Report")
            {
                e.Item.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.PROJECT_HISTORY_REPORT, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString()).ToString();
                e.Item.Target = "_blank";
            }
            
        }
    }
}