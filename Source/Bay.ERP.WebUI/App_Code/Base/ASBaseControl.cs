using System;
using System.Diagnostics;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Web.UI.Helper;
using System.Collections;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.Web.UI
{
    public class ASBaseControl : BaseControl
    {
        #region Member Variables
                
        #endregion 

        #region Properties    

        public String CurrentRole
        {
            get
            {
                String currentRole = String.Empty;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl["ASCurrentRole"]))
                {
                    currentRole = Helper.Url.SecureUrl["ASCurrentRole"];
                }

                return currentRole;
            }
        }

        #endregion

        #region Methods

        #endregion
    }
}