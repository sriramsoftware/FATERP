// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class BDProjectStatusWiseFloorUnitReportPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "BDProjectStatusWiseFloorUnitReportEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/Common/CMNReport.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Due Payment Schedule Report", " - ", base.Page.Title);

            ucCMNReportEntity.ReportName = ReportConstants.PROJECT_FLOOR_UNIT_STATUS_WISE_REPORT;

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}