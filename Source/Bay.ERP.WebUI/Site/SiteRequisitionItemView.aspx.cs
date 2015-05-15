using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Web.UI.WebControls;
using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.Web.UI
{
    public partial class SiteRequisitionItemViewPage : ProjectBasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "SiteRequisitionItemViewPage";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/REQ/REQRequisitionItemView.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events



        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("Requisition Item View", " - ", base.Page.Title);

            ucREQRequisitionItemViewEntity.ContentHolderPageUrl = "~/REQ/REQRequisitionItemView.aspx";

            if (!IsPostBack)
            {

            }
        }

        #endregion
    }
}
