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
    public partial class MDApprovalProcessTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _ApprovalProcessTypeID
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

        public MDApprovalProcessTypeEntity _MDApprovalProcessTypeEntity
        {
            get
            {
                MDApprovalProcessTypeEntity entity = new MDApprovalProcessTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDApprovalProcessTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDApprovalProcessTypeEntity CurrentMDApprovalProcessTypeEntity
        {
            get
            {
                if (_ApprovalProcessTypeID > 0)
                {
                    if (_MDApprovalProcessTypeEntity.ApprovalProcessTypeID != _ApprovalProcessTypeID)
                    {
                        _MDApprovalProcessTypeEntity = FCCMDApprovalProcessType.GetFacadeCreate().GetByID(_ApprovalProcessTypeID);
                    }
                }

                return _MDApprovalProcessTypeEntity;
            }
            set
            {
                _MDApprovalProcessTypeEntity = value;
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
            MDApprovalProcessTypeEntity mDApprovalProcessTypeEntity = CurrentMDApprovalProcessTypeEntity;


            if (!mDApprovalProcessTypeEntity.IsNew)
            {
                txtName.Text = mDApprovalProcessTypeEntity.Name.ToString();
                chkIsRemoved.Checked = mDApprovalProcessTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDApprovalProcessTypeList();
        }

        private void BindMDApprovalProcessTypeList()
        {
            lvMDApprovalProcessType.DataBind();
        }

        private MDApprovalProcessTypeEntity BuildMDApprovalProcessTypeEntity()
        {
            MDApprovalProcessTypeEntity mDApprovalProcessTypeEntity = CurrentMDApprovalProcessTypeEntity;

            mDApprovalProcessTypeEntity.Name = txtName.Text.Trim();
            mDApprovalProcessTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDApprovalProcessTypeEntity;
        }

        private void SaveMDApprovalProcessTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDApprovalProcessTypeEntity mDApprovalProcessTypeEntity = BuildMDApprovalProcessTypeEntity();

                    Int64 result = -1;

                    if (mDApprovalProcessTypeEntity.IsNew)
                    {
                        result = FCCMDApprovalProcessType.GetFacadeCreate().Add(mDApprovalProcessTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalProcessTypeEntity.FLD_NAME_ApprovalProcessTypeID, mDApprovalProcessTypeEntity.ApprovalProcessTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDApprovalProcessType.GetFacadeCreate().Update(mDApprovalProcessTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ApprovalProcessTypeID = 0;
                        _MDApprovalProcessTypeEntity = new MDApprovalProcessTypeEntity();
                        PrepareInitialView();
                        BindMDApprovalProcessTypeList();

                        if (mDApprovalProcessTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDApprovalProcessTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Approval Process Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Approval Process Type Information.", false);
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

        protected void lvMDApprovalProcessType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ApprovalProcessTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out ApprovalProcessTypeID);

            if (ApprovalProcessTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ApprovalProcessTypeID = ApprovalProcessTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalProcessTypeEntity.FLD_NAME_ApprovalProcessTypeID, ApprovalProcessTypeID.ToString(), SQLMatchType.Equal);

                        MDApprovalProcessTypeEntity mDApprovalProcessTypeEntity = new MDApprovalProcessTypeEntity();


                        result = FCCMDApprovalProcessType.GetFacadeCreate().Delete(mDApprovalProcessTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ApprovalProcessTypeID = 0;
                            _MDApprovalProcessTypeEntity = new MDApprovalProcessTypeEntity();
                            PrepareInitialView();
                            BindMDApprovalProcessTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Approval Process Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Approval Process Type.", true);
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

        protected void odsMDApprovalProcessType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDApprovalProcessTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ApprovalProcessTypeID = 0;
            _MDApprovalProcessTypeEntity = new MDApprovalProcessTypeEntity();
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
