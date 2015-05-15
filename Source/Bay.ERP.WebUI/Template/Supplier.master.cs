using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bay.ERP.Web.UI.Helper;

namespace Bay.ERP.Web.UI
{
    public partial class TemplateSupplier : SupplierBaseMasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MenuItem munSupplierInfo = new MenuItem();
                munSupplierInfo.Text = "Vendor Info";
                munSupplierInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMSupplierEditor.aspx", string.Empty, UrlConstants.OVERVIEW_SUPPLIER_ID, this.OverviewSupplierID.ToString()).ToString();

                MenuItem mnuSupplierAddressInfo = new MenuItem();
                mnuSupplierAddressInfo.Text = "Address Info";
                mnuSupplierAddressInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMSupplierAddressInfo.aspx", string.Empty, UrlConstants.OVERVIEW_SUPPLIER_ID, this.OverviewSupplierID.ToString()).ToString();

                MenuItem mnuSupplierContactPerson = new MenuItem();
                mnuSupplierContactPerson.Text = "Contact Person";
                mnuSupplierContactPerson.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMSupplierContactPerson.aspx", string.Empty, UrlConstants.OVERVIEW_SUPPLIER_ID, this.OverviewSupplierID.ToString()).ToString();

                MenuItem mnuSupplierBrandMap = new MenuItem();
                mnuSupplierBrandMap.Text = "Brand Map";
                mnuSupplierBrandMap.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMSupplierBrandMap.aspx", string.Empty, UrlConstants.OVERVIEW_SUPPLIER_ID, this.OverviewSupplierID.ToString()).ToString();

                //menuSupplier.Items.Add(munSupplierInfo);
                //menuSupplier.Items.Add(mnuSupplierAddressInfo);
                //menuSupplier.Items.Add(mnuSupplierContactPerson);
                //menuSupplier.Items.Add(mnuSupplierBrandMap);
            }

            lblSupplierName.Text = this.OverviewSupplier.SupplierName;
        }

        protected void mnuMain_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            e.Item.NavigateUrl = UrlHelper.BuildSecureUrl(e.Item.NavigateUrl, string.Empty, UrlConstants.OVERVIEW_SUPPLIER_ID, this.OverviewSupplierID.ToString()).ToString();
        }
    }
}