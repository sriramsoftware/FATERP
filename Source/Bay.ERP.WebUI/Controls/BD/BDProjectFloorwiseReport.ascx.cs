// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




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
    public partial class BDProjectFloorwiseReportControl : BaseControl
    {       
        #region Properties

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            ddlApprovalStatusID.Items.Add(new ListItem("In Approval Process", MasterDataConstants.WorkOrderStatus.IN_APPROVE_PROCESS.ToString()));
            ddlApprovalStatusID.Items.Add(new ListItem("Approved", MasterDataConstants.WorkOrderStatus.APPROVED.ToString()));
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtStartDate.Text = System.DateTime.Now.AddDays(-30).ToString(UIConstants.SHORT_DATE_FORMAT);
            txtEndDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
        }

        private void PrepareEditView()
        {
          
        }

        private void BindList()
        {
            BindBDProjectList();
        }

        private void BindBDProjectList()
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
        
        #region Button Event

        protected void btnShowReport_Click(object sender, EventArgs e)
        {
            String fe = String.Empty;
            String NavigationUrl = String.Empty;

            if (ddlProjectID.SelectedValue != "0" && ddlProjectID.Items.Count > 0)
            {
                fe = "vw_workOrderCosting.ProjectID = "+Int64.Parse(ddlProjectID.SelectedValue);
            }

            //else if (ddlApprovalStatusID.SelectedValue != "0" && ddlApprovalStatusID.Items.Count > 0)
            //{
            //    fe = "";
            //}

            //else if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            //{
            //    fe = "";
            //}

            //else if (txtEndDate.Text.Trim().IsNotNullOrEmpty())
            //{
            //    fe = "";
            //}

            NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.PROJECT_FLOOR_WISE_COST_REPORT, UrlConstants.OVERVIEW_FILTER_EXPRESSION_FLOOR_WISE_COST, fe).ToString();

            Helper.Response.Redirect(NavigationUrl);
        }

        #endregion

        #endregion Event
    }
}
