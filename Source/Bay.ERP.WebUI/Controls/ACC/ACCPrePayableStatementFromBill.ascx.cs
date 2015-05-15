// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




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
    public partial class ACCPrePayableStatementFromBillControl : BaseControl
    {       
        #region Properties

        public Int64 ACCPrePayableStatementID
        {
            get
            {
                Int64 accPrePayableStatementID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID], out accPrePayableStatementID);
                }

                return accPrePayableStatementID;
            }
        }

        public Int64 _PrePayableStatementID
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

        public ACCPrePayableStatementEntity _ACCPrePayableStatementEntity
        {
            get
            {
                ACCPrePayableStatementEntity entity = new ACCPrePayableStatementEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACCPrePayableStatementEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACCPrePayableStatementEntity CurrentACCPrePayableStatementEntity
        {
            get
            {
                if (_PrePayableStatementID > 0)
                {
                    if (_ACCPrePayableStatementEntity.PrePayableStatementID != _PrePayableStatementID)
                    {
                        _ACCPrePayableStatementEntity = FCCACCPrePayableStatement.GetFacadeCreate().GetByID(_PrePayableStatementID);
                    }
                }

                return _ACCPrePayableStatementEntity;
            }
            set
            {
                _ACCPrePayableStatementEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMApprovedBillExceptACCPayable(ddlBillID, false);
            MiscUtil.PRMApprovedAdvancePaymentWorkOrder(ddlWorkOrderID, false);
        }

        private void PrepareValidator()
        {
        }

        private void BuildNavigationUrl()
        {
            if (ddlBillID != null && ddlBillID.SelectedValue != "0")
            {
                hypBillDetail.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMBillUploadInfo.aspx", string.Empty, UrlConstants.OVERVIEW_CM_BILL_ID, ddlBillID.SelectedValue.ToString()).ToString();
            }

            if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue != "0")
            {
                hypWorkOrderDetail.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrderItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, ddlWorkOrderID.SelectedValue.ToString(), PRMWorkOrderEntity.FLD_NAME_WorkOrderNo, ddlWorkOrderID.Text.ToString()).ToString();
            }
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            BuildNavigationUrl();
        }

        private void PrepareEditView()
        {

        }

        private void BindList()
        {
            BindACCPrePayableStatementList();
        }

        private void BindACCPrePayableStatementList()
        {
         
        }

        private void SaveBilltoACCPrePayableStatementEntity()
        {
            if (IsValid)
            {
                try
                { 

                        #region AccPayableStatemenet Detail

                        IList<ACCPrePayableStatementDetailByBill_CustomEntity> lstACCPrePayableStatementDetail_CustomEntity = FCCACCPrePayableStatementDetailByBill_Custom.GetFacadeCreate().GetIL(Int64.Parse(ddlBillID.SelectedValue));

                        if (lstACCPrePayableStatementDetail_CustomEntity != null && lstACCPrePayableStatementDetail_CustomEntity.Count > 0)
                        {
                            IList<ACCPrePayableStatementDetailEntity> lstACCPrePayableStatementDetail = new List<ACCPrePayableStatementDetailEntity>();

                            foreach (ACCPrePayableStatementDetailByBill_CustomEntity entACCPrePayableStatementDetail_CustomEntity in lstACCPrePayableStatementDetail_CustomEntity)
                            {
                                ACCPrePayableStatementDetailEntity entACCPrePayableStatementDetail = new ACCPrePayableStatementDetailEntity();

                                

                                if (lstACCPrePayableStatementDetail != null && lstACCPrePayableStatementDetail.Count > 0)
                                {
                                    ACCPrePayableStatementDetailEntity entTempACCPrePayableStatementDetail = (from s in lstACCPrePayableStatementDetail
                                                                                                              where s.BillID == entACCPrePayableStatementDetail_CustomEntity.BillID && s.WorkOrderID == entACCPrePayableStatementDetail_CustomEntity.WorkOrderID
                                                                                                              // where s.BillID == entACCPrePayableStatementDetail_CustomEntity.BillID && s.WorkOrderID == entACCPrePayableStatementDetail_CustomEntity.WorkOrderID
                                                                                                              //&& s.ApprovedBillAmount == entACCPrePayableStatementDetail_CustomEntity.BillAmount && s.RequisitionID != entACCPrePayableStatementDetail_CustomEntity.RequisitionID
                                                                                                              select s).FirstOrDefault();
                                   

                                    if (entTempACCPrePayableStatementDetail != null && entTempACCPrePayableStatementDetail.BillID > 0)
                                    {
                                
                                        //Remove Previous Item
                                        lstACCPrePayableStatementDetail.Remove(entTempACCPrePayableStatementDetail);

                                        entTempACCPrePayableStatementDetail.RequisitionNo += "," + entACCPrePayableStatementDetail_CustomEntity.RequisitionNo;

                                        //Add New Edited Item.
                                        lstACCPrePayableStatementDetail.Add(entTempACCPrePayableStatementDetail);

                                        continue;
                                    }
                                }

                                

                                Decimal workOrderAgreementAmount=0, paidAmount=0, tDSAmount=0,securityMoney=0;

                                entACCPrePayableStatementDetail.PrePayableStatementID = ACCPrePayableStatementID;
                                    if (entACCPrePayableStatementDetail_CustomEntity.WorkOrderNo.IsNotNullOrEmpty())
                                    {
                                        entACCPrePayableStatementDetail.WorkOrderNo = entACCPrePayableStatementDetail_CustomEntity.WorkOrderNo.Trim();
                                    }
                                    else
                                    {
                                        entACCPrePayableStatementDetail.WorkOrderNo = null;
                                    }

                                    if (entACCPrePayableStatementDetail_CustomEntity.WOAmount.HasValue)
                                    {
                                       workOrderAgreementAmount = Decimal.Parse(entACCPrePayableStatementDetail_CustomEntity.WOAmount.ToString());
                                       entACCPrePayableStatementDetail.WorkOrderAmount = workOrderAgreementAmount;
                                    }
                                    else
                                    {
                                        entACCPrePayableStatementDetail.WorkOrderAmount = null;
                                    }

                                    if (entACCPrePayableStatementDetail_CustomEntity.WorkOrderID > 0)
                                    {
                                        entACCPrePayableStatementDetail.WorkOrderID = Int64.Parse(entACCPrePayableStatementDetail_CustomEntity.WorkOrderID.ToString());
                                    }
                                    else
                                    {
                                        entACCPrePayableStatementDetail.WorkOrderID = null;
                                    }

                                    if (entACCPrePayableStatementDetail_CustomEntity.StartDate.HasValue)
                                    {
                                        entACCPrePayableStatementDetail.WorkOrderDate = entACCPrePayableStatementDetail_CustomEntity.StartDate;
                                    }
                                    else
                                    {
                                        entACCPrePayableStatementDetail.WorkOrderDate = null;
                                    }

                                    Decimal payableAgainstWO = (workOrderAgreementAmount - paidAmount - tDSAmount);
                                    Decimal netPayableConsideringBillSecurity = (payableAgainstWO - paidAmount - securityMoney - tDSAmount);

                                    entACCPrePayableStatementDetail.PaidAmount = paidAmount;
                                    entACCPrePayableStatementDetail.SecurityMoney = securityMoney;
                                    entACCPrePayableStatementDetail.TDSAmount = tDSAmount;
                                    entACCPrePayableStatementDetail.PayableAgainstWorkOrder = payableAgainstWO;
                                    entACCPrePayableStatementDetail.NetPayableConsideringBillAndSecurity = netPayableConsideringBillSecurity;
                                    entACCPrePayableStatementDetail.CreateDate = System.DateTime.Now;

                                    if (entACCPrePayableStatementDetail_CustomEntity.BillAmount.HasValue)
                                    {
                                        entACCPrePayableStatementDetail.ApprovedBillAmount = Decimal.Parse(entACCPrePayableStatementDetail_CustomEntity.BillAmount.ToString());
                                    }
                                    else
                                    {
                                        entACCPrePayableStatementDetail.ApprovedBillAmount = null;
                                    }

                                    entACCPrePayableStatementDetail.PartyReconcile = false;

                                    if (entACCPrePayableStatementDetail_CustomEntity.RequisitionID > 0)
                                    {

                                        entACCPrePayableStatementDetail.RequisitionID = entACCPrePayableStatementDetail_CustomEntity.RequisitionID;
                                    }

                                    else
                                    {
                                        entACCPrePayableStatementDetail.RequisitionID = null;
                                    }


                                    if (entACCPrePayableStatementDetail_CustomEntity.RequisitionNo.IsNotNullOrEmpty())
                                    {
                                        entACCPrePayableStatementDetail.RequisitionNo = entACCPrePayableStatementDetail_CustomEntity.RequisitionNo;
                                    }
                                    else
                                    {
                                        entACCPrePayableStatementDetail.RequisitionNo = null;
                                    }

                                    if (entACCPrePayableStatementDetail_CustomEntity.RequisitionDate.HasValue)
                                    {
                                        entACCPrePayableStatementDetail.RequisitionDate = entACCPrePayableStatementDetail_CustomEntity.RequisitionDate;
                                    }
                                    else
                                    {
                                        entACCPrePayableStatementDetail.RequisitionDate = null;
                                    }

                                    entACCPrePayableStatementDetail.ProjectID = Int64.Parse(entACCPrePayableStatementDetail_CustomEntity.ProjectID.ToString());
                                    entACCPrePayableStatementDetail.BillID = entACCPrePayableStatementDetail_CustomEntity.BillID;
                                    entACCPrePayableStatementDetail.BillDate = entACCPrePayableStatementDetail_CustomEntity.billlDate;
                                    entACCPrePayableStatementDetail.BillNo = entACCPrePayableStatementDetail_CustomEntity.BillNo;
                                    entACCPrePayableStatementDetail.VendorCategoryID = Int64.Parse(entACCPrePayableStatementDetail_CustomEntity.VendorCategory.ToString());
                                    entACCPrePayableStatementDetail.FromVendorID = Int64.Parse(entACCPrePayableStatementDetail_CustomEntity.Vendor.ToString());
                                    entACCPrePayableStatementDetail.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                                    entACCPrePayableStatementDetail.Ref = null;
                                    entACCPrePayableStatementDetail.DueDate = DateTime.Now;
                                    entACCPrePayableStatementDetail.PlannedDate = null;
                                    entACCPrePayableStatementDetail.Remarks = null;
                                    entACCPrePayableStatementDetail.AdditionalRemarks = null;

                                    entACCPrePayableStatementDetail.ACCPayablePaymentStatusID = MasterDataConstants.MDACCPayablePaymentStatus.CURRENT;
                                    entACCPrePayableStatementDetail.ACCPayableApprovalStatusID = MasterDataConstants.ACCPrePayableStatementApprovalStatus.INITIATED;
                                    entACCPrePayableStatementDetail.AccountPaybleStatementDetailCategoryID = MasterDataConstants.MDAccountPaybleStatementDetailCategory.REGULAR;
                                    entACCPrePayableStatementDetail.PayableClassificationID = MasterDataConstants.MDPayableClassification.AS;
                                    entACCPrePayableStatementDetail.APPanelID = MasterDataConstants.DeafultAPPanel.DEFAULT_AP_PANEL;

                                    entACCPrePayableStatementDetail.IsRemoved = false;
                                    entACCPrePayableStatementDetail.IsLocked = false;

                                    lstACCPrePayableStatementDetail.Add(entACCPrePayableStatementDetail);
                            }

                            #region Insert To Payable Detail

                            if (lstACCPrePayableStatementDetail != null && lstACCPrePayableStatementDetail.Count > 0)
                            {
                                foreach (ACCPrePayableStatementDetailEntity ent in lstACCPrePayableStatementDetail)
                                {
                                    FCCACCPrePayableStatementDetail.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                                }
                            }

                            #endregion

                        }

                        #endregion
                            
                        _PrePayableStatementID = 0;
                        _ACCPrePayableStatementEntity = new ACCPrePayableStatementEntity();
                        PrepareInitialView();

                        MiscUtil.ShowMessage(lblMessage, "Pre Payable Statement Information has been added successfully.", false);
                    
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void SaveWOtoACCPrePayableStatementEntity()
        {
            if (IsValid)
            {
                try
                {

                    #region AccPayableStatemenet Detail

                    IList<ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity> lstACCPrePayableStatementDetail_CustomEntity = FCCACCPrePayableStatementDetailByWorkOrderNo_Custom.GetFacadeCreate().GetIL(Int64.Parse(ddlWorkOrderID.SelectedValue));

                    if (lstACCPrePayableStatementDetail_CustomEntity != null && lstACCPrePayableStatementDetail_CustomEntity.Count > 0)
                    {
                        IList<ACCPrePayableStatementDetailEntity> lstACCPrePayableStatementDetail = new List<ACCPrePayableStatementDetailEntity>();

                        foreach (ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity entACCPrePayableStatementDetail_CustomEntity in lstACCPrePayableStatementDetail_CustomEntity)
                        {
                            ACCPrePayableStatementDetailEntity entACCPrePayableStatementDetail = new ACCPrePayableStatementDetailEntity();



                            //if (lstACCPrePayableStatementDetail != null && lstACCPrePayableStatementDetail.Count > 0)
                            //{
                            //    ACCPrePayableStatementDetailEntity entTempACCPrePayableStatementDetail = (from s in lstACCPrePayableStatementDetail
                            //                                                                              where s.BillID == entACCPrePayableStatementDetail_CustomEntity.BillID
                            //                                                                              // where s.BillID == entACCPrePayableStatementDetail_CustomEntity.BillID && s.WorkOrderID == entACCPrePayableStatementDetail_CustomEntity.WorkOrderID
                            //                                                                              //&& s.ApprovedBillAmount == entACCPrePayableStatementDetail_CustomEntity.BillAmount && s.RequisitionID != entACCPrePayableStatementDetail_CustomEntity.RequisitionID
                            //                                                                              select s).FirstOrDefault();


                            //    if (entTempACCPrePayableStatementDetail != null && entTempACCPrePayableStatementDetail.BillID > 0)
                            //    {

                            //        //Remove Previous Item
                            //        lstACCPrePayableStatementDetail.Remove(entTempACCPrePayableStatementDetail);

                            //        entTempACCPrePayableStatementDetail.RequisitionNo += "," + entACCPrePayableStatementDetail_CustomEntity.RequisitionNo;

                            //        //Add New Edited Item.
                            //        lstACCPrePayableStatementDetail.Add(entTempACCPrePayableStatementDetail);

                            //        continue;
                            //    }
                            //}



                            Decimal workOrderAgreementAmount = 0, paidAmount = 0, tDSAmount = 0, securityMoney = 0,billAmount=0;

                            entACCPrePayableStatementDetail.PrePayableStatementID = ACCPrePayableStatementID;
                            if (entACCPrePayableStatementDetail_CustomEntity.WorkOrderNo.IsNotNullOrEmpty())
                            {
                                entACCPrePayableStatementDetail.WorkOrderNo = entACCPrePayableStatementDetail_CustomEntity.WorkOrderNo.Trim();
                            }
                            else
                            {
                                entACCPrePayableStatementDetail.WorkOrderNo = null;
                            }

                            if (entACCPrePayableStatementDetail_CustomEntity.WOAmount.HasValue)
                            {
                                workOrderAgreementAmount = Decimal.Parse(entACCPrePayableStatementDetail_CustomEntity.WOAmount.ToString());
                                entACCPrePayableStatementDetail.WorkOrderAmount = workOrderAgreementAmount;
                            }
                            else
                            {
                                entACCPrePayableStatementDetail.WorkOrderAmount = null;
                            }

                            if (entACCPrePayableStatementDetail_CustomEntity.WorkOrderID > 0)
                            {
                                entACCPrePayableStatementDetail.WorkOrderID = Int64.Parse(entACCPrePayableStatementDetail_CustomEntity.WorkOrderID.ToString());
                            }
                            else
                            {
                                entACCPrePayableStatementDetail.WorkOrderID = null;
                            }

                            if (entACCPrePayableStatementDetail_CustomEntity.StartDate != null)
                            {
                                entACCPrePayableStatementDetail.WorkOrderDate = entACCPrePayableStatementDetail_CustomEntity.StartDate;
                            }
                            else
                            {
                                entACCPrePayableStatementDetail.WorkOrderDate = null;
                            }

                            Decimal payableAgainstWO = (workOrderAgreementAmount - paidAmount - tDSAmount);
                            //Decimal netPayableConsideringBillSecurity = (billAmount - paidAmount - securityMoney - tDSAmount); //need to discuss with Rayan vaiya. To get value from formula or anywhere else???
                            Decimal netPayableConsideringBillSecurity = payableAgainstWO;

                            entACCPrePayableStatementDetail.PaidAmount = paidAmount;
                            entACCPrePayableStatementDetail.SecurityMoney = securityMoney;
                            entACCPrePayableStatementDetail.TDSAmount = tDSAmount;
                            entACCPrePayableStatementDetail.PayableAgainstWorkOrder = payableAgainstWO;
                            entACCPrePayableStatementDetail.NetPayableConsideringBillAndSecurity = netPayableConsideringBillSecurity;
                            entACCPrePayableStatementDetail.CreateDate = System.DateTime.Now;
                            entACCPrePayableStatementDetail.ApprovedBillAmount = 0;

                            entACCPrePayableStatementDetail.PartyReconcile = false;

                            Int64 requisitionID = 0;
                            Int64 projectID = 0;
                            String projectCode = null;
                            String requisitionNo = null;
                            DateTime requisitionDate=System.DateTime.Now;
                            
                            if (entACCPrePayableStatementDetail_CustomEntity.WorkOrderID > 0)
                            {
                                String fe_WOItemMap=SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID,entACCPrePayableStatementDetail_CustomEntity.WorkOrderID.ToString(),SQLMatchType.Equal);
                                IList<PRMWorkOrderItemMapEntity> lstWOItemMap=FCCPRMWorkOrderItemMap.GetFacadeCreate().GetIL(null,null,String.Empty,fe_WOItemMap,DatabaseOperationType.LoadWithFilterExpression);

                                if(lstWOItemMap!=null && lstWOItemMap.Count>0)
                                {
                                  var distinctTypeIDs = lstWOItemMap.Select(x => x.RequisitionID).Distinct();

                                    foreach (var ent in distinctTypeIDs)
                                    {
                                        String fe_requisition = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionEntity.FLD_NAME_RequisitionID, ent.ToString(), SQLMatchType.Equal);
                                        IList<REQRequisition_DetailedEntity> lstReqRequisition_detailed  = FCCREQRequisition_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_requisition);

                                        if (lstReqRequisition_detailed != null && lstReqRequisition_detailed.Count > 0)
                                        {
                                            requisitionID = lstReqRequisition_detailed[0].RequisitionID;
                                            projectCode = lstReqRequisition_detailed[0].ProjectCode;
                                            requisitionNo += lstReqRequisition_detailed[0].RequisitionNo + " ";
                                            requisitionDate = lstReqRequisition_detailed[0].RequisitionDate;
                                            projectID = lstReqRequisition_detailed[0].ProjectID;
                                        }
                                    }
                                }
                            }

                            entACCPrePayableStatementDetail.RequisitionID = requisitionID;
                            entACCPrePayableStatementDetail.RequisitionNo = requisitionNo;
                            entACCPrePayableStatementDetail.RequisitionDate = requisitionDate;
                             entACCPrePayableStatementDetail.ProjectID = projectID; 
                             entACCPrePayableStatementDetail.ProjectCode = projectCode;
                            
                            //REQRequisitionEntity reqRequisitionEntity = null;

                            //if (entACCPrePayableStatementDetail_CustomEntity.RequisitionID > 0)
                            //{
                            //    entACCPrePayableStatementDetail.RequisitionID = entACCPrePayableStatementDetail_CustomEntity.RequisitionID;
                            //    reqRequisitionEntity = FCCREQRequisition.GetFacadeCreate().GetByID(entACCPrePayableStatementDetail_CustomEntity.RequisitionID);

                            //    if (reqRequisitionEntity != null)
                            //    {
                            //        entACCPrePayableStatementDetail.RequisitionNo = reqRequisitionEntity.RequisitionNo; ;
                            //        entACCPrePayableStatementDetail.RequisitionDate = reqRequisitionEntity.RequisitionDate;
                            //        entACCPrePayableStatementDetail.ProjectID = reqRequisitionEntity.ProjectID; // Project ID should come from the first requisition Project ID.
                            //    }
                            //}

                            //else
                            //{
                            //    entACCPrePayableStatementDetail.RequisitionID = null;
                            //}

                           

                            //if (entACCPrePayableStatementDetail_CustomEntity.RequisitionNo.IsNotNullOrEmpty())
                            //{
                            //    entACCPrePayableStatementDetail.RequisitionNo = entACCPrePayableStatementDetail_CustomEntity.RequisitionNo;
                            //}
                            //else
                            //{
                            //    entACCPrePayableStatementDetail.RequisitionNo = null;
                            //}

                            //if (entACCPrePayableStatementDetail_CustomEntity.RequisitionDate.HasValue)
                            //{
                            //    entACCPrePayableStatementDetail.RequisitionDate = entACCPrePayableStatementDetail_CustomEntity.RequisitionDate;
                            //}
                            //else
                            //{
                            //    entACCPrePayableStatementDetail.RequisitionDate = null;
                            //}

                            
                            //entACCPrePayableStatementDetail.ProjectID = Int64.Parse(entACCPrePayableStatementDetail_CustomEntity.ProjectID.ToString());
                            entACCPrePayableStatementDetail.BillID = null;
                            entACCPrePayableStatementDetail.BillDate = null;
                            entACCPrePayableStatementDetail.BillNo = null;
                            entACCPrePayableStatementDetail.VendorCategoryID = MasterDataConstants.MDVendorCategory.VENDOR;
                            entACCPrePayableStatementDetail.FromVendorID = entACCPrePayableStatementDetail_CustomEntity.SupplierID;
                            entACCPrePayableStatementDetail.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                            entACCPrePayableStatementDetail.Ref = null;
                            entACCPrePayableStatementDetail.DueDate = DateTime.Now;
                            entACCPrePayableStatementDetail.PlannedDate = null;
                            entACCPrePayableStatementDetail.Remarks = null;
                            entACCPrePayableStatementDetail.AdditionalRemarks = null;

                            entACCPrePayableStatementDetail.ACCPayablePaymentStatusID = MasterDataConstants.MDACCPayablePaymentStatus.CURRENT;
                            entACCPrePayableStatementDetail.ACCPayableApprovalStatusID = MasterDataConstants.ACCPrePayableStatementApprovalStatus.INITIATED;
                            entACCPrePayableStatementDetail.AccountPaybleStatementDetailCategoryID = MasterDataConstants.MDAccountPaybleStatementDetailCategory.REGULAR;
                            entACCPrePayableStatementDetail.PayableClassificationID = MasterDataConstants.MDPayableClassification.AS;
                            entACCPrePayableStatementDetail.APPanelID = MasterDataConstants.DeafultAPPanel.DEFAULT_AP_PANEL;

                            entACCPrePayableStatementDetail.IsRemoved = false;
                            entACCPrePayableStatementDetail.IsLocked = false;

                            lstACCPrePayableStatementDetail.Add(entACCPrePayableStatementDetail);

                            break;
                        }

                        #region Insert To Payable Detail

                        if (lstACCPrePayableStatementDetail != null && lstACCPrePayableStatementDetail.Count > 0)
                        {
                            foreach (ACCPrePayableStatementDetailEntity ent in lstACCPrePayableStatementDetail)
                            {
                                FCCACCPrePayableStatementDetail.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                            }
                        }

                        #endregion

                        MiscUtil.ShowMessage(lblMessage, "Pre Payable Statement Information has been added successfully.", false);

                    }

                    #endregion

                    _PrePayableStatementID = 0;
                    _ACCPrePayableStatementEntity = new ACCPrePayableStatementEntity();
                    PrepareInitialView();

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
            SaveBilltoACCPrePayableStatementEntity();
        }

        protected void btnWOSubmit_Click(object sender, EventArgs e)
        {
            SaveWOtoACCPrePayableStatementEntity();
        }

        #endregion

        #region DropdownList Event

        protected void ddlWorkOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildNavigationUrl();
        }

        protected void ddlBillID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildNavigationUrl();
        }

        #endregion

        #endregion Event
    }
}
