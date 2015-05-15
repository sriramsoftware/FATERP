// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class CRMExistingBuyerBasicInfoPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "CRMExistingBuyerBasicInfoEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/CRM/CRMBuyerBasicInfo.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Existing Buyer", " - ", base.Page.Title);

            ucCRMExistingBuyerBasicInfoEntity.ContentHolderPageUrl = "~/CRMBuyerBasicInfo.aspx";
            ucCRMExistingBuyerBasicInfoEntity.PageAPType = MasterDataConstants.CRMMDBuyerType.EXISTING_BUYER;

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
