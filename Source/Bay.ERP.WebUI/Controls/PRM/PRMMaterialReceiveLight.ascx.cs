// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Nov-2012, 09:57:55




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class PRMMaterialReceiveLightControl : BaseControl
    {       
        #region Properties

        public Int64 _MaterialReceiveID
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

        public PRMMaterialReceiveEntity _PRMMaterialReceiveEntity
        {
            get
            {
                PRMMaterialReceiveEntity entity = new PRMMaterialReceiveEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMMaterialReceiveEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMMaterialReceiveEntity CurrentPRMMaterialReceiveEntity
        {
            get
            {
                if (_MaterialReceiveID > 0)
                {
                    if (_PRMMaterialReceiveEntity.MaterialReceiveID != _MaterialReceiveID)
                    {
                        _PRMMaterialReceiveEntity = FCCPRMMaterialReceive.GetFacadeCreate().GetByID(_MaterialReceiveID);
                    }
                }

                return _PRMMaterialReceiveEntity;
            }
            set
            {
                _PRMMaterialReceiveEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulatePRMSupplier(ddlSupplierID, false);
            MiscUtil.PopulatePRMWorkOrder(ddlWorkOrderID, true);
            MiscUtil.PopulateMDItem(ddlRequisitionItemID, false);
            MiscUtil.PopulateMDRegion(ddlRegionID, false);

            BuildBrandByItem();
            BuildCountryDropdownByRegion();
        }

        private void PrepareValidator()
        {
        }

        private void BuildBrandByItem()
        {
            if (ddlRequisitionItemID.SelectedValue != "0"&& ddlRequisitionItemID.Items.Count > 0)
            {
                MiscUtil.PopulateMDBrandByItemID(ddlBrandID, false, Int64.Parse(ddlRequisitionItemID.SelectedValue));
            }
        }

        private void BuildCountryDropdownByRegion()
        {
            if (ddlRegionID.SelectedValue != "0")
            {
                MiscUtil.PopulateMDCountryByRegionID(ddlCountryID, false, Int64.Parse(ddlRegionID.SelectedValue));

                if (ddlCountryID.Items.Count > 0)
                {
                   // ddlCountryID.SelectedValue = MasterDataConstants.ItemDefaults.DEFAULT_COUNTRY.ToString();
                }
            }
        }

        private void PrepareInitialViewSave()
        {
            BuildDropDownList();

            txtReceiveQty.Text = String.Empty;
            txtChallanNo.Text = String.Empty;
            txtMRRNo.Enabled = false;

            btnSubmit.Text = "Add Item To MRR & Requisition";
            btnAddNew.Visible = false;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtRequisition.Text = String.Empty;
            txtMRRNo.Text = String.Empty;
            txtMRRDate.Text = DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtRemarks.Text = String.Empty;
            txtReceiveQty.Text = String.Empty;
            txtChallanNo.Text = String.Empty;
            txtMRRNo.Enabled = true;

            btnSubmit.Text = "Add Item To MRR & Requisition";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            PRMMaterialReceiveEntity pRMMaterialReceiveEntity = CurrentPRMMaterialReceiveEntity;


            if (!pRMMaterialReceiveEntity.IsNew)
            {
                if (ddlProjectID.Items.Count > 0 && pRMMaterialReceiveEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = pRMMaterialReceiveEntity.ProjectID.ToString();
                }

                if (ddlSupplierID.Items.Count > 0 && pRMMaterialReceiveEntity.SupplierID != null)
                {
                    ddlSupplierID.SelectedValue = pRMMaterialReceiveEntity.SupplierID.ToString();
                }

               //Requisition Login need to implement

                if (ddlWorkOrderID.Items.Count > 0 && pRMMaterialReceiveEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = pRMMaterialReceiveEntity.WorkOrderID.ToString();
                }

                txtMRRNo.Text = pRMMaterialReceiveEntity.MRRNo.ToString();
                txtMRRDate.Text = pRMMaterialReceiveEntity.MRRDate.ToStringDefault();
                txtRemarks.Text = pRMMaterialReceiveEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private PRMMaterialReceiveItemMapEntity BuildPRMMaterialReceiveItemMapEntity(Int64 materialReceiveID,Int64 requisitionItemID)
        {
            PRMMaterialReceiveItemMapEntity pRMMaterialReceiveItemMapEntity = new PRMMaterialReceiveItemMapEntity();

            pRMMaterialReceiveItemMapEntity.MaterialReceiveID = materialReceiveID;
            pRMMaterialReceiveItemMapEntity.RequisitionItemID = requisitionItemID;
          
            if (txtReceiveDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMMaterialReceiveItemMapEntity.ReceiveDate = MiscUtil.ParseToDateTime(txtReceiveDate.Text);
            }

            if (!txtReceiveQty.Text.Trim().IsNullOrEmpty())
            {
                pRMMaterialReceiveItemMapEntity.ReceiveQty = Decimal.Parse(txtReceiveQty.Text.Trim());
            }

            pRMMaterialReceiveItemMapEntity.ChallanNo = txtChallanNo.Text.Trim();

            return pRMMaterialReceiveItemMapEntity;
        }

        private void BindList()
        {
            BindPRMMaterialReceiveList();
        }

        private void BindPRMMaterialReceiveList()
        {
            
        }

        private PRMMaterialReceiveEntity BuildPRMMaterialReceiveEntity()
        {
            PRMMaterialReceiveEntity pRMMaterialReceiveEntity = CurrentPRMMaterialReceiveEntity;

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMMaterialReceiveEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            if (ddlSupplierID.Items.Count > 0)
            {
                if (ddlSupplierID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMMaterialReceiveEntity.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
                }
            }

            if (ddlWorkOrderID.Items.Count > 0)
            {
                if (ddlWorkOrderID.SelectedValue == "0")
                {
                    pRMMaterialReceiveEntity.WorkOrderID = MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER;
                }
                else
                {
                    pRMMaterialReceiveEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                }
            }

            pRMMaterialReceiveEntity.MRRNo = txtMRRNo.Text.Trim();
            if (txtMRRDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMMaterialReceiveEntity.MRRDate = MiscUtil.ParseToDateTime(txtMRRDate.Text);
            }

            pRMMaterialReceiveEntity.Remarks = txtRemarks.Text.Trim();
            pRMMaterialReceiveEntity.MaterialReceiveApprovalStatusID = MasterDataConstants.MDMaterialReceiveApprovalStatus.APPROVED_BL;

            return pRMMaterialReceiveEntity;
        }

        private REQRequisitionEntity BuildREQRequisitionEntity()
        {
            REQRequisitionEntity rEQRequisitionEntity = new REQRequisitionEntity();

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    rEQRequisitionEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            rEQRequisitionEntity.RequisitionNo ="BL-"+ txtRequisition.Text.Trim();
            rEQRequisitionEntity.RequisitionDate = DateTime.Now;
            rEQRequisitionEntity.Remarks = "Automatic Created Requisition (Approved Before ERP System) From MRR.";
            rEQRequisitionEntity.RequisitionStatusID = MasterDataConstants.RequisitionStatus.APPROVED;
            rEQRequisitionEntity.PreparedByMemberID = this.CurrentMember.MemberID;
            return rEQRequisitionEntity;
        }

        private REQRequisitionItemEntity BuildREQRequisitionItemEntity(Int64 requisitionID)
        {
            REQRequisitionItemEntity rEQRequisitionItemEntity = new REQRequisitionItemEntity();

            rEQRequisitionItemEntity.RequisitionID = requisitionID;

            if (ddlRequisitionItemID.SelectedValue != "0" && ddlRequisitionItemID != null)
            {
                rEQRequisitionItemEntity.ItemID = Int64.Parse(ddlRequisitionItemID.SelectedValue);
            }
            rEQRequisitionItemEntity.AccountsCode = "000";//
            if (txtPrice.Text.IsNotNullOrEmpty())
            {
                rEQRequisitionItemEntity.Rate = Decimal.Parse(txtPrice.Text.ToString());// 
            }
            rEQRequisitionItemEntity.TotalRequiredQty = 0;//
            rEQRequisitionItemEntity.PresentRequiredQty = 1; // 
            rEQRequisitionItemEntity.RequiredDate = DateTime.Now;

            if (ddlBrandID.SelectedValue != "0" && ddlBrandID != null)
            {
                rEQRequisitionItemEntity.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
            }
            else
            {
                rEQRequisitionItemEntity.BrandID = MasterDataConstants.ItemDefaults.DEFAULT_BRAD;
            }

            if (ddlSupplierID.SelectedValue != "0" && ddlSupplierID != null)
            {
                rEQRequisitionItemEntity.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
            }
            else
            {
                rEQRequisitionItemEntity.SupplierID = MasterDataConstants.ItemDefaults.DEFAULT_SUPPLIER;
            }

            if (ddlRegionID.SelectedValue != "0" && ddlRegionID != null)
            {
                rEQRequisitionItemEntity.RegionID = Int64.Parse(ddlRegionID.SelectedValue);
            }
            else
            {
                rEQRequisitionItemEntity.RegionID = MasterDataConstants.ItemDefaults.DEFAULT_REGION;
            }

            if (ddlCountryID.SelectedValue != "0" && ddlCountryID != null)
            {
                rEQRequisitionItemEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
            }
            else
            {
                rEQRequisitionItemEntity.CountryID = MasterDataConstants.ItemDefaults.DEFAULT_COUNTRY;
            }

            return rEQRequisitionItemEntity;
        }

        private void SavePRMMaterialReceiveEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMMaterialReceiveEntity pRMMaterialReceiveEntity = BuildPRMMaterialReceiveEntity();

                    #region Requisition

                    String RequisitionNo = String.Empty;

                    if (txtRequisition.Text.IsNotNullOrEmpty())
                    {
                        RequisitionNo ="BL-"+ txtRequisition.Text.ToString();
                    }

                    Int64 resultRequisition = -1;
                    Int64 resultRequisitionItem = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_RequisitionNo, RequisitionNo, SQLMatchType.Equal);
                    IList<REQRequisitionEntity> lstRequisition = FCCREQRequisition.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    REQRequisitionItemEntity rEQRequisitionItemEntity = null;

                    if (lstRequisition != null && lstRequisition.Count > 0)
                    {
                        rEQRequisitionItemEntity = BuildREQRequisitionItemEntity(lstRequisition[0].RequisitionID);
                        pRMMaterialReceiveEntity.RequisitionID = lstRequisition[0].RequisitionID;
                    }
                    else
                    {
                        REQRequisitionEntity rEQRequisitionEntity = BuildREQRequisitionEntity();
                        resultRequisition = FCCREQRequisition.GetFacadeCreate().Add(rEQRequisitionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        pRMMaterialReceiveEntity.RequisitionID = resultRequisition;

                        if (resultRequisition > 0)
                        {
                            rEQRequisitionItemEntity = BuildREQRequisitionItemEntity(resultRequisition);
                        }
                    }

                    if (rEQRequisitionItemEntity != null)
                    {
                       resultRequisitionItem = FCCREQRequisitionItem.GetFacadeCreate().Add(rEQRequisitionItemEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }

                    #endregion

                    #region MRR

                    Int64 resultOne = -1;

                    if (pRMMaterialReceiveEntity.IsNew)
                    {
                        resultOne = FCCPRMMaterialReceive.GetFacadeCreate().Add(pRMMaterialReceiveEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveEntity.FLD_NAME_MaterialReceiveID, pRMMaterialReceiveEntity.MaterialReceiveID.ToString(), SQLMatchType.Equal);
                        resultOne = FCCPRMMaterialReceive.GetFacadeCreate().Update(pRMMaterialReceiveEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    #endregion

                    if (resultOne > 0 && resultRequisitionItem > 0)
                    {

                        #region Material Receive Item Map

                        Int64 resultTwo = -1;

                        PRMMaterialReceiveItemMapEntity pRMMaterialReceiveItemMapEntity = BuildPRMMaterialReceiveItemMapEntity(resultOne, resultRequisitionItem);
                        resultTwo = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().Add(pRMMaterialReceiveItemMapEntity, DatabaseOperationType.Add, TransactionRequired.No);

                        #endregion

                        try
                        {
                            #region Inventory

                            Int64 _employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                            Int64 _projectID = Int64.Parse(ddlProjectID.SelectedValue);

                            INVStoreEntity storeEntity = INVManager.GetDefaultStore(_projectID);
                            Int64 storeID = storeEntity.StoreID;

                            INVStoreUnitEntity storeUnitEntity = INVManager.GetDefaultStoreUnit(storeID);
                            Int64 storeUnitID = storeUnitEntity.StoreUnitID;

                            String fe_requisitionItem = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, resultRequisitionItem.ToString(), SQLMatchType.Equal);
                            IList<REQRequisitionItem_DetailedEntity> lst = FCCREQRequisitionItem_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_requisitionItem);

                            Int64 _itemID = 0;
                            Decimal _rate = 0;
                            Int64 brandID = MasterDataConstants.ItemDefaults.DEFAULT_BRAD;
                            Int64 regionID = MasterDataConstants.ItemDefaults.DEFAULT_REGION;
                            Int64 countryID = MasterDataConstants.ItemDefaults.DEFAULT_COUNTRY;

                            if (lst != null && lst.Count > 0)
                            {
                                _itemID = lst[0].ItemID;
                                brandID = (Int64)lst[0].BrandID;
                                regionID = (Int64)lst[0].RegionID;
                                countryID = (Int64)lst[0].CountryID;
                                _rate = lst[0].Rate;
                            }

                            Boolean invResult = INVManager.AddItemsToStoreUnit(_itemID, brandID, regionID, countryID, "", Int64.Parse(txtReceiveQty.Text.ToString()), MiscUtil.GetLocalIP(), _employeeID, _rate, txtRequisition.Text, ddlWorkOrderID.SelectedItem.Text, resultOne.ToString(), "", Int64.Parse(ddlProjectID.SelectedValue), storeID, storeUnitID);

                            #endregion

                        }
                        catch (Exception ex)
                        {   
                        }

                        _MaterialReceiveID = resultOne;
                        PrepareInitialViewSave();
                        btnAddNew.Visible = true;

                        if (pRMMaterialReceiveEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Material Receive Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Material Receive Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMMaterialReceiveEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Material Receive Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Material Receive Information.", false);
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMMaterialReceiveEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MaterialReceiveID = 0;
            _PRMMaterialReceiveEntity = new PRMMaterialReceiveEntity();
            PrepareInitialView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlRegionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildCountryDropdownByRegion();
        }

        protected void ddlRequisitionItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildBrandByItem();
        }

        #endregion

        #endregion Event
    }
}
