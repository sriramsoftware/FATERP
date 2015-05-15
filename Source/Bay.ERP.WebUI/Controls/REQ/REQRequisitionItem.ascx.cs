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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;
using AjaxControlToolkit;
using System.IO;

namespace Bay.ERP.Web.UI
{
    public partial class REQRequisitionItemControl : BaseControl
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

        private BDProjectEntity CurrentBDProjectEntity
        {
            get
            {
                BDProjectEntity _bDProjectEntity = new BDProjectEntity();

                if (CurrentREQRequisitionEntity.ProjectID > 0)
                {
                    _bDProjectEntity = FCCBDProject.GetFacadeCreate().GetByID(CurrentREQRequisitionEntity.ProjectID);
                }

                return _bDProjectEntity;
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

        //private Boolean ValidateInputApproval()
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
        //                Decimal reqestedQty,availableQty,approvedQty;
        //                Decimal requiredQtyDB = 0;

        //                Label lblPresentRequiredQtyDBLV = (Label)lvdi.FindControl("lblPresentRequiredQtyDBLV");
        //                Label lblAvailableQtyForReqisitionLV = (Label)lvdi.FindControl("lblAvailableQtyForReqisitionLV");
        //                Label txtPurchasedQty = (Label)lvdi.FindControl("txtPurchasedQty");
        //                TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");

        //                Decimal.TryParse(lblAvailableQtyForReqisitionLV.Text.Trim(), out availableQty);
        //                txtPurchasedQty
        //                Decimal.TryParse(lblAvailableQtyForReqisitionLV.Text.Trim(), out availableQty);
        //                Decimal.TryParse(txtPresentRequiredQty.Text.Trim(), out reqestedQty);
        //                Decimal.TryParse(lblPresentRequiredQtyDBLV.Text.Trim(), out requiredQtyDB);

        //                if (reqestedQty != requiredQtyDB)
        //                {
        //                    reqestedQty = requiredQtyDB;
        //                }

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

        private void BindREQRequisitionUploadInfoList()
        {
            lvREQRequisitionUploadInfo.DataBind();
        }

        private Boolean ValidateInputApproval()
        {
            Boolean flag = true;

            try
            {

                Boolean result = false;

                result = true;
                IList<ListViewDataItem> listReq = lvREQRequisitionItem.Items;

                if (listReq != null && listReq.Count > 0)
                {
                    foreach (ListViewDataItem lvdi in listReq)
                    {

                        Decimal totalQty;

                        Label txtQtyLV = (Label)lvdi.FindControl("txtQtyLV");
                        Decimal.TryParse(txtQtyLV.Text.Trim(), out totalQty);

                        if (totalQty <= 0)
                        {
                            flag = false;
                            MiscUtil.ShowMessage(lblMessage, "Total Qty Can't be zero. Please Update BOQ Qty.", true);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return flag;
        }

        private void BuildDropDownList()
        {
            MiscUtil.PopulateINVStore(ddlTransferFromStoreID, false);
        }

        private void PrepareValidator()
        {
        }

        private void BindREQRequisitionFloorDetailList()
        {
            lvREQRequisitionItemFloorDetail.DataBind();
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            lblRequisitonNo.Text = CurrentREQRequisitionEntity.RequisitionNo.ToString();

            hypProjectID.Value = CurrentREQRequisitionEntity.ProjectID.ToString();
            lblProjectName.Text = CurrentBDProjectEntity.ProjectName.ToString();

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

            String itemTreeNavigationUrl = UrlHelper.BuildSecureUrl("~/Site/SiteRequisitionItemTreeView.aspx", String.Empty, UrlConstants.OVERVIEW_PROJECT_ID, CurrentREQRequisitionEntity.ProjectID.ToString()).ToString();
            hypItemTree.Target = "_blank";
            hypItemTree.NavigateUrl = itemTreeNavigationUrl;

            if (CurrentREQRequisitionEntity.Remarks.IsNotNullOrEmpty())
            {
                hypFileUrl.Visible = true;
                //hypFileUrl.Text = CurrentREQRequisitionEntity.Remarks;

                String _Reqremarks=null;
                string[] words = CurrentREQRequisitionEntity.Remarks.Split(' ');
                foreach (string word in words)
                {
                    if (word.Contains("http"))
                    {
                        _Reqremarks += "<a href='"+ word +"'> File </a>" ;
                    }
                    else
                    {
                        _Reqremarks +=" ";
                        _Reqremarks += word; 
                    }
                }

                hypFileUrl.Text=_Reqremarks;
                hypFileUrl.Target = "_blank";
            }

            #region Approval Process

            EnableDisableApprovalProcessCheck();

            #endregion

            #region Migrate To TRF

            IList<PRMWorkOrderNoByRequisition_CustomEntity> lstWONO = FCCPRMWorkOrderNoByRequisition_Custom.GetFacadeCreate().GetIL(REQRequisitionID);

            if (lstWONO != null && lstWONO.Count > 0)
            {
                btnMigrateToTRF.Enabled = true;
            }
            else
            {
                if (CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.APPROVED ||
                    CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.REJECTED)
                {
                    btnMigrateToTRF.Enabled = true;
                    dvSelectFileInfo.Visible = false;
                }
                else
                {
                    btnMigrateToTRF.Enabled = false;
                    dvSelectFileInfo.Visible = true;
                }
            }

            #endregion

            #region Create Work Order

            REQRequisitionEntity req = FCCREQRequisition.GetFacadeCreate().GetByID(REQRequisitionID);

            if (req != null && req.RequisitionStatusID == MasterDataConstants.RequisitionStatus.APPROVED)
            {
                btnCreateWorkOrder.Enabled = true;
                btnCreateWOSingleClick.Enabled = true;
                dvSelectFileInfo.Visible = false;
            }
            else
            {
                btnCreateWorkOrder.Enabled = false;
                btnCreateWOSingleClick.Enabled = false;
                dvSelectFileInfo.Visible = true;
            }

            #endregion

            mappedItemsFromDB = new List<REQRequisitionItemFloorDetailEntity>();
            populatedCheckedItems = new List<REQRequisitionItemFloorDetailEntity>();

        }

        private void EnableDisableApprovalProcessCheck()
        {
            APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.REQUISITION, REQRequisitionID);

            if (aPApprovalProcessEntity.APApprovalProcessID > 0)
            {
                btnInitiateApprovalProcess.Enabled = false;
                btnAdd.Enabled = false;
                txtItemName.Enabled = false;
                btnSubmit.Enabled = false;
            }
            else
            {
                btnInitiateApprovalProcess.Enabled = true;
                btnAdd.Enabled = true;
                txtItemName.Enabled = true;
                btnSubmit.Enabled = true;
            }

            IList<PRMWorkOrderNoByRequisition_CustomEntity> lstWONO = FCCPRMWorkOrderNoByRequisition_Custom.GetFacadeCreate().GetIL(REQRequisitionID);

            if (lstWONO != null && lstWONO.Count > 0)
            {
                btnMigrateToTRF.Enabled = false;
                String fe_req = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrderItemMap." + PRMWorkOrderItemMapEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
                IList<PRMWorkOrderItemMap_DetailedEntity> lstPRMWorkOrderItemMap = FCCPRMWorkOrderItemMap_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_req);

                if (lstPRMWorkOrderItemMap != null && lstPRMWorkOrderItemMap.Count > 0)
                {

                    List<PRMWorkOrderItemMap_DetailedEntity> distinct =
                                       lstPRMWorkOrderItemMap
                                       .GroupBy(car => car.WorkOrderID)
                                       .Select(g => g.First())
                                       .ToList();

                    foreach (PRMWorkOrderItemMap_DetailedEntity pRMWorkOrderItemMapEntity in distinct)
                    {
                        PRMWorkOrderEntity pRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(pRMWorkOrderItemMapEntity.WorkOrderID);

                        if (pRMWorkOrderEntity.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.REJECTED ||
                            pRMWorkOrderEntity.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.CANCELED)
                        {
                            btnResetApprovalProcess.Enabled = true;
                            break;
                        }
                        else
                        {
                            btnResetApprovalProcess.Enabled = false;
                        }
                    }
                }
                
            }
        }

        private void PrepareEditView()
        {
        }

        private Boolean ValidationInputMigration()
        {
            Boolean validationResult = true;

           
            
            return validationResult;
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            if (hdEmpID.Value=="0")
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

                    #region TEST

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, CurrentREQRequisitionEntity.ProjectID.ToString(), SQLMatchType.Equal);
                    IList<PRMPreBOQEntity> preBOQList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (preBOQList != null && preBOQList.Count > 0)
                    {
                        Int64 preBOQID = preBOQList[0].PreBOQID;

                        switch (preBOQList[0].IsLocked)
                        {
                            case true:
                                String fepreBOQID=SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_PreBOQID,preBOQID.ToString(),SQLMatchType.Equal);
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

                    hypRequisitionReport.Visible = true;

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
                    hypRequisitionReport.Visible = true;

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
                            
                            ////Another Entity Item may be added Here.
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
                    hypRequisitionReport.Visible = true;

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

                    #region Addvertisement Requisition Discount
                    Boolean IsAdvertisementRequisition = false;
                    MDItemEntity entity = FCCMDItem.GetFacadeCreate().GetByID(rEQRequisitionItemEntity.ItemID);

                    if (entity.ItemCategoryID == MasterDataConstants.ItemDefaults.DEFAULT_ADVERTIESMENT_ITEM_CATEGORY)
                    {
                        IsAdvertisementRequisition = true;
                    }

                    if (IsAdvertisementRequisition)
                    {
                        String fe3 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_ItemID, rEQRequisitionItemEntity.ItemID.ToString(), SQLMatchType.Equal);
                        String fe4 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_SupplierID, rEQRequisitionItemEntity.SupplierID.ToString(), SQLMatchType.Equal);
                        String fe5 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_BrandID, rEQRequisitionItemEntity.BrandID.ToString(), SQLMatchType.Equal);
                        String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe4, SQLJoinType.AND, fe5);
                        String fe7 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.AND, fe6);

                        IList<PRMSupplierItemMapEntity> list = FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe7, DatabaseOperationType.LoadWithFilterExpression);
                        PRMSupplierItemMapEntity ent = list.Where(x => x.ItemID == rEQRequisitionItemEntity.ItemID).Single();
                        rEQRequisitionItemEntity.TotalRequiredQty = ent.DiscountPercentage;
                    }

                    #endregion 

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

        private INVTransferEntity BuildINVTransferEntity()
        {
            INVTransferEntity iNVTransferEntity = new INVTransferEntity();

            REQRequisitionEntity rEQRequisitionEntity = CurrentREQRequisitionEntity;

            iNVTransferEntity.TRFNo ="Req No: "+ rEQRequisitionEntity.RequisitionNo;
            String fe=SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_MemberID,rEQRequisitionEntity.PreparedByMemberID.ToString(),SQLMatchType.Equal);
            IList<HREmployeeEntity> hrEmployeeList =FCCHREmployee.GetFacadeCreate().GetIL(null,null,String.Empty,fe,DatabaseOperationType.LoadWithFilterExpression);

            if(hrEmployeeList!=null && hrEmployeeList.Count>0)
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

        private void SaveINVTransferEntity()
        {
            try
            {
                INVTransferEntity iNVTransferEntity = BuildINVTransferEntity();

                Int64 result = -1;
                result = FCCINVTransfer.GetFacadeCreate().Add(iNVTransferEntity, DatabaseOperationType.Add, TransactionRequired.No);

                if (result > 0)
                {
                    String fe=SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID,REQRequisitionID.ToString(),SQLMatchType.Equal);
                    IList<REQRequisitionItemEntity> REQRequisitionItemList=FCCREQRequisitionItem.GetFacadeCreate().GetIL(null,null,String.Empty,fe,DatabaseOperationType.LoadWithFilterExpression);

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
                        REQRequisitionEntity rEQRequisitionEntity = CurrentREQRequisitionEntity;
                        rEQRequisitionEntity.RequisitionStatusID = MasterDataConstants.RequisitionStatus.MIGRATE_TO_TRF;

                        String fe_req = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_RequisitionID, rEQRequisitionEntity.RequisitionID.ToString(), SQLMatchType.Equal);
                        FCCREQRequisition.GetFacadeCreate().Update(rEQRequisitionEntity, fe_req, DatabaseOperationType.Update, TransactionRequired.No);
                        
                        MiscUtil.ShowMessage(lblMessage, "TRF Information has been added successfully.", false);
                        String NavigationUrl = UrlHelper.BuildSecureUrl("~/INV/INVTransferItem.aspx", string.Empty, UrlConstants.OVERVIEW_TRANSFER_ID, result.ToString()).ToString();
                        Helper.Response.Redirect(NavigationUrl);
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
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            btnInitiateApprovalProcess.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnInitiateApprovalProcess, "").ToString());

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

        protected void ddlProjectFloorUnitIDLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList dropDownList = (DropDownList)sender;
            ListViewItem item = (ListViewItem)dropDownList.NamingContainer;
            DropDownList ddProjectUnitLocationIDLV = (DropDownList)item.FindControl("ddProjectUnitLocationIDLV");
            MiscUtil.ShowMessage(lblMessage, (((DropDownList)sender).SelectedValue).ToString(),false);
            MiscUtil.PopulateBDProjectFloorUnitByFloor(ddProjectUnitLocationIDLV, false, Int64.Parse(((DropDownList)sender).SelectedValue.ToString()));
          
            this.ModalPopupExtender2.Show();
        }

        protected void lvREQRequisitionItemFloorDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            REQRequisitionEntity rEQRequisitionEntity = CurrentREQRequisitionEntity;
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {  
                CheckBox chbxSelectLV = (CheckBox)e.Item.FindControl("chbxSelectLV");
                Label lblProjectFloorIDLV = (Label)e.Item.FindControl("lblProjectFloorIDLV");
                TextBox txtQtyLV = (TextBox)e.Item.FindControl("txtQtyLV");
                TextBox txtRateLV = (TextBox)e.Item.FindControl("txtRateLV");
                TextBox txtRemarksLV = (TextBox)e.Item.FindControl("txtRemarksLV");
                DropDownList ddlProjectFloorUnitIDLV = (DropDownList)e.Item.FindControl("ddlProjectFloorUnitIDLV");
                DropDownList ddProjectUnitLocationIDLV = (DropDownList)e.Item.FindControl("ddProjectUnitLocationIDLV");
                if (CurrentREQRequisitionEntity.IsRCS != false)
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

                if (CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.APPROVED||
                    CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.IN_APPROVE_PROCESS||
                    CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.REJECTED||
                    CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.MIGRATE_TO_TRF ||
                    CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.CANCELED)
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

                Label lblRequisitionItemIDLV = (Label)e.Item.FindControl("lblRequisitionItemIDLV");
                Int64 requisitionItemIDLV;
                Int64.TryParse(lblRequisitionItemIDLV.Text, out requisitionItemIDLV);

                if (requisitionItemIDLV > 0)
                {
                    String fe_req = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemFloorDetailEntity.FLD_NAME_RequisitionItemID, requisitionItemIDLV.ToString(), SQLMatchType.Equal);
                    IList<REQRequisitionItemFloorDetailEntity> lstREQRequisitionItemFloorDetail = FCCREQRequisitionItemFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_req, DatabaseOperationType.LoadWithFilterExpression);

                    if (lstREQRequisitionItemFloorDetail != null && lstREQRequisitionItemFloorDetail.Count > 0)
                    {
                        txtPresentRequiredQty.ReadOnly = true;
                    }
                    else
                    {
                        txtPresentRequiredQty.ReadOnly = false;
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

                if (CurrentREQRequisitionEntity != null)
                {
                    if (CurrentREQRequisitionEntity.RequisitionStatusID != MasterDataConstants.RequisitionStatus.INITIATED)
                    {
                        LinkButton lnkBtnDelete = (LinkButton)e.Item.FindControl("lnkBtnDelete");
                        lnkBtnDelete.Visible = false;
                    }
                }

                if (purchasedQty >= totalQty)
                {
                    txtPurchasedQty.ForeColor = System.Drawing.Color.Red;
                }

                else if (purchasedQty < totalQty)
                {
                    txtPurchasedQty.ForeColor = System.Drawing.Color.Black;
                }

                //txtTotalQtyLV.Enabled = false;
                //txtPurchasedQty.Enabled = false;
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;
                REQRequisitionItem_DetailedEntity ent = (REQRequisitionItem_DetailedEntity)dataItem.DataItem;
                txtRequiredDate.Text = ent.RequiredDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                txtRemarksLV.Text = ent.Remarks.ToString();
                
            }
        }

        protected void lvREQRequisitionItem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 RequisitionItemID;

            Int64.TryParse(e.CommandArgument.ToString(), out RequisitionItemID);

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

                    if (CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.INITIATED)
                    {   
                        lblLockMessage.Visible = false;
                    }

                    else if (CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.APPROVED ||
                    CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.IN_APPROVE_PROCESS ||
                    CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.REJECTED ||
                    CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.MIGRATE_TO_TRF ||
                    CurrentREQRequisitionEntity.RequisitionStatusID == MasterDataConstants.RequisitionStatus.CANCELED
                        )
                    {
                        btnFloorPopupSave.Enabled = false;
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
                                // hypRequisitionReport.Visible = false;
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
                Decimal totalFloorQty=0, totalRate=0;

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

                            DropDownList ddlProjectFloorUnitIDLV = (DropDownList)lvdi.FindControl("ddlProjectFloorUnitIDLV");
                            DropDownList ddProjectUnitLocationIDLV = (DropDownList)lvdi.FindControl("ddProjectUnitLocationIDLV");

                            REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity = new REQRequisitionItemFloorDetailEntity();

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
                            totalSelectedFloor+=1;
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
                    rEQRequisitionItemEntity.Rate= Math.Round(totalRate / totalSelectedFloor);

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

                    //BindList();

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

        protected void btnCreateWOSingleClick_Click(object sender, EventArgs e)
        {
            IList<PRMWorkOrderSingleClickFromRequisition_CustomEntity> lst = FCCPRMWorkOrderSingleClickFromRequisition_Custom.GetFacadeCreate().GetIL(REQRequisitionID,MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember));

            if (lst != null && lst.Count > 0)
            {
                PRMWorkOrderEntity pRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(Int64.Parse(lst[0].WorkOrderID.ToString()));

                MiscUtil.ShowMessage(lblMessage, "WorkOrder No: " + pRMWorkOrderEntity.WorkOrderNo + "Initiated Successfully.", false);
                String NavigationUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrderItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, pRMWorkOrderEntity.WorkOrderID.ToString(), PRMWorkOrderEntity.FLD_NAME_WorkOrderNo, pRMWorkOrderEntity.WorkOrderNo).ToString();
                Response.Redirect(NavigationUrl);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Fail to create WorkOrder.", true);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveREQRequisitionItemEntity();

            String NavigationUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisitionList.aspx", string.Empty).ToString();
            Response.Redirect(NavigationUrl);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                PreAddSaveREQRequisitionItemEntity();
                AddREQRequisitionItemEntity();
            }
        }

        protected void btnPnlMigrateToTRF_Click(object sender, EventArgs e)
        {
            if (ValidationInputMigration())
            {
                SaveINVTransferEntity();
            }
        }

        protected void btnInitiateApprovalProcess_Click(object sender, EventArgs e)
        {
            #region Save Initailly

            SaveREQRequisitionItemEntity();

            #endregion

            if (ValidateInputApproval())
            {
                #region Approval Process

                Boolean apResult = APRobot.CreateApprovalProcessForNewRequisition(REQRequisitionID);

                if (apResult == true)
                {
                    MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                    String NavigationUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisitionList.aspx", string.Empty).ToString();
                    Response.Redirect(NavigationUrl);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                }

                EnableDisableApprovalProcessCheck();

                #endregion
            }
        }

        protected void btnResetApprovalProcess_Click(object sender, EventArgs e)
        {
            #region Approval Process

            Boolean apResult = APRobot.ResetApprovalProcessForRequisition(REQRequisitionID);

            if (apResult == true)
            {
                MiscUtil.ShowMessage(lblMessage, "Approval Process has been reset successfully.", UIConstants.MessageType.GREEN);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to reset approval process.", UIConstants.MessageType.RED);
            }

            EnableDisableApprovalProcessCheck();

            #endregion
        }

        protected void btnCreateWorkOrder_Click(object sender, EventArgs e)
        {
            String NavUrl = UrlHelper.BuildSecureUrl("~/CM/CMWorkOrderItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_REQUISITION_ID, REQRequisitionID.ToString(),UrlConstants.OVERVIEW_PROJECT_CODE,CurrentBDProjectEntity.ProjectCode.ToString()).ToString();
            Response.Redirect(NavUrl);
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindREQRequisitionUploadInfoList();
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

                MiscUtil.ShowMessage(lblMessage, "Requisition Upload Info Save Successfully.", false);

                cpeEditor.Collapsed = false;
                cpeEditor.ClientState = "true";
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
