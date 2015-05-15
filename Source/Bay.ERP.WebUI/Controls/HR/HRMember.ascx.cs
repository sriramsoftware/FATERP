// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class HRMemberControl : BaseControl
    {       
        #region Properties

        public Int64 _MemberID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public HRMemberEntity _HRMemberEntity
        {
            get
            {
                HRMemberEntity entity = new HRMemberEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HRMemberEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HRMemberEntity CurrentHRMemberEntity
        {
            get
            {
                if (_MemberID > 0)
                {
                    if (_HRMemberEntity.MemberID != _MemberID)
                    {
                        _HRMemberEntity = FCCHRMember.GetFacadeCreate().GetByID(_MemberID);
                    }
                }

                return _HRMemberEntity;
            }
            set
            {
                _HRMemberEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDMemberType(ddlMemberTypeID, false);

            ListItem addPleaseItem = new ListItem("All", "0");
            ListItem EmployeeCode = new ListItem("Employee Code", SearchDropdownConstants.HRMemberSearchType.EMPLOYEE_CODE.ToString());
            ListItem FirstName = new ListItem("First Name", SearchDropdownConstants.HRMemberSearchType.FIRST_NAME.ToString());

            ddlSearchType.Items.Add(addPleaseItem);
            ddlSearchType.Items.Add(EmployeeCode);
            ddlSearchType.Items.Add(FirstName);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtFirstName.Text = String.Empty;
            txtMiddleName.Text = String.Empty;
            txtLastName.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HRMemberEntity hRMemberEntity = CurrentHRMemberEntity;

            if (!hRMemberEntity.IsNew)
            {
                txtFirstName.Text = hRMemberEntity.FirstName.ToString();
                txtMiddleName.Text = hRMemberEntity.MiddleName.ToString();
                txtLastName.Text = hRMemberEntity.LastName.ToString();

                if (ddlMemberTypeID.Items.Count > 0 && hRMemberEntity.MemberTypeID != null)
                {
                    ddlMemberTypeID.SelectedValue = hRMemberEntity.MemberTypeID.ToString();
                }

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHRMemberList();
        }

        private void BindHRMemberList()
        {
            lvHRMember.DataBind();
        }

        private HRMemberEntity BuildHRMemberEntity()
        {
            HRMemberEntity hRMemberEntity = CurrentHRMemberEntity;

            hRMemberEntity.FirstName = txtFirstName.Text.Trim();
            hRMemberEntity.MiddleName = txtMiddleName.Text.Trim();
            hRMemberEntity.LastName = txtLastName.Text.Trim();
            if (ddlMemberTypeID.Items.Count > 0)
            {
                if (ddlMemberTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    hRMemberEntity.MemberTypeID = Int64.Parse(ddlMemberTypeID.SelectedValue);
                }
            }

            return hRMemberEntity;
        }

        private void SaveHRMemberEntity()
        {
            if (IsValid)
            {
                try
                {
                    HRMemberEntity hRMemberEntity = BuildHRMemberEntity();

                    Int64 result = -1;

                    if (hRMemberEntity.IsNew)
                    {
                        result = FCCHRMember.GetFacadeCreate().Add(hRMemberEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, hRMemberEntity.MemberID.ToString(), SQLMatchType.Equal);
                        result = FCCHRMember.GetFacadeCreate().Update(hRMemberEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MemberID = 0;
                        _HRMemberEntity = new HRMemberEntity();
                        PrepareInitialView();
                        BindHRMemberList();

                        if (hRMemberEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Member Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Member Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hRMemberEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Member Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Member Information.", false);
                        }
                    }
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

        #region List View Event

        protected void lvHRMember_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                HRMember_CustomEntity ent = (HRMember_CustomEntity)dataItem.DataItem;

                HyperLink hypAccess = (HyperLink)e.Item.FindControl("hypAccess");
                HyperLink hypRoles = (HyperLink)e.Item.FindControl("hypRoles");
                HyperLink hypChangePassword = (HyperLink)e.Item.FindControl("hypChangePassword");
                HyperLink hypBlockUser = (HyperLink)e.Item.FindControl("hypBlockUser");

                String ss = ent.UserId.ToString();

                if (ent.UserId.ToString().Equals("00000000-0000-0000-0000-000000000000"))
                {
                    hypAccess.Text = "Create Login";
                    hypRoles.Text = "";
                    hypRoles.Enabled = false;
                    hypChangePassword.Text = "";
                    hypChangePassword.Enabled = false;
                    hypBlockUser.Enabled = false;
                }
                else
                {
                    hypAccess.Text = "Manage Login";
                    hypRoles.Text = "Manage Roles";
                    hypChangePassword.Text = "Reset Password";
                    hypBlockUser.Text = "Block User";
                }

                hypAccess.NavigateUrl = UrlHelper.BuildSecureUrl("~/Admin/HRMemberLogin.aspx", string.Empty, HRMember_CustomEntity.FLD_NAME_MemberID, ent.MemberID.ToString()).ToString();
                hypRoles.NavigateUrl = UrlHelper.BuildSecureUrl("~/Admin/HRMemberRoles.aspx", string.Empty, HRMember_CustomEntity.FLD_NAME_MemberID, ent.MemberID.ToString()).ToString();
                hypChangePassword.NavigateUrl = UrlHelper.BuildSecureUrl("~/Admin/HRMemberChangePassword.aspx", string.Empty, HRMember_CustomEntity.FLD_NAME_MemberID, ent.MemberID.ToString()).ToString();
                hypBlockUser.NavigateUrl = UrlHelper.BuildSecureUrl("~/Security/ASBlockUser.aspx", string.Empty, UrlConstants.OVERVIEW_MEMBER_ID, ent.MemberID.ToString()).ToString();
                
                hypAccess.Target="_blank";
                hypRoles.Target="_blank";
                hypChangePassword.Target = "_blank";
                hypBlockUser.Target = "_blank";
            }
        }

        protected void lvHRMember_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MemberID;

            Int64.TryParse(e.CommandArgument.ToString(), out MemberID);

            if (MemberID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MemberID = MemberID;

                    PrepareEditView();

                    //cpeEditor.Collapsed = false;
                    //cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, MemberID.ToString(), SQLMatchType.Equal);

                        HRMemberEntity hRMemberEntity = new HRMemberEntity();


                        result = FCCHRMember.GetFacadeCreate().Delete(hRMemberEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MemberID = 0;
                            _HRMemberEntity = new HRMemberEntity();
                            PrepareInitialView();
                            BindHRMemberList();

                            MiscUtil.ShowMessage(lblMessage, "Member has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Member.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsHRMember_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (ViewState["fe_Search"] != null)
            {
                fe = (String)ViewState["fe_Search"];
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHRMemberEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MemberID = 0;
            _HRMemberEntity = new HRMemberEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String fe = String.Empty;

            switch (ddlSearchType.SelectedValue)
            {
                case "0":
                    fe = String.Empty;
                    break;
                case "1":
                   fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployee." + HRMember_CustomEntity.FLD_NAME_EmployeeCode, txtSearchText.Text.Trim(), SQLMatchType.LikeWithBothMath);
                   break;
                case "2":
                   fe = SqlExpressionBuilder.PrepareFilterExpression("HRMember." + HRMember_CustomEntity.FLD_NAME_FirstName, txtSearchText.Text.Trim(), SQLMatchType.LikeWithBothMath);
                   break;
            }

            ViewState["fe_Search"] = fe;

            lvHRMember.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ViewState["fe_Search"] = null;
            BindList();
        }

        #endregion

        #endregion Event
    }
}
