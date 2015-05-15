// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Apr-2012, 09:57:10




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class REQRequisitionPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "REQRequisitionPage";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/REQ/REQRequisition.ascx;";
            }
        }

        #endregion

        #region Methods

        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Requisition", " - ", base.Page.Title);

            ucREQRequisitionEntity.ContentHolderPageUrl = "~/REQ/REQRequisition.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
