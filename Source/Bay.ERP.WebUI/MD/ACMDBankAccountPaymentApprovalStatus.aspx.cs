// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:00:20




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class ACMDBankAccountPaymentApprovalStatusPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "ACMDBankAccountPaymentApprovalStatusEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/MD/ACMDBankAccountPaymentApprovalStatus.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("A CBank Account Payment Approval Status", " - ", base.Page.Title);

            ucACMDBankAccountPaymentApprovalStatusEntity.ContentHolderPageUrl = "~/ACMDBankAccountPaymentApprovalStatus.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
