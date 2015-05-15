// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
using System.Text;
using System.Web.UI.HtmlControls;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeLoanApplicationDetailsWithApprovalControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeLoanApplicationID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public HREmployeeLoanApplicationEntity _HREmployeeLoanApplicationEntity
        {
            get
            {
                HREmployeeLoanApplicationEntity entity = new HREmployeeLoanApplicationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeLoanApplicationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeLoanApplicationEntity CurrentHREmployeeLoanApplicationEntity
        {
            get
            {
                if (OverviewLoanApplicationID > 0)
                {
                   
                        _HREmployeeLoanApplicationEntity = FCCHREmployeeLoanApplication.GetFacadeCreate().GetByID(OverviewLoanApplicationID);
                }

                return _HREmployeeLoanApplicationEntity;
            }
            set
            {
                _HREmployeeLoanApplicationEntity = value;
            }
        }


        public Int64 APApprovalProcessID
        {
            get
            {
                Int64 aPApprovalProcessID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID], out aPApprovalProcessID);
                }

                return aPApprovalProcessID;
            }
        }

        public Int64 APForwardInfoID
        {
            get
            {
                Int64 aPForwardInfoID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APForwardInfoEntity.FLD_NAME_APForwardInfoID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APForwardInfoEntity.FLD_NAME_APForwardInfoID], out aPForwardInfoID);
                }

                return aPForwardInfoID;
            }
        }

        public Int64 ProxyEmployeeID
        {
            get
            {
                Int64 proxyEmployeeID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_ProxyEmployeeID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_ProxyEmployeeID], out proxyEmployeeID);
                }

                return proxyEmployeeID;
            }
        }

        public Int64 APMemberFeedbackID
        {
            get
            {
                Int64 aPMemberFeedbackID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID], out aPMemberFeedbackID);
                }

                return aPMemberFeedbackID;
            }
        }

        public Int64 OverviewLoanApplicationID
        {
            get
            {
                Int64 overviewLoanApplicationID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_LOAN_APPLICATION_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_LOAN_APPLICATION_ID], out overviewLoanApplicationID);
                }

                return overviewLoanApplicationID;
            }
        }

        #endregion

        #region Methods

        private void RedirectPageToAllPendingList()
        {
            Response.Redirect("~/AP/Default.aspx");
        }

        private void RedirectPageToRejectList()
        {
            Response.Redirect("~/AP/APRejectedList.aspx");
        }

        private void RedirectPageToForwardList()
        {
            Response.Redirect("~/AP/APPendingForwardList.aspx");
        }

        private void RedirectPageToPendingList()
        {
            Response.Redirect("~/AP/APPendingList.aspx");
        }

        private void RedirectPageToProxyList()
        {
            Response.Redirect("~/AP/APProxyApprovalRequest.aspx");
        }

        private void BuildDropDownListAP()
        {
            if (!(APForwardInfoID > 0))
            {
                ddlAction.Items.Add(new ListItem("Approve", "1"));
                ddlAction.Items.Add(new ListItem("Back", "2"));
                ddlAction.Items.Add(new ListItem("Forward", "3"));

                APMemberFeedbackEntity ent = APRobot.GetAPMemberFeedbackByID(APMemberFeedbackID);

                ddlRejectTo.Items.Clear();
                ddlRejectTo.DataTextField = APMemberFeedback_DetailedEntity.FLD_NAME_MemberFullName;
                ddlRejectTo.DataValueField = APMemberFeedback_DetailedEntity.FLD_NAME_APMemberFeedbackID;
                ddlRejectTo.DataSource = APRobot.GetRejectToMemberFeedbacks_Detailed(APApprovalProcessID, ent.EmployeeID);
                ddlRejectTo.DataBind();
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                ddlRejectTo.Items.Insert(0, pleaseSelectListItem);

                ddlForwardTo.Items.Clear();
                ddlForwardTo.DataTextField = APPanelForwardMember_DetailedEntity.FLD_NAME_MemberFullName;
                ddlForwardTo.DataValueField = APPanelForwardMember_DetailedEntity.FLD_NAME_APPanelForwardMemberID;
                ddlForwardTo.DataSource = APRobot.GetAPPanelForwardMemberByApprovalProcessTypeAndReferenceID(MasterDataConstants.APType.LOAN_APPLICATION, OverviewLoanApplicationID);
                ddlForwardTo.DataBind();
            }
            else
            {
                ddlAction.Items.Add(new ListItem("Comment", "4"));
            }
        }

        private void EnableDisableApprovalButtons()
        {
            if (!(APForwardInfoID > 0))
            {
                APMemberFeedbackEntity ent = APRobot.GetAPMemberFeedbackByID(APMemberFeedbackID);

                if (ent.APFeedbackID == MasterDataConstants.APFeedback.APPROVED ||
                    ent.APFeedbackID == MasterDataConstants.APFeedback.REJECTED ||
                    ent.APFeedbackID == MasterDataConstants.APFeedback.NOT_YET_REQUESTED ||
                    ent.APFeedbackID == MasterDataConstants.APFeedback.CANCELED)
                {
                    btnApprove.Enabled = false;
                    btnReject.Enabled = false;
                    btnForward.Enabled = false;
                }
                else
                {
                    btnApprove.Enabled = true;
                    btnReject.Enabled = true;
                    btnForward.Enabled = true;
                }

                Boolean isAPFirstMember = APRobot.IsFirstMemberFeedback(APMemberFeedbackID);

                if (isAPFirstMember)
                {
                    if (ent.APFeedbackID == MasterDataConstants.APFeedback.APPROVED ||
                        ent.APFeedbackID == MasterDataConstants.APFeedback.REJECTED ||
                        ent.APFeedbackID == MasterDataConstants.APFeedback.NOT_YET_REQUESTED ||
                        ent.APFeedbackID == MasterDataConstants.APFeedback.CANCELED)
                    {
                        // btnSubmit.Visible = false;
                    }
                    else
                    {
                        //btnSubmit.Visible = true;
                    }
                }
                else
                {
                    //btnSubmit.Visible = false;
                }
            }
            else
            {
                btnApprove.Enabled = false;
                btnReject.Enabled = false;
                btnForward.Enabled = false;

                //btnSubmit.Visible = false;
            }
        }

        private String AddProxyMemberInfo(String remarks)
        {
            if (ProxyEmployeeID > 0)
            {
                APMemberFeedback_DetailedEntity ent = APRobot.GetMemberFeedback_DetailedByAPMemberFeedbackID(APMemberFeedbackID);
                remarks += "<br />";
                remarks += "<br />";
                remarks += "<b><i>This action has been taken by proxy member - " + ent.ProxyMemberFullName + "</i></b>";
            }

            return remarks;
        }

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDLoanCategory(ddlLoanCategoryID, false);
            MiscUtil.PopulateMDCurrency(ddlCurrencyID, false);
            MiscUtil.PopulateMDEmployeeLoanApprovalStatus(ddlEmployeeLoanApprovalStatusID, false);

            if (ddlEmployeeLoanApprovalStatusID != null && ddlEmployeeLoanApprovalStatusID.Items.Count > 0)
            {
                ddlEmployeeLoanApprovalStatusID.SelectedValue = MasterDataConstants.MDLoanApplicatoinStatus.PENDING.ToString();
            }

            BuildDropDownListAP();
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAppliedLoanAmount.Text = String.Empty;
            txtLoanPaymentStartDate.Text = String.Empty;
            txtLoanPaymentEndDate.Text = String.Empty;
            txtNumberOfInstallment.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtLoanRemarks.Text = String.Empty;

          

            #region Approval

            lvAPMemberFeedbackRemarks.DataSource = APRobot.GetMemberFeedbackRemarks_DetailedByApprovalProcessID(APApprovalProcessID);
            lvAPMemberFeedbackRemarks.DataBind();

            EnableDisableApprovalButtons();

            #endregion
        }

        private void PrepareEditView()
        {
            HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity = CurrentHREmployeeLoanApplicationEntity;


            if (!hREmployeeLoanApplicationEntity.IsNew)
            {
               
                if (ddlLoanCategoryID.Items.Count > 0 && hREmployeeLoanApplicationEntity.LoanCategoryID != null)
                {
                    ddlLoanCategoryID.SelectedValue = hREmployeeLoanApplicationEntity.LoanCategoryID.ToString();
                }

                txtAppliedLoanAmount.Text = hREmployeeLoanApplicationEntity.AppliedLoanAmount.ToString();
                if (ddlCurrencyID.Items.Count > 0 && hREmployeeLoanApplicationEntity.CurrencyID != null)
                {
                    ddlCurrencyID.SelectedValue = hREmployeeLoanApplicationEntity.CurrencyID.ToString();
                }

                txtLoanPaymentStartDate.Text = hREmployeeLoanApplicationEntity.LoanPaymentStartDate.ToStringDefault();
                txtLoanPaymentEndDate.Text = hREmployeeLoanApplicationEntity.LoanPaymentEndDate.ToStringDefault();
                txtNumberOfInstallment.Text = hREmployeeLoanApplicationEntity.NumberOfInstallment.ToString();
                txtDescription.Text = hREmployeeLoanApplicationEntity.Description.ToString();
                if (ddlEmployeeLoanApprovalStatusID.Items.Count > 0 && hREmployeeLoanApplicationEntity.EmployeeLoanApprovalStatusID != null)
                {
                    ddlEmployeeLoanApprovalStatusID.SelectedValue = hREmployeeLoanApplicationEntity.EmployeeLoanApprovalStatusID.ToString();
                }

                txtLoanRemarks.Text = hREmployeeLoanApplicationEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindHREmployeeLoanApplicationList();
        }

        private void BindHREmployeeLoanApplicationList()
        {
           
        }

        private HREmployeeLoanApplicationEntity BuildHREmployeeLoanApplicationEntity()
        {
            HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity = CurrentHREmployeeLoanApplicationEntity;

            if (ddlLoanCategoryID.Items.Count > 0)
            {
                if (ddlLoanCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeLoanApplicationEntity.LoanCategoryID = Int64.Parse(ddlLoanCategoryID.SelectedValue);
                }
            }

            if (!txtAppliedLoanAmount.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeLoanApplicationEntity.AppliedLoanAmount = Decimal.Parse(txtAppliedLoanAmount.Text.Trim());
            }

            if (ddlCurrencyID.Items.Count > 0)
            {
                if (ddlCurrencyID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeLoanApplicationEntity.CurrencyID = Int64.Parse(ddlCurrencyID.SelectedValue);
                }
            }

            if (txtLoanPaymentStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeLoanApplicationEntity.LoanPaymentStartDate = MiscUtil.ParseToDateTime(txtLoanPaymentStartDate.Text);
            }
            else
            {
                hREmployeeLoanApplicationEntity.LoanPaymentStartDate = null;
            }

            if (txtLoanPaymentEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeLoanApplicationEntity.LoanPaymentEndDate = MiscUtil.ParseToDateTime(txtLoanPaymentEndDate.Text);
            }
            else
            {
                hREmployeeLoanApplicationEntity.LoanPaymentEndDate = null;
            }

            if (!txtNumberOfInstallment.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeLoanApplicationEntity.NumberOfInstallment = Decimal.Parse(txtNumberOfInstallment.Text.Trim());
            }
            else
            {
                hREmployeeLoanApplicationEntity.NumberOfInstallment = null;
            }

            hREmployeeLoanApplicationEntity.Description = txtDescription.Text.Trim();
            if (ddlEmployeeLoanApprovalStatusID.Items.Count > 0)
            {
                if (ddlEmployeeLoanApprovalStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeLoanApplicationEntity.EmployeeLoanApprovalStatusID = Int64.Parse(ddlEmployeeLoanApprovalStatusID.SelectedValue);
                }
            }

            hREmployeeLoanApplicationEntity.Remarks = txtRemarks.Text.Trim();

            return hREmployeeLoanApplicationEntity;
        }

        private void SaveHREmployeeLoanApplicationEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity = BuildHREmployeeLoanApplicationEntity();

                    Int64 result = -1;

                    if (hREmployeeLoanApplicationEntity.IsNew)
                    {
                        result = FCCHREmployeeLoanApplication.GetFacadeCreate().Add(hREmployeeLoanApplicationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLoanApplicationEntity.FLD_NAME_EmployeeLoanApplicationID, hREmployeeLoanApplicationEntity.EmployeeLoanApplicationID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeLoanApplication.GetFacadeCreate().Update(hREmployeeLoanApplicationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {

                        _EmployeeLoanApplicationID = 0;
                        _HREmployeeLoanApplicationEntity = new HREmployeeLoanApplicationEntity();
                        PrepareInitialView();
                        BindHREmployeeLoanApplicationList();

                        if (hREmployeeLoanApplicationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Loan Application Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Loan Application Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeLoanApplicationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Loan Application Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Loan Application Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {

            btnApprove.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnApprove, "").ToString());
            btnReject.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnReject, "").ToString());
            btnSubmitComment.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnSubmitComment, "").ToString());
            btnForward.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnForward, "").ToString());


            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region ListView Event

        protected void lvAPMemberFeedbackRemarks_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                APMemberFeedbackRemarks_DetailedEntity ent = (APMemberFeedbackRemarks_DetailedEntity)e.Item.DataItem;

                APForwardInfo_DetailedEntity aPForwardInfo_DetailedEntity = APRobot.GetAPForwardInfo_DetailedByRemarksID(ent.APMemberFeedbackRemarksID);

                if (aPForwardInfo_DetailedEntity.APForwardInfoID > 0)
                {
                    HtmlGenericControl forwardInfoDiv = (HtmlGenericControl)e.Item.FindControl("forwardInfoDiv");

                    forwardInfoDiv.InnerHtml = "<br />";
                    forwardInfoDiv.InnerHtml += "<b>Forwading Remarks By Panel Member</b>";
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += aPForwardInfo_DetailedEntity.APMemberComment;
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += "<b>Response By " + aPForwardInfo_DetailedEntity.MemberFullName + "</b>";
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += aPForwardInfo_DetailedEntity.APForwardMemberComment;
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += "<br />";
                }
            }
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeLoanApplicationEntity();
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            btnApprove.Enabled = false;

            APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.LOAN_APPLICATION, OverviewLoanApplicationID);

            String remarks = txtLoanRemarks.Text.Trim();

            if (remarks.IsNullOrEmpty())
            {
                remarks = "Approved";
            }

            remarks = AddProxyMemberInfo(remarks);

            APRobot.AddAPMemberFeedbackRemarks(APMemberFeedbackID, remarks);

            EnableDisableApprovalButtons();

            MiscUtil.ShowMessage(lblMessage, "You Have Approved Successfully", UIConstants.MessageType.GREEN);

            PrepareInitialView();
            BindList();
            RedirectPageToPendingList();
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            btnReject.Enabled = false;

            if (ddlRejectTo.SelectedValue == "0")
            {
                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.LOAN_APPLICATION, OverviewLoanApplicationID);
            }
            else
            {
                Int64 rejectToAPMemberFeedbackID = Int64.Parse(ddlRejectTo.SelectedValue);

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.LOAN_APPLICATION, OverviewLoanApplicationID, rejectToAPMemberFeedbackID);
            }

            String remarks = txtLoanRemarks.Text.Trim();

            if (remarks.IsNullOrEmpty())
            {
                remarks = "Rejected";
            }

            remarks = AddProxyMemberInfo(remarks);

            APRobot.AddAPMemberFeedbackRemarks(APMemberFeedbackID, remarks);

            EnableDisableApprovalButtons();

            MiscUtil.ShowMessage(lblMessage, "You Have Rejected Successfully", UIConstants.MessageType.GREEN);

            PrepareInitialView();
            BindList();
            RedirectPageToRejectList();
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            //if (chbxAutoForwardTo.Checked)
            //{
            //    APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.BILL, CMBillID);

            //    IList<APMemberFeedbackEntity> feedbackList = APRobot.GetAllMemberFeedbacks(aPApprovalProcessEntity.APApprovalProcessID);

            //    IList<APMemberFeedbackEntity> ordered_list = feedbackList.OrderBy(x => x.SequenceNo).ToList();

            //    APPanelForwardMemberEntity aPPanelForwardMemberEntity = APRobot.GetAPPanelForwardMemberByID(Int64.Parse(ddlForwardTo.SelectedValue));

            //    var existsInfo = (from s in ordered_list
            //                      where s.EmployeeID.ToString() == aPPanelForwardMemberEntity.EmployeeID.ToString()
            //                      select s);

            //    if (existsInfo != null && existsInfo.Count() > 0)
            //    {
            //        MiscUtil.ShowMessage(lblMessage, "Member Already Exists in the Approval Panel", true);
            //        return;
            //    }

            //    APMemberFeedbackEntity currentEmployeeInfo = (from r in ordered_list
            //                                                  where r.EmployeeID.ToString() == MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember).ToString()
            //                                                  select r).FirstOrDefault();

            //    if (currentEmployeeInfo != null)
            //    {
            //        ordered_list = (from m in ordered_list
            //                        where m.SequenceNo > currentEmployeeInfo.SequenceNo
            //                        select m).ToList();



            //        APMemberFeedbackEntity aPMemberFeedbackEntity = new APMemberFeedbackEntity();

            //        aPMemberFeedbackEntity.APApprovalProcessID = aPApprovalProcessEntity.APApprovalProcessID;
            //        aPMemberFeedbackEntity.DepartmentID = aPPanelForwardMemberEntity.DepartmentID;
            //        aPMemberFeedbackEntity.EmployeeID = aPPanelForwardMemberEntity.EmployeeID;
            //        aPMemberFeedbackEntity.SequenceNo = currentEmployeeInfo.SequenceNo + 1;
            //        aPMemberFeedbackEntity.APFeedbackID = MasterDataConstants.APFeedback.NOT_YET_REQUESTED;
            //        aPMemberFeedbackEntity.FeedbackRequestDate = DateTime.Now;
            //        aPMemberFeedbackEntity.FeedbackLastResponseDate = null;
            //        aPMemberFeedbackEntity.FeedbackSubmitDate = null;
            //        aPMemberFeedbackEntity.IsProxyEmployeeEnabled = false;
            //        aPMemberFeedbackEntity.ProxyEmployeeID = null;

            //        Int64 aPMemberFeedbackID = FCCAPMemberFeedback.GetFacadeCreate().Add(aPMemberFeedbackEntity, DatabaseOperationType.Add, TransactionRequired.No);

            //        foreach (APMemberFeedbackEntity ent in ordered_list)
            //        {
            //            String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID, ent.APMemberFeedbackID.ToString(), SQLMatchType.Equal);
            //            ent.SequenceNo += 1;
            //            FCCAPMemberFeedback.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
            //        }

            //        APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.BILL, CMBillID);

            //        String remarks = txtRemarks.Text.Trim();

            //        if (remarks.IsNullOrEmpty())
            //        {
            //            remarks = "Approved";
            //        }

            //        remarks = AddProxyMemberInfo(remarks);

            //        APRobot.AddAPMemberFeedbackRemarks(APMemberFeedbackID, remarks);

            //        EnableDisableApprovalButtons();

            //        MiscUtil.ShowMessage(lblMessage, "You have Approved Successfully", UIConstants.MessageType.GREEN);

            //        PrepareInitialView();
            //        BindList();
            //        RedirectPageToPendingList();
            //    }
            //}

            ////Previous Code

            //else
            //{

                if (ddlRejectTo.Items.Count > 0)
                {
                    APRobot.UpdateMemberFeedbackFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.FORWARDED);
                    APRobot.UpdateMemberFeedbackLastResponseDate(APMemberFeedbackID, DateTime.Now);

                    String remarks = txtLoanRemarks.Text.Trim();

                    if (remarks.IsNullOrEmpty())
                    {
                        remarks = "Forwarded";
                    }

                    remarks = AddProxyMemberInfo(remarks);

                    Int64 aPMemberFeedbackRemarksID = APRobot.AddAPMemberFeedbackRemarks(APMemberFeedbackID, remarks);

                    Int64 aPPanelForwardMemberID = Int64.Parse(ddlForwardTo.SelectedValue);

                    APPanelForwardMemberEntity aPPanelForwardMemberEntity = APRobot.GetAPPanelForwardMemberByID(aPPanelForwardMemberID);

                    APForwardInfoEntity aPForwardInfoEntity = new APForwardInfoEntity();

                    aPForwardInfoEntity.APMemberFeedbackID = APMemberFeedbackID;
                    aPForwardInfoEntity.APApprovalProcessID = APApprovalProcessID;
                    aPForwardInfoEntity.APMemberFeedbackRemarksID = aPMemberFeedbackRemarksID;
                    aPForwardInfoEntity.DepartmentID = aPPanelForwardMemberEntity.DepartmentID;
                    aPForwardInfoEntity.EmployeeID = aPPanelForwardMemberEntity.EmployeeID;
                    aPForwardInfoEntity.CommentRequestDate = DateTime.Now;
                    aPForwardInfoEntity.CommentSubmitDate = null;
                    aPForwardInfoEntity.APMemberComment = txtForwardRemarks.Text.Trim();
                    aPForwardInfoEntity.APForwardMemberComment = String.Empty;

                    FCCAPForwardInfo.GetFacadeCreate().Add(aPForwardInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);

                    MiscUtil.ShowMessage(lblMessage, "You have forwarded the thread successfully", UIConstants.MessageType.GREEN);

                    PrepareInitialView();
                    BindList();

                    #region Forwarded Mail

                    String MailBody = String.Empty;
                    String Subject = String.Empty;

                    StringBuilder sb = new StringBuilder();

                    sb.Append("Dear Sir,");
                    sb.Append("<br/>");
                    sb.Append("This is a auto generated mail from the ERP.");
                    sb.Append("<br/>");
                    sb.Append("A Loan Application Request is Forwarded Request is waiting for your approval");
                    sb.Append("<br/>");
                    sb.Append("<br/>");
                    sb.Append("-");
                    sb.Append("<br/>");
                    sb.Append("Thanks");
                    sb.Append("<br/>");
                    sb.Append("ERP System");
                    MailBody = sb.ToString();
                    Subject = "ERP, Loan Application, Forwarded";
                    MailBody = @"Please note that a Bill is Forwarded.-Thanks ERP System";

                    HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(aPForwardInfoEntity.EmployeeID);

                    if (_hREmployeeEntity != null)
                    {
                        String[] sendToMail = new String[] { _hREmployeeEntity.PrimaryEmail };
                        MiscUtil.SendMail(sendToMail, Subject, MailBody);
                    }

                    #endregion


                    //RedirectPageToForwardList();
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to forward", UIConstants.MessageType.RED);
                }
            //}

        }

        protected void btnSubmitComment_Click(object sender, EventArgs e)
        {
            btnSubmitComment.Enabled = false;

            Boolean result = APRobot.UpdateAPForwardInfo(APForwardInfoID, txtComment.Text.Trim());

            if (result == true)
            {
                APRobot.UpdateMemberFeedbackFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.FORWARD_RESPONSE_RECEIVED);

                PrepareInitialView();
                BindList();

                MiscUtil.ShowMessage(lblMessage, "You have submited comments successfully", UIConstants.MessageType.GREEN);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to submit comments", UIConstants.MessageType.RED);
            }
        }

        #endregion

        #endregion Event
    }
}
