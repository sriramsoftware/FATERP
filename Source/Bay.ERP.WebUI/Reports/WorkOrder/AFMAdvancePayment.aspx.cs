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
using System.Web.UI.WebControls;
using Bay.ERP.Web.UI.Helper;

namespace Bay.ERP.Web.UI
{
    public partial class AFMAdvancePaymentPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "AFMAdvancePaymentEntity_Page";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Advance Payment", " - ", base.Page.Title);

           // ucMDCityEntity.ContentHolderPageUrl = "~/Controls/MD/MDCity.aspx";

            if (!IsPostBack)
            {

            }
        }


        protected void GridView3_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (GridView3.Rows.Count > 0)
            {
                HyperLink hlControl = new HyperLink();
                hlControl.Text = "Report";
                hlControl.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "WorkOrderReport", UrlConstants.OVERVIEW_WORKORDER_ID, e.Row.Cells[11].Text.ToString()).ToString();
                e.Row.Cells[12].Controls.Add(hlControl);
            }
        }

        #endregion
       
}
}
