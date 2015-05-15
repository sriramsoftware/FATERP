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
    public partial class HREmployeeSalarySessionDeducationInfoControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeSalarySessionDeducationInfoID
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

        public HREmployeeSalarySessionDeducationInfoEntity _HREmployeeSalarySessionDeducationInfoEntity
        {
            get
            {
                HREmployeeSalarySessionDeducationInfoEntity entity = new HREmployeeSalarySessionDeducationInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeSalarySessionDeducationInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeSalarySessionDeducationInfoEntity CurrentHREmployeeSalarySessionDeducationInfoEntity
        {
            get
            {
                if (_EmployeeSalarySessionDeducationInfoID > 0)
                {
                    if (_HREmployeeSalarySessionDeducationInfoEntity.EmployeeSalarySessionDeducationInfoID != _EmployeeSalarySessionDeducationInfoID)
                    {
                        _HREmployeeSalarySessionDeducationInfoEntity = FCCHREmployeeSalarySessionDeducationInfo.GetFacadeCreate().GetByID(_EmployeeSalarySessionDeducationInfoID);
                    }
                }

                return _HREmployeeSalarySessionDeducationInfoEntity;
            }
            set
            {
                _HREmployeeSalarySessionDeducationInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDSalarySession(ddlSalarySessionID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtDeductionAmount.Text = String.Empty;
            txtNote.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity = CurrentHREmployeeSalarySessionDeducationInfoEntity;


            if (!hREmployeeSalarySessionDeducationInfoEntity.IsNew)
            {
                if (ddlSalarySessionID.Items.Count > 0 && hREmployeeSalarySessionDeducationInfoEntity.SalarySessionID != null)
                {
                    ddlSalarySessionID.SelectedValue = hREmployeeSalarySessionDeducationInfoEntity.SalarySessionID.ToString();
                }

                txtDeductionAmount.Text = hREmployeeSalarySessionDeducationInfoEntity.DeductionAmount.ToString();
                txtNote.Text = hREmployeeSalarySessionDeducationInfoEntity.Note.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeSalarySessionDeducationInfoList();
        }

        private void BindHREmployeeSalarySessionDeducationInfoList()
        {
            lvHREmployeeSalarySessionDeducationInfo.DataBind();
        }

        private HREmployeeSalarySessionDeducationInfoEntity BuildHREmployeeSalarySessionDeducationInfoEntity()
        {
            HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity = CurrentHREmployeeSalarySessionDeducationInfoEntity;

            if (ddlSalarySessionID.Items.Count > 0)
            {
                if (ddlSalarySessionID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSalarySessionDeducationInfoEntity.SalarySessionID = Int64.Parse(ddlSalarySessionID.SelectedValue);
                }
            }

            if (!txtDeductionAmount.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeSalarySessionDeducationInfoEntity.DeductionAmount = Decimal.Parse(txtDeductionAmount.Text.Trim());
            }
            else
            {
                hREmployeeSalarySessionDeducationInfoEntity.DeductionAmount = null;
            }

            hREmployeeSalarySessionDeducationInfoEntity.Note = txtNote.Text.Trim();

            return hREmployeeSalarySessionDeducationInfoEntity;
        }

        private void SaveHREmployeeSalarySessionDeducationInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity = BuildHREmployeeSalarySessionDeducationInfoEntity();

                    Int64 result = -1;

                    if (hREmployeeSalarySessionDeducationInfoEntity.IsNew)
                    {
                        result = FCCHREmployeeSalarySessionDeducationInfo.GetFacadeCreate().Add(hREmployeeSalarySessionDeducationInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalarySessionDeducationInfoEntity.FLD_NAME_EmployeeSalarySessionDeducationInfoID, hREmployeeSalarySessionDeducationInfoEntity.EmployeeSalarySessionDeducationInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeSalarySessionDeducationInfo.GetFacadeCreate().Update(hREmployeeSalarySessionDeducationInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeSalarySessionDeducationInfoID = 0;
                        _HREmployeeSalarySessionDeducationInfoEntity = new HREmployeeSalarySessionDeducationInfoEntity();
                        PrepareInitialView();
                        BindHREmployeeSalarySessionDeducationInfoList();

                        if (hREmployeeSalarySessionDeducationInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Session Deducation Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Session Deducation Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeSalarySessionDeducationInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Salary Session Deducation Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Salary Session Deducation Info Information.", false);
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

        protected void lvHREmployeeSalarySessionDeducationInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeSalarySessionDeducationInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeSalarySessionDeducationInfoID);

            if (EmployeeSalarySessionDeducationInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeSalarySessionDeducationInfoID = EmployeeSalarySessionDeducationInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalarySessionDeducationInfoEntity.FLD_NAME_EmployeeSalarySessionDeducationInfoID, EmployeeSalarySessionDeducationInfoID.ToString(), SQLMatchType.Equal);

                        HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity = new HREmployeeSalarySessionDeducationInfoEntity();


                        result = FCCHREmployeeSalarySessionDeducationInfo.GetFacadeCreate().Delete(hREmployeeSalarySessionDeducationInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeSalarySessionDeducationInfoID = 0;
                            _HREmployeeSalarySessionDeducationInfoEntity = new HREmployeeSalarySessionDeducationInfoEntity();
                            PrepareInitialView();
                            BindHREmployeeSalarySessionDeducationInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Salary Session Deducation Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Salary Session Deducation Info.", true);
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

        protected void odsHREmployeeSalarySessionDeducationInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeSalarySessionDeducationInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeSalarySessionDeducationInfoID = 0;
            _HREmployeeSalarySessionDeducationInfoEntity = new HREmployeeSalarySessionDeducationInfoEntity();
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
