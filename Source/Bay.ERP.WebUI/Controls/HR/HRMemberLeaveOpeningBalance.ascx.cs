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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class HRMemberLeaveOpeningBalanceControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _MemberLeaveOpeningBalanceID
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

        public HRMemberLeaveOpeningBalanceEntity _HRMemberLeaveOpeningBalanceEntity
        {
            get
            {
                HRMemberLeaveOpeningBalanceEntity entity = new HRMemberLeaveOpeningBalanceEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HRMemberLeaveOpeningBalanceEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HRMemberLeaveOpeningBalanceEntity CurrentHRMemberLeaveOpeningBalanceEntity
        {
            get
            {
                if (_MemberLeaveOpeningBalanceID > 0)
                {
                    if (_HRMemberLeaveOpeningBalanceEntity.MemberLeaveOpeningBalanceID != _MemberLeaveOpeningBalanceID)
                    {
                        _HRMemberLeaveOpeningBalanceEntity = FCCHRMemberLeaveOpeningBalance.GetFacadeCreate().GetByID(_MemberLeaveOpeningBalanceID);
                    }
                }

                return _HRMemberLeaveOpeningBalanceEntity;
            }
            set
            {
                _HRMemberLeaveOpeningBalanceEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDAttendanceLeaveHolidayList(ddlAttendanceLeaveHolidayListID, false);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtBalanceDays.Text = String.Empty;
            txtBalanceAsOffDate.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity = CurrentHRMemberLeaveOpeningBalanceEntity;


            if (!hRMemberLeaveOpeningBalanceEntity.IsNew)
            {
                if (ddlAttendanceLeaveHolidayListID.Items.Count > 0 && hRMemberLeaveOpeningBalanceEntity.AttendanceLeaveHolidayListID != null)
                {
                    ddlAttendanceLeaveHolidayListID.SelectedValue = hRMemberLeaveOpeningBalanceEntity.AttendanceLeaveHolidayListID.ToString();
                }

                if (ddlEmployeeID.Items.Count > 0 && hRMemberLeaveOpeningBalanceEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = hRMemberLeaveOpeningBalanceEntity.EmployeeID.ToString();
                }

                txtBalanceDays.Text = hRMemberLeaveOpeningBalanceEntity.BalanceDays.ToString();
                txtBalanceAsOffDate.Text = hRMemberLeaveOpeningBalanceEntity.BalanceAsOffDate.ToStringDefault();
                txtRemarks.Text = hRMemberLeaveOpeningBalanceEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHRMemberLeaveOpeningBalanceList();
        }

        private void BindHRMemberLeaveOpeningBalanceList()
        {
            lvHRMemberLeaveOpeningBalance.DataBind();
        }

        private HRMemberLeaveOpeningBalanceEntity BuildHRMemberLeaveOpeningBalanceEntity()
        {
            HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity = CurrentHRMemberLeaveOpeningBalanceEntity;

            if (ddlAttendanceLeaveHolidayListID.Items.Count > 0)
            {
                if (ddlAttendanceLeaveHolidayListID.SelectedValue == "0")
                {
                }
                else
                {
                    hRMemberLeaveOpeningBalanceEntity.AttendanceLeaveHolidayListID = Int64.Parse(ddlAttendanceLeaveHolidayListID.SelectedValue);
                }
            }

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    hRMemberLeaveOpeningBalanceEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            if (!txtBalanceDays.Text.Trim().IsNullOrEmpty())
            {
                hRMemberLeaveOpeningBalanceEntity.BalanceDays = Decimal.Parse(txtBalanceDays.Text.Trim());
            }
            else
            {
                hRMemberLeaveOpeningBalanceEntity.BalanceDays = null;
            }

            if (txtBalanceAsOffDate.Text.Trim().IsNotNullOrEmpty())
            {
                hRMemberLeaveOpeningBalanceEntity.BalanceAsOffDate = MiscUtil.ParseToDateTime(txtBalanceAsOffDate.Text);
            }
            else
            {
                hRMemberLeaveOpeningBalanceEntity.BalanceAsOffDate = null;
            }

            hRMemberLeaveOpeningBalanceEntity.Remarks = txtRemarks.Text.Trim();

            return hRMemberLeaveOpeningBalanceEntity;
        }

        private void SaveHRMemberLeaveOpeningBalanceEntity()
        {
            if (IsValid)
            {
                try
                {
                    HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity = BuildHRMemberLeaveOpeningBalanceEntity();

                    Int64 result = -1;

                    if (hRMemberLeaveOpeningBalanceEntity.IsNew)
                    {
                        result = FCCHRMemberLeaveOpeningBalance.GetFacadeCreate().Add(hRMemberLeaveOpeningBalanceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRMemberLeaveOpeningBalanceEntity.FLD_NAME_MemberLeaveOpeningBalanceID, hRMemberLeaveOpeningBalanceEntity.MemberLeaveOpeningBalanceID.ToString(), SQLMatchType.Equal);
                        result = FCCHRMemberLeaveOpeningBalance.GetFacadeCreate().Update(hRMemberLeaveOpeningBalanceEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MemberLeaveOpeningBalanceID = 0;
                        _HRMemberLeaveOpeningBalanceEntity = new HRMemberLeaveOpeningBalanceEntity();
                        PrepareInitialView();
                        BindHRMemberLeaveOpeningBalanceList();

                        if (hRMemberLeaveOpeningBalanceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Member Leave Opening Balance Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Member Leave Opening Balance Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hRMemberLeaveOpeningBalanceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Member Leave Opening Balance Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Member Leave Opening Balance Information.", false);
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

        protected void lvHRMemberLeaveOpeningBalance_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MemberLeaveOpeningBalanceID;

            Int64.TryParse(e.CommandArgument.ToString(), out MemberLeaveOpeningBalanceID);

            if (MemberLeaveOpeningBalanceID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MemberLeaveOpeningBalanceID = MemberLeaveOpeningBalanceID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRMemberLeaveOpeningBalanceEntity.FLD_NAME_MemberLeaveOpeningBalanceID, MemberLeaveOpeningBalanceID.ToString(), SQLMatchType.Equal);

                        HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity = new HRMemberLeaveOpeningBalanceEntity();


                        result = FCCHRMemberLeaveOpeningBalance.GetFacadeCreate().Delete(hRMemberLeaveOpeningBalanceEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MemberLeaveOpeningBalanceID = 0;
                            _HRMemberLeaveOpeningBalanceEntity = new HRMemberLeaveOpeningBalanceEntity();
                            PrepareInitialView();
                            BindHRMemberLeaveOpeningBalanceList();

                            MiscUtil.ShowMessage(lblMessage, "Member Leave Opening Balance has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Member Leave Opening Balance.", true);
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

        protected void odsHRMemberLeaveOpeningBalance_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHRMemberLeaveOpeningBalanceEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MemberLeaveOpeningBalanceID = 0;
            _HRMemberLeaveOpeningBalanceEntity = new HRMemberLeaveOpeningBalanceEntity();
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
