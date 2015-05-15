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
    public abstract class ConsultantBasePage : BasePage
    {
        #region Properties

        public Int64 OverviewConsultantID
        {
            get
            {
                Int64 overviewConsultantID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CONSULTANT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CONSULTANT_ID], out overviewConsultantID);
                }

                return overviewConsultantID;
            }
        }

        public CMConsultantEntity OverviewConsultant
        {
            get
            {
                CMConsultantEntity _CMConsultantEntity = new CMConsultantEntity();

                _CMConsultantEntity = FCCCMConsultant.GetFacadeCreate().GetByID(OverviewConsultantID);

                return _CMConsultantEntity;
            }
        }
        #endregion
    }
}