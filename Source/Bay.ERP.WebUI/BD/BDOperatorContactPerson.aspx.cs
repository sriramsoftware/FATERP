// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:50:36




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class BDOperatorContactPersonPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "BDOperatorContactPersonEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/BDOperatorContactPerson.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion


        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Operator Contact Person", " - ", base.Page.Title);

            ucBDOperatorContactPersonEntity.ContentHolderPageUrl = "~/BD/BDOperatorContactPerson.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
