using System;
using System.Diagnostics;
using System.Web.Security;
using System.Configuration;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using System.Web;

namespace Bay.ERP.Web.UI
{
    public class BaseMasterPage : System.Web.UI.MasterPage
    {
        #region Member Variables

        private WebHelper _helper;

        #endregion
        
        #region Properties

        protected HRMemberEntity CurrentMember
        {
            [DebuggerStepThrough()]
            get
            {
                return HttpContext.Current.Session[SessionConstants.LOGIN_MEMBER_INFO] as HRMemberEntity;
            }
        }

        protected WebHelper Helper
        {
            get
            {
                if (_helper == null)
                {
                    _helper = new WebHelper(this);
                }

                return _helper;
            }
        }

        #endregion
    }
}