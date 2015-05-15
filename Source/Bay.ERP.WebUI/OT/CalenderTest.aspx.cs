using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bay.ERP.Web.UI
{
    public partial class OTCalenderTest : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "OTCalenderTestEntity_Page";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/OT/OTIssue.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hydOverviewProjectID.Value = "1";
            }
        }
    }
}