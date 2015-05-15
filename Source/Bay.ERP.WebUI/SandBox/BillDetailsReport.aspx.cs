// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:42:57




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class BillDetailsReportPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "BillDetailsReportPage";
            }
        }

        //public override string WebUserControlPaths
        //{
        //    get
        //    {
        //        return "~/Controls/MD/MDCity.ascx;";
        //    }
        //}

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("City", " - ", base.Page.Title);

           // ucMDCityEntity.ContentHolderPageUrl = "~/Controls/MD/MDCity.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
