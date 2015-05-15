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

namespace Bay.ERP.Web.UI
{
    public partial class PRMMaterialReceiveItemMapControl : BaseControl
    {       
        #region Properties

        public Int64 _MaterialReceiveItemMapID
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

        public PRMMaterialReceiveItemMapEntity _PRMMaterialReceiveItemMapEntity
        {
            get
            {
                PRMMaterialReceiveItemMapEntity entity = new PRMMaterialReceiveItemMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMMaterialReceiveItemMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMMaterialReceiveItemMapEntity CurrentPRMMaterialReceiveItemMapEntity
        {
            get
            {
                if (_MaterialReceiveItemMapID > 0)
                {
                    if (_PRMMaterialReceiveItemMapEntity.MaterialReceiveItemMapID != _MaterialReceiveItemMapID)
                    {
                        _PRMMaterialReceiveItemMapEntity = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetByID(_MaterialReceiveItemMapID);
                    }
                }

                return _PRMMaterialReceiveItemMapEntity;
            }
            set
            {
                _PRMMaterialReceiveItemMapEntity = value;
            }
        }

        public Int64 OverviewMaterialReceiveID
        {
            get
            {
                Int64 materialReceiveID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID], out materialReceiveID);
                    //_BankAccountTransferID = bankAccountTransferID;
                }

                return materialReceiveID;
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

         private PRMMaterialReceiveEntity CurrentPRMMaterialReceiveEntity
        {
            get
            {
                PRMMaterialReceiveEntity pRMMaterialReceiveEntity= new PRMMaterialReceiveEntity();

                if (OverviewMaterialReceiveID > 0)
                {
                    pRMMaterialReceiveEntity = FCCPRMMaterialReceive.GetFacadeCreate().GetByID(OverviewMaterialReceiveID);
                }

                return pRMMaterialReceiveEntity ?? new PRMMaterialReceiveEntity();
            }
        }

        private PRMWorkOrderEntity CurrentPRMWorkOrderEntity
        {
            get
            {
                PRMWorkOrderEntity pRMWorkOrderEntity = new PRMWorkOrderEntity();

                if (CurrentPRMMaterialReceiveEntity.WorkOrderID > 0)
                {
                    pRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(CurrentPRMMaterialReceiveEntity.WorkOrderID);
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
          
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

           
        }

        private void BindList()
        {
            BindPRMMaterialReceiveItemMapList();
        }

        private void BindPRMMaterialReceiveItemMapList()
        {
            lvPRMMaterialReceiveItemMap.DataBind();
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

        protected void lvPRMMaterialReceiveItemMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MaterialReceiveItemMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out MaterialReceiveItemMapID);

            if (e.CommandName == "FloorWiseRateAndQty")
            {
                CurrentWorkOrderItemIDPopup = MaterialReceiveItemMapID;

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

            if (MaterialReceiveItemMapID > 0)
            {
                

                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MaterialReceiveItemMapID = MaterialReceiveItemMapID;
                   
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveItemMapID, MaterialReceiveItemMapID.ToString(), SQLMatchType.Equal);

                        PRMMaterialReceiveItemMapEntity pRMMaterialReceiveItemMapEntity = new PRMMaterialReceiveItemMapEntity();


                        result = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().Delete(pRMMaterialReceiveItemMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MaterialReceiveItemMapID = 0;
                            _PRMMaterialReceiveItemMapEntity = new PRMMaterialReceiveItemMapEntity();
                            PrepareInitialView();
                            BindPRMMaterialReceiveItemMapList();

                            MiscUtil.ShowMessage(lblMessage, "Material Receive Item Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Material Receive Item Map.", true);
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

        protected void odsPRMMaterialReceiveItemMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMMaterialReceiveItemMap."+PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveID, OverviewMaterialReceiveID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MaterialReceiveItemMapID = 0;
            _PRMMaterialReceiveItemMapEntity = new PRMMaterialReceiveItemMapEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
        }

        #endregion

        #endregion Event
    }
}
