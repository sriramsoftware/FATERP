// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class INVStoreIssueNoteItemMapPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "INVStoreIssueNoteItemMapEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/INV/INVStoreIssueNoteItemMap.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Store Issue Note Item Map", " - ", base.Page.Title);

            ucINVStoreIssueNoteItemMapEntity.ContentHolderPageUrl = "~/INVStoreIssueNoteItemMap.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
