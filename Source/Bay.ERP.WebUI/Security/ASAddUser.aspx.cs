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
    public partial class ASAddUserPage : BasePage
    {
        public override string UniqueKey
        {
            get
            {
                return "ASAddUserPage";
            }
        }

        //// SeperatedBy ;
        //public override string WebUserControlPaths
        //{
        //    get
        //    {
        //        return "~/Controls/Security/ASSiteMap.ascx;";
        //    }
        //}

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ActivateRoleSetup(object sender, EventArgs e)
        {
            String[] roles = Roles.GetAllRoles();
            foreach (String strRole in roles)
            {
                ListItem li = new ListItem(strRole);
                ListBox1.Items.Add(li);
            }
            //ListBox1.DataSource = Roles.GetAllRoles();
            //ListBox1.DataBind();
        }

        protected void DeactivateRoleSetup(object sender, EventArgs e)
        {
            String[] roles = Roles.GetAllRoles();
            Roles.AddUserToRoles(this.Page.User.Identity.Name, roles);
        }
    }
}