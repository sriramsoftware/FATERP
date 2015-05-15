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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class OTProjectAdhocIssueControl : BaseControl
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

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDIssueCategoryByIssueIdentityCategory(ddlIssueCategoryID, false, MasterDataConstants.IssueIdentityCategory.PROJECT_ADHOC_ISSUE);
            MiscUtil.PopulateMDIssuePriority(ddlIssuePriorityID, false);
            MiscUtil.PopulateMDIssueStatus(ddlIssueStatusID, false);
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateHREmployee(ddlSupervisorEmployeeID, false);
            MiscUtil.PopulateHREmployee(ddlAssignedToEmployeeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void BindList()
        {
            lvOTIssue.DataBind();
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtTitle.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtCompletionPercentage.Text = "0";
            txtDuration.Text = String.Empty;
            txtExpectedStartDate.Text = System.DateTime.Now.ToString("MM/dd/yyyy hh:mm");
            txtExpectedEndDate.Text = System.DateTime.Now.ToString("MM/dd/yyyy hh:mm");
            txtActualStartDate.Text = String.Empty;
            txtActualEndDate.Text = String.Empty;
            txtNotifyBeforeMin.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            if (ddlSupervisorEmployeeID != null && ddlSupervisorEmployeeID.Items.Count > 0)
            {
                Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                if (employeeID > 0)
                {
                    ddlSupervisorEmployeeID.SelectedValue = employeeID.ToString();
                }
            }

            if (Action == "Edit"
               || Action == "EditDetails")
            {
                pnlComments.Visible = true;
            }
            else
            {
                pnlComments.Visible = false;
            }

            pnlEditMode.Visible = false;

            btnSubmit.Text = "Save";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            OTIssueEntity oTIssueEntity = CurrentOTIssueEntity;

            if (!oTIssueEntity.IsNew)
            {

                if (ddlIssueCategoryID.Items.Count > 0 && oTIssueEntity.IssueCategoryID != null)
                {
                    ddlIssueCategoryID.SelectedValue = oTIssueEntity.IssueCategoryID.ToString();
                }
                txtTitle.Text = oTIssueEntity.Title.ToString();
                txtDescription.Text = oTIssueEntity.Description.ToString();
                if (ddlIssuePriorityID.Items.Count > 0 && oTIssueEntity.IssuePriorityID != null)
                {
                    ddlIssuePriorityID.SelectedValue = oTIssueEntity.IssuePriorityID.ToString();
                }
                txtCompletionPercentage.Text = oTIssueEntity.CompletionPercentage.ToString();
                if (ddlIssueStatusID.Items.Count > 0 && oTIssueEntity.IssueStatusID != null)
                {
                    ddlIssueStatusID.SelectedValue = oTIssueEntity.IssueStatusID.ToString();
                }
                txtDuration.Text = oTIssueEntity.Duration.ToString();
                txtExpectedStartDate.Text = MiscUtil.ConvertDateTSQLStringJQueryUI(DateTime.Parse(oTIssueEntity.ExpectedStartDate.ToString()));
                txtExpectedEndDate.Text = MiscUtil.ConvertDateTSQLStringJQueryUI(DateTime.Parse(oTIssueEntity.ExpectedEndDate.ToString()));

                if (oTIssueEntity.ActualStartDate.HasValue)
                {
                    txtActualStartDate.Text = MiscUtil.ConvertDateTSQLStringJQueryUI(DateTime.Parse(oTIssueEntity.ActualStartDate.ToString()));
                }
                else
                {
                    txtActualStartDate.Text = oTIssueEntity.ActualStartDate.ToStringDefault();
                }

                if (oTIssueEntity.ActualEndDate.HasValue)
                {
                    txtActualEndDate.Text = MiscUtil.ConvertDateTSQLStringJQueryUI(DateTime.Parse(oTIssueEntity.ActualEndDate.ToString()));
                }
                else
                {
                    txtActualEndDate.Text = oTIssueEntity.ActualEndDate.ToStringDefault();
                }

                if (ddlSupervisorEmployeeID.Items.Count > 0 && oTIssueEntity.SupervisorEmployeeID != null)
                {
                    ddlSupervisorEmployeeID.SelectedValue = oTIssueEntity.SupervisorEmployeeID.ToString();
                }

                if (ddlAssignedToEmployeeID.Items.Count > 0 && oTIssueEntity.AssignedToEmployeeID != null)
                {
                    ddlAssignedToEmployeeID.SelectedValue = oTIssueEntity.AssignedToEmployeeID.ToString();
                }

                txtNotifyBeforeMin.Text = oTIssueEntity.NotifyBeforeMin.ToString();
                txtRemarks.Text = oTIssueEntity.Remarks.ToString();

                switch (Action)
                {
                    case "Edit":
                        pnlCreateIssue.Visible = false;
                        pnlEditMode.Visible = true;

                       #region Supervior Panel Visible / Invisible

                        Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                        if (employeeID > 0)
                        {
                            if (employeeID == CurrentOTIssueEntity.SupervisorEmployeeID)
                            {
                                pnlSupervisor.Visible = true;
                            }
                        }

                        else
                        {
                            pnlSupervisor.Visible = false;
                        }

                        #endregion

                        break;
                    case "EditDetails":
                        pnlCreateIssue.Visible = true;
                        pnlEditMode.Visible = false;
                        break;
                    case "ViewIssue":
                        pnlCreateIssue.Visible = true;
                        pnlEditMode.Visible = true;
                        pnlCreateIssue.Enabled = false;
                        pnlEditMode.Enabled = false;
                        pnlCommon.Enabled = false;
                        btnSubmit.Enabled = false;
                        btnClear.Enabled = false;
                        btnAddNew.Enabled = false;
                        txtRemarks.Enabled = false;
                        break;
                }

                pnlCommon.Visible = true;
                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private OTIssueEntity BuildOTIssueEntity()
        {
            OTIssueEntity oTIssueEntity = CurrentOTIssueEntity;

            #region User Input

            if (ddlIssueCategoryID.Items.Count > 0)
            {
                if (ddlIssueCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    oTIssueEntity.IssueCategoryID = Int64.Parse(ddlIssueCategoryID.SelectedValue);
                }
            }

            oTIssueEntity.Title = txtTitle.Text.Trim();
            oTIssueEntity.Description = txtDescription.Text.Trim();
            if (ddlIssuePriorityID.Items.Count > 0)
            {
                if (ddlIssuePriorityID.SelectedValue == "0")
                {
                }
                else
                {
                    oTIssueEntity.IssuePriorityID = Int64.Parse(ddlIssuePriorityID.SelectedValue);
                }
            }

            if (!txtCompletionPercentage.Text.Trim().IsNullOrEmpty())
            {
                oTIssueEntity.CompletionPercentage = Decimal.Parse(txtCompletionPercentage.Text.Trim());
            }
            else
            {
                oTIssueEntity.CompletionPercentage = 0;
            }

            if (ddlIssueStatusID.Items.Count > 0)
            {
                if (ddlIssueStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    oTIssueEntity.IssueStatusID = Int64.Parse(ddlIssueStatusID.SelectedValue);
                }
            }

            if (!txtDuration.Text.Trim().IsNullOrEmpty())
            {
                oTIssueEntity.Duration = Decimal.Parse(txtDuration.Text.Trim());
            }
            else
            {
                oTIssueEntity.Duration = null;
            }

            if (txtExpectedStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                oTIssueEntity.ExpectedStartDate = MiscUtil.ParseToDateTimeJQueryUI(txtExpectedStartDate.Text);
            }
            else
            {
                oTIssueEntity.ExpectedStartDate = null;
            }

            if (txtExpectedEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                oTIssueEntity.ExpectedEndDate = MiscUtil.ParseToDateTimeJQueryUI(txtExpectedEndDate.Text);
            }
            else
            {
                oTIssueEntity.ExpectedEndDate = null;
            }

            if (txtActualStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                oTIssueEntity.ActualStartDate = MiscUtil.ParseToDateTimeJQueryUI(txtActualStartDate.Text);
            }
            else
            {
                oTIssueEntity.ActualStartDate = oTIssueEntity.ExpectedStartDate;
            }

            if (txtActualEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                oTIssueEntity.ActualEndDate = MiscUtil.ParseToDateTimeJQueryUI(txtActualEndDate.Text);
            }
            else
            {
                oTIssueEntity.ActualEndDate = oTIssueEntity.ExpectedEndDate;
            }

            if (!txtNotifyBeforeMin.Text.Trim().IsNullOrEmpty())
            {
                oTIssueEntity.NotifyBeforeMin = Int32.Parse(txtNotifyBeforeMin.Text.Trim());
            }
            else
            {
                oTIssueEntity.NotifyBeforeMin = null;
            }

            if (ddlSupervisorEmployeeID.Items.Count > 0)
            {
                if (ddlSupervisorEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    oTIssueEntity.SupervisorEmployeeID = Int64.Parse(ddlSupervisorEmployeeID.SelectedValue);
                }
            }

            if (ddlAssignedToEmployeeID.Items.Count > 0)
            {
                if (ddlAssignedToEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    oTIssueEntity.AssignedToEmployeeID = Int64.Parse(ddlAssignedToEmployeeID.SelectedValue);
                }
            }

            oTIssueEntity.SupervisorAgreed = true;
            oTIssueEntity.ModifiedBySupervisorDateTime = System.DateTime.Now;

            oTIssueEntity.IP = MiscUtil.GetLocalIP();
            oTIssueEntity.Remarks = txtRemarks.Text.Trim();

            #endregion User Input

            #region Manual Input

            if (oTIssueEntity.IsNew)
            {
                oTIssueEntity.IssueIdentityCategoryID = MasterDataConstants.IssueIdentityCategory.PROJECT_ADHOC_ISSUE;
                oTIssueEntity.CreatedByMemberID = this.CurrentMember.MemberID;
                oTIssueEntity.CreateDate = DateTime.Now;
                oTIssueEntity.IsNotifyCompleted = false;
                oTIssueEntity.IsRemoved = false;

                oTIssueEntity.ParentIssueID = null;
                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                    }
                    else
                    {
                        oTIssueEntity.ReferenceID = Int64.Parse(ddlProjectID.SelectedValue);
                    }
                }
             
                oTIssueEntity.ReferenceIssueID = null;
            }

            if (Action == "AddSubIssue")
            {
                oTIssueEntity.ParentIssueID = _ParentIssueID;
            }
            else if (Action == "AddReferenceIssue")
            {
                oTIssueEntity.ReferenceIssueID = _ReferenceIssueID;
            }

            #endregion Manual Input

            return oTIssueEntity;
        }

        private void SaveOTIssueEntity()
        {
            if (IsValid)
            {
                try
                {
                    OTIssueEntity oTIssueEntity = BuildOTIssueEntity();

                    Int64 result = -1;

                    if (oTIssueEntity.IsNew)
                    {
                        result = FCCOTIssue.GetFacadeCreate().Add(oTIssueEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueID, oTIssueEntity.IssueID.ToString(), SQLMatchType.Equal);
                        result = FCCOTIssue.GetFacadeCreate().Update(oTIssueEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        if (oTIssueEntity.IsNew)
                        {

                            #region Send Notification
                           
                            String mailSubject = String.Empty;
                            String mailBody = String.Empty;
                            String[] mailTo = new String[1];
                            String fe = SqlExpressionBuilder.PrepareFilterExpression("OTIssue." + OTIssueEntity.FLD_NAME_IssueID, result.ToString(), SQLMatchType.Equal);
                            IList<OTIssue_DetailedEntity> lstOTIssueEntity = FCCOTIssue_Detailed.GetFacadeCreate().GetIL(10000,1,String.Empty,fe);

                            if (lstOTIssueEntity != null && lstOTIssueEntity.Count>0)
                            {
                                mailSubject = lstOTIssueEntity[0].Title.ToString() + "-" + lstOTIssueEntity[0].SupervisorFullName ;
                                mailBody = lstOTIssueEntity[0].Description.ToString();
                                mailBody += "<br/>";
                                mailBody += "<br/>";
                                mailBody += "Expected Start Date: " + lstOTIssueEntity[0].ExpectedStartDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                                mailBody += "<br/>";
                                mailBody += "Expected End Date: " + lstOTIssueEntity[0].ExpectedEndDate.ToString(UIConstants.SHORT_DATE_FORMAT);

                                HREmployeeEntity hREmployeeEntitiy = FCCHREmployee.GetFacadeCreate().GetByID(lstOTIssueEntity[0].AssignedToEmployeeID);

                                if (hREmployeeEntitiy != null && hREmployeeEntitiy.EmployeeID > 0)
                                {
                                    mailTo[0] =hREmployeeEntitiy.PrimaryEmail;
                                    MiscUtil.SendMail(mailTo, mailSubject, mailBody);
                                }
                            }

                            #endregion

                            _IssueID = 0;
                            _OTIssueEntity = new OTIssueEntity();
                            PrepareInitialView();

                            MiscUtil.ShowMessage(lblMessage, "Issue Information has been added successfully.", false);

                            String NavigationUrl = UrlHelper.BuildSecureUrl("~/OT/OTIssueAssignedResource.aspx", string.Empty, UrlConstants.OVERVIEW_ISSUE_ID, result.ToString()).ToString();
                            Response.Redirect(NavigationUrl);
                        }
                        else
                        {
                            PrepareInitialView();
                            PrepareEditView();

                            MiscUtil.ShowMessage(lblMessage, "Issue Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (oTIssueEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Issue Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Issue Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void BindCMNERPCommentList()
        {
            lvCMNERPComment.DataBind();
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

        #region List View Event

        protected void lvOTIssue_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                OTIssueEntity ent = (OTIssueEntity)dataItem.DataItem;

                HyperLink hypIssueReport = (HyperLink)e.Item.FindControl("hypIssueReport");
                hypIssueReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.ISSUE_REPORT, UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();

                hypIssueReport.Target = "_blank";
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsOTIssue_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueIdentityCategoryID, MasterDataConstants.IssueIdentityCategory.PROJECT_ADHOC_ISSUE.ToString(), SQLMatchType.Equal);

            if (ddlProjectID.SelectedValue != "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_ReferenceID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_CreatedByMemberID, CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region ObjectDataSource Event

        protected void odsCMNERPComment_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CMNERPComment." + CMNERPCommentEntity.FLD_NAME_ProcessCategoryID, "0", SQLMatchType.Equal);
            if (Action == "Edit"
                || Action == "EditDetails")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("CMNERPComment." + CMNERPCommentEntity.FLD_NAME_ProcessCategoryID, MasterDataConstants.CMNProcessCategory.ISSUE_AND_TASK.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("CMNERPComment." + CMNERPCommentEntity.FLD_NAME_ReferenceID, _IssueID.ToString(), SQLMatchType.Equal);

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSavePost_Click(object sender, EventArgs e)
        {
            Int64 result = -1;
            result = ERPCommentEngine.CreateComment(MasterDataConstants.CMNProcessCategory.ISSUE_AND_TASK, _IssueID, txtComment.Text.Trim().ToString(), MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember));
            if (result > 0)
            {
                txtComment.Text = String.Empty;
                BindCMNERPCommentList();


                MiscUtil.ShowMessage(lblMessage, "Comment Information has been added successfully.", false);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Fail to save Information.", true);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveOTIssueEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/OT/OTIssueEditor.aspx");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnAgree_Click(object sender, EventArgs e)
        {
            try
            {
                OTIssueEntity oTIssueEntity = CurrentOTIssueEntity;

                oTIssueEntity.SupervisorAgreed = true;

                Int64 result = -1;

                String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueID, _IssueID.ToString(), SQLMatchType.Equal);

                result = FCCOTIssue.GetFacadeCreate().Update(oTIssueEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                if (result > 0)
                {
                    MiscUtil.ShowMessage(lblMessage, "Issue has been successfully Updated.", true);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to Update Issue.", true);
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            }
        }

        protected void Disagree_Click(object sender, EventArgs e)
        {
            try
            {
                OTIssueEntity oTIssueEntity = CurrentOTIssueEntity;

                oTIssueEntity.SupervisorAgreed = false;

                Int64 result = -1;

                String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueID, _IssueID.ToString(), SQLMatchType.Equal);

                result = FCCOTIssue.GetFacadeCreate().Update(oTIssueEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                if (result > 0)
                {
                    MiscUtil.ShowMessage(lblMessage, "Issue has been successfully Updated.", true);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to Update Issue.", true);
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            }
        }

        #endregion

        #region Dropdown Event

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProjectID.SelectedValue != "0")
            {
                BindList();
            }
        }

        protected void txtExpectedEndDate_TextChanged(object sender, EventArgs e)
        {
            Double diffDate = (MiscUtil.ParseToDateTimeJQueryUI(txtExpectedEndDate.Text)- MiscUtil.ParseToDateTimeJQueryUI(txtExpectedStartDate.Text)).TotalDays;

            txtDuration.Text = Math.Ceiling((diffDate -diffDate / 7)).ToString();

          //  MiscUtil.ShowMessage(lblMessage, diffDate.ToString(), false);
        }

        #endregion

        #endregion Event
    }
}
