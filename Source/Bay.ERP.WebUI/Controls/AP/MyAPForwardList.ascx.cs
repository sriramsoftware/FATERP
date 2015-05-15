// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class MyAPForwardListControl : BaseControl
    {       
        #region Properties

        public String PageAPType1 { get; set; }
        public Int64 PageAPType{ get; set; }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            BindList();
        }

        private void BindList()
        {
            Int64 employeeID = 0;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_MemberID, this.CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
            IList<HREmployeeEntity> lstEmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lstEmployee != null && lstEmployee.Count > 0)
            {
                employeeID = lstEmployee[0].EmployeeID;
            }

            //if (PageAPType == 0)
            //{
            //    lvAPMemberFeedback.DataSource = APRobot.GetApprovalRequests_DetailedByMember(employeeID);
            //}
            //else if(PageAPType == MasterDataConstants.APFeedback.FEEDBACK_REQUESTED)
            //{
            //    lvAPMemberFeedback.DataSource = APRobot.GetAllApprovalRequests_DetailedToMemberFeedback(employeeID);                
            //}
            //else
            //{
            //    lvAPMemberFeedback.DataSource = APRobot.GetApprovalRequests_DetailedByMemberAndStatus(employeeID, PageAPType);
            //}

            lvAPMemberFeedback.DataSource = APRobot.GetMyAPForwardInfo_DetailedByEmployee(employeeID);                            

            lvAPMemberFeedback.DataBind();   
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
            }
        }

        #endregion

        #region List View Event

        protected void lvAPMemberFeedback_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                APForwardInfo_DetailedEntity ent = (APForwardInfo_DetailedEntity)dataItem.DataItem;

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByID(ent.APApprovalProcessID);

                HyperLink lnkViewDetails = (HyperLink)e.Item.FindControl("lnkViewDetails");
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");
                Label lblTitle = (Label)e.Item.FindControl("lblTitle");
                Label lblAPFeedbackName = (Label)e.Item.FindControl("lblAPFeedbackName");

                #region This code should be changed

                String aPFeedbackName = String.Empty;

                switch (aPApprovalProcessEntity.APStatusID)
	            {
                    case MasterDataConstants.APStatus.CANCELED:
                        aPFeedbackName = "Canceled";
                        break;
                    case MasterDataConstants.APStatus.COMPLETED:
                        aPFeedbackName = "Complete";
                        break;
                    case MasterDataConstants.APStatus.IN_PROCESS:
                        aPFeedbackName = "In Process";
                        break;
                    case MasterDataConstants.APStatus.NEW:
                        aPFeedbackName = "New";
                        break;
                    case MasterDataConstants.APStatus.ON_HOLD:
                        aPFeedbackName = "On Hold";
                        break;
		            default:
                    break;
	            }   
                #endregion

                lblTitle.Text = aPApprovalProcessEntity.Title;
                lblAPFeedbackName.Text = aPFeedbackName;

                Label lblAPType = (Label)e.Item.FindControl("lblAPType");

                if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.REQUISITION)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/REQ/REQRequisitionDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.REQUISITION_ID,
                        aPApprovalProcessEntity.ReferenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString(),
                        APForwardInfoEntity.FLD_NAME_APForwardInfoID,
                        ent.APForwardInfoID.ToString()
                        ).ToString();
                    lblAPType.Text = "Requisition";

                }
                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.WORK_ORDER)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/PRM/PRMWorkOrderViewWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_WORKORDER_ID,
                        aPApprovalProcessEntity.ReferenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString(),
                        APForwardInfoEntity.FLD_NAME_APForwardInfoID,
                        ent.APForwardInfoID.ToString()
                        ).ToString();
                    lblAPType.Text = "Work Order";
                }
                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.BILL)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/CM/CMBillDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_CM_BILL_ID,
                        aPApprovalProcessEntity.ReferenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();
                    lblAPType.Text = "Bill";
                }
                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.PAYABLE_STATEMENT)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/ACC/ACCPostPayableStatementDetailWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_DETAIL_ID,
                        aPApprovalProcessEntity.ReferenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();
                    lblAPType.Text = "Payable Statement";
                }

                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.TRF)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/INV/INVTransferItemDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_TRANSFER_ID,
                        aPApprovalProcessEntity.ReferenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();
                    lblAPType.Text = "TRF";
                }

                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.BANK_DEPOSIT)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/AC/ACBankAccountDepositDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID,
                        aPApprovalProcessEntity.ReferenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    lblAPType.Text = "BANK DEPOSIT";
                }

                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.BANK_PAYMENT)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/AC/ACBankAccountPaymentDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID,
                        aPApprovalProcessEntity.ReferenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    lblAPType.Text = "BANK PAYMENT";
                }

                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.TEMPORARY_JOURNAL)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/AC/ACJournalDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_ID,
                        aPApprovalProcessEntity.ReferenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    lblAPType.Text = "JOURNAL ENTRY";
                }

                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.BANK_ACCOUNT_TRANSFER)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/AC/ACBankAccountTransferDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_BANK_ACCOUNT_TRANSFER_ID,
                        aPApprovalProcessEntity.ReferenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    lblAPType.Text = "BANK ACCOUNT TRANSFER";
                }

                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.MRR)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/PRM/PRMMaterialReceiveDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID,
                        aPApprovalProcessEntity.ReferenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    lblAPType.Text = "MATERIAL RECEIVE";
                }

                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.AGREEMENT)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl(
                        "~/CRM/CRMAgreementDetailsWithApproval.aspx",
                        string.Empty,
                        UrlConstants.OVERVIEW_AGREEMENT_ID,
                        aPApprovalProcessEntity.ReferenceID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();

                    lblAPType.Text = "AGREEMENT";
                }

                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.CONTACT_LIST)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProcessAssignedResourceDetailsWithApproval.aspx",
                      string.Empty,
                      UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_ID,
                      aPApprovalProcessEntity.ReferenceID.ToString(),
                      APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                      ent.APMemberFeedbackID.ToString(),
                      APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                      ent.APApprovalProcessID.ToString()
                      ).ToString();

                    lblAPType.Text = "CONTACT_LIST";
                }

                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.CUSTOM)
                {
                    lnkViewDetails.NavigateUrl = "#";
                    lblAPType.Text = "Custom";
                }
                                
                lnkShowApprovalStatus.NavigateUrl = UrlHelper.BuildSecureUrl(
                           "~/AP/APView.aspx",
                           string.Empty,
                           APApprovalProcessEntity.FLD_NAME_APApprovalProcessID,
                           aPApprovalProcessEntity.APApprovalProcessID.ToString()
                           ).ToString();

                lnkViewDetails.Target = "_blank";
                lnkShowApprovalStatus.Target = "_blank";
            }
        }

        #endregion List View Event

        #endregion Event
    }
}
