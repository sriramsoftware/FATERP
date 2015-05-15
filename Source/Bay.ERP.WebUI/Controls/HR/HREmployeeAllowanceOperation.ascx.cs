// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 12:08:49




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
    public partial class HREmployeeAllowanceOperationControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeAllowanceID
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

        public HREmployeeAllowanceEntity _HREmployeeAllowanceEntity
        {
            get
            {
                HREmployeeAllowanceEntity entity = new HREmployeeAllowanceEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeAllowanceEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeAllowanceEntity CurrentHREmployeeAllowanceEntity
        {
            get
            {
                if (_EmployeeAllowanceID > 0)
                {
                    if (_HREmployeeAllowanceEntity.EmployeeAllowanceID != _EmployeeAllowanceID)
                    {
                        _HREmployeeAllowanceEntity = FCCHREmployeeAllowance.GetFacadeCreate().GetByID(_EmployeeAllowanceID);
                    }
                }

                return _HREmployeeAllowanceEntity;
            }
            set
            {
                _HREmployeeAllowanceEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
            MiscUtil.PopulateACFiscalYear(ddlFiscalYearID, false);
            MiscUtil.PopulateMDAllowanceCategory(ddlAllowanceCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAmount.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeAllowanceEntity hREmployeeAllowanceEntity = CurrentHREmployeeAllowanceEntity;


            if (!hREmployeeAllowanceEntity.IsNew)
            {
                if (ddlEmployeeID.Items.Count > 0 && hREmployeeAllowanceEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = hREmployeeAllowanceEntity.EmployeeID.ToString();
                }

                if (ddlFiscalYearID.Items.Count > 0 && hREmployeeAllowanceEntity.FiscalYearID != null)
                {
                    ddlFiscalYearID.SelectedValue = hREmployeeAllowanceEntity.FiscalYearID.ToString();
                }

                if (ddlAllowanceCategoryID.Items.Count > 0 && hREmployeeAllowanceEntity.AllowanceCategoryID != null)
                {
                    ddlAllowanceCategoryID.SelectedValue = hREmployeeAllowanceEntity.AllowanceCategoryID.ToString();
                }

                txtAmount.Text = hREmployeeAllowanceEntity.Amount.ToString();
                txtRemarks.Text = hREmployeeAllowanceEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeAllowanceList();
        }

        private void BindHREmployeeAllowanceList()
        {
            lvHREmployeeAllowance.DataBind();
        }

        private HREmployeeAllowanceEntity BuildHREmployeeAllowanceEntity()
        {
            HREmployeeAllowanceEntity hREmployeeAllowanceEntity = CurrentHREmployeeAllowanceEntity;

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeAllowanceEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            if (ddlFiscalYearID.Items.Count > 0)
            {
                if (ddlFiscalYearID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeAllowanceEntity.FiscalYearID = Int64.Parse(ddlFiscalYearID.SelectedValue);
                }
            }

            if (ddlAllowanceCategoryID.Items.Count > 0)
            {
                if (ddlAllowanceCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeAllowanceEntity.AllowanceCategoryID = Int64.Parse(ddlAllowanceCategoryID.SelectedValue);
                }
            }

            if (!txtAmount.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeAllowanceEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
            }

            hREmployeeAllowanceEntity.Remarks = txtRemarks.Text.Trim();
            hREmployeeAllowanceEntity.CreateDate = System.DateTime.Now;

            return hREmployeeAllowanceEntity;
        }

        private void SaveHREmployeeAllowanceEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeAllowanceEntity hREmployeeAllowanceEntity = BuildHREmployeeAllowanceEntity();

                    Int64 result = -1;

                    if (hREmployeeAllowanceEntity.IsNew)
                    {
                        result = FCCHREmployeeAllowance.GetFacadeCreate().Add(hREmployeeAllowanceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeAllowanceEntity.FLD_NAME_EmployeeAllowanceID, hREmployeeAllowanceEntity.EmployeeAllowanceID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeAllowance.GetFacadeCreate().Update(hREmployeeAllowanceEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeAllowanceID = 0;
                        _HREmployeeAllowanceEntity = new HREmployeeAllowanceEntity();
                        PrepareInitialView();
                        BindHREmployeeAllowanceList();

                        if (hREmployeeAllowanceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Allowance Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Allowance Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeAllowanceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Allowance Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Allowance Information.", false);
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

        protected void lvHREmployeeAllowance_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeAllowanceID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeAllowanceID);

            if (EmployeeAllowanceID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeAllowanceID = EmployeeAllowanceID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeAllowanceEntity.FLD_NAME_EmployeeAllowanceID, EmployeeAllowanceID.ToString(), SQLMatchType.Equal);

                        HREmployeeAllowanceEntity hREmployeeAllowanceEntity = new HREmployeeAllowanceEntity();


                        result = FCCHREmployeeAllowance.GetFacadeCreate().Delete(hREmployeeAllowanceEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeAllowanceID = 0;
                            _HREmployeeAllowanceEntity = new HREmployeeAllowanceEntity();
                            PrepareInitialView();
                            BindHREmployeeAllowanceList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Allowance has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Allowance.", true);
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

        protected void odsHREmployeeAllowance_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
            if (chbxFilter.Checked)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeAllowance_DetailedEntity.FLD_NAME_EmployeeCode, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = "M2.FirstName + CASE WHEN M2.MiddleName != '' THEN ' ' + M2.MiddleName ELSE '' END + CASE WHEN M2.MiddleName != NULL THEN ' ' + M2.MiddleName ELSE '' END + ' ' + M2.LastName like '%" + txtSearchText.Text.ToString() + "%'";

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe2);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeAllowanceEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeAllowanceID = 0;
            _HREmployeeAllowanceEntity = new HREmployeeAllowanceEntity();
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
