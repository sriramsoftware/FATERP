// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




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
    public partial class ACItemGroupAccountMapControl : BaseControl
    {       
        #region Properties

        public Int64 _ItemGroupAccountMapID
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

        public ACItemGroupAccountMapEntity _ACItemGroupAccountMapEntity
        {
            get
            {
                ACItemGroupAccountMapEntity entity = new ACItemGroupAccountMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACItemGroupAccountMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACItemGroupAccountMapEntity CurrentACItemGroupAccountMapEntity
        {
            get
            {
                if (_ItemGroupAccountMapID > 0)
                {
                    if (_ACItemGroupAccountMapEntity.ItemGroupAccountMapID != _ItemGroupAccountMapID)
                    {
                        _ACItemGroupAccountMapEntity = FCCACItemGroupAccountMap.GetFacadeCreate().GetByID(_ItemGroupAccountMapID);
                    }
                }

                return _ACItemGroupAccountMapEntity;
            }
            set
            {
                _ACItemGroupAccountMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDItemCategory(ddlItemCategoryID, false);
            MiscUtil.PopulateACDimension(ddlDimensionID, true);
            MiscUtil.PopulateACAccountByAccountGroup(ddlSalesAccountID, true);
            MiscUtil.PopulateACAccountByAccountGroup(ddlInventoryAccountID, true);
            MiscUtil.PopulateACAccountByAccountGroup(ddlCOGSAccountID, true);
            MiscUtil.PopulateACAccountByAccountGroup(ddlInventoryAdjustmentsAccountID, true);
            MiscUtil.PopulateACDepreciationMethod(ddlDepreciationMethodID, true);
            MiscUtil.PopulateACAccountByAccountGroup(ddlDepreciationAccountID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAssetType.Text = String.Empty;
            txtPurchaseDate.Text = String.Empty;
            txtPurchasePrice.Text = String.Empty;
            txtDepreciationRate.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity = CurrentACItemGroupAccountMapEntity;


            if (!aCItemGroupAccountMapEntity.IsNew)
            {
                if (ddlItemCategoryID.Items.Count > 0 && aCItemGroupAccountMapEntity.ItemCategoryID != null)
                {
                    ddlItemCategoryID.SelectedValue = aCItemGroupAccountMapEntity.ItemCategoryID.ToString();
                }

                if (ddlDimensionID.Items.Count > 0 && aCItemGroupAccountMapEntity.DimensionID != null)
                {
                    ddlDimensionID.SelectedValue = aCItemGroupAccountMapEntity.DimensionID.ToString();
                }

                if (ddlSalesAccountID.Items.Count > 0 && aCItemGroupAccountMapEntity.SalesAccountID != null)
                {
                    ddlSalesAccountID.SelectedValue = aCItemGroupAccountMapEntity.SalesAccountID.ToString();
                }

                if (ddlInventoryAccountID.Items.Count > 0 && aCItemGroupAccountMapEntity.InventoryAccountID != null)
                {
                    ddlInventoryAccountID.SelectedValue = aCItemGroupAccountMapEntity.InventoryAccountID.ToString();
                }

                if (ddlCOGSAccountID.Items.Count > 0 && aCItemGroupAccountMapEntity.COGSAccountID != null)
                {
                    ddlCOGSAccountID.SelectedValue = aCItemGroupAccountMapEntity.COGSAccountID.ToString();
                }

                if (ddlInventoryAdjustmentsAccountID.Items.Count > 0 && aCItemGroupAccountMapEntity.InventoryAdjustmentsAccountID != null)
                {
                    ddlInventoryAdjustmentsAccountID.SelectedValue = aCItemGroupAccountMapEntity.InventoryAdjustmentsAccountID.ToString();
                }

                txtAssetType.Text = aCItemGroupAccountMapEntity.AssetType.ToString();
                txtPurchaseDate.Text = aCItemGroupAccountMapEntity.PurchaseDate.ToStringDefault();
                txtPurchasePrice.Text = aCItemGroupAccountMapEntity.PurchasePrice.ToString();
                txtDepreciationRate.Text = aCItemGroupAccountMapEntity.DepreciationRate.ToString();
                if (ddlDepreciationMethodID.Items.Count > 0 && aCItemGroupAccountMapEntity.DepreciationMethodID != null)
                {
                    ddlDepreciationMethodID.SelectedValue = aCItemGroupAccountMapEntity.DepreciationMethodID.ToString();
                }

                if (ddlDepreciationAccountID.Items.Count > 0 && aCItemGroupAccountMapEntity.DepreciationAccountID != null)
                {
                    ddlDepreciationAccountID.SelectedValue = aCItemGroupAccountMapEntity.DepreciationAccountID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACItemGroupAccountMapList();
        }

        private void BindACItemGroupAccountMapList()
        {
            lvACItemGroupAccountMap.DataBind();
        }

        private ACItemGroupAccountMapEntity BuildACItemGroupAccountMapEntity()
        {
            ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity = CurrentACItemGroupAccountMapEntity;

            if (ddlItemCategoryID.Items.Count > 0)
            {
                if (ddlItemCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    aCItemGroupAccountMapEntity.ItemCategoryID = Int64.Parse(ddlItemCategoryID.SelectedValue);
                }
            }

            if (ddlDimensionID.Items.Count > 0)
            {
                if (ddlDimensionID.SelectedValue == "0")
                {
                    aCItemGroupAccountMapEntity.DimensionID = null;
                }
                else
                {
                    aCItemGroupAccountMapEntity.DimensionID = Int64.Parse(ddlDimensionID.SelectedValue);
                }
            }

            if (ddlSalesAccountID.Items.Count > 0)
            {
                if (ddlSalesAccountID.SelectedValue == "0")
                {
                    aCItemGroupAccountMapEntity.SalesAccountID = null;
                }
                else
                {
                    aCItemGroupAccountMapEntity.SalesAccountID = Int64.Parse(ddlSalesAccountID.SelectedValue);
                }
            }

            if (ddlInventoryAccountID.Items.Count > 0)
            {
                if (ddlInventoryAccountID.SelectedValue == "0")
                {
                    aCItemGroupAccountMapEntity.InventoryAccountID = null;
                }
                else
                {
                    aCItemGroupAccountMapEntity.InventoryAccountID = Int64.Parse(ddlInventoryAccountID.SelectedValue);
                }
            }

            if (ddlCOGSAccountID.Items.Count > 0)
            {
                if (ddlCOGSAccountID.SelectedValue == "0")
                {
                    aCItemGroupAccountMapEntity.COGSAccountID = null;
                }
                else
                {
                    aCItemGroupAccountMapEntity.COGSAccountID = Int64.Parse(ddlCOGSAccountID.SelectedValue);
                }
            }

            if (ddlInventoryAdjustmentsAccountID.Items.Count > 0)
            {
                if (ddlInventoryAdjustmentsAccountID.SelectedValue == "0")
                {
                    aCItemGroupAccountMapEntity.InventoryAdjustmentsAccountID = null;
                }
                else
                {
                    aCItemGroupAccountMapEntity.InventoryAdjustmentsAccountID = Int64.Parse(ddlInventoryAdjustmentsAccountID.SelectedValue);
                }
            }

            aCItemGroupAccountMapEntity.AssetType = txtAssetType.Text.Trim();
            if (txtPurchaseDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCItemGroupAccountMapEntity.PurchaseDate = MiscUtil.ParseToDateTime(txtPurchaseDate.Text);
            }
            else
            {
                aCItemGroupAccountMapEntity.PurchaseDate = null;
            }

            if (!txtPurchasePrice.Text.Trim().IsNullOrEmpty())
            {
                aCItemGroupAccountMapEntity.PurchasePrice = Decimal.Parse(txtPurchasePrice.Text.Trim());
            }
            else
            {
                aCItemGroupAccountMapEntity.PurchasePrice = null;
            }

            if (!txtDepreciationRate.Text.Trim().IsNullOrEmpty())
            {
                aCItemGroupAccountMapEntity.DepreciationRate = Decimal.Parse(txtDepreciationRate.Text.Trim());
            }
            else
            {
                aCItemGroupAccountMapEntity.DepreciationRate = null;
            }

            if (ddlDepreciationMethodID.Items.Count > 0)
            {
                if (ddlDepreciationMethodID.SelectedValue == "0")
                {
                    aCItemGroupAccountMapEntity.DepreciationMethodID = null;
                }
                else
                {
                    aCItemGroupAccountMapEntity.DepreciationMethodID = Int64.Parse(ddlDepreciationMethodID.SelectedValue);
                }
            }

            if (ddlDepreciationAccountID.Items.Count > 0)
            {
                if (ddlDepreciationAccountID.SelectedValue == "0")
                {
                    aCItemGroupAccountMapEntity.DepreciationAccountID = null;
                }
                else
                {
                    aCItemGroupAccountMapEntity.DepreciationAccountID = Int64.Parse(ddlDepreciationAccountID.SelectedValue);
                }
            }


            return aCItemGroupAccountMapEntity;
        }

        private void SaveACItemGroupAccountMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity = BuildACItemGroupAccountMapEntity();

                    Int64 result = -1;

                    if (aCItemGroupAccountMapEntity.IsNew)
                    {
                        result = FCCACItemGroupAccountMap.GetFacadeCreate().Add(aCItemGroupAccountMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACItemGroupAccountMapEntity.FLD_NAME_ItemGroupAccountMapID, aCItemGroupAccountMapEntity.ItemGroupAccountMapID.ToString(), SQLMatchType.Equal);
                        result = FCCACItemGroupAccountMap.GetFacadeCreate().Update(aCItemGroupAccountMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ItemGroupAccountMapID = 0;
                        _ACItemGroupAccountMapEntity = new ACItemGroupAccountMapEntity();
                        PrepareInitialView();
                        BindACItemGroupAccountMapList();

                        if (aCItemGroupAccountMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CItem Group Account Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CItem Group Account Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCItemGroupAccountMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CItem Group Account Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CItem Group Account Map Information.", false);
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

        protected void lvACItemGroupAccountMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ItemGroupAccountMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out ItemGroupAccountMapID);

            if (ItemGroupAccountMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ItemGroupAccountMapID = ItemGroupAccountMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACItemGroupAccountMapEntity.FLD_NAME_ItemGroupAccountMapID, ItemGroupAccountMapID.ToString(), SQLMatchType.Equal);

                        ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity = new ACItemGroupAccountMapEntity();


                        result = FCCACItemGroupAccountMap.GetFacadeCreate().Delete(aCItemGroupAccountMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ItemGroupAccountMapID = 0;
                            _ACItemGroupAccountMapEntity = new ACItemGroupAccountMapEntity();
                            PrepareInitialView();
                            BindACItemGroupAccountMapList();

                            MiscUtil.ShowMessage(lblMessage, "A CItem Group Account Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CItem Group Account Map.", true);
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

        protected void odsACItemGroupAccountMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACItemGroupAccountMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ItemGroupAccountMapID = 0;
            _ACItemGroupAccountMapEntity = new ACItemGroupAccountMapEntity();
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
