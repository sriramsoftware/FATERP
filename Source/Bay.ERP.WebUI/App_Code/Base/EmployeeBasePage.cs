using System;
using System.Diagnostics;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web;
using System.Collections;

using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Web.UI.Helper;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI;
using System.Collections.Generic;

namespace Bay.ERP.Web.UI
{
    public abstract class EmployeeBasePage : BasePage
    {
        #region Properties

        public Int64 OverviewEmployeeID
        {
            get
            {
                Int64 overviewEmployeeID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID], out overviewEmployeeID);
                }

                return overviewEmployeeID;
            }
        }

        public HREmployeeEntity OverviewEmployee
        {
            get
            {
                HREmployeeEntity _HREmployeeEntity = new HREmployeeEntity();

                _HREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(OverviewEmployeeID);

                return _HREmployeeEntity;
            }
        }

        #endregion
    }
}