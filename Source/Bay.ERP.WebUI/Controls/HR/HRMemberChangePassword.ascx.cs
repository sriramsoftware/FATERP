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
    public partial class HRMemberChangePasswordControl : BaseControl
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

            btnSubmit.Text = "Change User Password";
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
                        //user.
                        lblNewPassword.Text = user.ResetPassword();

                        MiscUtil.ShowMessage(lblMessage, "Password has been changed successfully.", false);
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

        #endregion

        #endregion Event
    }
}
