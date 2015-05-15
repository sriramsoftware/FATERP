using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bay.ERP.Web.UI.Helper;

namespace Bay.ERP.Web.UI
{
    public partial class SupplierMenuControl : SupplierBaseControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //mnuQuickLink.Items[0]..NavigateUrl.Depth

        }
        protected void mnuQuickLink_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            e.Item.NavigateUrl = UrlHelper.BuildSecureUrl(e.Item.NavigateUrl, string.Empty, UrlConstants.OVERVIEW_SUPPLIER_ID, this.OverviewSupplierID.ToString()).ToString();
       }
    }
}