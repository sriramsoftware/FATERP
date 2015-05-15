using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bay.ERP.Web.UI.Helper;

namespace Bay.ERP.Web.UI
{
    public partial class TemplateContractor : ContractorBaseMasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MenuItem mnuContractorInfo = new MenuItem();
                mnuContractorInfo.Text = "Contractor Info";
                mnuContractorInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMContractorEditor.aspx", string.Empty, UrlConstants.OVERVIEW_CONTRACTOR_ID, this.OverviewContractorID.ToString()).ToString();

                MenuItem mnuContractorAddressInfo = new MenuItem();
                mnuContractorAddressInfo.Text = "AddressInfo";
                mnuContractorAddressInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMContractorAddressInfo.aspx", string.Empty, UrlConstants.OVERVIEW_CONTRACTOR_ID, this.OverviewContractorID.ToString()).ToString();

                MenuItem mnuContratorMajorProject = new MenuItem();
                mnuContratorMajorProject.Text = "Major Projects";
                mnuContratorMajorProject.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMContractorMajorProjectExecuted.aspx", string.Empty, UrlConstants.OVERVIEW_CONTRACTOR_ID, this.OverviewContractorID.ToString()).ToString();

                MenuItem mnuContractorContactPerson = new MenuItem();
                mnuContractorContactPerson.Text = "Contact Person";
                mnuContractorContactPerson.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMContractorContactPerson.aspx", string.Empty, UrlConstants.OVERVIEW_CONTRACTOR_ID, this.OverviewContractorID.ToString()).ToString();

                MenuItem mnuContractorEquipmentList = new MenuItem();
                mnuContractorEquipmentList.Text = "Equipment List";
                mnuContractorEquipmentList.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMContractorEquipmentList.aspx", string.Empty, UrlConstants.OVERVIEW_CONTRACTOR_ID, this.OverviewContractorID.ToString()).ToString();

                MenuItem mnuFinancialStrength = new MenuItem();
                mnuFinancialStrength.Text = "Financial Strength";
                mnuFinancialStrength.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMFinancialStrengthMajorWork.aspx", string.Empty, UrlConstants.OVERVIEW_CONTRACTOR_ID, this.OverviewContractorID.ToString()).ToString();

                MenuItem mnuContractorLicence = new MenuItem();
                mnuContractorLicence.Text = "Licence No";
                mnuContractorLicence.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMContractorLicence.aspx", string.Empty, UrlConstants.OVERVIEW_CONTRACTOR_ID, this.OverviewContractorID.ToString()).ToString();

                MenuItem mnuCriterionStatusRemark = new MenuItem();
                mnuCriterionStatusRemark.Text = "Critierion Remarks";
                mnuCriterionStatusRemark.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMCriterionStatusRemarks.aspx", string.Empty, UrlConstants.OVERVIEW_CONTRACTOR_ID, this.OverviewContractorID.ToString()).ToString();

                

                //menuContractor.Items.Add(mnuContractorInfo);
                //menuContractor.Items.Add(mnuContractorAddressInfo);
                //menuContractor.Items.Add(mnuContratorMajorProject);
                //menuContractor.Items.Add(mnuContractorContactPerson);
                //menuContractor.Items.Add(mnuContractorEquipmentList);
                //menuContractor.Items.Add(mnuFinancialStrength);
                //menuContractor.Items.Add(mnuContractorLicence);
                //menuContractor.Items.Add(mnuCriterionStatusRemark);
            }

            lblContractorName.Text = this.OverviewContractor.Name;
        }

        protected void mnuMain_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            e.Item.NavigateUrl = UrlHelper.BuildSecureUrl(e.Item.NavigateUrl, string.Empty, UrlConstants.OVERVIEW_CONTRACTOR_ID, this.OverviewContractorID.ToString()).ToString();
        }
    }
}