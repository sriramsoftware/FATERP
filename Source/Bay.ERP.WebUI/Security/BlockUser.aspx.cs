using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Bay.ERP.Web.UI
{
    public partial class BlockUserPage : BasePage
    {
        public override string UniqueKey
        {
            get { return "BlockUser_Page"; }
        }


        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/Security/BlockUser.ascx;";
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}