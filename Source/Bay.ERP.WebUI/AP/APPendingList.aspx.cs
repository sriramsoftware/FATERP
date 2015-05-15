// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class APPendingListPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "APPendingList_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/AP/Default.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("My Pending List", " - ", base.Page.Title);

            ucAPPendingListEntity.ContentHolderPageUrl = "~/AP/Default.aspx";
            ucAPPendingListEntity.PageAPType = MasterDataConstants.APFeedback.FEEDBACK_REQUESTED;    

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
