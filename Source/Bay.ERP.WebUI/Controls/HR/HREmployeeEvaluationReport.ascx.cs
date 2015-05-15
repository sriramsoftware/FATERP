// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Dec-2013, 01:17:51




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Linq;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeEvaluationReportControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeEvaluationReportID
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

        public HREmployeeEvaluationReportEntity _HREmployeeEvaluationReportEntity
        {
            get
            {
                HREmployeeEvaluationReportEntity entity = new HREmployeeEvaluationReportEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeEvaluationReportEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeEvaluationReportEntity CurrentHREmployeeEvaluationReportEntity
        {
            get
            {
                if (_CurrentSessionID > 0 && _CurrentEmployeeEvaluatedID > 0)
                {
                    String fe1 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationReportEntity.FLD_NAME_SessionID, _CurrentSessionID.ToString(), SQLMatchType.Equal);
                    String fe2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationReportEntity.FLD_NAME_EmployeeID, _CurrentEmployeeEvaluatedID.ToString(), SQLMatchType.Equal);
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                    IList<HREmployeeEvaluationReportEntity> HREmployeeEvaluationReportEntityList = FCCHREmployeeEvaluationReport.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                    //IList<BDProjectLiftEntity> BDProjectLiftList = FCCBDProjectLift.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (HREmployeeEvaluationReportEntityList != null && HREmployeeEvaluationReportEntityList.Count > 0)
                    {
                        _HREmployeeEvaluationReportEntity = HREmployeeEvaluationReportEntityList[0];
                    }
                    else
                    {
                        _HREmployeeEvaluationReportEntity = new HREmployeeEvaluationReportEntity();
                    }
                }

                return _HREmployeeEvaluationReportEntity;
            }
            set
            {
                _HREmployeeEvaluationReportEntity = value;
            }
        }

        public Int64 _CurrentSessionID
        {
            get
            {
                Int64 SessionID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVALUATION_SESSION_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVALUATION_SESSION_ID], out SessionID);
                }

                return SessionID;
            }
        }

        public Int64 _CurrentEmployeeEvaluatedID
        {
            get
            {
                Int64 CurrentEmployeeEvaluatedID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID], out CurrentEmployeeEvaluatedID);
                }

                return CurrentEmployeeEvaluatedID;
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

        private void GetEmployeeNameAndCode()
        {
            HREmployeeEntity entity = FCCHREmployee.GetFacadeCreate().GetByID(_CurrentEmployeeEvaluatedID);
            HRMemberEntity ent = FCCHRMember.GetFacadeCreate().GetByID(entity.MemberID);
            txtEmployeeCode.Text = entity.EmployeeCode;
            txtEmployeeName.Text = ent.FirstName+" "+ ent.MiddleName +" "+ ent.LastName;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            GetEmployeeNameAndCode();
            
            txtTitle1.Text = "EBR";
            txtTitle1Column1.Text = "Sep-13";
            txtTitle1Column2.Text = "March-14";
            txtTitle1Category1.Text = "Self";
            txtTitle1Category1Column1Value.Text = String.Empty;
            txtTitle1Category1Column2Value.Text = "0";
            txtTitle1Category2.Text = "Supervisor";
            txtTitle1Category2Column1Value.Text = String.Empty;
            txtTitle1Category2Column2Value.Text = "0";
            txtTitle2.Text = "Peroid";
            txtTitle2Column1.Text = "December-13";
            txtTitle2Category1.Text = "PBR 1 Target";
            txtTitle2Category1Column1Value.Text = String.Empty;
            txtTitle2Category1Column2Value.Text = "0";
            txtTitle2Category2.Text = "PBR 1 Cap";
            txtTitle2Category2Column1Value.Text = String.Empty;
            txtTitle2Category2Column2Value.Text = "0";
            txtTitle3.Text = "Peroid";
            txtTitle3Column1.Text = "June-14";
            txtTitle3Category1.Text = "PBR 2 Target";
            txtTitle3Category1Column1Value.Text = "0";
            txtTitle3Category1Column2Value.Text = "0";
            txtTitle3Category2.Text = "PBR 2 Cap";
            txtTitle3Category2Column1Value.Text = "0";
            txtTitle3Category2Column2Value.Text = "0";
            txtHRReportQuestion1Title.Text = "Weekly HR Review List (WHRL)";
            txtHRReportQuestion1TitleValue.Text = String.Empty;
            txtSupervisorNumberValue.Text = String.Empty;
            txtScoreValue.Text = String.Empty;
            txtDeducationValue.Text = String.Empty;
            txtActualScoreValue.Text = String.Empty;
            txtTitle4.Text = "PBR 1";
            txtTitle4Column1Value.Text = String.Empty;
            txtHRReportQuestion2Title.Text = "HR Report";
            txtHRReportQuestion2TitleValue.Text = String.Empty;
            

            btnSubmit.Text = "Add";
            btnSubmit.Visible = true;
        }

        private void PrepareEditView()
        {
            HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity = CurrentHREmployeeEvaluationReportEntity;


            if (!hREmployeeEvaluationReportEntity.IsNew)
            {
                GetEmployeeNameAndCode();
                txtTitle1.Text = hREmployeeEvaluationReportEntity.Title1.ToString();
                txtTitle1Column1.Text = hREmployeeEvaluationReportEntity.Title1Column1.ToString();
                txtTitle1Column2.Text = hREmployeeEvaluationReportEntity.Title1Column2.ToString();
                txtTitle1Category1.Text = hREmployeeEvaluationReportEntity.Title1Category1.ToString();
                txtTitle1Category1Column1Value.Text = hREmployeeEvaluationReportEntity.Title1Category1Column1Value.ToString();
                txtTitle1Category1Column2Value.Text = hREmployeeEvaluationReportEntity.Title1Category1Column2Value.ToString();
                txtTitle1Category2.Text = hREmployeeEvaluationReportEntity.Title1Category2.ToString();
                txtTitle1Category2Column1Value.Text = hREmployeeEvaluationReportEntity.Title1Category2Column1Value.ToString();
                txtTitle1Category2Column2Value.Text = hREmployeeEvaluationReportEntity.Title1Category2Column2Value.ToString();
                txtTitle2.Text = hREmployeeEvaluationReportEntity.Title2.ToString();
                txtTitle2Column1.Text = hREmployeeEvaluationReportEntity.Title2Column1.ToString();
                txtTitle2Category1.Text = hREmployeeEvaluationReportEntity.Title2Category1.ToString();
                txtTitle2Category1Column1Value.Text = hREmployeeEvaluationReportEntity.Title2Category1Column1Value.ToString();
                txtTitle2Category1Column2Value.Text = hREmployeeEvaluationReportEntity.Title2Category1Column2Value.ToString();
                txtTitle2Category2.Text = hREmployeeEvaluationReportEntity.Title2Category2.ToString();
                txtTitle2Category2Column1Value.Text = hREmployeeEvaluationReportEntity.Title2Category2Column1Value.ToString();
                txtTitle2Category2Column2Value.Text = hREmployeeEvaluationReportEntity.Title2Category2Column2Value.ToString();
                txtTitle3.Text = hREmployeeEvaluationReportEntity.Title3.ToString();
                txtTitle3Column1.Text = hREmployeeEvaluationReportEntity.Title3Column1.ToString();
                txtTitle3Category1.Text = hREmployeeEvaluationReportEntity.Title3Category1.ToString();
                txtTitle3Category1Column1Value.Text = hREmployeeEvaluationReportEntity.Title3Category1Column1Value.ToString();
                txtTitle3Category1Column2Value.Text = hREmployeeEvaluationReportEntity.Title3Category1Column2Value.ToString();
                txtTitle3Category2.Text = hREmployeeEvaluationReportEntity.Title3Category2.ToString();
                txtTitle3Category2Column1Value.Text = hREmployeeEvaluationReportEntity.Title3Category2Column1Value.ToString();
                txtTitle3Category2Column2Value.Text = hREmployeeEvaluationReportEntity.Title3Category2Column2Value.ToString();
                txtHRReportQuestion1Title.Text = hREmployeeEvaluationReportEntity.HRReportQuestion1Title.ToString();
                txtHRReportQuestion1TitleValue.Text = hREmployeeEvaluationReportEntity.HRReportQuestion1TitleValue.ToString();
                txtSupervisorNumberValue.Text = hREmployeeEvaluationReportEntity.SupervisorNumberValue.ToString();
                txtScoreValue.Text = hREmployeeEvaluationReportEntity.ScoreValue.ToString();
                txtDeducationValue.Text = hREmployeeEvaluationReportEntity.DeducationValue.ToString();
                txtActualScoreValue.Text = hREmployeeEvaluationReportEntity.ActualScoreValue.ToString();
                txtTitle4.Text = hREmployeeEvaluationReportEntity.Title4.ToString();
                txtTitle4Column1Value.Text = hREmployeeEvaluationReportEntity.Title4Column1Value.ToString();
                txtHRReportQuestion2Title.Text = hREmployeeEvaluationReportEntity.HRReportQuestion2Title.ToString();
                txtHRReportQuestion2TitleValue.Text = hREmployeeEvaluationReportEntity.HRReportQuestion2TitleValue.ToString();
                hREmployeeEvaluationReportEntity.SessionID = _CurrentSessionID;
                hREmployeeEvaluationReportEntity.EmployeeID = _CurrentSessionID;

                GetReport();
                btnSubmit.Text = "Update";
                btnSubmit.Visible = true;
            }
        }

        private void GetReport()
        {
            HREmployeeEvaluationReportEntity ent = CurrentHREmployeeEvaluationReportEntity;
            hypHRReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_EVALUATIONREPORT_REPORT, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ent.SessionID.ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString()).ToString();
            hypHRReport.Target = "_blank";
        }

        private void BindList()
        {
            BindHREmployeeEvaluationReportList();
        }

        private void BindHREmployeeEvaluationReportList()
        {
            //lvHREmployeeEvaluationReport.DataBind();
        }

        private HREmployeeEvaluationReportEntity BuildHREmployeeEvaluationReportEntity()
        {
            HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity = CurrentHREmployeeEvaluationReportEntity;

            hREmployeeEvaluationReportEntity.SessionID = _CurrentSessionID;
            hREmployeeEvaluationReportEntity.EmployeeID = _CurrentEmployeeEvaluatedID;
            hREmployeeEvaluationReportEntity.Title1 = txtTitle1.Text.Trim();
            hREmployeeEvaluationReportEntity.Title1Column1 = txtTitle1Column1.Text.Trim();
            hREmployeeEvaluationReportEntity.Title1Column2 = txtTitle1Column2.Text.Trim();
            hREmployeeEvaluationReportEntity.Title1Category1 = txtTitle1Category1.Text.Trim();
            hREmployeeEvaluationReportEntity.Title1Category1Column1Value = txtTitle1Category1Column1Value.Text.Trim();
            hREmployeeEvaluationReportEntity.Title1Category1Column2Value = txtTitle1Category1Column2Value.Text.Trim();
            hREmployeeEvaluationReportEntity.Title1Category2 = txtTitle1Category2.Text.Trim();
            hREmployeeEvaluationReportEntity.Title1Category2Column1Value = txtTitle1Category2Column1Value.Text.Trim();
            hREmployeeEvaluationReportEntity.Title1Category2Column2Value = txtTitle1Category2Column2Value.Text.Trim();
            hREmployeeEvaluationReportEntity.Title2 = txtTitle2.Text.Trim();
            hREmployeeEvaluationReportEntity.Title2Column1 = txtTitle2Column1.Text.Trim();
            hREmployeeEvaluationReportEntity.Title2Category1 = txtTitle2Category1.Text.Trim();
            hREmployeeEvaluationReportEntity.Title2Category1Column1Value = txtTitle2Category1Column1Value.Text.Trim();
            hREmployeeEvaluationReportEntity.Title2Category1Column2Value = txtTitle2Category1Column2Value.Text.Trim();
            hREmployeeEvaluationReportEntity.Title2Category2 = txtTitle2Category2.Text.Trim();
            hREmployeeEvaluationReportEntity.Title2Category2Column1Value = txtTitle2Category2Column1Value.Text.Trim();
            hREmployeeEvaluationReportEntity.Title2Category2Column2Value = txtTitle2Category2Column2Value.Text.Trim();
            hREmployeeEvaluationReportEntity.Title3 = txtTitle3.Text.Trim();
            hREmployeeEvaluationReportEntity.Title3Column1 = txtTitle3Column1.Text.Trim();
            hREmployeeEvaluationReportEntity.Title3Category1 = txtTitle3Category1.Text.Trim();
            hREmployeeEvaluationReportEntity.Title3Category1Column1Value = txtTitle3Category1Column1Value.Text.Trim();
            hREmployeeEvaluationReportEntity.Title3Category1Column2Value = txtTitle3Category1Column2Value.Text.Trim();
            hREmployeeEvaluationReportEntity.Title3Category2 = txtTitle3Category2.Text.Trim();
            hREmployeeEvaluationReportEntity.Title3Category2Column1Value = txtTitle3Category2Column1Value.Text.Trim();
            hREmployeeEvaluationReportEntity.Title3Category2Column2Value = txtTitle3Category2Column2Value.Text.Trim();
            hREmployeeEvaluationReportEntity.HRReportQuestion1Title = txtHRReportQuestion1Title.Text.Trim();
            hREmployeeEvaluationReportEntity.HRReportQuestion1TitleValue = txtHRReportQuestion1TitleValue.Text.Trim();
            if (!txtSupervisorNumberValue.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeEvaluationReportEntity.SupervisorNumberValue = Decimal.Parse(txtSupervisorNumberValue.Text.Trim());
            }

            if (!txtScoreValue.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeEvaluationReportEntity.ScoreValue = Decimal.Parse(txtScoreValue.Text.Trim());
            }

            if (!txtDeducationValue.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeEvaluationReportEntity.DeducationValue = Decimal.Parse(txtDeducationValue.Text.Trim());
            }

            if (!txtActualScoreValue.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeEvaluationReportEntity.ActualScoreValue = Decimal.Parse(txtActualScoreValue.Text.Trim());
            }

            hREmployeeEvaluationReportEntity.Title4 = txtTitle4.Text.Trim();
            if (!txtTitle4Column1Value.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeEvaluationReportEntity.Title4Column1Value = Decimal.Parse(txtTitle4Column1Value.Text.Trim());
            }

            hREmployeeEvaluationReportEntity.HRReportQuestion2Title = txtHRReportQuestion2Title.Text.Trim();
            hREmployeeEvaluationReportEntity.HRReportQuestion2TitleValue = txtHRReportQuestion2TitleValue.Text.Trim();
            

            return hREmployeeEvaluationReportEntity;
        }

        private void SaveHREmployeeEvaluationReportEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity = BuildHREmployeeEvaluationReportEntity();

                    Int64 result = -1;

                    if (hREmployeeEvaluationReportEntity.IsNew)
                    {
                        result = FCCHREmployeeEvaluationReport.GetFacadeCreate().Add(hREmployeeEvaluationReportEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationReportEntity.FLD_NAME_EmployeeEvaluationReportID, hREmployeeEvaluationReportEntity.EmployeeEvaluationReportID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeEvaluationReport.GetFacadeCreate().Update(hREmployeeEvaluationReportEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeEvaluationReportID = 0;
                        _HREmployeeEvaluationReportEntity = new HREmployeeEvaluationReportEntity();
                        PrepareInitialView();
                        PrepareEditView();
                        BindHREmployeeEvaluationReportList();

                        if (hREmployeeEvaluationReportEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Evaluation Report Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Evaluation Report Information has been updated successfully.", false);
                            //Response.Redirect("~/HR/HREmployeeEvaluation.aspx");
                        }
                    }
                    else
                    {
                        if (hREmployeeEvaluationReportEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Evaluation Report Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Evaluation Report Information.", false);
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

        protected void lvHREmployeeEvaluationReport_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeEvaluationReportID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeEvaluationReportID);

            if (EmployeeEvaluationReportID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeEvaluationReportID = EmployeeEvaluationReportID;

                    PrepareEditView();

                    //cpeEditor.Collapsed = false;
                    //cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationReportEntity.FLD_NAME_EmployeeEvaluationReportID, EmployeeEvaluationReportID.ToString(), SQLMatchType.Equal);

                        HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity = new HREmployeeEvaluationReportEntity();


                        result = FCCHREmployeeEvaluationReport.GetFacadeCreate().Delete(hREmployeeEvaluationReportEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeEvaluationReportID = 0;
                            _HREmployeeEvaluationReportEntity = new HREmployeeEvaluationReportEntity();
                            PrepareInitialView();
                            BindHREmployeeEvaluationReportList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Evaluation Report has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Evaluation Report.", true);
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

        protected void odsHREmployeeEvaluationReport_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeEvaluationReportEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeEvaluationReportID = 0;
            _HREmployeeEvaluationReportEntity = new HREmployeeEvaluationReportEntity();
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
