// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jan-2012, 04:11:49



using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Manager;
using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Web.UI.HtmlControls;
using System.Threading;
using System.Text;
using AjaxControlToolkit;
using System.IO;

namespace Bay.ERP.Web.UI
{
    public partial class REQRequisitionDetailsWithApprovalControl : BaseControl
    {
        #region Extra

        class CustomerComparer : IEqualityComparer<REQRequisitionItemFloorDetailEntity>
        {
            public bool Equals(REQRequisitionItemFloorDetailEntity x, REQRequisitionItemFloorDetailEntity y)
            {
                return (x.RequisitionItemID.Equals(y.RequisitionItemID) && x.ProjectFloorID.Equals(y.ProjectFloorID));
            }

            public int GetHashCode(REQRequisitionItemFloorDetailEntity obj)
            {
                return obj.RequisitionItemID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _BOQID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID_BOQID"] != null)
                {
                    Int64.TryParse(ViewState["ID_BOQID"].ToString(), out id);
                }

                else
                {
                    //String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_ProjectID, CurrentREQRequisitionEntity.ProjectID.ToString(), SQLMatchType.Equal);
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
                ViewState["ID_BOQID"] = value;
            }
        }

        public Int64 _RequisitionUploadInfoID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["RequisitionUploadInfoID"] != null)
                {
                    Int64.TryParse(ViewState["RequisitionUploadInfoID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["RequisitionUploadInfoID"] = value;
            }
        }
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

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.REQUISITION_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.REQUISITION_ID], out rEQRequisitionID);
                }

                return rEQRequisitionID;
            }
        }

        public Int64 APApprovalProcessID
        {
            get
            {
                Int64 aPApprovalProcessID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID], out aPApprovalProcessID);
                }

                return aPApprovalProcessID;
            }
        }

        private REQRequisitionEntity rEQRequisitionNormalEntity
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

        public Int64 APForwardInfoID
        {
            get
            {
                Int64 aPForwardInfoID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APForwardInfoEntity.FLD_NAME_APForwardInfoID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APForwardInfoEntity.FLD_NAME_APForwardInfoID], out aPForwardInfoID);
                }

                return aPForwardInfoID;
            }
        }
        
        public Int64 ProxyEmployeeID
        {
            get
            {
                Int64 proxyEmployeeID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_ProxyEmployeeID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_ProxyEmployeeID], out proxyEmployeeID);
                }

                return proxyEmployeeID;
            }
        }

        public Int64 APMemberFeedbackID
        {
            get
            {
                Int64 aPMemberFeedbackID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID], out aPMemberFeedbackID);
                }

                return aPMemberFeedbackID;
            }
        }

        private REQRequisition_DetailedEntity CurrentREQRequisitionEntity
        {
            get
            {
                IList<REQRequisition_DetailedEntity> _lstREQRequisitionEntity=new List<REQRequisition_DetailedEntity>();

                if (REQRequisitionID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
                    _lstREQRequisitionEntity = FCCREQRequisition_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe);
                }

                return _lstREQRequisitionEntity[0];
            }
        }

        public Decimal ItemQty
        {
            get
            {
                Decimal itemQty=0;
                if (ViewState["vs_ItemQty"] != null)
                {
                    Decimal.TryParse(ViewState["vs_ItemQty"].ToString(),out itemQty);
                }

                return itemQty;
            }
            set
            {
                ViewState["vs_ItemQty"] = value;
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

        public Int64 CurrentRequisitionItemIDPopup
        {
            get
            {
                Int64 id = 0;

                if (ViewState["CurrentRequisitionItemIDPopup"] != null)
                {
                    Int64.TryParse(ViewState["CurrentRequisitionItemIDPopup"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["CurrentRequisitionItemIDPopup"] = value;
            }
        }

        public IList<REQRequisitionItemFloorDetailEntity> _REQRequisitionItemFloorDetailList
        {
            get
            {
                IList<REQRequisitionItemFloorDetailEntity> lst = new List<REQRequisitionItemFloorDetailEntity>();

                if (ViewState["vs_CurrentREQRequisitionItemFloorDetailList"] != null)
                {
                    lst = (IList<REQRequisitionItemFloorDetailEntity>)ViewState["vs_CurrentREQRequisitionItemFloorDetailList"];
                }

                return lst;
            }
            set
            {
                ViewState["vs_CurrentREQRequisitionItemFloorDetailList"] = value;
            }
        }

        public IList<REQRequisitionItemFloorDetailEntity> REQRequisitionItemFloorDetailList
        {
            get
            {
                if (CurrentRequisitionItemIDPopup > 0)
                {
                    if (_REQRequisitionItemFloorDetailList != null && _REQRequisitionItemFloorDetailList.Count > 0)
                    {
                        if (_REQRequisitionItemFloorDetailList[0].RequisitionItemID != CurrentRequisitionItemIDPopup)
                        {
                            String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemFloorDetailEntity.FLD_NAME_RequisitionItemID, CurrentRequisitionItemIDPopup.ToString(), SQLMatchType.Equal);
                            _REQRequisitionItemFloorDetailList = FCCREQRequisitionItemFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                        }
                    }
                    else
                    {
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemFloorDetailEntity.FLD_NAME_RequisitionItemID, CurrentRequisitionItemIDPopup.ToString(), SQLMatchType.Equal);
                        _REQRequisitionItemFloorDetailList = FCCREQRequisitionItemFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                    }
                }

                return _REQRequisitionItemFloorDetailList;
            }
            set
            {
                _REQRequisitionItemFloorDetailList = value;
            }
        }

        public IList<REQRequisitionItemFloorDetailEntity> mappedItemsFromDB
        {
            get
            {
                return (IList<REQRequisitionItemFloorDetailEntity>)ViewState["vs_mappedItemsFromDB"];
            }
            set
            {
                ViewState["vs_mappedItemsFromDB"] = value;
            }
        }

        public IList<REQRequisitionItemFloorDetailEntity> populatedCheckedItems
        {
            get
            {
                return (IList<REQRequisitionItemFloorDetailEntity>)ViewState["vs_populatedCheckedItems"];
            }
            set
            {
                ViewState["vs_populatedCheckedItems"] = value;
            }
        }

        #endregion

        #region Methods

        private void PrepareInitialViewPopup()
        {   
            MiscUtil.PopulateMDRegion(ddlOriginRegionID, false);
            MiscUtil.PopulateINVStore(ddlTransferFromStoreID, false);
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

        private void RedirectPageToAllPendingList()
        {
            Response.Redirect("~/AP/Default.aspx");
        }

        private void RedirectPageToRejectList()
        {
            Response.Redirect("~/AP/APPendingList.aspx");
        }

        private void RedirectPageToForwardList()
        {
            Response.Redirect("~/AP/APPendingList.aspx");
        }

        private void RedirectPageToPendingList()
        {
            Response.Redirect("~/AP/APPendingList.aspx");
        }

        private void RedirectPageToProxyList()
        {
            Response.Redirect("~/AP/APProxyApprovalRequest.aspx");
        }

        private void BuildCountryDropdownByRegion()
        {
            if (ddlOriginRegionID.SelectedValue != "0" && ddlOriginRegionID.Items.Count > 0)
            {
                MiscUtil.PopulateMDCountryByRegionID(ddlOriginCountryID, false, Int64.Parse(ddlOriginRegionID.SelectedValue));
            }
        }

        private INVTransferEntity BuildINVTransferEntity()
        {
            INVTransferEntity iNVTransferEntity = new INVTransferEntity();

            REQRequisitionEntity rEQRequisitionEntity = rEQRequisitionNormalEntity;

            iNVTransferEntity.TRFNo = "Req No: " + rEQRequisitionEntity.RequisitionNo;
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_MemberID, rEQRequisitionEntity.PreparedByMemberID.ToString(), SQLMatchType.Equal);
            IList<HREmployeeEntity> hrEmployeeList = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (hrEmployeeList != null && hrEmployeeList.Count > 0)
            {
                iNVTransferEntity.RequestedByEmployeeID = hrEmployeeList[0].EmployeeID;
            }

            iNVTransferEntity.RequestDate = rEQRequisitionEntity.RequisitionDate;

            if (rEQRequisitionEntity != null && rEQRequisitionEntity.RequisitionID > 0)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_ProjectID, rEQRequisitionEntity.ProjectID.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_IsDefault, "1", SQLMatchType.Equal);
                String fe_store = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                IList<INVStoreEntity> iNVStoreEntityList = FCCINVStore.GetFacadeCreate().GetIL(null, null, String.Empty, fe_store, DatabaseOperationType.LoadWithFilterExpression);


                if (iNVStoreEntityList != null && iNVStoreEntityList.Count > 0)
                {
                    iNVTransferEntity.TransferToStoreID = iNVStoreEntityList[0].StoreID;

                    String fe_storeUnit1 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_StoreID, iNVStoreEntityList[0].StoreID.ToString(), SQLMatchType.Equal);
                    String fe_storeUnit2 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_IsDefault, "1", SQLMatchType.Equal);
                    String fe_storeUnit = SqlExpressionBuilder.PrepareFilterExpression(fe_storeUnit1, SQLJoinType.AND, fe_storeUnit2);

                    IList<INVStoreUnitEntity> lstStoreUnit = FCCINVStoreUnit.GetFacadeCreate().GetIL(null, null, String.Empty, fe_storeUnit, DatabaseOperationType.LoadWithFilterExpression);

                    if (lstStoreUnit != null && lstStoreUnit.Count > 0)
                    {
                        iNVTransferEntity.TransferToStoreUnitID = lstStoreUnit[0].StoreUnitID;
                    }

                }
            }

            if (ddlTransferFromStoreID != null && ddlTransferFromStoreID.Items.Count > 0)
            {
                iNVTransferEntity.TransferFromStoreID = Int64.Parse(ddlTransferFromStoreID.SelectedValue);

                String fe_storeUnit1 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_StoreID, ddlTransferFromStoreID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe_storeUnit2 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_IsDefault, "1", SQLMatchType.Equal);
                String fe_storeUnit = SqlExpressionBuilder.PrepareFilterExpression(fe_storeUnit1, SQLJoinType.AND, fe_storeUnit2);

                IList<INVStoreUnitEntity> lstStoreUnit = FCCINVStoreUnit.GetFacadeCreate().GetIL(null, null, String.Empty, fe_storeUnit, DatabaseOperationType.LoadWithFilterExpression);

                iNVTransferEntity.TransferFromStoreUnitID = lstStoreUnit[0].StoreUnitID;
            }

            iNVTransferEntity.Remarks = "Migrated From Requisition :" + rEQRequisitionEntity.Remarks;
            iNVTransferEntity.InventoryTransferStatusID = MasterDataConstants.INVTransferApprovalStatus.REQUESTED;
            iNVTransferEntity.RequisitionID = rEQRequisitionEntity.RequisitionID;

            return iNVTransferEntity;
        }

        private Int64 SaveINVTransferEntity()
        {
            Int64 result = -1;

            try
            {
                INVTransferEntity iNVTransferEntity = BuildINVTransferEntity();
                
                result = FCCINVTransfer.GetFacadeCreate().Add(iNVTransferEntity, DatabaseOperationType.Add, TransactionRequired.No);

                if (result > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
                    IList<REQRequisitionItemEntity> REQRequisitionItemList = FCCREQRequisitionItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    foreach (REQRequisitionItemEntity ent in REQRequisitionItemList)
                    {
                        INVTransferItemEntity iNVTransferItemEntity = new INVTransferItemEntity();
                        iNVTransferItemEntity.TransferID = result;

                        iNVTransferItemEntity.ItemID = ent.ItemID;
                        iNVTransferItemEntity.BrandID = ent.BrandID;
                        iNVTransferItemEntity.RegionID = ent.RegionID;
                        iNVTransferItemEntity.CountryID = ent.CountryID;
                        iNVTransferItemEntity.RequestQty = ent.PresentRequiredQty;
                        iNVTransferItemEntity.Remarks = null;

                        Int64 resultC = -1;

                        resultC = FCCINVTransferItem.GetFacadeCreate().Add(iNVTransferItemEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }

                    if (iNVTransferEntity.IsNew)
                    {
                        REQRequisitionEntity rEQRequisitionEntity = rEQRequisitionNormalEntity;
                        rEQRequisitionEntity.RequisitionStatusID = MasterDataConstants.RequisitionStatus.MIGRATE_TO_TRF;

                        String fe_req = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_RequisitionID, rEQRequisitionEntity.RequisitionID.ToString(), SQLMatchType.Equal);
                        FCCREQRequisition.GetFacadeCreate().Update(rEQRequisitionEntity, fe_req, DatabaseOperationType.Update, TransactionRequired.No);

                        MiscUtil.ShowMessage(lblMessage, "TRF Information has been added successfully.", false);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "TRF Information has been updated successfully.", false);
                    }
                }
                else
                {
                    if (iNVTransferEntity.IsNew)
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to add TRF Information.", false);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to update TRF Information.", false);
                    }
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            }

            return result;
        }

        private void BuildDropDownList()
        {
            if (!(APForwardInfoID > 0))
            {
                ddlAction.Items.Add(new ListItem("Approve", "1"));
                ddlAction.Items.Add(new ListItem("Back", "2"));
                ddlAction.Items.Add(new ListItem("Forward", "3"));

                APMemberFeedbackEntity ent = APRobot.GetAPMemberFeedbackByID(APMemberFeedbackID);

                ddlRejectTo.Items.Clear();
                ddlRejectTo.DataTextField = APMemberFeedback_DetailedEntity.FLD_NAME_MemberFullName;
                ddlRejectTo.DataValueField = APMemberFeedback_DetailedEntity.FLD_NAME_APMemberFeedbackID;
                ddlRejectTo.DataSource = APRobot.GetRejectToMemberFeedbacks_Detailed(APApprovalProcessID, ent.EmployeeID);
                ddlRejectTo.DataBind();
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                ddlRejectTo.Items.Insert(0, pleaseSelectListItem);

                ddlForwardTo.Items.Clear();
                ddlForwardTo.DataTextField = APPanelForwardMember_DetailedEntity.FLD_NAME_MemberFullName;
                ddlForwardTo.DataValueField = APPanelForwardMember_DetailedEntity.FLD_NAME_APPanelForwardMemberID;
                ddlForwardTo.DataSource = APRobot.GetAPPanelForwardMemberByApprovalProcessTypeAndReferenceID(MasterDataConstants.APType.REQUISITION, REQRequisitionID);
                ddlForwardTo.DataBind();
            }
            else
            {
                ddlAction.Items.Add(new ListItem("Comment", "4"));
            }
        }
        private void BindREQRequisitionUploadInfoList()
        {
            lvREQRequisitionUploadInfo.DataBind();
        }
        private void PrepareValidator()
        {
        }

        //private Boolean ValidateInputForUpdate()
        //{
        //    Boolean flag = true;

        //    try
        //    {

        //        Boolean result = false;

        //        result = true;
        //        IList<ListViewDataItem> listReq = lvREQRequisitionItem.Items;

        //        if (listReq != null && listReq.Count > 0)
        //        {
        //            foreach (ListViewDataItem lvdi in listReq)
        //            {
        //                Decimal reqestedQty, availableQty;
        //                Decimal requiredQtyDB = 0;
        //                Label lblPresentRequiredQtyDBLV = (Label)lvdi.FindControl("lblPresentRequiredQtyDBLV");
        //                Label lblAvailableQtyForReqisitionLV = (Label)lvdi.FindControl("lblAvailableQtyForReqisitionLV");
        //                TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");

        //                Decimal.TryParse(lblAvailableQtyForReqisitionLV.Text.Trim(), out availableQty);
        //                Decimal.TryParse(txtPresentRequiredQty.Text.Trim(), out reqestedQty);
        //                Decimal.TryParse(lblPresentRequiredQtyDBLV.Text.Trim(), out requiredQtyDB);

        //                if (availableQty < reqestedQty)
        //                {
        //                    flag = false;
        //                    MiscUtil.ShowMessage(lblMessage, "Requested qty should not be exceded available qty.", true);
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }

        //    return flag;
        //}

        //private Boolean ValidateInputApproval()
        //{
        //    Boolean flag = true;

        //    try
        //    {

        //    Boolean result = false;
            
        //    APMemberFeedbackEntity ent = FCCAPMemberFeedback.GetFacadeCreate().GetByID(APMemberFeedbackID);

        //    if (ent.APMemberFeedbackID > 0)
        //    {
        //        String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID, ent.APApprovalProcessID.ToString(), SQLMatchType.Equal);
        //        IList<APMemberFeedbackEntity> list = FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

        //        if (list != null && list.Count > 0)
        //        {
        //            APMemberFeedbackEntity item = list.OrderByDescending(x => x.SequenceNo).First();

        //            if (ent.SequenceNo == item.SequenceNo - 1)
        //            {
        //                result = true;
        //                IList<ListViewDataItem> listReq = lvREQRequisitionItem.Items;

        //                if (listReq != null && listReq.Count > 0)
        //                {
        //                    foreach (ListViewDataItem lvdi in listReq)
        //                    {

        //                        Decimal PresentRequiredQty, totalQty, rate, purchasedQty;
        //                        Int64 ItemID;

        //                        Label lblRate = (Label)lvdi.FindControl("lblRate");
        //                        Label lblItemID = (Label)lvdi.FindControl("lblItemLV");
        //                        Label txtQtyLV = (Label)lvdi.FindControl("txtQtyLV");
        //                        Label txtPurchasedQty = (Label)lvdi.FindControl("txtPurchasedQty");
        //                        //TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");

        //                        Decimal reqestedQty, availableQty;
        //                       // Decimal.TryParse(txtPresentRequiredQty.Text.Trim(), out PresentRequiredQty);
        //                        Decimal.TryParse(txtPurchasedQty.Text.Trim(), out purchasedQty);
        //                        Decimal.TryParse(txtQtyLV.Text.Trim(), out totalQty);
        //                        Decimal.TryParse(lblRate.Text.Trim(), out rate);
        //                        Int64.TryParse(lblItemID.Text, out ItemID);

        //                        //if (PresentRequiredQty + purchasedQty > totalQty)
        //                        //{
        //                        //    flag = false;
        //                        //    MiscUtil.ShowMessage(lblMessage, "Can't Exced Total Qty.", true);
        //                        //    break;
        //                        //}

        //                        Decimal requiredQtyDB = 0;
        //                        Label lblPresentRequiredQtyDBLV = (Label)lvdi.FindControl("lblPresentRequiredQtyDBLV");
        //                        Label lblAvailableQtyForReqisitionLV = (Label)lvdi.FindControl("lblAvailableQtyForReqisitionLV");
        //                        TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");

        //                        Decimal.TryParse(lblAvailableQtyForReqisitionLV.Text.Trim(), out availableQty);
        //                        Decimal.TryParse(txtPresentRequiredQty.Text.Trim(), out reqestedQty);
        //                        Decimal.TryParse(lblPresentRequiredQtyDBLV.Text.Trim(), out requiredQtyDB);

        //                        if (reqestedQty != requiredQtyDB)
        //                        {
        //                            reqestedQty = requiredQtyDB;
        //                        }

        //                        if (availableQty < reqestedQty)
        //                        {
        //                            flag = false;
        //                            MiscUtil.ShowMessage(lblMessage, "Requested qty should not be exceded available qty.", true);
        //                            break;
        //                        }

        //                        if (rate <= 0)
        //                        {
        //                            flag = false;
        //                            MiscUtil.ShowMessage(lblMessage, "Please Enter Item Price.", true);
        //                            break;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }   
                       
        //    }
        //    catch (Exception ex)
        //    {
        //    }

        //    return flag;
        //}

        private Boolean ValidateInputApproval()
        {
            Boolean flag = true;

            try
            {

                Boolean result = false;

                APMemberFeedbackEntity ent = FCCAPMemberFeedback.GetFacadeCreate().GetByID(APMemberFeedbackID);

                if (ent.APMemberFeedbackID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID, ent.APApprovalProcessID.ToString(), SQLMatchType.Equal);
                    IList<APMemberFeedbackEntity> list = FCCAPMemberFeedback.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (list != null && list.Count > 0)
                    {
                        APMemberFeedbackEntity item = list.OrderByDescending(x => x.SequenceNo).First();

                        if (ent.SequenceNo == item.SequenceNo - 1)
                        {
                            result = true;
                            IList<ListViewDataItem> listReq = lvREQRequisitionItem.Items;

                            if (listReq != null && listReq.Count > 0)
                            {
                                foreach (ListViewDataItem lvdi in listReq)
                                {

                                    Decimal PresentRequiredQty, totalQty, rate, purchasedQty;
                                    Int64 ItemID;

                                    Label lblRate = (Label)lvdi.FindControl("lblRate");
                                    Label lblItemID = (Label)lvdi.FindControl("lblItemLV");
                                    Label txtQtyLV = (Label)lvdi.FindControl("txtQtyLV");
                                    Label txtPurchasedQty = (Label)lvdi.FindControl("txtPurchasedQty");
                                    TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");


                                    Decimal.TryParse(txtPresentRequiredQty.Text.Trim(), out PresentRequiredQty);
                                    Decimal.TryParse(txtPurchasedQty.Text.Trim(), out purchasedQty);
                                    Decimal.TryParse(txtQtyLV.Text.Trim(), out totalQty);
                                    Decimal.TryParse(lblRate.Text.Trim(), out rate);
                                    Int64.TryParse(lblItemID.Text, out ItemID);

                                    if (PresentRequiredQty + purchasedQty > totalQty)
                                    {
                                        flag = false;
                                        MiscUtil.ShowMessage(lblMessage, "Can't Exced Total Qty.", true);
                                        break;
                                    }

                                    if (rate <= 0)
                                    {
                                        flag = false;
                                        MiscUtil.ShowMessage(lblMessage, "Please Enter Item Price.", true);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
            }

            return flag;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            lblRequisitonNo.Text = CurrentREQRequisitionEntity.RequisitionNo.ToString();
            lblProjectName.Text = CurrentREQRequisitionEntity.ProjectName.ToString();
            lblProjectCode.Text = CurrentREQRequisitionEntity.ProjectCode.ToString();
            lblRequisitonDate.Text = CurrentREQRequisitionEntity.RequisitionDate.ToString(UIConstants.SHORT_DATE_FORMAT);

            hypProjectID.Value = CurrentREQRequisitionEntity.ProjectID.ToString();

            if (CurrentREQRequisitionEntity.IsCashPayment)
            {
                lblCashPayment.ForeColor = System.Drawing.Color.Red;
                lblPayment.ForeColor = System.Drawing.Color.Red;
                lblPayment.Text = "Yes";
            }
            else
            {
                lblPayment.Text = "No";
            }

            #region AddvertisementRequisition
            Boolean IsAdvertisementRequisition = false;

            String feReqItem = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItemEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
            IList<REQRequisitionItem_DetailedEntity> lst = FCCREQRequisitionItem_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, feReqItem);

            if (lst != null && lst.Count > 0)
            {
                foreach (REQRequisitionItem_DetailedEntity entREQRequisitionItem_DetailedEntity in lst)
                {
                    if (entREQRequisitionItem_DetailedEntity.ItemCategoryID == MasterDataConstants.ItemDefaults.DEFAULT_ADVERTIESMENT_ITEM_CATEGORY)
                    {
                        IsAdvertisementRequisition = true;
                    }
                }
            }

            String NavigationUrl = String.Empty;

            NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "RequisitionReport", UrlConstants.REQUISITION_ID, REQRequisitionID.ToString()).ToString();

            if (IsAdvertisementRequisition)
            {
                NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.CRM_AD_REQUISITION_REPORT, UrlConstants.REQUISITION_ID, REQRequisitionID.ToString()).ToString();
            }
            hypRequisitionReport.NavigateUrl = NavigationUrl;
            hypRequisitionReport.Target = "_blank";

            #endregion AddvertisementRequisition

            //String NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.REQUISITION_REPORT, UrlConstants.REQUISITION_ID, REQRequisitionID.ToString()).ToString();
            //hypRequisitionReport.Target = "_blank";
            //hypRequisitionReport.NavigateUrl = NavigationUrl;

            BuildGrandTotalLabel();

            if (CurrentREQRequisitionEntity.Remarks.IsNotNullOrEmpty())
            {
                hypFileUrl.Visible = true;
                //hypFileUrl.Text = CurrentREQRequisitionEntity.Remarks;

                String _Reqremarks = null;
                string[] words = CurrentREQRequisitionEntity.Remarks.Split(' ');
                foreach (string word in words)
                {
                    if (word.Contains("http"))
                    {
                        _Reqremarks += "<a href='" + word + "'> File </a>";
                    }
                    else
                    {
                        _Reqremarks += " ";
                        _Reqremarks += word;
                    }
                }

                hypFileUrl.Text = _Reqremarks;
                hypFileUrl.Target = "_blank";
            }

            if (CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.WorkOrderStatus.CANCELED ||
               CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.WorkOrderStatus.APPROVED ||
               CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.WorkOrderStatus.REJECTED)
            {
                btnMigrateToTRF.Enabled = false;
            }

            if (APForwardInfoID > 0)
            {
                btnMigrateToTRF.Enabled = false;
            }

            #region Approval

            lvAPMemberFeedbackRemarks.DataSource = APRobot.GetMemberFeedbackRemarks_DetailedByApprovalProcessID(APApprovalProcessID);
            lvAPMemberFeedbackRemarks.DataBind();

            EnableDisableApprovalButtons();

            PrepareInitialViewPopup();

            #endregion

            mappedItemsFromDB = new List<REQRequisitionItemFloorDetailEntity>();
            populatedCheckedItems = new List<REQRequisitionItemFloorDetailEntity>();
        }

        private void BuildGrandTotalLabel()
        {
            if (REQRequisitionID > 0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
                IList<REQRequisitionItemEntity> lst = FCCREQRequisitionItem.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    var transinfo = (from transaction in lst
                                     select transaction.PresentRequiredQty * transaction.Rate).Sum(val => val);

                    //lblGrandTotal.Text = Math.Round(transinfo,2).ToString();
                    lblGrandTotal.Text = MiscUtil.NumericCommaSeperatedFormat((Decimal)transinfo);
                }
            }
        }

        private void EnableDisableApprovalButtons()
        {
            if (!(APForwardInfoID > 0))
            {
                APMemberFeedbackEntity ent = APRobot.GetAPMemberFeedbackByID(APMemberFeedbackID);

                if (ent.APFeedbackID == MasterDataConstants.APFeedback.APPROVED ||
                    ent.APFeedbackID == MasterDataConstants.APFeedback.REJECTED ||
                    ent.APFeedbackID == MasterDataConstants.APFeedback.NOT_YET_REQUESTED ||
                    ent.APFeedbackID == MasterDataConstants.APFeedback.CANCELED)
                {
                    btnApprove.Enabled = false;
                    btnReject.Enabled = false;
                    btnForward.Enabled = false;
                }
                else
                {
                    btnApprove.Enabled = true;
                    btnReject.Enabled = true;
                    btnForward.Enabled = true;
                }

                Boolean isAPFirstMember = APRobot.IsFirstMemberFeedback(APMemberFeedbackID);

                if (isAPFirstMember)
                {
                    if (ent.APFeedbackID == MasterDataConstants.APFeedback.APPROVED ||
                        ent.APFeedbackID == MasterDataConstants.APFeedback.REJECTED ||
                        ent.APFeedbackID == MasterDataConstants.APFeedback.NOT_YET_REQUESTED ||
                        ent.APFeedbackID == MasterDataConstants.APFeedback.CANCELED)
                    {
                        addPanel.Visible = false;
                        btnSubmit.Visible = false;
                    }
                    else
                    {
                        addPanel.Visible = true;
                        btnSubmit.Visible = true;
                    }
                }
                else
                {
                    addPanel.Visible = false;
                    btnSubmit.Visible = false;
                }
            }
            else
            {
                btnApprove.Enabled = false;
                btnReject.Enabled = false;
                btnForward.Enabled = false;

                addPanel.Visible = false;
                btnSubmit.Visible = false;
            }
        }

        private void PrepareEditView()
        {
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            if (hdEmpID.Value == "0")
            {
                if (txtItemName.Text.Trim().IsNotNullOrEmpty())
                {
                    MiscUtil.ShowMessage(lblMessage, "Invalid Item, Please Enter Correct BOQ Item.", true);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Please Select Pre-BOQ / BOQ Item.", true);
                }

                validationResult = false;
            }

            return validationResult;
        }


        private void PriceEntryValidateInput()
        {

            String fe = String.Empty;
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_ItemID, _CurrentItemID.ToString(), SQLMatchType.Equal);

            if (ddlBrandID.SelectedValue != "0" && ddlBrandID.Items.Count > 0)
            {
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_BrandID, ddlBrandID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            if (ddlSupplierID.SelectedValue != "0" && ddlSupplierID.Items.Count > 0)
            {
                String feSupplier = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_SupplierID, ddlSupplierID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, feSupplier);
            }

            if (ddlOriginRegionID.SelectedValue != "0")
            {
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_OriginRegionID, ddlOriginRegionID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            }

            if (ddlOriginCountryID.SelectedValue != "0")
            {
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_OriginCountryID, ddlOriginCountryID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe4);
            }

            IList<PRMSupplierItemMapEntity> supplierItemMapList = FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            PRMSupplierItemMapEntity ent = supplierItemMapList != null ? supplierItemMapList[0] : new PRMSupplierItemMapEntity();
            PRMSupplierItemMapEntity entPRMSupplierItemMapEntity = BuildPRMSupplierItemMapEntity(ent);

            Int64 result = -1;

            if (supplierItemMapList != null && supplierItemMapList.Count > 0)
            {
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_SupplierItemMapID, supplierItemMapList[0].SupplierItemMapID.ToString(), SQLMatchType.Equal);
                result = FCCPRMSupplierItemMap.GetFacadeCreate().Update(entPRMSupplierItemMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            }

            else
            {
                result = FCCPRMSupplierItemMap.GetFacadeCreate().Add(entPRMSupplierItemMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
            }

            if (result > 0)
            {
                MiscUtil.ShowMessage(lblMessage, "Price Updated Successfully.", false);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Some Error Occured.", true);
            }
        }

        private PRMSupplierItemMapEntity BuildPRMSupplierItemMapEntity(PRMSupplierItemMapEntity ent)
        {
            PRMSupplierItemMapEntity pRMSupplierItemMapEntity = ent;

            if (ddlSupplierID.Items.Count > 0)
            {
                if (ddlSupplierID.SelectedValue == "0")
                {
                    
                }
                else
                {
                    pRMSupplierItemMapEntity.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
                }
            }

            if (ddlBrandID.Items.Count > 0)
            {
                if (ddlBrandID.SelectedValue == "0")
                {
                   
                }
                else
                {
                    pRMSupplierItemMapEntity.BrandID = Int64.Parse(ddlBrandID.SelectedValue.ToString());
                }
            }

            pRMSupplierItemMapEntity.ItemID = Int64.Parse(_CurrentItemID.ToString());

            if (ddlOriginRegionID.Items.Count > 0)
            {
                if (ddlOriginRegionID.SelectedValue == "0")
                {
                    pRMSupplierItemMapEntity.OriginRegionID = null;
                }
                else
                {
                    pRMSupplierItemMapEntity.OriginRegionID = Int64.Parse(ddlOriginRegionID.SelectedValue);
                }
            }

            if (ddlOriginCountryID.Items.Count > 0)
            {
                if (ddlOriginCountryID.SelectedValue == "0")
                {
                    pRMSupplierItemMapEntity.OriginCountryID = null;
                }
                else
                {
                    pRMSupplierItemMapEntity.OriginCountryID = Int64.Parse(ddlOriginCountryID.SelectedValue);
                }
            }

            if (!txtPrice.Text.Trim().IsNullOrEmpty())
            {
                pRMSupplierItemMapEntity.DiscountPercentage = 0;
                pRMSupplierItemMapEntity.ActualPrice = Decimal.Parse(txtPrice.Text.Trim());
                pRMSupplierItemMapEntity.Price = Decimal.Parse(txtPrice.Text.Trim());
                pRMSupplierItemMapEntity.EntryDate = System.DateTime.Now;

            }
            pRMSupplierItemMapEntity.Model = null;
            pRMSupplierItemMapEntity.WarrantyPeriod = null;
            pRMSupplierItemMapEntity.IsRemoved = false;

            return pRMSupplierItemMapEntity;
        }

        private REQRequisitionItemEntity BuildREQRequisitionItemEntity()
        {
            REQRequisitionItemEntity rEQRequisitionItemEntity = CurrentREQRequisitionItemEntity;

            rEQRequisitionItemEntity.RequisitionID = REQRequisitionID;

            //Need to change Here.
            Int64 ItemID = Int64.Parse(hdEmpID.Value);
            rEQRequisitionItemEntity.AccountsCode = "000";//
            rEQRequisitionItemEntity.ItemID = ItemID;
            rEQRequisitionItemEntity.Rate = 0;// 
            rEQRequisitionItemEntity.TotalRequiredQty = 0;//

            if (ItemID > 0)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionItem_CustomEntity.FLD_NAME_ProjectID, hypProjectID.Value.ToString(), SQLMatchType.Equal);
                IList<REQRequisitionItem_CustomEntity> _rEQRequisitionItemList = FCCREQRequisitionItem_Custom.GetFacadeCreate().GetIL(fe1);

                if (_rEQRequisitionItemList != null && _rEQRequisitionItemList.Count > 0)
                {
                    System.Nullable<Decimal> totalFreight = (from ord in _rEQRequisitionItemList
                                                             select ord.PresentRequiredQty)
                                                                .Sum();
                    if (totalFreight > 0)
                    {
                        rEQRequisitionItemEntity.PurchasedQtyTillToDate = totalFreight;
                    }
                    else
                    {
                        rEQRequisitionItemEntity.PurchasedQtyTillToDate = 0;
                    }
                }
            }

            rEQRequisitionItemEntity.PresentRequiredQty = 1;
            rEQRequisitionItemEntity.RequiredDate = System.DateTime.Now;
            rEQRequisitionItemEntity.Remarks = String.Empty;
            //End Here.

            #region DECISION MAKING AREA

            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, CurrentREQRequisitionEntity.ProjectID.ToString(), SQLMatchType.Equal);
            IList<PRMPreBOQEntity> preBOQList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (preBOQList != null && preBOQList.Count > 0)
            {
                Int64 preBOQID = preBOQList[0].PreBOQID;

                switch (preBOQList[0].IsLocked)
                {
                    case true:
                        String fepreBOQID = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                        IList<PRMBOQEntity> BOQList = FCCPRMBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fepreBOQID, DatabaseOperationType.LoadWithFilterExpression);

                        if (BOQList != null && BOQList.Count > 0)
                        {
                            Int64 BOQID = BOQList[0].BOQID;

                            String feBOQ1 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQID, BOQID.ToString(), SQLMatchType.Equal);
                            String feBOQ2 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_ItemID, hdEmpID.Value.ToString(), SQLMatchType.Equal);
                            String feBOQ = SqlExpressionBuilder.PrepareFilterExpression(feBOQ1, SQLJoinType.AND, feBOQ2);

                            IList<PRMBOQDetailEntity> BOQDetailList = FCCPRMBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, feBOQ, DatabaseOperationType.LoadWithFilterExpression);

                            if (BOQDetailList != null && BOQDetailList.Count > 0)
                            {
                                rEQRequisitionItemEntity.BrandID = BOQDetailList[0].BrandID;
                                rEQRequisitionItemEntity.SupplierID = BOQDetailList[0].SupplierID;
                                rEQRequisitionItemEntity.RegionID = BOQDetailList[0].RegionID;
                                rEQRequisitionItemEntity.CountryID = BOQDetailList[0].CountryID;
                                rEQRequisitionItemEntity.Rate = BOQDetailList[0].Rate;
                                rEQRequisitionItemEntity.TotalRequiredQty = BOQDetailList[0].TotalQty;
                            }
                        }
                        break;

                    case false:
                        String fePreBOQ1 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                        String fePreBOQ2 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_ItemID, hdEmpID.Value.ToString(), SQLMatchType.Equal);
                        String fePreBOQ = SqlExpressionBuilder.PrepareFilterExpression(fePreBOQ1, SQLJoinType.AND, fePreBOQ2);
                        IList<PRMPreBOQDetailEntity> preBOQDetailList = FCCPRMPreBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fePreBOQ, DatabaseOperationType.LoadWithFilterExpression);

                        if (preBOQDetailList != null && preBOQDetailList.Count > 0)
                        {
                            rEQRequisitionItemEntity.BrandID = preBOQDetailList[0].BrandID;
                            rEQRequisitionItemEntity.SupplierID = preBOQDetailList[0].SupplierID;
                            rEQRequisitionItemEntity.RegionID = preBOQDetailList[0].RegionID;
                            rEQRequisitionItemEntity.CountryID = preBOQDetailList[0].CountryID;
                            rEQRequisitionItemEntity.Rate = preBOQDetailList[0].Rate;
                            rEQRequisitionItemEntity.TotalRequiredQty = preBOQDetailList[0].TotalQty;
                        }
                        break;

                    default:
                        break;
                }
            }

            //hypRequisitionReport.Visible = true;

            #endregion

            return rEQRequisitionItemEntity;
        }

        private void BindList()
        {
            BindREQRequisitionItemList();
        }

        private void BindREQRequisitionItemList()
        {
            lvREQRequisitionItem.DataBind();
        }

        private void PreAddSaveREQRequisitionItemEntity()
        {
            try
            {
                IList<ListViewDataItem> list = lvREQRequisitionItem.Items;

                if (list != null && list.Count > 0)
                {
                   // hypRequisitionReport.Visible = true;

                    foreach (ListViewDataItem lvdi in list)
                    {

                        Decimal PresentRequiredQty;
                        Int64 ItemID;

                        Label lblItemID = (Label)lvdi.FindControl("lblItemLV");
                        TextBox txtAccCodeLV = (TextBox)lvdi.FindControl("txtAccCodeLV");
                        Label txtQtyLV = (Label)lvdi.FindControl("txtQtyLV");
                        Label txtPurchasedQty = (Label)lvdi.FindControl("txtPurchasedQty");
                        TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");
                        TextBox txtRequiredDate = (TextBox)lvdi.FindControl("txtRequiredDate");
                        TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");

                        Decimal.TryParse(txtPresentRequiredQty.Text.Trim(), out PresentRequiredQty);
                        Int64.TryParse(lblItemID.Text, out ItemID);

                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_ItemID, ItemID.ToString(), SQLMatchType.Equal);
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                        IList<REQRequisitionItemEntity> RequisitionItemList = FCCREQRequisitionItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                        if (RequisitionItemList != null && RequisitionItemList.Count > 0)
                        {
                            REQRequisitionItemEntity rEQRequisitionItem = RequisitionItemList[0];
                            rEQRequisitionItem.RequisitionID = REQRequisitionID;
                            rEQRequisitionItem.AccountsCode = txtAccCodeLV.Text.ToString();
                            rEQRequisitionItem.PresentRequiredQty = PresentRequiredQty;
                            rEQRequisitionItem.ItemID = ItemID;
                            rEQRequisitionItem.Remarks = txtRemarksLV.Text.ToString();
                            if (txtRequiredDate.Text.Trim().IsNotNullOrEmpty())
                            {
                                rEQRequisitionItem.RequiredDate = MiscUtil.ParseToDateTime(txtRequiredDate.Text);
                            }
                            //Another Entity Item may be added Here.
                            FCCREQRequisitionItem.GetFacadeCreate().Update(rEQRequisitionItem, fe, DatabaseOperationType.Update, TransactionRequired.No);
                        }
                    }
                }
                BindREQRequisitionItemList();
            }
            catch (Exception ex)
            {
            }
        }

        private void SaveREQRequisitionItemEntity()
        {
            try
            {
                IList<ListViewDataItem> list = lvREQRequisitionItem.Items;

                if (list != null && list.Count > 0)
                {
                   // hypRequisitionReport.Visible = true;

                    foreach (ListViewDataItem lvdi in list)
                    {

                        Decimal PresentRequiredQty;
                        Int64 ItemID,requisitionItem;

                        Label lblRequisitionItemIDLV = (Label)lvdi.FindControl("lblRequisitionItemIDLV");
                        Label lblItemID = (Label)lvdi.FindControl("lblItemLV");
                        TextBox txtAccCodeLV = (TextBox)lvdi.FindControl("txtAccCodeLV");
                        Label txtQtyLV = (Label)lvdi.FindControl("txtQtyLV");
                        Label txtPurchasedQty = (Label)lvdi.FindControl("txtPurchasedQty");
                        TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");
                        TextBox txtRequiredDate = (TextBox)lvdi.FindControl("txtRequiredDate");
                        TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");

                        Decimal.TryParse(txtPresentRequiredQty.Text.Trim(), out PresentRequiredQty);
                        Int64.TryParse(lblItemID.Text, out ItemID);
                        Int64.TryParse(lblRequisitionItemIDLV.Text, out requisitionItem);

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, requisitionItem.ToString(), SQLMatchType.Equal);
                        REQRequisitionItemEntity requisitionItemEntity = FCCREQRequisitionItem.GetFacadeCreate().GetByID(requisitionItem);

                        if (requisitionItemEntity != null && requisitionItemEntity.RequisitionItemID > 0)
                        {
                            REQRequisitionItemEntity rEQRequisitionItem = requisitionItemEntity;
                            rEQRequisitionItem.RequisitionID = REQRequisitionID;
                            rEQRequisitionItem.AccountsCode = txtAccCodeLV.Text.ToString();
                            rEQRequisitionItem.PresentRequiredQty = PresentRequiredQty;
                            rEQRequisitionItem.ItemID = ItemID;
                            rEQRequisitionItem.Remarks = txtRemarksLV.Text.ToString();
                            if (txtRequiredDate.Text.Trim().IsNotNullOrEmpty())
                            {
                                rEQRequisitionItem.RequiredDate = MiscUtil.ParseToDateTime(txtRequiredDate.Text);
                            }
                            //Another Entity Item may be added Here.
                            FCCREQRequisitionItem.GetFacadeCreate().Update(rEQRequisitionItem, fe, DatabaseOperationType.Update, TransactionRequired.No);
                        }
                    }
                    MiscUtil.ShowMessage(lblMessage, "Requisition Item Information has been saved successfully.", false);
                }
                BindREQRequisitionItemList();
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to save Requisition Item Information.", true);
            }
        }

        private void AddREQRequisitionItemEntity()
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
                        txtItemName.Text = "";
                        hdEmpID.Value = "0";
                        PrepareInitialView();
                        BindREQRequisitionItemList();

                        if (rEQRequisitionItemEntity.IsNew)
                        {
                            //MiscUtil.ShowMessage(lblMessage, "Requisition Item Information has been added successfully.", false);
                        }
                        else
                        {
                            //MiscUtil.ShowMessage(lblMessage, "Requisition Item Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (rEQRequisitionItemEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Requisition Item Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Requisition Item Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
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
            String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, _RequisitionItemID.ToString(), SQLMatchType.Equal);

            REQRequisitionItemEntity RequisitionItem = FCCREQRequisitionItem.GetFacadeCreate().GetByID(_RequisitionItemID);

            if (RequisitionItem != null)
            {
                try
                {
                    REQRequisitionItemEntity reqRequisitionItem = RequisitionItem;
                    reqRequisitionItem.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                    reqRequisitionItem.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
                    reqRequisitionItem.RegionID = Int64.Parse(ddlOriginRegionID.SelectedValue);
                    reqRequisitionItem.CountryID = Int64.Parse(ddlOriginCountryID.SelectedValue);
                    GetCurrentPrice();
                    reqRequisitionItem.Rate = Decimal.Parse(this.txtPrice.Text.ToString());

                    FCCREQRequisitionItem.GetFacadeCreate().Update(reqRequisitionItem, fe, DatabaseOperationType.Update, TransactionRequired.No);

                    BindList();

                    MiscUtil.ShowMessage(lblMessage, "Requisition Item Rate has been successfully Updated.", false);
                }

                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private String AddProxyMemberInfo(String remarks)
        {
            if (ProxyEmployeeID > 0)
            {
                APMemberFeedback_DetailedEntity ent = APRobot.GetMemberFeedback_DetailedByAPMemberFeedbackID(APMemberFeedbackID);
                remarks += "<br />";
                remarks += "<br />";
                remarks += "<b><i>This action has been taken by proxy member - " + ent.ProxyMemberFullName + "</i></b>";
            }

            return remarks;
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            btnApprove.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnApprove, "").ToString());
            btnReject.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnReject, "").ToString());
            btnSubmitComment.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnSubmitComment, "").ToString());
            btnForward.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnForward, "").ToString());

            afuFiles.UploadedComplete += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedComplete);
            afuFiles.UploadedFileError += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedFileError);
   
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event
        protected void lvREQRequisitionUploadInfo_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                LinkButton lnkBtnDelete = (LinkButton)e.Item.FindControl("lnkBtnDelete");

                if (CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.APPROVED)
                {
                    lnkBtnDelete.Visible = false;
                }
            }
        }
        protected void lvREQRequisitionUploadInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 RequisitionUploadInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out RequisitionUploadInfoID);

            if (RequisitionUploadInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _RequisitionUploadInfoID = RequisitionUploadInfoID;
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionUploadInfoEntity.FLD_NAME_RequisitionUploadInfoID, RequisitionUploadInfoID.ToString(), SQLMatchType.Equal);

                        REQRequisitionUploadInfoEntity rEQRequisitionUploadInfoEntity = new REQRequisitionUploadInfoEntity();


                        result = FCCREQRequisitionUploadInfo.GetFacadeCreate().Delete(rEQRequisitionUploadInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _RequisitionUploadInfoID = 0;
                            PrepareInitialView();
                            BindREQRequisitionUploadInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Requisition Upload Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Requisition Upload Info.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        protected void lvREQRequisitionItemFloorDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                CheckBox chbxSelectLV = (CheckBox)e.Item.FindControl("chbxSelectLV");
                Label lblProjectFloorIDLV = (Label)e.Item.FindControl("lblProjectFloorIDLV");
                TextBox txtQtyLV = (TextBox)e.Item.FindControl("txtQtyLV");
                TextBox txtRateLV = (TextBox)e.Item.FindControl("txtRateLV");
                TextBox txtRemarksLV = (TextBox)e.Item.FindControl("txtRemarksLV");

                DropDownList ddlProjectFloorUnitIDLV = (DropDownList)e.Item.FindControl("ddlProjectFloorUnitIDLV");
                DropDownList ddProjectUnitLocationIDLV = (DropDownList)e.Item.FindControl("ddProjectUnitLocationIDLV");
                if (rEQRequisitionNormalEntity.IsRCS != false)
                {
                    MiscUtil.PopulateBDProjectFloorUnitByFloor(ddlProjectFloorUnitIDLV, false, Int64.Parse(lblProjectFloorIDLV.Text));

                    if (ddlProjectFloorUnitIDLV != null && ddlProjectFloorUnitIDLV.Items.Count > 0)
                    {
                        MiscUtil.PopulateBDProjectFloorUnitByFloor(ddProjectUnitLocationIDLV, false, Int64.Parse(ddlProjectFloorUnitIDLV.SelectedValue.ToString()));
                    }
                }
                else
                {
                    ddlProjectFloorUnitIDLV.Enabled = false;
                    ddProjectUnitLocationIDLV.Enabled = false;
                }

                ddlProjectFloorUnitIDLV.SelectedIndexChanged += new EventHandler(ddlProjectFloorUnitIDLV_SelectedIndexChanged);

                if (CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.APPROVED)
                {
                    chbxSelectLV.Enabled = false;
                }


                IList<REQRequisitionItemFloorDetailEntity> lst = REQRequisitionItemFloorDetailList;

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

        protected void ddlProjectFloorUnitIDLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList dropDownList = (DropDownList)sender;
            ListViewItem item = (ListViewItem)dropDownList.NamingContainer;
            DropDownList ddProjectUnitLocationIDLV = (DropDownList)item.FindControl("ddProjectUnitLocationIDLV");
            MiscUtil.ShowMessage(lblMessage, (((DropDownList)sender).SelectedValue).ToString(), false);
            MiscUtil.PopulateBDProjectFloorUnitByFloor(ddProjectUnitLocationIDLV, false, Int64.Parse(((DropDownList)sender).SelectedValue.ToString()));

            this.ModalPopupExtender2.Show();
        }

        protected void lvREQRequisitionItem_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                TextBox txtAccCodeLV = (TextBox)e.Item.FindControl("txtAccCodeLV");
                Label txtTotalQtyLV = (Label)e.Item.FindControl("txtQtyLV");
                Label txtPurchasedQty = (Label)e.Item.FindControl("txtPurchasedQty");
                TextBox txtPresentRequiredQty = (TextBox)e.Item.FindControl("txtPresentRequiredQty");
                TextBox txtRequiredDate = (TextBox)e.Item.FindControl("txtRequiredDate");
                TextBox txtRemarksLV = (TextBox)e.Item.FindControl("txtRemarksLV");
                LinkButton lnkBtnModifyPrice = (LinkButton)e.Item.FindControl("lnkBtnModifyPrice");
                
                Label lblRequisitionItemIDLV = (Label)e.Item.FindControl("lblRequisitionItemIDLV");

                Int64 requisitionItemIDLV;
                Int64.TryParse(lblRequisitionItemIDLV.Text, out requisitionItemIDLV);

                if (requisitionItemIDLV > 0)
                {
                    String fe_req = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemFloorDetailEntity.FLD_NAME_RequisitionItemID, requisitionItemIDLV.ToString(), SQLMatchType.Equal);
                    IList<REQRequisitionItemFloorDetailEntity> lstREQRequisitionItemFloorDetail = FCCREQRequisitionItemFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_req, DatabaseOperationType.LoadWithFilterExpression);

                    if (lstREQRequisitionItemFloorDetail != null && lstREQRequisitionItemFloorDetail.Count > 0)
                    {
                        lnkBtnModifyPrice.Visible = false;
                        txtPresentRequiredQty.ReadOnly = true;
                        lblModifyPriceInfo.Visible = true;
                    }
                    else
                    {
                        txtPresentRequiredQty.ReadOnly = false;
                        lnkBtnModifyPrice.Visible = true;
                        lblModifyPriceInfo.Visible = false;
                    }
                }

                Decimal totalQty;
                Decimal purchasedQty;

                Int64 itemID;

                Label lblItemLV = (Label)e.Item.FindControl("lblItemLV");

                Int64.TryParse(lblItemLV.Text, out itemID);

                #region BOQ / Project Cost Qty

                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, CurrentREQRequisitionEntity.ProjectID.ToString(), SQLMatchType.Equal);
                IList<PRMPreBOQEntity> preBOQList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (preBOQList != null && preBOQList.Count > 0)
                {
                    Int64 preBOQID = preBOQList[0].PreBOQID;

                    switch (preBOQList[0].IsLocked)
                    {
                        case true:
                            String fepreBOQID = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                            IList<PRMBOQEntity> BOQList = FCCPRMBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fepreBOQID, DatabaseOperationType.LoadWithFilterExpression);

                            if (BOQList != null && BOQList.Count > 0)
                            {
                                Int64 BOQID = BOQList[0].BOQID;

                                String feBOQ1 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQID, BOQID.ToString(), SQLMatchType.Equal);
                                String feBOQ2 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_ItemID, itemID.ToString(), SQLMatchType.Equal);
                                String feBOQ = SqlExpressionBuilder.PrepareFilterExpression(feBOQ1, SQLJoinType.AND, feBOQ2);

                                IList<PRMBOQDetailEntity> BOQDetailList = FCCPRMBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, feBOQ, DatabaseOperationType.LoadWithFilterExpression);

                                if (BOQDetailList != null && BOQDetailList.Count > 0)
                                {
                                    txtTotalQtyLV.Text = BOQDetailList[0].TotalQty.ToString();
                                }
                            }
                            break;

                        case false:
                            String fePreBOQ1 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                            String fePreBOQ2 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_ItemID, itemID.ToString(), SQLMatchType.Equal);
                            String fePreBOQ = SqlExpressionBuilder.PrepareFilterExpression(fePreBOQ1, SQLJoinType.AND, fePreBOQ2);
                            IList<PRMPreBOQDetailEntity> preBOQDetailList = FCCPRMPreBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fePreBOQ, DatabaseOperationType.LoadWithFilterExpression);

                            if (preBOQDetailList != null && preBOQDetailList.Count > 0)
                            {
                                txtTotalQtyLV.Text = preBOQDetailList[0].TotalQty.ToString();
                            }
                            break;

                        default:
                            break;
                    }
                }

                #endregion

                Decimal.TryParse(txtTotalQtyLV.Text.ToString(), out totalQty);
                Decimal.TryParse(txtPurchasedQty.Text.ToString(), out purchasedQty);

                if (purchasedQty >= totalQty)
                {
                    txtPurchasedQty.ForeColor = System.Drawing.Color.Red;
                }

                else if (purchasedQty < totalQty)
                {
                    txtPurchasedQty.ForeColor = System.Drawing.Color.Black;
                }


                txtTotalQtyLV.Enabled = false;
                txtPurchasedQty.Enabled = false;
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;
                REQRequisitionItem_DetailedEntity ent = (REQRequisitionItem_DetailedEntity)dataItem.DataItem;
                txtRequiredDate.Text = ent.RequiredDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                txtRemarksLV.Text = ent.Remarks.ToString();


                Boolean isAPFirstMember = APRobot.IsFirstMemberFeedback(APMemberFeedbackID);

                LinkButton lnkBtnDelete = (LinkButton)e.Item.FindControl("lnkBtnDelete");
                

                APMemberFeedbackEntity aPMemberFeedbackEntity = APRobot.GetAPMemberFeedbackByID(APMemberFeedbackID);

                //if (!(APForwardInfoID > 0))
                //{
                    if (true) //if (isAPFirstMember)
                    {
                        if (aPMemberFeedbackEntity.APFeedbackID == MasterDataConstants.APFeedback.APPROVED || aPMemberFeedbackEntity.APFeedbackID == MasterDataConstants.APFeedback.REJECTED || aPMemberFeedbackEntity.APFeedbackID == MasterDataConstants.APFeedback.NOT_YET_REQUESTED || aPMemberFeedbackEntity.APFeedbackID == MasterDataConstants.APFeedback.CANCELED)
                        {
                            lnkBtnDelete.Visible = false;
                            lnkBtnModifyPrice.Visible = false;
                        }
                        else
                        {
                            lnkBtnDelete.Visible = true;

                            if (lnkBtnModifyPrice.Visible!=false)
                            {
                                lnkBtnModifyPrice.Visible = true;
                            }
                        }
                    }
                    //else
                    //{
                    //    lnkBtnDelete.Visible = false;
                    //    lnkBtnModifyPrice.Visible = false;
                    //}
                //}
                //else
                //{
                //    trDelete.Visible = false;
                //    lnkBtnModifyPrice.Visible = false;
                //}
            }
        }
        
        protected void lvREQRequisitionItem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 RequisitionItemID;

            Int64.TryParse(e.CommandArgument.ToString(), out RequisitionItemID);

            if (e.CommandName == "ModifyPrice")
            {
                Int64 ItemID;

                Label lblItemLV = (Label)e.Item.FindControl("lblItemLV");
                Label lblUnitLV = (Label)e.Item.FindControl("lblUnitLV");

                Int64.TryParse(lblItemLV.Text.ToString(), out ItemID);

                if (RequisitionItemID > 0)
                {
                    MiscUtil.PopulateMDBrandByItemID(ddlBrandID, false, Int64.Parse(ItemID.ToString()));

                    String unitNameLV = String.Empty;

                    if (lblUnitLV.Text.IsNotNullOrEmpty())
                    {
                        unitNameLV = " (" + lblUnitLV.Text + ") ";
                    }

                    this.lblItemName.Text = ((Label)e.Item.FindControl("lblItemNameLV")).Text + unitNameLV;

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
                    _RequisitionItemID = RequisitionItemID;

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
            else
            {
                if (RequisitionItemID > 0)
                {

                    if (e.CommandName == "FloorWiseRateAndQty")
                    {
                        CurrentRequisitionItemIDPopup = RequisitionItemID;

                        Label lblItemLV = (Label)e.Item.FindControl("lblItemLV");

                        Int64 itemID;
                        Int64.TryParse(lblItemLV.Text.Trim(), out itemID);

                        String fe_floor = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorEntity.FLD_NAME_ProjectID, CurrentREQRequisitionEntity.ProjectID.ToString(), SQLMatchType.Equal);
                        IList<BDProjectFloorEntity> lstBDProjectFloor = FCCBDProjectFloor.GetFacadeCreate().GetIL(null, null, String.Empty, fe_floor, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstBDProjectFloor != null && lstBDProjectFloor.Count > 0)
                        {
                            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, CurrentREQRequisitionEntity.ProjectID.ToString(), SQLMatchType.Equal);
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
                        lblFloorWiseItemName.Text = lblItemNameLV.Text.ToString();
                        this.ModalPopupExtender2.Show();

                        if (lvREQRequisitionItemFloorDetail.DataSource != null)
                        {
                            btnFloorPopupSave.Enabled = true;
                        }
                        else
                        {
                            btnFloorPopupSave.Enabled = false;
                        }

                        if (CurrentREQRequisitionEntity.RequisitionStatusID != MasterDataConstants.RequisitionStatus.APPROVED)
                        {
                            btnFloorPopupSave.Enabled = true;
                            lblLockMessage.Visible = false;
                        }

                        else
                        {   
                            lblLockMessage.Visible = true;
                        }
                    }

                    LinkButton lnkBtnEdit = (LinkButton)e.Item.FindControl("lnkBtnEdit");
                    TextBox txtPresentRequiredQty = (TextBox)e.Item.FindControl("txtPresentRequiredQty");

                    if (string.Equals(e.CommandName, "EditItem") && txtPresentRequiredQty.Enabled == true)
                    {
                        txtPresentRequiredQty.Text = ItemQty.ToString();
                        txtPresentRequiredQty.Enabled = false;
                        lnkBtnEdit.Text = "Edit";
                    }

                    else if (string.Equals(e.CommandName, "EditItem") && txtPresentRequiredQty.Enabled == false)
                    {
                        _RequisitionItemID = RequisitionItemID;

                        PrepareEditView();

                        txtPresentRequiredQty.Enabled = true;
                        ItemQty = Decimal.Parse(txtPresentRequiredQty.Text);
                        lnkBtnEdit.Text = "Cancel";

                    }
                    else if (string.Equals(e.CommandName, "DeleteItem"))
                    {
                        try
                        {
                            Int64 result = -1;

                            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, RequisitionItemID.ToString(), SQLMatchType.Equal);
                            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
                            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                            REQRequisitionItemEntity rEQRequisitionItemEntity = new REQRequisitionItemEntity();


                            result = FCCREQRequisitionItem.GetFacadeCreate().Delete(rEQRequisitionItemEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                            if (result == 0)
                            {
                                _RequisitionItemID = 0;
                                _REQRequisitionItemEntity = new REQRequisitionItemEntity();
                                PrepareInitialView();
                                BindREQRequisitionItemList();
                                IList<ListViewDataItem> list = lvREQRequisitionItem.Items;

                                if (list == null || list.Count <= 0)
                                {
                                  //  hypRequisitionReport.Visible = false;
                                }

                                MiscUtil.ShowMessage(lblMessage, "Requisition Item has been successfully deleted.", true);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to delete Requisition Item.", true);
                            }
                        }
                        catch (Exception ex)
                        {
                            MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                        }
                    }
                }
            }
        }

        protected void lvAPMemberFeedbackRemarks_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                APMemberFeedbackRemarks_DetailedEntity ent = (APMemberFeedbackRemarks_DetailedEntity)e.Item.DataItem;

                APForwardInfo_DetailedEntity aPForwardInfo_DetailedEntity = APRobot.GetAPForwardInfo_DetailedByRemarksID(ent.APMemberFeedbackRemarksID);

                if (aPForwardInfo_DetailedEntity.APForwardInfoID > 0)
                {
                    HtmlGenericControl forwardInfoDiv = (HtmlGenericControl)e.Item.FindControl("forwardInfoDiv");

                    forwardInfoDiv.InnerHtml = "<br />";
                    forwardInfoDiv.InnerHtml += "<b>Forwading Remarks By Panel Member</b>";
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += aPForwardInfo_DetailedEntity.APMemberComment;
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += "<b>Response By " + aPForwardInfo_DetailedEntity.MemberFullName + "</b>";
                    if (aPForwardInfo_DetailedEntity.CommentSubmitDate.HasValue)
                    {
                        forwardInfoDiv.InnerHtml += " on <b>" + aPForwardInfo_DetailedEntity.CommentSubmitDate.ToString(UIConstants.SHORT_DATE_TIME_FORMAT) + "</b>";
                    }
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += aPForwardInfo_DetailedEntity.APForwardMemberComment;
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += "<br />";
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsREQRequisitionItem_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {  
            String fe = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItemEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        protected void odsREQRequisitionItemFloorDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (_RequisitionItemID > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItemFloorDetail." + REQRequisitionItemFloorDetailEntity.FLD_NAME_RequisitionItemID, _RequisitionItemID.ToString(), SQLMatchType.Equal);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        protected void odsREQRequisitionUploadInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionUploadInfoEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnFloorPopupSave_Click(object sender, EventArgs e)
        {
            try
            {
                String fe_db = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemFloorDetailEntity.FLD_NAME_RequisitionItemID, CurrentRequisitionItemIDPopup.ToString(), SQLMatchType.Equal);
                mappedItemsFromDB = FCCREQRequisitionItemFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_db, DatabaseOperationType.LoadWithFilterExpression);

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

                            REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity = new REQRequisitionItemFloorDetailEntity();

                            DropDownList ddlProjectFloorUnitIDLV = (DropDownList)lvdi.FindControl("ddlProjectFloorUnitIDLV");
                            DropDownList ddProjectUnitLocationIDLV = (DropDownList)lvdi.FindControl("ddProjectUnitLocationIDLV");

                            if (ddlProjectFloorUnitIDLV.Items.Count > 0)
                            {
                                if (ddlProjectFloorUnitIDLV.SelectedValue == "0")
                                {
                                    rEQRequisitionItemFloorDetailEntity.ProjectFloorUnitID = null;
                                }
                                else
                                {
                                    rEQRequisitionItemFloorDetailEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitIDLV.SelectedValue);
                                }
                            }
                            else
                            {
                                rEQRequisitionItemFloorDetailEntity.ProjectFloorUnitID = null;
                            }

                            if (ddProjectUnitLocationIDLV.Items.Count > 0)
                            {
                                if (ddProjectUnitLocationIDLV.SelectedValue == "0")
                                {
                                    rEQRequisitionItemFloorDetailEntity.ProjectUnitLocationID = null;
                                }
                                else
                                {
                                    rEQRequisitionItemFloorDetailEntity.ProjectUnitLocationID = Int64.Parse(ddProjectUnitLocationIDLV.SelectedValue);
                                }
                            }
                            else
                            {
                                rEQRequisitionItemFloorDetailEntity.ProjectUnitLocationID = null;
                            }

                            rEQRequisitionItemFloorDetailEntity.RequisitionItemID = CurrentRequisitionItemIDPopup;
                            rEQRequisitionItemFloorDetailEntity.ProjectFloorID = Int64.Parse(lblProjectFloorIDLV.Text.Trim());
                            rEQRequisitionItemFloorDetailEntity.RequisitionID = CurrentREQRequisitionEntity.RequisitionID;
                            rEQRequisitionItemFloorDetailEntity.ProjectFloorUnitID = null;
                            rEQRequisitionItemFloorDetailEntity.Qty = newQty;
                            rEQRequisitionItemFloorDetailEntity.Rate = floorRate;
                            rEQRequisitionItemFloorDetailEntity.Remarks = txtRemarksLV.Text;
                            rEQRequisitionItemFloorDetailEntity.EntryDate = System.DateTime.Now;

                            populatedCheckedItems.Add(rEQRequisitionItemFloorDetailEntity);
                            totalSelectedFloor += 1;
                            totalFloorQty += newQty;
                            totalRate += floorRate;
                        }
                    }
                }

                if (mappedItemsFromDB != null && mappedItemsFromDB.Count > 0)
                {
                    IList<REQRequisitionItemFloorDetailEntity> finalAddList = populatedCheckedItems.Except(mappedItemsFromDB, new CustomerComparer()).ToList();
                    IList<REQRequisitionItemFloorDetailEntity> finalDeleteList = mappedItemsFromDB.Except(populatedCheckedItems, new CustomerComparer()).ToList();

                    if (finalAddList != null && finalAddList.Count > 0)
                    {
                        foreach (REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity in finalAddList)
                        {
                            FCCREQRequisitionItemFloorDetail.GetFacadeCreate().Add(rEQRequisitionItemFloorDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                    }

                    if (finalDeleteList != null && finalDeleteList.Count > 0)
                    {
                        foreach (REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity in finalDeleteList)
                        {
                            String fe_del = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemFloorDetailEntity.FLD_NAME_RequisitionItemFloorDetailID, rEQRequisitionItemFloorDetailEntity.RequisitionItemFloorDetailID.ToString(), SQLMatchType.Equal);
                            FCCREQRequisitionItemFloorDetail.GetFacadeCreate().Delete(rEQRequisitionItemFloorDetailEntity, fe_del, DatabaseOperationType.Delete, TransactionRequired.No);
                        }
                    }
                }
                else
                {
                    if (populatedCheckedItems != null && populatedCheckedItems.Count > 0)
                    {
                        foreach (REQRequisitionItemFloorDetailEntity ent in populatedCheckedItems)
                        {
                            FCCREQRequisitionItemFloorDetail.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                    }
                }

                if (totalSelectedFloor > 0)
                {
                    #region Update Requisition Item Cost and Qty

                    String fe_requisitionItem = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, CurrentRequisitionItemIDPopup.ToString(), SQLMatchType.Equal);
                    REQRequisitionItemEntity rEQRequisitionItemEntity = FCCREQRequisitionItem.GetFacadeCreate().GetByID(CurrentRequisitionItemIDPopup);

                    rEQRequisitionItemEntity.PresentRequiredQty = Math.Round(totalFloorQty);
                    rEQRequisitionItemEntity.Rate = Math.Round(totalRate / totalSelectedFloor);

                    FCCREQRequisitionItem.GetFacadeCreate().Update(rEQRequisitionItemEntity, fe_requisitionItem, DatabaseOperationType.Update, TransactionRequired.No);

                    IList<ListViewDataItem> listRequisitionItem = lvREQRequisitionItem.Items;

                    if (listRequisitionItem != null && listRequisitionItem.Count > 0)
                    {

                        Int64 tempDataItemIndex = 0;

                        foreach (ListViewDataItem lvdi in listRequisitionItem)
                        {
                            Label lblRequisitionItemIDLV = (Label)lvdi.FindControl("lblRequisitionItemIDLV");

                            Int64.TryParse(lblRequisitionItemIDLV.Text.Trim(), out tempDataItemIndex);

                            if (CurrentRequisitionItemIDPopup == tempDataItemIndex)
                            {
                                TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");
                                // TextBox txtTotalQtyLV = (TextBox)lvdi.FindControl("txtTotalQtyLV");
                                txtPresentRequiredQty.Text = rEQRequisitionItemEntity.PresentRequiredQty.ToString();
                                // txtRateLV.Text = avgRate.ToString();
                                break;
                            }
                        }
                    }
                    #endregion
                }
                else
                {

                }

                BindList();
                MiscUtil.ShowMessage(lblMessage, "Requisition Floor Wise Item Info Saved Successfully.", false);

                CurrentRequisitionItemIDPopup = 0;
                _REQRequisitionItemFloorDetailList = new List<REQRequisitionItemFloorDetailEntity>();
                mappedItemsFromDB = new List<REQRequisitionItemFloorDetailEntity>();
                populatedCheckedItems = new List<REQRequisitionItemFloorDetailEntity>();
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Some Error Occured." + ex.Message.ToString(), true);
            }

        }

        protected void btnPnlMigrateToTRF_Click(object sender, EventArgs e)
        {
            Int64 transferID = SaveINVTransferEntity();

            if (transferID > 0)
            {

                #region AP Update

                APApprovalProcessEntity aPApprovalProcessEntity = FCCAPApprovalProcess.GetFacadeCreate().GetByID(APApprovalProcessID);

                if (aPApprovalProcessEntity != null && aPApprovalProcessEntity.APApprovalProcessID > 0)
                {
                    aPApprovalProcessEntity.APStatusID = MasterDataConstants.APStatus.CANCELED;

                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APApprovalProcessID, APApprovalProcessID.ToString(), SQLMatchType.Equal);
                    result = FCCAPApprovalProcess.GetFacadeCreate().Update(aPApprovalProcessEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                    if (result > 0)
                    {
                        APMemberFeedbackEntity aPMemberFeedbackEntity = FCCAPMemberFeedback.GetFacadeCreate().GetByID(APMemberFeedbackID);

                        if (aPMemberFeedbackEntity != null && aPMemberFeedbackEntity.APMemberFeedbackID > 0)
                        {
                            aPMemberFeedbackEntity.APFeedbackID = MasterDataConstants.APFeedback.CANCELED;

                            Int64 resultC = -1;
                            String fe_memberfeedback = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID, APMemberFeedbackID.ToString(), SQLMatchType.Equal);

                            resultC = FCCAPMemberFeedback.GetFacadeCreate().Update(aPMemberFeedbackEntity, fe_memberfeedback, DatabaseOperationType.Update, TransactionRequired.No);

                            if (resultC > 0)
                            {
                                String NavigationUrl = UrlHelper.BuildSecureUrl("~/INV/INVTransferItem.aspx", string.Empty, UrlConstants.OVERVIEW_TRANSFER_ID, transferID.ToString()).ToString();
                                Helper.Response.Redirect(NavigationUrl);
                            }
                        }
                    }
                }

                #endregion
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //if (ValidateInputForUpdate())
            //{
                SaveREQRequisitionItemEntity();
            //}
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                PreAddSaveREQRequisitionItemEntity();
                AddREQRequisitionItemEntity();
            }
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            if (ValidateInputApproval())
            {
                btnApprove.Enabled = false;

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.REQUISITION, REQRequisitionID);

                String remarks = txtRemarks.Text.Trim();

                if (remarks.IsNullOrEmpty())
                {
                    remarks = "Approved";
                }

                remarks = AddProxyMemberInfo(remarks);

                APRobot.AddAPMemberFeedbackRemarks(APMemberFeedbackID, remarks);

                EnableDisableApprovalButtons();

                MiscUtil.ShowMessage(lblMessage, "You Have Approved Successfully", UIConstants.MessageType.GREEN);

                String fe = SqlExpressionBuilder.PrepareFilterExpression(APForwardInfoEntity.FLD_NAME_APMemberFeedbackID, APMemberFeedbackID.ToString(), SQLMatchType.Equal);
                IList<APForwardInfoEntity> lstForwardedInfo = FCCAPForwardInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lstForwardedInfo != null && lstForwardedInfo.Count > 0)
                {

                    #region Forwarded Reply Mail

                    String MailBody = String.Empty;
                    String Subject = String.Empty;

                    StringBuilder sb = new StringBuilder();

                    sb.Append("Dear Sir,");
                    sb.Append("<br/>");
                    sb.Append("This is a auto generated mail from the ERP.");
                    sb.Append("<br/>");
                    sb.Append("A Forwarded Requisition is Processed By Senior");
                    sb.Append("<br/>");
                    sb.Append("-");
                    sb.Append("<br/>");
                    sb.Append("Thanks");
                    sb.Append("<br/>");
                    sb.Append("ERP System");
                    MailBody = sb.ToString();
                    Subject = "ERP, Requsition, Forwarded Reply";

                    String[] sendToMail = new String[lstForwardedInfo.Count];

                    Int64 count = 0;

                    foreach (APForwardInfoEntity aPForwardInfoEntity in lstForwardedInfo)
                    {
                        HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(aPForwardInfoEntity.EmployeeID);

                        if (_hREmployeeEntity != null)
                        {
                            sendToMail[count] = _hREmployeeEntity.PrimaryEmail;
                            count++;
                        }
                    }

                    MiscUtil.SendMail(sendToMail, Subject, MailBody);

                    #endregion
                }

                PrepareInitialView();
                BindList();
                RedirectPageToPendingList();
            }
        }
        
        protected void btnReject_Click(object sender, EventArgs e)
        {
            btnReject.Enabled = false;

            if (ddlRejectTo.SelectedValue == "0")
            {
                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.REQUISITION, REQRequisitionID);
            }
            else
            {
                Int64 rejectToAPMemberFeedbackID = Int64.Parse(ddlRejectTo.SelectedValue);

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.REQUISITION, REQRequisitionID, rejectToAPMemberFeedbackID);
            }

            String remarks = txtRemarks.Text.Trim();

            if (remarks.IsNullOrEmpty())
            {
                remarks = "Rejected";
            }

            remarks = AddProxyMemberInfo(remarks);

            APRobot.AddAPMemberFeedbackRemarks(APMemberFeedbackID, remarks);

            EnableDisableApprovalButtons();

            MiscUtil.ShowMessage(lblMessage, "You Have Rejected Successfully", UIConstants.MessageType.GREEN);

            PrepareInitialView();
            BindList();
            RedirectPageToRejectList();
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            btnForward.Enabled = false;

            if (ddlRejectTo.Items.Count > 0)
            {
                APRobot.UpdateMemberFeedbackFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.FORWARDED);
                APRobot.UpdateMemberFeedbackLastResponseDate(APMemberFeedbackID, DateTime.Now);

                String remarks = txtRemarks.Text.Trim();

                if (remarks.IsNullOrEmpty())
                {
                    remarks = "Forwarded";
                }

                remarks = AddProxyMemberInfo(remarks);

                Int64 aPMemberFeedbackRemarksID = APRobot.AddAPMemberFeedbackRemarks(APMemberFeedbackID, remarks);

                Int64 aPPanelForwardMemberID = Int64.Parse(ddlForwardTo.SelectedValue);

                APPanelForwardMemberEntity aPPanelForwardMemberEntity = APRobot.GetAPPanelForwardMemberByID(aPPanelForwardMemberID);

                APForwardInfoEntity aPForwardInfoEntity = new APForwardInfoEntity();

                aPForwardInfoEntity.APMemberFeedbackID = APMemberFeedbackID;
                aPForwardInfoEntity.APApprovalProcessID = APApprovalProcessID;
                aPForwardInfoEntity.APMemberFeedbackRemarksID = aPMemberFeedbackRemarksID;
                aPForwardInfoEntity.DepartmentID = aPPanelForwardMemberEntity.DepartmentID;
                aPForwardInfoEntity.EmployeeID = aPPanelForwardMemberEntity.EmployeeID;
                aPForwardInfoEntity.CommentRequestDate = DateTime.Now;
                aPForwardInfoEntity.CommentSubmitDate = null;
                aPForwardInfoEntity.APMemberComment = txtForwardRemarks.Text.Trim();
                aPForwardInfoEntity.APForwardMemberComment = String.Empty;

                FCCAPForwardInfo.GetFacadeCreate().Add(aPForwardInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                
                MiscUtil.ShowMessage(lblMessage, "You have forwarded the thread successfully", UIConstants.MessageType.GREEN);

                PrepareInitialView();
                BindList();

                #region Forwarded Mail

                String MailBody = String.Empty;
                String Subject = String.Empty;

                StringBuilder sb = new StringBuilder();

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Requisition Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Requsition, Forwarded";

                HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(aPForwardInfoEntity.EmployeeID);

                if (_hREmployeeEntity != null)
                {
                    String[] sendToMail = new String[] { _hREmployeeEntity.PrimaryEmail };
                    MiscUtil.SendMail(sendToMail, Subject, MailBody);
                }

                #endregion

                RedirectPageToForwardList();
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to forward", UIConstants.MessageType.RED); 
            }

        }

        protected void btnSubmitComment_Click(object sender, EventArgs e)
        {
            btnSubmitComment.Enabled = false;

            Boolean result = APRobot.UpdateAPForwardInfo(APForwardInfoID, txtComment.Text.Trim());

            if (result == true)
            {
                APRobot.UpdateMemberFeedbackFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.FORWARD_RESPONSE_RECEIVED);

                #region Forwarded Response Received Mail

                String MailBody = String.Empty;
                String Subject = String.Empty;

                StringBuilder sb = new StringBuilder();

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Requisition Forwarded Response Received");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Requsition, Forwarded Response Received";

                APMemberFeedbackEntity apMemberFeedbackEntity = FCCAPMemberFeedback.GetFacadeCreate().GetByID(APMemberFeedbackID);

                if (apMemberFeedbackEntity != null && apMemberFeedbackEntity.APMemberFeedbackID > 0)
                {

                    //String fe=SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.f
                    HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(apMemberFeedbackEntity.EmployeeID);

                    if (_hREmployeeEntity != null)
                    {
                        String[] sendToMail = new String[] { _hREmployeeEntity.PrimaryEmail };
                        MiscUtil.SendMail(sendToMail, Subject, MailBody);
                    }
                }

                #endregion

                PrepareInitialView();
                BindList();

                MiscUtil.ShowMessage(lblMessage, "You have submited comments successfully", UIConstants.MessageType.GREEN);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to submit comments", UIConstants.MessageType.RED);
            }
        }

        protected void lnkGetPrice_OnClick(object sender, EventArgs e)
        {
            this.Panel2_ModalPopupExtender.Show();
            GetCurrentPrice();
        }

        protected void lnkSetPrice_OnClick(object sender, EventArgs e)
        {
            this.Panel2_ModalPopupExtender.Show();

            #region Insert Item Price To The Price Database

            PriceEntryValidateInput();

            #endregion
        }

        protected void btnPnlPriceUpdatePopup_Click(object sender, EventArgs e)
        {
            UpdatePriceInfo();

            BuildGrandTotalLabel();
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindREQRequisitionUploadInfoList();
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

        #region File Uploader Events

        protected void afuFiles_UploadedComplete(object sender, AsyncFileUploadEventArgs e)
        {
            try
            {
                REQRequisitionUploadInfoEntity ent = new REQRequisitionUploadInfoEntity();
                ent.RequisitionID = REQRequisitionID;
                ent.OriginalFileName = Path.GetFileName(e.FileName);
                ent.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(e.FileName);
                ent.FileType = "";
                ent.Extension = Path.GetExtension(e.FileName);
                ent.Path = FileUploadConstants.EVENT.EVENT_IMAGE + ent.CurrentFileName;
                ent.Remarks = String.Empty;

                FCCREQRequisitionUploadInfo.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);

                // file upload

                afuFiles.SaveAs(Server.MapPath(ent.Path));

                //LoadFileListGried
                BindREQRequisitionUploadInfoList();
                cpeEditor.Collapsed = false;
                cpeEditor.ClientState = "false";

                MiscUtil.ShowMessage(lblMessage, "Requisition Upload Info Save Successfully.", false);
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Some Error Occured." + ex.Message, true);

            }

        }

        protected void afuFiles_UploadedFileError(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "error", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Error: " + e.StatusMessage + "';", true);
        }

        #endregion

        #endregion Event
    }
}
