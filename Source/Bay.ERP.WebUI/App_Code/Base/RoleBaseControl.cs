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
    public class RoleBaseControl : BaseControl
    {
        #region Properties

        public String OverviewRole
        {
            get
            {
                String overviewRole = String.Empty;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ROLE]))
                {
                    overviewRole = Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ROLE];
                }

                return overviewRole;
            }
        }

        #endregion
    }
}