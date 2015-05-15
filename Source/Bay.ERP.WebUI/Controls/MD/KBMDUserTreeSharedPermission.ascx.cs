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
    public partial class KBMDUserTreeSharedPermissionControl : BaseControl
    {       
        #region Properties

        public Int64 _UserTreeSharedPermissionID
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

        public KBMDUserTreeSharedPermissionEntity _KBMDUserTreeSharedPermissionEntity
        {
            get
            {
                KBMDUserTreeSharedPermissionEntity entity = new KBMDUserTreeSharedPermissionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (KBMDUserTreeSharedPermissionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private KBMDUserTreeSharedPermissionEntity CurrentKBMDUserTreeSharedPermissionEntity
        {
            get
            {
                if (_UserTreeSharedPermissionID > 0)
                {
                    if (_KBMDUserTreeSharedPermissionEntity.UserTreeSharedPermissionID != _UserTreeSharedPermissionID)
                    {
                        _KBMDUserTreeSharedPermissionEntity = FCCKBMDUserTreeSharedPermission.GetFacadeCreate().GetByID(_UserTreeSharedPermissionID);
                    }
                }

                return _KBMDUserTreeSharedPermissionEntity;
            }
            set
            {
                _KBMDUserTreeSharedPermissionEntity = value;
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
            KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity = CurrentKBMDUserTreeSharedPermissionEntity;


            if (!kBMDUserTreeSharedPermissionEntity.IsNew)
            {
                txtName.Text = kBMDUserTreeSharedPermissionEntity.Name.ToString();
                txtRemarks.Text = kBMDUserTreeSharedPermissionEntity.Remarks.ToString();
                chkIsRemoved.Checked = kBMDUserTreeSharedPermissionEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindKBMDUserTreeSharedPermissionList();
        }

        private void BindKBMDUserTreeSharedPermissionList()
        {
            lvKBMDUserTreeSharedPermission.DataBind();
        }

        private KBMDUserTreeSharedPermissionEntity BuildKBMDUserTreeSharedPermissionEntity()
        {
            KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity = CurrentKBMDUserTreeSharedPermissionEntity;

            kBMDUserTreeSharedPermissionEntity.Name = txtName.Text.Trim();
            kBMDUserTreeSharedPermissionEntity.Remarks = txtRemarks.Text.Trim();
            kBMDUserTreeSharedPermissionEntity.IsRemoved = chkIsRemoved.Checked;


            return kBMDUserTreeSharedPermissionEntity;
        }

        private void SaveKBMDUserTreeSharedPermissionEntity()
        {
            if (IsValid)
            {
                try
                {
                    KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity = BuildKBMDUserTreeSharedPermissionEntity();

                    Int64 result = -1;

                    if (kBMDUserTreeSharedPermissionEntity.IsNew)
                    {
                        result = FCCKBMDUserTreeSharedPermission.GetFacadeCreate().Add(kBMDUserTreeSharedPermissionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(KBMDUserTreeSharedPermissionEntity.FLD_NAME_UserTreeSharedPermissionID, kBMDUserTreeSharedPermissionEntity.UserTreeSharedPermissionID.ToString(), SQLMatchType.Equal);
                        result = FCCKBMDUserTreeSharedPermission.GetFacadeCreate().Update(kBMDUserTreeSharedPermissionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _UserTreeSharedPermissionID = 0;
                        _KBMDUserTreeSharedPermissionEntity = new KBMDUserTreeSharedPermissionEntity();
                        PrepareInitialView();
                        BindKBMDUserTreeSharedPermissionList();

                        if (kBMDUserTreeSharedPermissionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Shared Permission Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Shared Permission Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (kBMDUserTreeSharedPermissionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add K BUser Tree Shared Permission Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update K BUser Tree Shared Permission Information.", false);
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

        protected void lvKBMDUserTreeSharedPermission_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 UserTreeSharedPermissionID;

            Int64.TryParse(e.CommandArgument.ToString(), out UserTreeSharedPermissionID);

            if (UserTreeSharedPermissionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _UserTreeSharedPermissionID = UserTreeSharedPermissionID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBMDUserTreeSharedPermissionEntity.FLD_NAME_UserTreeSharedPermissionID, UserTreeSharedPermissionID.ToString(), SQLMatchType.Equal);

                        KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity = new KBMDUserTreeSharedPermissionEntity();


                        result = FCCKBMDUserTreeSharedPermission.GetFacadeCreate().Delete(kBMDUserTreeSharedPermissionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _UserTreeSharedPermissionID = 0;
                            _KBMDUserTreeSharedPermissionEntity = new KBMDUserTreeSharedPermissionEntity();
                            PrepareInitialView();
                            BindKBMDUserTreeSharedPermissionList();

                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Shared Permission has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete K BUser Tree Shared Permission.", true);
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

        protected void odsKBMDUserTreeSharedPermission_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveKBMDUserTreeSharedPermissionEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _UserTreeSharedPermissionID = 0;
            _KBMDUserTreeSharedPermissionEntity = new KBMDUserTreeSharedPermissionEntity();
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
