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
    public partial class MDApprovalPanelStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _ApprovalPanelStatusID
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

        public MDApprovalPanelStatusEntity _MDApprovalPanelStatusEntity
        {
            get
            {
                MDApprovalPanelStatusEntity entity = new MDApprovalPanelStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDApprovalPanelStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDApprovalPanelStatusEntity CurrentMDApprovalPanelStatusEntity
        {
            get
            {
                if (_ApprovalPanelStatusID > 0)
                {
                    if (_MDApprovalPanelStatusEntity.ApprovalPanelStatusID != _ApprovalPanelStatusID)
                    {
                        _MDApprovalPanelStatusEntity = FCCMDApprovalPanelStatus.GetFacadeCreate().GetByID(_ApprovalPanelStatusID);
                    }
                }

                return _MDApprovalPanelStatusEntity;
            }
            set
            {
                _MDApprovalPanelStatusEntity = value;
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
            MDApprovalPanelStatusEntity mDApprovalPanelStatusEntity = CurrentMDApprovalPanelStatusEntity;


            if (!mDApprovalPanelStatusEntity.IsNew)
            {
                txtName.Text = mDApprovalPanelStatusEntity.Name.ToString();
                chkIsRemoved.Checked = mDApprovalPanelStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDApprovalPanelStatusList();
        }

        private void BindMDApprovalPanelStatusList()
        {
            lvMDApprovalPanelStatus.DataBind();
        }

        private MDApprovalPanelStatusEntity BuildMDApprovalPanelStatusEntity()
        {
            MDApprovalPanelStatusEntity mDApprovalPanelStatusEntity = CurrentMDApprovalPanelStatusEntity;

            mDApprovalPanelStatusEntity.Name = txtName.Text.Trim();
            mDApprovalPanelStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDApprovalPanelStatusEntity;
        }

        private void SaveMDApprovalPanelStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDApprovalPanelStatusEntity mDApprovalPanelStatusEntity = BuildMDApprovalPanelStatusEntity();

                    Int64 result = -1;

                    if (mDApprovalPanelStatusEntity.IsNew)
                    {
                        result = FCCMDApprovalPanelStatus.GetFacadeCreate().Add(mDApprovalPanelStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalPanelStatusEntity.FLD_NAME_ApprovalPanelStatusID, mDApprovalPanelStatusEntity.ApprovalPanelStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDApprovalPanelStatus.GetFacadeCreate().Update(mDApprovalPanelStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ApprovalPanelStatusID = 0;
                        _MDApprovalPanelStatusEntity = new MDApprovalPanelStatusEntity();
                        PrepareInitialView();
                        BindMDApprovalPanelStatusList();

                        if (mDApprovalPanelStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Panel Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Panel Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDApprovalPanelStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Approval Panel Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Approval Panel Status Information.", false);
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

        protected void lvMDApprovalPanelStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ApprovalPanelStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out ApprovalPanelStatusID);

            if (ApprovalPanelStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ApprovalPanelStatusID = ApprovalPanelStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalPanelStatusEntity.FLD_NAME_ApprovalPanelStatusID, ApprovalPanelStatusID.ToString(), SQLMatchType.Equal);

                        MDApprovalPanelStatusEntity mDApprovalPanelStatusEntity = new MDApprovalPanelStatusEntity();


                        result = FCCMDApprovalPanelStatus.GetFacadeCreate().Delete(mDApprovalPanelStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ApprovalPanelStatusID = 0;
                            _MDApprovalPanelStatusEntity = new MDApprovalPanelStatusEntity();
                            PrepareInitialView();
                            BindMDApprovalPanelStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Approval Panel Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Approval Panel Status.", true);
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

        protected void odsMDApprovalPanelStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDApprovalPanelStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ApprovalPanelStatusID = 0;
            _MDApprovalPanelStatusEntity = new MDApprovalPanelStatusEntity();
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
