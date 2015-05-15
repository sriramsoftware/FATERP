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
    public partial class HREmployeeReportsUnderSalarySessionControl : BaseControl
    {       
        #region Properties

        

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

          
        }

        private void PrepareEditView()
        {
            //HREmployeeNoticeEntity hREmployeeNoticeEntity = CurrentHREmployeeNoticeEntity;


            //if (!hREmployeeNoticeEntity.IsNew)
            //{
              
            //}
        }

        private void BindList()
        {
            BindHREmployeeNoticeList();
        }

        private void BindHREmployeeNoticeList()
        {
            //lvHREmployeeNotice.DataBind();
        }

        private HREmployeeNoticeEntity BuildHREmployeeNoticeEntity()
        {
            HREmployeeNoticeEntity hREmployeeNoticeEntity = new HREmployeeNoticeEntity();

           


            return hREmployeeNoticeEntity;
        }

        private void SaveHREmployeeNoticeEntity()
        {
           
        }

        private void GenerateReports()
        {
            String NavigationUrl = String.Empty;
            hypEmployeeTimeSheetReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_MONTHLY_TIME_SHEET_SUMMARY_REPORT, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, (ddlSalarySessionID.SelectedValue).ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_FROMID, MasterDataConstants.MDDepartment.MIS_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_TOID, MasterDataConstants.MDDepartment.IS_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_OTHERID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString()).ToString();
            hypEmployeeTimeSheetReport.Target = "_blank";

            hypSecurityGuardTimeSheetReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_MONTHLY_TIME_SHEET_SUMMARY_REPORT, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, (ddlSalarySessionID.SelectedValue).ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_FROMID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_TOID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_OTHERID, MasterDataConstants.MDDepartment.NO_DEPARTMENTID.ToString()).ToString();
            hypSecurityGuardTimeSheetReport.Target = "_blank";

            hypEmployeeSalaryPaymentReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_SALARY_PAYMENT_REPORT, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, (ddlSalarySessionID.SelectedValue).ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_FROMID, MasterDataConstants.MDDepartment.MIS_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_TOID, MasterDataConstants.MDDepartment.IS_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_OTHERID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString()).ToString();
            hypEmployeeSalaryPaymentReport.Target = "_blank";

            hypSecurityGaurdSalaryPaymentReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_SALARY_PAYMENT_REPORT, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, (ddlSalarySessionID.SelectedValue).ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_FROMID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_TOID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_OTHERID, MasterDataConstants.MDDepartment.NO_DEPARTMENTID.ToString()).ToString();
            hypSecurityGaurdSalaryPaymentReport.Target = "_blank";

            hypEmployeeSalaryStatementReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_SALARY_STATEMENT_REPORT, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, (ddlSalarySessionID.SelectedValue).ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_FROMID, MasterDataConstants.MDDepartment.MIS_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_TOID, MasterDataConstants.MDDepartment.IS_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_OTHERID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString()).ToString();
            hypEmployeeSalaryStatementReport.Target = "_blank";

            hypSecurityGaurdSalaryStatementReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_SALARY_STATEMENT_REPORT, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, (ddlSalarySessionID.SelectedValue).ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_FROMID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_TOID, MasterDataConstants.MDDepartment.SECURITY_DEPARTMENTID.ToString(), UrlConstants.OVERVIEW_MDDEPARTMENT_OTHERID, MasterDataConstants.MDDepartment.NO_DEPARTMENTID.ToString()).ToString();
            hypSecurityGaurdSalaryStatementReport.Target = "_blank";

            hypBankDisbursementLevel4Plus.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_SALARY_DISBURSEMENT_BANK, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, (ddlSalarySessionID.SelectedValue).ToString(), UrlConstants.OVERVIEW_FROM_LEVEL, MasterDataConstants.HREmployeeSalaryLevel.Level4.ToString(), UrlConstants.OVERVIEW_TO_LEVEL, MasterDataConstants.HREmployeeSalaryLevel.Level20.ToString()).ToString();
            hypBankDisbursementLevel4Plus.Target = "_blank";

            hypBankDisbursementLevel1To3.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_SALARY_DISBURSEMENT_BANK, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, (ddlSalarySessionID.SelectedValue).ToString(), UrlConstants.OVERVIEW_FROM_LEVEL, MasterDataConstants.HREmployeeSalaryLevel.Level1.ToString(), UrlConstants.OVERVIEW_TO_LEVEL, MasterDataConstants.HREmployeeSalaryLevel.Level3.ToString()).ToString();
            hypBankDisbursementLevel1To3.Target = "_blank";

            hypLeaveApplications.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_LEAVE_APPLICATIONS_REPORT, UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID, (ddlSalarySessionID.SelectedValue).ToString()).ToString();
            hypLeaveApplications.Target = "_blank";
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
                GenerateReports();
            }
        }

        #endregion

        #region List View Event


        #endregion List View Event

        #region ObjectDataSource Event

        

        #endregion

        #region Drop Down Event

        protected void ddlSalarySessionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateReports();
        }

        #endregion

        #endregion Event
    }
}
