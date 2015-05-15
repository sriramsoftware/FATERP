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
    public partial class HREmployeeSalaryInfoHistoryControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeSalaryInfoHistoryID
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

        public HREmployeeSalaryInfoHistoryEntity _HREmployeeSalaryInfoHistoryEntity
        {
            get
            {
                HREmployeeSalaryInfoHistoryEntity entity = new HREmployeeSalaryInfoHistoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeSalaryInfoHistoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeSalaryInfoHistoryEntity CurrentHREmployeeSalaryInfoHistoryEntity
        {
            get
            {
                if (_EmployeeSalaryInfoHistoryID > 0)
                {
                    if (_HREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoHistoryID != _EmployeeSalaryInfoHistoryID)
                    {
                        _HREmployeeSalaryInfoHistoryEntity = FCCHREmployeeSalaryInfoHistory.GetFacadeCreate().GetByID(_EmployeeSalaryInfoHistoryID);
                    }
                }

                return _HREmployeeSalaryInfoHistoryEntity;
            }
            set
            {
                _HREmployeeSalaryInfoHistoryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHREmployeeSalaryInfo(ddlEmployeeSalaryInfoID, false);
            MiscUtil.PopulateHREmployee(ddlCreatedByEmployeeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtDesignationID.Text = String.Empty;
            txtFiscalYearID.Text = String.Empty;
            txtSalarySessionID.Text = String.Empty;
            txtEmployeeID.Text = String.Empty;
            chkIsDeposite.Checked = false;
            txtSalaryAmount.Text = String.Empty;
            txtPayCycleID.Text = String.Empty;
            txtPayscaleID.Text = String.Empty;
            txtEmployeeCode.Text = String.Empty;
            txtProjectID.Text = String.Empty;
            txtDepartmentID.Text = String.Empty;
            txtCreateDate.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity = CurrentHREmployeeSalaryInfoHistoryEntity;


            if (!hREmployeeSalaryInfoHistoryEntity.IsNew)
            {
                if (ddlEmployeeSalaryInfoID.Items.Count > 0 && hREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoID != null)
                {
                    ddlEmployeeSalaryInfoID.SelectedValue = hREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoID.ToString();
                }

                txtDesignationID.Text = hREmployeeSalaryInfoHistoryEntity.DesignationID.ToString();
                txtFiscalYearID.Text = hREmployeeSalaryInfoHistoryEntity.FiscalYearID.ToString();
                txtSalarySessionID.Text = hREmployeeSalaryInfoHistoryEntity.SalarySessionID.ToString();
                txtEmployeeID.Text = hREmployeeSalaryInfoHistoryEntity.EmployeeID.ToString();
                chkIsDeposite.Checked = hREmployeeSalaryInfoHistoryEntity.IsDeposite;
                txtSalaryAmount.Text = hREmployeeSalaryInfoHistoryEntity.SalaryAmount.ToString();
                txtPayCycleID.Text = hREmployeeSalaryInfoHistoryEntity.PayCycleID.ToString();
                txtPayscaleID.Text = hREmployeeSalaryInfoHistoryEntity.PayscaleID.ToString();
                txtEmployeeCode.Text = hREmployeeSalaryInfoHistoryEntity.EmployeeCode.ToString();
                txtProjectID.Text = hREmployeeSalaryInfoHistoryEntity.ProjectID.ToString();
                txtDepartmentID.Text = hREmployeeSalaryInfoHistoryEntity.DepartmentID.ToString();
                txtCreateDate.Text = hREmployeeSalaryInfoHistoryEntity.CreateDate.ToStringDefault();
                if (ddlCreatedByEmployeeID.Items.Count > 0 && hREmployeeSalaryInfoHistoryEntity.CreatedByEmployeeID != null)
                {
                    ddlCreatedByEmployeeID.SelectedValue = hREmployeeSalaryInfoHistoryEntity.CreatedByEmployeeID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeSalaryInfoHistoryList();
        }

        private void BindHREmployeeSalaryInfoHistoryList()
        {
            lvHREmployeeSalaryInfoHistory.DataBind();
        }

        private HREmployeeSalaryInfoHistoryEntity BuildHREmployeeSalaryInfoHistoryEntity()
        {
            HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity = CurrentHREmployeeSalaryInfoHistoryEntity;

            if (ddlEmployeeSalaryInfoID.Items.Count > 0)
            {
                if (ddlEmployeeSalaryInfoID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoID = Int64.Parse(ddlEmployeeSalaryInfoID.SelectedValue);
                }
            }

            if (!txtDesignationID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryInfoHistoryEntity.DesignationID = Int64.Parse(txtDesignationID.Text.Trim());
            }
            else
            {
                hREmployeeSalaryInfoHistoryEntity.DesignationID = null;
            }

            if (!txtFiscalYearID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryInfoHistoryEntity.FiscalYearID = Int64.Parse(txtFiscalYearID.Text.Trim());
            }

            if (!txtSalarySessionID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryInfoHistoryEntity.SalarySessionID = Int64.Parse(txtSalarySessionID.Text.Trim());
            }

            if (!txtEmployeeID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryInfoHistoryEntity.EmployeeID = Int64.Parse(txtEmployeeID.Text.Trim());
            }

            hREmployeeSalaryInfoHistoryEntity.IsDeposite = chkIsDeposite.Checked;

            if (!txtSalaryAmount.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryInfoHistoryEntity.SalaryAmount = Decimal.Parse(txtSalaryAmount.Text.Trim());
            }

            if (!txtPayCycleID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryInfoHistoryEntity.PayCycleID = Int64.Parse(txtPayCycleID.Text.Trim());
            }
            else
            {
                hREmployeeSalaryInfoHistoryEntity.PayCycleID = null;
            }

            if (!txtPayscaleID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryInfoHistoryEntity.PayscaleID = Int64.Parse(txtPayscaleID.Text.Trim());
            }
            else
            {
                hREmployeeSalaryInfoHistoryEntity.PayscaleID = null;
            }

            hREmployeeSalaryInfoHistoryEntity.EmployeeCode = txtEmployeeCode.Text.Trim();
            if (!txtProjectID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryInfoHistoryEntity.ProjectID = Int64.Parse(txtProjectID.Text.Trim());
            }
            else
            {
                hREmployeeSalaryInfoHistoryEntity.ProjectID = null;
            }

            if (!txtDepartmentID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryInfoHistoryEntity.DepartmentID = Int64.Parse(txtDepartmentID.Text.Trim());
            }
            else
            {
                hREmployeeSalaryInfoHistoryEntity.DepartmentID = null;
            }

            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeSalaryInfoHistoryEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }

            if (ddlCreatedByEmployeeID.Items.Count > 0)
            {
                if (ddlCreatedByEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSalaryInfoHistoryEntity.CreatedByEmployeeID = Int64.Parse(ddlCreatedByEmployeeID.SelectedValue);
                }
            }


            return hREmployeeSalaryInfoHistoryEntity;
        }

        private void SaveHREmployeeSalaryInfoHistoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity = BuildHREmployeeSalaryInfoHistoryEntity();

                    Int64 result = -1;

                    if (hREmployeeSalaryInfoHistoryEntity.IsNew)
                    {
                        result = FCCHREmployeeSalaryInfoHistory.GetFacadeCreate().Add(hREmployeeSalaryInfoHistoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryInfoHistoryEntity.FLD_NAME_EmployeeSalaryInfoHistoryID, hREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoHistoryID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeSalaryInfoHistory.GetFacadeCreate().Update(hREmployeeSalaryInfoHistoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeSalaryInfoHistoryID = 0;
                        _HREmployeeSalaryInfoHistoryEntity = new HREmployeeSalaryInfoHistoryEntity();
                        PrepareInitialView();
                        BindHREmployeeSalaryInfoHistoryList();

                        if (hREmployeeSalaryInfoHistoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Info History Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Info History Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeSalaryInfoHistoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Salary Info History Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Salary Info History Information.", false);
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

        protected void lvHREmployeeSalaryInfoHistory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeSalaryInfoHistoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeSalaryInfoHistoryID);

            if (EmployeeSalaryInfoHistoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeSalaryInfoHistoryID = EmployeeSalaryInfoHistoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryInfoHistoryEntity.FLD_NAME_EmployeeSalaryInfoHistoryID, EmployeeSalaryInfoHistoryID.ToString(), SQLMatchType.Equal);

                        HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity = new HREmployeeSalaryInfoHistoryEntity();


                        result = FCCHREmployeeSalaryInfoHistory.GetFacadeCreate().Delete(hREmployeeSalaryInfoHistoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeSalaryInfoHistoryID = 0;
                            _HREmployeeSalaryInfoHistoryEntity = new HREmployeeSalaryInfoHistoryEntity();
                            PrepareInitialView();
                            BindHREmployeeSalaryInfoHistoryList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Info History has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Salary Info History.", true);
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

        protected void odsHREmployeeSalaryInfoHistory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeSalaryInfoHistoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeSalaryInfoHistoryID = 0;
            _HREmployeeSalaryInfoHistoryEntity = new HREmployeeSalaryInfoHistoryEntity();
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
