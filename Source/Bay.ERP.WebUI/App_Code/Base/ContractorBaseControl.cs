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
    public class ContractorBaseControl : BaseControl
    {
        #region Properties

        public Int64 OverviewContractorID
        {
            get
            {
                Int64 overviewContractorID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CONTRACTOR_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CONTRACTOR_ID], out overviewContractorID);
                }

                return overviewContractorID;
            }
        }

        public CMContractorEntity OverviewContractor
        {
            get
            {
                CMContractorEntity _CMContractorEntity = new CMContractorEntity();

                _CMContractorEntity = FCCCMContractor.GetFacadeCreate().GetByID(OverviewContractorID);

                return _CMContractorEntity;
            }
        }
        #endregion
    }
}