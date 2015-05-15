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
    public partial class HREmployeeSalaryBreakdownHistoryControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeSalaryBreakdownHistoryID
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

        public HREmployeeSalaryBreakdownHistoryEntity _HREmployeeSalaryBreakdownHistoryEntity
        {
            get
            {
                HREmployeeSalaryBreakdownHistoryEntity entity = new HREmployeeSalaryBreakdownHistoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeSalaryBreakdownHistoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeSalaryBreakdownHistoryEntity CurrentHREmployeeSalaryBreakdownHistoryEntity
        {
            get
            {
                if (_EmployeeSalaryBreakdownHistoryID > 0)
                {
                    if (_HREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakdownHistoryID != _EmployeeSalaryBreakdownHistoryID)
                    {
                        _HREmployeeSalaryBreakdownHistoryEntity = FCCHREmployeeSalaryBreakdownHistory.GetFacadeCreate().GetByID(_EmployeeSalaryBreakdownHistoryID);
                    }
                }

                return _HREmployeeSalaryBreakdownHistoryEntity;
            }
            set
            {
                _HREmployeeSalaryBreakdownHistoryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHREmployeeSalaryBreakDown(ddlEmployeeSalaryBreakDownID, false);
            MiscUtil.PopulateHREmployee(ddlCreatedByEmployeeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtEmployeeSalaryBreakdownHistoryID.Text = String.Empty;
            txtEmployeeSalaryInfoID.Text = String.Empty;
            txtEmployeeID.Text = String.Empty;
            txtYearlyRate.Text = String.Empty;
            txtMonthlyRate.Text = String.Empty;
            txtDailyRate.Text = String.Empty;
            txtOTHourlyRate.Text = String.Empty;
            txtHoulryRate.Text = String.Empty;
            txtCreateDate.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity = CurrentHREmployeeSalaryBreakdownHistoryEntity;


            if (!hREmployeeSalaryBreakdownHistoryEntity.IsNew)
            {
                txtEmployeeSalaryBreakdownHistoryID.Text = hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakdownHistoryID.ToString();
                if (ddlEmployeeSalaryBreakDownID.Items.Count > 0 && hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakDownID != null)
                {
                    ddlEmployeeSalaryBreakDownID.SelectedValue = hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakDownID.ToString();
                }

                txtEmployeeSalaryInfoID.Text = hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryInfoID.ToString();
                txtEmployeeID.Text = hREmployeeSalaryBreakdownHistoryEntity.EmployeeID.ToString();
                txtYearlyRate.Text = hREmployeeSalaryBreakdownHistoryEntity.YearlyRate.ToString();
                txtMonthlyRate.Text = hREmployeeSalaryBreakdownHistoryEntity.MonthlyRate.ToString();
                txtDailyRate.Text = hREmployeeSalaryBreakdownHistoryEntity.DailyRate.ToString();
                txtOTHourlyRate.Text = hREmployeeSalaryBreakdownHistoryEntity.OTHourlyRate.ToString();
                txtHoulryRate.Text = hREmployeeSalaryBreakdownHistoryEntity.HoulryRate.ToString();
                txtCreateDate.Text = hREmployeeSalaryBreakdownHistoryEntity.CreateDate.ToStringDefault();
                if (ddlCreatedByEmployeeID.Items.Count > 0 && hREmployeeSalaryBreakdownHistoryEntity.CreatedByEmployeeID != null)
                {
                    ddlCreatedByEmployeeID.SelectedValue = hREmployeeSalaryBreakdownHistoryEntity.CreatedByEmployeeID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeSalaryBreakdownHistoryList();
        }

        private void BindHREmployeeSalaryBreakdownHistoryList()
        {
            lvHREmployeeSalaryBreakdownHistory.DataBind();
        }

        private HREmployeeSalaryBreakdownHistoryEntity BuildHREmployeeSalaryBreakdownHistoryEntity()
        {
            HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity = CurrentHREmployeeSalaryBreakdownHistoryEntity;

            if (!txtEmployeeSalaryBreakdownHistoryID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakdownHistoryID = Int64.Parse(txtEmployeeSalaryBreakdownHistoryID.Text.Trim());
            }

            if (ddlEmployeeSalaryBreakDownID.Items.Count > 0)
            {
                if (ddlEmployeeSalaryBreakDownID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakDownID = Int64.Parse(ddlEmployeeSalaryBreakDownID.SelectedValue);
                }
            }

            if (!txtEmployeeSalaryInfoID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryInfoID = Int64.Parse(txtEmployeeSalaryInfoID.Text.Trim());
            }

            if (!txtEmployeeID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakdownHistoryEntity.EmployeeID = Int64.Parse(txtEmployeeID.Text.Trim());
            }

            if (!txtYearlyRate.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakdownHistoryEntity.YearlyRate = Decimal.Parse(txtYearlyRate.Text.Trim());
            }

            if (!txtMonthlyRate.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakdownHistoryEntity.MonthlyRate = Decimal.Parse(txtMonthlyRate.Text.Trim());
            }

            if (!txtDailyRate.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakdownHistoryEntity.DailyRate = Decimal.Parse(txtDailyRate.Text.Trim());
            }

            if (!txtOTHourlyRate.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakdownHistoryEntity.OTHourlyRate = Decimal.Parse(txtOTHourlyRate.Text.Trim());
            }

            if (!txtHoulryRate.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalaryBreakdownHistoryEntity.HoulryRate = Decimal.Parse(txtHoulryRate.Text.Trim());
            }

            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeSalaryBreakdownHistoryEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }

            if (ddlCreatedByEmployeeID.Items.Count > 0)
            {
                if (ddlCreatedByEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSalaryBreakdownHistoryEntity.CreatedByEmployeeID = Int64.Parse(ddlCreatedByEmployeeID.SelectedValue);
                }
            }


            return hREmployeeSalaryBreakdownHistoryEntity;
        }

        private void SaveHREmployeeSalaryBreakdownHistoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity = BuildHREmployeeSalaryBreakdownHistoryEntity();

                    Int64 result = -1;

                    if (hREmployeeSalaryBreakdownHistoryEntity.IsNew)
                    {
                        result = FCCHREmployeeSalaryBreakdownHistory.GetFacadeCreate().Add(hREmployeeSalaryBreakdownHistoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryBreakdownHistoryEntity.FLD_NAME_EmployeeSalaryBreakdownHistoryID, hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakdownHistoryID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeSalaryBreakdownHistory.GetFacadeCreate().Update(hREmployeeSalaryBreakdownHistoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeSalaryBreakdownHistoryID = 0;
                        _HREmployeeSalaryBreakdownHistoryEntity = new HREmployeeSalaryBreakdownHistoryEntity();
                        PrepareInitialView();
                        BindHREmployeeSalaryBreakdownHistoryList();

                        if (hREmployeeSalaryBreakdownHistoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Breakdown History Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Breakdown History Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeSalaryBreakdownHistoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Salary Breakdown History Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Salary Breakdown History Information.", false);
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

        protected void lvHREmployeeSalaryBreakdownHistory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeSalaryBreakdownHistoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeSalaryBreakdownHistoryID);

            if (EmployeeSalaryBreakdownHistoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeSalaryBreakdownHistoryID = EmployeeSalaryBreakdownHistoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryBreakdownHistoryEntity.FLD_NAME_EmployeeSalaryBreakdownHistoryID, EmployeeSalaryBreakdownHistoryID.ToString(), SQLMatchType.Equal);

                        HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity = new HREmployeeSalaryBreakdownHistoryEntity();


                        result = FCCHREmployeeSalaryBreakdownHistory.GetFacadeCreate().Delete(hREmployeeSalaryBreakdownHistoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeSalaryBreakdownHistoryID = 0;
                            _HREmployeeSalaryBreakdownHistoryEntity = new HREmployeeSalaryBreakdownHistoryEntity();
                            PrepareInitialView();
                            BindHREmployeeSalaryBreakdownHistoryList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Breakdown History has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Salary Breakdown History.", true);
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

        protected void odsHREmployeeSalaryBreakdownHistory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeSalaryBreakdownHistoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeSalaryBreakdownHistoryID = 0;
            _HREmployeeSalaryBreakdownHistoryEntity = new HREmployeeSalaryBreakdownHistoryEntity();
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
