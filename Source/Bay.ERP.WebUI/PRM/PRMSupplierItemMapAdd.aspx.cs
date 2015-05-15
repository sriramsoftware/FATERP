// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Web.UI.WebControls;

namespace Bay.ERP.Web.UI
{
    public partial class PRMSupplierItemMapAddPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "PRMSupplierItemMapAddEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/PRM/PRMSupplierItemMapAdd.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Vendor Item Map", " - ", base.Page.Title);

            ucPRMSupplierItemMapAddEntity.ContentHolderPageUrl = "~/PRM/PRMSupplierItemMapAdd.aspx";

            if (!IsPostBack)
            {
        
            }
        }

        #endregion
    }
}