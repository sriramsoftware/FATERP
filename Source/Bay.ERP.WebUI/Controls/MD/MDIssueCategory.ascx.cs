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
    public partial class MDIssueCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _IssueCategoryID
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

        public MDIssueCategoryEntity _MDIssueCategoryEntity
        {
            get
            {
                MDIssueCategoryEntity entity = new MDIssueCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDIssueCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDIssueCategoryEntity CurrentMDIssueCategoryEntity
        {
            get
            {
                if (_IssueCategoryID > 0)
                {
                    if (_MDIssueCategoryEntity.IssueCategoryID != _IssueCategoryID)
                    {
                        _MDIssueCategoryEntity = FCCMDIssueCategory.GetFacadeCreate().GetByID(_IssueCategoryID);
                    }
                }

                return _MDIssueCategoryEntity;
            }
            set
            {
                _MDIssueCategoryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDIssueIdentityCategory(ddlIssueIdentityCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDIssueCategoryEntity mDIssueCategoryEntity = CurrentMDIssueCategoryEntity;


            if (!mDIssueCategoryEntity.IsNew)
            {
                if (ddlIssueIdentityCategoryID.Items.Count > 0 && mDIssueCategoryEntity.IssueIdentityCategoryID != null)
                {
                    ddlIssueIdentityCategoryID.SelectedValue = mDIssueCategoryEntity.IssueIdentityCategoryID.ToString();
                }

                txtName.Text = mDIssueCategoryEntity.Name.ToString();
                txtDescription.Text = mDIssueCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDIssueCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDIssueCategoryList();
        }

        private void BindMDIssueCategoryList()
        {
            lvMDIssueCategory.DataBind();
        }

        private MDIssueCategoryEntity BuildMDIssueCategoryEntity()
        {
            MDIssueCategoryEntity mDIssueCategoryEntity = CurrentMDIssueCategoryEntity;

            if (ddlIssueIdentityCategoryID.Items.Count > 0)
            {
                if (ddlIssueIdentityCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    mDIssueCategoryEntity.IssueIdentityCategoryID = Int64.Parse(ddlIssueIdentityCategoryID.SelectedValue);
                }
            }

            mDIssueCategoryEntity.Name = txtName.Text.Trim();
            mDIssueCategoryEntity.Description = txtDescription.Text.Trim();
            mDIssueCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDIssueCategoryEntity;
        }

        private void SaveMDIssueCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDIssueCategoryEntity mDIssueCategoryEntity = BuildMDIssueCategoryEntity();

                    Int64 result = -1;

                    if (mDIssueCategoryEntity.IsNew)
                    {
                        result = FCCMDIssueCategory.GetFacadeCreate().Add(mDIssueCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDIssueCategoryEntity.FLD_NAME_IssueCategoryID, mDIssueCategoryEntity.IssueCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDIssueCategory.GetFacadeCreate().Update(mDIssueCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _IssueCategoryID = 0;
                        _MDIssueCategoryEntity = new MDIssueCategoryEntity();
                        PrepareInitialView();
                        BindMDIssueCategoryList();

                        if (mDIssueCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Issue Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Issue Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDIssueCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Issue Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Issue Category Information.", false);
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

        protected void lvMDIssueCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 IssueCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out IssueCategoryID);

            if (IssueCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _IssueCategoryID = IssueCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDIssueCategoryEntity.FLD_NAME_IssueCategoryID, IssueCategoryID.ToString(), SQLMatchType.Equal);

                        MDIssueCategoryEntity mDIssueCategoryEntity = new MDIssueCategoryEntity();


                        result = FCCMDIssueCategory.GetFacadeCreate().Delete(mDIssueCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _IssueCategoryID = 0;
                            _MDIssueCategoryEntity = new MDIssueCategoryEntity();
                            PrepareInitialView();
                            BindMDIssueCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Issue Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Issue Category.", true);
                        }
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

        protected void odsMDIssueCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDIssueCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _IssueCategoryID = 0;
            _MDIssueCategoryEntity = new MDIssueCategoryEntity();
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
