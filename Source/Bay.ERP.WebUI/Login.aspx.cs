using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Web.UI.Manager;
using Bay.ERP.Web.UI.Helper;
using System.Web.Security;
using Bay.ERP.Web.UI.Notifciation;
using System.Configuration;
using System.Data.SqlClient;

namespace Bay.ERP.Web.UI
{
    public partial class LogInPage : BasePage
    {
        #region Variable

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "Public_Page";
            }
        }

        #endregion

        #region Methods

        private void SetUserIDAndPasswordFromCookies()
        {
            userLoginControl.TitleText = "";

            TextBox txtUserName = (TextBox)userLoginControl.FindControl("UserName");
            TextBox txtPassword = (TextBox)userLoginControl.FindControl("Password");

            String cookieUserName = ASSecurityManager.GetUserNameFromCookies();
            String cookiePassword = ASSecurityManager.GetPasswordFromCookies();

            if (cookieUserName.IsNotNullOrEmpty() && cookiePassword.IsNotNullOrEmpty())
            {
                txtUserName.Attributes.Add("value", cookieUserName);
                txtPassword.Attributes.Add("value", cookiePassword);
            }
        }

        #endregion

        #region Events

        #region Page Events

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SetUserIDAndPasswordFromCookies();
            }

            //Get connection string from web.config file
            string strcon = ConfigurationManager.ConnectionStrings["ETCON"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file
            SqlConnectionStringBuilder Builder = new SqlConnectionStringBuilder(strcon);
            String Database = Builder.InitialCatalog;
            lblDBName.Text = Database;
        }

        #endregion

        #region Login Control Events

        protected void userLoginControl_LoggedIn(object sender, EventArgs e)
        {
            //#region TEst

            //Session["ProjectMemeberShip"] = "";

            //#endregion

            #region Performing the user's after login setps in security manager

            ASSecurityManager.UserLogedIn(userLoginControl.UserName);

            #endregion

            #region Set Password in cookies

            CheckBox chkRemeberMe = (CheckBox)userLoginControl.FindControl("RememberMe");

            if (chkRemeberMe.Checked == true)
            {
                ASSecurityManager.SetUserNameAndPasswordToCookies(userLoginControl.UserName, userLoginControl.Password);
            }

            #endregion

            #region Notification Service 

            // Join into the recipient list.

            //Membership.

            //if (!string.IsNullOrEmpty(userLoginControl.UserName))
            //{
            //    NotificationAdapterLive.Instance.Join(userLoginControl.UserName);
            //}

            #endregion

            #region Redirect to page for the logged in user

            if (this.CurrentMember != null)
            {
                #region Role Wise Redirect

                //String[] roles = Roles.GetRolesForUser(userLoginControl.UserName);

                //if (roles.Length > 0 && roles[0].ToString() == "Applicant Portal")
                //{
                //    // i need to come back here.... might dont need to send the id
                //    Helper.Url.Redirect("~/CareerPortal/CPDefault.aspx", string.Empty, UrlConstants.OVERVIEW_MEMBER_ID, this.CurrentMember.MemberID.ToString());
                //}

                #endregion

                #region Redirect to return URL

                //if (Request.QueryString.HasKeys())
                //{
                //    String returnUrl = Request.QueryString["returnUrl"];

                //    returnUrl = returnUrl.Replace("_", "%");

                //    Helper.Url.Redirect(returnUrl);
                //}

                //Response.Redirect("~/Customer/MyAccount.aspx");

                #endregion                

                //Response.Redirect("~/Default.aspx");
            }

            #endregion
        }

        protected void lnkForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ForgotPassword.aspx");
        }

        #endregion

        #endregion
    }
}