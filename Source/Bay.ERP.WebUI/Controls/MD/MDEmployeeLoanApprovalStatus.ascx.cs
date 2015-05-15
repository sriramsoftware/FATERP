// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDEmployeeLoanApprovalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeLoanApprovalStatusID
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

        public MDEmployeeLoanApprovalStatusEntity _MDEmployeeLoanApprovalStatusEntity
        {
            get
            {
                MDEmployeeLoanApprovalStatusEntity entity = new MDEmployeeLoanApprovalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEmployeeLoanApprovalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEmployeeLoanApprovalStatusEntity CurrentMDEmployeeLoanApprovalStatusEntity
        {
            get
            {
                if (_EmployeeLoanApprovalStatusID > 0)
                {
                    if (_MDEmployeeLoanApprovalStatusEntity.EmployeeLoanApprovalStatusID != _EmployeeLoanApprovalStatusID)
                    {
                        _MDEmployeeLoanApprovalStatusEntity = FCCMDEmployeeLoanApprovalStatus.GetFacadeCreate().GetByID(_EmployeeLoanApprovalStatusID);
                    }
                }

                return _MDEmployeeLoanApprovalStatusEntity;
            }
            set
            {
                _MDEmployeeLoanApprovalStatusEntity = value;
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

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDEmployeeLoanApprovalStatusEntity mDEmployeeLoanApprovalStatusEntity = CurrentMDEmployeeLoanApprovalStatusEntity;


            if (!mDEmployeeLoanApprovalStatusEntity.IsNew)
            {
                txtName.Text = mDEmployeeLoanApprovalStatusEntity.Name.ToString();
                txtDescription.Text = mDEmployeeLoanApprovalStatusEntity.Description.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEmployeeLoanApprovalStatusList();
        }

        private void BindMDEmployeeLoanApprovalStatusList()
        {
            lvMDEmployeeLoanApprovalStatus.DataBind();
        }

        private MDEmployeeLoanApprovalStatusEntity BuildMDEmployeeLoanApprovalStatusEntity()
        {
            MDEmployeeLoanApprovalStatusEntity mDEmployeeLoanApprovalStatusEntity = CurrentMDEmployeeLoanApprovalStatusEntity;

            mDEmployeeLoanApprovalStatusEntity.Name = txtName.Text.Trim();
            mDEmployeeLoanApprovalStatusEntity.Description = txtDescription.Text.Trim();

            return mDEmployeeLoanApprovalStatusEntity;
        }

        private void SaveMDEmployeeLoanApprovalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEmployeeLoanApprovalStatusEntity mDEmployeeLoanApprovalStatusEntity = BuildMDEmployeeLoanApprovalStatusEntity();

                    Int64 result = -1;

                    if (mDEmployeeLoanApprovalStatusEntity.IsNew)
                    {
                        result = FCCMDEmployeeLoanApprovalStatus.GetFacadeCreate().Add(mDEmployeeLoanApprovalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeLoanApprovalStatusEntity.FLD_NAME_EmployeeLoanApprovalStatusID, mDEmployeeLoanApprovalStatusEntity.EmployeeLoanApprovalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEmployeeLoanApprovalStatus.GetFacadeCreate().Update(mDEmployeeLoanApprovalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeLoanApprovalStatusID = 0;
                        _MDEmployeeLoanApprovalStatusEntity = new MDEmployeeLoanApprovalStatusEntity();
                        PrepareInitialView();
                        BindMDEmployeeLoanApprovalStatusList();

                        if (mDEmployeeLoanApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Loan Approval Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Loan Approval Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEmployeeLoanApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Loan Approval Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Loan Approval Status Information.", false);
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

        protected void lvMDEmployeeLoanApprovalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeLoanApprovalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeLoanApprovalStatusID);

            if (EmployeeLoanApprovalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeLoanApprovalStatusID = EmployeeLoanApprovalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeLoanApprovalStatusEntity.FLD_NAME_EmployeeLoanApprovalStatusID, EmployeeLoanApprovalStatusID.ToString(), SQLMatchType.Equal);

                        MDEmployeeLoanApprovalStatusEntity mDEmployeeLoanApprovalStatusEntity = new MDEmployeeLoanApprovalStatusEntity();


                        result = FCCMDEmployeeLoanApprovalStatus.GetFacadeCreate().Delete(mDEmployeeLoanApprovalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeLoanApprovalStatusID = 0;
                            _MDEmployeeLoanApprovalStatusEntity = new MDEmployeeLoanApprovalStatusEntity();
                            PrepareInitialView();
                            BindMDEmployeeLoanApprovalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Loan Approval Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Loan Approval Status.", true);
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

        protected void odsMDEmployeeLoanApprovalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEmployeeLoanApprovalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeLoanApprovalStatusID = 0;
            _MDEmployeeLoanApprovalStatusEntity = new MDEmployeeLoanApprovalStatusEntity();
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
