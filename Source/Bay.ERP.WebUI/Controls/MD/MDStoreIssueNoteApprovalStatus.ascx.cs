// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




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
    public partial class MDStoreIssueNoteApprovalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _StoreIssueNoteApprovalStatusID
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

        public MDStoreIssueNoteApprovalStatusEntity _MDStoreIssueNoteApprovalStatusEntity
        {
            get
            {
                MDStoreIssueNoteApprovalStatusEntity entity = new MDStoreIssueNoteApprovalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDStoreIssueNoteApprovalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDStoreIssueNoteApprovalStatusEntity CurrentMDStoreIssueNoteApprovalStatusEntity
        {
            get
            {
                if (_StoreIssueNoteApprovalStatusID > 0)
                {
                    if (_MDStoreIssueNoteApprovalStatusEntity.StoreIssueNoteApprovalStatusID != _StoreIssueNoteApprovalStatusID)
                    {
                        _MDStoreIssueNoteApprovalStatusEntity = FCCMDStoreIssueNoteApprovalStatus.GetFacadeCreate().GetByID(_StoreIssueNoteApprovalStatusID);
                    }
                }

                return _MDStoreIssueNoteApprovalStatusEntity;
            }
            set
            {
                _MDStoreIssueNoteApprovalStatusEntity = value;
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
            MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity = CurrentMDStoreIssueNoteApprovalStatusEntity;


            if (!mDStoreIssueNoteApprovalStatusEntity.IsNew)
            {
                txtName.Text = mDStoreIssueNoteApprovalStatusEntity.Name.ToString();
                txtDescription.Text = mDStoreIssueNoteApprovalStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDStoreIssueNoteApprovalStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDStoreIssueNoteApprovalStatusList();
        }

        private void BindMDStoreIssueNoteApprovalStatusList()
        {
            lvMDStoreIssueNoteApprovalStatus.DataBind();
        }

        private MDStoreIssueNoteApprovalStatusEntity BuildMDStoreIssueNoteApprovalStatusEntity()
        {
            MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity = CurrentMDStoreIssueNoteApprovalStatusEntity;

            mDStoreIssueNoteApprovalStatusEntity.Name = txtName.Text.Trim();
            mDStoreIssueNoteApprovalStatusEntity.Description = txtDescription.Text.Trim();
            mDStoreIssueNoteApprovalStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDStoreIssueNoteApprovalStatusEntity;
        }

        private void SaveMDStoreIssueNoteApprovalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity = BuildMDStoreIssueNoteApprovalStatusEntity();

                    Int64 result = -1;

                    if (mDStoreIssueNoteApprovalStatusEntity.IsNew)
                    {
                        result = FCCMDStoreIssueNoteApprovalStatus.GetFacadeCreate().Add(mDStoreIssueNoteApprovalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDStoreIssueNoteApprovalStatusEntity.FLD_NAME_StoreIssueNoteApprovalStatusID, mDStoreIssueNoteApprovalStatusEntity.StoreIssueNoteApprovalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDStoreIssueNoteApprovalStatus.GetFacadeCreate().Update(mDStoreIssueNoteApprovalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _StoreIssueNoteApprovalStatusID = 0;
                        _MDStoreIssueNoteApprovalStatusEntity = new MDStoreIssueNoteApprovalStatusEntity();
                        PrepareInitialView();
                        BindMDStoreIssueNoteApprovalStatusList();

                        if (mDStoreIssueNoteApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Store Issue Note Approval Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Store Issue Note Approval Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDStoreIssueNoteApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Store Issue Note Approval Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Store Issue Note Approval Status Information.", false);
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

        protected void lvMDStoreIssueNoteApprovalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 StoreIssueNoteApprovalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out StoreIssueNoteApprovalStatusID);

            if (StoreIssueNoteApprovalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _StoreIssueNoteApprovalStatusID = StoreIssueNoteApprovalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDStoreIssueNoteApprovalStatusEntity.FLD_NAME_StoreIssueNoteApprovalStatusID, StoreIssueNoteApprovalStatusID.ToString(), SQLMatchType.Equal);

                        MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity = new MDStoreIssueNoteApprovalStatusEntity();


                        result = FCCMDStoreIssueNoteApprovalStatus.GetFacadeCreate().Delete(mDStoreIssueNoteApprovalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _StoreIssueNoteApprovalStatusID = 0;
                            _MDStoreIssueNoteApprovalStatusEntity = new MDStoreIssueNoteApprovalStatusEntity();
                            PrepareInitialView();
                            BindMDStoreIssueNoteApprovalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Store Issue Note Approval Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Store Issue Note Approval Status.", true);
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

        protected void odsMDStoreIssueNoteApprovalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDStoreIssueNoteApprovalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _StoreIssueNoteApprovalStatusID = 0;
            _MDStoreIssueNoteApprovalStatusEntity = new MDStoreIssueNoteApprovalStatusEntity();
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
