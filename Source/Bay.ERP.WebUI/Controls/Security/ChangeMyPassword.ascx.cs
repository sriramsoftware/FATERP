// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Feb-2012, 05:48:58




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

using Bay.ERP.Web.UI.Manager;
using System.Web.Security;

namespace Bay.ERP.Web.UI
{
    public partial class ChangeMyPasswordControl : BaseControl
    {       
        #region Properties

        public Int64 SecurityMemberID
        {
            get
            {
                return this.CurrentMember.MemberID;
            }
        }        

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHRMember(ddlMemberID, false);

            if (ddlMemberID.Items.Count > 0)
            {
                ddlMemberID.SelectedValue = SecurityMemberID.ToString();
            }

            //ddlMemberID.Enabled = false;
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtOldPassword.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtReTypePassword.Text = String.Empty;
            lblPassword.Text = String.Empty;

            btnSubmit.Text = "Change";
        }
        
        private void SaveHRMemberEntity()
        {
            if (IsValid)
            {
                try
                {
                    MembershipUser user = ASSecurityManager.GetASPNETUserByMemberID(SecurityMemberID);

                    if (user != null)
                    {
                        if (ASSecurityManager.ValidateASPNETUserPassword(user.UserName, txtOldPassword.Text.Trim()) == true)
                        {
                            ASSecurityManager.ChangeASPNETUserPassword(user.UserName, txtOldPassword.Text.Trim(), txtPassword.Text.Trim());

                            MiscUtil.ShowMessage(lblMessage, "Password has been changed successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Incorrect Old password.", true);
                        }
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "User not found.", false);
                    }

                    PrepareInitialView();
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
            }
        }

        #endregion
                
        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHRMemberEntity();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
        }

        protected void btnGetPassword_Click(object sender, EventArgs e)
        {
            MembershipUser user = ASSecurityManager.GetASPNETUserByMemberID(SecurityMemberID);
            string password = user.ResetPassword();
            lblPassword.Text = password;
        }

        #endregion

        #endregion Event
    }
}
