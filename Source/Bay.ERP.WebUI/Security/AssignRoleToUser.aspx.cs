// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Feb-2010, 12:41:01




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class AssignRoleToUserPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "AssignRoleToUser_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/Security/AssignRoleToUser.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Assign Role To User", " - ", base.Page.Title);

            ucAssignRoleToUserEntity.ContentHolderPageUrl = "~/Security/AssignRoleToUser.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
