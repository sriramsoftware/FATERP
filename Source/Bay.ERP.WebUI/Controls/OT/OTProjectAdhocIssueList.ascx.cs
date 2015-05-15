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
    public partial class OTProjectAdhocIssueListControl : BaseControl
    {       
        #region Properties

        public Int64 _IssueID
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
            //MiscUtil.PopulateMDIssueIdentityCategory(ddlIssueIdentityCategoryID, false);
            //MiscUtil.PopulateMDIssueCategory(ddlIssueCategoryID, false);
            //MiscUtil.PopulateOTIssue(ddlParentIssueID, true);
            //MiscUtil.PopulateMDIssuePriority(ddlIssuePriorityID, false);
            //MiscUtil.PopulateMDIssueStatus(ddlIssueStatusID, false);
            //MiscUtil.PopulateHRMember(ddlCreatedByMemberID, false);
            //MiscUtil.PopulateOTIssue(ddlReferenceIssueID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            //txtReferenceID.Text = String.Empty;
            //txtTitle.Text = String.Empty;
            //txtDescription.Text = String.Empty;
            //txtCompletionPercentage.Text = String.Empty;
            //txtCreateDate.Text = String.Empty;
            //txtDuration.Text = String.Empty;
            //txtExpectedStartDate.Text = String.Empty;
            //txtExpectedEndDate.Text = String.Empty;
            //txtActualStartDate.Text = String.Empty;
            //txtActualEndDate.Text = String.Empty;
            //txtNotifyBeforeMin.Text = String.Empty;
            //chkIsNotifyCompleted.Checked = false;
            //txtRemarks.Text = String.Empty;
            //chkIsRemoved.Checked = false;

            //btnSubmit.Text = "Add";
            //btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            OTIssueEntity oTIssueEntity = CurrentOTIssueEntity;


            //if (!oTIssueEntity.IsNew)
            //{
            //    if (ddlIssueIdentityCategoryID.Items.Count > 0 && oTIssueEntity.IssueIdentityCategoryID != null)
            //    {
            //        ddlIssueIdentityCategoryID.SelectedValue = oTIssueEntity.IssueIdentityCategoryID.ToString();
            //    }

            //    if (ddlIssueCategoryID.Items.Count > 0 && oTIssueEntity.IssueCategoryID != null)
            //    {
            //        ddlIssueCategoryID.SelectedValue = oTIssueEntity.IssueCategoryID.ToString();
            //    }

            //    if (ddlParentIssueID.Items.Count > 0 && oTIssueEntity.ParentIssueID != null)
            //    {
            //        ddlParentIssueID.SelectedValue = oTIssueEntity.ParentIssueID.ToString();
            //    }

            //    txtReferenceID.Text = oTIssueEntity.ReferenceID.ToString();
            //    txtTitle.Text = oTIssueEntity.Title.ToString();
            //    txtDescription.Text = oTIssueEntity.Description.ToString();
            //    if (ddlIssuePriorityID.Items.Count > 0 && oTIssueEntity.IssuePriorityID != null)
            //    {
            //        ddlIssuePriorityID.SelectedValue = oTIssueEntity.IssuePriorityID.ToString();
            //    }

            //    txtCompletionPercentage.Text = oTIssueEntity.CompletionPercentage.ToString();
            //    if (ddlIssueStatusID.Items.Count > 0 && oTIssueEntity.IssueStatusID != null)
            //    {
            //        ddlIssueStatusID.SelectedValue = oTIssueEntity.IssueStatusID.ToString();
            //    }

            //    if (ddlCreatedByMemberID.Items.Count > 0 && oTIssueEntity.CreatedByMemberID != null)
            //    {
            //        ddlCreatedByMemberID.SelectedValue = oTIssueEntity.CreatedByMemberID.ToString();
            //    }

            //    txtCreateDate.Text = oTIssueEntity.CreateDate.ToStringDefault();
            //    txtDuration.Text = oTIssueEntity.Duration.ToString();
            //    txtExpectedStartDate.Text = oTIssueEntity.ExpectedStartDate.ToStringDefault();
            //    txtExpectedEndDate.Text = oTIssueEntity.ExpectedEndDate.ToStringDefault();
            //    txtActualStartDate.Text = oTIssueEntity.ActualStartDate.ToStringDefault();
            //    txtActualEndDate.Text = oTIssueEntity.ActualEndDate.ToStringDefault();
            //    txtNotifyBeforeMin.Text = oTIssueEntity.NotifyBeforeMin.ToString();
            //    chkIsNotifyCompleted.Checked = oTIssueEntity.IsNotifyCompleted;
            //    txtRemarks.Text = oTIssueEntity.Remarks.ToString();
            //    if (ddlReferenceIssueID.Items.Count > 0 && oTIssueEntity.ReferenceIssueID != null)
            //    {
            //        ddlReferenceIssueID.SelectedValue = oTIssueEntity.ReferenceIssueID.ToString();
            //    }

            //    chkIsRemoved.Checked = oTIssueEntity.IsRemoved;

            //    btnSubmit.Text = "Update";
            //    btnAddNew.Visible = true;
            //}
        }

        private void BindList()
        {
            BindOTIssueList();
        }

        private void BindOTIssueList()
        {
            lvOTIssue_Detailed.DataBind();
        }

        private OTIssueEntity BuildOTIssueEntity()
        {
            OTIssueEntity oTIssueEntity = CurrentOTIssueEntity;

            //if (ddlIssueIdentityCategoryID.Items.Count > 0)
            //{
            //    if (ddlIssueIdentityCategoryID.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        oTIssueEntity.IssueIdentityCategoryID = Int64.Parse(ddlIssueIdentityCategoryID.SelectedValue);
            //    }
            //}

            //if (ddlIssueCategoryID.Items.Count > 0)
            //{
            //    if (ddlIssueCategoryID.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        oTIssueEntity.IssueCategoryID = Int64.Parse(ddlIssueCategoryID.SelectedValue);
            //    }
            //}

            //if (ddlParentIssueID.Items.Count > 0)
            //{
            //    if (ddlParentIssueID.SelectedValue == "0")
            //    {
            //        oTIssueEntity.ParentIssueID = null;
            //    }
            //    else
            //    {
            //        oTIssueEntity.ParentIssueID = Int64.Parse(ddlParentIssueID.SelectedValue);
            //    }
            //}

            //if (!txtReferenceID.Text.Trim().IsNullOrEmpty())
            //{
            //    oTIssueEntity.ReferenceID = Int64.Parse(txtReferenceID.Text.Trim());
            //}
            //else
            //{
            //    oTIssueEntity.ReferenceID = null;
            //}

            //oTIssueEntity.Title = txtTitle.Text.Trim();
            //oTIssueEntity.Description = txtDescription.Text.Trim();
            //if (ddlIssuePriorityID.Items.Count > 0)
            //{
            //    if (ddlIssuePriorityID.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        oTIssueEntity.IssuePriorityID = Int64.Parse(ddlIssuePriorityID.SelectedValue);
            //    }
            //}

            //if (!txtCompletionPercentage.Text.Trim().IsNullOrEmpty())
            //{
            //    oTIssueEntity.CompletionPercentage = Decimal.Parse(txtCompletionPercentage.Text.Trim());
            //}
            //else
            //{
            //    oTIssueEntity.CompletionPercentage = null;
            //}

            //if (ddlIssueStatusID.Items.Count > 0)
            //{
            //    if (ddlIssueStatusID.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        oTIssueEntity.IssueStatusID = Int64.Parse(ddlIssueStatusID.SelectedValue);
            //    }
            //}

            //if (ddlCreatedByMemberID.Items.Count > 0)
            //{
            //    if (ddlCreatedByMemberID.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        oTIssueEntity.CreatedByMemberID = Int64.Parse(ddlCreatedByMemberID.SelectedValue);
            //    }
            //}

            //if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            //{
            //    oTIssueEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            //}
            //else
            //{
            //    oTIssueEntity.CreateDate = null;
            //}

            //if (!txtDuration.Text.Trim().IsNullOrEmpty())
            //{
            //    oTIssueEntity.Duration = Decimal.Parse(txtDuration.Text.Trim());
            //}
            //else
            //{
            //    oTIssueEntity.Duration = null;
            //}

            //if (txtExpectedStartDate.Text.Trim().IsNotNullOrEmpty())
            //{
            //    oTIssueEntity.ExpectedStartDate = MiscUtil.ParseToDateTime(txtExpectedStartDate.Text);
            //}
            //else
            //{
            //    oTIssueEntity.ExpectedStartDate = null;
            //}

            //if (txtExpectedEndDate.Text.Trim().IsNotNullOrEmpty())
            //{
            //    oTIssueEntity.ExpectedEndDate = MiscUtil.ParseToDateTime(txtExpectedEndDate.Text);
            //}
            //else
            //{
            //    oTIssueEntity.ExpectedEndDate = null;
            //}

            //if (txtActualStartDate.Text.Trim().IsNotNullOrEmpty())
            //{
            //    oTIssueEntity.ActualStartDate = MiscUtil.ParseToDateTime(txtActualStartDate.Text);
            //}
            //else
            //{
            //    oTIssueEntity.ActualStartDate = null;
            //}

            //if (txtActualEndDate.Text.Trim().IsNotNullOrEmpty())
            //{
            //    oTIssueEntity.ActualEndDate = MiscUtil.ParseToDateTime(txtActualEndDate.Text);
            //}
            //else
            //{
            //    oTIssueEntity.ActualEndDate = null;
            //}

            //if (!txtNotifyBeforeMin.Text.Trim().IsNullOrEmpty())
            //{
            //    oTIssueEntity.NotifyBeforeMin = Int32.Parse(txtNotifyBeforeMin.Text.Trim());
            //}
            //else
            //{
            //    oTIssueEntity.NotifyBeforeMin = null;
            //}

            //oTIssueEntity.IsNotifyCompleted = chkIsNotifyCompleted.Checked;

            //oTIssueEntity.Remarks = txtRemarks.Text.Trim();
            //if (ddlReferenceIssueID.Items.Count > 0)
            //{
            //    if (ddlReferenceIssueID.SelectedValue == "0")
            //    {
            //        oTIssueEntity.ReferenceIssueID = null;
            //    }
            //    else
            //    {
            //        oTIssueEntity.ReferenceIssueID = Int64.Parse(ddlReferenceIssueID.SelectedValue);
            //    }
            //}

            //oTIssueEntity.IsRemoved = chkIsRemoved.Checked;


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
                        _IssueID = 0;
                        _OTIssueEntity = new OTIssueEntity();
                        PrepareInitialView();
                        BindOTIssueList();

                        if (oTIssueEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "O TIssue Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "O TIssue Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (oTIssueEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add O TIssue Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update O TIssue Information.", false);
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

        #region List View Event

        protected void lvOTIssue_Detailed_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                OTIssue_DetailedEntity ent = (OTIssue_DetailedEntity)dataItem.DataItem;

                HyperLink hypEdit = (HyperLink)e.Item.FindControl("hypEdit");
                HyperLink hypAddSubIssue = (HyperLink)e.Item.FindControl("hypAddSubIssue");
                HyperLink hypAddReferenceIssue = (HyperLink)e.Item.FindControl("hypAddReferenceIssue");
                HyperLink hypAssignedResource = (HyperLink)e.Item.FindControl("hypAssignedResource");
                HyperLink hypIssueReport = (HyperLink)e.Item.FindControl("hypIssueReport");
                hypIssueReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "IssueReport", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                hypAssignedResource.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTIssueAssignedResource.aspx", string.Empty, UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                hypEdit.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTProjectAdhocIssue.aspx", string.Empty, "do", "Edit", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                //hypAddSubIssue.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTIssueEditor.aspx", string.Empty, "do", "AddSubIssue", "ParentIssueID", ent.IssueID.ToString()).ToString();
                //hypAddReferenceIssue.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTIssueEditor.aspx", string.Empty, "do", "AddReferenceIssue", "ReferenceIssueID", ent.IssueID.ToString()).ToString();

                hypIssueReport.Target = "_blank";
                hypEdit.Target = "_blank";
            }
        }

        protected void lvOTIssue_Detailed_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 IssueID;

            Int64.TryParse(e.CommandArgument.ToString(), out IssueID);

            if (IssueID > 0)
            {
                if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueID, IssueID.ToString(), SQLMatchType.Equal);

                        OTIssueEntity oTIssueEntity = new OTIssueEntity();


                        result = FCCOTIssue.GetFacadeCreate().Delete(oTIssueEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _IssueID = 0;
                            _OTIssueEntity = new OTIssueEntity();
                            PrepareInitialView();
                            BindOTIssueList();

                            MiscUtil.ShowMessage(lblMessage, "O TIssue has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete O TIssue.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
                else if (string.Equals(e.CommandName, "AddToSchedule"))
                {
                    try
                    {
                        OTIssueEntity oTIssueEntity = FCCOTIssue.GetFacadeCreate().GetByID(IssueID);

                        OTScheduleEntity oTScheduleEntity = new OTScheduleEntity();

                        //oTScheduleEntity

                        
                        //if (result == 0)
                        //{
                        
                        //    MiscUtil.ShowMessage(lblMessage, "O TIssue has been successfully deleted.", true);
                        //}
                        //else
                        //{
                        //    MiscUtil.ShowMessage(lblMessage, "Failed to delete O TIssue.", true);
                        //}
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsOTIssue_Detailed_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("OTIssue."+OTIssueEntity.FLD_NAME_IssueIdentityCategoryID, MasterDataConstants.IssueIdentityCategory.PROJECT_ADHOC_ISSUE.ToString(), SQLMatchType.Equal);

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveOTIssueEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _IssueID = 0;
            _OTIssueEntity = new OTIssueEntity();
            PrepareInitialView();
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
