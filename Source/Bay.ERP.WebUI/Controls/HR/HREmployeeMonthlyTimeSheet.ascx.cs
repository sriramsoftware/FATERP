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
    public partial class HREmployeeMonthlyTimeSheetControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeMonthlyTimeSheetID
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

        public HREmployeeMonthlyTimeSheetEntity _HREmployeeMonthlyTimeSheetEntity
        {
            get
            {
                HREmployeeMonthlyTimeSheetEntity entity = new HREmployeeMonthlyTimeSheetEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeMonthlyTimeSheetEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeMonthlyTimeSheetEntity CurrentHREmployeeMonthlyTimeSheetEntity
        {
            get
            {
                if (_EmployeeMonthlyTimeSheetID > 0)
                {
                    if (_HREmployeeMonthlyTimeSheetEntity.EmployeeMonthlyTimeSheetID != _EmployeeMonthlyTimeSheetID)
                    {
                        _HREmployeeMonthlyTimeSheetEntity = FCCHREmployeeMonthlyTimeSheet.GetFacadeCreate().GetByID(_EmployeeMonthlyTimeSheetID);
                    }
                }

                return _HREmployeeMonthlyTimeSheetEntity;
            }
            set
            {
                _HREmployeeMonthlyTimeSheetEntity = value;
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

            txtFiscalYearID.Text = String.Empty;
            txtSalarySessionID.Text = String.Empty;
            txtAttendanceLeaveAndHolidayCategoryID.Text = String.Empty;
            txtNote.Text = String.Empty;
            txtWorkingDay.Text = String.Empty;
            txtYear.Text = String.Empty;
            txtMonth.Text = String.Empty;
            txtDay.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtDate.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity = CurrentHREmployeeMonthlyTimeSheetEntity;


            if (!hREmployeeMonthlyTimeSheetEntity.IsNew)
            {
                txtFiscalYearID.Text = hREmployeeMonthlyTimeSheetEntity.FiscalYearID.ToString();
                txtSalarySessionID.Text = hREmployeeMonthlyTimeSheetEntity.SalarySessionID.ToString();
                txtAttendanceLeaveAndHolidayCategoryID.Text = hREmployeeMonthlyTimeSheetEntity.AttendanceLeaveAndHolidayCategoryID.ToString();
                txtNote.Text = hREmployeeMonthlyTimeSheetEntity.Note.ToString();
                txtWorkingDay.Text = hREmployeeMonthlyTimeSheetEntity.WorkingDay.ToStringDefault();
                txtYear.Text = hREmployeeMonthlyTimeSheetEntity.Year.ToString();
                txtMonth.Text = hREmployeeMonthlyTimeSheetEntity.Month.ToString();
                txtDay.Text = hREmployeeMonthlyTimeSheetEntity.Day.ToString();
                txtRemarks.Text = hREmployeeMonthlyTimeSheetEntity.Remarks.ToString();
                txtDate.Text = hREmployeeMonthlyTimeSheetEntity.Date.ToStringDefault();
                chkIsRemoved.Checked = hREmployeeMonthlyTimeSheetEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeMonthlyTimeSheetList();
        }

        private void BindHREmployeeMonthlyTimeSheetList()
        {
            lvHREmployeeMonthlyTimeSheet.DataBind();
        }

        private HREmployeeMonthlyTimeSheetEntity BuildHREmployeeMonthlyTimeSheetEntity()
        {
            HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity = CurrentHREmployeeMonthlyTimeSheetEntity;

            if (!txtFiscalYearID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeMonthlyTimeSheetEntity.FiscalYearID = Int64.Parse(txtFiscalYearID.Text.Trim());
            }

            if (!txtSalarySessionID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeMonthlyTimeSheetEntity.SalarySessionID = Int64.Parse(txtSalarySessionID.Text.Trim());
            }

            if (!txtAttendanceLeaveAndHolidayCategoryID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeMonthlyTimeSheetEntity.AttendanceLeaveAndHolidayCategoryID = Int64.Parse(txtAttendanceLeaveAndHolidayCategoryID.Text.Trim());
            }

            hREmployeeMonthlyTimeSheetEntity.Note = txtNote.Text.Trim();
            if (txtWorkingDay.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeMonthlyTimeSheetEntity.WorkingDay = MiscUtil.ParseToDateTime(txtWorkingDay.Text);
            }

            if (!txtYear.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeMonthlyTimeSheetEntity.Year = Int32.Parse(txtYear.Text.Trim());
            }

            if (!txtMonth.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeMonthlyTimeSheetEntity.Month = Int32.Parse(txtMonth.Text.Trim());
            }

            if (!txtDay.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeMonthlyTimeSheetEntity.Day = Int32.Parse(txtDay.Text.Trim());
            }

            hREmployeeMonthlyTimeSheetEntity.Remarks = txtRemarks.Text.Trim();
            if (txtDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeMonthlyTimeSheetEntity.Date = MiscUtil.ParseToDateTime(txtDate.Text);
            }

            hREmployeeMonthlyTimeSheetEntity.IsRemoved = chkIsRemoved.Checked;


            return hREmployeeMonthlyTimeSheetEntity;
        }

        private void SaveHREmployeeMonthlyTimeSheetEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity = BuildHREmployeeMonthlyTimeSheetEntity();

                    Int64 result = -1;

                    if (hREmployeeMonthlyTimeSheetEntity.IsNew)
                    {
                        result = FCCHREmployeeMonthlyTimeSheet.GetFacadeCreate().Add(hREmployeeMonthlyTimeSheetEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetEntity.FLD_NAME_EmployeeMonthlyTimeSheetID, hREmployeeMonthlyTimeSheetEntity.EmployeeMonthlyTimeSheetID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeMonthlyTimeSheet.GetFacadeCreate().Update(hREmployeeMonthlyTimeSheetEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeMonthlyTimeSheetID = 0;
                        _HREmployeeMonthlyTimeSheetEntity = new HREmployeeMonthlyTimeSheetEntity();
                        PrepareInitialView();
                        BindHREmployeeMonthlyTimeSheetList();

                        if (hREmployeeMonthlyTimeSheetEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Monthly Time Sheet Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Monthly Time Sheet Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeMonthlyTimeSheetEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Monthly Time Sheet Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Monthly Time Sheet Information.", false);
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

        protected void lvHREmployeeMonthlyTimeSheet_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeMonthlyTimeSheetID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeMonthlyTimeSheetID);

            if (EmployeeMonthlyTimeSheetID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeMonthlyTimeSheetID = EmployeeMonthlyTimeSheetID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetEntity.FLD_NAME_EmployeeMonthlyTimeSheetID, EmployeeMonthlyTimeSheetID.ToString(), SQLMatchType.Equal);

                        HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity = new HREmployeeMonthlyTimeSheetEntity();


                        result = FCCHREmployeeMonthlyTimeSheet.GetFacadeCreate().Delete(hREmployeeMonthlyTimeSheetEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeMonthlyTimeSheetID = 0;
                            _HREmployeeMonthlyTimeSheetEntity = new HREmployeeMonthlyTimeSheetEntity();
                            PrepareInitialView();
                            BindHREmployeeMonthlyTimeSheetList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Monthly Time Sheet has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Monthly Time Sheet.", true);
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

        protected void odsHREmployeeMonthlyTimeSheet_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeMonthlyTimeSheetEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeMonthlyTimeSheetID = 0;
            _HREmployeeMonthlyTimeSheetEntity = new HREmployeeMonthlyTimeSheetEntity();
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
