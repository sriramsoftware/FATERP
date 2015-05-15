// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Dec-2011, 03:47:46




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
    public partial class PRMPreBOQDetailPrintVersionControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _PreBOQID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }
                else
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);

                    IList<PRMPreBOQEntity> tempList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (tempList != null && tempList.Count > 0)
                    {
                        id = tempList[0].PreBOQID;
                    }
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public Decimal PreBOQTotalValue
        {
            get
            {
                Decimal _preBOQTotalValue = 0;

                if (_PreBOQID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, _PreBOQID.ToString(), SQLMatchType.Equal);

                    IList<PRMPreBOQDetailEntity> preBOQList = FCCPRMPreBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty,fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (preBOQList != null && preBOQList.Count > 0)
                    {
                        foreach (PRMPreBOQDetailEntity ent in preBOQList)
                        {
                            _preBOQTotalValue += ent.Rate * ent.TotalQty;                         
                        }
                    }
                }
                return Decimal.Round(_preBOQTotalValue, 2);
            }
        }

        public Int64 _CurrentItemID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ItemID"] != null)
                {
                    Int64.TryParse(ViewState["ItemID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ItemID"] = value;
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

        private void BindList()
        {
            BindPRMPreBOQDetailList();
        }

        private void BindPRMPreBOQDetailList()
        {
            lvPRMPreBOQDetail.DataBind();
        }

        private void PrepareInitialView()
        {
            lblTopTotalBudgetValue.Text = lblButtomTotalBudgetValue.Text = PreBOQTotalValue.ToString();

            PrepareInitialViewPopup();
        }

        private void PrepareInitialViewPopup()
        {
            MiscUtil.PopulateMDBrand(ddlBrandID, false);
            MiscUtil.PopulatePRMSupplier(ddlSupplierID, false);
            MiscUtil.PopulateMDRegion(ddlOriginRegionID, false);
        }

        private void BuildCountryDropdownByRegion()
        {
            if (ddlOriginRegionID.SelectedValue != "0")
            {
                MiscUtil.PopulateMDCountryByRegionID(ddlOriginCountryID, false, Int64.Parse(ddlOriginRegionID.SelectedValue));
            }
        }

        private void PrepareEditView()
        {   
        }

        private void UpdatePreBOQInfo()
        {
            try
            {
                IList<ListViewDataItem> list = lvPRMPreBOQDetail.Items;

                if (list != null && list.Count > 0)
                {
                    Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        DataKey currentDataKey = lvPRMPreBOQDetail.DataKeys[tempDataItemIndex++];
                        Int64 intPreBOQDetailID = (Int64)currentDataKey["PreBOQDetailID"];

                        Decimal newRate = 0;
                        Decimal newTotalQty = 0;

                        TextBox txtRateLV = (TextBox)lvdi.FindControl("txtRateLV");
                        TextBox txtTotalQtyLV = (TextBox)lvdi.FindControl("txtTotalQtyLV");
                        TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");

                        Decimal.TryParse(txtRateLV.Text.Trim(), out newRate);
                        Decimal.TryParse(txtTotalQtyLV.Text.Trim(), out newTotalQty);

                        PRMPreBOQDetailEntity pRMPreBOQDetailEntity = FCCPRMPreBOQDetail.GetFacadeCreate().GetByID(intPreBOQDetailID);

                        if (newRate > 0)
                        {
                            pRMPreBOQDetailEntity.Rate = newRate;
                        }

                        if (newRate > 0)
                        {
                            pRMPreBOQDetailEntity.TotalQty = newTotalQty;
                        }

                        pRMPreBOQDetailEntity.Remarks = txtRemarksLV.Text;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQDetailID, intPreBOQDetailID.ToString(), SQLMatchType.Equal);

                        FCCPRMPreBOQDetail.GetFacadeCreate().Update(pRMPreBOQDetailEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);
                    }
                    PrepareInitialView();
                    MiscUtil.ShowMessage(lblMessage, "BOQ Information has been saved successfully.", false);
                }               
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to save BOQ Information.", true);
            }
        }

        private void GetCurrentPrice()
        {
            String fe = String.Empty;
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_ItemID, _CurrentItemID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_BrandID, ddlBrandID.SelectedValue.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            String fe3 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_OriginRegionID, ddlOriginRegionID.SelectedValue.ToString(), SQLMatchType.Equal);
            String fe4 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_OriginCountryID, ddlOriginCountryID.SelectedValue.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe4);
            String fe5 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_SupplierID, ddlSupplierID.SelectedValue.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe5);

            IList<PRMSupplierItemMapEntity> supplierItemMapList = FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (supplierItemMapList != null && supplierItemMapList.Count > 0)
            {
                this.txtPrice.Text = supplierItemMapList[0].Price.ToString();
            }
            else
            {
                this.txtPrice.Text = "0";
            }
        }

        private void UpdatePriceInfo()
        {
            String fe = String.Empty;
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_ItemID, _CurrentItemID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, this._PreBOQID.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            IList<PRMPreBOQDetailEntity> preBOQDetailList = FCCPRMPreBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (preBOQDetailList != null && preBOQDetailList.Count > 0)
            {
                PRMPreBOQDetailEntity prmPreBOQDetailent = preBOQDetailList[0];
                prmPreBOQDetailent.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                prmPreBOQDetailent.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
                prmPreBOQDetailent.RegionID = Int64.Parse(ddlOriginRegionID.SelectedValue);
                prmPreBOQDetailent.CountryID = Int64.Parse(ddlOriginCountryID.SelectedValue);
                GetCurrentPrice();
                prmPreBOQDetailent.Rate = Decimal.Parse(this.txtPrice.Text.ToString());
                FCCPRMPreBOQDetail.GetFacadeCreate().Update(prmPreBOQDetailent, fe, DatabaseOperationType.Update, TransactionRequired.No);

                BindList();
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

        protected void lvPRMPreBOQDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "test")
            {   
                Int64 ItemID;

                Int64.TryParse(e.CommandArgument.ToString(), out ItemID);

                if (ItemID > 0)
                {
                    BuildCountryDropdownByRegion();
                    _CurrentItemID = ItemID;
                     this.lblItemName.Text = ((Label)e.Item.FindControl("lblItemNameLV")).Text;
                     this.ddlBrandID.SelectedValue = ((Label) e.Item.FindControl("lblBrandID")).Text;
                     this.ddlSupplierID.SelectedValue = ((Label)e.Item.FindControl("lblSupplierID")).Text;
                     this.ddlOriginRegionID.SelectedValue = ((Label)e.Item.FindControl("lblRegionID")).Text;
                     BuildCountryDropdownByRegion();
                     this.ddlOriginCountryID.SelectedValue = ((Label)e.Item.FindControl("lblCountryID")).Text;
                     GetCurrentPrice();
                }

                this.Panel1_ModalPopupExtender.Show();
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsPRMPreBOQDetail_Custom_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMPreBOQDetail." + PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, _PreBOQID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event
        
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePreBOQInfo();
        }

        protected void lnkSavePopup_Click(object sender, EventArgs e)
        {
            UpdatePriceInfo();
        }

        protected void lnkGetPrice_OnClick(object sender, EventArgs e)
        {
            this.Panel1_ModalPopupExtender.Show();
            GetCurrentPrice();
        }

        #endregion

        #region Dropdown Event

        protected void ddlOriginRegionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Panel1_ModalPopupExtender.Show();
            BuildCountryDropdownByRegion();
        }

        #endregion

        #endregion Event
    }
}
