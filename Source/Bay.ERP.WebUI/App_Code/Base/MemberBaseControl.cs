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
    public class MemberBaseControl : BaseControl
    {
        #region Properties

        public Int64 OverviewMemberID
        {
            get
            {
                Int64 overviewMemberID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID], out overviewMemberID);
                }

                return overviewMemberID;
            }
        }

        public Int64 MemberIdentityGroupID
        {
            get
            {
                return (Int64)ViewState["MemberIdentityGroupID"];
            }
            set
            {
                ViewState["MemberIdentityGroupID"] = value;
            }
        }

        public Int64 MemberSourceCategoryID
        {
            get
            {
                return (Int64)ViewState["MemberSourceCategoryID"];
            }
            set
            {
                ViewState["MemberSourceCategoryID"] = value;
            }
        }

        #endregion
    }
}