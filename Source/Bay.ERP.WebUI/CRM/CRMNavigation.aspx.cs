// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Helper;

namespace Bay.ERP.Web.UI
{
    public partial class CRMNavigationPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "CRMNavigationEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/CRM/CRMNavigation.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Customer", " - ", base.Page.Title);

            ucCRMNavigationEntity.ContentHolderPageUrl = "~/CRMCustomer.aspx";

            if (!IsPostBack)
            {
                String navUrl = UrlHelper.BuildSecureUrl("~/Common/CMNDashboardItemView.aspx", string.Empty, UrlConstants.OVERVIEW_DASHBOARD_ITEM_ID, "40").ToString();
                Response.Redirect(navUrl);

            }
        }

        #endregion
    }
}
