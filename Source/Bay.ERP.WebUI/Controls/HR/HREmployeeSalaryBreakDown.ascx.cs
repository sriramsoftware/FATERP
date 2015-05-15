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
    public partial class HREmployeeSalaryBreakDownControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeSalaryBreakDownID
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

        public HREmployeeSalaryBreakDownEntity _HREmployeeSalaryBreakDownEntity
        {
            get
            {
                HREmployeeSalaryBreakDownEntity entity = new HREmployeeSalaryBreakDownEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeSalaryBreakDownEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeSalaryBreakDownEntity CurrentHREmployeeSalaryBreakDownEntity
        {
            get
            {
                if (_EmployeeSalaryBreakDownID > 0)
                {
                    if (_HREmployeeSalaryBreakDownEntity.EmployeeSalaryBreakDownID != _EmployeeSalaryBreakDownID)
                    {
                        _HREmployeeSalaryBreakDownEntity = FCCHREmployeeSalaryBreakDown.GetFacadeCreate().GetByID(_EmployeeSalaryBreakDownID);
                    }
                }

                return _HREmployeeSalaryBreakDownEntity;
            }
            set
            {
                _HREmployeeSalaryBreakDownEntity = value;
            }
        }

        public Int64 OverViewEmployeeSalaryInfoID
        {
            get
            {
                Int64 OverViewEmployeeSalaryInfoID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_HR_EMPLOYEE_SALARY_INFO_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_HR_EMPLOYEE_SALARY_INFO_ID], out OverViewEmployeeSalaryInfoID);
                }

                return OverViewEmployeeSalaryInfoID;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            //MiscUtil.PopulateHREmployeeSalaryInfo(ddlEmployeeSalaryInfoID, false);
            MiscUtil.PopulateHREmployeeBySalaryInfoID(ddlEmployeeID, false, OverViewEmployeeSalaryInfoID);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtYearlyRate.Text = String.Empty;
            txtMonthlyRate.Text = String.Empty;
            txtDailyRate.Text = String.Empty;
            txtOTHourlyRate.Text = String.Empty;
            txtHoulryRate.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity = CurrentHREmployeeSalaryBreakDownEntity;


            if (!hREmployeeSalaryBreakDownEntity.IsNew)
            {
                if (ddlEmployeeID.Items.Count > 0 && hREmployeeSalaryBreakDownEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = hREmployeeSalaryBreakDownEntity.EmployeeID.ToString();
                }

                txtYearlyRate.Text = hREmployeeSalaryBreakDownEntity.YearlyRate.ToString();
                txtMonthlyRate.Text = hREmployeeSalaryBreakDownEntity.MonthlyRate.ToString();
                txtDailyRate.Text = hREmployeeSalaryBreakDownEntity.DailyRate.ToString();
                txtOTHourlyRate.Text = hREmployeeSalaryBreakDownEntity.OTHourlyRate.ToString();
                txtHoulryRate.Text = hREmployeeSalaryBreakDownEntity.HoulryRate.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeSalaryBreakDownList();
        }

        private void BindHREmployeeSalaryBreakDownList()
        {
            lvHREmployeeSalaryBreakDown.DataBind();
        }

        private HREmployeeSalaryBreakDownEntity BuildHREmployeeSalaryBreakDownEntity()
        {
            HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity = CurrentHREmployeeSalaryBreakDownEntity;
            hREmployeeSalaryBreakDownEntity.EmployeeSalaryInfoID = OverViewEmployeeSalaryInfoID;

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSalaryBreakDownEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            if (!txtYearlyRate.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakDownEntity.YearlyRate = Decimal.Parse(txtYearlyRate.Text.Trim());
            }

            if (!txtMonthlyRate.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakDownEntity.MonthlyRate = Decimal.Parse(txtMonthlyRate.Text.Trim());
            }

            if (!txtDailyRate.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakDownEntity.DailyRate = Decimal.Parse(txtDailyRate.Text.Trim());
            }

            if (!txtOTHourlyRate.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakDownEntity.OTHourlyRate = Decimal.Parse(txtOTHourlyRate.Text.Trim());
            }

            if (!txtHoulryRate.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakDownEntity.HoulryRate = Decimal.Parse(txtHoulryRate.Text.Trim());
            }


            return hREmployeeSalaryBreakDownEntity;
        }

        private void SaveHREmployeeSalaryBreakDownEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity = BuildHREmployeeSalaryBreakDownEntity();

                    Int64 result = -1;

                    if (hREmployeeSalaryBreakDownEntity.IsNew)
                    {
                        result = FCCHREmployeeSalaryBreakDown.GetFacadeCreate().Add(hREmployeeSalaryBreakDownEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryBreakDownEntity.FLD_NAME_EmployeeSalaryBreakDownID, hREmployeeSalaryBreakDownEntity.EmployeeSalaryBreakDownID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeSalaryBreakDown.GetFacadeCreate().Update(hREmployeeSalaryBreakDownEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeSalaryBreakDownID = 0;
                        _HREmployeeSalaryBreakDownEntity = new HREmployeeSalaryBreakDownEntity();
                        PrepareInitialView();
                        BindHREmployeeSalaryBreakDownList();

                        if (hREmployeeSalaryBreakDownEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Break Down Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Break Down Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeSalaryBreakDownEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Salary Break Down Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Salary Break Down Information.", false);
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

        protected void lvHREmployeeSalaryBreakDown_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeSalaryBreakDownID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeSalaryBreakDownID);

            if (EmployeeSalaryBreakDownID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeSalaryBreakDownID = EmployeeSalaryBreakDownID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryBreakDownEntity.FLD_NAME_EmployeeSalaryBreakDownID, EmployeeSalaryBreakDownID.ToString(), SQLMatchType.Equal);

                        HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity = new HREmployeeSalaryBreakDownEntity();


                        result = FCCHREmployeeSalaryBreakDown.GetFacadeCreate().Delete(hREmployeeSalaryBreakDownEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeSalaryBreakDownID = 0;
                            _HREmployeeSalaryBreakDownEntity = new HREmployeeSalaryBreakDownEntity();
                            PrepareInitialView();
                            BindHREmployeeSalaryBreakDownList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Break Down has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Salary Break Down.", true);
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

        protected void odsHREmployeeSalaryBreakDown_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryInfoEntity.FLD_NAME_EmployeeSalaryInfoID, OverViewEmployeeSalaryInfoID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeSalaryBreakDownEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeSalaryBreakDownID = 0;
            _HREmployeeSalaryBreakDownEntity = new HREmployeeSalaryBreakDownEntity();
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
