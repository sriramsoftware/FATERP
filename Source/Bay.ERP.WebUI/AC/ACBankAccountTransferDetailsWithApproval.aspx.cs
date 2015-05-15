// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class ACBankAccountTransferDetailsWithApprovalPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "ACBankAccountTransferDetailsWithApprovalEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/AC/ACBankAccountTransferDetailsWithApproval.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Bank Account Transfer Approval", " - ", base.Page.Title);

            ucACBankAccountTransferDetailsWithApprovalEntity.ContentHolderPageUrl = "~/ACBankAccountTransferDetailsWithApproval.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
