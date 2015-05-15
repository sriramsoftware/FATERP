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

namespace Bay.ERP.Web.UI
{
    public partial class OTIssueEditorControl : IssueBaseControl
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
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtTitle.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtCompletionPercentage.Text = String.Empty;
            txtDuration.Text = String.Empty;
            txtExpectedStartDate.Text = String.Empty;
            txtExpectedEndDate.Text = String.Empty;
            txtActualStartDate.Text = String.Empty;
            txtActualEndDate.Text = String.Empty;
            txtNotifyBeforeMin.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            
            btnSubmit.Text = "Add";
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
                txtExpectedStartDate.Text = oTIssueEntity.ExpectedStartDate.ToStringDefault();
                txtExpectedEndDate.Text = oTIssueEntity.ExpectedEndDate.ToStringDefault();
                txtActualStartDate.Text = oTIssueEntity.ActualStartDate.ToStringDefault();
                txtActualEndDate.Text = oTIssueEntity.ActualEndDate.ToStringDefault();
                txtNotifyBeforeMin.Text = oTIssueEntity.NotifyBeforeMin.ToString();
                txtRemarks.Text = oTIssueEntity.Remarks.ToString();

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
                oTIssueEntity.ExpectedStartDate = MiscUtil.ParseToDateTime(txtExpectedStartDate.Text);
            }
            else
            {
                oTIssueEntity.ExpectedStartDate = null;
            }

            if (txtExpectedEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                oTIssueEntity.ExpectedEndDate = MiscUtil.ParseToDateTime(txtExpectedEndDate.Text);
            }
            else
            {
                oTIssueEntity.ExpectedEndDate = null;
            }

            if (txtActualStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                oTIssueEntity.ActualStartDate = MiscUtil.ParseToDateTime(txtActualStartDate.Text);
            }
            else
            {
                oTIssueEntity.ActualStartDate = null;
            }

            if (txtActualEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                oTIssueEntity.ActualEndDate = MiscUtil.ParseToDateTime(txtActualEndDate.Text);
            }
            else
            {
                oTIssueEntity.ActualEndDate = null;
            }

            if (!txtNotifyBeforeMin.Text.Trim().IsNullOrEmpty())
            {
                oTIssueEntity.NotifyBeforeMin = Int32.Parse(txtNotifyBeforeMin.Text.Trim());
            }
            else
            {
                oTIssueEntity.NotifyBeforeMin = null;
            }

            oTIssueEntity.Remarks = txtRemarks.Text.Trim();
            
            #endregion User Input

            #region Manual Input

            if (oTIssueEntity.IsNew)
            {
                oTIssueEntity.IssueIdentityCategoryID = MasterDataConstants.IssueIdentityCategory.PROJECT_TASK;
                oTIssueEntity.CreatedByMemberID = this.CurrentMember.MemberID;
                oTIssueEntity.CreateDate = DateTime.Now;
                oTIssueEntity.IsNotifyCompleted = false;
                oTIssueEntity.IsRemoved = false;

                oTIssueEntity.ParentIssueID = null;
                oTIssueEntity.ReferenceID = null;
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
                            _IssueID = 0;
                            _OTIssueEntity = new OTIssueEntity();
                            PrepareInitialView();

                            MiscUtil.ShowMessage(lblMessage, "Issue Information has been added successfully.", false);
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
        
        #region Button Event

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

        #endregion

        #endregion Event
    }
}
