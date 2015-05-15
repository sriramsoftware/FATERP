using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using System.Web.Compilation;

using Bay.ERP.Web.UI;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using System.Collections.Generic;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class Controls_Security_AssignRoleToUser : BaseControl
    {
        #region Member Variables
                
        private Int64 _CurrentMemberID = 0;
        private MembershipUser _MembershipUser;

        #endregion

        #region Properties

        public Int32 memberSource
        {
            get 
            {
                Int32 _memberSource = 0;

                Int32.TryParse(ViewState["memberSource"].ToString(), out  _memberSource);

                return _memberSource;
            }
            set
            {
                ViewState["memberSource"] = value;
            }
        }

        public Int64 CurrentCompanyID
        {
            get
            {
                Int32 _CurrentCompanyID = 0;

                Int32.TryParse(ViewState["CurrentCompanyID"].ToString(), out  _CurrentCompanyID);

                return _CurrentCompanyID;
            }
            set
            {
                ViewState["CurrentCompanyID"] = value;
            }
        }

        private Int64 CurrentMemberID
        {
            get
            {
                // when member is for erm, cp, etc
                //if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID]))
                //{
                //    _CurrentMemberID = Int64.Parse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID]);

                //    memberSource = 1; // means member
                //}
                //// when member is for comppany,clinet, vendor
                //else if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CRM_COMPANY_ID]))
                //{
                //    CurrentCompanyID = Int64.Parse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CRM_COMPANY_ID]);

                //    String filterExpressionCompany = SqlExpressionBuilder.PrepareFilterExpression(CRMMemberUserMapEntity.FLD_NAME_CRMCompanyID, CurrentCompanyID.ToString(), SQLMatchType.Equal);

                //    IList<CRMMemberUserMapEntity> cRMMemberUserMapEntityList = FCCCRMMemberUserMap.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpressionCompany, DatabaseOperationType.LoadWithFilterExpression);

                //    if (cRMMemberUserMapEntityList != null && cRMMemberUserMapEntityList.Count > 0)
                //    {
                //        _CurrentMemberID = cRMMemberUserMapEntityList[0].MemberID;
                //    }

                //    memberSource = 2; // means company
                //}

                return _CurrentMemberID;
            }
        }

        #endregion

        #region Methods
        
        private void LoadAllRoles()
        {
           // string[] UserRoles = ASSecurityManager.GetRolesForAssignToUserByMemberID(this.CurrentMember.MemberID);
            //ddlRolename.DataSource = UserRoles;
         //   ddlRolename.DataBind();
            ddlRolename.Items.Insert(0, new ListItem("Select Role"));
        }


        protected void PrepareInitialView()
        {

            LoadAllRoles();

            try
            {
                txtUsername.Text = ASSecurityManager.GetASPNETUserByMemberID(CurrentMemberID).UserName;
            }
            catch (Exception ex)
            { }

            try
            {
                 ddlRolename.SelectedValue = ASSecurityManager.GetRolesByMemberID(CurrentMemberID)[0];
            }
            catch (Exception ex)
            { }

            txtUsername.Enabled = false;
            btnSubmit.Text = "Update"; 
        }

        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareInitialView();
            }
        }

        protected void SetRoleToUSer()
        {
            try
            {
                if (txtUsername.Text.IsNotNullOrEmpty())
                {
                    String user = txtUsername.Text.Trim();

                    if (ddlRolename.SelectedItem.Text != "Select Role")
                    {
                        String role = ddlRolename.SelectedItem.Text;

                        ASSecurityManager.GetASPNETUserByUserName(user);

                        String[] users = new String[1];

                        users[0] = user;

                        #region Remove Previous Roles

                        String[] userRoles = Roles.GetRolesForUser(user);

                        foreach (String userRole in userRoles)
                        {
                            Roles.RemoveUserFromRole(user, userRole);
                        }

                        #endregion

                        Roles.AddUsersToRole(users, role);
                    }

                    MiscUtil.ShowMessage(lblMessage, "Role Assigne to " + user + " successfully.", false);
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SetRoleToUSer();
        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (memberSource == 1) // means member
            {
                Helper.Url.Redirect("~/ERM/ERMUserAccesWizard.aspx", String.Empty, UrlConstants.OVERVIEW_MEMBER_ID, CurrentMemberID.ToString(), "SendEmail", "True");
            }
            else if(memberSource == 2) // means company
            {
               // Helper.Url.Redirect("~/CRM/CRMUserAccesWizard.aspx", String.Empty, UrlConstants.OVERVIEW_CRM_COMPANY_ID, CurrentCompanyID.ToString(), "SendEmail", "True");
            }
        }
    }
}