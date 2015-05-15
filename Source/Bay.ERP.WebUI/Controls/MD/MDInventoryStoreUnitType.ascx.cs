// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:18:05




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
    public partial class MDInventoryStoreUnitTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _InventoryStoreUnitTypeID
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

        public MDInventoryStoreUnitTypeEntity _MDInventoryStoreUnitTypeEntity
        {
            get
            {
                MDInventoryStoreUnitTypeEntity entity = new MDInventoryStoreUnitTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDInventoryStoreUnitTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDInventoryStoreUnitTypeEntity CurrentMDInventoryStoreUnitTypeEntity
        {
            get
            {
                if (_InventoryStoreUnitTypeID > 0)
                {
                    if (_MDInventoryStoreUnitTypeEntity.InventoryStoreUnitTypeID != _InventoryStoreUnitTypeID)
                    {
                        _MDInventoryStoreUnitTypeEntity = FCCMDInventoryStoreUnitType.GetFacadeCreate().GetByID(_InventoryStoreUnitTypeID);
                    }
                }

                return _MDInventoryStoreUnitTypeEntity;
            }
            set
            {
                _MDInventoryStoreUnitTypeEntity = value;
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
            txtIconPath.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity = CurrentMDInventoryStoreUnitTypeEntity;


            if (!mDInventoryStoreUnitTypeEntity.IsNew)
            {
                txtName.Text = mDInventoryStoreUnitTypeEntity.Name.ToString();
                txtDescription.Text = mDInventoryStoreUnitTypeEntity.Description.ToString();
                txtIconPath.Text = mDInventoryStoreUnitTypeEntity.IconPath.ToString();
                chkIsRemoved.Checked = mDInventoryStoreUnitTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDInventoryStoreUnitTypeList();
        }

        private void BindMDInventoryStoreUnitTypeList()
        {
            lvMDInventoryStoreUnitType.DataBind();
        }

        private MDInventoryStoreUnitTypeEntity BuildMDInventoryStoreUnitTypeEntity()
        {
            MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity = CurrentMDInventoryStoreUnitTypeEntity;

            mDInventoryStoreUnitTypeEntity.Name = txtName.Text.Trim();
            mDInventoryStoreUnitTypeEntity.Description = txtDescription.Text.Trim();
            mDInventoryStoreUnitTypeEntity.IconPath = txtIconPath.Text.Trim();
            mDInventoryStoreUnitTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDInventoryStoreUnitTypeEntity;
        }

        private void SaveMDInventoryStoreUnitTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity = BuildMDInventoryStoreUnitTypeEntity();

                    Int64 result = -1;

                    if (mDInventoryStoreUnitTypeEntity.IsNew)
                    {
                        result = FCCMDInventoryStoreUnitType.GetFacadeCreate().Add(mDInventoryStoreUnitTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDInventoryStoreUnitTypeEntity.FLD_NAME_InventoryStoreUnitTypeID, mDInventoryStoreUnitTypeEntity.InventoryStoreUnitTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDInventoryStoreUnitType.GetFacadeCreate().Update(mDInventoryStoreUnitTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _InventoryStoreUnitTypeID = 0;
                        _MDInventoryStoreUnitTypeEntity = new MDInventoryStoreUnitTypeEntity();
                        PrepareInitialView();
                        BindMDInventoryStoreUnitTypeList();

                        if (mDInventoryStoreUnitTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Inventory Store Unit Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Inventory Store Unit Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDInventoryStoreUnitTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Inventory Store Unit Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Inventory Store Unit Type Information.", false);
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

        protected void lvMDInventoryStoreUnitType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 InventoryStoreUnitTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out InventoryStoreUnitTypeID);

            if (InventoryStoreUnitTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _InventoryStoreUnitTypeID = InventoryStoreUnitTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDInventoryStoreUnitTypeEntity.FLD_NAME_InventoryStoreUnitTypeID, InventoryStoreUnitTypeID.ToString(), SQLMatchType.Equal);

                        MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity = new MDInventoryStoreUnitTypeEntity();


                        result = FCCMDInventoryStoreUnitType.GetFacadeCreate().Delete(mDInventoryStoreUnitTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _InventoryStoreUnitTypeID = 0;
                            _MDInventoryStoreUnitTypeEntity = new MDInventoryStoreUnitTypeEntity();
                            PrepareInitialView();
                            BindMDInventoryStoreUnitTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Inventory Store Unit Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Inventory Store Unit Type.", true);
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

        protected void odsMDInventoryStoreUnitType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDInventoryStoreUnitTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _InventoryStoreUnitTypeID = 0;
            _MDInventoryStoreUnitTypeEntity = new MDInventoryStoreUnitTypeEntity();
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
