// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class PRMWorkOrderItemMapControl : BaseControl
    {
        #region Extra

        class CustomerComparer : IEqualityComparer<PRMWorkOrderItemFloorDetailEntity>
        {
            public bool Equals(PRMWorkOrderItemFloorDetailEntity x, PRMWorkOrderItemFloorDetailEntity y)
            {
                return (x.WorkOrderItemMapID.Equals(y.WorkOrderItemMapID) && x.ProjectFloorID.Equals(y.ProjectFloorID));
            }

            public int GetHashCode(PRMWorkOrderItemFloorDetailEntity obj)
            {
                return obj.WorkOrderItemMapID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _WorkOrderItemMapID
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

        public PRMWorkOrderItemMapEntity _PRMWorkOrderItemMapEntity
        {
            get
            {
                PRMWorkOrderItemMapEntity entity = new PRMWorkOrderItemMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMWorkOrderItemMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMWorkOrderItemMapEntity CurrentPRMWorkOrderItemMapEntity
        {
            get
            {
                if (_WorkOrderItemMapID > 0)
                {
                    if (_PRMWorkOrderItemMapEntity.WorkOrderItemMapID != _WorkOrderItemMapID)
                    {
                        _PRMWorkOrderItemMapEntity = FCCPRMWorkOrderItemMap.GetFacadeCreate().GetByID(_WorkOrderItemMapID);
                    }
                }

                return _PRMWorkOrderItemMapEntity;
            }
            set
            {
                _PRMWorkOrderItemMapEntity = value;
            }
        }

        public Int64 PRMWorkOrderID
        {
            get
            {
                Int64 _pRMWorkOrderID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_WORKORDER_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_WORKORDER_ID], out _pRMWorkOrderID);
                }

                return _pRMWorkOrderID;
            }
        }

        private PRMWorkOrderEntity CurrentPRMWorkOrderEntity
        {
            get
            {
                PRMWorkOrderEntity pRMWorkOrderEntity = new PRMWorkOrderEntity();

                if (PRMWorkOrderID > 0)
                {
                    pRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(PRMWorkOrderID);
                }

                return pRMWorkOrderEntity??new PRMWorkOrderEntity();
            }
        }

        public String PRMWorkOrderNo
        {
            get
            {
                String _pRMWorkOrderNo = null;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[PRMWorkOrderEntity.FLD_NAME_WorkOrderNo]))
                {
                    _pRMWorkOrderNo = Helper.Url.SecureUrl[PRMWorkOrderEntity.FLD_NAME_WorkOrderNo];
                }

                return _pRMWorkOrderNo;
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

        public Int64 _CurrentWorkOrderItemID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["vs_CurrentWorkOrderItemID"] != null)
                {
                    Int64.TryParse(ViewState["vs_CurrentWorkOrderItemID"].ToString(), out id);
                }

                return id;
            }

            set
            {
                ViewState["vs_CurrentWorkOrderItemID"] = value;
            }
        }

        public Int64 CurrentWorkOrderItemIDPopup
        {
            get
            {
                Int64 id = 0;

                if (ViewState["CurrentWorkOrderItemIDPopup"] != null)
                {
                    Int64.TryParse(ViewState["CurrentWorkOrderItemIDPopup"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["CurrentWorkOrderItemIDPopup"] = value;
            }
        }

        public IList<PRMWorkOrderItemFloorDetailEntity> _PRMWorkOrderItemFloorDetailEntityList
        {
            get
            {
                IList<PRMWorkOrderItemFloorDetailEntity> lst = new List<PRMWorkOrderItemFloorDetailEntity>();

                if (ViewState["vs_CurrentPRMWorkOrderItemFloorDetailEntity"] != null)
                {
                    lst = (IList<PRMWorkOrderItemFloorDetailEntity>)ViewState["vs_CurrentPRMWorkOrderItemFloorDetailEntity"];
                }

                return lst;
            }
            set
            {
                ViewState["vs_CurrentPRMWorkOrderItemFloorDetailEntity"] = value;
            }
        }

        public IList<PRMWorkOrderItemFloorDetailEntity> PRMWorkOrderItemFloorDetailEntityList
        {
            get
            {
                if (CurrentWorkOrderItemIDPopup > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemFloorDetailEntity.FLD_NAME_WorkOrderItemMapID, CurrentWorkOrderItemIDPopup.ToString(), SQLMatchType.Equal);

                    if (_PRMWorkOrderItemFloorDetailEntityList != null && _PRMWorkOrderItemFloorDetailEntityList.Count > 0)
                    {
                        if (_PRMWorkOrderItemFloorDetailEntityList[0].WorkOrderItemMapID != CurrentWorkOrderItemIDPopup)
                        {
                            _PRMWorkOrderItemFloorDetailEntityList = FCCPRMWorkOrderItemFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                        }
                    }
                    else
                    {   
                        _PRMWorkOrderItemFloorDetailEntityList = FCCPRMWorkOrderItemFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                    }
                }
                return _PRMWorkOrderItemFloorDetailEntityList;
            }
            set
            {
                _PRMWorkOrderItemFloorDetailEntityList = value;
            }
        }

        public IList<PRMWorkOrderItemFloorDetailEntity> mappedItemsFromDB
        {
            get
            {
                return (IList<PRMWorkOrderItemFloorDetailEntity>)ViewState["vs_mappedItemsFromDB"];
            }
            set
            {
                ViewState["vs_mappedItemsFromDB"] = value;
            }
        }

        public IList<PRMWorkOrderItemFloorDetailEntity> populatedCheckedItems
        {
            get
            {
                return (IList<PRMWorkOrderItemFloorDetailEntity>)ViewState["vs_populatedCheckedItems"];
            }
            set
            {
                ViewState["vs_populatedCheckedItems"] = value;
            }
        }

        public Int64 _RequisitionItemMapIDLV
        {
            get
            {
                Int64 id = 0;

                if (ViewState["_RequisitionItemMapIDLV"] != null)
                {
                    Int64.TryParse(ViewState["_RequisitionItemMapIDLV"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["_RequisitionItemMapIDLV"] = value;
            }
        }

        public Int64 _RequisitionIDLV
        {
            get
            {
                Int64 id = 0;

                if (ViewState["RequisitionIDLV"] != null)
                {
                    Int64.TryParse(ViewState["RequisitionIDLV"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["RequisitionIDLV"] = value;
            }
        }
   

        #endregion

        #region Properties PopUp

        public Int64 _WorkOrderItemDetailID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ItemDetailID"] != null)
                {
                    Int64.TryParse(ViewState["ItemDetailID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ItemDetailID"] = value;
            }
        }

        public PRMWorkOrderItemDetailEntity _PRMWorkOrderItemDetailEntity
        {
            get
            {
                PRMWorkOrderItemDetailEntity entity = new PRMWorkOrderItemDetailEntity();

                if (ViewState["CurrentWorkOrderItemDetailEntity"] != null)
                {
                    entity = (PRMWorkOrderItemDetailEntity)ViewState["CurrentWorkOrderItemDetailEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentWorkOrderItemDetailEntity"] = value;
            }
        }

        private PRMWorkOrderItemDetailEntity CurrentPRMWorkOrderItemDetailEntity
        {
            get
            {
                if (_WorkOrderItemDetailID > 0)
                {
                    if (_PRMWorkOrderItemDetailEntity.WorkOrderItemDetailID != _WorkOrderItemDetailID)
                    {
                        _PRMWorkOrderItemDetailEntity = FCCPRMWorkOrderItemDetail.GetFacadeCreate().GetByID(_WorkOrderItemDetailID);
                    }
                }

                return _PRMWorkOrderItemDetailEntity;
            }
            set
            {
                _PRMWorkOrderItemDetailEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateREQApprovedRequisition(ddlRequisitionID, false);
            MiscUtil.PopulateMDWorkOrderStatus(ddlWorkOrderStatusID, false);
            BuildREQRequisitionItem();
        }

        private void BuildREQRequisitionItem()
        {
            if (ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
            {
                MiscUtil.PopulateREQRequisitionItemRequisitionID(ddlRequisitionItemID, false,Int64.Parse(ddlRequisitionID.SelectedValue));

                String filterExpression = String.Empty;
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionItem_CustomEntity.FLD_NAME_RequisitionID, ddlRequisitionID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItem_CustomEntity.FLD_NAME_RequisitionItemID, ddlRequisitionItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                filterExpression = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                IList<REQRequisitionItem_CustomEntity> requisitonItemList = FCCREQRequisitionItem_Custom.GetFacadeCreate().GetIL(filterExpression);

                if(requisitonItemList != null && requisitonItemList.Count > 0)
                {  
                    txtRate.Text = requisitonItemList[0].Rate.ToString();
                    txtRequiredQty.Text = requisitonItemList[0].PresentRequiredQty.ToString();
                    ViewState["RequisitonRate"] = requisitonItemList[0].Rate.ToString();

                }
            }

            else
            {
                ViewState["RequisitonRate"] = null;
            }
        }

        private void BuildREQRequisitionItemRate()
        {
            if (ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
            {
                // MiscUtil.PopulateREQRequisitionItemRequisitionID(ddlRequisitionItemID, false, Int64.Parse(ddlRequisitionID.SelectedValue));

                String filterExpression = String.Empty;
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionItem_CustomEntity.FLD_NAME_RequisitionID, ddlRequisitionID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItem_CustomEntity.FLD_NAME_RequisitionItemID, ddlRequisitionItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                filterExpression = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                IList<REQRequisitionItem_CustomEntity> requisitonItemList = FCCREQRequisitionItem_Custom.GetFacadeCreate().GetIL(filterExpression);

                if (requisitonItemList != null && requisitonItemList.Count > 0)
                {
                    txtRate.Text = requisitonItemList[0].Rate.ToString();
                    txtRequiredQty.Text = requisitonItemList[0].PresentRequiredQty.ToString();
                    ViewState["RequisitonRate"] = requisitonItemList[0].Rate.ToString();

                }
            }

            else
            {
                ViewState["RequisitonRate"] = null;
            }
        }

        private Boolean ValidationInput()
        {
            if (txtRate.Text.IsNotNullOrEmpty())
            {
                Double requisitionRate = 0, workOrderRate,workOrderRateWithPercentage;
                Double percentageRate;

                if (ViewState["RequisitonRate"] != null)
                {
                    Double.TryParse(ViewState["RequisitonRate"].ToString(), out requisitionRate);
                    if (requisitionRate == 0)
                    {
                        requisitionRate = 1;
                    }
                }
                Double.TryParse(txtRate.Text, out workOrderRate);

                percentageRate =(Double)requisitionRate * .1;
                workOrderRateWithPercentage =(Double)(requisitionRate + percentageRate);

                if (workOrderRateWithPercentage < workOrderRate)
                {
                    MiscUtil.ShowMessage(lblMessage, "Item Rate Will be allowed Only 10% After Requisition Rate.", true);
                    return false;
                }
            }

            return true;
        }

        private void PrepareInitialView()
        {
            txtRequiredQty.Text = String.Empty;
            txtRate.Text = String.Empty;
            txtDeliveryAddress.Text = String.Empty;
            txtItemDescription.Text = String.Empty;
            lblWorkOrderNo.Text = PRMWorkOrderNo.ToString();

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;

            BuildDropDownList();


            #region Approval Process

            //EnableDisableApprovalProcessCheck();

            #endregion

            mappedItemsFromDB = new List<PRMWorkOrderItemFloorDetailEntity>();
            populatedCheckedItems = new List<PRMWorkOrderItemFloorDetailEntity>();
        }

        //private void EnableDisableApprovalProcessCheck()
        //{
        //    APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.WORK_ORDER, PRMWorkOrderID);

        //    if (aPApprovalProcessEntity.APApprovalProcessID > 0)
        //    {
        //        btnInitiateApprovalProcess.Enabled = false;
        //    }
        //    else
        //    {
        //        btnInitiateApprovalProcess.Enabled = true;
        //    }
        //}

        private void PrepareEditView()
        {
            PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity = CurrentPRMWorkOrderItemMapEntity;


            if (!pRMWorkOrderItemMapEntity.IsNew)
            {
                lblWorkOrderNo.Text = PRMWorkOrderNo.ToString();

                if (ddlRequisitionID.Items.Count > 0 && pRMWorkOrderItemMapEntity.RequisitionID != null)
                {
                    ddlRequisitionID.SelectedValue = pRMWorkOrderItemMapEntity.RequisitionID.ToString();
                }

                if (ddlRequisitionItemID.Items.Count > 0 && pRMWorkOrderItemMapEntity.RequisitionItemID != null)
                {
                    ddlRequisitionItemID.SelectedValue = pRMWorkOrderItemMapEntity.RequisitionItemID.ToString();
                }

                txtRequiredQty.Text = pRMWorkOrderItemMapEntity.RequiredQty.ToString();
                txtRate.Text = pRMWorkOrderItemMapEntity.Rate.ToString();
                txtDeliveryAddress.Text = pRMWorkOrderItemMapEntity.DeliveryAddress.ToString();
                txtItemDescription.Text = pRMWorkOrderItemMapEntity.Description.ToString();
                if (ddlWorkOrderStatusID.Items.Count > 0 && pRMWorkOrderItemMapEntity.WorkOrderStatusID != null)
                {
                    ddlWorkOrderStatusID.SelectedValue = pRMWorkOrderItemMapEntity.WorkOrderStatusID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindPRMWorkOrderItemMapList();
        }

        private void BindPRMWorkOrderItemMapList()
        {
            lvPRMWorkOrderItemMap.DataBind();
        }

        private PRMWorkOrderItemMapEntity BuildPRMWorkOrderItemMapEntity()
        {
            PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity = CurrentPRMWorkOrderItemMapEntity;
            
            pRMWorkOrderItemMapEntity.WorkOrderID = PRMWorkOrderID;
            
            if (ddlRequisitionID.Items.Count > 0)
            {
                if (ddlRequisitionID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMWorkOrderItemMapEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                }
            }

            if (ddlRequisitionItemID.Items.Count > 0)
            {
                if (ddlRequisitionItemID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMWorkOrderItemMapEntity.RequisitionItemID = Int64.Parse(ddlRequisitionItemID.SelectedValue);
                }
            }

            if (!txtRequiredQty.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderItemMapEntity.RequiredQty = Decimal.Parse(txtRequiredQty.Text.Trim());
            }

            if (!txtRate.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderItemMapEntity.Rate = Decimal.Parse(txtRate.Text.Trim());
            }

            pRMWorkOrderItemMapEntity.DeliveryAddress = txtDeliveryAddress.Text.Trim();
            pRMWorkOrderItemMapEntity.Description = txtItemDescription.Text.Trim();
            if (ddlWorkOrderStatusID.Items.Count > 0)
            {
                if (ddlWorkOrderStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMWorkOrderItemMapEntity.WorkOrderStatusID = Int64.Parse(ddlWorkOrderStatusID.SelectedValue);
                }
            }


            return pRMWorkOrderItemMapEntity;
        }

        private void SavePRMWorkOrderItemMapEntity()
        {
            if (ValidationInput())
            {
                if (IsValid)
                {
                    try
                    {
                        PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity = BuildPRMWorkOrderItemMapEntity();

                        Int64 result = -1;

                        if (pRMWorkOrderItemMapEntity.IsNew)
                        {
                            result = FCCPRMWorkOrderItemMap.GetFacadeCreate().Add(pRMWorkOrderItemMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderItemMapID, pRMWorkOrderItemMapEntity.WorkOrderItemMapID.ToString(), SQLMatchType.Equal);
                            result = FCCPRMWorkOrderItemMap.GetFacadeCreate().Update(pRMWorkOrderItemMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        }

                        if (result > 0)
                        {
                            _WorkOrderItemMapID = 0;
                            _PRMWorkOrderItemMapEntity = new PRMWorkOrderItemMapEntity();
                            PrepareInitialView();
                            BindPRMWorkOrderItemMapList();

                            if (pRMWorkOrderItemMapEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Work Order Item Map Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Work Order Item Map Information has been updated successfully.", false);
                            }
                        }
                        else
                        {
                            if (pRMWorkOrderItemMapEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Work Order Item Map Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Work Order Item Map Information.", false);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion

        #region Methods PopUp

        private void BuildDropDownListPopup()
        {
            MiscUtil.PopulateMDUnit(ddlUnitID, true);
        }

        private void PrepareInitialViewPopup()
        {
            BuildDropDownListPopup();

            txtDescription.Text = String.Empty;
            txtPopupRate.Text = String.Empty;
            txtQty.Text = String.Empty;

            btnAddPopup.Text = "Add";
            btnAddNewPopup.Visible = false;
        }

        private void PrepareEditViewPopup()
        {
            PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = CurrentPRMWorkOrderItemDetailEntity;


            if (!pRMWorkOrderItemDetailEntity.IsNew)
            {

                txtDescription.Text = pRMWorkOrderItemDetailEntity.Description.ToString();
                if (ddlUnitID.Items.Count > 0 && pRMWorkOrderItemDetailEntity.UnitID != null)
                {
                    ddlUnitID.SelectedValue = pRMWorkOrderItemDetailEntity.UnitID.ToString();
                }

                txtPopupRate.Text = pRMWorkOrderItemDetailEntity.Rate.ToString();
                txtQty.Text = pRMWorkOrderItemDetailEntity.Qty.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindListPopup()
        {
            BindPRMWorkOrderItemDetailList();
        }

        private void BindPRMWorkOrderItemDetailList()
        {
            lvPRMWorkOrderItemDetail.DataBind();
        }

        private PRMWorkOrderItemDetailEntity BuildPRMWorkOrderItemDetailEntity()
        {
            PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = CurrentPRMWorkOrderItemDetailEntity;

            pRMWorkOrderItemDetailEntity.WorkOrderItemMapID = _WorkOrderItemMapID;
            pRMWorkOrderItemDetailEntity.Description = txtDescription.Text.Trim();
            if (ddlUnitID.Items.Count > 0)
            {
                if (ddlUnitID.SelectedValue == "0")
                {
                    pRMWorkOrderItemDetailEntity.UnitID = null;
                }
                else
                {
                    pRMWorkOrderItemDetailEntity.UnitID = Int64.Parse(ddlUnitID.SelectedValue);
                }
            }

            if (!txtPopupRate.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderItemDetailEntity.Rate = Decimal.Parse(txtPopupRate.Text.Trim());
            }

            if (!txtQty.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderItemDetailEntity.Qty = Decimal.Parse(txtQty.Text.Trim());
            }


            return pRMWorkOrderItemDetailEntity;
        }

        private void SavePRMWorkOrderItemDetailEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = BuildPRMWorkOrderItemDetailEntity();

                    Int64 result = -1;

                    if (pRMWorkOrderItemDetailEntity.IsNew)
                    {
                        result = FCCPRMWorkOrderItemDetail.GetFacadeCreate().Add(pRMWorkOrderItemDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemDetailEntity.FLD_NAME_WorkOrderItemDetailID, pRMWorkOrderItemDetailEntity.WorkOrderItemDetailID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMWorkOrderItemDetail.GetFacadeCreate().Update(pRMWorkOrderItemDetailEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _WorkOrderItemDetailID = 0;
                        _PRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();
                        PrepareInitialViewPopup();
                        BindPRMWorkOrderItemDetailList();

                        if (pRMWorkOrderItemDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Work Order Item Detail Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Work Order Item Detail Information has been updated successfully.", false);
                        }

                        this.Panel1_ModalPopupExtender.Show();
                    }
                    else
                    {
                        if (pRMWorkOrderItemDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Work Order Item Detail Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Work Order Item Detail Information.", false);
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
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvREQRequisitionItemFloorDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                CheckBox chbxSelectLV = (CheckBox)e.Item.FindControl("chbxSelectLV");
                Label lblProjectFloorIDLV = (Label)e.Item.FindControl("lblProjectFloorIDLV");
                TextBox txtQtyLV = (TextBox)e.Item.FindControl("txtQtyLV");
                TextBox txtRateLV = (TextBox)e.Item.FindControl("txtRateLV");
                TextBox txtRemarksLV = (TextBox)e.Item.FindControl("txtRemarksLV");


                if (CurrentPRMWorkOrderEntity.WorkOrderStatusID== MasterDataConstants.WorkOrderStatus.APPROVED)
                {
                    chbxSelectLV.Enabled = false;
                }


                IList<PRMWorkOrderItemFloorDetailEntity> lst = PRMWorkOrderItemFloorDetailEntityList;

                if (lst != null && lst.Count > 0)
                {
                    var result = (from s in lst
                                  where s.ProjectFloorID.ToString() == lblProjectFloorIDLV.Text.Trim()
                                  select s).FirstOrDefault();

                    if (result != null)
                    {
                        chbxSelectLV.Checked = true;
                        txtQtyLV.Text = result.Qty.ToString();
                        txtRateLV.Text = result.Rate.ToString();
                        txtRemarksLV.Text = result.Remarks;
                    }
                    else
                    {
                        chbxSelectLV.Checked = false;
                    }
                }

                else
                {
                    chbxSelectLV.Checked = false;
                }
            }
        }

        protected void lvPRMWorkOrderItemMap_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                PRMWorkOrderItemMap_DetailedEntity ent = (PRMWorkOrderItemMap_DetailedEntity)dataItem.DataItem;

                HyperLink hypRequisitionNoLV = (HyperLink)e.Item.FindControl("hypRequisitionNoLV");
                hypRequisitionNoLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.REQUISITION_REPORT, UrlConstants.REQUISITION_ID, ent.RequisitionID.ToString()).ToString();
                hypRequisitionNoLV.Target = "_blank";
            }
        }

        protected void lvPRMWorkOrderItemMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 WorkOrderItemMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out WorkOrderItemMapID);

            #region Work Order Item Detail Popup

            if (e.CommandName == "ItemDetail")
            {
                _WorkOrderItemMapID = WorkOrderItemMapID;
                PrepareInitialViewPopup();
                BindPRMWorkOrderItemDetailList();
                this.Panel1_ModalPopupExtender.Show();
            }

            #endregion

            if (WorkOrderItemMapID > 0)
            {
                if (e.CommandName == "FloorWiseRateAndQty")
                {
                    CurrentWorkOrderItemIDPopup = WorkOrderItemMapID;

                    Label lblItemLV = (Label)e.Item.FindControl("lblItemLV");
                    Label lblRequisitionIDLV = (Label)e.Item.FindControl("lblRequisitionIDLV");
                    Label lblRequisitionItemIDLV = (Label)e.Item.FindControl("lblRequisitionItemIDLV");
                    Label lblWorkOrderItemMapIDLV = (Label)e.Item.FindControl("lblWorkOrderItemMapIDLV");

                    Label lblProjectIDLV = (Label)e.Item.FindControl("lblProjectIDLV");
                    Label lblWorkOrderIDLV = (Label)e.Item.FindControl("lblWorkOrderIDLV");

                    Int64 itemID;
                    Int64.TryParse(lblItemLV.Text.Trim(), out itemID);

                    _RequisitionItemMapIDLV=Int64.Parse(lblRequisitionItemIDLV.Text.ToString());
                    _RequisitionIDLV = Int64.Parse(lblRequisitionIDLV.Text.ToString());
                    

                    String fe_floor = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorEntity.FLD_NAME_ProjectID, lblProjectIDLV.Text.ToString(), SQLMatchType.Equal);
                    IList<BDProjectFloorEntity> lstBDProjectFloor = FCCBDProjectFloor.GetFacadeCreate().GetIL(null, null, String.Empty, fe_floor, DatabaseOperationType.LoadWithFilterExpression);

                    if (lstBDProjectFloor != null && lstBDProjectFloor.Count > 0)
                    {
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, lblProjectIDLV.Text.ToString(), SQLMatchType.Equal);
                        IList<PRMPreBOQEntity> preBOQList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                        if (preBOQList != null && preBOQList.Count > 0)
                        {
                            Int64 preBOQID = preBOQList[0].PreBOQID;

                            switch (preBOQList[0].IsLocked)
                            {
                                case true:

                                    #region GET Item From BOQ

                                    String fe_boq = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                                    IList<PRMBOQEntity> lstPRMBOQ = FCCPRMBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe_boq, DatabaseOperationType.LoadWithFilterExpression);

                                    if (lstPRMBOQ != null && lstPRMBOQ.Count > 0)
                                    {
                                        String fe_BOQDetail1 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQID, lstPRMBOQ[0].BOQID.ToString(), SQLMatchType.Equal);
                                        String fe_BOQDetail2 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_ItemID, itemID.ToString(), SQLMatchType.Equal);

                                        String fe_BOQDetail = SqlExpressionBuilder.PrepareFilterExpression(fe_BOQDetail1, SQLJoinType.AND, fe_BOQDetail2);

                                        IList<PRMBOQDetailEntity> lstPRMBOQDetail = FCCPRMBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_BOQDetail, DatabaseOperationType.LoadWithFilterExpression);

                                        if (lstPRMBOQDetail != null && lstPRMBOQDetail.Count > 0)
                                        {
                                            String fe_floorDetail = SqlExpressionBuilder.PrepareFilterExpression("PRMBOQFloorDetail." + PRMBOQFloorDetailEntity.FLD_NAME_BOQDetailID, lstPRMBOQDetail[0].BOQDetailID.ToString(), SQLMatchType.Equal);
                                            IList<PRMBOQFloorDetail_DetailedEntity> lstPRMPreBOQFloorDetail = FCCPRMBOQFloorDetail_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe_floorDetail);

                                            lvREQRequisitionItemFloorDetail.DataSource = lstPRMPreBOQFloorDetail;
                                            lvREQRequisitionItemFloorDetail.DataBind();
                                        }
                                    }

                                    #endregion

                                    break;

                                case false:

                                    #region Get Item From Pre-BOQ

                                    String fe_preBOQDetail1 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                                    String fe_preBOQDetail2 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_ItemID, itemID.ToString(), SQLMatchType.Equal);

                                    String fe_preBOQDetail = SqlExpressionBuilder.PrepareFilterExpression(fe_preBOQDetail1, SQLJoinType.AND, fe_preBOQDetail2);

                                    IList<PRMPreBOQDetailEntity> lstPRMPreBOQDetail = FCCPRMPreBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_preBOQDetail, DatabaseOperationType.LoadWithFilterExpression);

                                    if (lstPRMPreBOQDetail != null && lstPRMPreBOQDetail.Count > 0)
                                    {
                                        String fe_floorDetail = SqlExpressionBuilder.PrepareFilterExpression("PRMPreBOQFloorDetail." + PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQDetailID, lstPRMPreBOQDetail[0].PreBOQDetailID.ToString(), SQLMatchType.Equal);
                                        IList<PRMPreBOQFloorDetail_DetailedEntity> lstPRMPreBOQFloorDetail = FCCPRMPreBOQFloorDetail_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_floorDetail);

                                        lvREQRequisitionItemFloorDetail.DataSource = lstPRMPreBOQFloorDetail;
                                        lvREQRequisitionItemFloorDetail.DataBind();
                                    }

                                    #endregion

                                    break;

                                default:
                                    break;
                            }
                        }
                    }

                    Label lblItemNameLV = (Label)e.Item.FindControl("lblItemNameLV");

                    //BindREQRequisitionFloorDetailList();
                    //lblFloorWiseItemName.Text = lblItemNameLV.Text.ToString();
                    this.ModalPopupExtender2.Show();

                    if (lvREQRequisitionItemFloorDetail.DataSource != null)
                    {
                        btnFloorPopupSave.Enabled = true;
                    }
                    else
                    {
                        btnFloorPopupSave.Enabled = false;
                    }

                    if (CurrentPRMWorkOrderEntity.WorkOrderStatusID != MasterDataConstants.WorkOrderStatus.APPROVED)
                    {
                        lblLockMessage.Visible = false;
                    }

                    else if (CurrentPRMWorkOrderEntity.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.APPROVED)
                    {
                        btnFloorPopupSave.Enabled = false;
                        lblLockMessage.Visible = true;
                    }
                }

                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _WorkOrderItemMapID = WorkOrderItemMapID;

                    PrepareEditView();
                }

                else if (string.Equals(e.CommandName, "Event"))
                {
                    _WorkOrderItemMapID = WorkOrderItemMapID;

                    Label lblItemNameLV = (Label)e.Item.FindControl("lblItemNameLV");
                    Label lblRequisitionItemIDLV = (Label)e.Item.FindControl("lblRequisitionItemIDLV");
                    CMNEventEntity cMNEventEntity = new CMNEventEntity();
                    
                    cMNEventEntity.EventIdentityCategoryID = MasterDataConstants.CMNMDEventIdentityCategory.EVENT_FROM_WORKORDER;
                    cMNEventEntity.EventCategoryID = MasterDataConstants.CMNMDEventCategory.EVENT_FROM_WORKORDER;
                    cMNEventEntity.ParentEventID = null;
                    cMNEventEntity.ReferenceEventID = null;
                    cMNEventEntity.EventReferenceNo = MasterDataConstants.AutoAssigned.DEFAULT_AUTO_ASSIGNED;
                    cMNEventEntity.Title = lblItemNameLV.Text.ToString();
                    cMNEventEntity.Details = lblItemNameLV.Text.ToString();
                    cMNEventEntity.Location = "";
                    cMNEventEntity.EventLocationCategoryID = MasterDataConstants.MDEventLocationCategory.LOCATION_NOT_AVAILABLE;
                    cMNEventEntity.LocationReferenceID = null;
                    cMNEventEntity.WebsiteURL = String.Empty;
                    cMNEventEntity.TicketSellerURL = String.Empty;
                    cMNEventEntity.YoutubeURL = String.Empty;
                    cMNEventEntity.TransitAndParkingInformation = String.Empty;
                    cMNEventEntity.EventOptionID = MasterDataConstants.CMNMDEventOption.GUEST_CAN_INIVATE_PEOPLE_ONLY;
                    cMNEventEntity.CompletionPercentage = 0;
                    cMNEventEntity.EventStatusID = MasterDataConstants.CMNMDEventStatus.UP_COMING;
                    cMNEventEntity.RepeatCategoryID = MasterDataConstants.BDMDRepeatCategory.ONE_TIME_EVENT;
                    cMNEventEntity.CreatedByMemberID = CurrentMember.MemberID;
                    cMNEventEntity.OwnerMemberID = CurrentMember.MemberID;
                    cMNEventEntity.CreateDate = System.DateTime.Now;
                    cMNEventEntity.Duration = 0;
                    REQRequisitionItemEntity rEQRequisitionItemEntity = FCCREQRequisitionItem.GetFacadeCreate().GetByID(Int64.Parse(lblRequisitionItemIDLV.Text));
                    cMNEventEntity.ExpectedStartDate = rEQRequisitionItemEntity.RequiredDate; // This should come from Requisition Required Date
                    cMNEventEntity.ExpectedEndDate = rEQRequisitionItemEntity.RequiredDate;
                    cMNEventEntity.ActualStartDate = null;
                    cMNEventEntity.ActualEndDate = null;
                    cMNEventEntity.IsAllDay = true;
                    cMNEventEntity.NotifyBeforeMin = null;
                    cMNEventEntity.IsNotifyCompleted = false;
                    cMNEventEntity.Remarks = "";
                    cMNEventEntity.SharedSettingID = MasterDataConstants.CMNMDSharedSetting.DEFAULT;
                    cMNEventEntity.ModifiedDateTime = System.DateTime.Now;
                    cMNEventEntity.IP = MiscUtil.GetLocalIP();
                    cMNEventEntity.IsOwnerGoing = false;
                    cMNEventEntity.IsRemoved = false;

                    Int64 result = FCCCMNEvent.GetFacadeCreate().Add(cMNEventEntity, DatabaseOperationType.Add, TransactionRequired.No);

                    if(result>0)
                    {
                        MiscUtil.ShowMessage(lblMessage, "Event Added Successfully", false);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Some Error Occoured.", false);
                    }
                }

                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderItemMapID, WorkOrderItemMapID.ToString(), SQLMatchType.Equal);

                        PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity = new PRMWorkOrderItemMapEntity();


                        result = FCCPRMWorkOrderItemMap.GetFacadeCreate().Delete(pRMWorkOrderItemMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _WorkOrderItemMapID = 0;
                            _PRMWorkOrderItemMapEntity = new PRMWorkOrderItemMapEntity();
                            PrepareInitialView();
                            BindPRMWorkOrderItemMapList();

                            MiscUtil.ShowMessage(lblMessage, "Work Order Item Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Work Order Item Map.", true);
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

        #region List View Event(Popup)

        protected void lvPRMWorkOrderItemDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 WorkOrderItemDetailID;

            Int64.TryParse(e.CommandArgument.ToString(), out WorkOrderItemDetailID);

            if (WorkOrderItemDetailID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _WorkOrderItemDetailID = WorkOrderItemDetailID;

                  //  PrepareEditViewPopup();

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemDetailEntity.FLD_NAME_WorkOrderItemDetailID, WorkOrderItemDetailID.ToString(), SQLMatchType.Equal);

                        PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();


                        result = FCCPRMWorkOrderItemDetail.GetFacadeCreate().Delete(pRMWorkOrderItemDetailEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _WorkOrderItemDetailID = 0;
                            _PRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();
                            //PrepareInitialView();
                            BindPRMWorkOrderItemDetailList();
                            

                            MiscUtil.ShowMessage(lblMessage, "Work Order Item Detail has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Work Order Item Detail.", true);
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

        protected void odsPRMWorkOrderItemMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrderItemMap." + PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID, PRMWorkOrderID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        protected void odsREQRequisitionItemFloorDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            //String fe = String.Empty;

            //if (_WorkOrderItemMapID > 0)
            //{
            //    fe = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItemFloorDetail." + REQRequisitionItemFloorDetailEntity.FLD_NAME_RequisitionItemID, CurrentWorkOrderItemIDPopup.ToString(), SQLMatchType.Equal);
            //}

            //e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnCreateWorkOrderDetail_Click(object sender, EventArgs e)
        {
            if (PRMWorkOrderID > 0)
            {
                String NavUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrder.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, PRMWorkOrderID.ToString()).ToString();
                Response.Redirect(NavUrl);
            }
        }

        protected void btnFloorPopupSave_Click(object sender, EventArgs e)
        {
            try
            {
                String fe_db = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemFloorDetailEntity.FLD_NAME_WorkOrderItemMapID, CurrentWorkOrderItemIDPopup.ToString(), SQLMatchType.Equal);
                mappedItemsFromDB = FCCPRMWorkOrderItemFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_db, DatabaseOperationType.LoadWithFilterExpression);

                IList<ListViewDataItem> list = lvREQRequisitionItemFloorDetail.Items;

                Int64 totalSelectedFloor = 0;
                Decimal totalFloorQty = 0, totalRate = 0;

                if (list != null && list.Count > 0)
                {
                    foreach (ListViewDataItem lvdi in list)
                    {
                        CheckBox chbxSelectLV = (CheckBox)lvdi.FindControl("chbxSelectLV");

                        if (chbxSelectLV.Checked)
                        {
                            Decimal newQty, floorRate;

                            TextBox txtTotalQtyLV = (TextBox)lvdi.FindControl("txtQtyLV");
                            TextBox txtRateLV = (TextBox)lvdi.FindControl("txtRateLV");
                            TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                            Label lblProjectFloorIDLV = (Label)lvdi.FindControl("lblProjectFloorIDLV");

                            Decimal.TryParse(txtTotalQtyLV.Text.Trim(), out newQty);
                            Decimal.TryParse(txtRateLV.Text.Trim(), out floorRate);

                            PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity = new PRMWorkOrderItemFloorDetailEntity();

                            pRMWorkOrderItemFloorDetailEntity.WorkOrderID = PRMWorkOrderID; 
                            pRMWorkOrderItemFloorDetailEntity.WorkOrderItemMapID = CurrentWorkOrderItemIDPopup;
                            pRMWorkOrderItemFloorDetailEntity.RequisitionItemID = _RequisitionItemMapIDLV;
                            pRMWorkOrderItemFloorDetailEntity.ProjectFloorID = Int64.Parse(lblProjectFloorIDLV.Text.Trim());
                            pRMWorkOrderItemFloorDetailEntity.RequisitionID = _RequisitionIDLV;//.RequisitionID;
                            pRMWorkOrderItemFloorDetailEntity.ProjectFloorUnitID = null;
                            pRMWorkOrderItemFloorDetailEntity.Qty = newQty;
                            pRMWorkOrderItemFloorDetailEntity.Rate = floorRate;
                            pRMWorkOrderItemFloorDetailEntity.Remarks = txtRemarksLV.Text;
                            pRMWorkOrderItemFloorDetailEntity.EntryDate = System.DateTime.Now;

                            populatedCheckedItems.Add(pRMWorkOrderItemFloorDetailEntity);
                            totalSelectedFloor += 1;
                            totalFloorQty += newQty;
                            totalRate += floorRate;
                        }
                    }
                }

                if (mappedItemsFromDB != null && mappedItemsFromDB.Count > 0)
                {
                    IList<PRMWorkOrderItemFloorDetailEntity> finalAddList = populatedCheckedItems.Except(mappedItemsFromDB, new CustomerComparer()).ToList();
                    IList<PRMWorkOrderItemFloorDetailEntity> finalDeleteList = mappedItemsFromDB.Except(populatedCheckedItems, new CustomerComparer()).ToList();

                    if (finalAddList != null && finalAddList.Count > 0)
                    {
                        foreach (PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity in finalAddList)
                        {
                            FCCPRMWorkOrderItemFloorDetail.GetFacadeCreate().Add(pRMWorkOrderItemFloorDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                    }

                    if (finalDeleteList != null && finalDeleteList.Count > 0)
                    {
                        foreach (PRMWorkOrderItemFloorDetailEntity pRMWorkOrderItemFloorDetailEntity in finalDeleteList)
                        {
                            String fe_del = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemFloorDetailEntity.FLD_NAME_WorkOrderItemFloorDetailID, pRMWorkOrderItemFloorDetailEntity.WorkOrderItemFloorDetailID.ToString(), SQLMatchType.Equal);
                            FCCPRMWorkOrderItemFloorDetail.GetFacadeCreate().Delete(pRMWorkOrderItemFloorDetailEntity, fe_del, DatabaseOperationType.Delete, TransactionRequired.No);
                        }
                    }
                }
                else
                {
                    if (populatedCheckedItems != null && populatedCheckedItems.Count > 0)
                    {
                        foreach (PRMWorkOrderItemFloorDetailEntity ent in populatedCheckedItems)
                        {
                            FCCPRMWorkOrderItemFloorDetail.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                    }
                }

                if (totalSelectedFloor > 0)
                {
                    //#region Update Wor Item Cost and Qty

                    //String fe_requisitionItem = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, CurrentRequisitionItemIDPopup.ToString(), SQLMatchType.Equal);
                    //REQRequisitionItemEntity rEQRequisitionItemEntity = FCCREQRequisitionItem.GetFacadeCreate().GetByID(CurrentRequisitionItemIDPopup);

                    //rEQRequisitionItemEntity.PresentRequiredQty = Math.Round(totalFloorQty);
                    //rEQRequisitionItemEntity.Rate = Math.Round(totalRate / totalSelectedFloor);

                    //FCCREQRequisitionItem.GetFacadeCreate().Update(rEQRequisitionItemEntity, fe_requisitionItem, DatabaseOperationType.Update, TransactionRequired.No);

                    //IList<ListViewDataItem> listRequisitionItem = lvREQRequisitionItem.Items;

                    //if (listRequisitionItem != null && listRequisitionItem.Count > 0)
                    //{

                    //    Int64 tempDataItemIndex = 0;

                    //    foreach (ListViewDataItem lvdi in listRequisitionItem)
                    //    {
                    //        Label lblRequisitionItemIDLV = (Label)lvdi.FindControl("lblRequisitionItemIDLV");

                    //        Int64.TryParse(lblRequisitionItemIDLV.Text.Trim(), out tempDataItemIndex);

                    //        if (CurrentRequisitionItemIDPopup == tempDataItemIndex)
                    //        {
                    //            TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");
                    //            // TextBox txtTotalQtyLV = (TextBox)lvdi.FindControl("txtTotalQtyLV");
                    //            txtPresentRequiredQty.Text = rEQRequisitionItemEntity.PresentRequiredQty.ToString();
                    //            // txtRateLV.Text = avgRate.ToString();
                    //            break;
                    //        }
                    //    }
                    //}

                    //BindList();

                    //#endregion
                }
                else
                {

                }

                MiscUtil.ShowMessage(lblMessage, "Requisition Floor Wise Item Info Saved Successfully.", false);

                CurrentWorkOrderItemIDPopup = 0;
                _PRMWorkOrderItemFloorDetailEntityList = new List<PRMWorkOrderItemFloorDetailEntity>();
                mappedItemsFromDB = new List<PRMWorkOrderItemFloorDetailEntity>();
                populatedCheckedItems = new List<PRMWorkOrderItemFloorDetailEntity>();
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Some Error Occured." + ex.Message.ToString(), true);
            }

        }

        protected void btnWorkOrderPaymentTerm_Click(object sender, EventArgs e)
        {
            String NavUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrderPaymentTerm.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, PRMWorkOrderID.ToString(), PRMWorkOrderEntity.FLD_NAME_WorkOrderNo, PRMWorkOrderNo.ToString()).ToString();
            Response.Redirect(NavUrl);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMWorkOrderItemMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _WorkOrderItemMapID = 0;
            _PRMWorkOrderItemMapEntity = new PRMWorkOrderItemMapEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnInitiateApprovalProcess_Click(object sender, EventArgs e)
        {
            #region Approval Process

            Boolean apResult = APRobot.CreateApprovalProcessForNewWorkWorder(PRMWorkOrderID);

            if (apResult == true)
            {
                MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process. Please Ensure Panel Member or Item Category Map.", UIConstants.MessageType.RED);
            }

            //EnableDisableApprovalProcessCheck();

            #endregion

        }

        protected void btnRequiredQtyEdit_Click(object sender, EventArgs e)
        {
            if (txtRequiredQty.ReadOnly == false)
            {
                txtRequiredQty.ReadOnly = true;
                btnRequiredQtyEdit.Text = "Edit";
            }
            else
            {
                txtRequiredQty.ReadOnly = false;
                btnRequiredQtyEdit.Text = "Lock";
            }
        }
        #endregion

        #region DropDownEvent

        protected void ddlRequisitionItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildREQRequisitionItemRate();
        }

        protected void ddlRequisitionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildREQRequisitionItem();
        }

        #endregion

        #region ObjectDataSource Event Popup

        protected void odsPRMWorkOrderItemDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrderItemDetail." + PRMWorkOrderItemDetailEntity.FLD_NAME_WorkOrderItemMapID, _WorkOrderItemMapID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event Popup

        protected void btnSavePopup_Click(object sender, EventArgs e)
        {
            SavePRMWorkOrderItemDetailEntity();
            this.Panel1_ModalPopupExtender.Show();
        }

        protected void btnAddNewPopup_Click(object sender, EventArgs e)
        {
            _WorkOrderItemDetailID = 0;
            _PRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();
            PrepareInitialViewPopup();
        }

        protected void btnClearPopup_Click(object sender, EventArgs e)
        {
            PrepareInitialViewPopup();
            PrepareEditViewPopup();
            this.Panel1_ModalPopupExtender.Show();
        }

        #endregion

        #endregion Event
    }
}
