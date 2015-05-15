// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




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
    public partial class MDEmployeeSalaryPaymentStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeSalaryPaymentStatusID
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

        public MDEmployeeSalaryPaymentStatusEntity _MDEmployeeSalaryPaymentStatusEntity
        {
            get
            {
                MDEmployeeSalaryPaymentStatusEntity entity = new MDEmployeeSalaryPaymentStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEmployeeSalaryPaymentStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEmployeeSalaryPaymentStatusEntity CurrentMDEmployeeSalaryPaymentStatusEntity
        {
            get
            {
                if (_EmployeeSalaryPaymentStatusID > 0)
                {
                    if (_MDEmployeeSalaryPaymentStatusEntity.EmployeeSalaryPaymentStatusID != _EmployeeSalaryPaymentStatusID)
                    {
                        _MDEmployeeSalaryPaymentStatusEntity = FCCMDEmployeeSalaryPaymentStatus.GetFacadeCreate().GetByID(_EmployeeSalaryPaymentStatusID);
                    }
                }

                return _MDEmployeeSalaryPaymentStatusEntity;
            }
            set
            {
                _MDEmployeeSalaryPaymentStatusEntity = value;
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
            MDEmployeeSalaryPaymentStatusEntity mDEmployeeSalaryPaymentStatusEntity = CurrentMDEmployeeSalaryPaymentStatusEntity;


            if (!mDEmployeeSalaryPaymentStatusEntity.IsNew)
            {
                txtName.Text = mDEmployeeSalaryPaymentStatusEntity.Name.ToString();
                chkIsRemoved.Checked = mDEmployeeSalaryPaymentStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEmployeeSalaryPaymentStatusList();
        }

        private void BindMDEmployeeSalaryPaymentStatusList()
        {
            lvMDEmployeeSalaryPaymentStatus.DataBind();
        }

        private MDEmployeeSalaryPaymentStatusEntity BuildMDEmployeeSalaryPaymentStatusEntity()
        {
            MDEmployeeSalaryPaymentStatusEntity mDEmployeeSalaryPaymentStatusEntity = CurrentMDEmployeeSalaryPaymentStatusEntity;

            mDEmployeeSalaryPaymentStatusEntity.Name = txtName.Text.Trim();
            mDEmployeeSalaryPaymentStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEmployeeSalaryPaymentStatusEntity;
        }

        private void SaveMDEmployeeSalaryPaymentStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEmployeeSalaryPaymentStatusEntity mDEmployeeSalaryPaymentStatusEntity = BuildMDEmployeeSalaryPaymentStatusEntity();

                    Int64 result = -1;

                    if (mDEmployeeSalaryPaymentStatusEntity.IsNew)
                    {
                        result = FCCMDEmployeeSalaryPaymentStatus.GetFacadeCreate().Add(mDEmployeeSalaryPaymentStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeSalaryPaymentStatusEntity.FLD_NAME_EmployeeSalaryPaymentStatusID, mDEmployeeSalaryPaymentStatusEntity.EmployeeSalaryPaymentStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEmployeeSalaryPaymentStatus.GetFacadeCreate().Update(mDEmployeeSalaryPaymentStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeSalaryPaymentStatusID = 0;
                        _MDEmployeeSalaryPaymentStatusEntity = new MDEmployeeSalaryPaymentStatusEntity();
                        PrepareInitialView();
                        BindMDEmployeeSalaryPaymentStatusList();

                        if (mDEmployeeSalaryPaymentStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Payment Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Payment Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEmployeeSalaryPaymentStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Salary Payment Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Salary Payment Status Information.", false);
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

        protected void lvMDEmployeeSalaryPaymentStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeSalaryPaymentStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeSalaryPaymentStatusID);

            if (EmployeeSalaryPaymentStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeSalaryPaymentStatusID = EmployeeSalaryPaymentStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeSalaryPaymentStatusEntity.FLD_NAME_EmployeeSalaryPaymentStatusID, EmployeeSalaryPaymentStatusID.ToString(), SQLMatchType.Equal);

                        MDEmployeeSalaryPaymentStatusEntity mDEmployeeSalaryPaymentStatusEntity = new MDEmployeeSalaryPaymentStatusEntity();


                        result = FCCMDEmployeeSalaryPaymentStatus.GetFacadeCreate().Delete(mDEmployeeSalaryPaymentStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeSalaryPaymentStatusID = 0;
                            _MDEmployeeSalaryPaymentStatusEntity = new MDEmployeeSalaryPaymentStatusEntity();
                            PrepareInitialView();
                            BindMDEmployeeSalaryPaymentStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Payment Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Salary Payment Status.", true);
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

        protected void odsMDEmployeeSalaryPaymentStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEmployeeSalaryPaymentStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeSalaryPaymentStatusID = 0;
            _MDEmployeeSalaryPaymentStatusEntity = new MDEmployeeSalaryPaymentStatusEntity();
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
