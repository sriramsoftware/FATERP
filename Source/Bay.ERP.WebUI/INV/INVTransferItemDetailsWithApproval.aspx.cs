// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 01:46:09




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class INVTransferItemDetailsWithApprovalPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "INVTransferItemDetailsWithApprovalEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/INV/INVTransferItemDetailsWithApproval.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Transfer Item With Approval", " - ", base.Page.Title);

            ucINVTransferItemDetailsWithApprovalEntity.ContentHolderPageUrl = "~/INV/INVTransferItem.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
