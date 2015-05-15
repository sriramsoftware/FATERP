using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bay.ERP.Web.UI.Helper;

namespace Bay.ERP.Web.UI
{
    public partial class TemplateConsultant : ConsultantBaseMasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MenuItem mnuConsultantInfo = new MenuItem();
                mnuConsultantInfo.Text = "Consultant Info";
                mnuConsultantInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMConsultantEditor.aspx", string.Empty, UrlConstants.OVERVIEW_CONSULTANT_ID, this.OverviewConsultantID.ToString()).ToString();

                MenuItem mnuConsultantdressInfo = new MenuItem();
                mnuConsultantdressInfo.Text = "AddressInfo";
                mnuConsultantdressInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMConsultantAddressInfo.aspx", string.Empty, UrlConstants.OVERVIEW_CONSULTANT_ID, this.OverviewConsultantID.ToString()).ToString();

                MenuItem mnuConsultantContactPerson = new MenuItem();
                mnuConsultantContactPerson.Text = "Contact Person";
                mnuConsultantContactPerson.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMConsultantContactPerson.aspx", string.Empty, UrlConstants.OVERVIEW_CONSULTANT_ID, this.OverviewConsultantID.ToString()).ToString();

                MenuItem mnuContractorEnlistedWorkArea = new MenuItem();
                mnuContractorEnlistedWorkArea.Text = "Enlisted WorkArea";
                mnuContractorEnlistedWorkArea.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMConsultantEnlistedWorkArea.aspx", string.Empty, UrlConstants.OVERVIEW_CONSULTANT_ID, this.OverviewConsultantID.ToString()).ToString();

                MenuItem mnuContractorAssignedWorkArea = new MenuItem();
                mnuContractorAssignedWorkArea.Text = "Assigned Work";
                mnuContractorAssignedWorkArea.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMConsultantAssignedWorkArea.aspx", string.Empty, UrlConstants.OVERVIEW_CONSULTANT_ID, this.OverviewConsultantID.ToString()).ToString();

                //menuContractor.Items.Add(mnuConsultantInfo);
                //menuContractor.Items.Add(mnuConsultantdressInfo);
                //menuContractor.Items.Add(mnuConsultantContactPerson);
                //menuContractor.Items.Add(mnuContractorEnlistedWorkArea);
                //menuContractor.Items.Add(mnuContractorAssignedWorkArea);
                
            }

            lblConsultantName.Text = this.OverviewConsultant.Name;
        }

        protected void mnuMain_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            e.Item.NavigateUrl = UrlHelper.BuildSecureUrl(e.Item.NavigateUrl, string.Empty, UrlConstants.OVERVIEW_CONSULTANT_ID, this.OverviewConsultantID.ToString()).ToString();
        }
    }
}