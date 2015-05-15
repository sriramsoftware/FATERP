// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 31-Jan-2013, 04:31:48




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Linq;
using System.Web.UI.WebControls;

namespace Bay.ERP.Web.UI
{
    public partial class ACBankAccountPaymentDetailsWithApprovalPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "ACBankAccountPaymentDetailsWithApprovalEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/AC/ACBankAccountPaymentDetailsWithApproval.ascx;";
            }
        }

        #endregion

        #region Methods

        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Bank Account Payment With Approval Details", " - ", base.Page.Title);

            ucACBankAccountPaymentDetailsWithApprovalEntity.ContentHolderPageUrl = "~/ACBankAccountPaymentDetailsWithApproval.aspx";
            
            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
