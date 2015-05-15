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
using System.Data;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class PRMMaterialReceiveControl : BaseControl
    {
        #region Properties

        public String Action
        {
            get
            {
                String action = "Add";

                if (ViewState["do"] != null)
                {
                    action = ViewState["do"].ToString();
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["do"].ToString()))
                {
                    action = Helper.Url.SecureUrl["do"].ToString();

                    ViewState["do"] = action;
                }

                return action;
            }
            set
            {
                ViewState["do"] = value;
            }
        }

        public IList<PRMMaterialReceiveItemMapEntity> PRMMaterialReceiveItemMapList
        {
            get
            {
                return (IList<PRMMaterialReceiveItemMapEntity>)ViewState["vs_CurrentMaterialReceiveItemMapEntity"];
            }
            set
            {
                ViewState["vs_CurrentMaterialReceiveItemMapEntity"] = value;
            }
        }

        public Int64 _MaterialReceiveID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID], out id);
                    ViewState["ID"] = id;
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

        public IList<PRMMaterialReceiveItemMapEntity> UpdatedMappedPRMMaterialReceiveEntity
        {
            get
            {
                return (IList<PRMMaterialReceiveItemMapEntity>)ViewState["vs_UpdatedMappedPRMMaterialReceiveEntity"];
            }
            set
            {
                ViewState["vs_UpdatedMappedPRMMaterialReceiveEntity"] = value;
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

        private PRMWorkOrderEntity CurrentPRMWorkOrderEntity
        {
            get
            {
                PRMWorkOrderEntity pRMWorkOrderEntity = new PRMWorkOrderEntity();

                Int64 PRMWorkOrderID=0;
                Int64.TryParse(ddlWorkOrderID.SelectedValue.ToString(),out PRMWorkOrderID);

                if (PRMWorkOrderID > 0)
                {
                    pRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(PRMWorkOrderID);
                }

                return pRMWorkOrderEntity ?? new PRMWorkOrderEntity();
            }
        }

        public IList<PRMWorkOrderItemFloorDetailEntity> PRMWorkOrderItemFloorDetailEntityList
        {
            get
            {
                //if (_RequisitionItemID > 0)
                //{
                //    if (_REQRequisitionItemEntity.RequisitionItemID != _RequisitionItemID)
                //    {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemFloorDetailEntity.FLD_NAME_WorkOrderItemMapID, CurrentWorkOrderItemIDPopup.ToString(), SQLMatchType.Equal);
                ViewState["vs_CurrentPRMWorkOrderItemFloorDetailEntity"] = FCCPRMWorkOrderItemFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                //}
                //}

                return (IList<PRMWorkOrderItemFloorDetailEntity>)ViewState["vs_CurrentPRMWorkOrderItemFloorDetailEntity"];
            }
            set
            {
                ViewState["vs_CurrentPRMWorkOrderItemFloorDetailEntity"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateStartWithAPPanel(ddlAPPanelID, false, MasterDataConstants.APPanelStartWith.MRR);

            if (ddlProjectID.SelectedValue != "0" && ddlProjectID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMSupplierByProjectID(ddlSupplierID, false, Int64.Parse(ddlProjectID.SelectedValue));
                ddlRequisitionID.Items.Clear();
                ddlWorkOrderID.Items.Clear();

                if (ddlSupplierID.SelectedValue != "0" && ddlSupplierID.Items.Count > 0)
                {
                    MiscUtil.PopulatePRMRequisitionBySupplierID(ddlRequisitionID, false, Int64.Parse(ddlSupplierID.SelectedValue));

                    if (ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
                    {
                        MiscUtil.PopulatePRMWorkOrderByRequisitonID(ddlWorkOrderID, false, Int64.Parse(ddlRequisitionID.SelectedValue));
                    }
                }
            }

        }

        private void PrepareValidator()
        {
        }

        private Boolean ValidationInput()
        {
            Boolean flag = true;

            if (lvPRMWorkOrderItemMap.Items.Count <= 0)
            {
                MiscUtil.ShowMessage(lblMessage, "No Item Available to Receive", true);
                flag = false;
            }

            return flag;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            BindList();

            txtMRRNo.Text = String.Empty;
            txtMRRDate.Text = System.DateTime.Now.ToString("dd-MM-yyyy");
            txtRemarks.Text = String.Empty;

            PRMMaterialReceiveItemMapList = new List<PRMMaterialReceiveItemMapEntity>();
            UpdatedMappedPRMMaterialReceiveEntity = new List<PRMMaterialReceiveItemMapEntity>();

            btnSubmit.Text = "Save & Submit For Approval";
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

                if (ddlRequisitionID.Items.Count > 0 && pRMMaterialReceiveEntity.RequisitionID != null)
                {
                    ddlRequisitionID.SelectedValue = pRMMaterialReceiveEntity.RequisitionID.ToString();
                }

                if (ddlWorkOrderID.Items.Count > 0 && pRMMaterialReceiveEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = pRMMaterialReceiveEntity.WorkOrderID.ToString();
                }

                txtMRRNo.Text = pRMMaterialReceiveEntity.MRRNo.ToString();
                txtMRRDate.Text = pRMMaterialReceiveEntity.MRRDate.ToStringDefault();
                txtRemarks.Text = pRMMaterialReceiveEntity.Remarks.ToString();

                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveID, _MaterialReceiveID.ToString(), SQLMatchType.Equal);
                UpdatedMappedPRMMaterialReceiveEntity = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (UpdatedMappedPRMMaterialReceiveEntity != null && UpdatedMappedPRMMaterialReceiveEntity.Count > 0)
                {
                    PRMMaterialReceiveItemMapList = UpdatedMappedPRMMaterialReceiveEntity;
                }
                else
                {
                    UpdatedMappedPRMMaterialReceiveEntity = new List<PRMMaterialReceiveItemMapEntity>();
                }

                BindPRMWorkOrderItemMapList();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindPRMWorkOrderItemMapList();
        }

        private void BindPRMMaterialReceiveList()
        {
            lvPRMMaterialReceive.DataBind();
        }

        private void BindPRMWorkOrderItemMapList()
        {
            String fe = String.Empty;

            //if (chbxSelectWorkOrder.Checked)
            //{
            if (ddlWorkOrderID.SelectedValue != "0" && ddlWorkOrderID.Items.Count > 0 && ddlProjectID.SelectedValue != "0" && ddlProjectID.Items.Count > 0 && ddlSupplierID.SelectedValue != "0" && ddlSupplierID.Items.Count > 0 && ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + PRMWorkOrder_CustomEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrder." + PRMWorkOrder_CustomEntity.FLD_NAME_SupplierID, ddlSupplierID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrderItemMap." + PRMWorkOrder_CustomEntity.FLD_NAME_WorkOrderID, ddlWorkOrderID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrderItemMap." + PRMWorkOrder_CustomEntity.FLD_NAME_RequisitionID, ddlRequisitionID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe4);
            }

            lvPRMWorkOrderItemMap.DataSource = FCCPRMWorkOrder_Custom.GetFacadeCreate().GetDT(fe);
            lvPRMWorkOrderItemMap.DataBind();
            //}

            //else if (chbxSelectRequisition.Checked)
            //{
            //    String fe1 = String.Empty;

            //    if (ddlWorkOrderID.SelectedValue != "0" && ddlWorkOrderID.Items.Count > 0 && ddlProjectID.SelectedValue != "0" && ddlProjectID.Items.Count > 0 && ddlSupplierID.SelectedValue != "0" && ddlSupplierID.Items.Count > 0 && ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
            //    {
            //        fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition.RequisitionID", ddlRequisitionID.SelectedValue.ToString(), SQLMatchType.Equal);
            //    }

            //    lvPRMWorkOrderItemMap.DataSource = FCCPRMMaterialRequisitionItem_Custom.GetFacadeCreate().GetIL(fe1);
            //    lvPRMWorkOrderItemMap.DataBind();
            //}


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

            if (ddlRequisitionID.Items.Count > 0)
            {
                if (ddlRequisitionID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMMaterialReceiveEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                }
            }

            if (ddlWorkOrderID.Items.Count > 0)
            {
                if (ddlWorkOrderID.SelectedValue == "0")
                {
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
            pRMMaterialReceiveEntity.MaterialReceiveApprovalStatusID = MasterDataConstants.MDMaterialReceiveApprovalStatus.INITIATED;
            pRMMaterialReceiveEntity.CreatedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            return pRMMaterialReceiveEntity;
        }


        private void BuildPRMMaterialReceiveItemEntity(Int64 result, PRMMaterialReceiveEntity pRMMaterialReceiveEntity)
        {
            IList<ListViewDataItem> list = lvPRMWorkOrderItemMap.Items;

            if (list != null && list.Count > 0)
            {
                foreach (ListViewDataItem lvdi in list)
                {

                    Decimal ReceiveQty, rateLV, totalWOItemAmount;
                    Int64 requisitionItemID;

                    Label lblRequisitonItemIDLV = (Label)lvdi.FindControl("lblRequisitonItemIDLV");
                    TextBox txtQtyLV = (TextBox)lvdi.FindControl("txtReceiveQtyLV");
                    TextBox txtChallanNoLV = (TextBox)lvdi.FindControl("txtChallanNoLV");
                    TextBox txtReceiveDateLV = (TextBox)lvdi.FindControl("txtReceiveDateLV");
                    Label lblRateLV = (Label)lvdi.FindControl("lblRateLV");


                    Decimal.TryParse(txtQtyLV.Text.Trim(), out ReceiveQty);
                    Decimal.TryParse(lblRateLV.Text.Trim(), out rateLV);

                    totalWOItemAmount = ReceiveQty * rateLV;

                    if (ReceiveQty <= 0)
                    {
                        continue;
                    }

                    Int64.TryParse(lblRequisitonItemIDLV.Text, out requisitionItemID);

                    PRMMaterialReceiveItemMapEntity pRMMaterialReceiveItemMap = new PRMMaterialReceiveItemMapEntity();
                    pRMMaterialReceiveItemMap.MaterialReceiveID = result;
                    pRMMaterialReceiveItemMap.RequisitionItemID = requisitionItemID;
                    pRMMaterialReceiveItemMap.ReceiveQty = ReceiveQty;
                    pRMMaterialReceiveItemMap.ItemRate = rateLV;
                    pRMMaterialReceiveItemMap.WOItemTotalRate = totalWOItemAmount;
                    pRMMaterialReceiveItemMap.ChallanNo = txtChallanNoLV.Text.ToString();
                    if (txtReceiveDateLV.Text.Trim().IsNotNullOrEmpty())
                    {
                        pRMMaterialReceiveItemMap.ReceiveDate = MiscUtil.ParseToDateTime(txtReceiveDateLV.Text);
                    }

                    if (pRMMaterialReceiveEntity.IsNew)
                    {
                        FCCPRMMaterialReceiveItemMap.GetFacadeCreate().Add(pRMMaterialReceiveItemMap, DatabaseOperationType.Add, TransactionRequired.No);
                    }

                    else
                    {
                        String fe;
                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveID, pRMMaterialReceiveEntity.MaterialReceiveID.ToString(), SQLMatchType.Equal);
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_RequisitionItemID, requisitionItemID.ToString(), SQLMatchType.Equal);
                        fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                        FCCPRMMaterialReceiveItemMap.GetFacadeCreate().Update(pRMMaterialReceiveItemMap, fe, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    //#region Inventory

                    //Int64 _employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                    //Int64 _projectID=Int64.Parse(ddlProjectID.SelectedValue);

                    //INVStoreEntity storeEntity = INVManager.GetDefaultStore(_projectID);
                    //Int64 storeID = storeEntity.StoreID;

                    //INVStoreUnitEntity storeUnitEntity = INVManager.GetDefaultStoreUnit(storeID);
                    //Int64 storeUnitID = storeUnitEntity.StoreUnitID;

                    //String fe_requisitionItem = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem."+REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, requisitionItemID.ToString(), SQLMatchType.Equal);
                    //IList<REQRequisitionItem_DetailedEntity> lst = FCCREQRequisitionItem_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_requisitionItem);

                    //Int64 _itemID = 0;
                    //Decimal _rate = 0;
                    //Int64 brandID = 0;
                    //Int64 regionID = 0;
                    //Int64 countryID = 0;

                    //if (lst != null && lst.Count>0)
                    //{
                    //    _itemID = lst[0].ItemID;
                    //    brandID = (Int64)lst[0].BrandID;
                    //    regionID = (Int64)lst[0].RegionID;
                    //    countryID = (Int64)lst[0].CountryID;

                    //    String fe_WOItemID = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_RequisitionItemID, lst[0].RequisitionItemID.ToString(), SQLMatchType.Equal);
                    //    String fe_WOID = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID, ddlWorkOrderID.SelectedValue.ToString(), SQLMatchType.Equal);

                    //    String fe_WOItemMap = SqlExpressionBuilder.PrepareFilterExpression(fe_WOItemID, SQLJoinType.AND, fe_WOID);

                    //    IList<PRMWorkOrderItemMapEntity> lstWOItem = FCCPRMWorkOrderItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_WOItemMap, DatabaseOperationType.LoadWithFilterExpression);

                    //    if (lstWOItem != null && lstWOItem.Count > 0)
                    //    {
                    //        Decimal.TryParse(lstWOItem[0].Rate.ToString(),out _rate);
                    //    }
                    //}

                    //Boolean invResult = INVManager.AddItemsToStoreUnit(_itemID,brandID,regionID,countryID, "", Int64.Parse(ReceiveQty.ToString()), MiscUtil.GetLocalIP(), _employeeID, _rate, ddlRequisitionID.SelectedItem.Text, ddlWorkOrderID.SelectedItem.Text, result.ToString(), "", Int64.Parse(ddlProjectID.SelectedValue), storeID, storeUnitID);

                    //#endregion
                }
            }
        }
        private void SavePRMMaterialReceiveEntity()
        {
            if (IsValid)
            {

                try
                {
                    PRMMaterialReceiveEntity pRMMaterialReceiveEntity = BuildPRMMaterialReceiveEntity();

                    Int64 result = -1;

                    if (pRMMaterialReceiveEntity.IsNew)
                    {
                        result = FCCPRMMaterialReceive.GetFacadeCreate().Add(pRMMaterialReceiveEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }

                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveEntity.FLD_NAME_MaterialReceiveID, pRMMaterialReceiveEntity.MaterialReceiveID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMMaterialReceive.GetFacadeCreate().Update(pRMMaterialReceiveEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {

                        BuildPRMMaterialReceiveItemEntity(result, pRMMaterialReceiveEntity);

                        #region Approval Process

                        Boolean apResult = APRobot.CreateApprovalProcessForNewMRR(result, Int64.Parse(ddlAPPanelID.SelectedValue));

                        if (apResult == true)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                        }

                        #endregion

                        _MaterialReceiveID = 0;
                        _PRMMaterialReceiveEntity = new PRMMaterialReceiveEntity();
                        PrepareInitialView();



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


                if (CurrentPRMWorkOrderEntity.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.APPROVED)
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

        protected void lvPRMMaterialReceive_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                PRMMaterialReceive_DetailedEntity ent = (PRMMaterialReceive_DetailedEntity)dataItem.DataItem;


                HyperLink hypMRRNo = (HyperLink)e.Item.FindControl("hypMRRNo");
                hypMRRNo.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "MaterialReceiveReport", UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID, ent.MaterialReceiveID.ToString()).ToString();

                hypMRRNo.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMMaterialReceiveItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID, ent.MaterialReceiveID.ToString()).ToString();

                hypMRRNo.Target = "_blank";

                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.MRR, ent.MaterialReceiveID);

                if (aPApprovalProcessEntity.APApprovalProcessID > 0)
                {
                    lnkShowApprovalStatus.NavigateUrl = UrlHelper.BuildSecureUrl(
                               "~/AP/APView.aspx",
                               string.Empty,
                               APApprovalProcessEntity.FLD_NAME_APApprovalProcessID,
                               aPApprovalProcessEntity.APApprovalProcessID.ToString()
                               ).ToString();

                    lnkShowApprovalStatus.Target = "_blank";
                }
                else
                {
                    lnkShowApprovalStatus.NavigateUrl = String.Empty;
                    lnkShowApprovalStatus.Enabled = false;
                }
            }
        }

        protected void lvPRMMaterialReceive_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 WorkOrderItemMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out WorkOrderItemMapID);

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
            }

        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsPRMMaterialReceive_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveEntity.FLD_NAME_WorkOrderID, "0", SQLMatchType.Equal);

            if (ddlWorkOrderID != null && ddlWorkOrderID.Items.Count > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("PRMMaterialReceive." + PRMMaterialReceiveEntity.FLD_NAME_WorkOrderID, ddlWorkOrderID.SelectedValue.ToString(), SQLMatchType.Equal);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                SavePRMMaterialReceiveEntity();
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MaterialReceiveID = 0;
            _PRMMaterialReceiveEntity = new PRMMaterialReceiveEntity();
            PrepareInitialView();
        }

        #endregion

        #region DropDownEvent

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProjectID.SelectedValue != "0" && ddlProjectID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMSupplierByProjectID(ddlSupplierID, false, Int64.Parse(ddlProjectID.SelectedValue));
                ddlRequisitionID.Items.Clear();
                ddlWorkOrderID.Items.Clear();

                if (ddlSupplierID.SelectedValue != "0" && ddlSupplierID.Items.Count > 0)
                {
                    MiscUtil.PopulatePRMRequisitionBySupplierID(ddlRequisitionID, false, Int64.Parse(ddlSupplierID.SelectedValue));

                    if (ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
                    {
                        MiscUtil.PopulatePRMWorkOrderByRequisitonID(ddlWorkOrderID, false, Int64.Parse(ddlRequisitionID.SelectedValue));
                    }
                }
            }
            BindList();
            BindPRMMaterialReceiveList();
        }

        protected void ddlSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlRequisitionID.Items.Clear();
            ddlWorkOrderID.Items.Clear();

            if (ddlSupplierID.SelectedValue != "0" && ddlSupplierID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMRequisitionBySupplierID(ddlRequisitionID, false, Int64.Parse(ddlSupplierID.SelectedValue));

                if (ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
                {
                    MiscUtil.PopulatePRMWorkOrderByRequisitonID(ddlWorkOrderID, false, Int64.Parse(ddlRequisitionID.SelectedValue));
                }
            }

            BindList();
            BindPRMMaterialReceiveList();
        }

        protected void ddlRequisitionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlWorkOrderID.Items.Clear();

            if (ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMWorkOrderByRequisitonID(ddlWorkOrderID, false, Int64.Parse(ddlRequisitionID.SelectedValue));
            }

            BindList();
            BindPRMMaterialReceiveList();
        }

        protected void ddlWorkOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindList();
            BindPRMMaterialReceiveList();
        }

        #endregion

        #region Check Box Event

        protected void chbxSelectRequisition_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSelectRequisition.Checked)
            {
                chbxSelectWorkOrder.Checked = false;
            }
            else if (chbxSelectRequisition.Checked == false)
            {
                chbxSelectWorkOrder.Checked = true;
            }
            BindPRMWorkOrderItemMapList();
        }

        protected void chbxSelectWorkOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSelectWorkOrder.Checked)
            {
                chbxSelectRequisition.Checked = false;
            }
            else if (chbxSelectWorkOrder.Checked == false)
            {
                chbxSelectRequisition.Checked = true;
            }

            BindPRMWorkOrderItemMapList();
        }

        #endregion

        #endregion Event
    }
}
