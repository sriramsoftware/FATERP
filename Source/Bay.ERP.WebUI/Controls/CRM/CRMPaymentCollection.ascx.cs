// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Apr-2013, 12:14:24




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
    public partial class CRMPaymentCollectionControl : BaseControl
    {       
        #region Properties

        public Int64 _PaymentCollectionID
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

        public CRMPaymentCollectionEntity _CRMPaymentCollectionEntity
        {
            get
            {
                CRMPaymentCollectionEntity entity = new CRMPaymentCollectionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMPaymentCollectionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMPaymentCollectionEntity CurrentCRMPaymentCollectionEntity
        {
            get
            {
                if (_PaymentCollectionID > 0)
                {
                    if (_CRMPaymentCollectionEntity.PaymentCollectionID != _PaymentCollectionID)
                    {
                        _CRMPaymentCollectionEntity = FCCCRMPaymentCollection.GetFacadeCreate().GetByID(_PaymentCollectionID);
                    }
                }

                return _CRMPaymentCollectionEntity;
            }
            set
            {
                _CRMPaymentCollectionEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCRMPaymentScheduleMap(ddlPaymentScheduleMapID, false);
            MiscUtil.PopulateCRMAgreement(ddlAgreementID, false);
            MiscUtil.PopulateCRMMDPaymentApprovalStatus(ddlPaymentApprovalStatusID, false);
            MiscUtil.PopulateCRMMDPaymentCategory(ddlPaymentCategoryID, false);
          
            BuildScheduleMapByAgreement();
        }

        private void BuildScheduleMapByAgreement()
        {
            if (ddlAgreementID != null && ddlAgreementID.Items.Count > 0)
            {
                MiscUtil.PopulateCRMPendingPaymentScheduleMapByAgreement(ddlPaymentScheduleMapID, false, Int64.Parse(ddlAgreementID.SelectedValue));

                if (ddlPaymentScheduleMapID != null && ddlPaymentScheduleMapID.Items.Count > 0)
                {
                    CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetByID(Int64.Parse(ddlPaymentScheduleMapID.SelectedValue));

                    if (cRMPaymentScheduleMapEntity != null && cRMPaymentScheduleMapEntity.PaymentScheduleMapID > 0)
                    {
                        Decimal totalAmount;
                        totalAmount =(Decimal)(cRMPaymentScheduleMapEntity.AgreementAAmount + cRMPaymentScheduleMapEntity.AgreementBAmount + cRMPaymentScheduleMapEntity.AgreementCAmount);
                        txtTotalAmount.Text = totalAmount.ToString();
                        txtAgreementAAmount.Text = cRMPaymentScheduleMapEntity.AgreementAAmount.ToString();
                        txtAgreementBAmount.Text = cRMPaymentScheduleMapEntity.AgreementBAmount.ToString();
                        txtAgreementCAmount.Text = cRMPaymentScheduleMapEntity.AgreementCAmount.ToString();
                        txtGrossAmount.Text = totalAmount.ToString();
                        txtNetAmount.Text = totalAmount.ToString();
                        txtInitialAmountInAgreement.Text = totalAmount.ToString();
                        ViewState["AgreementAmount"] = totalAmount;
                        txtPaymentDueAmount.Text = totalAmount.ToString();
                        lblPaymentCategory.Text = "Complete Payment";
                        txtOverDueAmount.Text="0";
                        txtPaymentDueDate.Text = cRMPaymentScheduleMapEntity.InstallmentDueDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                    }
                }
                else
                {
                    ddlPaymentScheduleMapID.Items.Clear();
                    txtTotalAmount.Text = "0";
                    txtAgreementAAmount.Text = "0";
                    txtAgreementBAmount.Text = "0";
                    txtAgreementCAmount.Text = "0";
                    txtGrossAmount.Text = "0";
                    txtNetAmount.Text = "0";
                    txtInitialAmountInAgreement.Text = "0";
                    ViewState["AgreementAmount"] = 0;
                    txtPaymentDueAmount.Text = "0";
                    lblPaymentCategory.Text = String.Empty;
                    txtOverDueAmount.Text="0";
                    txtPaymentDueDate.Text = String.Empty;
                }
            }
            else
            {
                ddlPaymentScheduleMapID.Items.Clear();
                txtTotalAmount.Text = "0";
                txtAgreementAAmount.Text = "0";
                txtAgreementBAmount.Text = "0";
                txtAgreementCAmount.Text = "0";
                ViewState["AgreementAmount"] = 0;
                txtPaymentDueAmount.Text = "0";
                txtOverDueAmount.Text = "0";
                lblPaymentCategory.Text = String.Empty;
                txtPaymentDueDate.Text = String.Empty;
            }
        }

        private void BuildAgreementAmountByInstallment()
        {
            if (ddlPaymentScheduleMapID != null && ddlPaymentScheduleMapID.Items.Count > 0)
            {
                CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetByID(Int64.Parse(ddlPaymentScheduleMapID.SelectedValue));

                if (cRMPaymentScheduleMapEntity != null && cRMPaymentScheduleMapEntity.PaymentScheduleMapID > 0)
                {
                    Decimal totalAmount;
                    totalAmount = (Decimal)(cRMPaymentScheduleMapEntity.AgreementAAmount + cRMPaymentScheduleMapEntity.AgreementBAmount + cRMPaymentScheduleMapEntity.AgreementCAmount);
                    txtTotalAmount.Text = totalAmount.ToString();
                    txtAgreementAAmount.Text = cRMPaymentScheduleMapEntity.AgreementAAmount.ToString();
                    txtAgreementBAmount.Text = cRMPaymentScheduleMapEntity.AgreementBAmount.ToString();
                    txtAgreementCAmount.Text = cRMPaymentScheduleMapEntity.AgreementCAmount.ToString();
                    txtGrossAmount.Text = totalAmount.ToString();
                    txtNetAmount.Text = totalAmount.ToString();
                    txtInitialAmountInAgreement.Text = totalAmount.ToString();
                    txtPaymentDueAmount.Text = totalAmount.ToString();
                    txtOverDueAmount.Text = "0";
                    ViewState["AgreementAmount"] = totalAmount;
                    lblPaymentCategory.Text = "Complete Payment";
                    txtPaymentDueDate.Text = cRMPaymentScheduleMapEntity.InstallmentDueDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                }
            }
            else
            {
                ddlPaymentScheduleMapID.Items.Clear();
                txtTotalAmount.Text = "0";
                txtAgreementAAmount.Text = "0";
                txtAgreementBAmount.Text = "0";
                txtAgreementCAmount.Text = "0";
                txtGrossAmount.Text = "0";
                txtNetAmount.Text = "0";
                txtOverDueAmount.Text = "0";
                txtInitialAmountInAgreement.Text = "0";
                txtPaymentDueAmount.Text = "0";
                ViewState["AgreementAmount"] = 0;
                lblPaymentCategory.Text = String.Empty;
                txtPaymentDueDate.Text = String.Empty;
            }
        }

        private void BuildAgreementByAgreementType()
        {
            if (ddlSearchAgreementTypeID.Items.Count > 0 && ddlSearchAgreementTypeID != null)
            {
                MiscUtil.PopulateCRMAgreementByAgreementType(ddlSearchAgreementID, false, Int64.Parse(ddlSearchAgreementTypeID.SelectedValue));
                MiscUtil.PopulateCRMPaymentScheduleByAgreement(ddlSearchPaymentScheduleID, false, Int64.Parse(ddlSearchAgreementID.SelectedValue));
            }
            else
            {
                ddlSearchAgreementID.Items.Clear();
                ddlSearchPaymentScheduleID.Items.Clear();
            }
        }

        private void BuildScheduleByAgreement()
        {
            if (ddlSearchAgreementID.Items.Count > 0 && ddlSearchAgreementID != null)
            {
                MiscUtil.PopulateCRMPaymentScheduleByAgreement(ddlSearchPaymentScheduleID, false, Int64.Parse(ddlSearchAgreementID.SelectedValue));
            }
            else
            {
                ddlSearchPaymentScheduleID.Items.Clear();
            }
        }

        private void PrepareValidator()
        {
        }

        private Boolean ValidationInput()
        {
            Boolean flag = true;

            if (Int64.Parse(ddlPaymentCategoryID.SelectedValue) == MasterDataConstants.CRMMDPaymentCategory.PAYMENT_EXCEDED)
            {
                flag = false;
                MiscUtil.ShowMessage(lblMessage, "Please Adjust the payment, Payment Should not be exceded", true);
            }

            if (ddlPaymentScheduleMapID != null && ddlPaymentScheduleMapID.Items.Count > 0)
            {
                Decimal agreementA=0,agreementB=0,agreementC=0;
                Decimal.TryParse(txtAgreementAAmount.Text.Trim(), out agreementA);
                Decimal.TryParse(txtAgreementBAmount.Text.Trim(), out agreementB);
                Decimal.TryParse(txtAgreementCAmount.Text.Trim(), out agreementC);

                CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetByID(Int64.Parse(ddlPaymentScheduleMapID.SelectedValue));

                if (cRMPaymentScheduleMapEntity != null && cRMPaymentScheduleMapEntity.PaymentScheduleMapID > 0)
                {
                    if (cRMPaymentScheduleMapEntity.AgreementAAmount < agreementA)
                    {
                        MiscUtil.ShowMessage(lblMessage, "The Maximum paid amount of Agreement A is : " + cRMPaymentScheduleMapEntity.AgreementAAmount, true);
                        flag = false;
                    }
                    else if (cRMPaymentScheduleMapEntity.AgreementBAmount < agreementB)
                    {
                        MiscUtil.ShowMessage(lblMessage, "The Maximum paid amount of Agreement B is : "+cRMPaymentScheduleMapEntity.AgreementBAmount, true);
                        flag = false;
                    }
                    else if (cRMPaymentScheduleMapEntity.AgreementCAmount < agreementC)
                    {
                        MiscUtil.ShowMessage(lblMessage, "The Maximum paid amount of Agreement C is : "+cRMPaymentScheduleMapEntity.AgreementCAmount, true);
                        flag = false;
                    }
                }
            }

            return flag;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtMoneyReceiptNo.Text = String.Empty;
            txtActualPaymentDate.Text = String.Empty;
            txtPaymentDescription.Text = String.Empty;
            txtOverDueAmount.Text = "0";
            txtDelayDayOnPayment.Text = "0";
            txtDelayDayOnOverDue.Text = "0";
            txtPaymentReceivedInBank.Text = String.Empty;
            txtPaymentNotReceivedNote.Text = String.Empty;
            chkReverseEntry.Checked = false;
            chkLastPayment.Checked = false;
            txtDiscountAmount.Text = String.Empty;
            txtVat.Text = String.Empty;
            txtTax.Text = String.Empty;
            txtServiceCharge.Text = String.Empty;
            txtAdditionalFee.Text = String.Empty;
            txtGrossAmount.Text = String.Empty;
            txtNetAmount.Text = String.Empty;
            txtExtraField.Text = String.Empty;
            txtCashOrChequeNo.Text = String.Empty;
            txtCashOrChequeDate.Text = String.Empty;
            txtBankName.Text = String.Empty;
            txtBranchName.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMPaymentCollectionEntity cRMPaymentCollectionEntity = CurrentCRMPaymentCollectionEntity;


            if (!cRMPaymentCollectionEntity.IsNew)
            {
                if (ddlPaymentScheduleMapID.Items.Count > 0 && cRMPaymentCollectionEntity.PaymentScheduleMapID != null)
                {
                    ddlPaymentScheduleMapID.SelectedValue = cRMPaymentCollectionEntity.PaymentScheduleMapID.ToString();
                }

                txtMoneyReceiptNo.Text = cRMPaymentCollectionEntity.MoneyReceiptNo.ToString();
                txtActualPaymentDate.Text = cRMPaymentCollectionEntity.ActualPaymentDate.ToStringDefault();
                txtPaymentDescription.Text = cRMPaymentCollectionEntity.PaymentDescription.ToString();
                txtOverDueAmount.Text = cRMPaymentCollectionEntity.OverDueAmount.ToString();
                txtDelayDayOnPayment.Text = cRMPaymentCollectionEntity.DelayDayOnPayment.ToString();
                txtDelayDayOnOverDue.Text = cRMPaymentCollectionEntity.DelayDayOnOverDue.ToString();
                txtPaymentReceivedInBank.Text = cRMPaymentCollectionEntity.PaymentReceivedInBank.ToString();
                txtPaymentNotReceivedNote.Text = cRMPaymentCollectionEntity.PaymentNotReceivedNote.ToString();
                if (ddlAgreementID.Items.Count > 0 && cRMPaymentCollectionEntity.AgreementID != null)
                {
                    ddlAgreementID.SelectedValue = cRMPaymentCollectionEntity.AgreementID.ToString();
                }

                chkReverseEntry.Checked = cRMPaymentCollectionEntity.ReverseEntry;
                chkLastPayment.Checked = cRMPaymentCollectionEntity.LastPayment;
                txtDiscountAmount.Text = cRMPaymentCollectionEntity.DiscountAmount.ToString();
                txtVat.Text = cRMPaymentCollectionEntity.Vat.ToString();
                txtTax.Text = cRMPaymentCollectionEntity.Tax.ToString();
                txtServiceCharge.Text = cRMPaymentCollectionEntity.ServiceCharge.ToString();
                txtAdditionalFee.Text = cRMPaymentCollectionEntity.AdditionalFee.ToString();
                txtGrossAmount.Text = cRMPaymentCollectionEntity.GrossAmount.ToString();
                txtNetAmount.Text = cRMPaymentCollectionEntity.NetAmount.ToString();
                txtCashOrChequeNo.Text = cRMPaymentCollectionEntity.CashOrChequeNo.ToString();
                txtCashOrChequeDate.Text = cRMPaymentCollectionEntity.CashOrChequeDate.ToStringDefault();
                txtBankName.Text = cRMPaymentCollectionEntity.BankName.ToString();
                txtBranchName.Text = cRMPaymentCollectionEntity.BranchName.ToString();
                if (ddlPaymentApprovalStatusID.Items.Count > 0 && cRMPaymentCollectionEntity.PaymentApprovalStatusID != null)
                {
                    ddlPaymentApprovalStatusID.SelectedValue = cRMPaymentCollectionEntity.PaymentApprovalStatusID.ToString();
                }

                if (ddlPaymentCategoryID.Items.Count > 0 && cRMPaymentCollectionEntity.PaymentCategoryID != null)
                {
                    ddlPaymentCategoryID.SelectedValue = cRMPaymentCollectionEntity.PaymentCategoryID.ToString();
                }

                txtExtraField.Text = cRMPaymentCollectionEntity.ExtraField.ToString();
                txtRemarks.Text = cRMPaymentCollectionEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMPaymentCollectionList();
        }

        private void BindCRMPaymentCollectionList()
        {
            lvCRMPaymentCollection.DataBind();
        }

        private CRMPaymentCollectionEntity BuildCRMPaymentCollectionEntity()
        {
             CRMPaymentCollectionEntity cRMPaymentCollectionEntity = CurrentCRMPaymentCollectionEntity;

             //for (Int32 i = 1; i <= 3; i++)
             //{

             //    if (ddlPaymentScheduleMapID.Items.Count > 0)
             //    {
             //        if (ddlPaymentScheduleMapID.SelectedValue == "0")
             //        {
             //        }
             //        else
             //        {
             //            cRMPaymentCollectionEntity.PaymentScheduleMapID = Int64.Parse(ddlPaymentScheduleMapID.SelectedValue);
             //        }
             //    }

             //    CRMAgreementEntity cRMAgreementEntity = FCCCRMAgreement.GetFacadeCreate().GetByID(Int64.Parse(ddlAgreementID.SelectedValue));

             //    if (cRMAgreementEntity != null && cRMAgreementEntity.AgreementID > 0)
             //    {
             //        cRMPaymentCollectionEntity.AgreementTypeID = cRMAgreementEntity.AgreementTypeID;
             //        cRMPaymentCollectionEntity.ProjectID = cRMAgreementEntity.ProjectID;
             //    }

             //    if (!txtMoneyReceiptNo.Text.Trim().IsNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.MoneyReceiptNo = Decimal.Parse(txtMoneyReceiptNo.Text.Trim());
             //    }

             //    if (txtActualPaymentDate.Text.Trim().IsNotNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.ActualPaymentDate = MiscUtil.ParseToDateTime(txtActualPaymentDate.Text);
             //    }

             //    cRMPaymentCollectionEntity.PaymentDescription = txtPaymentDescription.Text.Trim();

             //    Decimal installmentAmount = 0;

             //    switch (i)
             //    {
             //        case 1:
             //            if (txtAgreementAAmount.Text.Trim().IsNotNullOrEmpty())
             //            {
             //                Decimal.TryParse(txtAgreementAAmount.Text.ToString(), out installmentAmount);
             //            }
             //            break;
             //        case 2:
             //            if (txtAgreementBAmount.Text.Trim().IsNotNullOrEmpty())
             //            {
             //                Decimal.TryParse(txtAgreementBAmount.Text.ToString(), out installmentAmount);
             //            }
             //            break;
             //        case 3:
             //            if (txtAgreementCAmount.Text.Trim().IsNotNullOrEmpty())
             //            {
             //                Decimal.TryParse(txtAgreementCAmount.Text.ToString(), out installmentAmount);
             //            }
             //            break;
             //    }

             //    cRMPaymentCollectionEntity.InstallmentPaymentAmount = installmentAmount;
             //    cRMPaymentCollectionEntity.InstallmentPaymentInWord = "Word Will Come Here";

             //    if (txtInitialAmountInAgreement.Text.Trim().IsNotNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.InitialAmountInAgreement = Decimal.Parse(txtInitialAmountInAgreement.Text.Trim());
             //    }
             //    else
             //    {
             //        cRMPaymentCollectionEntity.InitialAmountInAgreement = null;
             //    }

             //    if (!txtOverDueAmount.Text.Trim().IsNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.OverDueAmount = Decimal.Parse(txtOverDueAmount.Text.Trim());
             //    }
             //    else
             //    {
             //        cRMPaymentCollectionEntity.OverDueAmount = null;
             //    }

             //    if (!txtDelayDayOnPayment.Text.Trim().IsNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.DelayDayOnPayment = Decimal.Parse(txtDelayDayOnPayment.Text.Trim());
             //    }
             //    else
             //    {
             //        cRMPaymentCollectionEntity.DelayDayOnPayment = null;
             //    }

             //    if (!txtDelayDayOnOverDue.Text.Trim().IsNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.DelayDayOnOverDue = Decimal.Parse(txtDelayDayOnOverDue.Text.Trim());
             //    }
             //    else
             //    {
             //        cRMPaymentCollectionEntity.DelayDayOnOverDue = null;
             //    }

             //    if (!txtPaymentReceivedInBank.Text.Trim().IsNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.PaymentReceivedInBank = Decimal.Parse(txtPaymentReceivedInBank.Text.Trim());
             //    }
             //    else
             //    {
             //        cRMPaymentCollectionEntity.PaymentReceivedInBank = null;
             //    }

             //    cRMPaymentCollectionEntity.PaymentNotReceivedNote = txtPaymentNotReceivedNote.Text.Trim();
             //    if (ddlAgreementID.Items.Count > 0)
             //    {
             //        if (ddlAgreementID.SelectedValue == "0")
             //        {
             //        }
             //        else
             //        {
             //            cRMPaymentCollectionEntity.AgreementID = Int64.Parse(ddlAgreementID.SelectedValue);
             //        }
             //    }

             //    cRMPaymentCollectionEntity.ReverseEntry = chkReverseEntry.Checked;

             //    cRMPaymentCollectionEntity.LastPayment = chkLastPayment.Checked;

             //    if (!txtDiscountAmount.Text.Trim().IsNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.DiscountAmount = Char.Parse(txtDiscountAmount.Text.Trim());
             //    }

             //    if (!txtVat.Text.Trim().IsNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.Vat = Char.Parse(txtVat.Text.Trim());
             //    }

             //    if (!txtTax.Text.Trim().IsNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.Tax = Char.Parse(txtTax.Text.Trim());
             //    }

             //    if (!txtServiceCharge.Text.Trim().IsNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.ServiceCharge = Char.Parse(txtServiceCharge.Text.Trim());
             //    }

             //    if (!txtAdditionalFee.Text.Trim().IsNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.AdditionalFee = Char.Parse(txtAdditionalFee.Text.Trim());
             //    }

             //    if (!txtGrossAmount.Text.Trim().IsNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.GrossAmount = Char.Parse(txtGrossAmount.Text.Trim());
             //    }

             //    if (!txtNetAmount.Text.Trim().IsNullOrEmpty())
             //    {
             //        cRMPaymentCollectionEntity.NetAmount = Char.Parse(txtNetAmount.Text.Trim());
             //    }

             //    if (ddlPaymentApprovalStatusID.Items.Count > 0)
             //    {
             //        if (ddlPaymentApprovalStatusID.SelectedValue == "0")
             //        {
             //        }
             //        else
             //        {
             //            cRMPaymentCollectionEntity.PaymentApprovalStatusID = Int64.Parse(ddlPaymentApprovalStatusID.SelectedValue);
             //        }
             //    }

             //    if (ddlPaymentCategoryID.Items.Count > 0)
             //    {
             //        if (ddlPaymentCategoryID.SelectedValue == "0")
             //        {
             //        }
             //        else
             //        {
             //            cRMPaymentCollectionEntity.PaymentCategoryID = Int64.Parse(ddlPaymentCategoryID.SelectedValue);
             //        }
             //    }

             //    cRMPaymentCollectionEntity.ExtraField = txtExtraField.Text.Trim();
             //    cRMPaymentCollectionEntity.Remarks = txtRemarks.Text.Trim();
             //    cRMPaymentCollectionEntity.CreateDate = System.DateTime.Now;
             //    cRMPaymentCollectionEntity.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
             //    cRMPaymentCollectionEntity.IP = MiscUtil.GetLocalIP();
             //}

            return cRMPaymentCollectionEntity;
        }

        private void SaveCRMPaymentCollectionEntity()
        {
            if (IsValid)
            {
                try
                {

                    #region Previous Code

                    //try
                    //{
                    //    IList<ListViewDataItem> listPaymentSchedule = lvCRMPaymentCollection.Items;

                    //    if (listPaymentSchedule != null && listPaymentSchedule.Count > 0)
                    //    {
                    //        foreach (ListViewDataItem lvdi in listPaymentSchedule)
                    //        {
                    //            TextBox txtInstallmentNameLV = (TextBox)lvdi.FindControl("txtInstallmentNameLV");
                    //            TextBox txtAgreementAAmountLV = (TextBox)lvdi.FindControl("txtAgreementAAmountLV");
                    //            TextBox txtAgreementBAmountLV = (TextBox)lvdi.FindControl("txtAgreementBAmountLV");
                    //            TextBox txtAgreementCAmountLV = (TextBox)lvdi.FindControl("txtAgreementCAmountLV");
                    //            TextBox txtInstallmentDueDateLV = (TextBox)lvdi.FindControl("txtInstallmentDueDateLV");
                    //            TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");

                    //            Decimal agreementAAmount, agreementBAmount, agreementCAmount;

                    //            Decimal.TryParse(txtAgreementAAmountLV.Text.Trim(), out agreementAAmount);
                    //            Decimal.TryParse(txtAgreementBAmountLV.Text.Trim(), out agreementBAmount);
                    //            Decimal.TryParse(txtAgreementCAmountLV.Text.Trim(), out agreementCAmount);


                    //            CRMPaymentCollectionEntity cRMPaymentCollectionEntity = new CRMPaymentCollectionEntity();

                    //            cRMPaymentCollectionEntity.PaymentScheduleMapID = Int64.Parse(ddlPaymentScheduleMapID.SelectedValue);
                    //            //cRMPaymentCollectionEntity.AgreementTypeID = Int64.Parse(ddlAgreementTypeID.SelectedValue);
                    //                cRMPaymentCollectionEntity.MoneyReceiptNo = Decimal.Parse(txtMoneyReceiptNo.Text.Trim());

                    //            if (txtActualPaymentDate.Text.Trim().IsNotNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.ActualPaymentDate = MiscUtil.ParseToDateTime(txtActualPaymentDate.Text);
                    //            }

                    //            cRMPaymentCollectionEntity.PaymentDescription = txtPaymentDescription.Text.Trim();
                    //            if (!txtInstallmentPaymentAmount.Text.Trim().IsNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.InstallmentPaymentAmount = Decimal.Parse(txtInstallmentPaymentAmount.Text.Trim());
                    //            }
                    //            else
                    //            {
                    //                cRMPaymentCollectionEntity.InstallmentPaymentAmount = null;
                    //            }

                    //            //cRMPaymentCollectionEntity.InstallmentPaymentInWord = txtInstallmentPaymentInWord.Text.Trim();
                    //            //if (!txtInitialAmountInAgreement.Text.Trim().IsNullOrEmpty())
                    //            //{
                    //            //    cRMPaymentCollectionEntity.InitialAmountInAgreement = Decimal.Parse(txtInitialAmountInAgreement.Text.Trim());
                    //            //}
                    //            else
                    //            {
                    //                cRMPaymentCollectionEntity.InitialAmountInAgreement = null;
                    //            }

                    //            if (!txtOverDueAmount.Text.Trim().IsNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.OverDueAmount = Decimal.Parse(txtOverDueAmount.Text.Trim());
                    //            }
                    //            else
                    //            {
                    //                cRMPaymentCollectionEntity.OverDueAmount = null;
                    //            }

                    //            if (!txtDelayDayOnPayment.Text.Trim().IsNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.DelayDayOnPayment = Decimal.Parse(txtDelayDayOnPayment.Text.Trim());
                    //            }
                    //            else
                    //            {
                    //                cRMPaymentCollectionEntity.DelayDayOnPayment = null;
                    //            }

                    //            if (!txtDelayDayOnOverDue.Text.Trim().IsNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.DelayDayOnOverDue = Decimal.Parse(txtDelayDayOnOverDue.Text.Trim());
                    //            }
                    //            else
                    //            {
                    //                cRMPaymentCollectionEntity.DelayDayOnOverDue = null;
                    //            }

                    //            if (!txtPaymentReceivedInBank.Text.Trim().IsNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.PaymentReceivedInBank = Decimal.Parse(txtPaymentReceivedInBank.Text.Trim());
                    //            }
                    //            else
                    //            {
                    //                cRMPaymentCollectionEntity.PaymentReceivedInBank = null;
                    //            }

                    //            cRMPaymentCollectionEntity.PaymentNotReceivedNote = txtPaymentNotReceivedNote.Text.Trim();
                    //            if (ddlAgreementID.Items.Count > 0)
                    //            {
                    //                if (ddlAgreementID.SelectedValue == "0")
                    //                {
                    //                }
                    //                else
                    //                {
                    //                    cRMPaymentCollectionEntity.AgreementID = Int64.Parse(ddlAgreementID.SelectedValue);
                    //                }
                    //            }

                    //            if (ddlProjectID.Items.Count > 0)
                    //            {
                    //                if (ddlProjectID.SelectedValue == "0")
                    //                {
                    //                }
                    //                else
                    //                {
                    //                    cRMPaymentCollectionEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                    //                }
                    //            }

                    //            cRMPaymentCollectionEntity.ReverseEntry = chkReverseEntry.Checked;

                    //            cRMPaymentCollectionEntity.LastPayment = chkLastPayment.Checked;

                    //            if (!txtDiscountAmount.Text.Trim().IsNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.DiscountAmount = Char.Parse(txtDiscountAmount.Text.Trim());
                    //            }

                    //            if (!txtVat.Text.Trim().IsNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.Vat = Char.Parse(txtVat.Text.Trim());
                    //            }

                    //            if (!txtTax.Text.Trim().IsNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.Tax = Char.Parse(txtTax.Text.Trim());
                    //            }

                    //            if (!txtServiceCharge.Text.Trim().IsNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.ServiceCharge = Char.Parse(txtServiceCharge.Text.Trim());
                    //            }

                    //            if (!txtAdditionalFee.Text.Trim().IsNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.AdditionalFee = Char.Parse(txtAdditionalFee.Text.Trim());
                    //            }

                    //            if (!txtGrossAmount.Text.Trim().IsNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.GrossAmount = Char.Parse(txtGrossAmount.Text.Trim());
                    //            }

                    //            if (!txtNetAmount.Text.Trim().IsNullOrEmpty())
                    //            {
                    //                cRMPaymentCollectionEntity.NetAmount = Char.Parse(txtNetAmount.Text.Trim());
                    //            }

                    //            if (ddlPaymentApprovalStatusID.Items.Count > 0)
                    //            {
                    //                if (ddlPaymentApprovalStatusID.SelectedValue == "0")
                    //                {
                    //                }
                    //                else
                    //                {
                    //                    cRMPaymentCollectionEntity.PaymentApprovalStatusID = Int64.Parse(ddlPaymentApprovalStatusID.SelectedValue);
                    //                }
                    //            }

                    //            if (ddlPaymentCategoryID.Items.Count > 0)
                    //            {
                    //                if (ddlPaymentCategoryID.SelectedValue == "0")
                    //                {
                    //                }
                    //                else
                    //                {
                    //                    cRMPaymentCollectionEntity.PaymentCategoryID = Int64.Parse(ddlPaymentCategoryID.SelectedValue);
                    //                }
                    //            }

                    //            cRMPaymentCollectionEntity.ExtraField = null;
                    //            cRMPaymentCollectionEntity.Remarks = txtRemarks.Text.Trim();

                    //            cRMPaymentCollectionEntity.CreateDate = System.DateTime.Now;
                    //            cRMPaymentCollectionEntity.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                    //            cRMPaymentCollectionEntity.IP = MiscUtil.GetLocalIP();

                    //            FCCCRMPaymentCollection.GetFacadeCreate().Add(cRMPaymentCollectionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    //        }
                    //    }
                    //}
                    //catch (Exception ex)
                    //{
                    //}

                    #endregion

                    if (ddlPaymentCategoryID.SelectedValue == MasterDataConstants.CRMMDPaymentCategory.COMPLETED.ToString())
                    {
                        CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetByID(Int64.Parse(ddlPaymentScheduleMapID.SelectedValue));

                        if (cRMPaymentScheduleMapEntity != null && cRMPaymentScheduleMapEntity.PaymentScheduleMapID > 0)
                        {
                            #region Update Info

                            cRMPaymentScheduleMapEntity.FinalPayment = true;

                            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleMapEntity.FLD_NAME_PaymentScheduleMapID, cRMPaymentScheduleMapEntity.PaymentScheduleMapID.ToString(), SQLMatchType.Equal);
                            FCCCRMPaymentScheduleMap.GetFacadeCreate().Update(cRMPaymentScheduleMapEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                            #endregion
                        }

                    }

                    if (ddlPaymentCategoryID.SelectedValue == MasterDataConstants.CRMMDPaymentCategory.PARTIAL_PAYMENT.ToString())
                    {
                        CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetByID(Int64.Parse(ddlPaymentScheduleMapID.SelectedValue));

                        if (cRMPaymentScheduleMapEntity != null && cRMPaymentScheduleMapEntity.PaymentScheduleMapID>0)
                        {
                            Decimal agreementAAamount, agreementBAmount, agreementCAmount;
                            Decimal agreementAmount,totalPaidAmount;

                            #region Update Info
                            Decimal.TryParse(txtPaymentDueAmount.Text.ToString(), out agreementAmount);

                            Decimal.TryParse(txtTotalAmount.Text.ToString(), out totalPaidAmount);

                            Decimal.TryParse(txtAgreementAAmount.Text.ToString(), out agreementAAamount);
                            Decimal.TryParse(txtAgreementBAmount.Text.ToString(), out agreementBAmount);
                            Decimal.TryParse(txtAgreementCAmount.Text.ToString(), out agreementCAmount);

                            cRMPaymentScheduleMapEntity.AgreementAAmount = agreementAAamount;
                            cRMPaymentScheduleMapEntity.AgreementBAmount = agreementBAmount;
                            cRMPaymentScheduleMapEntity.AgreementCAmount = agreementCAmount;
                            cRMPaymentScheduleMapEntity.FinalPayment = true;

                            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleMapEntity.FLD_NAME_PaymentScheduleMapID, cRMPaymentScheduleMapEntity.PaymentScheduleMapID.ToString(), SQLMatchType.Equal);
                            FCCCRMPaymentScheduleMap.GetFacadeCreate().Update(cRMPaymentScheduleMapEntity,fe, DatabaseOperationType.Update, TransactionRequired.No);

                            #endregion

                            #region Insert New Installment Info

                            cRMPaymentScheduleMapEntity.LinkPaymentScheduleMapID = cRMPaymentScheduleMapEntity.PaymentScheduleMapID;
                            cRMPaymentScheduleMapEntity.InstallmentName = cRMPaymentScheduleMapEntity.InstallmentName+" (*)";

                            Decimal needToPayAgreementA = agreementAmount * .50m;
                            Decimal needToPayAgreementB = agreementAmount * .42m;
                            Decimal needToPayAgreementC = agreementAmount * .08m;

                            //Decimal.TryParse(txtOverDueAmount.Text.ToString(), out agreementAmount);

                            if (agreementAAamount == needToPayAgreementA)
                            {
                                agreementAAamount = 0;
                            }
                            else if (needToPayAgreementA > agreementAAamount)
                            {
                                agreementAAamount = needToPayAgreementA - agreementAAamount;
                            }

                            if (agreementBAmount == needToPayAgreementB)
                            {
                                agreementBAmount = 0;
                            }
                            else if (needToPayAgreementB > agreementBAmount)
                            {
                                agreementBAmount = needToPayAgreementB - agreementBAmount;
                            }

                            if (agreementCAmount == needToPayAgreementC)
                            {
                                agreementCAmount = 0;
                            }
                            else if (needToPayAgreementA > agreementCAmount)
                            {
                                agreementCAmount = needToPayAgreementC - agreementCAmount;
                            }

                            cRMPaymentScheduleMapEntity.AgreementAAmount = agreementAAamount;
                            cRMPaymentScheduleMapEntity.AgreementBAmount = agreementBAmount;
                            cRMPaymentScheduleMapEntity.AgreementCAmount = agreementCAmount;

                            cRMPaymentScheduleMapEntity.FinalPayment = false;

                            FCCCRMPaymentScheduleMap.GetFacadeCreate().Add(cRMPaymentScheduleMapEntity, DatabaseOperationType.Add, TransactionRequired.No);

                            #endregion
                        }
                    }
                    Int64 paymentScheduleID=0;

                    if (ddlPaymentScheduleMapID != null && ddlPaymentScheduleMapID.Items.Count > 0)
                    {
                        CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetByID(Int64.Parse(ddlPaymentScheduleMapID.SelectedValue));

                        if (cRMPaymentScheduleMapEntity != null && cRMPaymentScheduleMapEntity.PaymentScheduleMapID > 0)
                        {
                            paymentScheduleID = cRMPaymentScheduleMapEntity.PaymentScheduleID;
                        }
                    }

                    for (Int32 i = 1; i <= 3; i++)
                    {
                        CRMPaymentCollectionEntity cRMPaymentCollectionEntity = new CRMPaymentCollectionEntity();

                        Decimal agreementAmount = (Decimal)ViewState["AgreementAmount"];

                        if (ddlPaymentScheduleMapID.Items.Count > 0)
                        {
                            if (ddlPaymentScheduleMapID.SelectedValue == "0")
                            {
                            }
                            else
                            {
                                cRMPaymentCollectionEntity.PaymentScheduleMapID = Int64.Parse(ddlPaymentScheduleMapID.SelectedValue);
                            }
                        }

                        if (paymentScheduleID > 0)
                        {
                            cRMPaymentCollectionEntity.PaymentScheduleID = paymentScheduleID;
                        }

                        CRMAgreementEntity cRMAgreementEntity = FCCCRMAgreement.GetFacadeCreate().GetByID(Int64.Parse(ddlAgreementID.SelectedValue));

                        if (cRMAgreementEntity != null && cRMAgreementEntity.AgreementID > 0)
                        {   
                            cRMPaymentCollectionEntity.ProjectID = cRMAgreementEntity.ProjectID;
                        }

                        if (!txtMoneyReceiptNo.Text.Trim().IsNullOrEmpty())
                        {
                            cRMPaymentCollectionEntity.MoneyReceiptNo = Decimal.Parse(txtMoneyReceiptNo.Text.Trim());
                        }
                        else
                        {
                            cRMPaymentCollectionEntity.MoneyReceiptNo = 0;
                        }

                        if (txtActualPaymentDate.Text.Trim().IsNotNullOrEmpty())
                        {
                            cRMPaymentCollectionEntity.ActualPaymentDate = MiscUtil.ParseToDateTime(txtActualPaymentDate.Text);
                        }

                        cRMPaymentCollectionEntity.PaymentDescription = txtPaymentDescription.Text.Trim();

                        Decimal installmentAmount = 0,partialAmount=0;
                        Int64 agreementPaymentType = 0;

                        Decimal needToPayAgreementA = agreementAmount * .50m;
                        Decimal needToPayAgreementB = agreementAmount * .42m;
                        Decimal needToPayAgreementC = agreementAmount * .08m;

                        switch (i)
                        {
                            case 1:
                                if (txtAgreementAAmount.Text.Trim().IsNotNullOrEmpty())
                                {
                                    Decimal.TryParse(txtAgreementAAmount.Text.ToString(), out installmentAmount);
                                }

                                agreementPaymentType = MasterDataConstants.CRMMDAgreementType.AGREEMENT_A;

                                if (ddlPaymentCategoryID.SelectedValue == MasterDataConstants.CRMMDPaymentCategory.PARTIAL_PAYMENT.ToString())
                                {
                                    if (installmentAmount == needToPayAgreementA)
                                    {
                                        partialAmount = 0;
                                    }
                                    else if (needToPayAgreementA > installmentAmount)
                                    {
                                        partialAmount = needToPayAgreementA - installmentAmount;
                                    }
                                }

                                break;
                            case 2:
                                if (txtAgreementBAmount.Text.Trim().IsNotNullOrEmpty())
                                {
                                    Decimal.TryParse(txtAgreementBAmount.Text.ToString(), out installmentAmount);
                                }
                                agreementPaymentType = MasterDataConstants.CRMMDAgreementType.AGREEMENT_B;

                                if (ddlPaymentCategoryID.SelectedValue == MasterDataConstants.CRMMDPaymentCategory.PARTIAL_PAYMENT.ToString())
                                {
                                    if (installmentAmount == needToPayAgreementB)
                                    {
                                        partialAmount = 0;
                                    }
                                    else if (needToPayAgreementB > installmentAmount)
                                    {
                                        partialAmount = needToPayAgreementB - installmentAmount;
                                    }
                                }

                                break;
                            case 3:
                                if (txtAgreementCAmount.Text.Trim().IsNotNullOrEmpty())
                                {
                                    Decimal.TryParse(txtAgreementCAmount.Text.ToString(), out installmentAmount);
                                }
                                agreementPaymentType = MasterDataConstants.CRMMDAgreementType.AGREEMENT_C;

                                if (ddlPaymentCategoryID.SelectedValue == MasterDataConstants.CRMMDPaymentCategory.PARTIAL_PAYMENT.ToString())
                                {
                                    if (installmentAmount == needToPayAgreementC)
                                    {
                                        partialAmount = 0;
                                    }
                                    else if (needToPayAgreementC > installmentAmount)
                                    {
                                        partialAmount = needToPayAgreementC - installmentAmount;
                                    }
                                }

                                break;
                        }

                        cRMPaymentCollectionEntity.AgreementTypeID = agreementPaymentType;

                        cRMPaymentCollectionEntity.InstallmentPaymentAmount = installmentAmount;
                        cRMPaymentCollectionEntity.InstallmentPaymentInWord = "Word Will Come Here";

                        if (txtInitialAmountInAgreement.Text.Trim().IsNotNullOrEmpty())
                        {
                            cRMPaymentCollectionEntity.InitialAmountInAgreement = Decimal.Parse(txtInitialAmountInAgreement.Text.Trim());
                        }
                        else
                        {
                            cRMPaymentCollectionEntity.InitialAmountInAgreement = null;
                        }

                        //if (!txtOverDueAmount.Text.Trim().IsNullOrEmpty())
                        //{
                        //    cRMPaymentCollectionEntity.OverDueAmount = Decimal.Parse(txtOverDueAmount.Text.Trim());
                        //}
                        //else
                        //{
                            cRMPaymentCollectionEntity.OverDueAmount = null;
                        //}

                            DateTime dueDate = MiscUtil.ParseToDateTime(txtPaymentDueDate.Text.ToString());
                            DateTime paymentDate = MiscUtil.ParseToDateTime(txtActualPaymentDate.Text.ToString());

                            if ((paymentDate - dueDate).TotalDays > 0)
                            {
                                cRMPaymentCollectionEntity.DelayDayOnPayment = Decimal.Parse((paymentDate - dueDate).TotalDays.ToString());
                            }
                            else
                            {
                                cRMPaymentCollectionEntity.DelayDayOnPayment = null;
                            }

                        //if (!txtDelayDayOnOverDue.Text.Trim().IsNullOrEmpty())
                        //{
                        //    cRMPaymentCollectionEntity.DelayDayOnOverDue = Decimal.Parse(txtDelayDayOnOverDue.Text.Trim());
                        //}
                        //else
                        //{
                            cRMPaymentCollectionEntity.DelayDayOnOverDue = null;
                        //}

                        if (!txtPaymentReceivedInBank.Text.Trim().IsNullOrEmpty())
                        {
                            cRMPaymentCollectionEntity.PaymentReceivedInBank = Decimal.Parse(txtPaymentReceivedInBank.Text.Trim());
                        }
                        else
                        {
                            cRMPaymentCollectionEntity.PaymentReceivedInBank = null;
                        }
                        cRMPaymentCollectionEntity.ChequeInCashConfirmation = false;

                        cRMPaymentCollectionEntity.PaymentNotReceivedNote = txtPaymentNotReceivedNote.Text.Trim();
                        if (ddlAgreementID.Items.Count > 0)
                        {
                            if (ddlAgreementID.SelectedValue == "0")
                            {
                            }
                            else
                            {
                                cRMPaymentCollectionEntity.AgreementID = Int64.Parse(ddlAgreementID.SelectedValue);
                            }
                        }

                        cRMPaymentCollectionEntity.ReverseEntry = chkReverseEntry.Checked;

                        cRMPaymentCollectionEntity.LastPayment = chkLastPayment.Checked;

                        if (!txtDiscountAmount.Text.Trim().IsNullOrEmpty())
                        {
                            cRMPaymentCollectionEntity.DiscountAmount = Decimal.Parse(txtDiscountAmount.Text.Trim());
                        }
                        else
                        {
                            cRMPaymentCollectionEntity.DiscountAmount = null;
                        }

                        if (!txtVat.Text.Trim().IsNullOrEmpty())
                        {
                            cRMPaymentCollectionEntity.Vat = Decimal.Parse(txtVat.Text.Trim());
                        }
                        else
                        {
                            cRMPaymentCollectionEntity.Vat = null;
                        }

                        if (!txtTax.Text.Trim().IsNullOrEmpty())
                        {
                            cRMPaymentCollectionEntity.Tax = Decimal.Parse(txtTax.Text.Trim());
                        }
                        else
                        {
                            cRMPaymentCollectionEntity.Tax = null;
                        }

                        if (!txtServiceCharge.Text.Trim().IsNullOrEmpty())
                        {
                            cRMPaymentCollectionEntity.ServiceCharge = Decimal.Parse(txtServiceCharge.Text.Trim());
                        }
                        else
                        {
                            cRMPaymentCollectionEntity.ServiceCharge = null;
                        }

                        if (!txtAdditionalFee.Text.Trim().IsNullOrEmpty())
                        {
                            cRMPaymentCollectionEntity.AdditionalFee = Decimal.Parse(txtAdditionalFee.Text.Trim());
                        }
                        else
                        {
                            cRMPaymentCollectionEntity.AdditionalFee = null;
                        }

                        if (!txtGrossAmount.Text.Trim().IsNullOrEmpty())
                        {
                            cRMPaymentCollectionEntity.GrossAmount = Decimal.Parse(txtGrossAmount.Text.Trim());
                        }
                        else
                        {
                            cRMPaymentCollectionEntity.GrossAmount = null;
                        }

                        if (!txtNetAmount.Text.Trim().IsNullOrEmpty())
                        {
                            cRMPaymentCollectionEntity.NetAmount = Decimal.Parse(txtNetAmount.Text.Trim());
                        }
                        else
                        {
                            cRMPaymentCollectionEntity.NetAmount = null;
                        }

                        if (ddlPaymentApprovalStatusID.Items.Count > 0)
                        {
                            if (ddlPaymentApprovalStatusID.SelectedValue == "0")
                            {
                            }
                            else
                            {
                                cRMPaymentCollectionEntity.PaymentApprovalStatusID = Int64.Parse(ddlPaymentApprovalStatusID.SelectedValue);
                            }
                        }

                        if (ddlPaymentCategoryID.Items.Count > 0)
                        {
                            if (ddlPaymentCategoryID.SelectedValue == "0")
                            {
                            }
                            else
                            {
                                cRMPaymentCollectionEntity.PaymentCategoryID = Int64.Parse(ddlPaymentCategoryID.SelectedValue);
                            }
                        }

                        cRMPaymentCollectionEntity.ExtraField = txtExtraField.Text.Trim();
                        cRMPaymentCollectionEntity.CashOrChequeNo = txtCashOrChequeNo.Text.Trim();

                        if (txtCashOrChequeDate.Text.Trim().IsNotNullOrEmpty())
                        {
                            cRMPaymentCollectionEntity.CashOrChequeDate = MiscUtil.ParseToDateTime(txtCashOrChequeDate.Text);
                        }
                        else
                        {
                            cRMPaymentCollectionEntity.CashOrChequeDate = null;
                        }

                        cRMPaymentCollectionEntity.BankName = txtBankName.Text.Trim();
                        cRMPaymentCollectionEntity.BranchName = txtBranchName.Text.Trim();
                        cRMPaymentCollectionEntity.Remarks = txtRemarks.Text.Trim();
                        cRMPaymentCollectionEntity.CreateDate = System.DateTime.Now;
                        cRMPaymentCollectionEntity.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                        cRMPaymentCollectionEntity.IP = MiscUtil.GetLocalIP();

                        Int64 result=FCCCRMPaymentCollection.GetFacadeCreate().Add(cRMPaymentCollectionEntity, DatabaseOperationType.Add, TransactionRequired.No);

                        if (result > 0)
                        {
                            dvMoneyReceipt.Visible = true;

                            switch (i)
                            {
                                case 1:
                                    hypAgreementAMoneyReceipt.Text = "Agreement A Money Receipt";
                                    hypAgreementAMoneyReceipt.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.MONEY_RECEIPT_REPORT, UrlConstants.OVERVIEW_PAYMENT_COLLECTION_ID, result.ToString()).ToString();
                                    hypAgreementAMoneyReceipt.Target = "_blank";
                                    break;
                                case 2:
                                    hypAgreementBMoneyReceipt.Text = "Agreement B Money Receipt";
                                    hypAgreementBMoneyReceipt.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.MONEY_RECEIPT_REPORT, UrlConstants.OVERVIEW_PAYMENT_COLLECTION_ID, result.ToString()).ToString();
                                    hypAgreementBMoneyReceipt.Target = "_blank";
                                    break;
                                case 3:
                                    hypAgreementCMoneyReceipt.Text = "Agreement C Money Receipt";
                                    hypAgreementCMoneyReceipt.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.MONEY_RECEIPT_REPORT, UrlConstants.OVERVIEW_PAYMENT_COLLECTION_ID, result.ToString()).ToString();
                                    hypAgreementCMoneyReceipt.Target = "_blank";
                                    break;
                            }
                        }

                        #region Previous Code

                        //if (ddlPaymentCategoryID.SelectedValue == MasterDataConstants.CRMMDPaymentCategory.PARTIAL_PAYMENT.ToString())
                        //{   
                        //    cRMPaymentCollectionEntity.InstallmentPaymentAmount = partialAmount;
                        //    cRMPaymentCollectionEntity.OverDueAmount = null;
                        //    cRMPaymentCollectionEntity.DelayDayOnPayment = null;

                        //    if (partialAmount > 0)
                        //    {
                        //        cRMPaymentCollectionEntity.DelayDayOnOverDue = Decimal.Parse((System.DateTime.Now - MiscUtil.ParseToDateTime(txtPaymentDueDate.Text)).TotalDays.ToString());
                        //    }

                        //    else if (partialAmount <= 0)
                        //    {
                        //        cRMPaymentCollectionEntity.DelayDayOnOverDue = null;
                        //    }

                        //    cRMPaymentCollectionEntity.PaymentDescription = ddlPaymentScheduleMapID.SelectedItem.ToString();
                        //    cRMPaymentCollectionEntity.ActualPaymentDate = null;
                        //    FCCCRMPaymentCollection.GetFacadeCreate().Add(cRMPaymentCollectionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        //}

                        #endregion
                    }

                    _PaymentCollectionID = 0;
                    _CRMPaymentCollectionEntity = new CRMPaymentCollectionEntity();
                    PrepareInitialView();
                    MiscUtil.ShowMessage(lblMessage, "Payment Collection Information has been added successfully.", false);
                    BindList();
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        protected Decimal CalculateAvailableAmount(Decimal paidAmount, Decimal percentageAmount)
        {
            Decimal availableAmount;
            availableAmount = paidAmount - percentageAmount;

            return availableAmount;
        }

        protected void Display(TextBox agreementName, Decimal availableAmount, Decimal percentageAmount, Decimal paidAmount)
        {
            if (availableAmount >= 0)
            {
                agreementName.Text = percentageAmount.ToString();
            }
            else
            {
                agreementName.Text = (paidAmount > 0 ? paidAmount : 0).ToString();
            }
        }

        private void CalculateAgreementDetail()
        {
            if (ddlPaymentScheduleMapID != null && ddlPaymentScheduleMapID.Items.Count > 0)
            {
                CRMPaymentScheduleMapEntity paymentScheduleMapEntity = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetByID(Int64.Parse(ddlPaymentScheduleMapID.SelectedValue));

                if (paymentScheduleMapEntity != null && paymentScheduleMapEntity.PaymentScheduleMapID > 0)
                {
                    txtAgreementAAmount.Text = paymentScheduleMapEntity.AgreementAAmount.ToString();
                    txtAgreementBAmount.Text = paymentScheduleMapEntity.AgreementBAmount.ToString();
                    txtAgreementCAmount.Text = paymentScheduleMapEntity.AgreementCAmount.ToString();
                }
                else
                {

                    Decimal dueAmount = 0, paidAmount = 0, availableAmount;

                    if (txtPaymentDueAmount.Text.Trim().IsNotNullOrEmpty())
                    {
                        Decimal.TryParse(txtTotalAmount.Text.Trim(), out dueAmount);
                    }
                    if (txtTotalAmount.Text.Trim().IsNotNullOrEmpty())
                    {
                        Decimal.TryParse(txtTotalAmount.Text.Trim(), out paidAmount);
                    }

                    Decimal percentageAAmount = 0, percentageBAmount = 0, percentageCAmount = 0;
                    percentageAAmount = dueAmount * .5m; //50%
                    percentageBAmount = dueAmount * .42m; //42%
                    percentageCAmount = dueAmount * .08m; //8%

                    availableAmount = CalculateAvailableAmount(paidAmount, percentageAAmount);

                    Display(txtAgreementAAmount, availableAmount, percentageAAmount, paidAmount);

                    paidAmount = availableAmount;
                    availableAmount = CalculateAvailableAmount(paidAmount, percentageBAmount);

                    Display(txtAgreementBAmount, availableAmount, percentageBAmount, paidAmount);

                    paidAmount = availableAmount;
                    availableAmount = CalculateAvailableAmount(paidAmount, percentageCAmount);

                    Display(txtAgreementCAmount, availableAmount, percentageCAmount, paidAmount);
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

        protected void lvCRMPaymentCollection_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PaymentCollectionID;

            Int64.TryParse(e.CommandArgument.ToString(), out PaymentCollectionID);

            if (PaymentCollectionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PaymentCollectionID = PaymentCollectionID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentCollectionEntity.FLD_NAME_PaymentCollectionID, PaymentCollectionID.ToString(), SQLMatchType.Equal);

                        CRMPaymentCollectionEntity cRMPaymentCollectionEntity = new CRMPaymentCollectionEntity();


                        result = FCCCRMPaymentCollection.GetFacadeCreate().Delete(cRMPaymentCollectionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PaymentCollectionID = 0;
                            _CRMPaymentCollectionEntity = new CRMPaymentCollectionEntity();
                            PrepareInitialView();
                            BindCRMPaymentCollectionList();

                            MiscUtil.ShowMessage(lblMessage, "Payment Collection has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Payment Collection.", true);
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

        protected void odsCRMPaymentCollection_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty; //SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentCollectionEntity.FLD_NAME_PaymentScheduleMapID, "0", SQLMatchType.Equal);

            if (ddlAgreementID != null && ddlAgreementID.Items.Count > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("CRMPaymentCollection." + CRMPaymentCollectionEntity.FLD_NAME_AgreementID, ddlAgreementID.SelectedValue.ToString(), SQLMatchType.Equal);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void lnkCalculateAgreementAmount_Click(object sender, EventArgs e)
        {
            CalculateAgreementDetail();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                SaveCRMPaymentCollectionEntity();
            }
        }

        protected void btnGetSchedule_Click(object sender, EventArgs e)
        {
            String fe_collection1 = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentCollectionEntity.FLD_NAME_AgreementID, ddlSearchAgreementID.SelectedValue, SQLMatchType.Equal);
            String fe_collection2 = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentCollectionEntity.FLD_NAME_AgreementID, ddlSearchAgreementTypeID.SelectedValue, SQLMatchType.Equal);
            String fe_collection = SqlExpressionBuilder.PrepareFilterExpression(fe_collection1, SQLJoinType.AND, fe_collection2);

            IList<CRMPaymentCollectionEntity> lstPaymentCollection = FCCCRMPaymentCollection.GetFacadeCreate().GetIL(null, null, String.Empty, fe_collection, DatabaseOperationType.LoadWithFilterExpression);

            if (lstPaymentCollection != null && lstPaymentCollection.Count > 0)
            {
                return;
            }

            else
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleMapEntity.FLD_NAME_PaymentScheduleID, ddlSearchPaymentScheduleID.SelectedValue.ToString(), SQLMatchType.Equal);
                IList<CRMPaymentScheduleMapEntity> lstPaymentScheduleMap = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lstPaymentScheduleMap != null && lstPaymentScheduleMap.Count > 0)
                {
                    foreach (CRMPaymentScheduleMapEntity ent in lstPaymentScheduleMap)
                    {
                        //for (Int32 i = 1; i <= 3; i++)
                        //{
                        Decimal paymentAmount = 0;

                        switch (Int64.Parse(ddlSearchAgreementTypeID.SelectedValue))
                        {
                            case MasterDataConstants.CRMMDAgreementType.AGREEMENT_A:
                                Decimal.TryParse(ent.AgreementAAmount.ToString(), out paymentAmount);
                                break;
                            case MasterDataConstants.CRMMDAgreementType.AGREEMENT_B:
                                Decimal.TryParse(ent.AgreementBAmount.ToString(), out paymentAmount);
                                break;
                            case MasterDataConstants.CRMMDAgreementType.AGREEMENT_C:
                                Decimal.TryParse(ent.AgreementCAmount.ToString(), out paymentAmount);
                                break;
                            //case 4:
                            //    Decimal.TryParse(ent.AgreementDAmount.ToString(), out paymentAmount);
                            //    break;
                            //case 5:
                            //    Decimal.TryParse(ent.AgreementEAmount.ToString(), out paymentAmount);
                            //    break;
                        }

                        if (paymentAmount > 0)
                        {
                            CRMPaymentCollectionEntity cRMPaymentCollectionEntity = new CRMPaymentCollectionEntity();

                            cRMPaymentCollectionEntity.PaymentScheduleMapID = ent.PaymentScheduleMapID;
                            cRMPaymentCollectionEntity.AgreementTypeID = Int64.Parse(ddlSearchAgreementTypeID.SelectedValue);
                            cRMPaymentCollectionEntity.MoneyReceiptNo = 0;
                            cRMPaymentCollectionEntity.ActualPaymentDate = ent.InstallmentDueDate;
                            cRMPaymentCollectionEntity.PaymentDescription = ent.InstallmentName;
                            cRMPaymentCollectionEntity.InstallmentPaymentAmount = paymentAmount;
                            cRMPaymentCollectionEntity.InstallmentPaymentInWord = "Installment Payment In Word will come here";
                            cRMPaymentCollectionEntity.InitialAmountInAgreement = null; // may be changed later on
                            cRMPaymentCollectionEntity.OverDueAmount = null;
                            cRMPaymentCollectionEntity.DelayDayOnPayment = null;
                            cRMPaymentCollectionEntity.DelayDayOnOverDue = null;
                            cRMPaymentCollectionEntity.PaymentReceivedInBank = null;
                            cRMPaymentCollectionEntity.PaymentNotReceivedNote = String.Empty;
                            cRMPaymentCollectionEntity.AgreementID = Int64.Parse(ent.AgreementID.ToString());
                            cRMPaymentCollectionEntity.PaymentScheduleID = Int64.Parse(ddlSearchPaymentScheduleID.SelectedValue);
                            cRMPaymentCollectionEntity.ProjectID = 48;
                            cRMPaymentCollectionEntity.ReverseEntry = false;
                            cRMPaymentCollectionEntity.LastPayment = false;
                            cRMPaymentCollectionEntity.DiscountAmount = 0;
                            cRMPaymentCollectionEntity.Vat = 0;
                            cRMPaymentCollectionEntity.Tax = 0;
                            cRMPaymentCollectionEntity.ServiceCharge = 0;
                            cRMPaymentCollectionEntity.AdditionalFee = 0;
                            cRMPaymentCollectionEntity.GrossAmount = paymentAmount;
                            cRMPaymentCollectionEntity.NetAmount = paymentAmount;
                            cRMPaymentCollectionEntity.PaymentApprovalStatusID = MasterDataConstants.CRMMDPaymentApprovalStatus.INITIATED;
                            cRMPaymentCollectionEntity.PaymentCategoryID = Int64.Parse(ddlPaymentCategoryID.SelectedValue); //will change here
                            cRMPaymentCollectionEntity.ExtraField = null;
                            cRMPaymentCollectionEntity.Remarks = ent.Remarks;
                            cRMPaymentCollectionEntity.CreateDate = System.DateTime.Now;
                            cRMPaymentCollectionEntity.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                            cRMPaymentCollectionEntity.IP = MiscUtil.GetLocalIP();

                            FCCCRMPaymentCollection.GetFacadeCreate().Add(cRMPaymentCollectionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            // }
                        }
                    }
                }
            }


            if (ddlSearchAgreementID != null && ddlSearchAgreementID.Items.Count > 0)
            {
               // String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleEntity.FLD_NAME_AgreementID, ddlSearchAgreementID.SelectedValue.ToString(), SQLMatchType.Equal);
                //String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleEntity.FLD_NAME_PaymentScheduleID,  ddlSearchAgreementTypeID.SelectedValue.ToString(), SQLMatchType.Equal);
                //String fe_filter = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                //ViewState["Search_String"] = fe1;
                BindList();
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ViewState["Search_String"] = null;
            BindList();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PaymentCollectionID = 0;
            _CRMPaymentCollectionEntity = new CRMPaymentCollectionEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlSearchAgreementTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildAgreementByAgreementType();
        }

        protected void ddlSearchAgreementID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildScheduleByAgreement();
        }

        protected void ddlAgreementID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildScheduleMapByAgreement();
            BindCRMPaymentCollectionList();
        }

        protected void ddlPaymentScheduleMapID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildAgreementAmountByInstallment();
        }

        protected void chbxMoneyReceipt_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxMoneyReceipt.Checked)
            {
                txtMoneyReceiptNo.Text = String.Empty;
                txtMoneyReceiptNo.Enabled = true;
            }
            else
            {
                txtMoneyReceiptNo.Text = String.Empty;
                txtMoneyReceiptNo.Enabled = false;
            }

        }

        #endregion

        #endregion Event
    }
}
