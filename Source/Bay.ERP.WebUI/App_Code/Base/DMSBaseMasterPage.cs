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
    public class DMSBaseMasterPage : BaseMasterPage
    {
        #region Properties

        public Int64 OverviewReferenceID
        {
            get
            {
                Int64 overviewReferenceID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_DMS_REFERENCE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_DMS_REFERENCE_ID], out overviewReferenceID);
                }

                return overviewReferenceID;
            }
        }

        public DMSDocumentNodeEntity OverviewDocumentNode
        {
            get
            {
                DMSDocumentNodeEntity _DMSDocumentNodeEntity = new DMSDocumentNodeEntity();

                _DMSDocumentNodeEntity = FCCDMSDocumentNode.GetFacadeCreate().GetByID(OverviewReferenceID);

                return _DMSDocumentNodeEntity;
            }
        }

        #endregion
    }
}