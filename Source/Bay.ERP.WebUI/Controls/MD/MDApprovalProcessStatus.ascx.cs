// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




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
    public partial class MDApprovalProcessStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _ApprovalProcessStatusID
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

        public MDApprovalProcessStatusEntity _MDApprovalProcessStatusEntity
        {
            get
            {
                MDApprovalProcessStatusEntity entity = new MDApprovalProcessStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDApprovalProcessStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDApprovalProcessStatusEntity CurrentMDApprovalProcessStatusEntity
        {
            get
            {
                if (_ApprovalProcessStatusID > 0)
                {
                    if (_MDApprovalProcessStatusEntity.ApprovalProcessStatusID != _ApprovalProcessStatusID)
                    {
                        _MDApprovalProcessStatusEntity = FCCMDApprovalProcessStatus.GetFacadeCreate().GetByID(_ApprovalProcessStatusID);
                    }
                }

                return _MDApprovalProcessStatusEntity;
            }
            set
            {
                _MDApprovalProcessStatusEntity = value;
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
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDApprovalProcessStatusEntity mDApprovalProcessStatusEntity = CurrentMDApprovalProcessStatusEntity;


            if (!mDApprovalProcessStatusEntity.IsNew)
            {
                txtName.Text = mDApprovalProcessStatusEntity.Name.ToString();
                chkIsRemoved.Checked = mDApprovalProcessStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDApprovalProcessStatusList();
        }

        private void BindMDApprovalProcessStatusList()
        {
            lvMDApprovalProcessStatus.DataBind();
        }

        private MDApprovalProcessStatusEntity BuildMDApprovalProcessStatusEntity()
        {
            MDApprovalProcessStatusEntity mDApprovalProcessStatusEntity = CurrentMDApprovalProcessStatusEntity;

            mDApprovalProcessStatusEntity.Name = txtName.Text.Trim();
            mDApprovalProcessStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDApprovalProcessStatusEntity;
        }

        private void SaveMDApprovalProcessStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDApprovalProcessStatusEntity mDApprovalProcessStatusEntity = BuildMDApprovalProcessStatusEntity();

                    Int64 result = -1;

                    if (mDApprovalProcessStatusEntity.IsNew)
                    {
                        result = FCCMDApprovalProcessStatus.GetFacadeCreate().Add(mDApprovalProcessStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalProcessStatusEntity.FLD_NAME_ApprovalProcessStatusID, mDApprovalProcessStatusEntity.ApprovalProcessStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDApprovalProcessStatus.GetFacadeCreate().Update(mDApprovalProcessStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ApprovalProcessStatusID = 0;
                        _MDApprovalProcessStatusEntity = new MDApprovalProcessStatusEntity();
                        PrepareInitialView();
                        BindMDApprovalProcessStatusList();

                        if (mDApprovalProcessStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDApprovalProcessStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Approval Process Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Approval Process Status Information.", false);
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

        protected void lvMDApprovalProcessStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ApprovalProcessStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out ApprovalProcessStatusID);

            if (ApprovalProcessStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ApprovalProcessStatusID = ApprovalProcessStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalProcessStatusEntity.FLD_NAME_ApprovalProcessStatusID, ApprovalProcessStatusID.ToString(), SQLMatchType.Equal);

                        MDApprovalProcessStatusEntity mDApprovalProcessStatusEntity = new MDApprovalProcessStatusEntity();


                        result = FCCMDApprovalProcessStatus.GetFacadeCreate().Delete(mDApprovalProcessStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ApprovalProcessStatusID = 0;
                            _MDApprovalProcessStatusEntity = new MDApprovalProcessStatusEntity();
                            PrepareInitialView();
                            BindMDApprovalProcessStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Approval Process Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Approval Process Status.", true);
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

        protected void odsMDApprovalProcessStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDApprovalProcessStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ApprovalProcessStatusID = 0;
            _MDApprovalProcessStatusEntity = new MDApprovalProcessStatusEntity();
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
