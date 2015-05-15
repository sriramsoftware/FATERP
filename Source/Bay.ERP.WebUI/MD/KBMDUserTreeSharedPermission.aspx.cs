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
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class KBMDUserTreeSharedPermissionPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "KBMDUserTreeSharedPermissionEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/MD/KBMDUserTreeSharedPermission.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("K BUser Tree Shared Permission", " - ", base.Page.Title);

            ucKBMDUserTreeSharedPermissionEntity.ContentHolderPageUrl = "~/KBMDUserTreeSharedPermission.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
