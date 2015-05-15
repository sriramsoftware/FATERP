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
    public abstract class IssueBasePage : BasePage
    {
        #region Properties

        public Int64 OverviewIssueID
        {
            get
            {
                Int64 overviewIssueID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_ID], out overviewIssueID);
                }

                return overviewIssueID;
            }
        }

        public OTIssueEntity OverviewIssue
        {
            get
            {
                OTIssueEntity _OTIssueEntity = new OTIssueEntity();

                FCCOTIssue.GetFacadeCreate().GetByID(OverviewIssueID);

                return _OTIssueEntity;
            }
        }

        #endregion
    }
}