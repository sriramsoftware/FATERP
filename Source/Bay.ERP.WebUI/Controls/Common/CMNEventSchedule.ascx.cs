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

namespace Bay.ERP.Web.UI
{
    public partial class CMNEventScheduleNavigationControl : BaseControl
    {
        #region Properties
        public Int64 OverviewEventIdentityCategoryID
        {
            get
            {
                Int64 overviewEventIdentityCategoryID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID], out overviewEventIdentityCategoryID);
                }

                return overviewEventIdentityCategoryID;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMNMDEventCategoryByEventIdentity(ddlEventCategoryID, false, OverviewEventIdentityCategoryID);
            SetResourceIDByDropdown();
        }

        private void PrepareValidator()
        {
        }

        private void SetResourceIDByDropdown()
        {
            if (ddlEventCategoryID.SelectedValue != "0" && ddlEventCategoryID.Items.Count > 0)
            {
                hfOverviewEventCategoryID.Value = ddlEventCategoryID.SelectedValue.ToString();
            }
            hfOverviewOwnerMemberID.Value = CurrentMember.MemberID.ToString();
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            #region Decision

            //Need to change here.
            hfOverviewEventIdentityID.Value = OverviewEventIdentityCategoryID.ToString();

            #endregion
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

        #region Dropdown Event

        protected void ddlEventCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetResourceIDByDropdown();
        }

        #endregion

        #endregion Event
    }
}
