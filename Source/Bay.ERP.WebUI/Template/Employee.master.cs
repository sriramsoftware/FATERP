using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bay.ERP.Web.UI.Helper;

namespace Bay.ERP.Web.UI
{
    public partial class TemplateEmployee : EmployeeBaseMasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }

            lblEmployeeName.Text = this.OverviewEmployeeDetailedEntity.EmployeeFullName;
            lblEmployeeCode.Text = this.OverviewEmployeeDetailedEntity.EmployeeCode;
            lblEmployeDesignation.Text = this.OverviewEmployeeDetailedEntity.DesignationName;
            lblEmployeeSalary.Text = this.OverviewEmployeeDetailedEntity.SalaryLevel.ToString();

            if (OverviewEmployeePhotoEntity.Path != null)
            {
                imgEmployeePhoto.ImageUrl = this.OverviewEmployeePhotoEntity.Path;
            }
            else
            {
                imgEmployeePhoto.ImageUrl = "~/Images/User.png";
            }
        }

        protected void mnuMain_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            e.Item.NavigateUrl = UrlHelper.BuildSecureUrl(e.Item.NavigateUrl, string.Empty, UrlConstants.OVERVIEW_EMPLOYEE_ID, this.OverviewEmployeeID.ToString()).ToString();
        }
    }
}