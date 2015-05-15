// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jul-2012, 05:23:43




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class BDProjectAssignedPersonPage : ProjectBasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "BDProjectAssignedPersonEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/BD/BDProjectAssignedPerson.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Project Assigned Person", " - ", base.Page.Title);

            ucBDProjectAssignedPersonEntity.ContentHolderPageUrl = "~/BD/BDProjectAssignedPerson.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}