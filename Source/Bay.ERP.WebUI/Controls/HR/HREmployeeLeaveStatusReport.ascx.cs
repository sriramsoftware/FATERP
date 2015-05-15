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
    public partial class HREmployeeLeaveStatusReportControl : BaseControl
    {       
        #region Properties

        

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACFiscalYear(ddlACFiscalYearID, false);
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

        private void GenerateReport()
        {
            String NavigationUrl = String.Empty;
            hypLeaveStatusReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_LEAVE_STATUS_REPORT, UrlConstants.OVERVIEW_FISCALYEAR_ID, (Int64.Parse(ddlACFiscalYearID.SelectedValue)).ToString()).ToString();
            hypLeaveStatusReport.Target = "_blank";
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
                GenerateReport();
            }
        }

        #endregion

        #region List View Event


        #endregion List View Event

        #region ObjectDataSource Event

        

        #endregion

        #region Drop Down Event

        protected void ddlACFiscalYearID_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateReport();
        }

        #endregion

        #endregion Event
    }
}
