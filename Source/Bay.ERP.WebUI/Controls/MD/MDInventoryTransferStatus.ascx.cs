// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 01:46:09




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
    public partial class MDInventoryTransferStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _InventoryTransferStatusID
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

        public MDInventoryTransferStatusEntity _MDInventoryTransferStatusEntity
        {
            get
            {
                MDInventoryTransferStatusEntity entity = new MDInventoryTransferStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDInventoryTransferStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDInventoryTransferStatusEntity CurrentMDInventoryTransferStatusEntity
        {
            get
            {
                if (_InventoryTransferStatusID > 0)
                {
                    if (_MDInventoryTransferStatusEntity.InventoryTransferStatusID != _InventoryTransferStatusID)
                    {
                        _MDInventoryTransferStatusEntity = FCCMDInventoryTransferStatus.GetFacadeCreate().GetByID(_InventoryTransferStatusID);
                    }
                }

                return _MDInventoryTransferStatusEntity;
            }
            set
            {
                _MDInventoryTransferStatusEntity = value;
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
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDInventoryTransferStatusEntity mDInventoryTransferStatusEntity = CurrentMDInventoryTransferStatusEntity;


            if (!mDInventoryTransferStatusEntity.IsNew)
            {
                txtName.Text = mDInventoryTransferStatusEntity.Name.ToString();
                txtDescription.Text = mDInventoryTransferStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDInventoryTransferStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDInventoryTransferStatusList();
        }

        private void BindMDInventoryTransferStatusList()
        {
            lvMDInventoryTransferStatus.DataBind();
        }

        private MDInventoryTransferStatusEntity BuildMDInventoryTransferStatusEntity()
        {
            MDInventoryTransferStatusEntity mDInventoryTransferStatusEntity = CurrentMDInventoryTransferStatusEntity;

            mDInventoryTransferStatusEntity.Name = txtName.Text.Trim();
            mDInventoryTransferStatusEntity.Description = txtDescription.Text.Trim();
            mDInventoryTransferStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDInventoryTransferStatusEntity;
        }

        private void SaveMDInventoryTransferStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDInventoryTransferStatusEntity mDInventoryTransferStatusEntity = BuildMDInventoryTransferStatusEntity();

                    Int64 result = -1;

                    if (mDInventoryTransferStatusEntity.IsNew)
                    {
                        result = FCCMDInventoryTransferStatus.GetFacadeCreate().Add(mDInventoryTransferStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDInventoryTransferStatusEntity.FLD_NAME_InventoryTransferStatusID, mDInventoryTransferStatusEntity.InventoryTransferStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDInventoryTransferStatus.GetFacadeCreate().Update(mDInventoryTransferStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _InventoryTransferStatusID = 0;
                        _MDInventoryTransferStatusEntity = new MDInventoryTransferStatusEntity();
                        PrepareInitialView();
                        BindMDInventoryTransferStatusList();

                        if (mDInventoryTransferStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Inventory Transfer Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Inventory Transfer Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDInventoryTransferStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Inventory Transfer Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Inventory Transfer Status Information.", false);
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

        protected void lvMDInventoryTransferStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 InventoryTransferStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out InventoryTransferStatusID);

            if (InventoryTransferStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _InventoryTransferStatusID = InventoryTransferStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDInventoryTransferStatusEntity.FLD_NAME_InventoryTransferStatusID, InventoryTransferStatusID.ToString(), SQLMatchType.Equal);

                        MDInventoryTransferStatusEntity mDInventoryTransferStatusEntity = new MDInventoryTransferStatusEntity();


                        result = FCCMDInventoryTransferStatus.GetFacadeCreate().Delete(mDInventoryTransferStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _InventoryTransferStatusID = 0;
                            _MDInventoryTransferStatusEntity = new MDInventoryTransferStatusEntity();
                            PrepareInitialView();
                            BindMDInventoryTransferStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Inventory Transfer Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Inventory Transfer Status.", true);
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

        protected void odsMDInventoryTransferStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDInventoryTransferStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _InventoryTransferStatusID = 0;
            _MDInventoryTransferStatusEntity = new MDInventoryTransferStatusEntity();
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
