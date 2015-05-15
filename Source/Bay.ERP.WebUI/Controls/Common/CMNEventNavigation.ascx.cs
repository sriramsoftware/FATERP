// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




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
    public partial class CMNEventNavigationControl : BaseControl
    {       
        #region Properties

        public Int64 PageNavigationType { get; set; }
        public Int64 PageAPType { get; set; }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            
        }

        private void PrepareValidator()
        {
        }

        private String BuildNavigationUrl()
        {
            String navUrl = String.Empty;

            switch (PageNavigationType)
            {
                case MasterDataConstants.EventPageType.EVENT:
                    navUrl = "~/Common/CMNEvent.aspx";
                    break;
                case MasterDataConstants.EventPageType.EVENT_SCHEDULE:
                    navUrl = "~/Common/CMNEventSchedule.aspx";
                    break;
            }

            return  navUrl;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
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

        protected void btnArtGalleryEvent_Click(object sender, EventArgs e)
        {
            String navUrl = UrlHelper.BuildSecureUrl(BuildNavigationUrl(), string.Empty, UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID, MasterDataConstants.CMNMDEventIdentityCategory.ART_GALLERY_EVENT.ToString()).ToString();
            Helper.Response.Redirect(navUrl);
        }

        protected void btnBayOfficialEvent_Click(object sender, EventArgs e)
        {
            String navUrl = UrlHelper.BuildSecureUrl(BuildNavigationUrl(), string.Empty, UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID, MasterDataConstants.CMNMDEventIdentityCategory.BAY_S_OFFICIAL_EVENT.ToString()).ToString();
            Helper.Response.Redirect(navUrl);
        }

        protected void btnFrontDeskEvent_Click(object sender, EventArgs e)
        {
            String navUrl = UrlHelper.BuildSecureUrl(BuildNavigationUrl(), string.Empty, UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID, MasterDataConstants.CMNMDEventIdentityCategory.FRONT_DESK_EVENT.ToString()).ToString();
            Helper.Response.Redirect(navUrl);
        }

        protected void btnWorkOrderEvent_Click(object sender, EventArgs e)
        {
            String navUrl = UrlHelper.BuildSecureUrl(BuildNavigationUrl(), string.Empty, UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID, MasterDataConstants.CMNMDEventIdentityCategory.EVENT_FROM_WORKORDER.ToString()).ToString();
            Helper.Response.Redirect(navUrl);
        }

        #endregion

        #endregion Event
    }
}
