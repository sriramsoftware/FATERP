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
    public class SupplierBaseControl : BaseControl
    {
        #region Properties

        public Int64 OverviewSupplierID
        {
            get
            {
                Int64 overviewSupplierID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SUPPLIER_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SUPPLIER_ID], out overviewSupplierID);
                }

                return overviewSupplierID;
            }
        }

        public PRMSupplierEntity OverviewSupplier
        {
            get
            {
                PRMSupplierEntity _PRMSupplierEntity = new PRMSupplierEntity();

                FCCPRMSupplier.GetFacadeCreate().GetByID(OverviewSupplierID);

                return _PRMSupplierEntity;
            }
        }

        #endregion
    }
}