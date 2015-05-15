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
    public partial class ACItemAccountMapControl : BaseControl
    {       
        #region Properties

        public Int64 _ItemAccountMapID
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

        public ACItemAccountMapEntity _ACItemAccountMapEntity
        {
            get
            {
                ACItemAccountMapEntity entity = new ACItemAccountMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACItemAccountMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACItemAccountMapEntity CurrentACItemAccountMapEntity
        {
            get
            {
                if (_ItemAccountMapID > 0)
                {
                    if (_ACItemAccountMapEntity.ItemAccountMapID != _ItemAccountMapID)
                    {
                        _ACItemAccountMapEntity = FCCACItemAccountMap.GetFacadeCreate().GetByID(_ItemAccountMapID);
                    }
                }

                return _ACItemAccountMapEntity;
            }
            set
            {
                _ACItemAccountMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDItem(ddlItemID, false);
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
            ACItemAccountMapEntity aCItemAccountMapEntity = CurrentACItemAccountMapEntity;


            if (!aCItemAccountMapEntity.IsNew)
            {
                if (ddlItemID.Items.Count > 0 && aCItemAccountMapEntity.ItemID != null)
                {
                    ddlItemID.SelectedValue = aCItemAccountMapEntity.ItemID.ToString();
                }

                if (ddlDimensionID.Items.Count > 0 && aCItemAccountMapEntity.DimensionID != null)
                {
                    ddlDimensionID.SelectedValue = aCItemAccountMapEntity.DimensionID.ToString();
                }

                if (ddlSalesAccountID.Items.Count > 0 && aCItemAccountMapEntity.SalesAccountID != null)
                {
                    ddlSalesAccountID.SelectedValue = aCItemAccountMapEntity.SalesAccountID.ToString();
                }

                if (ddlInventoryAccountID.Items.Count > 0 && aCItemAccountMapEntity.InventoryAccountID != null)
                {
                    ddlInventoryAccountID.SelectedValue = aCItemAccountMapEntity.InventoryAccountID.ToString();
                }

                if (ddlCOGSAccountID.Items.Count > 0 && aCItemAccountMapEntity.COGSAccountID != null)
                {
                    ddlCOGSAccountID.SelectedValue = aCItemAccountMapEntity.COGSAccountID.ToString();
                }

                if (ddlInventoryAdjustmentsAccountID.Items.Count > 0 && aCItemAccountMapEntity.InventoryAdjustmentsAccountID != null)
                {
                    ddlInventoryAdjustmentsAccountID.SelectedValue = aCItemAccountMapEntity.InventoryAdjustmentsAccountID.ToString();
                }

                txtAssetType.Text = aCItemAccountMapEntity.AssetType.ToString();
                txtPurchaseDate.Text = aCItemAccountMapEntity.PurchaseDate.ToStringDefault();
                txtPurchasePrice.Text = aCItemAccountMapEntity.PurchasePrice.ToString();
                txtDepreciationRate.Text = aCItemAccountMapEntity.DepreciationRate.ToString();
                if (ddlDepreciationMethodID.Items.Count > 0 && aCItemAccountMapEntity.DepreciationMethodID != null)
                {
                    ddlDepreciationMethodID.SelectedValue = aCItemAccountMapEntity.DepreciationMethodID.ToString();
                }

                if (ddlDepreciationAccountID.Items.Count > 0 && aCItemAccountMapEntity.DepreciationAccountID != null)
                {
                    ddlDepreciationAccountID.SelectedValue = aCItemAccountMapEntity.DepreciationAccountID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACItemAccountMapList();
        }

        private void BindACItemAccountMapList()
        {
            lvACItemAccountMap.DataBind();
        }

        private ACItemAccountMapEntity BuildACItemAccountMapEntity()
        {
            ACItemAccountMapEntity aCItemAccountMapEntity = CurrentACItemAccountMapEntity;

            if (ddlItemID.Items.Count > 0)
            {
                if (ddlItemID.SelectedValue == "0")
                {
                }
                else
                {
                    aCItemAccountMapEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                }
            }

            if (ddlDimensionID.Items.Count > 0)
            {
                if (ddlDimensionID.SelectedValue == "0")
                {
                    aCItemAccountMapEntity.DimensionID = null;
                }
                else
                {
                    aCItemAccountMapEntity.DimensionID = Int64.Parse(ddlDimensionID.SelectedValue);
                }
            }

            if (ddlSalesAccountID.Items.Count > 0)
            {
                if (ddlSalesAccountID.SelectedValue == "0")
                {
                    aCItemAccountMapEntity.SalesAccountID = null;
                }
                else
                {
                    aCItemAccountMapEntity.SalesAccountID = Int64.Parse(ddlSalesAccountID.SelectedValue);
                }
            }

            if (ddlInventoryAccountID.Items.Count > 0)
            {
                if (ddlInventoryAccountID.SelectedValue == "0")
                {
                    aCItemAccountMapEntity.InventoryAccountID = null;
                }
                else
                {
                    aCItemAccountMapEntity.InventoryAccountID = Int64.Parse(ddlInventoryAccountID.SelectedValue);
                }
            }

            if (ddlCOGSAccountID.Items.Count > 0)
            {
                if (ddlCOGSAccountID.SelectedValue == "0")
                {
                    aCItemAccountMapEntity.COGSAccountID = null;
                }
                else
                {
                    aCItemAccountMapEntity.COGSAccountID = Int64.Parse(ddlCOGSAccountID.SelectedValue);
                }
            }

            if (ddlInventoryAdjustmentsAccountID.Items.Count > 0)
            {
                if (ddlInventoryAdjustmentsAccountID.SelectedValue == "0")
                {
                    aCItemAccountMapEntity.InventoryAdjustmentsAccountID = null;
                }
                else
                {
                    aCItemAccountMapEntity.InventoryAdjustmentsAccountID = Int64.Parse(ddlInventoryAdjustmentsAccountID.SelectedValue);
                }
            }

            aCItemAccountMapEntity.AssetType = txtAssetType.Text.Trim();
            if (txtPurchaseDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCItemAccountMapEntity.PurchaseDate = MiscUtil.ParseToDateTime(txtPurchaseDate.Text);
            }
            else
            {
                aCItemAccountMapEntity.PurchaseDate = null;
            }

            if (!txtPurchasePrice.Text.Trim().IsNullOrEmpty())
            {
                aCItemAccountMapEntity.PurchasePrice = Decimal.Parse(txtPurchasePrice.Text.Trim());
            }
            else
            {
                aCItemAccountMapEntity.PurchasePrice = null;
            }

            if (!txtDepreciationRate.Text.Trim().IsNullOrEmpty())
            {
                aCItemAccountMapEntity.DepreciationRate = Decimal.Parse(txtDepreciationRate.Text.Trim());
            }
            else
            {
                aCItemAccountMapEntity.DepreciationRate = null;
            }

            if (ddlDepreciationMethodID.Items.Count > 0)
            {
                if (ddlDepreciationMethodID.SelectedValue == "0")
                {
                    aCItemAccountMapEntity.DepreciationMethodID = null;
                }
                else
                {
                    aCItemAccountMapEntity.DepreciationMethodID = Int64.Parse(ddlDepreciationMethodID.SelectedValue);
                }
            }

            if (ddlDepreciationAccountID.Items.Count > 0)
            {
                if (ddlDepreciationAccountID.SelectedValue == "0")
                {
                    aCItemAccountMapEntity.DepreciationAccountID = null;
                }
                else
                {
                    aCItemAccountMapEntity.DepreciationAccountID = Int64.Parse(ddlDepreciationAccountID.SelectedValue);
                }
            }


            return aCItemAccountMapEntity;
        }

        private void SaveACItemAccountMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACItemAccountMapEntity aCItemAccountMapEntity = BuildACItemAccountMapEntity();

                    Int64 result = -1;

                    if (aCItemAccountMapEntity.IsNew)
                    {
                        result = FCCACItemAccountMap.GetFacadeCreate().Add(aCItemAccountMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACItemAccountMapEntity.FLD_NAME_ItemAccountMapID, aCItemAccountMapEntity.ItemAccountMapID.ToString(), SQLMatchType.Equal);
                        result = FCCACItemAccountMap.GetFacadeCreate().Update(aCItemAccountMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ItemAccountMapID = 0;
                        _ACItemAccountMapEntity = new ACItemAccountMapEntity();
                        PrepareInitialView();
                        BindACItemAccountMapList();

                        if (aCItemAccountMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CItem Account Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CItem Account Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCItemAccountMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CItem Account Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CItem Account Map Information.", false);
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

        protected void lvACItemAccountMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ItemAccountMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out ItemAccountMapID);

            if (ItemAccountMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ItemAccountMapID = ItemAccountMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACItemAccountMapEntity.FLD_NAME_ItemAccountMapID, ItemAccountMapID.ToString(), SQLMatchType.Equal);

                        ACItemAccountMapEntity aCItemAccountMapEntity = new ACItemAccountMapEntity();


                        result = FCCACItemAccountMap.GetFacadeCreate().Delete(aCItemAccountMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ItemAccountMapID = 0;
                            _ACItemAccountMapEntity = new ACItemAccountMapEntity();
                            PrepareInitialView();
                            BindACItemAccountMapList();

                            MiscUtil.ShowMessage(lblMessage, "A CItem Account Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CItem Account Map.", true);
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

        protected void odsACItemAccountMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACItemAccountMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ItemAccountMapID = 0;
            _ACItemAccountMapEntity = new ACItemAccountMapEntity();
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
