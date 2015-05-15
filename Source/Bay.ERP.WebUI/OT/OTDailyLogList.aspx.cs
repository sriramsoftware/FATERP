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
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class OTDailyLogListPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "OTDailyLogListEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/OT/OTDailyLogList.ascx;";
            }
        }

        #endregion

        #region Methods

        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Daily Log List", " - ", base.Page.Title);

            ucOTDailyLogListEntity.ContentHolderPageUrl = "~/Controls/OT/OTDailyLogList.aspx";
            ucOTDailyLogListEntity.PageAPType = MasterDataConstants.IssuePageType.MY_ISSUE_LIST;

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
