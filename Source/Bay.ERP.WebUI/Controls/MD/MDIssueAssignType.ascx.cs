// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Mar-2013, 11:29:57




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
    public partial class MDIssueAssignTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _IssueAssignTypeID
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

        public MDIssueAssignTypeEntity _MDIssueAssignTypeEntity
        {
            get
            {
                MDIssueAssignTypeEntity entity = new MDIssueAssignTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDIssueAssignTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDIssueAssignTypeEntity CurrentMDIssueAssignTypeEntity
        {
            get
            {
                if (_IssueAssignTypeID > 0)
                {
                    if (_MDIssueAssignTypeEntity.IssueAssignTypeID != _IssueAssignTypeID)
                    {
                        _MDIssueAssignTypeEntity = FCCMDIssueAssignType.GetFacadeCreate().GetByID(_IssueAssignTypeID);
                    }
                }

                return _MDIssueAssignTypeEntity;
            }
            set
            {
                _MDIssueAssignTypeEntity = value;
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
            MDIssueAssignTypeEntity mDIssueAssignTypeEntity = CurrentMDIssueAssignTypeEntity;


            if (!mDIssueAssignTypeEntity.IsNew)
            {
                txtName.Text = mDIssueAssignTypeEntity.Name.ToString();
                txtDescription.Text = mDIssueAssignTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDIssueAssignTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDIssueAssignTypeList();
        }

        private void BindMDIssueAssignTypeList()
        {
            lvMDIssueAssignType.DataBind();
        }

        private MDIssueAssignTypeEntity BuildMDIssueAssignTypeEntity()
        {
            MDIssueAssignTypeEntity mDIssueAssignTypeEntity = CurrentMDIssueAssignTypeEntity;

            mDIssueAssignTypeEntity.Name = txtName.Text.Trim();
            mDIssueAssignTypeEntity.Description = txtDescription.Text.Trim();
            mDIssueAssignTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDIssueAssignTypeEntity;
        }

        private void SaveMDIssueAssignTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDIssueAssignTypeEntity mDIssueAssignTypeEntity = BuildMDIssueAssignTypeEntity();

                    Int64 result = -1;

                    if (mDIssueAssignTypeEntity.IsNew)
                    {
                        result = FCCMDIssueAssignType.GetFacadeCreate().Add(mDIssueAssignTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDIssueAssignTypeEntity.FLD_NAME_IssueAssignTypeID, mDIssueAssignTypeEntity.IssueAssignTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDIssueAssignType.GetFacadeCreate().Update(mDIssueAssignTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _IssueAssignTypeID = 0;
                        _MDIssueAssignTypeEntity = new MDIssueAssignTypeEntity();
                        PrepareInitialView();
                        BindMDIssueAssignTypeList();

                        if (mDIssueAssignTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Issue Assign Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Issue Assign Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDIssueAssignTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Issue Assign Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Issue Assign Type Information.", false);
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

        protected void lvMDIssueAssignType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 IssueAssignTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out IssueAssignTypeID);

            if (IssueAssignTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _IssueAssignTypeID = IssueAssignTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDIssueAssignTypeEntity.FLD_NAME_IssueAssignTypeID, IssueAssignTypeID.ToString(), SQLMatchType.Equal);

                        MDIssueAssignTypeEntity mDIssueAssignTypeEntity = new MDIssueAssignTypeEntity();


                        result = FCCMDIssueAssignType.GetFacadeCreate().Delete(mDIssueAssignTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _IssueAssignTypeID = 0;
                            _MDIssueAssignTypeEntity = new MDIssueAssignTypeEntity();
                            PrepareInitialView();
                            BindMDIssueAssignTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Issue Assign Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Issue Assign Type.", true);
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

        protected void odsMDIssueAssignType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDIssueAssignTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _IssueAssignTypeID = 0;
            _MDIssueAssignTypeEntity = new MDIssueAssignTypeEntity();
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
