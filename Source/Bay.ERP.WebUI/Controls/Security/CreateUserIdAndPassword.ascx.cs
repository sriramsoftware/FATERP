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
//using System.Transactions;

using Bay.ERP.Web.UI.Helper;

using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class SecurityCreateUserIdAndPasswordControl : ASBaseControl
    {
        #region Member Variables

        private Int32 memberSource = 0;  
        private Int64 _CurrentMemberID = 0;
        private MembershipUser _MembershipUser;

        #endregion

        #region Properties

        public Int64 CurrentCompanyID { get; set; }

        private Int64 CurrentMemberID
        {
            get
            {
                // when member is for erm, cp, etc
                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID]))
                {
                    _CurrentMemberID = Int64.Parse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MEMBER_ID]);

                    memberSource = 1; // means member
                }
                // when member is for comppany,clinet, vendor
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

        private MembershipUser CurrentMembershipUser
        {
            get
            {
                return ASSecurityManager.GetASPNETUserByMemberID(CurrentMemberID);
            }
        }

        #endregion

        #region Methods

        private void PrepareInitialView()
        {
            txtUsername.Text = String.Empty;
            txtOldpassword.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtCPassword.Text = String.Empty;
            txtAddedByMemberName.Text = this.CurrentMember.FirstName + this.CurrentMember.LastName;
            txtCreateDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");

            divRoles.Visible = false;

            lblAddedBy.Text = "Added By";
            lblCreateDate.Text = "Create Date";

            btnSubmit.Text = "Add";

            txtUsername.Enabled = true;
            divOldPassword.Visible = false;

            if (!StringHelper.IsBlank(Helper.Url.SecureUrl["SendEmail"]))
            {
                if (Helper.Url.SecureUrl["SendEmail"].ToString() == "True")
                {
                    CollapsiblePanelExtender2.Collapsed = false;
                }
            }
        }

        private void PrepareEditView()
        {
            Int64 memberID = CurrentMemberID;

            if (memberID > 0)
            {
                if (CurrentMembershipUser != null)
                {
                    #region Set User Information

                    txtUsername.Text = CurrentMembershipUser.UserName;

                    // binging user's role list
                    lstRoleInfo.DataSource = Roles.GetRolesForUser(CurrentMembershipUser.UserName);
                    lstRoleInfo.DataBind();

                    
                    #endregion

                    divRoles.Visible = true;

                    lblAddedBy.Text = "Updated By";
                    lblCreateDate.Text = "Update Date";

                    btnSubmit.Text = "Update";

                    txtUsername.Enabled = false;
                    divOldPassword.Visible = true;
                }

                // find the mail for member
                PopulateUsersEmailList();
            }
        }

        private void PopulateUsersEmailList()
        {
            if (memberSource == 1) // means member
            {
                //#region Email list population for user

                //String assignToMemberEmailAddress = String.Empty;
                //String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(ERMMemberWorkLocationEntity.FLD_NAME_MemberID, this.CurrentMemberID.ToString(), SQLMatchType.Equal);
                //String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ERMMemberWorkLocationEntity.FLD_NAME_IsPrimaryOffice, "1", EPMS.Common.Shared.SQLMatchType.Equal);
                //String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);
                //IList<ERMMemberWorkLocationEntity> eRMMemberWorkLocationEntityList = FCCERMMemberWorkLocation.GetFacadeCreate().GetIL(
                //    null,
                //    null,
                //    String.Empty,
                //    filterExpression,
                //    DatabaseOperationType.LoadWithFilterExpression);

                //if (eRMMemberWorkLocationEntityList != null && eRMMemberWorkLocationEntityList.Count > 0)
                //{
                //    ListBoxItem rlbi = new ListBoxItem();

                //    if (eRMMemberWorkLocationEntityList[0].OfficeEmail.IsNotNullOrEmpty())
                //    {
                //        rlbi.Text = eRMMemberWorkLocationEntityList[0].OfficeEmail;

                //        rlbEmail.Items.Add(rlbi);
                //    }
                //}

                //if (assignToMemberEmailAddress.IsNullOrEmpty())
                //{
                //    filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(MemberAddressInformationEntity.FLD_NAME_MemberID, CurrentMemberID.ToString(), EPMS.Common.Shared.SQLMatchType.Equal);
                //    filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(MemberAddressInformationEntity.FLD_NAME_IsCurrent, "1", EPMS.Common.Shared.SQLMatchType.Equal);
                //    filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);
                //    IList<MemberAddressInformationEntity> memberAddressInformationEntityList = FCCMemberAddressInformation.GetFacadeCreate().GetIL(
                //        null,
                //        null,
                //        String.Empty,
                //        filterExpression,
                //        DatabaseOperationType.LoadWithFilterExpression);

                //    if (memberAddressInformationEntityList != null && memberAddressInformationEntityList.Count > 0)
                //    {
                //        RadListBoxItem rlbi = new RadListBoxItem();

                //        if (memberAddressInformationEntityList[0].PersonalEmail.IsNotNullOrEmpty())
                //        {
                //            rlbi.Text = memberAddressInformationEntityList[0].PersonalEmail;

                //            rlbEmail.Items.Add(rlbi);
                //        }
                //    }
                //}

                //#endregion
            }
            else if (memberSource == 2) // means company
            {
                //#region Email list population for CRM Company

                //String assignToMemberEmailAddress = String.Empty;
                //String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMemberUserMapEntity.FLD_NAME_CRMCompanyID, this.CurrentCompanyID.ToString(), SQLMatchType.Equal);

                //IList<CRMMemberUserMapEntity> cRMMemberUserMapEntityList = FCCCRMMemberUserMap.GetFacadeCreate().GetIL(
                //    null,
                //    null,
                //    String.Empty,
                //    filterExpression,
                //    DatabaseOperationType.LoadWithFilterExpression);

                //if (cRMMemberUserMapEntityList != null && cRMMemberUserMapEntityList.Count > 0)
                //{
                //    RadListBoxItem rlbi = new RadListBoxItem();

                //    if (cRMMemberUserMapEntityList[0].Email.IsNotNullOrEmpty())
                //    {
                //        rlbi.Text = cRMMemberUserMapEntityList[0].Email;

                //        rlbEmail.Items.Add(rlbi);
                //    }
                //}

                //#endregion
            }
        }

        private void SaveMemberAccount()
        {
            try
            {
                Int64 memberID = CurrentMemberID;

                if (memberID > 0)
                {
                    if (CurrentMembershipUser != null)
                    {
                        // validating old password
                        Boolean passwordValidationResult = ASSecurityManager.ValidateASPNETUserPassword(txtUsername.Text, txtOldpassword.Text);

                        if (passwordValidationResult)
                        {
                            ASSecurityManager.ChangeASPNETUserPassword(txtUsername.Text.Trim(), txtOldpassword.Text.Trim(), txtPassword.Text.Trim());

                            MiscUtil.ShowMessage(lblMessage, "Password Changed Successfully", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Incorrect Old Password.", true);
                        }
                    }
                    else
                    {
                        MembershipUser newUser = ASSecurityManager.CreateASPNETUserForMember(CurrentMemberID, txtUsername.Text.Trim(), txtPassword.Text.Trim());

                        if (newUser != null)
                        {
                            MiscUtil.ShowMessage(lblMessage, "New user created successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to create new user.", true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to create new user.", true);
            }

        }
        
        #endregion

        #region Events

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region Button Events

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMemberAccount();
        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                //foreach (ListItem radListBoxItem in rlbEmail.CheckedItems)
                //{
                //    UserIdPasswordSendEmailTemplate emailHelper = new UserIdPasswordSendEmailTemplate();

                //    emailHelper.PrepareMail(CurrentMemberID, txtUsername.Text, radListBoxItem.Text);
                //    emailHelper.Send();
                //}
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed send email.", true);
            }

            MiscUtil.ShowMessage(lblMessage, "Email sent successfully.", false);
        }

        #endregion

        #endregion        
    }
}