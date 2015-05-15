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
using System.Web.Security;
using System.Linq;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeEvaluationControl : BaseControl
    {
        #region Extra Field Properties

        public Int64 PageAPType { get; set; }

        #endregion

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
          
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            if (this.Page.User.Identity.IsAuthenticated == true)
            {
                if (Roles.IsUserInRole(this.Page.User.Identity.Name, "Admin") == true ||
                    Roles.IsUserInRole(this.Page.User.Identity.Name, "HR") == true)
                {
                    chbxShowAll.Visible = true;
                }
                else
                {
                    chbxShowAll.Visible = false;
                }
            }
        }

        private void PrepareEditView()
        {
            HREmployeeEvaluationEntity hREmployeeEvaluationEntity = CurrentHREmployeeEvaluationEntity;

            if (!hREmployeeEvaluationEntity.IsNew)
            {
              
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

        protected void lvHREmployeeEvaluation_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                HREmployeeEvaluationIndividual_CustomEntity ent = (HREmployeeEvaluationIndividual_CustomEntity)dataItem.DataItem;

                HyperLink hypBtnDoEvaluation = (HyperLink)e.Item.FindControl("hypBtnDoEvaluation");
                HyperLink hypReport = (HyperLink)e.Item.FindControl("hypReport");
                Label lblRequestInfo = (Label)e.Item.FindControl("lblRequestInfo");
                Label lblEmployeeSubmitInfo = (Label)e.Item.FindControl("lblEmployeeSubmitInfo");
                Label lblSupervisorSubmitInfo = (Label)e.Item.FindControl("lblSupervisorSubmitInfo");
                HyperLink hypBtnDoHREvaluation = (HyperLink)e.Item.FindControl("hypBtnDoHREvaluation");
                HyperLink hypHRReport = (HyperLink)e.Item.FindControl("hypHRReport");
                
                    
                String sname = "Employee";

                if (ent.SupervisorEmployeeID == MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember))
                {
                    sname = "Supervisor";
                }

                if (!ent.EmployeeSubmitDate.HasValue && !ent.SupervisorSubmitDate.HasValue)
                {
                    lblRequestInfo.Text = "Requested Only";
                }

                #region SupervisorSubmited or not

                if (!ent.SupervisorSubmitDate.HasValue && ent.SessionCategoryID == MasterDataConstants.MDEvaluationSessionCategory.PBR)
                {
                    lblRequestInfo.Text = "Supervisor Please Submit your marks";
                }

                #endregion

                if (ent.EmployeeSubmitDate.HasValue)
                {
                    lblEmployeeSubmitInfo.Text = "<br/>Employee Submitted";
                }

                if (ent.SupervisorSubmitDate.HasValue)
                {
                    lblSupervisorSubmitInfo.Text = "<br/>Supervisor Submitted";
                }

                if (PageAPType == MasterDataConstants.MDEvaluationSessionCategory.HEALTH_CHECKUP)
                {
                    hypBtnDoEvaluation.Text = "Give Answer";
                }

                //hypBtnDoHREvaluation.NavigateUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeeEvaluationReport.aspx", string.Empty, "do", sname, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ent.SessionID.ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString()).ToString();
                //hypHRReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_EVALUATIONREPORT_REPORT, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ent.SessionID.ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString()).ToString();
                hypReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_EVALUATION_REPORT, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ent.SessionID.ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString()).ToString();

                lblEmployeeSubmitInfo.Visible = false;
                hypBtnDoHREvaluation.Visible = false;
                hypHRReport.Visible = false;
                #region IsSupervisor

                Int64 supervisorID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                HREmployeeEntity currentHREmployee = FCCHREmployee.GetFacadeCreate().GetByID(supervisorID);
                if (ent.SupervisorEmployeeID == supervisorID && ent.SessionCategoryID == MasterDataConstants.MDEvaluationSessionCategory.PBR || CurrentMember.MemberID == 25 || CurrentMember.MemberID == 182 || CurrentMember.MemberID == 317 || CurrentMember.MemberID == 20520 || CurrentMember.MemberID == 27 || CurrentMember.MemberID == 181)
                {
                    //hypReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_EVALUATION_REPORT, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ent.SessionID.ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString()).ToString();
                    hypBtnDoEvaluation.NavigateUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeeEvaluationMigration.aspx", string.Empty, "do", sname, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ent.SessionID.ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString(), UrlConstants.OVERVIEW_SUEPRVISOR_EMPLOYEE_ID, ent.SupervisorEmployeeID.ToString()).ToString();
                }
                else if (ent.SessionCategoryID == MasterDataConstants.MDEvaluationSessionCategory.PBR)
                {
                    //hypReport.Enabled = false;
                    hypBtnDoEvaluation.Enabled = false;
                    chbxShowAll.Visible = false;
                }
                else
                {
                    //hypReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_EVALUATION_REPORT, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ent.SessionID.ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString()).ToString();
                    hypBtnDoEvaluation.NavigateUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeeEvaluationMigration.aspx", string.Empty, "do", sname, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ent.SessionID.ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString(), UrlConstants.OVERVIEW_SUEPRVISOR_EMPLOYEE_ID, ent.SupervisorEmployeeID.ToString()).ToString();
                }
                if (CurrentMember.MemberID == 182 || CurrentMember.MemberID == 25 || CurrentMember.MemberID == 317 || CurrentMember.MemberID == 20520 || CurrentMember.MemberID == 27 || CurrentMember.MemberID == 181)
                {
                    chbxShowAll.Visible = true;
                }

                if ((CurrentMember.MemberID == 182 || CurrentMember.MemberID == 25 || CurrentMember.MemberID == 317 || CurrentMember.MemberID == 20520 || CurrentMember.MemberID == 27 || CurrentMember.MemberID == 181) && ent.SessionCategoryID == MasterDataConstants.MDEvaluationSessionCategory.PBR)
                {
                    hypBtnDoHREvaluation.Visible = true;
                    hypHRReport.Visible = true;
                    hypBtnDoHREvaluation.NavigateUrl = UrlHelper.BuildSecureUrl("~/HR/HREmployeeEvaluationReport.aspx", string.Empty, "do", sname, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ent.SessionID.ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString()).ToString();
                    hypHRReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_EVALUATIONREPORT_REPORT, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ent.SessionID.ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.EmployeeID.ToString()).ToString();
                }
                else
                {
                    hypBtnDoHREvaluation.Enabled = false;
                    hypHRReport.Enabled = false;
                }

                hypReport.Target = "_blank";
                hypBtnDoEvaluation.Target = "_blank";
                hypBtnDoHREvaluation.Target = "_blank";
                hypHRReport.Target = "_blank";
                #endregion IsSuperviosr

               

            }
        }

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
            String fe = String.Empty;

            if (PageAPType.ToString().IsNotNullOrEmpty())
            {
                if (PageAPType == MasterDataConstants.MDEvaluationSessionCategory.HEALTH_CHECKUP)
                {
                    fe = "MDEvaluationSessionCategory.SessionCategoryID " + " = " + MasterDataConstants.MDEvaluationSessionCategory.HEALTH_CHECKUP;

                }
                else if (PageAPType == MasterDataConstants.MDEvaluationSessionCategory.QUARTERLY_EVALUATIONS)
                {
                    fe = "MDEvaluationSessionCategory.SessionCategoryID " + " <> " + MasterDataConstants.MDEvaluationSessionCategory.HEALTH_CHECKUP;
                }
            }

            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeEvaluation.EmployeeID", MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember).ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeEvaluation.SupervisorEmployeeID", MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember).ToString(), SQLMatchType.Equal);
            String fe3 = "HREmployeeEvaluation.EmployeeSubmitDate is not null";

            String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe2, SQLJoinType.AND, fe3);
            String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe4);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe5);

            if (chbxShowAll.Checked)
            {
                if (PageAPType.ToString().IsNotNullOrEmpty())
                {
                    if (PageAPType == MasterDataConstants.MDEvaluationSessionCategory.HEALTH_CHECKUP)
                    {
                        fe = "MDEvaluationSessionCategory.SessionCategoryID " + " = " + MasterDataConstants.MDEvaluationSessionCategory.HEALTH_CHECKUP;

                    }
                    else if (PageAPType == MasterDataConstants.MDEvaluationSessionCategory.QUARTERLY_EVALUATIONS)
                    {
                        fe = "MDEvaluationSessionCategory.SessionCategoryID " + " <> " + MasterDataConstants.MDEvaluationSessionCategory.HEALTH_CHECKUP;
                    }
                }
            }

            if (chbxFilter.Checked)
            {
                if (txtSearchText.Text.Trim().IsNotNullOrEmpty())
                {
                    String fe55= SqlExpressionBuilder.PrepareFilterExpression("HREmployeeEvaluation.SupervisorEmployeeCode", txtSearchText.Text.ToString(), SQLMatchType.Equal);
                    String fe6 = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeEvaluation.EmployeeCode", txtSearchText.Text.ToString(), SQLMatchType.Equal);
                    String fe_code = SqlExpressionBuilder.PrepareFilterExpression(fe55, SQLJoinType.OR, fe6);

                    if (fe.IsNotNullOrEmpty())
                    {
                        fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe_code);
                    }
                    else
                    {
                        fe = fe_code;
                    }
                }
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

       
        #endregion

        #region Checkbox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindHREmployeeEvaluationList();
        }

        protected void chbxShowAll_CheckedChanged(object sender, EventArgs e)
        {
            BindHREmployeeEvaluationList();
        }

        #endregion

        #endregion Event
    }
}
