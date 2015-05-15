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
using Bay.ERP.Web.UI.Manager;

using System.Web.UI.WebControls.WebParts;


namespace Bay.ERP.Web.UI
{
    public partial class Default : BasePage
    {
        public override string UniqueKey
        {
            get
            {
                return "Default_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/Common/CMNDashboardSchedule.ascx;";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Int64 employeeID = 0;

                //String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_MemberID, this.CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
                //IList<HREmployeeEntity> lstEmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                //if (lstEmployee != null && lstEmployee.Count > 0)
                //{
                //    employeeID = lstEmployee[0].EmployeeID;
                //}

                //lvAPMemberFeedback.DataSource = APRobot.GetNewApprovalRequestsToMemberFeedback(employeeID);
                //lvAPMemberFeedback.DataBind();
                hypArtGellaryEvent.NavigateUrl = UrlHelper.BuildSecureUrl("~/Common/CMNEventSchedule.aspx", string.Empty, UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID, MasterDataConstants.CMNMDEventIdentityCategory.ART_GALLERY_EVENT.ToString()).ToString();
                hypArtGellaryEvent.Target = "_blank";
                hypOfficialEvent.NavigateUrl = UrlHelper.BuildSecureUrl("~/Common/CMNEventSchedule.aspx", string.Empty, UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID, MasterDataConstants.CMNMDEventIdentityCategory.BAY_S_OFFICIAL_EVENT.ToString()).ToString();
                hypOfficialEvent.Target = "_blank";
            }            
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
            //NotificationMessageLive message = new NotificationMessageLive();
            //message.RecipientName = "raju";
            //message.MessageContent = "This is a test notificatiopn" + DateTime.Now.ToLongTimeString();

            //if (!string.IsNullOrWhiteSpace(message.RecipientName) && !string.IsNullOrEmpty(message.MessageContent))
            //{
            //    // Call the client adapter to send the message to the particular recipient instantly.
            //    NotificationAdapterLive.Instance.SendMessage(message);
            //}
        }

        protected void lvAPMemberFeedback_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                APMemberFeedbackEntity ent = (APMemberFeedbackEntity)dataItem.DataItem;

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByID(ent.APApprovalProcessID);
                
                HyperLink lnkViewDetails = (HyperLink)e.Item.FindControl("lnkViewDetails");
                HiddenField hydAPApprovalProcessID = (HiddenField)e.Item.FindControl("hydAPApprovalProcessID");
                Label lblTitle = (Label)e.Item.FindControl("lblTitle");

                if(aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.REQUISITION)
                {                    
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/REQ/REQRequisitionDetailsWithApproval.aspx", 
                        string.Empty, 
                        UrlConstants.REQUISITION_ID, 
                        aPApprovalProcessEntity.ReferenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString()
                        ).ToString();

                }
                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.WORK_ORDER)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/PRM/PRMWorkOrderViewWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_WORKORDER_ID, 
                        aPApprovalProcessEntity.ReferenceID.ToString(),                        
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString()
                        ).ToString();
                }
                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.CUSTOM)
                {
                    lnkViewDetails.NavigateUrl = "#";
                }

                lnkViewDetails.Target = "_blank";
            }
        }
        
    }
}