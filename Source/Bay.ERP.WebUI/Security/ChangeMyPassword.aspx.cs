// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Feb-2012, 02:51:44




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class AdminChangeMyPasswordPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "AdminChangeMyPasswordPage";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/Security/ChangeMyPassword.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Change Password", " - ", base.Page.Title);

            ucChangeMyPasswordEntity.ContentHolderPageUrl = "~/Admin/ChangeMyPassword.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
