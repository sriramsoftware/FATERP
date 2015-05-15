using System;
using System.Diagnostics;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Web.UI.Helper;
using System.Collections;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Bay.ERP.Web.UI
{
    public class BaseControl : System.Web.UI.UserControl
    {
        #region Member Variables

        private WebHelper _helper;
        
        #endregion 

        #region Properties

        public String ContentHolderPageUrl { get; set; }

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
            [DebuggerStepThrough]
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

        #region Methods

        public virtual bool IsValid
        {
            get
            {
                return true;
            }
        }

        #endregion        

        #region Log Activity

        protected void LogActivity(string activity, bool recordPageUrl)
        {
            if (Request.IsAuthenticated)
            {
                // Get information about the currently logged on user
                MembershipUser currentUser = Membership.GetUser(false);
                if (currentUser != null)
                {
                    Guid userId = (Guid)currentUser.ProviderUserKey;
                    // Log the activity in the database
                    using (SqlConnection myConnection = new
                       SqlConnection(ConfigurationManager.
                       ConnectionStrings["ETCON"].ConnectionString))
                    {
                        SqlCommand myCommand = new SqlCommand();
                        myCommand.CommandText = "usp_LogUserActivity";
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myCommand.Connection = myConnection;
                        myCommand.Parameters.AddWithValue("@UserId", userId);
                        myCommand.Parameters.AddWithValue("@Activity", activity);
                        if (recordPageUrl)
                            myCommand.Parameters.AddWithValue("@PageUrl", Request.RawUrl);
                        else
                            myCommand.Parameters.AddWithValue("@PageUrl", DBNull.Value);
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                    }
                }
            }
        }

        #endregion
    }
}