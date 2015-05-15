// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Sep-2013, 05:29:42




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
    public partial class HREmployeeEvaluationUpdateControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeEvaluationID
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

        public HREmployeeEvaluationEntity _HREmployeeEvaluationEntity
        {
            get
            {
                HREmployeeEvaluationEntity entity = new HREmployeeEvaluationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeEvaluationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeEvaluationEntity CurrentHREmployeeEvaluationEntity
        {
            get
            {
                if (_EmployeeEvaluationID > 0)
                {
                    if (_HREmployeeEvaluationEntity.EmployeeEvaluationID != _EmployeeEvaluationID)
                    {
                        _HREmployeeEvaluationEntity = FCCHREmployeeEvaluation.GetFacadeCreate().GetByID(_EmployeeEvaluationID);
                    }
                }

                return _HREmployeeEvaluationEntity;
            }
            set
            {
                _HREmployeeEvaluationEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHRSession(ddlSessionID, false);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, true);
            MiscUtil.PopulateHREmployee(ddlSupervisorEmployeeID, true);
            MiscUtil.PopulateMDEvaluatedBy(ddlEvaluatedByID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtEvaluationName.Text = String.Empty;
            txtEmployeeFullName.Text = String.Empty;
            txtEmployeeCode.Text = String.Empty;
            txtEmployeeDepartmentName.Text = String.Empty;
            txtEmployeeLevel.Text = String.Empty;
            txtSupervisorFullName.Text = String.Empty;
            txtSupervisorEmployeeCode.Text = String.Empty;
            txtSupervisorEmployeeDepartmentName.Text = String.Empty;
            txtSupervisorEmployeeLevel.Text = String.Empty;
            txtEmployeeSubmitDate.Text = String.Empty;
            txtSupervisorSubmitDate.Text = String.Empty;
            txtCreateDate.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtExtra.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeEvaluationEntity hREmployeeEvaluationEntity = CurrentHREmployeeEvaluationEntity;


            if (!hREmployeeEvaluationEntity.IsNew)
            {
                if (ddlSessionID.Items.Count > 0 && hREmployeeEvaluationEntity.SessionID != null)
                {
                    ddlSessionID.SelectedValue = hREmployeeEvaluationEntity.SessionID.ToString();
                }

                txtEvaluationName.Text = hREmployeeEvaluationEntity.EvaluationName.ToString();
                if (ddlEmployeeID.Items.Count > 0 && hREmployeeEvaluationEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = hREmployeeEvaluationEntity.EmployeeID.ToString();
                }

                txtEmployeeFullName.Text = hREmployeeEvaluationEntity.EmployeeFullName.ToString();
                txtEmployeeCode.Text = hREmployeeEvaluationEntity.EmployeeCode.ToString();
                txtEmployeeDepartmentName.Text = hREmployeeEvaluationEntity.EmployeeDepartmentName.ToString();
                txtEmployeeLevel.Text = hREmployeeEvaluationEntity.EmployeeLevel.ToString();
                if (ddlSupervisorEmployeeID.Items.Count > 0 && hREmployeeEvaluationEntity.SupervisorEmployeeID != null)
                {
                    ddlSupervisorEmployeeID.SelectedValue = hREmployeeEvaluationEntity.SupervisorEmployeeID.ToString();
                }

                txtSupervisorFullName.Text = hREmployeeEvaluationEntity.SupervisorFullName.ToString();
                txtSupervisorEmployeeCode.Text = hREmployeeEvaluationEntity.SupervisorEmployeeCode.ToString();
                txtSupervisorEmployeeDepartmentName.Text = hREmployeeEvaluationEntity.SupervisorEmployeeDepartmentName.ToString();
                txtSupervisorEmployeeLevel.Text = hREmployeeEvaluationEntity.SupervisorEmployeeLevel.ToString();
                txtEmployeeSubmitDate.Text = hREmployeeEvaluationEntity.EmployeeSubmitDate.ToStringDefault();
                txtSupervisorSubmitDate.Text = hREmployeeEvaluationEntity.SupervisorSubmitDate.ToStringDefault();
                txtCreateDate.Text = hREmployeeEvaluationEntity.CreateDate.ToStringDefault();
                if (ddlEvaluatedByID.Items.Count > 0 && hREmployeeEvaluationEntity.EvaluatedByID != null)
                {
                    ddlEvaluatedByID.SelectedValue = hREmployeeEvaluationEntity.EvaluatedByID.ToString();
                }

                txtRemarks.Text = hREmployeeEvaluationEntity.Remarks.ToString();
                txtExtra.Text = hREmployeeEvaluationEntity.Extra.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeEvaluationList();
        }

        private void BindHREmployeeEvaluationList()
        {
            lvHREmployeeEvaluation.DataBind();
        }

        private HREmployeeEvaluationEntity BuildHREmployeeEvaluationEntity()
        {
            HREmployeeEvaluationEntity hREmployeeEvaluationEntity = CurrentHREmployeeEvaluationEntity;

            if (ddlSessionID.Items.Count > 0)
            {
                if (ddlSessionID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeEvaluationEntity.SessionID = Int64.Parse(ddlSessionID.SelectedValue);
                }
            }

            hREmployeeEvaluationEntity.EvaluationName = txtEvaluationName.Text.Trim();
            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                    hREmployeeEvaluationEntity.EmployeeID = null;
                }
                else
                {
                    hREmployeeEvaluationEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            hREmployeeEvaluationEntity.EmployeeFullName = txtEmployeeFullName.Text.Trim();
            hREmployeeEvaluationEntity.EmployeeCode = txtEmployeeCode.Text.Trim();
            hREmployeeEvaluationEntity.EmployeeDepartmentName = txtEmployeeDepartmentName.Text.Trim();
            hREmployeeEvaluationEntity.EmployeeLevel = txtEmployeeLevel.Text.Trim();
            if (ddlSupervisorEmployeeID.Items.Count > 0)
            {
                if (ddlSupervisorEmployeeID.SelectedValue == "0")
                {
                    hREmployeeEvaluationEntity.SupervisorEmployeeID = null;
                }
                else
                {
                    hREmployeeEvaluationEntity.SupervisorEmployeeID = Int64.Parse(ddlSupervisorEmployeeID.SelectedValue);
                }
            }

            hREmployeeEvaluationEntity.SupervisorFullName = txtSupervisorFullName.Text.Trim();
            hREmployeeEvaluationEntity.SupervisorEmployeeCode = txtSupervisorEmployeeCode.Text.Trim();
            hREmployeeEvaluationEntity.SupervisorEmployeeDepartmentName = txtSupervisorEmployeeDepartmentName.Text.Trim();
            hREmployeeEvaluationEntity.SupervisorEmployeeLevel = txtSupervisorEmployeeLevel.Text.Trim();
            if (txtEmployeeSubmitDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeEvaluationEntity.EmployeeSubmitDate = MiscUtil.ParseToDateTime(txtEmployeeSubmitDate.Text);
            }
            else
            {
                hREmployeeEvaluationEntity.EmployeeSubmitDate = null;
            }

            if (txtSupervisorSubmitDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeEvaluationEntity.SupervisorSubmitDate = MiscUtil.ParseToDateTime(txtSupervisorSubmitDate.Text);
            }
            else
            {
                hREmployeeEvaluationEntity.SupervisorSubmitDate = null;
            }

            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeEvaluationEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }
            else
            {
                hREmployeeEvaluationEntity.CreateDate = null;
            }

            if (ddlEvaluatedByID.Items.Count > 0)
            {
                if (ddlEvaluatedByID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeEvaluationEntity.EvaluatedByID = Int64.Parse(ddlEvaluatedByID.SelectedValue);
                }
            }

            hREmployeeEvaluationEntity.Remarks = txtRemarks.Text.Trim();
            hREmployeeEvaluationEntity.Extra = txtExtra.Text.Trim();

            return hREmployeeEvaluationEntity;
        }

        private void SaveHREmployeeEvaluationEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeEvaluationEntity hREmployeeEvaluationEntity = BuildHREmployeeEvaluationEntity();

                    Int64 result = -1;

                    if (hREmployeeEvaluationEntity.IsNew)
                    {
                        result = FCCHREmployeeEvaluation.GetFacadeCreate().Add(hREmployeeEvaluationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationEntity.FLD_NAME_EmployeeEvaluationID, hREmployeeEvaluationEntity.EmployeeEvaluationID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeEvaluation.GetFacadeCreate().Update(hREmployeeEvaluationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeEvaluationID = 0;
                        _HREmployeeEvaluationEntity = new HREmployeeEvaluationEntity();
                        PrepareInitialView();
                        BindHREmployeeEvaluationList();

                        if (hREmployeeEvaluationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Evaluation Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Evaluation Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeEvaluationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Evaluation Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Evaluation Information.", false);
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

        protected void lvHREmployeeEvaluation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeEvaluationID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeEvaluationID);

            if (EmployeeEvaluationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeEvaluationID = EmployeeEvaluationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationEntity.FLD_NAME_EmployeeEvaluationID, EmployeeEvaluationID.ToString(), SQLMatchType.Equal);

                        HREmployeeEvaluationEntity hREmployeeEvaluationEntity = new HREmployeeEvaluationEntity();


                        result = FCCHREmployeeEvaluation.GetFacadeCreate().Delete(hREmployeeEvaluationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeEvaluationID = 0;
                            _HREmployeeEvaluationEntity = new HREmployeeEvaluationEntity();
                            PrepareInitialView();
                            BindHREmployeeEvaluationList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Evaluation has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Evaluation.", true);
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

        protected void odsHREmployeeEvaluation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeEvaluationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeEvaluationID = 0;
            _HREmployeeEvaluationEntity = new HREmployeeEvaluationEntity();
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
