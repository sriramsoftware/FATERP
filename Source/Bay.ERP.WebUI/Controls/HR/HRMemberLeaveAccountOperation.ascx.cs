// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;


namespace Bay.ERP.Web.UI
{
    public partial class HRMemberLeaveAccountOperationControl : BaseControl
    {       
        #region Properties

        public Int64 _MemberLeaveAccountID
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

        public HRMemberLeaveAccountEntity _HRMemberLeaveAccountEntity
        {
            get
            {
                HRMemberLeaveAccountEntity entity = new HRMemberLeaveAccountEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HRMemberLeaveAccountEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HRMemberLeaveAccountEntity CurrentHRMemberLeaveAccountEntity
        {
            get
            {
                if (_MemberLeaveAccountID > 0)
                {
                    if (_HRMemberLeaveAccountEntity.MemberLeaveAccountID != _MemberLeaveAccountID)
                    {
                        _HRMemberLeaveAccountEntity = FCCHRMemberLeaveAccount.GetFacadeCreate().GetByID(_MemberLeaveAccountID);
                    }
                }

                return _HRMemberLeaveAccountEntity;
            }
            set
            {
                _HRMemberLeaveAccountEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDAttendanceLeaveHolidayList(ddlAttendanceLeaveHolidayListID, true);
            MiscUtil.PopulateMDSalarySession(ddlSalarySessionID, true);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
            MiscUtil.PopulateACFiscalYear(ddlFiscalYearID, false);
            MiscUtil.PopulateMDLeaveCategory(ddlLeaveCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtUpdateDate.Text = String.Empty;
            txtEarnedDays.Text = String.Empty;
            txtAccuredDays.Text = String.Empty;
            txtUsedDays.Text = String.Empty;
            txtBalanceDays.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity = CurrentHRMemberLeaveAccountEntity;


            if (!hRMemberLeaveAccountEntity.IsNew)
            {
                if (ddlAttendanceLeaveHolidayListID.Items.Count > 0 && hRMemberLeaveAccountEntity.AttendanceLeaveHolidayListID != null)
                {
                    ddlAttendanceLeaveHolidayListID.SelectedValue = hRMemberLeaveAccountEntity.AttendanceLeaveHolidayListID.ToString();
                }

                if (ddlSalarySessionID.Items.Count > 0 && hRMemberLeaveAccountEntity.SalarySessionID != null)
                {
                    ddlSalarySessionID.SelectedValue = hRMemberLeaveAccountEntity.SalarySessionID.ToString();
                }

                if (ddlEmployeeID.Items.Count > 0 && hRMemberLeaveAccountEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = hRMemberLeaveAccountEntity.EmployeeID.ToString();
                }

                if (ddlFiscalYearID.Items.Count > 0 && hRMemberLeaveAccountEntity.FiscalYearID != null)
                {
                    ddlFiscalYearID.SelectedValue = hRMemberLeaveAccountEntity.FiscalYearID.ToString();
                }

                if (ddlLeaveCategoryID.Items.Count > 0 && hRMemberLeaveAccountEntity.LeaveCategoryID != null)
                {
                    ddlLeaveCategoryID.SelectedValue = hRMemberLeaveAccountEntity.LeaveCategoryID.ToString();
                }

                txtUpdateDate.Text = hRMemberLeaveAccountEntity.UpdateDate.ToStringDefault();
                txtEarnedDays.Text = hRMemberLeaveAccountEntity.EarnedDays.ToString();
                txtAccuredDays.Text = hRMemberLeaveAccountEntity.AccuredDays.ToString();
                txtUsedDays.Text = hRMemberLeaveAccountEntity.UsedDays.ToString();
                txtBalanceDays.Text = hRMemberLeaveAccountEntity.BalanceDays.ToString();
                chkIsRemoved.Checked = hRMemberLeaveAccountEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHRMemberLeaveAccountList();
        }

        private void BindHRMemberLeaveAccountList()
        {
            lvHRMemberLeaveAccount.DataBind();
        }

        private HRMemberLeaveAccountEntity BuildHRMemberLeaveAccountEntity()
        {
            HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity = CurrentHRMemberLeaveAccountEntity;

            if (ddlAttendanceLeaveHolidayListID.Items.Count > 0)
            {
                if (ddlAttendanceLeaveHolidayListID.SelectedValue == "0")
                {
                    hRMemberLeaveAccountEntity.AttendanceLeaveHolidayListID = null;
                }
                else
                {
                    hRMemberLeaveAccountEntity.AttendanceLeaveHolidayListID = Int64.Parse(ddlAttendanceLeaveHolidayListID.SelectedValue);
                }
            }

            if (ddlSalarySessionID.Items.Count > 0)
            {
                if (ddlSalarySessionID.SelectedValue == "0")
                {
                    hRMemberLeaveAccountEntity.SalarySessionID = null;
                }
                else
                {
                    hRMemberLeaveAccountEntity.SalarySessionID = Int64.Parse(ddlSalarySessionID.SelectedValue);
                }
            }

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    hRMemberLeaveAccountEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            if (txtUpdateDate.Text.Trim().IsNotNullOrEmpty())
            {
                hRMemberLeaveAccountEntity.UpdateDate = MiscUtil.ParseToDateTime(txtUpdateDate.Text);
            }
            else
            {
                hRMemberLeaveAccountEntity.UpdateDate = null;
            }

            if (!txtEarnedDays.Text.Trim().IsNullOrEmpty())
            {
                hRMemberLeaveAccountEntity.EarnedDays = Decimal.Parse(txtEarnedDays.Text.Trim());
            }
            else
            {
                hRMemberLeaveAccountEntity.EarnedDays = null;
            }

            if (!txtAccuredDays.Text.Trim().IsNullOrEmpty())
            {
                hRMemberLeaveAccountEntity.AccuredDays = Decimal.Parse(txtAccuredDays.Text.Trim());
            }
            else
            {
                hRMemberLeaveAccountEntity.AccuredDays = null;
            }

            if (!txtUsedDays.Text.Trim().IsNullOrEmpty())
            {
                hRMemberLeaveAccountEntity.UsedDays = Decimal.Parse(txtUsedDays.Text.Trim());
            }
            else
            {
                hRMemberLeaveAccountEntity.UsedDays = null;
            }

            if (!txtBalanceDays.Text.Trim().IsNullOrEmpty())
            {
                hRMemberLeaveAccountEntity.BalanceDays = Decimal.Parse(txtBalanceDays.Text.Trim());
            }
            else
            {
                hRMemberLeaveAccountEntity.BalanceDays = null;
            }

            if (ddlFiscalYearID.Items.Count > 0)
            {
                if (ddlFiscalYearID.SelectedValue == "0")
                {
                }
                else
                {
                    hRMemberLeaveAccountEntity.FiscalYearID = Int64.Parse(ddlFiscalYearID.SelectedValue);
                }
            }

            if (ddlLeaveCategoryID.Items.Count > 0)
            {
                if (ddlLeaveCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hRMemberLeaveAccountEntity.LeaveCategoryID = Int64.Parse(ddlLeaveCategoryID.SelectedValue);
                }
            }

            hRMemberLeaveAccountEntity.IsRemoved = chkIsRemoved.Checked;


            return hRMemberLeaveAccountEntity;
        }

        private void SaveHRMemberLeaveAccountEntity()
        {
            if (IsValid)
            {
                try
                {
                    HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity = BuildHRMemberLeaveAccountEntity();

                    Int64 result = -1;

                    if (hRMemberLeaveAccountEntity.IsNew)
                    {
                        result = FCCHRMemberLeaveAccount.GetFacadeCreate().Add(hRMemberLeaveAccountEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRMemberLeaveAccountEntity.FLD_NAME_MemberLeaveAccountID, hRMemberLeaveAccountEntity.MemberLeaveAccountID.ToString(), SQLMatchType.Equal);
                        result = FCCHRMemberLeaveAccount.GetFacadeCreate().Update(hRMemberLeaveAccountEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MemberLeaveAccountID = 0;
                        _HRMemberLeaveAccountEntity = new HRMemberLeaveAccountEntity();
                        PrepareInitialView();
                        BindHRMemberLeaveAccountList();

                        if (hRMemberLeaveAccountEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Member Leave Account Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Member Leave Account Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hRMemberLeaveAccountEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Member Leave Account Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Member Leave Account Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void CalculateLeave()
        {
            if (chbxFilter.Checked)
            {
                HREmployeeEntity hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(Int64.Parse(ddlEmployeeID.SelectedValue));
                ACFiscalYearEntity aCFiscalYearEntity = FCCACFiscalYear.GetFacadeCreate().GetByID(Int64.Parse(ddlFiscalYearID.SelectedValue));
                MDLeaveCategoryEntity mDLeaveCategoryEntity = FCCMDLeaveCategory.GetFacadeCreate().GetByID(Int64.Parse(ddlLeaveCategoryID.SelectedValue));
                IList<MDLeavePolicyEntity> mDLeavePolicyList = FCCMDLeavePolicy.GetFacadeCreate().GetIL(1000, 1, String.Empty, String.Empty, DatabaseOperationType.Load);
                Decimal leaveInDays = 0;
                if (mDLeavePolicyList.Count > 0 && mDLeavePolicyList != null)
                {
                    mDLeavePolicyList[0] = mDLeavePolicyList.Single(x => (x.LeaveCategoryID == mDLeaveCategoryEntity.LeaveCategoryID && x.FiscalYearID == aCFiscalYearEntity.FiscalYearID && x.EmployeeJobTypeID == hREmployeeEntity.EmployeeJobTypeID));

                    if (mDLeavePolicyList[0].LeaveCategoryID == mDLeaveCategoryEntity.LeaveCategoryID && mDLeavePolicyList[0].FiscalYearID == aCFiscalYearEntity.FiscalYearID)
                    {
                        leaveInDays = mDLeavePolicyList[0].LeaveInDays;
                    }

                    if (hREmployeeEntity.EmployeeJobTypeID == MasterDataConstants.MDEmployeeJobType.FULLTIME && hREmployeeEntity.ConfirmDate <= aCFiscalYearEntity.BeginDate)
                    {
                        txtEarnedDays.Text = leaveInDays.ToString().Trim(); ;
                    }
                    else if (hREmployeeEntity.EmployeeJobTypeID == MasterDataConstants.MDEmployeeJobType.PARTTIMENOTLESS75PERCENT)
                    {
                        txtEarnedDays.Text = leaveInDays.ToString().Trim();
                    }
                    else if (hREmployeeEntity.EmployeeJobTypeID == MasterDataConstants.MDEmployeeJobType.FULLTIME && hREmployeeEntity.ConfirmDate == null)
                    {
                        txtEarnedDays.Text = "0.0";
                    }
                    else if (hREmployeeEntity.EmployeeJobTypeID == MasterDataConstants.MDEmployeeJobType.PARTTIMENOTLESS50PERCENT)
                    {
                        txtEarnedDays.Text = leaveInDays.ToString().Trim();
                    }
                    else if (hREmployeeEntity.EmployeeJobTypeID == MasterDataConstants.MDEmployeeJobType.FULLTIME && (hREmployeeEntity.ConfirmDate <= aCFiscalYearEntity.BeginDate && hREmployeeEntity.ConfirmDate >= aCFiscalYearEntity.EndDate))
                    {
                        DateTime s = aCFiscalYearEntity.EndDate;
                        DateTime e = (DateTime)hREmployeeEntity.ConfirmDate;

                        Decimal Month = s.Subtract(e).Days / (365 / 12);
                        Month = (leaveInDays / 12) * Month;
                        txtEarnedDays.Text = Month.ToString().Trim(); ;
                    }
                    else
                    {
                        txtEarnedDays.Text = "0";
                    }
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage,"There is no policy in this fiscal year and may be not active please insert data in Leave Policy.",false);
                }
            }
            else
            {
                txtEarnedDays.Text = String.Empty;
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

        protected void lvHRMemberLeaveAccount_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MemberLeaveAccountID;

            Int64.TryParse(e.CommandArgument.ToString(), out MemberLeaveAccountID);

            if (MemberLeaveAccountID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MemberLeaveAccountID = MemberLeaveAccountID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRMemberLeaveAccountEntity.FLD_NAME_MemberLeaveAccountID, MemberLeaveAccountID.ToString(), SQLMatchType.Equal);

                        HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity = new HRMemberLeaveAccountEntity();


                        result = FCCHRMemberLeaveAccount.GetFacadeCreate().Delete(hRMemberLeaveAccountEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MemberLeaveAccountID = 0;
                            _HRMemberLeaveAccountEntity = new HRMemberLeaveAccountEntity();
                            PrepareInitialView();
                            BindHRMemberLeaveAccountList();

                            MiscUtil.ShowMessage(lblMessage, "Member Leave Account has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Member Leave Account.", true);
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

        protected void odsHRMemberLeaveAccount_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
            
            if (chbxFiltring.Checked)
            {
                fe = "M2.FirstName + CASE WHEN M2.MiddleName != '' THEN ' ' + M2.MiddleName ELSE '' END + CASE WHEN M2.MiddleName != NULL THEN ' ' + M2.MiddleName ELSE '' END + ' ' + M2.LastName like '%" + txtSearchText.Text.ToString() + "%'";
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHRMemberLeaveAccountEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MemberLeaveAccountID = 0;
            _HRMemberLeaveAccountEntity = new HRMemberLeaveAccountEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = null;
            String connectionString = ConfigurationManager.ConnectionStrings["ETCON"].ConnectionString;

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("InsertLeave_SET", sqlConnection);
                command.CommandType =  System.Data.CommandType.StoredProcedure;
 
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
         

        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            CalculateLeave();
        }
      
        protected void chbxFiltering_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
