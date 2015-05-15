// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jul-2012, 11:50:01




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
    public partial class REQRequisitionItemCorporateControl : BaseControl
    {
        #region Properties

        public Int64 _RequisitionItemID
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

        public REQRequisitionItemEntity _REQRequisitionItemEntity
        {
            get
            {
                REQRequisitionItemEntity entity = new REQRequisitionItemEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (REQRequisitionItemEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private REQRequisitionItemEntity CurrentREQRequisitionItemEntity
        {
            get
            {
                if (_RequisitionItemID > 0)
                {
                    if (_REQRequisitionItemEntity.RequisitionItemID != _RequisitionItemID)
                    {
                        _REQRequisitionItemEntity = FCCREQRequisitionItem.GetFacadeCreate().GetByID(_RequisitionItemID);
                    }
                }

                return _REQRequisitionItemEntity;
            }
            set
            {
                _REQRequisitionItemEntity = value;
            }
        }

        public Int64 REQRequisitionID
        {
            get
            {
                Int64 rEQRequisitionID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[REQRequisitionEntity.FLD_NAME_RequisitionID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[REQRequisitionEntity.FLD_NAME_RequisitionID], out rEQRequisitionID);
                }

                return rEQRequisitionID;
            }
        }

        private REQRequisitionEntity CurrentREQRequisitionEntity
        {
            get
            {
                REQRequisitionEntity _REQRequisitionEntity;

                if (REQRequisitionID > 0)
                {
                    _REQRequisitionEntity = FCCREQRequisition.GetFacadeCreate().GetByID(REQRequisitionID);
                }

                else
                {
                    _REQRequisitionEntity = new REQRequisitionEntity();
                }

                return _REQRequisitionEntity;
            }
        }

        public Decimal ItemQty
        {
            get
            {
                Decimal itemQty = 0;
                if (ViewState["vs_ItemQty"] != null)
                {
                    Decimal.TryParse(ViewState["vs_ItemQty"].ToString(), out itemQty);
                }

                return itemQty;
            }
            set
            {
                ViewState["vs_ItemQty"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {  
            MiscUtil.PopulateMDItem(ddlItemID, false);

            if (ddlItemID != null && ddlItemID.Items.Count > 0)
            {
                MiscUtil.PopulateMDBrandByItemID(ddlBrandID, false,Int64.Parse(ddlItemID.SelectedValue));

                if(ddlBrandID != null && ddlBrandID.Items.Count > 0)
                {
                    MiscUtil.PopulateMDRegionByItemBrandID(ddlRegionID, false,Int64.Parse(ddlItemID.SelectedValue),Int64.Parse(ddlBrandID.SelectedValue));

                    if (ddlRegionID != null && ddlRegionID.Items.Count > 0)
                    {
                        MiscUtil.PopulateMDCountryByItemBrandRegionID(ddlCountryID, false, Int64.Parse(ddlItemID.SelectedValue), Int64.Parse(ddlBrandID.SelectedValue), Int64.Parse(ddlRegionID.SelectedValue));
                    }
                }
            }
        }
        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAccountsCode.Text = String.Empty;
            txtRate.Text = String.Empty;
            txtTotalRequiredQty.Text = String.Empty;
            txtPurchasedQtyTillToDate.Text = String.Empty;
            txtPresentRequiredQty.Text = String.Empty;
            txtRequiredDate.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            lblRequisitonNo.Text = CurrentREQRequisitionEntity.RequisitionNo.ToString();

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            REQRequisitionItemEntity rEQRequisitionItemEntity = CurrentREQRequisitionItemEntity;


            if (!rEQRequisitionItemEntity.IsNew)
            {

                txtAccountsCode.Text = rEQRequisitionItemEntity.AccountsCode.ToString();
                if (ddlItemID.Items.Count > 0 && rEQRequisitionItemEntity.ItemID != null)
                {
                    ddlItemID.SelectedValue = rEQRequisitionItemEntity.ItemID.ToString();
                }

                if (ddlBrandID.Items.Count > 0 && rEQRequisitionItemEntity.BrandID != null)
                {
                    ddlBrandID.SelectedValue = rEQRequisitionItemEntity.BrandID.ToString();
                }

                if (ddlSupplierID.Items.Count > 0 && rEQRequisitionItemEntity.SupplierID != null)
                {
                    ddlSupplierID.SelectedValue = rEQRequisitionItemEntity.SupplierID.ToString();
                }

                if (ddlRegionID.Items.Count > 0 && rEQRequisitionItemEntity.RegionID != null)
                {
                    ddlRegionID.SelectedValue = rEQRequisitionItemEntity.RegionID.ToString();
                }

                if (ddlCountryID.Items.Count > 0 && rEQRequisitionItemEntity.CountryID != null)
                {
                    ddlCountryID.SelectedValue = rEQRequisitionItemEntity.CountryID.ToString();
                }

                txtRate.Text = rEQRequisitionItemEntity.Rate.ToString();
                txtTotalRequiredQty.Text = rEQRequisitionItemEntity.TotalRequiredQty.ToString();
                txtPurchasedQtyTillToDate.Text = rEQRequisitionItemEntity.PurchasedQtyTillToDate.ToString();
                txtPresentRequiredQty.Text = rEQRequisitionItemEntity.PresentRequiredQty.ToString();
                txtRequiredDate.Text = rEQRequisitionItemEntity.RequiredDate.ToStringDefault();
                txtRemarks.Text = rEQRequisitionItemEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindREQRequisitionItemList();
        }

        private void BindREQRequisitionItemList()
        {
            lvREQRequisitionItem.DataBind();
        }

        private REQRequisitionItemEntity BuildREQRequisitionItemEntity()
        {
            REQRequisitionItemEntity rEQRequisitionItemEntity = CurrentREQRequisitionItemEntity;

            rEQRequisitionItemEntity.RequisitionID = REQRequisitionID;
           
            rEQRequisitionItemEntity.AccountsCode = txtAccountsCode.Text.Trim();
            if (ddlItemID.Items.Count > 0)
            {
                if (ddlItemID.SelectedValue == "0")
                {
                }
                else
                {
                    rEQRequisitionItemEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                }
            }

            if (ddlBrandID.Items.Count > 0)
            {
                if (ddlBrandID.SelectedValue == "0")
                {
                }
                else
                {
                    rEQRequisitionItemEntity.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                }
            }

            if (ddlSupplierID.Items.Count > 0)
            {
                if (ddlSupplierID.SelectedValue == "0")
                {
                }
                else
                {
                    rEQRequisitionItemEntity.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
                }
            }

            if (ddlRegionID.Items.Count > 0)
            {
                if (ddlRegionID.SelectedValue == "0")
                {
                }
                else
                {
                    rEQRequisitionItemEntity.RegionID = Int64.Parse(ddlRegionID.SelectedValue);
                }
            }

            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                }
                else
                {
                    rEQRequisitionItemEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }

            if (!txtRate.Text.Trim().IsNullOrEmpty())
            {
                rEQRequisitionItemEntity.Rate = Decimal.Parse(txtRate.Text.Trim());
            }

            if (!txtTotalRequiredQty.Text.Trim().IsNullOrEmpty())
            {
                rEQRequisitionItemEntity.TotalRequiredQty = Decimal.Parse(txtTotalRequiredQty.Text.Trim());
            }

            if (!txtPurchasedQtyTillToDate.Text.Trim().IsNullOrEmpty())
            {
                rEQRequisitionItemEntity.PurchasedQtyTillToDate = Decimal.Parse(txtPurchasedQtyTillToDate.Text.Trim());
            }
            else
            {
                rEQRequisitionItemEntity.PurchasedQtyTillToDate = null;
            }

            if (!txtPresentRequiredQty.Text.Trim().IsNullOrEmpty())
            {
                rEQRequisitionItemEntity.PresentRequiredQty = Decimal.Parse(txtPresentRequiredQty.Text.Trim());
            }

            if (txtRequiredDate.Text.Trim().IsNotNullOrEmpty())
            {
                rEQRequisitionItemEntity.RequiredDate = MiscUtil.ParseToDateTime(txtRequiredDate.Text);
            }

            rEQRequisitionItemEntity.Remarks = txtRemarks.Text.Trim();

            return rEQRequisitionItemEntity;
        }

        private void SaveREQRequisitionItemEntity()
        {
            if (IsValid)
            {
                try
                {
                    REQRequisitionItemEntity rEQRequisitionItemEntity = BuildREQRequisitionItemEntity();

                    Int64 result = -1;

                    if (rEQRequisitionItemEntity.IsNew)
                    {
                        result = FCCREQRequisitionItem.GetFacadeCreate().Add(rEQRequisitionItemEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, rEQRequisitionItemEntity.RequisitionItemID.ToString(), SQLMatchType.Equal);
                        result = FCCREQRequisitionItem.GetFacadeCreate().Update(rEQRequisitionItemEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _RequisitionItemID = 0;
                        _REQRequisitionItemEntity = new REQRequisitionItemEntity();
                        PrepareInitialView();
                        BindREQRequisitionItemList();

                        if (rEQRequisitionItemEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "R EQRequisition Item Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "R EQRequisition Item Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (rEQRequisitionItemEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add R EQRequisition Item Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update R EQRequisition Item Information.", false);
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

        protected void lvREQRequisitionItem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 RequisitionItemID;

            Int64.TryParse(e.CommandArgument.ToString(), out RequisitionItemID);

            if (RequisitionItemID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _RequisitionItemID = RequisitionItemID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, RequisitionItemID.ToString(), SQLMatchType.Equal);

                        REQRequisitionItemEntity rEQRequisitionItemEntity = new REQRequisitionItemEntity();


                        result = FCCREQRequisitionItem.GetFacadeCreate().Delete(rEQRequisitionItemEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _RequisitionItemID = 0;
                            _REQRequisitionItemEntity = new REQRequisitionItemEntity();
                            PrepareInitialView();
                            BindREQRequisitionItemList();

                            MiscUtil.ShowMessage(lblMessage, "R EQRequisition Item has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete R EQRequisition Item.", true);
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

        protected void odsREQRequisitionItem_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveREQRequisitionItemEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _RequisitionItemID = 0;
            _REQRequisitionItemEntity = new REQRequisitionItemEntity();
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
