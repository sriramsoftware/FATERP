using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bay.ERP.Web.UI
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:SecureButton runat=server></{0}:SecureButton>")]
    public class SecureButton : Button
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string UniqueKey
        {
            get
            {
                String s = (String)ViewState["UniqueKey"];
                return ((s == null) ? "[" + this.ID + "]" : s);
            }

            set
            {
                ViewState["UniqueKey"] = value;
            }
        }

        protected override void OnInit(EventArgs e)
        {
            String pageUniqueKey = ((BasePage)this.Page).UniqueKey;

            String combinedUniqueKey = pageUniqueKey + SecurityConstants.KEY_GLUE + this.UniqueKey;

            this.Visible = PermissionHelper.IsUerHasPermission(combinedUniqueKey);

            //this.Visible = true;
        }

        protected override void RenderContents(HtmlTextWriter output)
        {            
        }       
    }
}