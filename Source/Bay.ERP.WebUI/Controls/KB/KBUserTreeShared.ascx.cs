// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




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
    public partial class KBUserTreeSharedControl : BaseControl
    {       
        #region Properties

        public Int64 _UserTreeSharedID
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

        public KBUserTreeSharedEntity _KBUserTreeSharedEntity
        {
            get
            {
                KBUserTreeSharedEntity entity = new KBUserTreeSharedEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (KBUserTreeSharedEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private KBUserTreeSharedEntity CurrentKBUserTreeSharedEntity
        {
            get
            {
                if (_UserTreeSharedID > 0)
                {
                    if (_KBUserTreeSharedEntity.UserTreeSharedID != _UserTreeSharedID)
                    {
                        _KBUserTreeSharedEntity = FCCKBUserTreeShared.GetFacadeCreate().GetByID(_UserTreeSharedID);
                    }
                }

                return _KBUserTreeSharedEntity;
            }
            set
            {
                _KBUserTreeSharedEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateKBUserTree(ddlUserTreeID, false);
            MiscUtil.PopulateKBMDUserTreeSetting(ddlUserTreeSettingID, false);
            MiscUtil.PopulateHREmployee(ddlSharedGivenByEmployeeID, false);
            MiscUtil.PopulateHREmployee(ddlSharedGivenToEmployeeID, false);
            MiscUtil.PopulateKBMDUserTreeSharedPermission(ddlUserTreePermissionID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtMessage.Text = String.Empty;
            txtSharedDateTime.Text = String.Empty;
            txtIP.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            KBUserTreeSharedEntity kBUserTreeSharedEntity = CurrentKBUserTreeSharedEntity;


            if (!kBUserTreeSharedEntity.IsNew)
            {
                if (ddlUserTreeID.Items.Count > 0 && kBUserTreeSharedEntity.UserTreeID != null)
                {
                    ddlUserTreeID.SelectedValue = kBUserTreeSharedEntity.UserTreeID.ToString();
                }

                if (ddlUserTreeSettingID.Items.Count > 0 && kBUserTreeSharedEntity.UserTreeSettingID != null)
                {
                    ddlUserTreeSettingID.SelectedValue = kBUserTreeSharedEntity.UserTreeSettingID.ToString();
                }

                txtMessage.Text = kBUserTreeSharedEntity.Message.ToString();
                if (ddlSharedGivenByEmployeeID.Items.Count > 0 && kBUserTreeSharedEntity.SharedGivenByEmployeeID != null)
                {
                    ddlSharedGivenByEmployeeID.SelectedValue = kBUserTreeSharedEntity.SharedGivenByEmployeeID.ToString();
                }

                txtSharedDateTime.Text = kBUserTreeSharedEntity.SharedDateTime.ToStringDefault();
                if (ddlSharedGivenToEmployeeID.Items.Count > 0 && kBUserTreeSharedEntity.SharedGivenToEmployeeID != null)
                {
                    ddlSharedGivenToEmployeeID.SelectedValue = kBUserTreeSharedEntity.SharedGivenToEmployeeID.ToString();
                }

                txtIP.Text = kBUserTreeSharedEntity.IP.ToString();
                if (ddlUserTreePermissionID.Items.Count > 0 && kBUserTreeSharedEntity.UserTreePermissionID != null)
                {
                    ddlUserTreePermissionID.SelectedValue = kBUserTreeSharedEntity.UserTreePermissionID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindKBUserTreeSharedList();
        }

        private void BindKBUserTreeSharedList()
        {
            lvKBUserTreeShared.DataBind();
        }

        private KBUserTreeSharedEntity BuildKBUserTreeSharedEntity()
        {
            KBUserTreeSharedEntity kBUserTreeSharedEntity = CurrentKBUserTreeSharedEntity;

            if (ddlUserTreeID.Items.Count > 0)
            {
                if (ddlUserTreeID.SelectedValue == "0")
                {
                }
                else
                {
                    kBUserTreeSharedEntity.UserTreeID = Int64.Parse(ddlUserTreeID.SelectedValue);
                }
            }

            if (ddlUserTreeSettingID.Items.Count > 0)
            {
                if (ddlUserTreeSettingID.SelectedValue == "0")
                {
                }
                else
                {
                    kBUserTreeSharedEntity.UserTreeSettingID = Int64.Parse(ddlUserTreeSettingID.SelectedValue);
                }
            }

            kBUserTreeSharedEntity.Message = txtMessage.Text.Trim();
            if (ddlSharedGivenByEmployeeID.Items.Count > 0)
            {
                if (ddlSharedGivenByEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    kBUserTreeSharedEntity.SharedGivenByEmployeeID = Int64.Parse(ddlSharedGivenByEmployeeID.SelectedValue);
                }
            }

            if (txtSharedDateTime.Text.Trim().IsNotNullOrEmpty())
            {
                kBUserTreeSharedEntity.SharedDateTime = MiscUtil.ParseToDateTime(txtSharedDateTime.Text);
            }

            if (ddlSharedGivenToEmployeeID.Items.Count > 0)
            {
                if (ddlSharedGivenToEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    kBUserTreeSharedEntity.SharedGivenToEmployeeID = Int64.Parse(ddlSharedGivenToEmployeeID.SelectedValue);
                }
            }

            kBUserTreeSharedEntity.IP = txtIP.Text.Trim();
            if (ddlUserTreePermissionID.Items.Count > 0)
            {
                if (ddlUserTreePermissionID.SelectedValue == "0")
                {
                }
                else
                {
                    kBUserTreeSharedEntity.UserTreePermissionID = Int64.Parse(ddlUserTreePermissionID.SelectedValue);
                }
            }


            return kBUserTreeSharedEntity;
        }

        private void SaveKBUserTreeSharedEntity()
        {
            if (IsValid)
            {
                try
                {
                    KBUserTreeSharedEntity kBUserTreeSharedEntity = BuildKBUserTreeSharedEntity();

                    Int64 result = -1;

                    if (kBUserTreeSharedEntity.IsNew)
                    {
                        result = FCCKBUserTreeShared.GetFacadeCreate().Add(kBUserTreeSharedEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_UserTreeSharedID, kBUserTreeSharedEntity.UserTreeSharedID.ToString(), SQLMatchType.Equal);
                        result = FCCKBUserTreeShared.GetFacadeCreate().Update(kBUserTreeSharedEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _UserTreeSharedID = 0;
                        _KBUserTreeSharedEntity = new KBUserTreeSharedEntity();
                        PrepareInitialView();
                        BindKBUserTreeSharedList();

                        if (kBUserTreeSharedEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Shared Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Shared Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (kBUserTreeSharedEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add K BUser Tree Shared Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update K BUser Tree Shared Information.", false);
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

        protected void lvKBUserTreeShared_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 UserTreeSharedID;

            Int64.TryParse(e.CommandArgument.ToString(), out UserTreeSharedID);

            if (UserTreeSharedID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _UserTreeSharedID = UserTreeSharedID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_UserTreeSharedID, UserTreeSharedID.ToString(), SQLMatchType.Equal);

                        KBUserTreeSharedEntity kBUserTreeSharedEntity = new KBUserTreeSharedEntity();


                        result = FCCKBUserTreeShared.GetFacadeCreate().Delete(kBUserTreeSharedEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _UserTreeSharedID = 0;
                            _KBUserTreeSharedEntity = new KBUserTreeSharedEntity();
                            PrepareInitialView();
                            BindKBUserTreeSharedList();

                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Shared has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete K BUser Tree Shared.", true);
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

        protected void odsKBUserTreeShared_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveKBUserTreeSharedEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _UserTreeSharedID = 0;
            _KBUserTreeSharedEntity = new KBUserTreeSharedEntity();
            PrepareInitialView();
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
