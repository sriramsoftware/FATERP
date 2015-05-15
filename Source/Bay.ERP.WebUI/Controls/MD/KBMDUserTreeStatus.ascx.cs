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
    public partial class KBMDUserTreeStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _UserTreeStatusID
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

        public KBMDUserTreeStatusEntity _KBMDUserTreeStatusEntity
        {
            get
            {
                KBMDUserTreeStatusEntity entity = new KBMDUserTreeStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (KBMDUserTreeStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private KBMDUserTreeStatusEntity CurrentKBMDUserTreeStatusEntity
        {
            get
            {
                if (_UserTreeStatusID > 0)
                {
                    if (_KBMDUserTreeStatusEntity.UserTreeStatusID != _UserTreeStatusID)
                    {
                        _KBMDUserTreeStatusEntity = FCCKBMDUserTreeStatus.GetFacadeCreate().GetByID(_UserTreeStatusID);
                    }
                }

                return _KBMDUserTreeStatusEntity;
            }
            set
            {
                _KBMDUserTreeStatusEntity = value;
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
            KBMDUserTreeStatusEntity kBMDUserTreeStatusEntity = CurrentKBMDUserTreeStatusEntity;


            if (!kBMDUserTreeStatusEntity.IsNew)
            {
                txtName.Text = kBMDUserTreeStatusEntity.Name.ToString();
                txtRemarks.Text = kBMDUserTreeStatusEntity.Remarks.ToString();
                chkIsRemoved.Checked = kBMDUserTreeStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindKBMDUserTreeStatusList();
        }

        private void BindKBMDUserTreeStatusList()
        {
            lvKBMDUserTreeStatus.DataBind();
        }

        private KBMDUserTreeStatusEntity BuildKBMDUserTreeStatusEntity()
        {
            KBMDUserTreeStatusEntity kBMDUserTreeStatusEntity = CurrentKBMDUserTreeStatusEntity;

            kBMDUserTreeStatusEntity.Name = txtName.Text.Trim();
            kBMDUserTreeStatusEntity.Remarks = txtRemarks.Text.Trim();
            kBMDUserTreeStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return kBMDUserTreeStatusEntity;
        }

        private void SaveKBMDUserTreeStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    KBMDUserTreeStatusEntity kBMDUserTreeStatusEntity = BuildKBMDUserTreeStatusEntity();

                    Int64 result = -1;

                    if (kBMDUserTreeStatusEntity.IsNew)
                    {
                        result = FCCKBMDUserTreeStatus.GetFacadeCreate().Add(kBMDUserTreeStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(KBMDUserTreeStatusEntity.FLD_NAME_UserTreeStatusID, kBMDUserTreeStatusEntity.UserTreeStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCKBMDUserTreeStatus.GetFacadeCreate().Update(kBMDUserTreeStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _UserTreeStatusID = 0;
                        _KBMDUserTreeStatusEntity = new KBMDUserTreeStatusEntity();
                        PrepareInitialView();
                        BindKBMDUserTreeStatusList();

                        if (kBMDUserTreeStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (kBMDUserTreeStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add K BUser Tree Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update K BUser Tree Status Information.", false);
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

        protected void lvKBMDUserTreeStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 UserTreeStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out UserTreeStatusID);

            if (UserTreeStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _UserTreeStatusID = UserTreeStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBMDUserTreeStatusEntity.FLD_NAME_UserTreeStatusID, UserTreeStatusID.ToString(), SQLMatchType.Equal);

                        KBMDUserTreeStatusEntity kBMDUserTreeStatusEntity = new KBMDUserTreeStatusEntity();


                        result = FCCKBMDUserTreeStatus.GetFacadeCreate().Delete(kBMDUserTreeStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _UserTreeStatusID = 0;
                            _KBMDUserTreeStatusEntity = new KBMDUserTreeStatusEntity();
                            PrepareInitialView();
                            BindKBMDUserTreeStatusList();

                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete K BUser Tree Status.", true);
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

        protected void odsKBMDUserTreeStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveKBMDUserTreeStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _UserTreeStatusID = 0;
            _KBMDUserTreeStatusEntity = new KBMDUserTreeStatusEntity();
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
