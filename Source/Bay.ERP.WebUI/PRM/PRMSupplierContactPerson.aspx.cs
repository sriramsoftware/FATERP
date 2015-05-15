// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class PRMSupplierContactPersonPage : SupplierBasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "PRMSupplierContactPersonEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/PRM/PRMSupplierContactPerson.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Vendor Contact Person", " - ", base.Page.Title);

            ucPRMSupplierContactPersonEntity.ContentHolderPageUrl = "~/PRM/PRMSupplierContactPerson.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}