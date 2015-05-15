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
    public partial class PRMPreBOQDetailControl : ProjectBaseControl
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

        public Int64 _CurrentPreBOQDetailIDPopup
        {
            get
            {
                Int64 id = 0;

                if (ViewState["vs_CurrentPreBOQDetailIDPopup"] != null)
                {
                    Int64.TryParse(ViewState["vs_CurrentPreBOQDetailIDPopup"].ToString(), out id);
                }

                return id;
            }

            set
            {
                ViewState["vs_CurrentPreBOQDetailIDPopup"] = value;
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

        private void BindPRMPreBOQFloorDetailList()
        {
            lvPRMPreBOQFloorDetail.DataBind();
        }

        private void PrepareInitialView()
        {
            lblTopTotalBudgetValue.Text = lblButtomTotalBudgetValue.Text = PreBOQTotalValue.ToString();

            PrepareInitialViewPopup();
        }

        private void PrepareInitialViewPopup()
        {   
            MiscUtil.PopulateMDRegion(ddlOriginRegionID, false);
        }

        private void BuildSupplierByBrand()
        {
            if (ddlBrandID != null && ddlBrandID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMSupplierByBrandID(ddlSupplierID, false, Int64.Parse(ddlBrandID.SelectedValue.ToString()));
            }
            else
            {
                ddlSupplierID.Items.Clear();
            }
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

                        if (newTotalQty > 0)
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
                MiscUtil.ShowMessage(lblMessage, "Failed To Save BOQ Information.", true);
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

                IList<ListViewDataItem> list = lvPRMPreBOQDetail.Items;

                if (list != null && list.Count > 0)
                {
                    Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        DataKey currentDataKey = lvPRMPreBOQDetail.DataKeys[tempDataItemIndex++];
                        Int64 intPreBOQDetailID = (Int64)currentDataKey["PreBOQDetailID"];

                        if (preBOQDetailList[0].PreBOQDetailID == intPreBOQDetailID)
                        {
                            TextBox txtRateLV = (TextBox)lvdi.FindControl("txtRateLV");
                            txtRateLV.Text = prmPreBOQDetailent.Rate.ToString();
                        }
                    }
                }

                BindList();
            }
        }

        private void UpdatePreBOQFloorDetail()
        {
            try
            {
                IList<ListViewDataItem> listPRMPreFloorDetail = lvPRMPreBOQFloorDetail.Items;

                if (listPRMPreFloorDetail != null && listPRMPreFloorDetail.Count > 0)
                {
                    Decimal Totalqty = 0, totalRate = 0, avgRate, avgTotalQty, count = 0;

                    foreach (ListViewDataItem lvdi in listPRMPreFloorDetail)
                    {
                        Int64 floorDetailID;
                        Decimal newQty, floorRate;

                        TextBox txtTotalQtyLV = (TextBox)lvdi.FindControl("txtQtyLV");
                        TextBox txtRateLV = (TextBox)lvdi.FindControl("txtRateLV");
                        TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                        Label floorDetailIDLV = (Label)lvdi.FindControl("lblPreBOQFloorDetailIDLV");

                        Decimal.TryParse(txtTotalQtyLV.Text.Trim(), out newQty);
                        Decimal.TryParse(txtRateLV.Text.Trim(), out floorRate);
                        Int64.TryParse(floorDetailIDLV.Text.Trim(), out floorDetailID);

                        PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity = FCCPRMPreBOQFloorDetail.GetFacadeCreate().GetByID(floorDetailID);
                        pRMPreBOQFloorDetailEntity.Qty = newQty;
                        pRMPreBOQFloorDetailEntity.Rate = floorRate;
                        pRMPreBOQFloorDetailEntity.Remarks = txtRemarksLV.Text;
                        pRMPreBOQFloorDetailEntity.EntryDate = System.DateTime.Now;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQFloorDetailID, floorDetailID.ToString(), SQLMatchType.Equal);

                        FCCPRMPreBOQFloorDetail.GetFacadeCreate().Update(pRMPreBOQFloorDetailEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                        Totalqty += newQty;
                        totalRate += floorRate;
                        count++;
                    }

                    avgRate = totalRate / count;
                    avgTotalQty = Totalqty / count;

                    #region Update Project Cost Qty

                    String fe_BOQDetail = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQDetailID, _CurrentPreBOQDetailIDPopup.ToString(), SQLMatchType.Equal);
                    PRMPreBOQDetailEntity prmBOQDetailEntity = FCCPRMPreBOQDetail.GetFacadeCreate().GetByID(_CurrentPreBOQDetailIDPopup);
                    prmBOQDetailEntity.TotalQty = Totalqty;

                    FCCPRMPreBOQDetail.GetFacadeCreate().Update(prmBOQDetailEntity, fe_BOQDetail, DatabaseOperationType.Update, TransactionRequired.No);

                    IList<ListViewDataItem> listPRMBOQDetail = lvPRMPreBOQDetail.Items;

                    if (listPRMBOQDetail != null && listPRMBOQDetail.Count > 0)
                    {
                        Int32 tempDataItemIndex = 0;

                        foreach (ListViewDataItem lvdi in listPRMBOQDetail)
                        {
                            DataKey currentDataKey = lvPRMPreBOQDetail.DataKeys[tempDataItemIndex++];
                            Int64 intPreBOQDetailID = (Int64)currentDataKey["PreBOQDetailID"];

                            if (_CurrentPreBOQDetailIDPopup == intPreBOQDetailID)
                            {
                                TextBox txtRateLV = (TextBox)lvdi.FindControl("txtRateLV");
                                TextBox txtTotalQtyLV = (TextBox)lvdi.FindControl("txtTotalQtyLV");
                                txtTotalQtyLV.Text = Totalqty.ToString();
                                txtRateLV.Text = avgRate.ToString();
                                break;
                            }
                        }
                    }

                    BindList();

                    #endregion

                    MiscUtil.ShowMessage(lblMessage, "Project Cost Information has been saved successfully.", false);
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Save Project Cost Information.", true);
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

        protected void lvPRMPreBOQDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                PRMPreBOQDetail_CustomEntity ent = (PRMPreBOQDetail_CustomEntity)dataItem.DataItem;

                String fe=SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQDetailID,ent.PreBOQDetailID.ToString(),SQLMatchType.Equal);
                IList<PRMPreBOQFloorDetailEntity> lst=FCCPRMPreBOQFloorDetail.GetFacadeCreate().GetIL(null,null,String.Empty,fe,DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    LinkButton btnAdditionalQty = (LinkButton)e.Item.FindControl("btnAdditionalQty");
                    btnAdditionalQty.Visible = false;
                }
            }
        }

        protected void lvPRMPreBOQDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            #region Modify Qty

            if (e.CommandName == "ModifyQty")
            {
                Int64 ItemID;

                Int64.TryParse(e.CommandArgument.ToString(), out ItemID);
                Label lblPreBOQDetailIDLV = (Label)e.Item.FindControl("lblPreBOQDetailIDLV");
                TextBox txtRateLV = (TextBox)e.Item.FindControl("txtRateLV");

                Int64 preBOQDetailID = Int64.Parse(lblPreBOQDetailIDLV.Text);
                _CurrentPreBOQDetailIDPopup = preBOQDetailID;

                if (ItemID > 0)
                {
                    _CurrentItemID = ItemID;
                    this.lblItemName.Text = ((Label)e.Item.FindControl("lblItemNameLV")).Text;

                    PRMPreBOQDetailEntity bOQDetailEntity = FCCPRMPreBOQDetail.GetFacadeCreate().GetByID(preBOQDetailID);

                    if (bOQDetailEntity != null && bOQDetailEntity.PreBOQDetailID > 0)
                    {

                        String fe3 = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                        IList<BDProjectFloorEntity> bDProjectFloorList = FCCBDProjectFloor.GetFacadeCreate().GetIL(null, null, String.Empty, fe3, DatabaseOperationType.LoadWithFilterExpression);

                        if (bDProjectFloorList != null && bDProjectFloorList.Count > 0)
                        {

                            foreach (BDProjectFloorEntity bdProjectfloorent in bDProjectFloorList)
                            {
                                String fe4 = String.Empty;
                                String feFloorDetail1 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQFloorDetailEntity.FLD_NAME_ProjectFloorID, bdProjectfloorent.ProjectFloorID.ToString(), SQLMatchType.Equal);
                                String feFloorDetail2 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQDetailID, preBOQDetailID.ToString(), SQLMatchType.Equal);
                                fe4 = SqlExpressionBuilder.PrepareFilterExpression(feFloorDetail1, SQLJoinType.AND, feFloorDetail2);

                                IList<PRMPreBOQFloorDetailEntity> list = FCCPRMPreBOQFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe4, DatabaseOperationType.LoadWithFilterExpression);

                                if (list == null || list.Count <= 0)
                                {
                                    PRMPreBOQFloorDetailEntity ent = new PRMPreBOQFloorDetailEntity();
                                    ent.PreBOQDetailID = Int64.Parse(preBOQDetailID.ToString());
                                    ent.ProjectFloorID = Int64.Parse(bdProjectfloorent.ProjectFloorID.ToString());
                                    Decimal dividedQty;
                                    Decimal RateLV;

                                    Decimal.TryParse(txtRateLV.Text, out RateLV);
                                    Decimal.TryParse((bOQDetailEntity.TotalQty / (this.OverviewProject.NoOfBasement + this.OverviewProject.NoOfStoried)).ToString(), out dividedQty);

                                    switch (bdProjectfloorent.FloorCategoryID)
                                    {
                                        case MasterDataConstants.FloorCategory.BASEMENT:
                                            dividedQty = dividedQty / 4; //Assumuation
                                            break;
                                        case MasterDataConstants.FloorCategory.FLOOR:
                                            dividedQty = dividedQty * 1; //Assumuation
                                            break;
                                        case MasterDataConstants.FloorCategory.PENTHOUSE:
                                            dividedQty = dividedQty * 2; //Assumuation
                                            break;
                                        case MasterDataConstants.FloorCategory.HEAD_ROOM:
                                            dividedQty = dividedQty * 3; //Assumuation
                                            break;
                                        default:
                                            dividedQty = 0;
                                            break;
                                    }

                                    ent.Rate = RateLV;
                                    ent.Qty = dividedQty;
                                    ent.Remarks = String.Empty;
                                    ent.EntryDate = System.DateTime.Now;
                                    FCCPRMPreBOQFloorDetail.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                                }
                            }

                            BindPRMPreBOQFloorDetailList();

                            this.ModalPopupExtender2.Show();
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "No Floor Available.", true);
                        }
                    }
                }
            }

            #endregion

            #region Modify Price

            if (e.CommandName == "ModifyPrice")
            {
                Int64 ItemID;

                Int64.TryParse(e.CommandArgument.ToString(), out ItemID);

                if (ItemID > 0)
                {
                    MiscUtil.PopulateMDBrandByItemID(ddlBrandID, false, Int64.Parse(ItemID.ToString()));
                    this.lblItemName.Text = ((Label)e.Item.FindControl("lblItemNameLV")).Text;

                    if (ddlBrandID != null && ddlBrandID.Items.Count > 0)
                    {
                        this.ddlBrandID.SelectedValue = ((Label)e.Item.FindControl("lblBrandID")).Text;
                    }

                    BuildSupplierByBrand();

                    if (ddlSupplierID != null && ddlSupplierID.Items.Count > 0)
                    {
                        this.ddlSupplierID.SelectedValue = ((Label)e.Item.FindControl("lblSupplierID")).Text;
                    }
                    _CurrentItemID = ItemID;

                    if (ddlOriginRegionID != null && ddlOriginRegionID.Items.Count > 0)
                    {
                        this.ddlOriginRegionID.SelectedValue = ((Label)e.Item.FindControl("lblRegionID")).Text;
                    }
                    BuildCountryDropdownByRegion();

                    if (ddlOriginCountryID != null && ddlOriginCountryID.Items.Count > 0)
                    {
                        this.ddlOriginCountryID.SelectedValue = ((Label)e.Item.FindControl("lblCountryID")).Text;
                    }

                    GetCurrentPrice();
                }

                this.Panel1_ModalPopupExtender.Show();
            }

            if (e.CommandName == "AdditionalQty")
            {
                Int64 preBoqDetailID;

                Int64.TryParse(e.CommandArgument.ToString(), out preBoqDetailID);

                if (preBoqDetailID > 0)
                {
                    _CurrentPreBOQDetailIDPopup = preBoqDetailID;

                    this.ModalPopupExtender1.Show();
                }
            }

            #endregion
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsPRMPreBOQDetail_Custom_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            if (e.ExecutingSelectCount == false && e.Arguments.SortExpression==String.Empty)
            {
                UpdatePreBOQInfo();
            }
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMPreBOQDetail." + PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, _PreBOQID.ToString(), SQLMatchType.Equal);

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("MDItem.ItemName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
            }
            
            e.InputParameters["filterExpression"] = fe;
        }

        protected void odsPRMPreBOQFloorDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (_CurrentPreBOQDetailIDPopup > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("PRMPreBOQFloorDetail." + PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQDetailID, _CurrentPreBOQDetailIDPopup.ToString(), SQLMatchType.Equal);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event
        
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePreBOQInfo();
        }

        protected void btnFloorPopupSave_Click(object sender, EventArgs e)
        {
            UpdatePreBOQFloorDetail();
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

        protected void btnPnlSaveAdditionalQty_Click(object sender, EventArgs e)
        {
            PRMPreBOQDetailEntity pRMBOQDetailEntity = FCCPRMPreBOQDetail.GetFacadeCreate().GetByID(_CurrentPreBOQDetailIDPopup);

            if (pRMBOQDetailEntity != null && pRMBOQDetailEntity.PreBOQDetailID > 0)
            {
                Decimal additionalQty = 0;
                Decimal.TryParse(txtQty.Text.Trim().ToString(), out additionalQty);

                PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity = new PRMAvailableBOQQtyForRequisitionEntity();

                pRMAvailableBOQQtyForRequisitionEntity.IsBOQ = false;
                pRMAvailableBOQQtyForRequisitionEntity.PreBOQOrBOQDetailID = _CurrentPreBOQDetailIDPopup;
                pRMAvailableBOQQtyForRequisitionEntity.ItemID = pRMBOQDetailEntity.ItemID;
                pRMAvailableBOQQtyForRequisitionEntity.Qty = additionalQty;
                pRMAvailableBOQQtyForRequisitionEntity.CreateDate = DateTime.Now;
                pRMAvailableBOQQtyForRequisitionEntity.CreatedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                PRMPreBOQEntity pRMPreBOQEntity = FCCPRMPreBOQ.GetFacadeCreate().GetByID(pRMBOQDetailEntity.PreBOQID);
                pRMAvailableBOQQtyForRequisitionEntity.ProjectID = pRMPreBOQEntity.ProjectID;

                Int64 result = -1;
                result = FCCPRMAvailableBOQQtyForRequisition.GetFacadeCreate().Add(pRMAvailableBOQQtyForRequisitionEntity, DatabaseOperationType.Add, TransactionRequired.No);

                if (result > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQDetailID, _CurrentPreBOQDetailIDPopup.ToString(), SQLMatchType.Equal);

                    pRMBOQDetailEntity.TotalQty = pRMBOQDetailEntity.TotalQty + additionalQty;

                    FCCPRMPreBOQDetail.GetFacadeCreate().Update(pRMBOQDetailEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                    IList<ListViewDataItem> list = lvPRMPreBOQDetail.Items;

                    if (list != null && list.Count > 0)
                    {
                        Int32 tempDataItemIndex = 0;

                        foreach (ListViewDataItem lvdi in list)
                        {
                            DataKey currentDataKey = lvPRMPreBOQDetail.DataKeys[tempDataItemIndex++];
                            Int64 PreBOQDetailID = (Int64)currentDataKey["PreBOQDetailID"];

                            if (_CurrentPreBOQDetailIDPopup == PreBOQDetailID)
                            {
                                TextBox txtTotalQtyLV = (TextBox)lvdi.FindControl("txtTotalQtyLV");
                                txtTotalQtyLV.Text = pRMBOQDetailEntity.TotalQty.ToString();
                            }
                        }
                    }

                    BindPRMPreBOQDetailList();

                    #region PreBOQ Floor Detail

                    String fe_projectFloor = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQDetailID, _CurrentPreBOQDetailIDPopup.ToString(), SQLMatchType.Equal);
                    IList<PRMPreBOQFloorDetailEntity> lstPRMPreBOQFloorDetail = FCCPRMPreBOQFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_projectFloor, DatabaseOperationType.LoadWithFilterExpression);

                    if (lstPRMPreBOQFloorDetail != null && lstPRMPreBOQFloorDetail.Count > 0)
                    {
                        Int64 totalfloorCount=lstPRMPreBOQFloorDetail.Count;
                        Decimal avgQty = pRMBOQDetailEntity.TotalQty / totalfloorCount;

                        foreach(PRMPreBOQFloorDetailEntity ent in lstPRMPreBOQFloorDetail)
                        {
                            String fe1=SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQFloorDetailID,ent.PreBOQFloorDetailID.ToString(),SQLMatchType.Equal);
                            ent.Qty=avgQty;
                            FCCPRMPreBOQFloorDetail.GetFacadeCreate().Update(ent, fe1, DatabaseOperationType.Update, TransactionRequired.No);
                        }
                    }

                    #endregion

                    this.ModalPopupExtender1.Hide();
                }
            }
        }

        #endregion

        #region Dropdown Event

        protected void ddlOriginRegionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Panel1_ModalPopupExtender.Show();
            BuildCountryDropdownByRegion();
        }

        protected void ddlBrandID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Panel1_ModalPopupExtender.Show();
            BuildSupplierByBrand();
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
