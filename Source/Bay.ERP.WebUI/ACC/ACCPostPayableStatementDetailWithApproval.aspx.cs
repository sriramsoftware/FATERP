// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class ACCPostPayableStatementDetailWithApprovalPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "ACCPostPayableStatementDetailWithApprovalEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/ACC/ACCPostPayableStatementDetailWithApproval.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Payable Statement Detail With Approval", " - ", base.Page.Title);

            ucACCPostPayableStatementDetailWithApprovalEntity.ContentHolderPageUrl = "~/ACCPostPayableStatementDetailWithApproval.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
