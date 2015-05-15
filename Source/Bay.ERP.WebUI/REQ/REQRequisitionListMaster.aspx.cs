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

namespace Bay.ERP.Web.UI
{
    public partial class REQRequisitionListMasterPage : ProjectBasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "REQRequisitionListMasterPage";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/REQ/REQRequisitionListMaster.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Requisition List Master", " - ", base.Page.Title);

            ucREQRequisitionListMasterEntity.ContentHolderPageUrl = "~/REQ/REQRequisitionListMaster.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
