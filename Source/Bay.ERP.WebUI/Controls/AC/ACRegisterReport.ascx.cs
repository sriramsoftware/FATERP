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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Web.UI;

namespace Bay.ERP.Web.UI
{
    public partial class ACRegisterReportControl : BaseControl
    {
        #region Properties

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            ddlRegisterCategoryID.Items.Add(new ListItem("Bank Payment", "1"));
            ddlRegisterCategoryID.Items.Add(new ListItem("Cash Payment", "5"));
            ddlRegisterCategoryID.Items.Add(new ListItem("Bank Deposit", "2"));
            ddlRegisterCategoryID.Items.Add(new ListItem("Journal", "3"));
            ddlRegisterCategoryID.Items.Add(new ListItem("Day Book", "4"));
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtStartDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtEndDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
        }

        private void PrepareEditView()
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
            String NavigationUrl = String.Empty;

            if (ddlRegisterCategoryID.SelectedValue != "0" && ddlRegisterCategoryID.Items.Count>0)
            {
                switch (ddlRegisterCategoryID.SelectedValue)
                {
                    case "1":
                        NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.BANK_ACCOUNT_PAYMENT_REGISTER_REPORT, UrlConstants.OVERVIEW_REGISTER_FROM_DATE, txtStartDate.Text.Trim().ToString(), UrlConstants.OVERVIEW_REGISTER_TO_DATE, txtEndDate.Text.Trim().ToString()).ToString();
                        break;
                    case "2":
                        NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.BANK_ACCOUNT_DEPOSIT_REGISTER_REPORT, UrlConstants.OVERVIEW_REGISTER_FROM_DATE, txtStartDate.Text.Trim().ToString(), UrlConstants.OVERVIEW_REGISTER_TO_DATE, txtEndDate.Text.Trim().ToString()).ToString();
                        break;
                    case "3":
                        NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.TEMPORARY_JOURNAL_REGISTER_REPORT, UrlConstants.OVERVIEW_REGISTER_FROM_DATE, txtStartDate.Text.Trim().ToString(), UrlConstants.OVERVIEW_REGISTER_TO_DATE, txtEndDate.Text.Trim().ToString()).ToString();
                        break;
                    case "4":
                        NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.DAY_BOOK_REPORT, UrlConstants.OVERVIEW_REGISTER_FROM_DATE, txtStartDate.Text.Trim().ToString(), UrlConstants.OVERVIEW_REGISTER_TO_DATE, txtEndDate.Text.Trim().ToString()).ToString();
                        break;
                    case "5":
                        NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.CASH_PAYMENT_REGISTER_REPORT, UrlConstants.OVERVIEW_REGISTER_FROM_DATE, txtStartDate.Text.Trim().ToString(), UrlConstants.OVERVIEW_REGISTER_TO_DATE, txtEndDate.Text.Trim().ToString()).ToString();
                        break;
                }
            }

            Helper.Response.Redirect(NavigationUrl);
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        #endregion Event
    }
}
