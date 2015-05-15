// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Data;


using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;
using System.Web.UI;

namespace Bay.ERP.Web.UI
{
    public partial class CMNDashboardScheduleControl : BaseControl
    {
        #region Properties

        public String Action
        {
            get
            {
                String action = "Add";

                if (ViewState["do"] != null)
                {
                    action = ViewState["do"].ToString();
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["do"].ToString()))
                {
                    action = Helper.Url.SecureUrl["do"].ToString();

                    ViewState["do"] = action;
                }

                return action;
            }
            set
            {
                ViewState["do"] = value;
            }
        }

        public Int64 _IssueID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_ID], out id);
                    ViewState["ID"] = id;
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public Int64? _ParentIssueID
        {
            get
            {
                Int64? id = null;

                if (ViewState["ParentIssueID"] != null)
                {
                    id = Int64.Parse(ViewState["ParentIssueID"].ToString());
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["ParentIssueID"]))
                {
                    id = Int64.Parse(Helper.Url.SecureUrl["ParentIssueID"].ToString());
                    ViewState["ParentIssueID"] = id;
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public Int64? _ReferenceIssueID
        {
            get
            {
                Int64? id = null;

                if (ViewState["ReferenceIssueID"] != null)
                {
                    id = Int64.Parse(ViewState["ReferenceIssueID"].ToString());
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["ReferenceIssueID"]))
                {
                    id = Int64.Parse(Helper.Url.SecureUrl["ReferenceIssueID"].ToString());
                    ViewState["ReferenceIssueID"] = id;
                }

                return id;
            }
            set
            {
                ViewState["ReferenceIssueID"] = value;
            }
        }

        public OTIssueEntity _OTIssueEntity
        {
            get
            {
                OTIssueEntity entity = new OTIssueEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (OTIssueEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private OTIssueEntity CurrentOTIssueEntity
        {
            get
            {
                if (_IssueID > 0)
                {
                    if (_OTIssueEntity.IssueID != _IssueID)
                    {
                        _OTIssueEntity = FCCOTIssue.GetFacadeCreate().GetByID(_IssueID);
                    }
                }

                return _OTIssueEntity;
            }
            set
            {
                _OTIssueEntity = value;
            }
        }


        public Int64 _RequisitionID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["RequisitionID"] != null)
                {
                    Int64.TryParse(ViewState["RequisitionID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["RequisitionID"] = value;
            }
        }

        public REQRequisitionEntity _REQRequisitionEntity
        {
            get
            {
                REQRequisitionEntity entity = new REQRequisitionEntity();

                if (ViewState["CurrentRequisitionEntity"] != null)
                {
                    entity = (REQRequisitionEntity)ViewState["CurrentRequisitionEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentRequisitionEntity"] = value;
            }
        }

        private REQRequisitionEntity CurrentREQRequisitionEntity
        {
            get
            {
                if (_RequisitionID > 0)
                {
                    if (_REQRequisitionEntity.RequisitionID != _RequisitionID)
                    {
                        _REQRequisitionEntity = FCCREQRequisition.GetFacadeCreate().GetByID(_RequisitionID);
                    }
                }

                return _REQRequisitionEntity;
            }
            set
            {
                _REQRequisitionEntity = value;
            }
        }

        #endregion

        #region Methods

        private void PrepareNotificationPopupView()
        {
            Int64 employeeID = 0;
            Boolean PopupFlag = false;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_MemberID, this.CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
            IList<HREmployeeEntity> lstEmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lstEmployee != null && lstEmployee.Count > 0)
            {
                employeeID = lstEmployee[0].EmployeeID;
            }

            IList<APMemberFeedback_DetailedEntity> lstAPMemberFeedback = APRobot.GetAllApprovalRequests_DetailedToMemberFeedback(employeeID);

            if (lstAPMemberFeedback != null && lstAPMemberFeedback.Count > 0)
            {
                lvAPMemberFeedback.DataSource = lstAPMemberFeedback;
                lvAPMemberFeedback.DataBind();
                PopupFlag = true;
                lblPendingApproval.Text = lstAPMemberFeedback.Count.ToString();
            }

            else
            {
                lblPendingApproval.Text = "0";
            }

            IList<APMemberFeedback_DetailedEntity> lstAPProxyMemberFeedback = APRobot.GetApprovalRequests_DetailedByProxyMember(employeeID);

            if (lstAPProxyMemberFeedback != null && lstAPProxyMemberFeedback.Count > 0)
            {
                lvAPProxyMemberFeedback.DataSource = APRobot.GetApprovalRequests_DetailedByProxyMember(employeeID);
                lvAPProxyMemberFeedback.DataBind();
                PopupFlag = true;
                lblPendingProxy.Text = lstAPProxyMemberFeedback.Count.ToString();
            }

            else
            {
                lblPendingProxy.Text = "0";
            }


            IList<APForwardInfo_DetailedEntity> lstAPForwardMemberFeedback = APRobot.GetAPForwardInfo_DetailedByEmployee(employeeID);

            if (lstAPForwardMemberFeedback != null && lstAPForwardMemberFeedback.Count > 0)
            {
                lvAPForwardMemberFeedback.DataSource = lstAPForwardMemberFeedback;
                lvAPForwardMemberFeedback.DataBind();
                PopupFlag = true;
                lblForward.Text = lstAPForwardMemberFeedback.Count.ToString();
            }

            else
            {
                lblForward.Text = "0";
            }

            if (PopupFlag)
            {
                this.Panel1_ModalPopupExtender.Show();
            }
        }

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProjectByMember(ddlProjectID, false, this.CurrentMember.MemberID);
            SetProjectIDByDropdown();
        }

        private void PrepareValidator()
        {
        }

        private void SetProjectIDByDropdown()
        {
            if (ddlProjectID.SelectedValue != "0" && ddlProjectID.Items.Count > 0)
            {
                hydOverviewProjectID.Value = ddlProjectID.SelectedValue.ToString();
            }
        }

        private void PrepareInitialView()
        {
            hypOverviewCurrentEmployeeID.Value = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember).ToString();
            BuildDropDownList();
            PrepareNotificationPopupView();
        }

        private void PrepareEditView()
        {
      
        }

        private void BindREQRequisitionList()
        {
            lvREQRequisition.DataBind();
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
                PrepareEditView();
            }
        }

        #endregion

        #region Dropdown Event

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetProjectIDByDropdown();
        }

        #endregion

        #region List View Event

        protected void lvREQRequisition_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                REQRequisitionDashboard_CustomEntity ent = (REQRequisitionDashboard_CustomEntity)dataItem.DataItem;

                HyperLink hypRequisition = (HyperLink)e.Item.FindControl("hypRequisition");
                Label lblRequisitionItem = (Label)e.Item.FindControl("lblRequisitionItem");

                String feReqItem = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItemEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), SQLMatchType.Equal);
                IList<REQRequisitionItem_DetailedEntity> lst = FCCREQRequisitionItem_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, feReqItem);

                if (lst != null && lst.Count > 0)
                {
                    foreach (REQRequisitionItem_DetailedEntity entREQRequisitionItem_DetailedEntity in lst)
                    {
                        lblRequisitionItem.Text += entREQRequisitionItem_DetailedEntity.MDItemItemName + ", ";
                    }

                    lblRequisitionItem.Text = lblRequisitionItem.Text.Substring(0, lblRequisitionItem.Text.Length - 2);
                }

                hypRequisition.NavigateUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisitionItem.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, ent.ProjectID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionNo, ent.RequisitionNo.ToString()).ToString();
                hypRequisition.Target = "_blank";
            }
        }

        #endregion List View Event

        #region List View Event Popup

        protected void lvAPMemberFeedback_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                APMemberFeedback_DetailedEntity ent = (APMemberFeedback_DetailedEntity)dataItem.DataItem;

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByID(ent.APApprovalProcessID);

                HyperLink lnkViewDetails = (HyperLink)e.Item.FindControl("lnkViewDetails");
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");
                Label lblTitle = (Label)e.Item.FindControl("lblTitle");

                lblTitle.Text = aPApprovalProcessEntity.Title;

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
                        ent.APApprovalProcessID.ToString()
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
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString()
                        ).ToString();
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
                }

                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.LOAN_APPLICATION)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeeLoanApplicationDetailsWithApproval.aspx",
                      string.Empty,
                      UrlConstants.OVERVIEW_LOAN_APPLICATION_ID,
                      aPApprovalProcessEntity.ReferenceID.ToString(),
                      APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                      ent.APMemberFeedbackID.ToString(),
                      APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                      ent.APApprovalProcessID.ToString()
                      ).ToString();
                }

                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.LEAVE_APPLICATION)
                {
                    lnkViewDetails.NavigateUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeeLeaveApplicationWithApproval.aspx",
                      string.Empty,
                      UrlConstants.OVERVIEW_LEAVE_APPLICATION_ID,
                      aPApprovalProcessEntity.ReferenceID.ToString(),
                      APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID,
                      ent.APMemberFeedbackID.ToString(),
                      APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                      ent.APApprovalProcessID.ToString()
                      ).ToString();
                }


                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.CUSTOM)
                {
                    lnkViewDetails.NavigateUrl = "#";
                }

                //lnkShowApprovalStatus.NavigateUrl = UrlHelper.BuildSecureUrl(
                //           "~/AP/APView.aspx",
                //           string.Empty,
                //           APApprovalProcessEntity.FLD_NAME_APApprovalProcessID,
                //           aPApprovalProcessEntity.APApprovalProcessID.ToString()
                //           ).ToString();

                //lnkViewDetails.Target = "_blank";
                // lnkShowApprovalStatus.Target = "_blank";
            }
        }

        protected void lvAPProxyMemberFeedback_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                APMemberFeedback_DetailedEntity ent = (APMemberFeedback_DetailedEntity)dataItem.DataItem;

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByID(ent.APApprovalProcessID);

                HyperLink lnkViewDetails = (HyperLink)e.Item.FindControl("lnkViewDetails");
                Label lblTitle = (Label)e.Item.FindControl("lblTitle");

                lblTitle.Text = aPApprovalProcessEntity.Title;

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
                        APMemberFeedbackEntity.FLD_NAME_ProxyEmployeeID,
                        ent.ProxyEmployeeID.ToString()
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
                        ent.APMemberFeedbackID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID,
                        ent.APApprovalProcessID.ToString(),
                        APMemberFeedbackEntity.FLD_NAME_ProxyEmployeeID,
                        ent.ProxyEmployeeID.ToString()
                        ).ToString();
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
                }
                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.CUSTOM)
                {
                    lnkViewDetails.NavigateUrl = "#";
                }

                lnkViewDetails.Target = "_blank";
            }
        }

        protected void lvAPForwardMemberFeedback_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                APForwardInfo_DetailedEntity ent = (APForwardInfo_DetailedEntity)dataItem.DataItem;

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByID(ent.APApprovalProcessID);

                HyperLink lnkViewDetails = (HyperLink)e.Item.FindControl("lnkViewDetails");
                Label lblTitle = (Label)e.Item.FindControl("lblTitle");

                lblTitle.Text = aPApprovalProcessEntity.Title;

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
                }
                else if (aPApprovalProcessEntity.APTypeID == MasterDataConstants.APType.CUSTOM)
                {
                    lnkViewDetails.NavigateUrl = "#";
                }

                lnkViewDetails.Target = "_blank";
            }

        }

        #endregion List View Event

        #region Calendar Button Event

        protected void btnCreateEvent_Click(object sender, EventArgs e)
        {
            try
            {
                #region User Input

                OTIssueEntity oTIssueEntity = new OTIssueEntity();
                
                oTIssueEntity.IssueCategoryID = 12; // Need to change here.

                oTIssueEntity.Title = txtTitle.Text.Trim();
                oTIssueEntity.Description = "Calendar Created Task";
                oTIssueEntity.IssuePriorityID = MasterDataConstants.MDIssuePriority.HIGH;
                oTIssueEntity.CompletionPercentage = 0;
                oTIssueEntity.IssueStatusID = MasterDataConstants.MDIssueStatus.NEW;
                oTIssueEntity.Duration = null;

                //String startDate=DateTime.ParseExact(txtStartDate.Text, "ddd MMM dd yyyy HH:mm:ss 'GMT'zzz", System.Globalization.CultureInfo.InvariantCulture).ToString();
                //String startDate = txtStartDate.Text;

                String startDate = txtStartDate.Text.Remove(txtStartDate.Text.LastIndexOf('('));
                String endDate = txtEndDate.Text.Remove(txtEndDate.Text.LastIndexOf('('));

                oTIssueEntity.ExpectedStartDate = DateTime.ParseExact(startDate.Trim(), "ddd MMM dd yyyy HH:mm:ss 'GMT'zzz", System.Globalization.CultureInfo.InvariantCulture);
                oTIssueEntity.ExpectedEndDate = DateTime.ParseExact(endDate.Trim(), "ddd MMM dd yyyy HH:mm:ss 'GMT'zzz", System.Globalization.CultureInfo.InvariantCulture);
                oTIssueEntity.SupervisorEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                oTIssueEntity.AssignedToEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                oTIssueEntity.ActualStartDate = null;
                oTIssueEntity.ActualEndDate = null;
                oTIssueEntity.NotifyBeforeMin = null;
                oTIssueEntity.SupervisorAgreed = true;
                oTIssueEntity.ModifiedBySupervisorDateTime = System.DateTime.Now;
                oTIssueEntity.IP = MiscUtil.GetLocalIP();
                oTIssueEntity.Remarks = String.Empty;

                oTIssueEntity.IssueIdentityCategoryID = MasterDataConstants.IssueIdentityCategory.ADHOC_ISSUE;
                oTIssueEntity.CreatedByMemberID = this.CurrentMember.MemberID;
                oTIssueEntity.CompletionPercentage = 0;
                oTIssueEntity.CreateDate = DateTime.Now;
                oTIssueEntity.IsNotifyCompleted = false;
                oTIssueEntity.IsRemoved = false;

                oTIssueEntity.ParentIssueID = null;
                oTIssueEntity.ReferenceID = null;
                oTIssueEntity.ReferenceIssueID = null;

                Int64 result = -1;

                result = FCCOTIssue.GetFacadeCreate().Add(oTIssueEntity, DatabaseOperationType.Add, TransactionRequired.No);

                if (result > 0)
                {
                    MiscUtil.ShowMessage(lblMessage, "Event Created Successfully", false);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Can't Create Event.", true);
                }
                #endregion Manual Input
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Some Error Occured", true);
            }
        }

        #endregion

        #region ObjectDataSource Event

        protected void odsREQRequisition_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
                
            String fe1 = "REQRequisition.RequisitionID not in(Select RequisitionID from PRMWorkOrderItemMap)";
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionEntity.FLD_NAME_RequisitionStatusID, MasterDataConstants.RequisitionStatus.APPROVED.ToString(), SQLMatchType.Equal);
            fe=SqlExpressionBuilder.PrepareFilterExpression(fe1,SQLJoinType.AND,fe2);

            if (chbxFilter.Checked)
            {
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition.RequisitionNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                //String fe2 = SqlExpressionBuilder.PrepareFilterExpression("MDRequisitionStatus.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                //String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindREQRequisitionList();
            this.Panel1_ModalPopupExtender.Show();
        }

        #endregion

        #endregion Event
    }
}
