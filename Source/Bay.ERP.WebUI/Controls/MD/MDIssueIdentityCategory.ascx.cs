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
    public partial class MDIssueIdentityCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _IssueIdentityCategoryID
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

        public MDIssueIdentityCategoryEntity _MDIssueIdentityCategoryEntity
        {
            get
            {
                MDIssueIdentityCategoryEntity entity = new MDIssueIdentityCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDIssueIdentityCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDIssueIdentityCategoryEntity CurrentMDIssueIdentityCategoryEntity
        {
            get
            {
                if (_IssueIdentityCategoryID > 0)
                {
                    if (_MDIssueIdentityCategoryEntity.IssueIdentityCategoryID != _IssueIdentityCategoryID)
                    {
                        _MDIssueIdentityCategoryEntity = FCCMDIssueIdentityCategory.GetFacadeCreate().GetByID(_IssueIdentityCategoryID);
                    }
                }

                return _MDIssueIdentityCategoryEntity;
            }
            set
            {
                _MDIssueIdentityCategoryEntity = value;
            }
        }

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

            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDIssueIdentityCategoryEntity mDIssueIdentityCategoryEntity = CurrentMDIssueIdentityCategoryEntity;


            if (!mDIssueIdentityCategoryEntity.IsNew)
            {
                txtName.Text = mDIssueIdentityCategoryEntity.Name.ToString();
                txtDescription.Text = mDIssueIdentityCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDIssueIdentityCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDIssueIdentityCategoryList();
        }

        private void BindMDIssueIdentityCategoryList()
        {
            lvMDIssueIdentityCategory.DataBind();
        }

        private MDIssueIdentityCategoryEntity BuildMDIssueIdentityCategoryEntity()
        {
            MDIssueIdentityCategoryEntity mDIssueIdentityCategoryEntity = CurrentMDIssueIdentityCategoryEntity;

            mDIssueIdentityCategoryEntity.Name = txtName.Text.Trim();
            mDIssueIdentityCategoryEntity.Description = txtDescription.Text.Trim();
            mDIssueIdentityCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDIssueIdentityCategoryEntity;
        }

        private void SaveMDIssueIdentityCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDIssueIdentityCategoryEntity mDIssueIdentityCategoryEntity = BuildMDIssueIdentityCategoryEntity();

                    Int64 result = -1;

                    if (mDIssueIdentityCategoryEntity.IsNew)
                    {
                        result = FCCMDIssueIdentityCategory.GetFacadeCreate().Add(mDIssueIdentityCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDIssueIdentityCategoryEntity.FLD_NAME_IssueIdentityCategoryID, mDIssueIdentityCategoryEntity.IssueIdentityCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDIssueIdentityCategory.GetFacadeCreate().Update(mDIssueIdentityCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _IssueIdentityCategoryID = 0;
                        _MDIssueIdentityCategoryEntity = new MDIssueIdentityCategoryEntity();
                        PrepareInitialView();
                        BindMDIssueIdentityCategoryList();

                        if (mDIssueIdentityCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Issue Identity Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Issue Identity Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDIssueIdentityCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Issue Identity Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Issue Identity Category Information.", false);
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

        protected void lvMDIssueIdentityCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 IssueIdentityCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out IssueIdentityCategoryID);

            if (IssueIdentityCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _IssueIdentityCategoryID = IssueIdentityCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDIssueIdentityCategoryEntity.FLD_NAME_IssueIdentityCategoryID, IssueIdentityCategoryID.ToString(), SQLMatchType.Equal);

                        MDIssueIdentityCategoryEntity mDIssueIdentityCategoryEntity = new MDIssueIdentityCategoryEntity();


                        result = FCCMDIssueIdentityCategory.GetFacadeCreate().Delete(mDIssueIdentityCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _IssueIdentityCategoryID = 0;
                            _MDIssueIdentityCategoryEntity = new MDIssueIdentityCategoryEntity();
                            PrepareInitialView();
                            BindMDIssueIdentityCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Issue Identity Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Issue Identity Category.", true);
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

        protected void odsMDIssueIdentityCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDIssueIdentityCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _IssueIdentityCategoryID = 0;
            _MDIssueIdentityCategoryEntity = new MDIssueIdentityCategoryEntity();
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