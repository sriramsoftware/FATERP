// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class ACCApprovedPostPayableStatementDetailListPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "ACCApprovedPostPayableStatementDetailListEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/ACC/ACCApprovedPostPayableStatementDetailList.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Approved Payable Statement Detail", " - ", base.Page.Title);

            ucACCApprovedPostPayableStatementDetailListEntity.ContentHolderPageUrl = "~/ACC/ACCRegularPostPayableStatementDetailList.aspx";
            ucACCApprovedPostPayableStatementDetailListEntity.PageAPType = MasterDataConstants.MDAccountPaybleStatementDetailCategory.REGULAR;
            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
