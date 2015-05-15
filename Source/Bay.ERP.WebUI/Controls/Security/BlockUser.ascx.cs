using System;
using System.Data;
using System.Web.Security;
using System.Web.UI.WebControls;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;
using System.Collections.Generic;

namespace Bay.ERP.Web.UI
{

    public partial class BlockUserControl : BaseControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadUserStatus();
            }
            //if (Helper.Session.Get(SessionConstants.MASTERDATA_EXPLORER_ISPOSTBACK) != null)
            //{
            //    LoadUserStatus();
            //    Helper.Session.Set(SessionConstants.MASTERDATA_EXPLORER_ISPOSTBACK, null);
            //}
        }
        private void LoadUserStatus()
        {

            string _MemberID = "0";
            if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID]))
            {
                _MemberID = Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID];
            }
            if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID]))
            {
                _MemberID = Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID];
            }
            try
            {

                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASMemberAspnetUsersMapEntity.FLD_NAME_MemberID, _MemberID, SQLMatchType.Equal);
                DataTable dt = FCCASPNETUserNameByMemberID.GetFacadeCreate().GetDT(long.Parse(_MemberID));
                if (dt.Rows.Count > 0)
                {
                    string UserName = dt.Rows[0]["UserName"].ToString();
                    MembershipUser msUser = Membership.GetUser(UserName);
                    chkIsActiveLogin.Checked = msUser.IsApproved;
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            }
        }

        private void LoginStatus(bool Status)
        {
            string _MemberID = "0";
            if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID]))
            {
                _MemberID = Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID];
            }
            if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID]))
            {
                _MemberID = Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID];
            }
            try
            {

                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASMemberAspnetUsersMapEntity.FLD_NAME_MemberID, _MemberID, SQLMatchType.Equal);
                DataTable dt = FCCASPNETUserNameByMemberID.GetFacadeCreate().GetDT(long.Parse(_MemberID));
                if (dt.Rows.Count > 0)
                {
                    string UserName = dt.Rows[0]["UserName"].ToString();
                    MembershipUser msUser = Membership.GetUser(UserName);
                    msUser.IsApproved = Status;
                    Membership.UpdateUser(msUser);
                    if (Status == true)
                    {
                        msUser.UnlockUser();
                    }

                    MiscUtil.ShowMessage(lblMessage, "Status update sucessful.", false);
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Status update unsucessful. " + ex.Message, true);
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            LoginStatus(chkIsActiveLogin.Checked);
        }
    }
}
