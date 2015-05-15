// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class HRDTLSubmissionReportControl : BaseControl
    {       
        #region Properties

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
            txtStartDate.Text = System.DateTime.Now.AddDays(-7).ToString(UIConstants.SHORT_DATE_FORMAT);
            txtEndDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
        }

        private void PrepareEditView()
        {
          
        }

        private void BindList()
        {
            BindOTIssueList();
        }

        private void BindOTIssueList()
        {
            
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

        #region ObjectDataSource Event

        #endregion

        #region Button Event

        protected void btnShowReport_Click(object sender, EventArgs e)
        {
            String NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_DTL_SUBMISSION_REPORT, UrlConstants.OVERVIEW_ISSUE_FROM_DATE, txtStartDate.Text.Trim().ToString(), UrlConstants.OVERVIEW_ISSUE_TO_DATE, txtEndDate.Text.Trim().ToString()).ToString();
            Helper.Response.Redirect(NavigationUrl);
        }

        #endregion

        #endregion Event
    }
}
