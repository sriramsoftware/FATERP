// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Jun-2013, 05:04:04




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class PRMVendorAccountMapPage : SupplierBasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "PRMVendorAccountMapEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/AC/ACAccountResourceAccountMap.ascx;";
            }
        }

        #endregion

        #region Methods

        private Int64 PrepareResourceCategory()
        {
            Int64 resourceCategoryID = 0;

            switch (OverviewSupplier.SupplierTypeID)
            {

                case MasterDataConstants.MDSupplierType.LOCAL:
                case MasterDataConstants.MDSupplierType.IMPORTER:
                case MasterDataConstants.MDSupplierType.LOCAL_AND_IMPORTER:
                    resourceCategoryID = MasterDataConstants.ACMDAccountResourceCategory.VENDOR;
                    break;
                case MasterDataConstants.MDSupplierType.CONTRACTOR:
                    resourceCategoryID = MasterDataConstants.ACMDAccountResourceCategory.CONTRACTOR;
                    break;
                case MasterDataConstants.MDSupplierType.CONSULTANT:
                    resourceCategoryID = MasterDataConstants.ACMDAccountResourceCategory.CONSULTANT;
                    break;

            }

            return resourceCategoryID;
        }


        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Resource Account Map", " - ", base.Page.Title);

            ucACAccountResourceAccountMapEntity.ContentHolderPageUrl = "~/ACResourceBankAccountMap.aspx";
            ucACAccountResourceAccountMapEntity.accountResourceCategory = PrepareResourceCategory();

            ucACAccountResourceAccountMapEntity.referenceID = OverviewSupplierID;

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
