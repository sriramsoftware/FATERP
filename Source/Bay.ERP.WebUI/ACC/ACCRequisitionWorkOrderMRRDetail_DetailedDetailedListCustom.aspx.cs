// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 21-Jan-2013, 04:58:29




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class ACCRequisitionWorkOrderMRRDetail_DetailedPageDetailedListCustom : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "ACCRequisitionWorkOrderMRRDetail_DetailedEntityList_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/ACC/ACCRequisitionWorkOrderMRRDetail_DetailedListCustom.ascx;";
            }
        }

        #endregion

        #region Methods

        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
