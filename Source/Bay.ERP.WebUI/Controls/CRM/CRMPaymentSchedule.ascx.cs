// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Apr-2013, 04:59:58




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
    public partial class CRMPaymentScheduleControl : BaseControl
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

        public Int64 _PaymentScheduleID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }

                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PAYMENT_SCHEDULE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PAYMENT_SCHEDULE_ID], out id);
                    ViewState["ID"] = id;
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public CRMPaymentScheduleEntity _CRMPaymentScheduleEntity
        {
            get
            {
                CRMPaymentScheduleEntity entity = new CRMPaymentScheduleEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMPaymentScheduleEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMPaymentScheduleEntity CurrentCRMPaymentScheduleEntity
        {
            get
            {
                if (_PaymentScheduleID > 0)
                {
                    if (_CRMPaymentScheduleEntity.PaymentScheduleID != _PaymentScheduleID)
                    {
                        _CRMPaymentScheduleEntity = FCCCRMPaymentSchedule.GetFacadeCreate().GetByID(_PaymentScheduleID);
                    }
                }

                return _CRMPaymentScheduleEntity;
            }
            set
            {
                _CRMPaymentScheduleEntity = value;
            }
        }

        public Int64 _PaymentScheduleMapID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["PaymentScheduleMapID"] != null)
                {
                    Int64.TryParse(ViewState["PaymentScheduleMapID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["PaymentScheduleMapID"] = value;
            }
        }

        public CRMPaymentScheduleMapEntity _CRMPaymentScheduleMapEntity
        {
            get
            {
                CRMPaymentScheduleMapEntity entity = new CRMPaymentScheduleMapEntity();

                if (ViewState["PaymentScheduleMapEntity"] != null)
                {
                    entity = (CRMPaymentScheduleMapEntity)ViewState["PaymentScheduleMapEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["PaymentScheduleMapEntity"] = value;
            }
        }

        private CRMPaymentScheduleMapEntity CurrentCRMPaymentScheduleMapEntity
        {
            get
            {
                if (_PaymentScheduleMapID > 0)
                {
                    if (_CRMPaymentScheduleMapEntity.PaymentScheduleMapID != _PaymentScheduleMapID)
                    {
                        _CRMPaymentScheduleMapEntity = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetByID(_PaymentScheduleMapID);
                    }
                }

                return _CRMPaymentScheduleMapEntity;
            }
            set
            {
                _CRMPaymentScheduleMapEntity = value;
            }
        }

        public IList<CRMPaymentScheduleMapEntity> TemporaryCRMPaymentScheduleMapList
        {
            get
            {
                return (IList<CRMPaymentScheduleMapEntity>)ViewState["TemporaryCRMPaymentScheduleMapList"];
            }
            set
            {
                ViewState["TemporaryCRMPaymentScheduleMapList"] = value;
            }
        }

        public Int64 OverviewBookSpaceID
        {
            get
            {
                Int64 overviewBookSpaceID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BOOK_SPACE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BOOK_SPACE_ID], out overviewBookSpaceID);
                }

                return overviewBookSpaceID;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCRMAgreement(ddlAgreementID, true);
            //BuildAgreementBuyerInfo();
        }

        private void PrepareValidator()
        {
        }

        private Boolean ValidationInput()
        {
            Boolean flag = true;

            IList<ListViewDataItem> listScheduleMap = lvCRMPaymentScheduleMap.Items;

            if (listScheduleMap.Count <= 0)
            {
                flag = false;
                MiscUtil.ShowMessage(lblMessage,"There should have atleast one Installment", true); 
            }

            Decimal grandTotal=0;
            Decimal agreementAmount,remainingAmount;
            Decimal.TryParse(txtTotalAgreementAmount.Text.Trim(), out agreementAmount);


            if (listScheduleMap != null && listScheduleMap.Count > 0)
            {
                foreach (ListViewDataItem lvdi in listScheduleMap)
                {
                    Decimal runingTotalQty;

                    TextBox txtTotalLV = (TextBox)lvdi.FindControl("txtTotalLV");
                    Decimal.TryParse(txtTotalLV.Text.Trim(), out runingTotalQty);

                    grandTotal = grandTotal + runingTotalQty;
                }
            }

            remainingAmount = agreementAmount - grandTotal;
            if (remainingAmount > 0)
            {
                flag = false;
                MiscUtil.ShowMessage(lblMessage, "Please adjust agreement Amount.", true); 
            }
            return flag;
        }

        private void PrepareInitialView()
        {
            //BuildDropDownList();
            BuildBookingBuyerInfo();
            txtHandoverDate.Text = String.Empty;
            txtActualHandoverDate.Text = String.Empty;
            txtCommonService.Text = String.Empty;
            txtUtilityConnectionCost.Text = String.Empty;
            txtReservedFund.Text = String.Empty;
            txtTotalInstallment.Text = String.Empty;
            txtTotalAgreementAmount.Text = String.Empty;
            txtEarnestMoney.Text = String.Empty;
            txtReservation.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtTotalAgreementAmount.Text = String.Empty;

            if (Action == null)
            {
                btnCreateInstallment.Enabled = true;
            }

            btnSubmit.Text = "Save Payment Schedule";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMPaymentScheduleEntity cRMPaymentScheduleEntity = CurrentCRMPaymentScheduleEntity;


            if (!cRMPaymentScheduleEntity.IsNew)
            {
                if (ddlBuyerBasicInfoID.Items.Count > 0 && cRMPaymentScheduleEntity.BuyerBasicInfoID != null)
                {
                    ddlBuyerBasicInfoID.SelectedValue = cRMPaymentScheduleEntity.BuyerBasicInfoID.ToString();
                }

                txtTotalAgreementAmount.Text = cRMPaymentScheduleEntity.TotalAgreementAmount.ToString();
                txtEarnestMoney.Text = cRMPaymentScheduleEntity.EarnestMoney.ToString();
                txtReservation.Text = cRMPaymentScheduleEntity.Reservation.ToString();
                txtHandoverDate.Text = cRMPaymentScheduleEntity.HandoverDate.ToStringDefault();
                txtActualHandoverDate.Text = cRMPaymentScheduleEntity.ActualHandoverDate.ToStringDefault();
                txtProjectCode.Text = cRMPaymentScheduleEntity.ProjectCode.ToString();
                txtCommonService.Text = cRMPaymentScheduleEntity.CommonService.ToString();
                txtUtilityConnectionCost.Text = cRMPaymentScheduleEntity.UtilityConnectionCost.ToString();
                txtReservedFund.Text = cRMPaymentScheduleEntity.ReservedFund.ToString();
                txtTotalInstallment.Text = cRMPaymentScheduleEntity.TotalInstallment.ToString();
                txtRemarks.Text = cRMPaymentScheduleEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }

            if (Action == "Edit")
            {
                String fe_map = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleMapEntity.FLD_NAME_PaymentScheduleID, _PaymentScheduleID.ToString(), SQLMatchType.Equal);
                IList<CRMPaymentScheduleMapEntity> lst = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_map, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {

                    TemporaryCRMPaymentScheduleMapList = lst;
                    TemporaryCRMPaymentScheduleMapList = TemporaryCRMPaymentScheduleMapList.OrderBy(x => x.InstallmentName).ToList();
                    BindCRMPaymentScheduleMapList();
                    btnCreateInstallment.Enabled = false;
                    btnRecalculate.Visible = true;
                    lnkRecalulateGrandTotal.Visible = true;
                }
            }
        }

        private void BindList()
        {
        
        }

        private void BindCRMPaymentScheduleMapList()
        {
            //if (Action == "Edit")
            //{
            //    String fe_map = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleMapEntity.FLD_NAME_PaymentScheduleID, _PaymentScheduleID.ToString(), SQLMatchType.Equal);
            //    IList<CRMPaymentScheduleMapEntity> lst = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_map, DatabaseOperationType.LoadWithFilterExpression);

            //    if (lst != null && lst.Count > 0)
            //    {
            //        TemporaryCRMPaymentScheduleMapList = lst;
            //        TemporaryCRMPaymentScheduleMapList = TemporaryCRMPaymentScheduleMapList.OrderBy(x => x.InstallmentName).ToList();
            //        btnCreateInstallment.Enabled = false;
            //    }
            //}

            lvCRMPaymentScheduleMap.DataSource = TemporaryCRMPaymentScheduleMapList;
            lvCRMPaymentScheduleMap.DataBind();
        }

        private CRMPaymentScheduleEntity BuildCRMPaymentScheduleEntity()
        {
            CRMPaymentScheduleEntity cRMPaymentScheduleEntity = CurrentCRMPaymentScheduleEntity;

            if (cRMPaymentScheduleEntity.BuyerBookSpaceID == 0)
            {
                cRMPaymentScheduleEntity.BuyerBookSpaceID = OverviewBookSpaceID;
            }
            else
            {
                cRMPaymentScheduleEntity.BuyerBookSpaceID = cRMPaymentScheduleEntity.BuyerBookSpaceID;
            }

            if (txtHandoverDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMPaymentScheduleEntity.HandoverDate = MiscUtil.ParseToDateTime(txtHandoverDate.Text);
            }

            if (txtActualHandoverDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMPaymentScheduleEntity.ActualHandoverDate = MiscUtil.ParseToDateTime(txtActualHandoverDate.Text);
            }
            else
            {
                cRMPaymentScheduleEntity.ActualHandoverDate = null;
            }

            cRMPaymentScheduleEntity.ProjectCode = txtProjectCode.Text.Trim();

            if (ddlBuyerBasicInfoID.Items.Count > 0)
            {
                if (ddlBuyerBasicInfoID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMPaymentScheduleEntity.BuyerBasicInfoID = Int64.Parse(ddlBuyerBasicInfoID.SelectedValue);
                }
            }

            if (!txtTotalAgreementAmount.Text.Trim().IsNullOrEmpty())
            {
                cRMPaymentScheduleEntity.TotalAgreementAmount = Decimal.Parse(txtTotalAgreementAmount.Text.Trim());
            }
            else
            {
                cRMPaymentScheduleEntity.TotalAgreementAmount = null;
            }

            if (!txtEarnestMoney.Text.Trim().IsNullOrEmpty())
            {
                cRMPaymentScheduleEntity.EarnestMoney = Decimal.Parse(txtEarnestMoney.Text.Trim());
            }
            else
            {
                cRMPaymentScheduleEntity.EarnestMoney = null;
            }

            if (!txtReservation.Text.Trim().IsNullOrEmpty())
            {
                cRMPaymentScheduleEntity.Reservation = Decimal.Parse(txtReservation.Text.Trim());
            }
            else
            {
                cRMPaymentScheduleEntity.Reservation = null;
            }

            if (!txtCommonService.Text.Trim().IsNullOrEmpty())
            {
                cRMPaymentScheduleEntity.CommonService = Decimal.Parse(txtCommonService.Text.Trim());
            }
            else
            {
                cRMPaymentScheduleEntity.CommonService = null;
            }

            if (!txtUtilityConnectionCost.Text.Trim().IsNullOrEmpty())
            {
                cRMPaymentScheduleEntity.UtilityConnectionCost = Decimal.Parse(txtUtilityConnectionCost.Text.Trim());
            }
            else
            {
                cRMPaymentScheduleEntity.UtilityConnectionCost = null;
            }

            if (!txtReservedFund.Text.Trim().IsNullOrEmpty())
            {
                cRMPaymentScheduleEntity.ReservedFund = Decimal.Parse(txtReservedFund.Text.Trim());
            }
            else
            {
                cRMPaymentScheduleEntity.ReservedFund = null;
            }

            if (!txtTotalInstallment.Text.Trim().IsNullOrEmpty())
            {
                cRMPaymentScheduleEntity.TotalInstallment = Decimal.Parse(txtTotalInstallment.Text.Trim());
            }
            else
            {
                cRMPaymentScheduleEntity.TotalInstallment = null;
            }

            cRMPaymentScheduleEntity.Remarks = txtRemarks.Text.Trim();


            cRMPaymentScheduleEntity.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            cRMPaymentScheduleEntity.IP = MiscUtil.GetLocalIP();
            cRMPaymentScheduleEntity.CreateDate = System.DateTime.Now;

            return cRMPaymentScheduleEntity;
        }

        private void SaveCRMPaymentScheduleEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMPaymentScheduleEntity cRMPaymentScheduleEntity = BuildCRMPaymentScheduleEntity();

                    Int64 result = -1;

                    if (cRMPaymentScheduleEntity.IsNew)
                    {
                        result = FCCCRMPaymentSchedule.GetFacadeCreate().Add(cRMPaymentScheduleEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleEntity.FLD_NAME_PaymentScheduleID, cRMPaymentScheduleEntity.PaymentScheduleID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMPaymentSchedule.GetFacadeCreate().Update(cRMPaymentScheduleEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {

                        #region Payment Schedule Map Here

                        if (TemporaryCRMPaymentScheduleMapList != null && TemporaryCRMPaymentScheduleMapList.Count > 0)
                        {
                            if (Action == "Add")
                            {
                                try
                                {
                                    IList<ListViewDataItem> listPaymentSchedule = lvCRMPaymentScheduleMap.Items;

                                    if (listPaymentSchedule != null && listPaymentSchedule.Count > 0)
                                    {
                                        foreach (ListViewDataItem lvdi in listPaymentSchedule)
                                        {
                                            TextBox txtInstallmentNameLV = (TextBox)lvdi.FindControl("txtInstallmentNameLV");
                                            TextBox txtAgreementAAmountLV = (TextBox)lvdi.FindControl("txtAgreementAAmountLV");
                                            TextBox txtAgreementBAmountLV = (TextBox)lvdi.FindControl("txtAgreementBAmountLV");
                                            TextBox txtAgreementCAmountLV = (TextBox)lvdi.FindControl("txtAgreementCAmountLV");
                                            TextBox txtInstallmentDueDateLV = (TextBox)lvdi.FindControl("txtInstallmentDueDateLV");
                                            TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");

                                            Decimal agreementAAmount, agreementBAmount, agreementCAmount;

                                            Decimal.TryParse(txtAgreementAAmountLV.Text.Trim(), out agreementAAmount);
                                            Decimal.TryParse(txtAgreementBAmountLV.Text.Trim(), out agreementBAmount);
                                            Decimal.TryParse(txtAgreementCAmountLV.Text.Trim(), out agreementCAmount);


                                            CRMPaymentScheduleMapEntity ent = new CRMPaymentScheduleMapEntity();

                                            if (ddlAgreementID.Items.Count > 0 && ddlAgreementID.SelectedValue != "0")
                                            {
                                                ent.AgreementID = Int64.Parse(ddlAgreementID.SelectedValue);
                                            }
                                            else
                                            {
                                                ent.AgreementID = null;
                                            }

                                            ent.LinkPaymentScheduleMapID = null;

                                            if (txtInstallmentDueDateLV.Text.Trim().IsNotNullOrEmpty())
                                            {
                                                ent.InstallmentDueDate = MiscUtil.ParseToDateTime(txtInstallmentDueDateLV.Text.Trim().ToString());
                                            }
                                            ent.InstallmentDueDateNew = null;
                                            ent.IP = MiscUtil.GetLocalIP();
                                            ent.InstallmentName = txtInstallmentNameLV.Text.Trim();
                                            ent.LastRevisedByEmployeeID = null;
                                            ent.LastRevisedDate = null;
                                            ent.PaymentDueDate = null;
                                            ent.PaymentScheduleID = result;
                                            ent.Remarks = txtRemarksLV.Text.Trim();
                                            ent.Revised = false;
                                            ent.RevisedIP = null;
                                            ent.FinalPayment = false;
                                            ent.CreateDate = System.DateTime.Now;
                                            ent.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                                            ent.AgreementAAmount = agreementAAmount;
                                            ent.AgreementBAmount = agreementBAmount;
                                            ent.AgreementCAmount = agreementCAmount;
                                            ent.AgreementDAmount = 0;
                                            ent.AgreementEAmount = 0;

                                            FCCCRMPaymentScheduleMap.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                }
                            }

                            else if (Action == "Edit")
                            {
                                try
                                {
                                    IList<ListViewDataItem> listPaymentSchedule = lvCRMPaymentScheduleMap.Items;

                                    if (listPaymentSchedule != null && listPaymentSchedule.Count > 0)
                                    {
                                        foreach (ListViewDataItem lvdi in listPaymentSchedule)
                                        {
                                            TextBox txtInstallmentNameLV = (TextBox)lvdi.FindControl("txtInstallmentNameLV");
                                            TextBox txtAgreementAAmountLV = (TextBox)lvdi.FindControl("txtAgreementAAmountLV");
                                            TextBox txtAgreementBAmountLV = (TextBox)lvdi.FindControl("txtAgreementBAmountLV");
                                            TextBox txtAgreementCAmountLV = (TextBox)lvdi.FindControl("txtAgreementCAmountLV");
                                            TextBox txtInstallmentDueDateLV = (TextBox)lvdi.FindControl("txtInstallmentDueDateLV");
                                            TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                                            Label lblPaymentScheduleMapIDLV = (Label)lvdi.FindControl("lblPaymentScheduleMapIDLV");

                                            Decimal agreementAAmount, agreementBAmount, agreementCAmount;
                                            Int64 paymentScheduleMapID;

                                            Decimal.TryParse(txtAgreementAAmountLV.Text.Trim(), out agreementAAmount);
                                            Decimal.TryParse(txtAgreementBAmountLV.Text.Trim(), out agreementBAmount);
                                            Decimal.TryParse(txtAgreementCAmountLV.Text.Trim(), out agreementCAmount);
                                            Int64.TryParse(lblPaymentScheduleMapIDLV.Text, out paymentScheduleMapID);

                                            CRMPaymentScheduleMapEntity ent = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetByID(paymentScheduleMapID);

                                            if (ddlAgreementID.Items.Count > 0 && ddlAgreementID.SelectedValue != "0")
                                            {
                                                ent.AgreementID = Int64.Parse(ddlAgreementID.SelectedValue);
                                            }
                                            else
                                            {
                                                ent.AgreementID = null;
                                            }

                                            ent.LinkPaymentScheduleMapID = null;

                                            if (txtInstallmentDueDateLV.Text.Trim().IsNotNullOrEmpty())
                                            {
                                                ent.InstallmentDueDate = MiscUtil.ParseToDateTime(txtInstallmentDueDateLV.Text.Trim().ToString());
                                            }

                                            ent.InstallmentDueDateNew = null;
                                            ent.IP = MiscUtil.GetLocalIP();
                                            ent.InstallmentName = txtInstallmentNameLV.Text.Trim();
                                            ent.LastRevisedByEmployeeID = null;
                                            ent.LastRevisedDate = null;
                                            ent.PaymentDueDate = null;
                                            ent.PaymentScheduleID = result;
                                            ent.Remarks = txtRemarksLV.Text.Trim();
                                            ent.Revised = false;
                                            ent.RevisedIP = null;
                                            ent.FinalPayment = false;
                                            ent.CreateDate = System.DateTime.Now;
                                            ent.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                                            ent.AgreementAAmount = agreementAAmount;
                                            ent.AgreementBAmount = agreementBAmount;
                                            ent.AgreementCAmount = agreementCAmount;
                                            ent.AgreementDAmount = 0;
                                            ent.AgreementEAmount = 0;

                                            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleMapEntity.FLD_NAME_PaymentScheduleMapID, paymentScheduleMapID.ToString(), SQLMatchType.Equal);
                                            FCCCRMPaymentScheduleMap.GetFacadeCreate().Update(ent,fe, DatabaseOperationType.Update, TransactionRequired.No);
                                        }

                                        Helper.Response.Redirect("~/CRM/CRMPaymentScheduleList.aspx");
                                    }
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                        }

                        #endregion

                        _PaymentScheduleID = 0;
                        _CRMPaymentScheduleEntity = new CRMPaymentScheduleEntity();
                        TemporaryCRMPaymentScheduleMapList = new List<CRMPaymentScheduleMapEntity>();
                        Action = "Add";
                       // txtReservation.ReadOnly = false;
                       // txtEarnestMoney.ReadOnly = false;
                        PrepareInitialView();
                        BindCRMPaymentScheduleMapList();

                        if (cRMPaymentScheduleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Payment Schedule Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Payment Schedule Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMPaymentScheduleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Payment Schedule Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Payment Schedule Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void BuildAgreementBuyerInfo()
        {
            if (ddlAgreementID.SelectedValue == "0")
            {
                ddlBuyerBasicInfoID.Enabled = true;
                MiscUtil.PopulateCRMBuyerBasicInfo(ddlBuyerBasicInfoID, false);
                txtProjectCode.Text = String.Empty;
                txtProjectCode.ReadOnly = false;
            }

            else if (ddlAgreementID != null && ddlAgreementID.SelectedValue != "0")
            {
                CRMAgreementEntity cRMAgreementEntity = FCCCRMAgreement.GetFacadeCreate().GetByID(Int64.Parse(ddlAgreementID.SelectedValue));

                if (cRMAgreementEntity != null && cRMAgreementEntity.AgreementID > 0)
                {
                    ddlBuyerBasicInfoID.SelectedValue = cRMAgreementEntity.BuyerBasicInfoID.ToString();
                    ddlBuyerBasicInfoID.Enabled = false;

                    BDProjectEntity bDProjectEntity = FCCBDProject.GetFacadeCreate().GetByID(cRMAgreementEntity.ProjectID);

                    if (bDProjectEntity != null && bDProjectEntity.ProjectID > 0)
                    {
                        txtProjectCode.Text = bDProjectEntity.ProjectCode.ToString();
                        txtProjectCode.ReadOnly = true;
                    }
                }
            }
        }

        private void BuildBookingBuyerInfo()
        {
            if (_PaymentScheduleID == 0)
            {
                CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity = FCCCRMBuyerBookSpace.GetFacadeCreate().GetByID(OverviewBookSpaceID);

                if (cRMBuyerBookSpaceEntity != null && cRMBuyerBookSpaceEntity.BuyerBookSpaceID > 0)
                {
                    MiscUtil.PopulateCRMBuyerBasicInfo(ddlBuyerBasicInfoID, false, cRMBuyerBookSpaceEntity.ReferenceID);

                    BDProjectEntity bDProjectEntity = FCCBDProject.GetFacadeCreate().GetByID(cRMBuyerBookSpaceEntity.ProjectID);

                    if (bDProjectEntity != null && bDProjectEntity.ProjectID > 0)
                    {
                        txtProjectCode.Text = bDProjectEntity.ProjectCode.ToString();
                        txtProjectCode.ReadOnly = true;
                    }
                }
            }
            else if (_PaymentScheduleID != 0)
            {
                CRMPaymentScheduleEntity ent = FCCCRMPaymentSchedule.GetFacadeCreate().GetByID(_PaymentScheduleID);
                CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity = FCCCRMBuyerBookSpace.GetFacadeCreate().GetByID(ent.BuyerBookSpaceID);
                if (cRMBuyerBookSpaceEntity != null && cRMBuyerBookSpaceEntity.BuyerBookSpaceID > 0)
                {
                    MiscUtil.PopulateCRMBuyerBasicInfo(ddlBuyerBasicInfoID, false, cRMBuyerBookSpaceEntity.ReferenceID);

                    BDProjectEntity bDProjectEntity = FCCBDProject.GetFacadeCreate().GetByID(cRMBuyerBookSpaceEntity.ProjectID);

                    if (bDProjectEntity != null && bDProjectEntity.ProjectID > 0)
                    {
                        txtProjectCode.Text = bDProjectEntity.ProjectCode.ToString();
                        txtProjectCode.ReadOnly = true;
                    }
                }
            }
        }

        private void GenerateInstallment()
        {
            if (txtTotalInstallment.Text.Trim().IsNotNullOrEmpty())
            {
                Int64 totalInstallmentNo,totalAgreementAmount,earnestMoney,reservedAmount;
                Decimal agreementA, agreementB, agreementC;

                Int64.TryParse(txtTotalInstallment.Text.Trim().ToString(), out totalInstallmentNo);
                Int64.TryParse(txtTotalAgreementAmount.Text.Trim().ToString(), out totalAgreementAmount);
                Int64.TryParse(txtEarnestMoney.Text.Trim().ToString(), out earnestMoney);
                Int64.TryParse(txtReservation.Text.Trim().ToString(), out reservedAmount);

                if (totalInstallmentNo > 0)
                {
                    IList<CRMPaymentScheduleMapEntity> lstCRMPaymentScheduleMap = new List<CRMPaymentScheduleMapEntity>();

                    DateTime processedDateTime = System.DateTime.Now;
                    CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = new CRMPaymentScheduleMapEntity();

                    for (Int32 i = 1; i <= 2; i++)
                    {
                        cRMPaymentScheduleMapEntity = new CRMPaymentScheduleMapEntity();
                        String processedInstallmentName = String.Empty;
                        Decimal installmentAmount = 0;

                        switch (i)
                        {
                            case 1:
                                processedInstallmentName = "Earnest Money";
                                installmentAmount = earnestMoney;
                                break;
                            case 2:
                                processedInstallmentName = "Reservation";
                                installmentAmount = reservedAmount;
                                break;
                        }

                        if (processedInstallmentName.IsNotNullOrEmpty())
                        {
                            cRMPaymentScheduleMapEntity.InstallmentName = processedInstallmentName;
                        }

                        cRMPaymentScheduleMapEntity.PaymentScheduleMapID = lstCRMPaymentScheduleMap.Count+1;
                        cRMPaymentScheduleMapEntity.InstallmentDueDate = System.DateTime.Now; // should come from agreement.
                        agreementA = installmentAmount * .5m;        // 50% for agreement A
                        agreementB = installmentAmount * .42m;     // 42% for agreement B
                        agreementC = installmentAmount * .08m;     // 8% for agreement C
                        cRMPaymentScheduleMapEntity.AgreementAAmount = agreementA;
                        cRMPaymentScheduleMapEntity.AgreementBAmount = agreementB;
                        cRMPaymentScheduleMapEntity.AgreementCAmount = agreementC;
                        cRMPaymentScheduleMapEntity.Remarks = String.Empty;

                        lstCRMPaymentScheduleMap.Add(cRMPaymentScheduleMapEntity);
                    }

                    totalAgreementAmount = totalAgreementAmount - earnestMoney - reservedAmount;
                    Decimal perAgreement = totalAgreementAmount / totalInstallmentNo;

                    for (Int32 count = 1; count <= totalInstallmentNo; count++)
                    {
                        cRMPaymentScheduleMapEntity = new CRMPaymentScheduleMapEntity();

                        String processedInstallmentName = String.Empty;

                        switch (count)
                        {
                            case 1:
                            case 21:
                            case 31:
                            case 41:
                            case 51:
                            case 61:
                            case 71:
                            case 81:
                            case 91:
                                processedInstallmentName = count + "st";
                                break;
                            case 2:
                            case 22:
                            case 32:
                            case 42:
                            case 52:
                            case 62:
                            case 72:
                            case 82:
                            case 92:
                                processedInstallmentName = count + "nd";
                                break;
                            case 3:
                            case 23:
                            case 33:
                            case 43:
                            case 53:
                            case 63:
                            case 73:
                            case 83:
                            case 93:
                                processedInstallmentName = count + "rd";
                                break;
                            default:
                                processedInstallmentName = count + "th";
                                break;
                        }

                        if (processedInstallmentName.IsNotNullOrEmpty())
                        {
                            if (count == totalInstallmentNo)
                            {
                                processedInstallmentName = "Final";
                            }
                            cRMPaymentScheduleMapEntity.InstallmentName = processedInstallmentName + " Installment";
                        }
                        cRMPaymentScheduleMapEntity.PaymentScheduleMapID = lstCRMPaymentScheduleMap.Count+1;
                        cRMPaymentScheduleMapEntity.InstallmentDueDate = processedDateTime; // should come from agreement.
                        agreementA = perAgreement * .5m;        // 50% for agreement A
                        agreementB = perAgreement * .42m;     // 42% for agreement B
                        agreementC = perAgreement * .08m;     // 8% for agreement C
                        cRMPaymentScheduleMapEntity.AgreementAAmount = agreementA;
                        cRMPaymentScheduleMapEntity.AgreementBAmount = agreementB;
                        cRMPaymentScheduleMapEntity.AgreementCAmount = agreementC;
                        cRMPaymentScheduleMapEntity.Remarks = String.Empty;

                        processedDateTime = processedDateTime.AddDays(60);

                        lstCRMPaymentScheduleMap.Add(cRMPaymentScheduleMapEntity);
                    }

                    TemporaryCRMPaymentScheduleMapList = lstCRMPaymentScheduleMap;

                    TemporaryCRMPaymentScheduleMapList = TemporaryCRMPaymentScheduleMapList.OrderBy(x => x.PaymentScheduleMapID).ToList();
                    BindCRMPaymentScheduleMapList();
                    //btnCreateInstallment.Enabled = false;
                  //  txtReservation.ReadOnly = true; Stoped by Rayan vaiya 24-Aug-2013 
                   // txtEarnestMoney.ReadOnly = true;
                    btnRecalculate.Visible = true;
                    lnkRecalulateGrandTotal.Visible = true;
                }
            }
            else if (txtTotalInstallment.Text.Trim().IsNullOrEmpty())
            {
                MiscUtil.ShowMessage(lblMessage, "Please Input the Installment Number", true);
            }
        }

        private void CalculateRemaingAmount()
        {
            try
            {
                IList<ListViewDataItem> listScheduleMap = lvCRMPaymentScheduleMap.Items;

                Decimal agreementAmount;

                Decimal.TryParse(txtTotalAgreementAmount.Text.Trim(), out agreementAmount);

                Decimal grandTotal = 0, remainingAmount;

                if (listScheduleMap != null && listScheduleMap.Count > 0)
                {
                    foreach (ListViewDataItem lvdi in listScheduleMap)
                    {
                        Decimal runingTotalQty;

                        Decimal agreementAAmount, agreementBAmount, agreementCAmount;

                        TextBox txtAgreementAAmountLV = (TextBox)lvdi.FindControl("txtAgreementAAmountLV");
                        TextBox txtAgreementBAmountLV = (TextBox)lvdi.FindControl("txtAgreementBAmountLV");
                        TextBox txtAgreementCAmountLV = (TextBox)lvdi.FindControl("txtAgreementCAmountLV");
                        TextBox txtTotalLV = (TextBox)lvdi.FindControl("txtTotalLV");

                        Decimal.TryParse(txtAgreementAAmountLV.Text.Trim(), out agreementAAmount);
                        Decimal.TryParse(txtAgreementBAmountLV.Text.Trim(), out agreementBAmount);
                        Decimal.TryParse(txtAgreementCAmountLV.Text.Trim(), out agreementCAmount);

                        txtTotalLV.Text = (agreementAAmount + agreementBAmount + agreementCAmount).ToString();
                        
                        Decimal.TryParse(txtTotalLV.Text.Trim(), out runingTotalQty);

                        grandTotal = grandTotal + runingTotalQty;
                    }
                }

                remainingAmount = agreementAmount - grandTotal;

                lblRemainingAmount.Text ="Remaining Amount : "+ Decimal.Round(remainingAmount, 2).ToString();
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Some Error occured : " + ex.Message, true);
            }
        }

        private void CalculateGrandTotalListView()
        {
            try
            {
                IList<ListViewDataItem> listScheduleMap = lvCRMPaymentScheduleMap.Items;

                if (listScheduleMap != null && listScheduleMap.Count > 0)
                {
                    foreach (ListViewDataItem lvdi in listScheduleMap)
                    {
                        Decimal agreementAAmount, agreementBAmount, agreementCAmount;

                        TextBox txtAgreementAAmountLV = (TextBox)lvdi.FindControl("txtAgreementAAmountLV");
                        TextBox txtAgreementBAmountLV = (TextBox)lvdi.FindControl("txtAgreementBAmountLV");
                        TextBox txtAgreementCAmountLV = (TextBox)lvdi.FindControl("txtAgreementCAmountLV");
                        TextBox txtTotalLV = (TextBox)lvdi.FindControl("txtTotalLV");
                        Decimal.TryParse(txtAgreementAAmountLV.Text.Trim(), out agreementAAmount);
                        Decimal.TryParse(txtAgreementBAmountLV.Text.Trim(), out agreementBAmount);
                        Decimal.TryParse(txtAgreementCAmountLV.Text.Trim(), out agreementCAmount);

                        txtTotalLV.Text = (agreementAAmount + agreementBAmount + agreementCAmount).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Some Error occured : " + ex.Message, true);
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

        protected void lvCRMPaymentScheduleMap_ItemCreated(object sender, ListViewItemEventArgs e)
        {
            //if ((e.Item != null) && (e.Item.ItemType == ListViewItemType.InsertItem))
            //{
            //    System.Web.UI.Control ddlUnitIDInsert = e.Item.FindControl("ddlUnitIDInsert");
            //    if (ddlUnitIDInsert != null)
            //    {
            //        MiscUtil.PopulateMDUnit((DropDownList)ddlUnitIDInsert, false);
            //    }
            //}
        }

        protected void lvCRMPaymentScheduleMap_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CRMPaymentScheduleMapEntity ent = (CRMPaymentScheduleMapEntity)dataItem.DataItem;
                
                TextBox txtInstallmentNameLV= (TextBox)e.Item.FindControl("txtInstallmentNameLV");
                TextBox txtAgreementAAmountLV= (TextBox)e.Item.FindControl("txtAgreementAAmountLV");
                TextBox txtAgreementBAmountLV= (TextBox)e.Item.FindControl("txtAgreementBAmountLV");
                TextBox txtAgreementCAmountLV= (TextBox)e.Item.FindControl("txtAgreementCAmountLV");
                TextBox txtRemarksLV = (TextBox)e.Item.FindControl("txtRemarksLV");
                TextBox txtInstallmentDueDateLV = (TextBox)e.Item.FindControl("txtInstallmentDueDateLV");

                if (ent.FinalPayment == true)
                {
                    txtInstallmentNameLV.Enabled = false;
                    txtAgreementAAmountLV.Enabled = false;
                    txtAgreementBAmountLV.Enabled = false;
                    txtAgreementCAmountLV.Enabled = false;
                    txtRemarksLV.Enabled = false;
                    txtInstallmentDueDateLV.Enabled = false;

                    txtInstallmentNameLV.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F0E1");
                    txtAgreementAAmountLV.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F0E1");
                    txtAgreementBAmountLV.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F0E1");
                    txtAgreementCAmountLV.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F0E1");
                    txtRemarksLV.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F0E1");
                    txtInstallmentDueDateLV.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F0E1");
                }

                switch (txtInstallmentNameLV.Text.Trim())
                {
                    case "Earnest Money":
                    case "Reservation":
                        txtInstallmentNameLV.Enabled=false;
                        txtAgreementAAmountLV.Enabled=false;
                        txtAgreementBAmountLV.Enabled=false;
                        txtAgreementCAmountLV.Enabled=false;
                        txtRemarksLV.Enabled = false;
                        txtInstallmentDueDateLV.Enabled = false;

                    txtInstallmentNameLV.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F0E1");
                    txtAgreementAAmountLV.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F0E1");
                    txtAgreementBAmountLV.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F0E1");
                    txtAgreementCAmountLV.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F0E1");
                    txtRemarksLV.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F0E1");
                    txtInstallmentDueDateLV.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F0E1");
                    break;
                }

                //txtAgreementAAmountLV.ClientID=

                //txtAgreementAAmountLV.Attributes.Add("onchange", "alert(document.getElementById('" + txtAgreementAAmountLV.Text + "').innerText);");
            }

        }

        protected void lvCRMPaymentScheduleMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PaymentScheduleMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out PaymentScheduleMapID);

            if (PaymentScheduleMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    //_PaymentScheduleMapID = PaymentScheduleMapID;

                    //PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {

                        switch (Action)
                        {
                            case "Edit":
                                 Int64 result = -1;

                                String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleMapEntity.FLD_NAME_PaymentScheduleMapID, PaymentScheduleMapID.ToString(), SQLMatchType.Equal);

                                CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = new CRMPaymentScheduleMapEntity();


                                result = FCCCRMPaymentScheduleMap.GetFacadeCreate().Delete(cRMPaymentScheduleMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                                if (result == 0)
                                {
                                    _PaymentScheduleMapID = 0;
                                    _CRMPaymentScheduleMapEntity = new CRMPaymentScheduleMapEntity();
                                    PrepareInitialView();
                                    BindCRMPaymentScheduleMapList();

                                    MiscUtil.ShowMessage(lblMessage, "Payment Schedule Map has been successfully deleted.", true);
                                }
                                else
                                {
                                    MiscUtil.ShowMessage(lblMessage, "Failed to delete Payment Schedule Map.", true);
                                }
                                break;
                            case "Add":

                                CRMPaymentScheduleMapEntity ent = (from s in TemporaryCRMPaymentScheduleMapList
                                                                   where s.PaymentScheduleMapID == PaymentScheduleMapID
                                                                   select s).FirstOrDefault();
                                if (ent != null && ent.PaymentScheduleMapID>0)
                                {
                                    TemporaryCRMPaymentScheduleMapList.Remove(ent);
                                    BindCRMPaymentScheduleMapList();
                                }

                                break;
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }

            if (string.Equals(e.CommandName, "InsertItem"))
            {
                CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = new CRMPaymentScheduleMapEntity();

                TextBox txtInstallmentNameLV = (TextBox)e.Item.FindControl("txtInstallmentNameLV");
                TextBox txtAgreementAAmountLV = (TextBox)e.Item.FindControl("txtAgreementAAmountLV");
                TextBox txtAgreementBAmountLV = (TextBox)e.Item.FindControl("txtAgreementBAmountLV");
                TextBox txtAgreementCAmountLV = (TextBox)e.Item.FindControl("txtAgreementCAmountLV");
                TextBox txtRemarksLV = (TextBox)e.Item.FindControl("txtRemarksLV");
                TextBox txtInstallmentDueDateLV = (TextBox)e.Item.FindControl("txtInstallmentDueDateLV");


                cRMPaymentScheduleMapEntity.InstallmentName = txtInstallmentNameLV.Text.Trim();
                
                cRMPaymentScheduleMapEntity.InstallmentDueDate = MiscUtil.ParseToDateTime(txtInstallmentDueDateLV.Text.Trim()); ; // should come from agreement.
                cRMPaymentScheduleMapEntity.AgreementAAmount = Decimal.Parse(txtAgreementAAmountLV.Text.Trim());
                cRMPaymentScheduleMapEntity.AgreementBAmount = Decimal.Parse(txtAgreementBAmountLV.Text.Trim());
                cRMPaymentScheduleMapEntity.AgreementCAmount = Decimal.Parse(txtAgreementCAmountLV.Text.Trim());
                cRMPaymentScheduleMapEntity.Remarks = txtRemarksLV.Text.Trim();

                switch (Action)
                {
                    case "Edit":
                        cRMPaymentScheduleMapEntity.PaymentScheduleID = _PaymentScheduleID;
                        FCCCRMPaymentScheduleMap.GetFacadeCreate().Add(cRMPaymentScheduleMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        break;
                    case "Add":
                        cRMPaymentScheduleMapEntity.PaymentScheduleID = _PaymentScheduleID;
                        cRMPaymentScheduleMapEntity.PaymentScheduleMapID = TemporaryCRMPaymentScheduleMapList.Count+1;
                        TemporaryCRMPaymentScheduleMapList.Add(cRMPaymentScheduleMapEntity);
                        break;

                }
                BindCRMPaymentScheduleMapList();

            }
        }

        #endregion List View Event

        #region Button Event

        protected void btnRecalculate_Click(object sender, EventArgs e)
        {
            CalculateRemaingAmount();
        }

        protected void btnCreateInstallment_Click(object sender, EventArgs e)
        {
            if (txtTotalInstallment.Text.Trim().IsNullOrEmpty())
            {
                MiscUtil.ShowMessage(lblMessage, "Please Enter Installment No", true);
                return;
            }

            GenerateInstallment();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                SaveCRMPaymentScheduleEntity();
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PaymentScheduleID = 0;
            _CRMPaymentScheduleEntity = new CRMPaymentScheduleEntity();
            TemporaryCRMPaymentScheduleMapList = new List<CRMPaymentScheduleMapEntity>();
            PrepareInitialView();
            btnCreateInstallment.Enabled = true;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void lnkRecalulateGrandTotal_Click(object sender, EventArgs e)
        {
            CalculateGrandTotalListView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlAgreementID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildAgreementBuyerInfo();
        }

        #endregion

        #endregion Event
    }
}
