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
    public partial class KBMDUserTreeSettingControl : BaseControl
    {       
        #region Properties

        public Int64 _UserTreeSettingID
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

        public KBMDUserTreeSettingEntity _KBMDUserTreeSettingEntity
        {
            get
            {
                KBMDUserTreeSettingEntity entity = new KBMDUserTreeSettingEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (KBMDUserTreeSettingEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private KBMDUserTreeSettingEntity CurrentKBMDUserTreeSettingEntity
        {
            get
            {
                if (_UserTreeSettingID > 0)
                {
                    if (_KBMDUserTreeSettingEntity.UserTreeSettingID != _UserTreeSettingID)
                    {
                        _KBMDUserTreeSettingEntity = FCCKBMDUserTreeSetting.GetFacadeCreate().GetByID(_UserTreeSettingID);
                    }
                }

                return _KBMDUserTreeSettingEntity;
            }
            set
            {
                _KBMDUserTreeSettingEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            KBMDUserTreeSettingEntity kBMDUserTreeSettingEntity = CurrentKBMDUserTreeSettingEntity;


            if (!kBMDUserTreeSettingEntity.IsNew)
            {
                txtName.Text = kBMDUserTreeSettingEntity.Name.ToString();
                txtRemarks.Text = kBMDUserTreeSettingEntity.Remarks.ToString();
                chkIsRemoved.Checked = kBMDUserTreeSettingEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindKBMDUserTreeSettingList();
        }

        private void BindKBMDUserTreeSettingList()
        {
            lvKBMDUserTreeSetting.DataBind();
        }

        private KBMDUserTreeSettingEntity BuildKBMDUserTreeSettingEntity()
        {
            KBMDUserTreeSettingEntity kBMDUserTreeSettingEntity = CurrentKBMDUserTreeSettingEntity;

            kBMDUserTreeSettingEntity.Name = txtName.Text.Trim();
            kBMDUserTreeSettingEntity.Remarks = txtRemarks.Text.Trim();
            kBMDUserTreeSettingEntity.IsRemoved = chkIsRemoved.Checked;


            return kBMDUserTreeSettingEntity;
        }

        private void SaveKBMDUserTreeSettingEntity()
        {
            if (IsValid)
            {
                try
                {
                    KBMDUserTreeSettingEntity kBMDUserTreeSettingEntity = BuildKBMDUserTreeSettingEntity();

                    Int64 result = -1;

                    if (kBMDUserTreeSettingEntity.IsNew)
                    {
                        result = FCCKBMDUserTreeSetting.GetFacadeCreate().Add(kBMDUserTreeSettingEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(KBMDUserTreeSettingEntity.FLD_NAME_UserTreeSettingID, kBMDUserTreeSettingEntity.UserTreeSettingID.ToString(), SQLMatchType.Equal);
                        result = FCCKBMDUserTreeSetting.GetFacadeCreate().Update(kBMDUserTreeSettingEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _UserTreeSettingID = 0;
                        _KBMDUserTreeSettingEntity = new KBMDUserTreeSettingEntity();
                        PrepareInitialView();
                        BindKBMDUserTreeSettingList();

                        if (kBMDUserTreeSettingEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Setting Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Setting Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (kBMDUserTreeSettingEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add K BUser Tree Setting Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update K BUser Tree Setting Information.", false);
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

        protected void lvKBMDUserTreeSetting_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 UserTreeSettingID;

            Int64.TryParse(e.CommandArgument.ToString(), out UserTreeSettingID);

            if (UserTreeSettingID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _UserTreeSettingID = UserTreeSettingID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBMDUserTreeSettingEntity.FLD_NAME_UserTreeSettingID, UserTreeSettingID.ToString(), SQLMatchType.Equal);

                        KBMDUserTreeSettingEntity kBMDUserTreeSettingEntity = new KBMDUserTreeSettingEntity();


                        result = FCCKBMDUserTreeSetting.GetFacadeCreate().Delete(kBMDUserTreeSettingEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _UserTreeSettingID = 0;
                            _KBMDUserTreeSettingEntity = new KBMDUserTreeSettingEntity();
                            PrepareInitialView();
                            BindKBMDUserTreeSettingList();

                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Setting has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete K BUser Tree Setting.", true);
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

        protected void odsKBMDUserTreeSetting_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveKBMDUserTreeSettingEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _UserTreeSettingID = 0;
            _KBMDUserTreeSettingEntity = new KBMDUserTreeSettingEntity();
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
