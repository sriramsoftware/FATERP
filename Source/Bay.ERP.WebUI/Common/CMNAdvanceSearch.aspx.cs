// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Feb-2012, 06:02:47




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class CMNAdvanceSearchPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "CMNAdvanceSearchEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/Common/CMNAdvanceSearch.ascx;";
            }
        }

        #endregion

        #region Methods

        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Bay's Advance Search", " - ", base.Page.Title);

            ucCMNAdvanceSearchEntity.ContentHolderPageUrl = "~/Common/CMNAdvanceSearch.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
