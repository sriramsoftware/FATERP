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
    public partial class MDIssueStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _IssueStatusID
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

        public MDIssueStatusEntity _MDIssueStatusEntity
        {
            get
            {
                MDIssueStatusEntity entity = new MDIssueStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDIssueStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDIssueStatusEntity CurrentMDIssueStatusEntity
        {
            get
            {
                if (_IssueStatusID > 0)
                {
                    if (_MDIssueStatusEntity.IssueStatusID != _IssueStatusID)
                    {
                        _MDIssueStatusEntity = FCCMDIssueStatus.GetFacadeCreate().GetByID(_IssueStatusID);
                    }
                }

                return _MDIssueStatusEntity;
            }
            set
            {
                _MDIssueStatusEntity = value;
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
            MDIssueStatusEntity mDIssueStatusEntity = CurrentMDIssueStatusEntity;


            if (!mDIssueStatusEntity.IsNew)
            {
                txtName.Text = mDIssueStatusEntity.Name.ToString();
                txtDescription.Text = mDIssueStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDIssueStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDIssueStatusList();
        }

        private void BindMDIssueStatusList()
        {
            lvMDIssueStatus.DataBind();
        }

        private MDIssueStatusEntity BuildMDIssueStatusEntity()
        {
            MDIssueStatusEntity mDIssueStatusEntity = CurrentMDIssueStatusEntity;

            mDIssueStatusEntity.Name = txtName.Text.Trim();
            mDIssueStatusEntity.Description = txtDescription.Text.Trim();
            mDIssueStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDIssueStatusEntity;
        }

        private void SaveMDIssueStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDIssueStatusEntity mDIssueStatusEntity = BuildMDIssueStatusEntity();

                    Int64 result = -1;

                    if (mDIssueStatusEntity.IsNew)
                    {
                        result = FCCMDIssueStatus.GetFacadeCreate().Add(mDIssueStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDIssueStatusEntity.FLD_NAME_IssueStatusID, mDIssueStatusEntity.IssueStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDIssueStatus.GetFacadeCreate().Update(mDIssueStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _IssueStatusID = 0;
                        _MDIssueStatusEntity = new MDIssueStatusEntity();
                        PrepareInitialView();
                        BindMDIssueStatusList();

                        if (mDIssueStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Issue Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Issue Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDIssueStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Issue Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Issue Status Information.", false);
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

        protected void lvMDIssueStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 IssueStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out IssueStatusID);

            if (IssueStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _IssueStatusID = IssueStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDIssueStatusEntity.FLD_NAME_IssueStatusID, IssueStatusID.ToString(), SQLMatchType.Equal);

                        MDIssueStatusEntity mDIssueStatusEntity = new MDIssueStatusEntity();


                        result = FCCMDIssueStatus.GetFacadeCreate().Delete(mDIssueStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _IssueStatusID = 0;
                            _MDIssueStatusEntity = new MDIssueStatusEntity();
                            PrepareInitialView();
                            BindMDIssueStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Issue Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Issue Status.", true);
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

        protected void odsMDIssueStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDIssueStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _IssueStatusID = 0;
            _MDIssueStatusEntity = new MDIssueStatusEntity();
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
