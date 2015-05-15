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
    public partial class ASCreateNewRolePage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "ASCreateNewRolePage";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/Security/ASCreateNewRole.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Create New Role", " - ", base.Page.Title);

            ucASCreateNewRoleEntity.ContentHolderPageUrl = "~/Security/ASCreateNewRole.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
