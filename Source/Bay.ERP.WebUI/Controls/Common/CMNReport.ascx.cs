// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class CMNReportControl : BaseControl
    {       
        #region Properties

        public String ReportName { get; set; }

        public Int64 _FavoriteID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public String Action
        {
            get
            {
                String action = "Add";

                if (ViewState["do"] != null)
                {
                    action = ViewState["do"].ToString();
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["do"].ToString()))
                {
                    action = Helper.Url.SecureUrl["do"].ToString();

                    ViewState["do"] = action;
                }

                return action;
            }
            set
            {
                ViewState["do"] = value;
            }
        }
    

        #endregion

        #region Methods

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ReportName == ReportConstants.DUE_PAYMENT_SCHEDULE_REPORT)
                {
                    dvToDate.Visible = true;
                    txtToDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
                }

                else if (ReportName == ReportConstants.ENCASHED_REPORT)
                {
                    dvEncash.Visible = true;
                    txtToDateEncash.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
                }
            }
        }

        #endregion

        #region Button Event

        protected void btnShowReport_Click(object sender, EventArgs e)
        {
            String navUrl = String.Empty;

            switch (ReportName)
            {
                case ReportConstants.DUE_PAYMENT_SCHEDULE_REPORT:
                    navUrl= UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.DUE_PAYMENT_SCHEDULE_REPORT, UrlConstants.OVERVIEW_TO_DATE_DUE_PAYMENT_SCHEDULE,MiscUtil.ParseToDateTime(txtToDate.Text.Trim().ToString()).ToString()).ToString();
                    break;

                case ReportConstants.FLOOR_UNIT_BOOKING_REPORT:
                    navUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.FLOOR_UNIT_BOOKING_REPORT, UrlConstants.REQUISITION_ID, "nothing").ToString();
                    break;

                case ReportConstants.PROJECT_FLOOR_UNIT_STATUS_WISE_REPORT:
                    navUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.PROJECT_FLOOR_UNIT_STATUS_WISE_REPORT, UrlConstants.REQUISITION_ID, "nothing").ToString();
                    break;

                case ReportConstants.ENCASHED_REPORT:
                        navUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.ENCASHED_REPORT, UrlConstants.OVERVIEW_TO_DATE_ENCASHED, MiscUtil.ParseToDateTime(txtToDateEncash.Text.Trim().ToString()).ToString(),UrlConstants.OVERVIEW_IS_ENCASHED,chkIsEncashed.Checked.ToString()).ToString();
                    break;
            }

            if(navUrl.IsNotNullOrEmpty())
            {
                Response.Redirect(navUrl);
            }
        }

        #endregion

        #endregion Event
    }
}
