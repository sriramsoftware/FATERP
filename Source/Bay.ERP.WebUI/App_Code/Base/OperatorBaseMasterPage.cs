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
    public class OperatorBaseMasterPage : BaseMasterPage
    {
        #region Properties

        public Int64 OverviewOperatorID
        {
            get
            {
                Int64 overviewOperatorID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_OPERATOR_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_OPERATOR_ID], out overviewOperatorID);
                }

                return overviewOperatorID;
            }
        }

        public BDOperatorEntity OverviewOperator
        {
            get
            {
                BDOperatorEntity bDOperatorEntity = new BDOperatorEntity();

                bDOperatorEntity = FCCBDOperator.GetFacadeCreate().GetByID(OverviewOperatorID);

                return bDOperatorEntity;
            }
        }

        #endregion
    }
}