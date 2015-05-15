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
    public partial class HREmployeeLeaveApplicationWithApprovalControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeLeaveApplicationID
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

        public HREmployeeLeaveApplicationEntity _HREmployeeLeaveApplicationEntity
        {
            get
            {
                HREmployeeLeaveApplicationEntity entity = new HREmployeeLeaveApplicationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeLeaveApplicationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeLeaveApplicationEntity CurrentHREmployeeLeaveApplicationEntity
        {
            get
            {
                if (OverviewLeaveApplicationID > 0)
                {
                    _HREmployeeLeaveApplicationEntity = FCCHREmployeeLeaveApplication.GetFacadeCreate().GetByID(OverviewLeaveApplicationID);
                }

                return _HREmployeeLeaveApplicationEntity;
            }
            set
            {
                _HREmployeeLeaveApplicationEntity = value;
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

        public Int64 OverviewLeaveApplicationID
        {
            get
            {
                Int64 overviewLeaveApplicationID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_LEAVE_APPLICATION_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_LEAVE_APPLICATION_ID], out overviewLeaveApplicationID);
                }

                return overviewLeaveApplicationID;
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
                ddlForwardTo.DataSource = APRobot.GetAPPanelForwardMemberByApprovalProcessTypeAndReferenceID(MasterDataConstants.APType.LEAVE_APPLICATION, OverviewLeaveApplicationID);
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
            MiscUtil.PopulateHREmployee(ddlBackupEmployeeID, true);
            MiscUtil.PopulateMDLeaveCategory(ddlLeaveCategoryID, false);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, true);

            BuildDropDownListAP();
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtApplicationDate.Text = String.Empty;
            txtRequestStartDate.Text = String.Empty;
            txtRequestEndDate.Text = String.Empty;
            txtTotalLeaveDays.Text = String.Empty;
            //txtDescription.Text = String.Empty;

            btnSubmit.Text = "Update";

            #region Approval

            lvAPMemberFeedbackRemarks.DataSource = APRobot.GetMemberFeedbackRemarks_DetailedByApprovalProcessID(APApprovalProcessID);
            lvAPMemberFeedbackRemarks.DataBind();

            EnableDisableApprovalButtons();

            #endregion
        }

        private void PrepareEditView()
        {
            HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity = CurrentHREmployeeLeaveApplicationEntity;


            if (!hREmployeeLeaveApplicationEntity.IsNew)
            {
                
                txtApplicationDate.Text = hREmployeeLeaveApplicationEntity.ApplicationDate.ToStringDefault();
                txtRequestStartDate.Text = hREmployeeLeaveApplicationEntity.RequestStartDate.ToStringDefault();
                txtRequestEndDate.Text = hREmployeeLeaveApplicationEntity.RequestEndDate.ToStringDefault();
                txtTotalLeaveDays.Text = hREmployeeLeaveApplicationEntity.TotalLeaveDays.ToString();
                //txtDescription.Text = hREmployeeLeaveApplicationEntity.Description.ToString();
                if (ddlBackupEmployeeID.Items.Count > 0 && hREmployeeLeaveApplicationEntity.BackupEmployeeID != null)
                {
                    ddlBackupEmployeeID.SelectedValue = hREmployeeLeaveApplicationEntity.BackupEmployeeID.ToString();
                }

                if (ddlLeaveCategoryID.Items.Count > 0 && hREmployeeLeaveApplicationEntity.LeaveCategoryID != null)
                {
                    ddlLeaveCategoryID.SelectedValue = hREmployeeLeaveApplicationEntity.LeaveCategoryID.ToString();
                }

                if (ddlEmployeeID.Items.Count > 0 && hREmployeeLeaveApplicationEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = hREmployeeLeaveApplicationEntity.EmployeeID.ToString();
                }

                if (ddlLeavePurpose.Items.Count > 0 && hREmployeeLeaveApplicationEntity.Description != null)
                {
                    ddlLeavePurpose.SelectedValue = hREmployeeLeaveApplicationEntity.Description.ToString();
                }

                if (ddlLeaveLocation.Items.Count > 0 && hREmployeeLeaveApplicationEntity.LeaveLocation!= null)
                {
                    ddlLeaveLocation.SelectedValue = hREmployeeLeaveApplicationEntity.LeaveLocation.ToString();
                }

                //if (ddlLeaveApplicationApplicationStatusID.Items.Count > 0 && hREmployeeLeaveApplicationEntity.LeaveApplicationApplicationStatusID != null)
                //{
                //    ddlLeaveApplicationApplicationStatusID.SelectedValue = hREmployeeLeaveApplicationEntity.LeaveApplicationApplicationStatusID.ToString();
                //}


                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindHREmployeeLeaveApplicationList();
        }

        private void BindHREmployeeLeaveApplicationList()
        {
           
        }

        private HREmployeeLeaveApplicationEntity BuildHREmployeeLeaveApplicationEntity()
        {
            HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity = CurrentHREmployeeLeaveApplicationEntity;

            if (txtApplicationDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeLeaveApplicationEntity.ApplicationDate = MiscUtil.ParseToDateTime(txtApplicationDate.Text);
            }

            if (txtRequestStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeLeaveApplicationEntity.RequestStartDate = MiscUtil.ParseToDateTime(txtRequestStartDate.Text);
            }

            if (txtRequestEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeLeaveApplicationEntity.RequestEndDate = MiscUtil.ParseToDateTime(txtRequestEndDate.Text);
            }

            if (!txtTotalLeaveDays.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeLeaveApplicationEntity.TotalLeaveDays = Decimal.Parse(txtTotalLeaveDays.Text.Trim());
            }

            //hREmployeeLeaveApplicationEntity.Description = txtDescription.Text.Trim();
            if (ddlBackupEmployeeID.Items.Count > 0)
            {
                if (ddlBackupEmployeeID.SelectedValue == "0")
                {
                    hREmployeeLeaveApplicationEntity.BackupEmployeeID = null;
                }
                else
                {
                    hREmployeeLeaveApplicationEntity.BackupEmployeeID = Int64.Parse(ddlBackupEmployeeID.SelectedValue);
                }
            }

            if (ddlLeaveCategoryID.Items.Count > 0)
            {
                if (ddlLeaveCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeLeaveApplicationEntity.LeaveCategoryID = Int64.Parse(ddlLeaveCategoryID.SelectedValue);
                }
            }

            if (ddlLeavePurpose.Items.Count > 0)
            {
                if (ddlLeavePurpose.SelectedValue == "0")
                {
                    hREmployeeLeaveApplicationEntity.Description = null;
                }
                else
                {
                    hREmployeeLeaveApplicationEntity.Description = ddlLeavePurpose.SelectedValue;
                }
            }

            if (ddlLeaveLocation.Items.Count > 0)
            {
                if (ddlLeaveLocation.SelectedValue == "0")
                {
                    hREmployeeLeaveApplicationEntity.LeaveLocation = null;
                }
                else
                {
                    hREmployeeLeaveApplicationEntity.LeaveLocation = ddlLeaveLocation.SelectedValue;
                }
            }


            return hREmployeeLeaveApplicationEntity;
        }

        private void SaveHREmployeeLeaveApplicationEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity = BuildHREmployeeLeaveApplicationEntity();

                    Int64 result = -1;

                    if (hREmployeeLeaveApplicationEntity.IsNew)
                    {
                        result = FCCHREmployeeLeaveApplication.GetFacadeCreate().Add(hREmployeeLeaveApplicationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLeaveApplicationEntity.FLD_NAME_EmployeeLeaveApplicationID, hREmployeeLeaveApplicationEntity.EmployeeLeaveApplicationID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeLeaveApplication.GetFacadeCreate().Update(hREmployeeLeaveApplicationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        
                    }

                    if (result > 0)
                    {
                        _EmployeeLeaveApplicationID = result;
                        _HREmployeeLeaveApplicationEntity = CurrentHREmployeeLeaveApplicationEntity;
                        PrepareEditView();
                        BindHREmployeeLeaveApplicationList();

                        if (hREmployeeLeaveApplicationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Leave Application Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Leave Application Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeLeaveApplicationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Leave Application Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Leave Application Information.", false);
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

        protected void lvLeaveStatus_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;
                Label lblCasualLeaveEarned = (Label)e.Item.FindControl("lblCasualLeaveEarned");
                Label lblCasualLeaveEnjoyed = (Label)e.Item.FindControl("lblCasualLeaveEnjoyed");
                Label lblCasualleaveBalance = (Label)e.Item.FindControl("lblCasualleaveBalance");
                Label lblMedicalLeaveEarned = (Label)e.Item.FindControl("lblMedicalLeaveEarned");
                Label lblMedicalLeaveEnjoyed = (Label)e.Item.FindControl("lblMedicalLeaveEnjoyed");
                Label lblMedicalLeaveBalance = (Label)e.Item.FindControl("lblMedicalLeaveBalance");
                Label lblEarnLeaveEarned = (Label)e.Item.FindControl("lblEarnLeaveEarned");
                Label lblEarnLeaveEnjoyed = (Label)e.Item.FindControl("lblEarnLeaveEnjoyed");
                Label lblEarnLeaveBalance = (Label)e.Item.FindControl("lblEarnLeaveBalance");
                Label lblLWPLeaveEarned = (Label)e.Item.FindControl("lblLWPLeaveEarned");
                Label lblLWPLeaveEnjoyed = (Label)e.Item.FindControl("lblLWPLeaveEnjoyed");
                Label lblLWPLeaveBalance = (Label)e.Item.FindControl("lblLWPLeaveBalance");
                Label lblTotalLeaveEnjoyed = (Label)e.Item.FindControl("lblTotalLeaveEnjoyed");

                if (lblCasualLeaveEarned.Text == String.Empty)
                {
                    lblCasualLeaveEarned.Text = "0";
                }

                if (lblCasualLeaveEnjoyed.Text == String.Empty)
                {
                    lblCasualLeaveEnjoyed.Text = "0";
                }

                if (lblMedicalLeaveEarned.Text == String.Empty)
                {
                    lblMedicalLeaveEarned.Text = "0";
                }

                if (lblMedicalLeaveEnjoyed.Text == String.Empty)
                {
                    lblMedicalLeaveEnjoyed.Text = "0";
                }

                if (lblEarnLeaveEarned.Text == String.Empty)
                {
                    lblEarnLeaveEarned.Text = "0";
                }

                if (lblEarnLeaveEnjoyed.Text == String.Empty)
                {
                    lblEarnLeaveEnjoyed.Text = "0";
                }

                if (lblLWPLeaveEarned.Text == String.Empty)
                {
                    lblLWPLeaveEarned.Text = "0";
                }

                if (lblLWPLeaveEnjoyed.Text == String.Empty)
                {
                    lblLWPLeaveEnjoyed.Text = "0";
                }

                lblCasualleaveBalance.Text = (Decimal.Parse(lblCasualLeaveEarned.Text) - Decimal.Parse(lblCasualLeaveEnjoyed.Text)).ToString();
                lblMedicalLeaveBalance.Text = (Decimal.Parse(lblMedicalLeaveEarned.Text) - Decimal.Parse(lblMedicalLeaveEnjoyed.Text)).ToString();
                lblEarnLeaveBalance.Text = (Decimal.Parse(lblEarnLeaveEarned.Text) - Decimal.Parse(lblEarnLeaveEnjoyed.Text)).ToString();
                lblLWPLeaveBalance.Text = (Decimal.Parse(lblLWPLeaveEarned.Text) - Decimal.Parse(lblLWPLeaveEnjoyed.Text)).ToString();

                lblTotalLeaveEnjoyed.Text = (Decimal.Parse(lblCasualLeaveEnjoyed.Text) + Decimal.Parse(lblMedicalLeaveEnjoyed.Text) + Decimal.Parse(lblEarnLeaveEnjoyed.Text) + Decimal.Parse(lblLWPLeaveEnjoyed.Text)).ToString().Trim();
            }
        }

        protected void lvOTIssue_Detailed_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                OTIssue_DetailedEntity ent = (OTIssue_DetailedEntity)dataItem.DataItem;

                Label lblIssuePriorityNameLV = (Label)e.Item.FindControl("lblIssuePriorityNameLV");
                Label lblExpectedEndDateLV = (Label)e.Item.FindControl("lblExpectedEndDateLV");
                Label lblSupervisorAgreedLV = (Label)e.Item.FindControl("lblSupervisorAgreedLV");

                if (ent.IssuePriorityID == MasterDataConstants.MDIssuePriority.CRITICAL && ent.IssueStatusID != MasterDataConstants.MDIssueStatus.COMPLETED)
                {
                    lblIssuePriorityNameLV.ForeColor = System.Drawing.Color.Red;
                }

                if (ent.IssueStatusID != MasterDataConstants.MDIssueStatus.COMPLETED && ent.ExpectedEndDate < System.DateTime.Now)
                {
                    lblExpectedEndDateLV.ForeColor = System.Drawing.Color.Red;
                }

                if (ent.SupervisorAgreed == false)
                {
                    lblSupervisorAgreedLV.ForeColor = System.Drawing.Color.Red;
                }

                HyperLink hypEdit = (HyperLink)e.Item.FindControl("hypEdit");
                HyperLink hypEditDetails = (HyperLink)e.Item.FindControl("hypEditDetails");
                HyperLink hypAddSubIssue = (HyperLink)e.Item.FindControl("hypAddSubIssue");
                HyperLink hypAddReferenceIssue = (HyperLink)e.Item.FindControl("hypAddReferenceIssue");

                HyperLink hypIssueReport = (HyperLink)e.Item.FindControl("hypIssueReport");
                Button btnCompletedLV = (Button)e.Item.FindControl("btnCompletedLV");
                LinkButton lnkBtnDelete = (LinkButton)e.Item.FindControl("lnkBtnDelete");

            }
        }

        #endregion

        #region ObjectDataSource Event

        protected void odsLeaveStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = "" + CurrentHREmployeeLeaveApplicationEntity.EmployeeID + "";

            e.InputParameters["filterExpression"] = fe;
        }

        protected void odsOTIssue_Detailed_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
            String fe2 = "OTIssue.AssignedToEmployeeID = " + CurrentHREmployeeLeaveApplicationEntity.EmployeeID + " and ( OTIssue.ExpectedStartDate >= '" + MiscUtil.ParseToDateTime(txtRequestStartDate.Text) + "' and  OTIssue.ExpectedEndDate <='" + MiscUtil.ParseToDateTime(txtRequestEndDate.Text) + "' or OTIssue.ExpectedEndDate >= '" + MiscUtil.ParseToDateTime(txtRequestStartDate.Text) + "' and OTIssue.ExpectedStartDate <='" + MiscUtil.ParseToDateTime(txtRequestEndDate.Text) + "')";
            fe = fe2;
            //fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe_assignToEmployee);

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeLeaveApplicationEntity();
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            btnApprove.Enabled = false;

            APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.LEAVE_APPLICATION, OverviewLeaveApplicationID);

            String remarks = txtRemarks.Text.Trim();

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
                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.LEAVE_APPLICATION, OverviewLeaveApplicationID);
            }
            else
            {
                Int64 rejectToAPMemberFeedbackID = Int64.Parse(ddlRejectTo.SelectedValue);

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.LEAVE_APPLICATION, OverviewLeaveApplicationID, rejectToAPMemberFeedbackID);
            }

            String remarks = txtRemarks.Text.Trim();

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

                String remarks = txtRemarks.Text.Trim();

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
