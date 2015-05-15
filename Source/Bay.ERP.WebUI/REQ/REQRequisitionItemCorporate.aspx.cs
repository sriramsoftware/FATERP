// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jan-2012, 04:11:49




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Web.UI.WebControls;
using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.Web.UI
{
    public partial class REQRequisitionItemCorporatePage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "REQRequisitionItemCorporatePage";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/REQ/REQRequisitionItemCorporate.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Requisition Item Corporate", " - ", base.Page.Title);

            ucREQRequisitionItemCorporateEntity.ContentHolderPageUrl = "~/REQ/REQRequisitionItemCorporate.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
