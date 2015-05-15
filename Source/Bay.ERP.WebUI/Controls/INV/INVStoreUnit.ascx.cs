// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:43:44




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
    public partial class INVStoreUnitControl : BaseControl
    {       
        #region Properties

        public Int64 _StoreUnitID
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

        public INVStoreUnitEntity _INVStoreUnitEntity
        {
            get
            {
                INVStoreUnitEntity entity = new INVStoreUnitEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (INVStoreUnitEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private INVStoreUnitEntity CurrentINVStoreUnitEntity
        {
            get
            {
                if (_StoreUnitID > 0)
                {
                    if (_INVStoreUnitEntity.StoreUnitID != _StoreUnitID)
                    {
                        _INVStoreUnitEntity = FCCINVStoreUnit.GetFacadeCreate().GetByID(_StoreUnitID);
                    }
                }

                return _INVStoreUnitEntity;
            }
            set
            {
                _INVStoreUnitEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateINVStore(ddlStoreID, false);
            MiscUtil.PopulateMDInventoryStoreUnitType(ddlInventoryStoreUnitTypeID, false);
            MiscUtil.PopulateINVStoreUnit(ddlParentStoreUnitID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtUnitTrackNumber.Text = String.Empty;
            txtLocation.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtCreateDate.Text = String.Empty;
            chkIsRemoved.Checked = false;
            chkIsDefault.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            INVStoreUnitEntity iNVStoreUnitEntity = CurrentINVStoreUnitEntity;


            if (!iNVStoreUnitEntity.IsNew)
            {
                if (ddlStoreID.Items.Count > 0 && iNVStoreUnitEntity.StoreID != null)
                {
                    ddlStoreID.SelectedValue = iNVStoreUnitEntity.StoreID.ToString();
                }

                if (ddlInventoryStoreUnitTypeID.Items.Count > 0 && iNVStoreUnitEntity.InventoryStoreUnitTypeID != null)
                {
                    ddlInventoryStoreUnitTypeID.SelectedValue = iNVStoreUnitEntity.InventoryStoreUnitTypeID.ToString();
                }

                txtUnitTrackNumber.Text = iNVStoreUnitEntity.UnitTrackNumber.ToString();
                txtLocation.Text = iNVStoreUnitEntity.Location.ToString();
                txtDescription.Text = iNVStoreUnitEntity.Description.ToString();
                txtCreateDate.Text = iNVStoreUnitEntity.CreateDate.ToStringDefault();
                chkIsRemoved.Checked = iNVStoreUnitEntity.IsRemoved;
                if (ddlParentStoreUnitID.Items.Count > 0 && iNVStoreUnitEntity.ParentStoreUnitID != null)
                {
                    ddlParentStoreUnitID.SelectedValue = iNVStoreUnitEntity.ParentStoreUnitID.ToString();
                }

                chkIsDefault.Checked = iNVStoreUnitEntity.IsDefault;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindINVStoreUnitList();
        }

        private void BindINVStoreUnitList()
        {
            lvINVStoreUnit.DataBind();
        }

        private INVStoreUnitEntity BuildINVStoreUnitEntity()
        {
            INVStoreUnitEntity iNVStoreUnitEntity = CurrentINVStoreUnitEntity;

            if (ddlStoreID.Items.Count > 0)
            {
                if (ddlStoreID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVStoreUnitEntity.StoreID = Int64.Parse(ddlStoreID.SelectedValue);
                }
            }

            if (ddlInventoryStoreUnitTypeID.Items.Count > 0)
            {
                if (ddlInventoryStoreUnitTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVStoreUnitEntity.InventoryStoreUnitTypeID = Int64.Parse(ddlInventoryStoreUnitTypeID.SelectedValue);
                }
            }

            iNVStoreUnitEntity.UnitTrackNumber = txtUnitTrackNumber.Text.Trim();
            iNVStoreUnitEntity.Location = txtLocation.Text.Trim();
            iNVStoreUnitEntity.Description = txtDescription.Text.Trim();
            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                iNVStoreUnitEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }

            iNVStoreUnitEntity.IsRemoved = chkIsRemoved.Checked;

            if (ddlParentStoreUnitID.Items.Count > 0)
            {
                if (ddlParentStoreUnitID.SelectedValue == "0")
                {
                    iNVStoreUnitEntity.ParentStoreUnitID = null;
                }
                else
                {
                    iNVStoreUnitEntity.ParentStoreUnitID = Int64.Parse(ddlParentStoreUnitID.SelectedValue);
                }
            }

            iNVStoreUnitEntity.IsDefault = chkIsDefault.Checked;


            return iNVStoreUnitEntity;
        }

        private void SaveINVStoreUnitEntity()
        {
            if (IsValid)
            {
                try
                {
                    INVStoreUnitEntity iNVStoreUnitEntity = BuildINVStoreUnitEntity();

                    Int64 result = -1;

                    if (iNVStoreUnitEntity.IsNew)
                    {
                        result = FCCINVStoreUnit.GetFacadeCreate().Add(iNVStoreUnitEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_StoreUnitID, iNVStoreUnitEntity.StoreUnitID.ToString(), SQLMatchType.Equal);
                        result = FCCINVStoreUnit.GetFacadeCreate().Update(iNVStoreUnitEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _StoreUnitID = 0;
                        _INVStoreUnitEntity = new INVStoreUnitEntity();
                        PrepareInitialView();
                        BindINVStoreUnitList();

                        if (iNVStoreUnitEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "I NVStore Unit Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "I NVStore Unit Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (iNVStoreUnitEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add I NVStore Unit Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update I NVStore Unit Information.", false);
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

        protected void lvINVStoreUnit_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 StoreUnitID;

            Int64.TryParse(e.CommandArgument.ToString(), out StoreUnitID);

            if (StoreUnitID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _StoreUnitID = StoreUnitID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_StoreUnitID, StoreUnitID.ToString(), SQLMatchType.Equal);

                        INVStoreUnitEntity iNVStoreUnitEntity = new INVStoreUnitEntity();


                        result = FCCINVStoreUnit.GetFacadeCreate().Delete(iNVStoreUnitEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _StoreUnitID = 0;
                            _INVStoreUnitEntity = new INVStoreUnitEntity();
                            PrepareInitialView();
                            BindINVStoreUnitList();

                            MiscUtil.ShowMessage(lblMessage, "I NVStore Unit has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete I NVStore Unit.", true);
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

        protected void odsINVStoreUnit_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveINVStoreUnitEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _StoreUnitID = 0;
            _INVStoreUnitEntity = new INVStoreUnitEntity();
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
