// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 11:07:00




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
    public partial class HREmployeeEvaluationResultControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeEvaluationResultID
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

        public HREmployeeEvaluationResultEntity _HREmployeeEvaluationResultEntity
        {
            get
            {
                HREmployeeEvaluationResultEntity entity = new HREmployeeEvaluationResultEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeEvaluationResultEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeEvaluationResultEntity CurrentHREmployeeEvaluationResultEntity
        {
            get
            {
                if (_EmployeeEvaluationResultID > 0)
                {
                    if (_HREmployeeEvaluationResultEntity.EmployeeEvaluationResultID != _EmployeeEvaluationResultID)
                    {
                        _HREmployeeEvaluationResultEntity = FCCHREmployeeEvaluationResult.GetFacadeCreate().GetByID(_EmployeeEvaluationResultID);
                    }
                }

                return _HREmployeeEvaluationResultEntity;
            }
            set
            {
                _HREmployeeEvaluationResultEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDEvaluationCriteriaCategory(ddlEvaluationCriteriaCategoryID, false);
            MiscUtil.PopulateHREmployeeEvaluation(ddlEmployeeEvaluationID, false);
            MiscUtil.PopulateMDEvaluationCriteria(ddlEmployeeEvaluationCriteriaID, false);
            MiscUtil.PopulateMDEvaluationCriteria(ddlSupervisorEvaluationCriteriaID, true);
            MiscUtil.PopulateHRSession(ddlSessionCategoryID, false);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtQuestion.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtAnswerGivenByEmployeeDepartmentName.Text = String.Empty;
            txtEmployeeFullName.Text = String.Empty;
            txtEmployeeCode.Text = String.Empty;
            txtSupervisorDepartmentName.Text = String.Empty;
            txtAnswerGivenBySupervisorEmployeeFullName.Text = String.Empty;
            txtSupervisorEmployeeCode.Text = String.Empty;
            txtEmployeeResult.Text = String.Empty;
            txtResult.Text = String.Empty;
            txtPointInThisQuestion.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtExtra1.Text = String.Empty;
            txtExtra2.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeEvaluationResultEntity hREmployeeEvaluationResultEntity = CurrentHREmployeeEvaluationResultEntity;


            if (!hREmployeeEvaluationResultEntity.IsNew)
            {
                if (ddlEvaluationCriteriaCategoryID.Items.Count > 0 && hREmployeeEvaluationResultEntity.EvaluationCriteriaCategoryID != null)
                {
                    ddlEvaluationCriteriaCategoryID.SelectedValue = hREmployeeEvaluationResultEntity.EvaluationCriteriaCategoryID.ToString();
                }

                txtQuestion.Text = hREmployeeEvaluationResultEntity.Question.ToString();
                txtDescription.Text = hREmployeeEvaluationResultEntity.Description.ToString();
                if (ddlEmployeeEvaluationID.Items.Count > 0 && hREmployeeEvaluationResultEntity.EmployeeEvaluationID != null)
                {
                    ddlEmployeeEvaluationID.SelectedValue = hREmployeeEvaluationResultEntity.EmployeeEvaluationID.ToString();
                }

                if (ddlEmployeeEvaluationCriteriaID.Items.Count > 0 && hREmployeeEvaluationResultEntity.EmployeeEvaluationCriteriaID != null)
                {
                    ddlEmployeeEvaluationCriteriaID.SelectedValue = hREmployeeEvaluationResultEntity.EmployeeEvaluationCriteriaID.ToString();
                }

                txtAnswerGivenByEmployeeDepartmentName.Text = hREmployeeEvaluationResultEntity.AnswerGivenByEmployeeDepartmentName.ToString();
                txtEmployeeFullName.Text = hREmployeeEvaluationResultEntity.EmployeeFullName.ToString();
                txtEmployeeCode.Text = hREmployeeEvaluationResultEntity.EmployeeCode.ToString();
                if (ddlSupervisorEvaluationCriteriaID.Items.Count > 0 && hREmployeeEvaluationResultEntity.SupervisorEvaluationCriteriaID != null)
                {
                    ddlSupervisorEvaluationCriteriaID.SelectedValue = hREmployeeEvaluationResultEntity.SupervisorEvaluationCriteriaID.ToString();
                }

                txtSupervisorDepartmentName.Text = hREmployeeEvaluationResultEntity.SupervisorDepartmentName.ToString();
                txtAnswerGivenBySupervisorEmployeeFullName.Text = hREmployeeEvaluationResultEntity.AnswerGivenBySupervisorEmployeeFullName.ToString();
                txtSupervisorEmployeeCode.Text = hREmployeeEvaluationResultEntity.SupervisorEmployeeCode.ToString();
                txtEmployeeResult.Text = hREmployeeEvaluationResultEntity.EmployeeResult.ToString();
                txtResult.Text = hREmployeeEvaluationResultEntity.Result.ToString();
                txtPointInThisQuestion.Text = hREmployeeEvaluationResultEntity.PointInThisQuestion.ToString();
                txtRemarks.Text = hREmployeeEvaluationResultEntity.Remarks.ToString();
                txtExtra1.Text = hREmployeeEvaluationResultEntity.Extra1.ToString();
                txtExtra2.Text = hREmployeeEvaluationResultEntity.Extra2.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeEvaluationResultList();
        }

        private void BindHREmployeeEvaluationResultList()
        {
            lvHREmployeeEvaluationResult.DataBind();
        }

        private HREmployeeEvaluationResultEntity BuildHREmployeeEvaluationResultEntity()
        {
            HREmployeeEvaluationResultEntity hREmployeeEvaluationResultEntity = CurrentHREmployeeEvaluationResultEntity;

            if (ddlEvaluationCriteriaCategoryID.Items.Count > 0)
            {
                if (ddlEvaluationCriteriaCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeEvaluationResultEntity.EvaluationCriteriaCategoryID = Int64.Parse(ddlEvaluationCriteriaCategoryID.SelectedValue);
                }
            }

            hREmployeeEvaluationResultEntity.Question = txtQuestion.Text.Trim();
            hREmployeeEvaluationResultEntity.Description = txtDescription.Text.Trim();
            if (ddlEmployeeEvaluationID.Items.Count > 0)
            {
                if (ddlEmployeeEvaluationID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeEvaluationResultEntity.EmployeeEvaluationID = Int64.Parse(ddlEmployeeEvaluationID.SelectedValue);
                }
            }

            if (ddlEmployeeEvaluationCriteriaID.Items.Count > 0)
            {
                if (ddlEmployeeEvaluationCriteriaID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeEvaluationResultEntity.EmployeeEvaluationCriteriaID = Int64.Parse(ddlEmployeeEvaluationCriteriaID.SelectedValue);
                }
            }

            hREmployeeEvaluationResultEntity.AnswerGivenByEmployeeDepartmentName = txtAnswerGivenByEmployeeDepartmentName.Text.Trim();
            hREmployeeEvaluationResultEntity.EmployeeFullName = txtEmployeeFullName.Text.Trim();
            hREmployeeEvaluationResultEntity.EmployeeCode = txtEmployeeCode.Text.Trim();
            if (ddlSupervisorEvaluationCriteriaID.Items.Count > 0)
            {
                if (ddlSupervisorEvaluationCriteriaID.SelectedValue == "0")
                {
                    hREmployeeEvaluationResultEntity.SupervisorEvaluationCriteriaID = null;
                }
                else
                {
                    hREmployeeEvaluationResultEntity.SupervisorEvaluationCriteriaID = Int64.Parse(ddlSupervisorEvaluationCriteriaID.SelectedValue);
                }
            }

            hREmployeeEvaluationResultEntity.SupervisorDepartmentName = txtSupervisorDepartmentName.Text.Trim();
            hREmployeeEvaluationResultEntity.AnswerGivenBySupervisorEmployeeFullName = txtAnswerGivenBySupervisorEmployeeFullName.Text.Trim();
            hREmployeeEvaluationResultEntity.SupervisorEmployeeCode = txtSupervisorEmployeeCode.Text.Trim();
            if (!txtEmployeeResult.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeEvaluationResultEntity.EmployeeResult = Int32.Parse(txtEmployeeResult.Text.Trim());
            }
            else
            {
                hREmployeeEvaluationResultEntity.EmployeeResult = null;
            }

            if (!txtResult.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeEvaluationResultEntity.Result = Int32.Parse(txtResult.Text.Trim());
            }
            else
            {
                hREmployeeEvaluationResultEntity.Result = null;
            }

            if (!txtPointInThisQuestion.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeEvaluationResultEntity.PointInThisQuestion = Int32.Parse(txtPointInThisQuestion.Text.Trim());
            }
            else
            {
                hREmployeeEvaluationResultEntity.PointInThisQuestion = null;
            }

            hREmployeeEvaluationResultEntity.Remarks = txtRemarks.Text.Trim();
            hREmployeeEvaluationResultEntity.Extra1 = txtExtra1.Text.Trim();
            hREmployeeEvaluationResultEntity.Extra2 = txtExtra2.Text.Trim();

            return hREmployeeEvaluationResultEntity;
        }

        private void SaveHREmployeeEvaluationResultEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeEvaluationResultEntity hREmployeeEvaluationResultEntity = BuildHREmployeeEvaluationResultEntity();

                    Int64 result = -1;

                    if (hREmployeeEvaluationResultEntity.IsNew)
                    {
                        result = FCCHREmployeeEvaluationResult.GetFacadeCreate().Add(hREmployeeEvaluationResultEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationResultEntity.FLD_NAME_EmployeeEvaluationResultID, hREmployeeEvaluationResultEntity.EmployeeEvaluationResultID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeEvaluationResult.GetFacadeCreate().Update(hREmployeeEvaluationResultEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeEvaluationResultID = 0;
                        _HREmployeeEvaluationResultEntity = new HREmployeeEvaluationResultEntity();
                        PrepareInitialView();
                        BindHREmployeeEvaluationResultList();

                        if (hREmployeeEvaluationResultEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Evaluation Result Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Evaluation Result Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeEvaluationResultEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Evaluation Result Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Evaluation Result Information.", false);
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

        protected void lvHREmployeeEvaluationResult_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeEvaluationResultID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeEvaluationResultID);

            if (EmployeeEvaluationResultID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeEvaluationResultID = EmployeeEvaluationResultID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationResultEntity.FLD_NAME_EmployeeEvaluationResultID, EmployeeEvaluationResultID.ToString(), SQLMatchType.Equal);

                        HREmployeeEvaluationResultEntity hREmployeeEvaluationResultEntity = new HREmployeeEvaluationResultEntity();


                        result = FCCHREmployeeEvaluationResult.GetFacadeCreate().Delete(hREmployeeEvaluationResultEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeEvaluationResultID = 0;
                            _HREmployeeEvaluationResultEntity = new HREmployeeEvaluationResultEntity();
                            PrepareInitialView();
                            BindHREmployeeEvaluationResultList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Evaluation Result has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Evaluation Result.", true);
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

        protected void odsHREmployeeEvaluationResult_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnShowReport_Click(object sender, EventArgs e)
        {
            String NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_EVALUATION_REPORT, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ddlSessionCategoryID.SelectedValue, UrlConstants.OVERVIEW_EMPLOYEE_ID, ddlEmployeeID.SelectedValue).ToString();
            Helper.Response.Redirect(NavigationUrl);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeEvaluationResultEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeEvaluationResultID = 0;
            _HREmployeeEvaluationResultEntity = new HREmployeeEvaluationResultEntity();
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
