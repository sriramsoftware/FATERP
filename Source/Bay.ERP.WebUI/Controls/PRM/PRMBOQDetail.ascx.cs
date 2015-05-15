// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    public partial class PRMBOQDetailControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _BOQID
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
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                    IList<PRMBOQEntity> tempList = FCCPRMBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (tempList != null && tempList.Count > 0)
                    {
                        id = tempList[0].BOQID;
                    }
                }

                return id;
            }

            set
            {
                ViewState["ID"] = value;
            }
        }

        public PRMBOQDetailEntity _PRMBOQDetailEntity
        {
            get
            {
                PRMBOQDetailEntity entity = new PRMBOQDetailEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMBOQDetailEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }

            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        public Decimal BOQTotalValue
        {
            get
            {
                Decimal _BOQTotalValue = 0;

                if (_BOQID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQID, _BOQID.ToString(), SQLMatchType.Equal);

                    IList<PRMBOQDetailEntity> preBOQList = FCCPRMBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (preBOQList != null && preBOQList.Count > 0)
                    {
                        foreach (PRMBOQDetailEntity ent in preBOQList)
                        {
                            _BOQTotalValue += ent.Rate * ent.TotalQty;
                        }
                    }
                }

                return Decimal.Round(_BOQTotalValue, 2);
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

        public Int64 _CurrentBOQDetailIDPopup
        {
            get
            {
                Int64 id = 0;

                if (ViewState["vs_CurrentBOQDetailIDPopup"] != null)
                {
                    Int64.TryParse(ViewState["vs_CurrentBOQDetailIDPopup"].ToString(), out id);
                }

                return id;
            }

            set
            {
                ViewState["vs_CurrentBOQDetailIDPopup"] = value;
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
            lblTopTotalBudgetValue.Text = lblButtomTotalBudgetValue.Text = BOQTotalValue.ToString();

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
            if (ddlOriginRegionID.SelectedValue != "0" && ddlOriginRegionID.Items.Count > 0)
            {
                MiscUtil.PopulateMDCountryByRegionID(ddlOriginCountryID, false, Int64.Parse(ddlOriginRegionID.SelectedValue));
            }
        }

        private void PrepareEditView()
        {
           
        }

        private void BindPRMBOQFloorDetailList()
        {
            lvPRMBOQFloorDetail.DataBind();
        }

        private void BindList()
        {
            BindPRMBOQDetailList();
        }

        private void BindPRMBOQDetailList()
        {
            lvPRMBOQDetail.DataBind();
        }

        private void UpdateBOQInfo()
        {
            try
            {
                IList<ListViewDataItem> list = lvPRMBOQDetail.Items;

                if (list != null && list.Count > 0)
                {
                    Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        DataKey currentDataKey = lvPRMBOQDetail.DataKeys[tempDataItemIndex++];
                        Int64 intPreBOQDetailID = (Int64)currentDataKey["BOQDetailID"];

                        Decimal newRate = 0;
                        Decimal newTotalQty = 0;

                        TextBox txtRateLV = (TextBox)lvdi.FindControl("txtRateLV");
                        TextBox txtTotalQtyLV = (TextBox)lvdi.FindControl("txtTotalQtyLV");
                        TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");

                        Decimal.TryParse(txtRateLV.Text.Trim(), out newRate);
                        Decimal.TryParse(txtTotalQtyLV.Text.Trim(), out newTotalQty);

                        PRMBOQDetailEntity pRMPreBOQDetailEntity = FCCPRMBOQDetail.GetFacadeCreate().GetByID(intPreBOQDetailID);

                        if (newRate > 0)
                        {
                            pRMPreBOQDetailEntity.Rate = newRate;
                        }

                        if (newTotalQty > 0)
                        {
                            pRMPreBOQDetailEntity.TotalQty = newTotalQty;
                        }

                        pRMPreBOQDetailEntity.Remarks = txtRemarksLV.Text;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQDetailID, intPreBOQDetailID.ToString(), SQLMatchType.Equal);

                        FCCPRMBOQDetail.GetFacadeCreate().Update(pRMPreBOQDetailEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    PrepareInitialView();
                    MiscUtil.ShowMessage(lblMessage, "Project Cost Information has been saved successfully.", false);
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Save Project Cost Information.", true);
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

        private void UpdateBOQFloorDetail()
        {
            try
            {
                IList<ListViewDataItem> listPRMFloorDetail = lvPRMBOQFloorDetail.Items;

                if (listPRMFloorDetail != null && listPRMFloorDetail.Count > 0)
                {
                    Decimal Totalqty = 0,totalRate=0,avgRate,avgTotalQty,count=0;

                    foreach (ListViewDataItem lvdi in listPRMFloorDetail)
                    {
                        Int64 floorDetailID;
                        Decimal newQty, floorRate;

                        TextBox txtTotalQtyLV = (TextBox)lvdi.FindControl("txtQtyLV");
                        TextBox txtRateLV = (TextBox)lvdi.FindControl("txtRateLV");
                        TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                        Label floorDetailIDLV = (Label)lvdi.FindControl("lblBOQFloorDetailIDLV");

                        Decimal.TryParse(txtTotalQtyLV.Text.Trim(), out newQty);
                        Decimal.TryParse(txtRateLV.Text.Trim(), out floorRate);
                        Int64.TryParse(floorDetailIDLV.Text.Trim(), out floorDetailID);

                        PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity = FCCPRMBOQFloorDetail.GetFacadeCreate().GetByID(floorDetailID);
                        pRMBOQFloorDetailEntity.Qty = newQty;
                        pRMBOQFloorDetailEntity.Rate = floorRate;
                        pRMBOQFloorDetailEntity.Remarks = txtRemarksLV.Text;
                        pRMBOQFloorDetailEntity.EntryDate = System.DateTime.Now;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQFloorDetailEntity.FLD_NAME_BOQFloorDetailID, floorDetailID.ToString(), SQLMatchType.Equal);

                        FCCPRMBOQFloorDetail.GetFacadeCreate().Update(pRMBOQFloorDetailEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                        Totalqty += newQty;
                        totalRate += floorRate;
                        count++;
                    }

                    avgRate = totalRate / count;
                    avgTotalQty = Totalqty / count;

                   #region Update Project Cost Qty

                    String fe_BOQDetail = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQDetailID, _CurrentBOQDetailIDPopup.ToString(), SQLMatchType.Equal);
                    PRMBOQDetailEntity prmBOQDetailEntity = FCCPRMBOQDetail.GetFacadeCreate().GetByID(_CurrentBOQDetailIDPopup);
                    prmBOQDetailEntity.TotalQty = Totalqty;

                    FCCPRMBOQDetail.GetFacadeCreate().Update(prmBOQDetailEntity, fe_BOQDetail, DatabaseOperationType.Update, TransactionRequired.No);

                    IList<ListViewDataItem> listPRMBOQDetail = lvPRMBOQDetail.Items;

                    if (listPRMBOQDetail != null && listPRMBOQDetail.Count > 0)
                    {
                        Int32 tempDataItemIndex = 0;

                        foreach (ListViewDataItem lvdi in listPRMBOQDetail)
                        {
                            DataKey currentDataKey = lvPRMBOQDetail.DataKeys[tempDataItemIndex++];
                            Int64 intBOQDetailID = (Int64)currentDataKey["BOQDetailID"];

                            if (_CurrentBOQDetailIDPopup == intBOQDetailID)
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

        private void UpdatePriceInfo()
        {
            String fe = String.Empty;
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_ItemID, _CurrentItemID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQID, this._BOQID.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            IList<PRMBOQDetailEntity> bOQDetailList = FCCPRMBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (bOQDetailList != null && bOQDetailList.Count > 0)
            {
                PRMBOQDetailEntity prmBOQDetailent = bOQDetailList[0];
                prmBOQDetailent.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                prmBOQDetailent.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
                prmBOQDetailent.RegionID = Int64.Parse(ddlOriginRegionID.SelectedValue);
                prmBOQDetailent.CountryID = Int64.Parse(ddlOriginCountryID.SelectedValue);
                GetCurrentPrice();
                prmBOQDetailent.Rate = Decimal.Parse(this.txtPrice.Text.ToString());
                FCCPRMBOQDetail.GetFacadeCreate().Update(prmBOQDetailent, fe, DatabaseOperationType.Update, TransactionRequired.No);

                 IList<ListViewDataItem> list = lvPRMBOQDetail.Items;

                 if (list != null && list.Count > 0)
                 {
                     Int32 tempDataItemIndex = 0;

                     foreach (ListViewDataItem lvdi in list)
                     {
                         DataKey currentDataKey = lvPRMBOQDetail.DataKeys[tempDataItemIndex++];
                         Int64 intBOQDetailID = (Int64)currentDataKey["BOQDetailID"];

                         if (bOQDetailList[0].BOQDetailID == intBOQDetailID)
                         {
                             TextBox txtRateLV = (TextBox)lvdi.FindControl("txtRateLV");
                             txtRateLV.Text = prmBOQDetailent.Rate.ToString();
                         }
                     }
                 }

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

        protected void lvPRMBOQDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                PRMBOQDetail_CustomEntity ent = (PRMBOQDetail_CustomEntity)dataItem.DataItem;

                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQFloorDetailEntity.FLD_NAME_BOQDetailID, ent.BOQDetailID.ToString(), SQLMatchType.Equal);
                IList<PRMBOQFloorDetailEntity> lst = FCCPRMBOQFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    LinkButton btnAdditionalQty = (LinkButton)e.Item.FindControl("btnAdditionalQty");
                    btnAdditionalQty.Visible = false;
                }
            }
        }

        protected void lvPRMBOQDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            #region Modify Qty

            if (e.CommandName == "ModifyQty")
            {
                Int64 ItemID;
                
                Int64.TryParse(e.CommandArgument.ToString(), out ItemID);
                Label lblBOQDetailLV=(Label)e.Item.FindControl("lblBOQDetailIDLV");
                TextBox txtRateLV = (TextBox)e.Item.FindControl("txtRateLV");

                Int64 BOQDetailID = Int64.Parse(lblBOQDetailLV.Text);
                _CurrentBOQDetailIDPopup = BOQDetailID;

                if (ItemID > 0)
                {
                    _CurrentItemID = ItemID;
                    this.lblItemName.Text = ((Label)e.Item.FindControl("lblItemNameLV")).Text;

                    PRMBOQDetailEntity bOQDetailEntity = FCCPRMBOQDetail.GetFacadeCreate().GetByID(BOQDetailID);

                    if (bOQDetailEntity != null && bOQDetailEntity.BOQDetailID > 0)
                    {
                        
                        String fe3 = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                        IList<BDProjectFloorEntity> bDProjectFloorList = FCCBDProjectFloor.GetFacadeCreate().GetIL(null, null, String.Empty, fe3, DatabaseOperationType.LoadWithFilterExpression);

                        if (bDProjectFloorList != null && bDProjectFloorList.Count > 0)
                        {

                            foreach (BDProjectFloorEntity bdProjectfloorent in bDProjectFloorList)
                            {
                                String fe4 = String.Empty;
                                String feFloorDetail1 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQFloorDetailEntity.FLD_NAME_ProjectFloorID, bdProjectfloorent.ProjectFloorID.ToString(), SQLMatchType.Equal);
                                String feFloorDetail2 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQFloorDetailEntity.FLD_NAME_BOQDetailID, BOQDetailID.ToString(), SQLMatchType.Equal);
                                fe4 = SqlExpressionBuilder.PrepareFilterExpression(feFloorDetail1, SQLJoinType.AND, feFloorDetail2);

                                IList<PRMBOQFloorDetailEntity> list = FCCPRMBOQFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe4, DatabaseOperationType.LoadWithFilterExpression);

                                if (list == null || list.Count <= 0)
                                {
                                    PRMBOQFloorDetailEntity ent = new PRMBOQFloorDetailEntity();
                                    ent.BOQDetailID = Int64.Parse(BOQDetailID.ToString());
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
                                    FCCPRMBOQFloorDetail.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                                }
                            }

                            BindPRMBOQFloorDetailList();

                            this.Panel1_ModalPopupExtender.Show();
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "No Floor Available.", true);
                        }
                    }
                }
            }

            #endregion

            #region Modify Price Info

            if (e.CommandName == "ModifyPrice")
            {
                Int64 ItemID;

                Int64.TryParse(e.CommandArgument.ToString(), out ItemID);

                if (ItemID > 0)
                {
                    MiscUtil.PopulateMDBrandByItemID(ddlBrandID, false, Int64.Parse(ItemID.ToString()));
                    this.lblItemNameModifyPriceLV.Text = ((Label)e.Item.FindControl("lblItemNameLV")).Text;

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

                this.Panel2_ModalPopupExtender.Show();
            }

            if (e.CommandName == "AdditionalQty")
            {
                Int64 boqDetailID;

                Int64.TryParse(e.CommandArgument.ToString(), out boqDetailID);

                if (boqDetailID > 0)
                {
                    _CurrentBOQDetailIDPopup = boqDetailID;

                    this.ModalPopupExtender1.Show();
                }
            }

            #endregion
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsPRMBOQDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            if (e.ExecutingSelectCount == false && e.Arguments.SortExpression==String.Empty)
            {
                UpdateBOQInfo();
            }

            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMBOQDetail." + PRMBOQEntity.FLD_NAME_BOQID, _BOQID.ToString(), SQLMatchType.Equal);

            if (chbxFilter.Checked)
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("MDItem.ItemName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
            }
            
            e.InputParameters["filterExpression"] = fe;
        }

        protected void odsPRMBOQFloorDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe=String.Empty;

            if (_CurrentBOQDetailIDPopup > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("PRMBOQFloorDetail." + PRMBOQFloorDetailEntity.FLD_NAME_BOQDetailID, _CurrentBOQDetailIDPopup.ToString(), SQLMatchType.Equal);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateBOQInfo();
        }

        protected void lnkSavePopup_Click(object sender, EventArgs e)
        {
            UpdateBOQFloorDetail();
        }

        protected void btnPnlPriceUpdatePopup_Click(object sender, EventArgs e)
        {
            UpdatePriceInfo();
        }

        protected void lnkGetPrice_OnClick(object sender, EventArgs e)
        {
            this.Panel2_ModalPopupExtender.Show();
            GetCurrentPrice();
        }

        protected void btnPnlSaveAdditionalQty_Click(object sender, EventArgs e)
        {
            PRMBOQDetailEntity pRMBOQDetailEntity = FCCPRMBOQDetail.GetFacadeCreate().GetByID(_CurrentBOQDetailIDPopup);

            if (pRMBOQDetailEntity != null && pRMBOQDetailEntity.BOQDetailID > 0)
            {
                 Decimal additionalQty=0;
                Decimal.TryParse(txtQty.Text.Trim().ToString(),out additionalQty);

                PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity = new PRMAvailableBOQQtyForRequisitionEntity();

                pRMAvailableBOQQtyForRequisitionEntity.IsBOQ = true;
                pRMAvailableBOQQtyForRequisitionEntity.PreBOQOrBOQDetailID = _CurrentBOQDetailIDPopup;
                pRMAvailableBOQQtyForRequisitionEntity.ItemID = pRMBOQDetailEntity.ItemID;
                pRMAvailableBOQQtyForRequisitionEntity.Qty = additionalQty;
                pRMAvailableBOQQtyForRequisitionEntity.CreateDate = DateTime.Now;
                pRMAvailableBOQQtyForRequisitionEntity.CreatedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                PRMBOQEntity pRMBOQEntity = FCCPRMBOQ.GetFacadeCreate().GetByID(pRMBOQDetailEntity.BOQID);
                pRMAvailableBOQQtyForRequisitionEntity.ProjectID = pRMBOQEntity.ProjectID;

                Int64 result = -1;
                result = FCCPRMAvailableBOQQtyForRequisition.GetFacadeCreate().Add(pRMAvailableBOQQtyForRequisitionEntity, DatabaseOperationType.Add, TransactionRequired.No);

                if (result > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQDetailID, _CurrentBOQDetailIDPopup.ToString(), SQLMatchType.Equal);

                    pRMBOQDetailEntity.TotalQty = pRMBOQDetailEntity.TotalQty + additionalQty;

                    FCCPRMBOQDetail.GetFacadeCreate().Update(pRMBOQDetailEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                    IList<ListViewDataItem> list = lvPRMBOQDetail.Items;

                    if (list != null && list.Count > 0)
                    {
                        Int32 tempDataItemIndex = 0;

                        foreach (ListViewDataItem lvdi in list)
                        {
                            DataKey currentDataKey = lvPRMBOQDetail.DataKeys[tempDataItemIndex++];
                            Int64 intBOQDetailID = (Int64)currentDataKey["BOQDetailID"];

                            if (_CurrentBOQDetailIDPopup == intBOQDetailID)
                            {
                                TextBox txtTotalQtyLV = (TextBox)lvdi.FindControl("txtTotalQtyLV");
                                txtTotalQtyLV.Text = pRMBOQDetailEntity.TotalQty.ToString();
                            }
                        }
                    }

                    BindPRMBOQDetailList();

                    #region BOQ Floor Detail

                    String fe_projectFloor = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQFloorDetailEntity.FLD_NAME_BOQDetailID, _CurrentBOQDetailIDPopup.ToString(), SQLMatchType.Equal);
                    IList<PRMBOQFloorDetailEntity> lstPRMBOQFloorDetail = FCCPRMBOQFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_projectFloor, DatabaseOperationType.LoadWithFilterExpression);

                    if (lstPRMBOQFloorDetail != null && lstPRMBOQFloorDetail.Count > 0)
                    {
                        Int64 totalfloorCount = lstPRMBOQFloorDetail.Count;
                        Decimal avgQty = pRMBOQDetailEntity.TotalQty / totalfloorCount;

                        foreach (PRMBOQFloorDetailEntity ent in lstPRMBOQFloorDetail)
                        {
                            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQFloorDetailEntity.FLD_NAME_BOQFloorDetailID, ent.BOQFloorDetailID.ToString(), SQLMatchType.Equal);
                            ent.Qty = avgQty;
                            FCCPRMBOQFloorDetail.GetFacadeCreate().Update(ent, fe1, DatabaseOperationType.Update, TransactionRequired.No);
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
            this.Panel2_ModalPopupExtender.Show();
            BuildCountryDropdownByRegion();
        }

        protected void ddlBrandID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Panel2_ModalPopupExtender.Show();
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
