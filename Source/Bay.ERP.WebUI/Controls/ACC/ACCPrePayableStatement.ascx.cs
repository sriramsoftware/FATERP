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
    public partial class ACCPrePayableStatementControl : BaseControl
    {       
        #region Properties

        public Int64 _PrePayableStatementID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }

                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID], out id);
                    ViewState["ID"] = id;
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
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtRef.Text = String.Empty;
            txtCreateDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtStartDate.Text = DateTime.Now.AddDays(-7).ToString(UIConstants.SHORT_DATE_FORMAT);
            txtEndDate.Text = DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACCPrePayableStatementEntity aCCPrePayableStatementEntity = CurrentACCPrePayableStatementEntity;


            if (!aCCPrePayableStatementEntity.IsNew)
            {
                txtRef.Text = aCCPrePayableStatementEntity.Ref.ToString();
                txtCreateDate.Text = aCCPrePayableStatementEntity.CreateDate.ToStringDefault();
                txtStartDate.Text = aCCPrePayableStatementEntity.StartDate.ToStringDefault();
                txtEndDate.Text = aCCPrePayableStatementEntity.EndDate.ToStringDefault();
                chkIsRemoved.Checked = aCCPrePayableStatementEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
                cpeEditor.Collapsed = false;
                cpeEditor.ClientState = "false";
            }
        }

        private void BindList()
        {
            BindACCPrePayableStatementList();
        }

        private void BindACCPrePayableStatementList()
        {
            lvACCPrePayableStatement.DataBind();
        }

        private ACCPrePayableStatementEntity BuildACCPrePayableStatementEntity()
        {
            ACCPrePayableStatementEntity aCCPrePayableStatementEntity = CurrentACCPrePayableStatementEntity;

            aCCPrePayableStatementEntity.Ref = txtRef.Text.Trim();
            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCCPrePayableStatementEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }

            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCCPrePayableStatementEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }

            if (txtEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCCPrePayableStatementEntity.EndDate = MiscUtil.ParseToDateTime(txtEndDate.Text);
            }

            aCCPrePayableStatementEntity.IsRemoved = chkIsRemoved.Checked;


            return aCCPrePayableStatementEntity;
        }

        private void BuildACCPrePayableStatementDetailEntity(ACCPrePayableStatementDetail_CustomEntity ent)
        {
            IList<ACCPrePayableStatementDetailEntity> lstACCPrePayableStatementDetail = new List<ACCPrePayableStatementDetailEntity>();
            //if (!txtWorkOrderNoLV.Text.Trim().IsNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.WorkOrderNo = txtWorkOrderNoLV.Text.Trim();
            //}
            //else
            //{
            //    aCCPrePayableStatementDetailEntity.WorkOrderNo = null;
            //}

            //if (!txtWorkOrderAmountLV.Text.Trim().IsNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.WorkOrderAmount = Decimal.Parse(txtWorkOrderAmountLV.Text.Trim());
            //}
            //else
            //{
            //    aCCPrePayableStatementDetailEntity.WorkOrderAmount = null;
            //}

            //if (txtWorkOrderDateLV.Text.Trim().IsNotNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.WorkOrderDate = MiscUtil.ParseToDateTime(txtWorkOrderDateLV.Text);
            //}
            //else
            //{
            //    aCCPrePayableStatementDetailEntity.WorkOrderDate = null;
            //}

            //if (!txtPaidAmountLV.Text.Trim().IsNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.PaidAmount = Decimal.Parse(txtPaidAmountLV.Text.Trim());
            //}
            //else
            //{
            //    aCCPrePayableStatementDetailEntity.PaidAmount = null;
            //}

            //if (!txtSecurityMoneyLV.Text.Trim().IsNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.SecurityMoney = Decimal.Parse(txtSecurityMoneyLV.Text.Trim());
            //}
            //else
            //{
            //    aCCPrePayableStatementDetailEntity.SecurityMoney = null;
            //}

            //if (!txtTDSAmountLV.Text.Trim().IsNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.TDSAmount = Decimal.Parse(txtTDSAmountLV.Text.Trim());
            //}
            //else
            //{
            //    aCCPrePayableStatementDetailEntity.TDSAmount = null;
            //}

            //if (!txtPayableAgainstWorkOrderLV.Text.Trim().IsNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder = Decimal.Parse(txtPayableAgainstWorkOrderLV.Text.Trim());
            //}
            //else
            //{
            //    aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder = null;
            //}

            //if (!txtApprovedBillAmountLV.Text.Trim().IsNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.ApprovedBillAmount = Decimal.Parse(txtApprovedBillAmountLV.Text.Trim());
            //}
            //else
            //{
            //    aCCPrePayableStatementDetailEntity.ApprovedBillAmount = null;
            //}

            //if (!txtNetPayableConsideringBillAndSecurityLV.Text.Trim().IsNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = Decimal.Parse(txtNetPayableConsideringBillAndSecurityLV.Text.Trim());
            //}
            //else
            //{
            //    aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = null;
            //}

            //aCCPrePayableStatementDetailEntity.PartyReconcile = chkPartyReconcileLV.Checked;

            ////if (ddlRequisitionID.Items.Count > 0)
            ////{
            ////    if (ddlRequisitionID.SelectedValue == "0")
            ////    {
            ////        aCCPrePayableStatementDetailEntity.RequisitionID = null;
            ////    }
            ////    else
            ////    {
            ////        aCCPrePayableStatementDetailEntity.RequisitionID = Int64.Parse(ddlRequisitionIDLV.SelectedValue);
            ////    }
            ////}

            //aCCPrePayableStatementDetailEntity.RequisitionNo = txtRequisitionNoLV.Text.Trim();
            //if (txtRequisitionDateLV.Text.Trim().IsNotNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.RequisitionDate = MiscUtil.ParseToDateTime(txtRequisitionDateLV.Text);
            //}
            //else
            //{
            //    aCCPrePayableStatementDetailEntity.RequisitionDate = null;
            //}

            ////if (ddlBillIDLV.Items.Count > 0)
            ////{
            ////    if (ddlBillID.SelectedValue == "0")
            ////    {
            ////        aCCPrePayableStatementDetailEntity.BillID = null;
            ////    }
            ////    else
            ////    {
            ////        aCCPrePayableStatementDetailEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
            ////    }
            ////}

            //aCCPrePayableStatementDetailEntity.BillNo = txtBillNoLV.Text.Trim();
            //if (txtBillDateLV.Text.Trim().IsNotNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.BillDate = MiscUtil.ParseToDateTime(txtBillDateLV.Text);
            //}
            //else
            //{
            //    aCCPrePayableStatementDetailEntity.BillDate = null;
            //}

            //aCCPrePayableStatementDetailEntity.Remarks = txtRemarksLV.Text.Trim();
            //aCCPrePayableStatementDetailEntity.Ref = txtRemarksLV.Text.Trim();

            //if (txtCreateDateLV.Text.Trim().IsNotNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDateLV.Text);
            //}

            //if (txtDueDateLV.Text.Trim().IsNotNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.DueDate = MiscUtil.ParseToDateTime(txtDueDateLV.Text);
            //}

            //if (txtPlannedDateLV.Text.Trim().IsNotNullOrEmpty())
            //{
            //    aCCPrePayableStatementDetailEntity.PlannedDate = MiscUtil.ParseToDateTime(txtPlannedDateLV.Text);
            //}
            //else
            //{
            //    aCCPrePayableStatementDetailEntity.PlannedDate = null;
            //}

            //aCCPrePayableStatementDetailEntity.AdditionalRemarks = txtAdditionalRemarksLV.Text.Trim();

            //if (ddlACCPayablePaymentStatusIDLV.Items.Count > 0)
            //{
            //    if (ddlACCPayablePaymentStatusIDLV.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        aCCPrePayableStatementDetailEntity.ACCPayablePaymentStatusID = Int64.Parse(ddlACCPayablePaymentStatusIDLV.SelectedValue);
            //    }
            //}

            //if (ddlACCPayableApprovalStatusIDLV.Items.Count > 0)
            //{
            //    if (ddlACCPayableApprovalStatusIDLV.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        aCCPrePayableStatementDetailEntity.ACCPayableApprovalStatusID = Int64.Parse(ddlACCPayableApprovalStatusIDLV.SelectedValue);
            //    }
            //}

            //aCCPrePayableStatementDetailEntity.IsRemoved = false;
        }

        private void SaveACCPrePayableStatementEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACCPrePayableStatementEntity aCCPrePayableStatementEntity = BuildACCPrePayableStatementEntity();

                    Int64 result = -1;

                    if (aCCPrePayableStatementEntity.IsNew)
                    {
                        result = FCCACCPrePayableStatement.GetFacadeCreate().Add(aCCPrePayableStatementEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACCPrePayableStatementEntity.FLD_NAME_PrePayableStatementID, aCCPrePayableStatementEntity.PrePayableStatementID.ToString(), SQLMatchType.Equal);
                        result = FCCACCPrePayableStatement.GetFacadeCreate().Update(aCCPrePayableStatementEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {

                        #region AccPayableStatemenet Detail From Bill

                        IList<ACCPrePayableStatementDetail_CustomEntity> lstACCPrePayableStatementDetail_CustomEntity = FCCACCPrePayableStatementDetail_Custom.GetFacadeCreate().GetIL(aCCPrePayableStatementEntity.StartDate, aCCPrePayableStatementEntity.EndDate);

                        if (lstACCPrePayableStatementDetail_CustomEntity != null && lstACCPrePayableStatementDetail_CustomEntity.Count > 0)
                        {
                            IList<ACCPrePayableStatementDetailEntity> lstACCPrePayableStatementDetail = new List<ACCPrePayableStatementDetailEntity>();

                            foreach (ACCPrePayableStatementDetail_CustomEntity entACCPrePayableStatementDetail_CustomEntity in lstACCPrePayableStatementDetail_CustomEntity)
                            {
                                ACCPrePayableStatementDetailEntity entACCPrePayableStatementDetail = new ACCPrePayableStatementDetailEntity();

                                

                                if (lstACCPrePayableStatementDetail != null && lstACCPrePayableStatementDetail.Count > 0)
                                {
                                    ACCPrePayableStatementDetailEntity entTempACCPrePayableStatementDetail = (from s in lstACCPrePayableStatementDetail
                                                                                                              where s.BillID == entACCPrePayableStatementDetail_CustomEntity.BillID && s.WorkOrderID == entACCPrePayableStatementDetail_CustomEntity.WorkOrderID
                                                                                                              //where s.BillID == entACCPrePayableStatementDetail_CustomEntity.BillID && s.WorkOrderID == entACCPrePayableStatementDetail_CustomEntity.WorkOrderID
                                                                                                              //&& s.ApprovedBillAmount == entACCPrePayableStatementDetail_CustomEntity.BillAmount && s.RequisitionID == entACCPrePayableStatementDetail_CustomEntity.RequisitionID
                                                                                                              select s).FirstOrDefault();
                                   
                                    

                                    if (entTempACCPrePayableStatementDetail != null && entTempACCPrePayableStatementDetail.BillID > 0)
                                    {
                                
                                        //Remove Previous Item
                                        lstACCPrePayableStatementDetail.Remove(entTempACCPrePayableStatementDetail);
                                        ///Clear this list................................
                                        entTempACCPrePayableStatementDetail.RequisitionNo += "," + entACCPrePayableStatementDetail_CustomEntity.RequisitionNo;

                                        //Add New Edited Item.
                                        lstACCPrePayableStatementDetail.Add(entTempACCPrePayableStatementDetail);

                                        continue;
                                    }
                                }

                                //else if(Flag)
                                //{

                                Decimal workOrderAgreementAmount = 0, paidAmount = 0, tDSAmount = 0, securityMoney = 0, billamount=0;

                                Decimal.TryParse(entACCPrePayableStatementDetail_CustomEntity.BillAmount.ToString(), out billamount);

                                    entACCPrePayableStatementDetail.PrePayableStatementID = result;
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
                                    Decimal netPayableConsideringBillSecurity = (billamount - paidAmount - securityMoney - tDSAmount);

                                    entACCPrePayableStatementDetail.PaidAmount = paidAmount;
                                    entACCPrePayableStatementDetail.SecurityMoney = securityMoney;
                                    entACCPrePayableStatementDetail.TDSAmount = tDSAmount;
                                    entACCPrePayableStatementDetail.PayableAgainstWorkOrder = payableAgainstWO;
                                    entACCPrePayableStatementDetail.NetPayableConsideringBillAndSecurity = netPayableConsideringBillSecurity;
                                    entACCPrePayableStatementDetail.CreateDate = System.DateTime.Now;

                                    //if (!txtSecurityMoneyLV.Text.Trim().IsNullOrEmpty())
                                    //{
                                    //    aCCPrePayableStatementDetailEntity.SecurityMoney = Decimal.Parse(txtSecurityMoneyLV.Text.Trim());
                                    //}
                                    //else
                                    //{
                                    //    aCCPrePayableStatementDetailEntity.SecurityMoney = null;
                                    //}

                                    //if (!txtTDSAmountLV.Text.Trim().IsNullOrEmpty())
                                    //{
                                    //    aCCPrePayableStatementDetailEntity.TDSAmount = Decimal.Parse(txtTDSAmountLV.Text.Trim());
                                    //}
                                    //else
                                    //{
                                    //    aCCPrePayableStatementDetailEntity.TDSAmount = null;
                                    //}

                                    //if (!txtPayableAgainstWorkOrderLV.Text.Trim().IsNullOrEmpty())
                                    //{
                                    //    aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder = Decimal.Parse(txtPayableAgainstWorkOrderLV.Text.Trim());
                                    //}
                                    //else
                                    //{
                                    //    aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder = null;
                                    //}

                                    if (entACCPrePayableStatementDetail_CustomEntity.BillAmount.HasValue)
                                    {
                                        entACCPrePayableStatementDetail.ApprovedBillAmount = Decimal.Parse(entACCPrePayableStatementDetail_CustomEntity.BillAmount.ToString());
                                    }
                                    else
                                    {
                                        entACCPrePayableStatementDetail.ApprovedBillAmount = null;
                                    }

                                    //if (!txtNetPayableConsideringBillAndSecurityLV.Text.Trim().IsNullOrEmpty())
                                    //{
                                    //    aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = Decimal.Parse(txtNetPayableConsideringBillAndSecurityLV.Text.Trim());
                                    //}
                                    //else
                                    //{
                                    //    aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = null;
                                    //}

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
                                //}
                            }

                            #region AccPayableStatemenet Detail

                            IList<ACCPrePayableStatementDetailFromWO_CustomEntity> lstACCPrePayableStatementDetailFromWO_CustomEntity = FCCACCPrePayableStatementDetailFromWO_Custom.GetFacadeCreate().GetIL();

                            if (lstACCPrePayableStatementDetailFromWO_CustomEntity != null && lstACCPrePayableStatementDetailFromWO_CustomEntity.Count > 0)
                            {

                                foreach (ACCPrePayableStatementDetailFromWO_CustomEntity entACCPrePayableStatementDetail_CustomEntity in lstACCPrePayableStatementDetailFromWO_CustomEntity)
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



                                    Decimal workOrderAgreementAmount = 0, paidAmount = 0, tDSAmount = 0, securityMoney = 0, billAmount = 0;

                                    entACCPrePayableStatementDetail.PrePayableStatementID = result;
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
                                    DateTime requisitionDate = System.DateTime.Now;

                                    if (entACCPrePayableStatementDetail_CustomEntity.WorkOrderID > 0)
                                    {
                                        String fe_WOItemMap = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID, entACCPrePayableStatementDetail_CustomEntity.WorkOrderID.ToString(), SQLMatchType.Equal);
                                        IList<PRMWorkOrderItemMapEntity> lstWOItemMap = FCCPRMWorkOrderItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_WOItemMap, DatabaseOperationType.LoadWithFilterExpression);

                                        if (lstWOItemMap != null && lstWOItemMap.Count > 0)
                                        {
                                            var distinctTypeIDs = lstWOItemMap.Select(x => x.RequisitionID).Distinct();

                                            foreach (var ent in distinctTypeIDs)
                                            {
                                                String fe_requisition = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionEntity.FLD_NAME_RequisitionID, ent.ToString(), SQLMatchType.Equal);
                                                IList<REQRequisition_DetailedEntity> lstReqRequisition_detailed = FCCREQRequisition_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_requisition);

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
                                }

                                //#region Insert To Payable Detail

                                //if (lstACCPrePayableStatementDetail != null && lstACCPrePayableStatementDetail.Count > 0)
                                //{
                                //    foreach (ACCPrePayableStatementDetailEntity ent in lstACCPrePayableStatementDetail)
                                //    {
                                //        FCCACCPrePayableStatementDetail.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                                //    }
                                //}

                                //#endregion

                                //MiscUtil.ShowMessage(lblMessage, "Pre Payable Statement Information has been added successfully.", false);

                            }

                            #endregion

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
                        BindACCPrePayableStatementList();

                        String navUrl = UrlHelper.BuildSecureUrl("~/ACC/ACCPrePayableStatementDetail.aspx", string.Empty, UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID, result.ToString()).ToString();
                        Response.Redirect(navUrl);

                        if (aCCPrePayableStatementEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Pre Payable Statement Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Pre Payable Statement Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCCPrePayableStatementEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Pre Payable Statement Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Pre Payable Statement Information.", false);
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

        protected void lvACCPrePayableStatement_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACCPrePayableStatementEntity ent = (ACCPrePayableStatementEntity)dataItem.DataItem;

                LinkButton lnkBtnEdit = (LinkButton)e.Item.FindControl("lnkBtnEdit");
                LinkButton lnkBtnDelete = (LinkButton)e.Item.FindControl("lnkBtnDelete");

                if (ent.PrePayableStatementID == MasterDataConstants.ACCPayableDefault.ACC_PRE_PAYABLE_STATEMENT_DEFAULT)
                {
                    lnkBtnEdit.Visible=false;
                    lnkBtnDelete.Visible = false;
                }

                HyperLink hypPayableRef = (HyperLink)e.Item.FindControl("hypPayableRef");
                HyperLink hypReport = (HyperLink)e.Item.FindControl("hypReport");
                hypReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.PRE_PAYABLE_REPORT, UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID, ent.PrePayableStatementID.ToString()).ToString();
                hypPayableRef.NavigateUrl = UrlHelper.BuildSecureUrl("~/ACC/ACCPrePayableStatementDetail.aspx", string.Empty, UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID, ent.PrePayableStatementID.ToString()).ToString();

                hypReport.Target = "_blank";
            }
        }

        protected void lvACCPrePayableStatement_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PrePayableStatementID;

            Int64.TryParse(e.CommandArgument.ToString(), out PrePayableStatementID);

            if (PrePayableStatementID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PrePayableStatementID = PrePayableStatementID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPrePayableStatementEntity.FLD_NAME_PrePayableStatementID, PrePayableStatementID.ToString(), SQLMatchType.Equal);

                        ACCPrePayableStatementEntity aCCPrePayableStatementEntity = new ACCPrePayableStatementEntity();


                        result = FCCACCPrePayableStatement.GetFacadeCreate().Delete(aCCPrePayableStatementEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PrePayableStatementID = 0;
                            _ACCPrePayableStatementEntity = new ACCPrePayableStatementEntity();
                            PrepareInitialView();
                            BindACCPrePayableStatementList();

                            MiscUtil.ShowMessage(lblMessage, "Payable Statement has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Payable Statement.", true);
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

        protected void odsACCPrePayableStatement_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACCPrePayableStatementEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PrePayableStatementID = 0;
            _ACCPrePayableStatementEntity = new ACCPrePayableStatementEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #endregion Event
    }
}
