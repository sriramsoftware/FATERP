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
    public partial class HREmployeeSalaryDeducationInfoOperationControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeSalaryDeducationInfoID
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

        public HREmployeeSalaryDeducationInfoEntity _HREmployeeSalaryDeducationInfoEntity
        {
            get
            {
                HREmployeeSalaryDeducationInfoEntity entity = new HREmployeeSalaryDeducationInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeSalaryDeducationInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeSalaryDeducationInfoEntity CurrentHREmployeeSalaryDeducationInfoEntity
        {
            get
            {
                if (_EmployeeSalaryDeducationInfoID > 0)
                {
                    if (_HREmployeeSalaryDeducationInfoEntity.EmployeeSalaryDeducationInfoID != _EmployeeSalaryDeducationInfoID)
                    {
                        _HREmployeeSalaryDeducationInfoEntity = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().GetByID(_EmployeeSalaryDeducationInfoID);
                    }
                }

                return _HREmployeeSalaryDeducationInfoEntity;
            }
            set
            {
                _HREmployeeSalaryDeducationInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDSalaryDeducationCategory(ddlSalaryDeducationCategoryID, false);
            MiscUtil.PopulateMDSalarySession(ddlSalarySessionID, false);
            MiscUtil.PopulateACFiscalYear(ddlFiscalYearID, false);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
            MiscUtil.PopulateMDPayCycle(ddlPayCycleID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtDeductionAmount.Text = String.Empty;
            txtPercentageOfBasicSalary.Text = "0";
            txtEffectiveDate.Text = String.Empty;
            txtEndDate.Text = String.Empty;
            txtNumberOfPayments.Text = String.Empty;
            txtNote.Text = String.Empty;
            chkIsRemoved.Checked = false;
            txtNextInstallment.Text = "1";

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity = CurrentHREmployeeSalaryDeducationInfoEntity;


            if (!hREmployeeSalaryDeducationInfoEntity.IsNew)
            {
                if (ddlSalaryDeducationCategoryID.Items.Count > 0 && hREmployeeSalaryDeducationInfoEntity.SalaryDeducationCategoryID != null)
                {
                    ddlSalaryDeducationCategoryID.SelectedValue = hREmployeeSalaryDeducationInfoEntity.SalaryDeducationCategoryID.ToString();
                }

                if (ddlSalarySessionID.Items.Count > 0 && hREmployeeSalaryDeducationInfoEntity.SalarySessionID != null)
                {
                    ddlSalarySessionID.SelectedValue = hREmployeeSalaryDeducationInfoEntity.SalarySessionID.ToString();
                }

                if (ddlFiscalYearID.Items.Count > 0 && hREmployeeSalaryDeducationInfoEntity.FiscalYearID != null)
                {
                    ddlFiscalYearID.SelectedValue = hREmployeeSalaryDeducationInfoEntity.FiscalYearID.ToString();
                }

                if (ddlEmployeeID.Items.Count > 0 && hREmployeeSalaryDeducationInfoEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = hREmployeeSalaryDeducationInfoEntity.EmployeeID.ToString();
                }

                txtDeductionAmount.Text = hREmployeeSalaryDeducationInfoEntity.DeductionAmount.ToString();
                txtPercentageOfBasicSalary.Text = hREmployeeSalaryDeducationInfoEntity.PercentageOfBasicSalary.ToString();
                if (ddlPayCycleID.Items.Count > 0 && hREmployeeSalaryDeducationInfoEntity.PayCycleID != null)
                {
                    ddlPayCycleID.SelectedValue = hREmployeeSalaryDeducationInfoEntity.PayCycleID.ToString();
                }

                txtEffectiveDate.Text = hREmployeeSalaryDeducationInfoEntity.EffectiveDate.ToStringDefault();
                txtEndDate.Text = hREmployeeSalaryDeducationInfoEntity.EndDate.ToStringDefault();
                txtNumberOfPayments.Text = hREmployeeSalaryDeducationInfoEntity.NumberOfPayments.ToString();
                txtNote.Text = hREmployeeSalaryDeducationInfoEntity.Note.ToString();
                chkIsRemoved.Checked = hREmployeeSalaryDeducationInfoEntity.IsRemoved;
                txtNextInstallment.Text = hREmployeeSalaryDeducationInfoEntity.NextInstallMent.ToString();


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeSalaryDeducationInfoList();
        }

        private void BindHREmployeeSalaryDeducationInfoList()
        {
            lvHREmployeeSalaryDeducationInfo.DataBind();
        }

        private HREmployeeSalaryDeducationInfoEntity BuildHREmployeeSalaryDeducationInfoEntity()
        {
            HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity = CurrentHREmployeeSalaryDeducationInfoEntity;

            if (ddlSalaryDeducationCategoryID.Items.Count > 0)
            {
                if (ddlSalaryDeducationCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSalaryDeducationInfoEntity.SalaryDeducationCategoryID = Int64.Parse(ddlSalaryDeducationCategoryID.SelectedValue);
                }
            }

            if (ddlSalarySessionID.Items.Count > 0)
            {
                if (ddlSalarySessionID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSalaryDeducationInfoEntity.SalarySessionID = Int64.Parse(ddlSalarySessionID.SelectedValue);
                }
            }

            if (ddlFiscalYearID.Items.Count > 0)
            {
                if (ddlFiscalYearID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSalaryDeducationInfoEntity.FiscalYearID = Int64.Parse(ddlFiscalYearID.SelectedValue);
                }
            }

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSalaryDeducationInfoEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            if (!txtDeductionAmount.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryDeducationInfoEntity.DeductionAmount = Decimal.Parse(txtDeductionAmount.Text.Trim());
            }

            if (!txtPercentageOfBasicSalary.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryDeducationInfoEntity.PercentageOfBasicSalary = Decimal.Parse(txtPercentageOfBasicSalary.Text.Trim());
            }

            if (ddlPayCycleID.Items.Count > 0)
            {
                if (ddlPayCycleID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSalaryDeducationInfoEntity.PayCycleID = Int64.Parse(ddlPayCycleID.SelectedValue);
                }
            }

            if (txtEffectiveDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeSalaryDeducationInfoEntity.EffectiveDate = MiscUtil.ParseToDateTime(txtEffectiveDate.Text);
            }

            if (txtEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeSalaryDeducationInfoEntity.EndDate = MiscUtil.ParseToDateTime(txtEndDate.Text);
            }
            else
            {
                hREmployeeSalaryDeducationInfoEntity.EndDate = null;
            }

            if (!txtNumberOfPayments.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryDeducationInfoEntity.NumberOfPayments = Decimal.Parse(txtNumberOfPayments.Text.Trim());
            }

            hREmployeeSalaryDeducationInfoEntity.Note = txtNote.Text.Trim();
            hREmployeeSalaryDeducationInfoEntity.IsRemoved = chkIsRemoved.Checked;
            hREmployeeSalaryDeducationInfoEntity.NextInstallMent = Decimal.Parse(txtNextInstallment.Text);


            return hREmployeeSalaryDeducationInfoEntity;
        }

        private void SaveHREmployeeSalaryDeducationInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity = BuildHREmployeeSalaryDeducationInfoEntity();

                    Int64 result = -1;

                    if (hREmployeeSalaryDeducationInfoEntity.IsNew)
                    {
                        result = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().Add(hREmployeeSalaryDeducationInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeSalaryDeducationInfoID, hREmployeeSalaryDeducationInfoEntity.EmployeeSalaryDeducationInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().Update(hREmployeeSalaryDeducationInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeSalaryDeducationInfoID = 0;
                        _HREmployeeSalaryDeducationInfoEntity = new HREmployeeSalaryDeducationInfoEntity();
                        PrepareInitialView();
                        BindHREmployeeSalaryDeducationInfoList();

                        if (hREmployeeSalaryDeducationInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Deducation Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Deducation Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeSalaryDeducationInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Salary Deducation Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Salary Deducation Info Information.", false);
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

        protected void lvHREmployeeSalaryDeducationInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeSalaryDeducationInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeSalaryDeducationInfoID);

            if (EmployeeSalaryDeducationInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeSalaryDeducationInfoID = EmployeeSalaryDeducationInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryDeducationInfoEntity.FLD_NAME_EmployeeSalaryDeducationInfoID, EmployeeSalaryDeducationInfoID.ToString(), SQLMatchType.Equal);

                        HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity = new HREmployeeSalaryDeducationInfoEntity();


                        result = FCCHREmployeeSalaryDeducationInfo.GetFacadeCreate().Delete(hREmployeeSalaryDeducationInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeSalaryDeducationInfoID = 0;
                            _HREmployeeSalaryDeducationInfoEntity = new HREmployeeSalaryDeducationInfoEntity();
                            PrepareInitialView();
                            BindHREmployeeSalaryDeducationInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Deducation Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Salary Deducation Info.", true);
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

        protected void odsHREmployeeSalaryDeducationInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
            if (chbxFilter.Checked)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_EmployeeCode, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = "M2.FirstName + CASE WHEN M2.MiddleName != '' THEN ' ' + M2.MiddleName ELSE '' END + CASE WHEN M2.MiddleName != NULL THEN ' ' + M2.MiddleName ELSE '' END + ' ' + M2.LastName like '%" + txtSearchText.Text.ToString() + "%'";

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe2);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeSalaryDeducationInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeSalaryDeducationInfoID = 0;
            _HREmployeeSalaryDeducationInfoEntity = new HREmployeeSalaryDeducationInfoEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
