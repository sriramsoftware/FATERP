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
    public abstract class ProjectBasePage : BasePage
    {   
        #region Properties

        public Int64 OverviewProjectID
        {
            get
            {
                Int64 overviewProjectID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROJECT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROJECT_ID], out overviewProjectID);
                }

                return overviewProjectID;
            }
        }

        public BDProjectEntity OverviewProject
        {
            get
            {
                BDProjectEntity _BDProjectEntity = new BDProjectEntity();

                _BDProjectEntity = FCCBDProject.GetFacadeCreate().GetByID(OverviewProjectID);

                return _BDProjectEntity;
            }
        }

        #endregion
    }
}