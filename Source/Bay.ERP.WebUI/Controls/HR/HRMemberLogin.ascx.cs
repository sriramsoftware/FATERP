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
    public partial class HRMemberLoginControl : BaseControl
    {       
        #region Properties

        public Int64 SecurityMemberID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }
                else
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[HRMember_CustomEntity.FLD_NAME_MemberID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[HRMember_CustomEntity.FLD_NAME_MemberID], out id);
                        SecurityMemberID = id;
                    } 
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
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

            ddlMemberID.Enabled = false;
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtUserID.Text = String.Empty;
            txtEmailAddress.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtReTypePassword.Text = String.Empty;
            chkIsUserLocked.Checked = false;
            
            btnSubmit.Text = "Add";
        }

        private void PrepareEditView()
        {
            MembershipUser user = ASSecurityManager.GetASPNETUserByMemberID(SecurityMemberID);

            if (user != null)
            {
                txtUserID.Text = user.UserName;
                txtUserID.ReadOnly = true;
                txtEmailAddress.Text = user.Email;
                divPassword.Visible = false;
                divReTypePassword.Visible = false;
                chkIsUserLocked.Checked = user.IsLockedOut;

                btnSubmit.Text = "Update";                
            }
        }

        private Boolean ValidateUserInput()
        {
            Boolean isInputValid = true;

            MembershipUser user = ASSecurityManager.GetASPNETUserByMemberID(SecurityMemberID);

            if (user == null)
            {

                if (ASSecurityManager.IsUserNameAvailable(txtUserID.Text.Trim()) == false)
                {
                    isInputValid = false;

                    MiscUtil.ShowMessage(lblMessage, "User ID is not available, Please choose another.", true);
                }
            }

            return isInputValid;
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
                        user.Email = txtEmailAddress.Text.ToString();

                        if (chkIsUserLocked.Checked == true)
                        {
                            user.IsApproved = false;
                            Membership.UpdateUser(user);
                        }
                        else
                        {  
                            user.UnlockUser();
                            user.IsApproved = true;
                            Membership.UpdateUser(user);
                        }

                        

                        MiscUtil.ShowMessage(lblMessage, "Email address has been updated successfully.", false);
                    }
                    else
                    {
                        user = ASSecurityManager.CreateASPNETUserForMember(SecurityMemberID, txtUserID.Text.Trim(), txtPassword.Text.Trim(), txtEmailAddress.Text.Trim());

                        if (chkIsUserLocked.Checked == true)
                        {
                            user.IsApproved = false;
                            Membership.UpdateUser(user);
                        }

                        MiscUtil.ShowMessage(lblMessage, "Login Information has been created successfully.", false);
                    }

                    PrepareInitialView();
                    PrepareEditView();
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
                PrepareEditView();
            }
        }

        #endregion
                
        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput() == true)
            {
                SaveHRMemberEntity();
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #endregion Event
    }
}
