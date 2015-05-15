// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




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
    public partial class ACBankAccountPaymentControl : BaseControl
    {
        #region Extra Field Properties

        public Int64 PageAPType { get; set; }

        #endregion

        #region Properties

        public Int64 _BankAccountPaymentID
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

        public ACBankAccountPaymentEntity _ACBankAccountPaymentEntity
        {
            get
            {
                ACBankAccountPaymentEntity entity = new ACBankAccountPaymentEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACBankAccountPaymentEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACBankAccountPaymentEntity CurrentACBankAccountPaymentEntity
        {
            get
            {
                if (_BankAccountPaymentID > 0)
                {
                    if (_ACBankAccountPaymentEntity.BankAccountPaymentID != _BankAccountPaymentID)
                    {
                        _ACBankAccountPaymentEntity = FCCACBankAccountPayment.GetFacadeCreate().GetByID(_BankAccountPaymentID);
                    }
                }

                return _ACBankAccountPaymentEntity;
            }
            set
            {
                _ACBankAccountPaymentEntity = value;
            }
        }

        public IList<ACBankAccountPaymentItem_DetailedEntity> CurrentACBankAccountPaymentItemList
        {
            get
            {
                return (IList<ACBankAccountPaymentItem_DetailedEntity>)ViewState["vs_CurrentACBankAccountPaymentItem_DetailedList"];
            }
            set
            {
                ViewState["vs_CurrentACBankAccountPaymentItem_DetailedList"] = value;
            }
        }

        public Int64 _bankAccountPaymentID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["bankAccountPaymentID"] != null)
                {
                    Int64.TryParse(ViewState["bankAccountPaymentID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["bankAccountPaymentID"] = value;
            }
        }

        public Int64 _BankAccountPaymentItemID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["BankAccountPaymentItemID"] != null)
                {
                    Int64.TryParse(ViewState["BankAccountPaymentItemID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["BankAccountPaymentItemID"] = value;
            }
        }

        public ACBankAccountPaymentItem_DetailedEntity _ACBankAccountPaymentItemEntity
        {
            get
            {
                ACBankAccountPaymentItem_DetailedEntity entity = new ACBankAccountPaymentItem_DetailedEntity();

                if (ViewState["Current_ACBankAccountPaymentItemEntity"] != null)
                {
                    entity = (ACBankAccountPaymentItem_DetailedEntity)ViewState["Current_ACBankAccountPaymentItemEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["Current_ACBankAccountPaymentItemEntity"] = value;
            }
        }

        private ACBankAccountPaymentItem_DetailedEntity CurrentACBankAccountPaymentItemEntity
        {
            get
            {
                if (_BankAccountPaymentItemID > 0)
                {
                    //if (_ACBankAccountDepositItemEntity.BankAccountDepositItemID != _BankAccountDepositItemID)
                    //{   
                    _ACBankAccountPaymentItemEntity = (from s in CurrentACBankAccountPaymentItemList
                                                       where s.BankAccountPaymentItemID == _BankAccountPaymentItemID
                                                       select s).FirstOrDefault();
                    // }
                }

                return _ACBankAccountPaymentItemEntity;
            }
            set
            {
                _ACBankAccountPaymentItemEntity = value;
            }
        }

        #region Properties From Payable

        public Int64 PayablePostPayableDetailID
        {
            get
            {
                Int64 rostPayableDetailID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_DETAIL_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_DETAIL_ID], out rostPayableDetailID);
                }

                return rostPayableDetailID;
            }
        }

        public Int64 PayableAccountID
        {
            get
            {
                Int64 payableAccountID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PAYABLE_ACCOUNT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PAYABLE_ACCOUNT_ID], out payableAccountID);
                }

                return payableAccountID;
            }
        }

        public Int64 PayableBankAccountID
        {
            get
            {
                Int64 payableBankAccountID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_ID], out payableBankAccountID);
                }

                return payableBankAccountID;
            }
        }

        public Int64 PayableAmount
        {
            get
            {
                Int64 payableAmount = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PAYABLE_AMOUNT]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PAYABLE_AMOUNT], out payableAmount);
                }

                return payableAmount;
            }
        }

        #endregion Properties From Payable

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACMDPayTo(ddlPayToID, false);
            MiscUtil.PopulateACBankAccount(ddlBankAccountID, false);
            MiscUtil.PopulateStartWithAPPanel(ddlAPPanelID, false,MasterDataConstants.APPanelStartWith.ACCOUNTS);

            BuildReferenceByPayTo();

            if (PageAPType == MasterDataConstants.ACPaymentType.CASH_PAYMENT)
            {
                if (ddlBankAccountID != null && ddlBankAccountID.Items.Count > 0)
                {
                    ddlBankAccountID.SelectedValue = "3"; //Cash Payment Page. Default Cash Account ID is 3.
                    ddlBankAccountID.Enabled = false;
                }
            }
        }

        private void BuildDropDownListPaymentItem()
        {
            MiscUtil.PopulateMDItem(ddlItemID, true);
            MiscUtil.PopulateBDProject(ddlProjectID, true);

            BuildProjectWiseDropdownInfo();
        }

        private void BuildProjectWiseDropdownInfo()
        {
            if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
            {
                MiscUtil.PopulateREQApprovedRequisitionByProject(ddlRequisitionID, true,Int64.Parse(ddlProjectID.SelectedValue));

                BuildRequisitionWiseInfo();

                BuildWorkorderWiseInfo();

                BuildFloorInfo();

                BuildFloorWiseInfo();
            }
        }

        private void BuildRequisitionWiseInfo()
        {
            if (ddlRequisitionID != null && ddlRequisitionID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMWorkOrderByRequisitonID(ddlWorkOrderID, true, Int64.Parse(ddlRequisitionID.SelectedValue));

                BuildWorkorderWiseInfo();
            }
        }

        private void BuildWorkorderWiseInfo()
        {
            if (ddlWorkOrderID != null && ddlWorkOrderID.Items.Count > 0)
            {
                MiscUtil.PopulateCMBillByWorkOrder(ddlBillID, true,Int64.Parse(ddlWorkOrderID.SelectedValue));
            }
        }

        private void BuildFloorInfo()
        {
            if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
            {
                MiscUtil.PopulateBDProjectFloorByProject(ddlProjectFloorID, true, Int64.Parse(ddlProjectID.SelectedValue));

                BuildFloorWiseInfo();
            }
        }

        private void BuildFloorWiseInfo()
        {
            if (ddlProjectFloorID != null && ddlProjectFloorID.Items.Count > 0)
            {
                MiscUtil.PopulateBDProjectFloorUnitByFloor(ddlProjectFloorUnitID, true, Int64.Parse(ddlProjectFloorID.SelectedValue));
            }
        }

        private void PrepareInitialViewPaymentItem()
        {
            BuildDropDownListPaymentItem();

            txtAmount.Text = String.Empty;
            txtMemoDetail.Text = String.Empty;
        }

        private void PrepareValidator()
        {
        }

        private void PreparePayableView()
        {
            if (PayablePostPayableDetailID > 0 && PayableBankAccountID > 0)
            {
                #region Master Info

                if (ddlBankAccountID != null && ddlBankAccountID.Items.Count > 0)
                {
                    ddlBankAccountID.SelectedValue = PayableBankAccountID.ToString();
                }

                ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity = FCCACCPostPayableStatementDetail.GetFacadeCreate().GetByID(PayablePostPayableDetailID);

                if (aCCPostPayableStatementDetailEntity != null && aCCPostPayableStatementDetailEntity.PostPayableStatementDetailID > 0)
                {
                    switch (aCCPostPayableStatementDetailEntity.VendorCategoryID)
                    {
                        case MasterDataConstants.MDVendorCategory.CONSULTANT:
                            ddlPayToID.SelectedValue = MasterDataConstants.ACMDPaidTo.CONSULTANT.ToString();
                            break;
                        case MasterDataConstants.MDVendorCategory.CONTRACTOR:
                            ddlPayToID.SelectedValue=MasterDataConstants.ACMDPaidTo.CONTRACTOR.ToString();
                            break;
                        case MasterDataConstants.MDVendorCategory.VENDOR:
                            ddlPayToID.SelectedValue = MasterDataConstants.ACMDPaidTo.VENDOR.ToString();
                            break;
                    }
                    BuildReferenceByPayTo();
                }

                #endregion

                #region Detail Info

                ACBankAccountPaymentItem_DetailedEntity acBankAccountPaymentItemEntity = new ACBankAccountPaymentItem_DetailedEntity();

                acBankAccountPaymentItemEntity.BankAccountPaymentItemID = CurrentACBankAccountPaymentItemList.Count + 1;

                acBankAccountPaymentItemEntity.AccountID = PayableAccountID;

                ACAccountEntity aCAccountEntity = FCCACAccount.GetFacadeCreate().GetByID(PayableAccountID);

                acBankAccountPaymentItemEntity.AccountName = aCAccountEntity.AccountName;
                acBankAccountPaymentItemEntity.DimensionID = null;
                acBankAccountPaymentItemEntity.Amount = PayableAmount;
                acBankAccountPaymentItemEntity.Memo = "PV";

                CurrentACBankAccountPaymentItemList.Add(acBankAccountPaymentItemEntity);

                BindACBankAccountPaymentItemList();

                #endregion
            }
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            if (hdEmpID.Value == "0")
            {
                if (txtItemName.Text.Trim().IsNotNullOrEmpty())
                {
                    MiscUtil.ShowMessage(lblMessage, "Invalid Accounts, Please Enter Correct Account Name.", true);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Please Select Correct Account Name.", true);
                }

                validationResult = false;
            }

            return validationResult;
        }

        private void PrepareEditViewPaymentItem()
        {
            ACBankAccountPaymentItem_DetailedEntity aCBankAccountPaymentItemEntity = CurrentACBankAccountPaymentItemEntity;

            if (!aCBankAccountPaymentItemEntity.IsNew)
            {
                if (aCBankAccountPaymentItemEntity.AccountID > 0)
                {
                    txtItemName.Text = aCBankAccountPaymentItemEntity.AccountName.ToString();
                    hdEmpID.Value = aCBankAccountPaymentItemEntity.AccountID.ToString();
                }

                if (ddlItemID.Items.Count > 0 && aCBankAccountPaymentItemEntity.ItemID != null)
                {
                    ddlItemID.SelectedValue = aCBankAccountPaymentItemEntity.ItemID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.ItemID == null)
                {
                    ddlItemID.SelectedValue = "0";
                }
                
                if (ddlProjectID.Items.Count > 0 && aCBankAccountPaymentItemEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = aCBankAccountPaymentItemEntity.ProjectID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.ProjectID == null)
                {
                    ddlProjectID.SelectedValue = "0";
                }

                BuildProjectWiseDropdownInfo();

                if (ddlRequisitionID.Items.Count > 0 && aCBankAccountPaymentItemEntity.RequisitionID != null)
                {
                    ddlRequisitionID.SelectedValue = aCBankAccountPaymentItemEntity.RequisitionID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.RequisitionID == null)
                {
                    ddlRequisitionID.SelectedValue = "0";
                }

                BuildRequisitionWiseInfo();

                if (ddlWorkOrderID.Items.Count > 0 && aCBankAccountPaymentItemEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = aCBankAccountPaymentItemEntity.WorkOrderID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.WorkOrderID == null)
                {
                    ddlWorkOrderID.SelectedValue = "0";
                }

                BuildWorkorderWiseInfo();

                if (ddlBillID.Items.Count > 0 && aCBankAccountPaymentItemEntity.BillID != null)
                {
                    ddlBillID.SelectedValue = aCBankAccountPaymentItemEntity.BillID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.BillID == null)
                {
                    ddlBillID.SelectedValue = "0";
                }

                if (ddlProjectFloorID.Items.Count > 0 && aCBankAccountPaymentItemEntity.ProjectFloorID != null)
                {
                    ddlProjectFloorID.SelectedValue = aCBankAccountPaymentItemEntity.ProjectFloorID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.ProjectFloorID == null)
                {
                    ddlProjectFloorID.SelectedValue = "0";
                }

                BuildFloorWiseInfo();

                if (ddlProjectFloorUnitID.Items.Count > 0 && aCBankAccountPaymentItemEntity.ProjectFloorUnitID != null)
                {
                    ddlProjectFloorUnitID.SelectedValue = aCBankAccountPaymentItemEntity.ProjectFloorUnitID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.ProjectFloorUnitID == null)
                {
                    ddlProjectFloorUnitID.SelectedValue = "0";
                }

                txtAmount.Text = aCBankAccountPaymentItemEntity.Amount.ToString();
                txtMemoDetail.Text = aCBankAccountPaymentItemEntity.Memo.ToString();
            }
        }

        private void EnableDisableApprovalProcessCheck()
        {
            APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.BANK_PAYMENT, _bankAccountPaymentID);

            if (aPApprovalProcessEntity.APApprovalProcessID > 0)
            {
                btnInitiateApprovalProcess.Enabled = false;
            }
            else
            {
                btnInitiateApprovalProcess.Enabled = true;
            }
        }

        private Boolean ValidationInput()
        {
            Boolean flag = true;

            if (CurrentACBankAccountPaymentItemList.Count <= 0)
            {
                flag = false;
                MiscUtil.ShowMessage(lblMessage, "Please Make at least one Bank Account Payment Information.", true);
            }

            return flag;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtPaymentDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtReference.Text = "Auto Assigned";
            txtName.Text = String.Empty;
            txtMemo.Text = String.Empty;

            pnlAdd.Visible = true;
            pnlUpdate.Visible = false;

            CurrentACBankAccountPaymentItemList = new List<ACBankAccountPaymentItem_DetailedEntity>();
        }

        private void BuildReferenceByPayTo()
        {
            if (ddlPayToID != null && ddlPayToID.Items.Count > 0)
            {
                lblReference.Text = ddlPayToID.SelectedItem.ToString() + " :";

                switch (Int64.Parse(ddlPayToID.SelectedValue))
                {
                    case MasterDataConstants.ACMDPaidFrom.MISCELLANEOUS:
                        pnlName.Visible = true;
                        pnlReference.Visible = false;
                        ddlReferenceID.Items.Clear();
                        break;
                    case MasterDataConstants.ACMDPaidFrom.CONTRACTOR:
                        MiscUtil.PopulateCMContractor(ddlReferenceID, false);
                        pnlReference.Visible = true;
                        pnlName.Visible = false;
                        break;
                    case MasterDataConstants.ACMDPaidFrom.CONSULTANT:
                        MiscUtil.PopulateCMConsultant(ddlReferenceID, false);
                        pnlReference.Visible = true;
                        pnlName.Visible = false;
                        break;
                    case MasterDataConstants.ACMDPaidFrom.VENDOR:
                        MiscUtil.PopulatePRMSupplier(ddlReferenceID, false);
                        pnlReference.Visible = true;
                        pnlName.Visible = false;
                        break;
                    case MasterDataConstants.ACMDPaidFrom.CUSTOMER:
                        MiscUtil.PopulateCRMCustomer(ddlReferenceID, false);
                        pnlReference.Visible = true;
                        pnlName.Visible = false;
                        break;
                }
            }
        }

        private void PrepareEditView()
        {
            ACBankAccountPaymentEntity aCBankAccountPaymentEntity = CurrentACBankAccountPaymentEntity;

            if (!aCBankAccountPaymentEntity.IsNew)
            {
                txtPaymentDate.Text = aCBankAccountPaymentEntity.PaymentDate.ToStringDefault();

                if (ddlPayToID.Items.Count > 0 && aCBankAccountPaymentEntity.PayToID != null)
                {
                    ddlPayToID.SelectedValue = aCBankAccountPaymentEntity.PayToID.ToString();
                }

                if (ddlBankAccountID.Items.Count > 0 && aCBankAccountPaymentEntity.BankAccountID != null)
                {
                    ddlBankAccountID.SelectedValue = aCBankAccountPaymentEntity.BankAccountID.ToString();
                }

                txtReference.Text = aCBankAccountPaymentEntity.Reference.ToString();
                txtName.Text = aCBankAccountPaymentEntity.Name.ToString();
                txtMemoDetail.Text = aCBankAccountPaymentEntity.Memo.ToString();
            }
        }

        private void BindList()
        {
            BindACBankAccountPaymentList();
        }

        private void BindACBankAccountPaymentList()
        {
           
        }

        private void BuildTotalValueLabel()
        {
            Decimal totalValue = (from s in CurrentACBankAccountPaymentItemList
                                  select s.Amount).Sum();

            lblTotalValue.Text = MiscUtil.NumericCommaSeperatedFormat(totalValue);

            if (totalValue == 0)
            {
                dvTotalValue.Visible = false;
            }
            if(totalValue>0)
            {
                dvTotalValue.Visible = true;
            }
        }

        private void BindACBankAccountPaymentItemList()
        {   
            lvACBankAccountPaymentItem.DataSource = CurrentACBankAccountPaymentItemList;
            lvACBankAccountPaymentItem.DataBind();
        }

        private ACBankAccountPaymentEntity BuildACBankAccountPaymentEntity()
        {
            ACBankAccountPaymentEntity aCBankAccountPaymentEntity = CurrentACBankAccountPaymentEntity;

            if (txtPaymentDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCBankAccountPaymentEntity.PaymentDate = MiscUtil.ParseToDateTime(txtPaymentDate.Text);
            }

            if (ddlPayToID.Items.Count > 0)
            {
                if (ddlPayToID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountPaymentEntity.PayToID = Int64.Parse(ddlPayToID.SelectedValue);
                }
            }

            if (ddlBankAccountID.Items.Count > 0)
            {
                if (ddlBankAccountID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountPaymentEntity.BankAccountID = Int64.Parse(ddlBankAccountID.SelectedValue);
                }
            }

            aCBankAccountPaymentEntity.BankAccountPaymentApprovalStatusID = MasterDataConstants.ACMDBankAccountPaymentApprovalStatus.INITIATED;
            aCBankAccountPaymentEntity.Reference = txtReference.Text.Trim();
            aCBankAccountPaymentEntity.Name = txtName.Text.Trim();
            aCBankAccountPaymentEntity.Memo = txtMemo.Text.Trim();
            aCBankAccountPaymentEntity.PreparedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            return aCBankAccountPaymentEntity;
        }

        private void SaveACBankAccountPaymentEntity()
        {
            
                if (IsValid)
                {
                    try
                    {
                        ACBankAccountPaymentEntity aCBankAccountPaymentEntity = BuildACBankAccountPaymentEntity();

                        Int64 result = -1;

                        if (aCBankAccountPaymentEntity.IsNew)
                        {
                            result = FCCACBankAccountPayment.GetFacadeCreate().Add(aCBankAccountPaymentEntity, DatabaseOperationType.Add, TransactionRequired.No);

                            if (PayablePostPayableDetailID > 0 && PayableBankAccountID > 0)
                            {

                                ACBankAccountPaymentPostPayableStatementDetailMapEntity aCBankAccountPaymentPostPayableStatementDetailMapEntity = new ACBankAccountPaymentPostPayableStatementDetailMapEntity();

                                aCBankAccountPaymentPostPayableStatementDetailMapEntity.BankAccountPaymentID = aCBankAccountPaymentEntity.BankAccountID;
                                aCBankAccountPaymentPostPayableStatementDetailMapEntity.PostPayableStatementDetailID = PayablePostPayableDetailID;
                                aCBankAccountPaymentPostPayableStatementDetailMapEntity.Remarks = "Purchase Voucher";

                                FCCACBankAccountPaymentPostPayableStatementDetailMap.GetFacadeCreate().Add(aCBankAccountPaymentPostPayableStatementDetailMapEntity, DatabaseOperationType.Add, TransactionRequired.No);

                                ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity = FCCACCPostPayableStatementDetail.GetFacadeCreate().GetByID(PayablePostPayableDetailID);

                                if (aCCPostPayableStatementDetailEntity != null && aCCPostPayableStatementDetailEntity.PostPayableStatementDetailID > 0)
                                {
                                    String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementDetailID, PayablePostPayableDetailID.ToString(), SQLMatchType.Equal);
                                    aCCPostPayableStatementDetailEntity.IsLocked = true;

                                    FCCACCPostPayableStatementDetail.GetFacadeCreate().Update(aCCPostPayableStatementDetailEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);
                                }
                            }
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountPaymentEntity.FLD_NAME_BankAccountPaymentID, aCBankAccountPaymentEntity.BankAccountPaymentID.ToString(), SQLMatchType.Equal);
                            result = FCCACBankAccountPayment.GetFacadeCreate().Update(aCBankAccountPaymentEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        }

                        if (result > 0)
                        {
                            Int64 resut_two = -1;

                            if (!aCBankAccountPaymentEntity.IsNew)
                            {
                                CurrentACBankAccountPaymentItemList = new List<ACBankAccountPaymentItem_DetailedEntity>();

                                ACBankAccountPaymentItem_DetailedEntity aCBankAccountDepositItemEntity = new ACBankAccountPaymentItem_DetailedEntity();

                                IList<ListViewDataItem> listBankDeposit = lvACBankAccountPaymentItem.Items;

                                if (listBankDeposit != null && listBankDeposit.Count > 0)
                                {

                                    String fe_del = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountPaymentItemEntity.FLD_NAME_BankAccountPaymentID, result.ToString(), SQLMatchType.Equal);
                                    ACBankAccountPaymentItemEntity acDopsitItem = new ACBankAccountPaymentItemEntity();

                                    FCCACBankAccountPaymentItem.GetFacadeCreate().Delete(acDopsitItem, fe_del, DatabaseOperationType.Delete, TransactionRequired.No);

                                    foreach (ListViewDataItem lvdi in listBankDeposit)
                                    {

                                        aCBankAccountDepositItemEntity = new ACBankAccountPaymentItem_DetailedEntity();

                                        Label lblAccountIDLV = (Label)lvdi.FindControl("lblAccountIDLV");
                                        Label lblAccountNameLV = (Label)lvdi.FindControl("lblAccountNameLV");
                                        Label lblAmountLV = (Label)lvdi.FindControl("lblAmountLV");
                                        Label lblMemoLV = (Label)lvdi.FindControl("lblMemoLV");
                                   

                                        aCBankAccountDepositItemEntity.BankAccountPaymentItemID = CurrentACBankAccountPaymentItemList.Count + 1;

                                        if (lblAccountIDLV.Text.Trim().IsNotNullOrEmpty())
                                        {
                                            aCBankAccountDepositItemEntity.AccountID = Int64.Parse(lblAccountIDLV.Text.Trim());
                                            aCBankAccountDepositItemEntity.AccountName = lblAccountNameLV.Text.ToString().Trim();
                                        }

                                        if (!lblAmountLV.Text.Trim().IsNullOrEmpty())
                                        {
                                            aCBankAccountDepositItemEntity.Amount = Decimal.Parse(lblAmountLV.Text.Trim());
                                        }

                                        aCBankAccountDepositItemEntity.Memo = lblMemoLV.Text.Trim();

                                        #region Update Value

                                        ACBankAccountPaymentItemEntity acBankAccountPaymentItemEntity = new ACBankAccountPaymentItemEntity();
                                        acBankAccountPaymentItemEntity.AccountID = aCBankAccountDepositItemEntity.AccountID;
                                        acBankAccountPaymentItemEntity.DimensionID = aCBankAccountDepositItemEntity.DimensionID;
                                        acBankAccountPaymentItemEntity.Amount = aCBankAccountDepositItemEntity.Amount;
                                        acBankAccountPaymentItemEntity.Memo = aCBankAccountDepositItemEntity.Memo;
                                        acBankAccountPaymentItemEntity.ItemID = aCBankAccountDepositItemEntity.ItemID;
                                        acBankAccountPaymentItemEntity.RequisitionID = aCBankAccountDepositItemEntity.RequisitionID;
                                        acBankAccountPaymentItemEntity.WorkOrderID = aCBankAccountDepositItemEntity.WorkOrderID;
                                        acBankAccountPaymentItemEntity.BillID = aCBankAccountDepositItemEntity.BillID;
                                        acBankAccountPaymentItemEntity.ProjectID = aCBankAccountDepositItemEntity.ProjectID;
                                        acBankAccountPaymentItemEntity.ProjectFloorID = aCBankAccountDepositItemEntity.ProjectFloorID;
                                        acBankAccountPaymentItemEntity.ProjectFloorUnitID = aCBankAccountDepositItemEntity.ProjectFloorUnitID;
                                        acBankAccountPaymentItemEntity.BankAccountPaymentID = result;

                                        resut_two = FCCACBankAccountPaymentItem.GetFacadeCreate().Add(acBankAccountPaymentItemEntity, DatabaseOperationType.Add, TransactionRequired.No);

                                        #endregion

                                        CurrentACBankAccountPaymentItemList.Add(aCBankAccountDepositItemEntity);
                                    }

                                    BindACBankAccountPaymentItemList();
                                    BuildTotalValueLabel();
                                }
                            }

                            if (aCBankAccountPaymentEntity.IsNew)
                            {
                                if (CurrentACBankAccountPaymentItemList != null && CurrentACBankAccountPaymentItemList.Count > 0)
                                {
                                    foreach (ACBankAccountPaymentItem_DetailedEntity ent in CurrentACBankAccountPaymentItemList)
                                    {
                                        ACBankAccountPaymentItemEntity acBankAccountPaymentItemEntity = new ACBankAccountPaymentItemEntity();
                                        acBankAccountPaymentItemEntity.AccountID = ent.AccountID;
                                        acBankAccountPaymentItemEntity.DimensionID = ent.DimensionID;
                                        acBankAccountPaymentItemEntity.ItemID = ent.ItemID;
                                        acBankAccountPaymentItemEntity.RequisitionID = ent.RequisitionID;
                                        acBankAccountPaymentItemEntity.WorkOrderID = ent.WorkOrderID;
                                        acBankAccountPaymentItemEntity.BillID = ent.BillID;
                                        acBankAccountPaymentItemEntity.ProjectID = ent.ProjectID;
                                        acBankAccountPaymentItemEntity.ProjectFloorID = ent.ProjectFloorID;
                                        acBankAccountPaymentItemEntity.ProjectFloorUnitID = ent.ProjectFloorUnitID;
                                        acBankAccountPaymentItemEntity.Amount = ent.Amount;
                                        acBankAccountPaymentItemEntity.Memo = ent.Memo;
                                        acBankAccountPaymentItemEntity.BankAccountPaymentID = result;

                                        resut_two = FCCACBankAccountPaymentItem.GetFacadeCreate().Add(acBankAccountPaymentItemEntity, DatabaseOperationType.Add, TransactionRequired.No);
                                    }
                                }
                            }

                            hypReportLink.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.BANK_ACCOUNT_PAYMENT_REPORT, UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID, result.ToString()).ToString();
                            hypReportLink.Target = "_blank";
                            hypReportLink.Visible = true;


                            String str = (String)ViewState["Action"].ToString();

                            if (str == "GenerateReport")
                            {
                                _BankAccountPaymentID = result;
                                _bankAccountPaymentID = result;
                                PrepareEditView();
                            }

                            else if (str == "Approval")
                            {
                                _BankAccountPaymentID = 0;
                                _bankAccountPaymentID = result;
                                _ACBankAccountPaymentEntity = new ACBankAccountPaymentEntity();
                                PrepareInitialView();
                                PrepareInitialViewPaymentItem();
                                CurrentACBankAccountPaymentItemList = new List<ACBankAccountPaymentItem_DetailedEntity>();
                                BindACBankAccountPaymentItemList();
                                BuildTotalValueLabel();
                            }
                          
                            //_ACBankAccountPaymentEntity = new ACBankAccountPaymentEntity();
                            //PrepareInitialView();
                            //BindACBankAccountPaymentList();
                            //PrepareInitialViewPaymentItem();
                            ////CurrentACBankAccountPaymentItemList = new List<ACBankAccountPaymentItem_DetailedEntity>();
                            //BindACBankAccountPaymentItemList();
                            //BuildTotalValueLabel();

                            if (aCBankAccountPaymentEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Bank Account Payment Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Bank Account Payment Information has been updated successfully.", false);
                            }
                        }
                        else
                        {
                            if (aCBankAccountPaymentEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Bank Account Payment Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Bank Account Payment Information.", false);
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
                PrepareInitialViewPaymentItem();
                PreparePayableView();
            }
        }

        #endregion

        #region List View Event

        protected void lvACBankAccountPaymentItem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BankAccountPaymentItemID;

            Int64.TryParse(e.CommandArgument.ToString(), out BankAccountPaymentItemID);

            if (BankAccountPaymentItemID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BankAccountPaymentItemID = BankAccountPaymentItemID;

                    PrepareEditViewPaymentItem();
                    pnlAdd.Visible = false;
                    pnlUpdate.Visible = true;
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {  

                        ACBankAccountPaymentItem_DetailedEntity paymentItemEntity = (from s in CurrentACBankAccountPaymentItemList
                                                                                      where s.BankAccountPaymentItemID == BankAccountPaymentItemID
                                                                                      select s).FirstOrDefault();

                        CurrentACBankAccountPaymentItemList.Remove(paymentItemEntity);

                        BindACBankAccountPaymentItemList();

                        BuildTotalValueLabel();
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region Button Event

        protected void btnSaveAndGenerateReport_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                ViewState["Action"] = "GenerateReport";

                #region Save Initailly

                SaveACBankAccountPaymentEntity();

                #endregion
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BankAccountPaymentID = 0;
            _ACBankAccountPaymentEntity = new ACBankAccountPaymentEntity();
            PrepareInitialView();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            CurrentACBankAccountPaymentItemEntity = new ACBankAccountPaymentItem_DetailedEntity();

            ClearAll();

            pnlUpdate.Visible = false;
            pnlAdd.Visible = true;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
            ClearAll();
        }

        protected void btnInitiateApprovalProcess_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                ViewState["Action"] = "Approval";

                #region Save Initailly

                if (_bankAccountPaymentID <= 0)
                {
                    SaveACBankAccountPaymentEntity();
                }

                #endregion

                #region Approval Process

                Boolean apResult = APRobot.CreateApprovalProcessForNewBankPayment(_bankAccountPaymentID, Int64.Parse(ddlAPPanelID.SelectedValue));

                if (apResult == true)
                {
                    MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                    //String NavigationUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisitionList.aspx", string.Empty).ToString();
                    //Response.Redirect(NavigationUrl);
                    _bankAccountPaymentID = 0;
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                }

                EnableDisableApprovalProcessCheck();

                #endregion
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                ACBankAccountPaymentItem_DetailedEntity cust = (from c in CurrentACBankAccountPaymentItemList
                                                                where c.BankAccountPaymentItemID == CurrentACBankAccountPaymentItemEntity.BankAccountPaymentItemID
                                                                select c).SingleOrDefault();

                CurrentACBankAccountPaymentItemList.Remove(cust);

                ACBankAccountPaymentItem_DetailedEntity aCBankAccountPaymentItemEntity = cust;

                if (hdEmpID.Value != "0")
                {
                    aCBankAccountPaymentItemEntity.AccountID = Int64.Parse(hdEmpID.Value);
                    aCBankAccountPaymentItemEntity.AccountName = txtItemName.Text.ToString().Trim();
                }

                if (ddlItemID.Items.Count > 0)
                {
                    if (ddlItemID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.ItemID = null;
                        aCBankAccountPaymentItemEntity.ItemName = String.Empty;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                        aCBankAccountPaymentItemEntity.ItemName = ddlItemID.SelectedItem.ToString();
                    }
                }

                if (ddlRequisitionID.Items.Count > 0)
                {
                    if (ddlRequisitionID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.RequisitionID = null;
                        aCBankAccountPaymentItemEntity.RequisitionNo = String.Empty;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                        aCBankAccountPaymentItemEntity.RequisitionNo = ddlRequisitionID.SelectedItem.ToString();
                    }
                }


                if (ddlWorkOrderID.Items.Count > 0)
                {
                    if (ddlWorkOrderID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.WorkOrderID = null;
                        aCBankAccountPaymentItemEntity.WorkOrderNo = String.Empty;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                        aCBankAccountPaymentItemEntity.WorkOrderNo = ddlWorkOrderID.SelectedItem.ToString();
                    }
                }

                if (ddlBillID.Items.Count > 0)
                {
                    if (ddlBillID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.BillID = null;
                        aCBankAccountPaymentItemEntity.BillNo = String.Empty;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                        aCBankAccountPaymentItemEntity.BillNo = ddlBillID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.ProjectID = null;
                        aCBankAccountPaymentItemEntity.ProjectName = String.Empty;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                        aCBankAccountPaymentItemEntity.ProjectName = ddlProjectID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectFloorID.Items.Count > 0)
                {
                    if (ddlProjectFloorID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.ProjectFloorID = null;
                        aCBankAccountPaymentItemEntity.ProjectFloorName = String.Empty;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                        aCBankAccountPaymentItemEntity.ProjectFloorName = ddlProjectFloorID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectFloorUnitID.Items.Count > 0)
                {
                    if (ddlProjectFloorUnitID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.ProjectFloorUnitID = null;
                        aCBankAccountPaymentItemEntity.ProjectFloorUnitName = String.Empty;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                        aCBankAccountPaymentItemEntity.ProjectFloorUnitName = ddlProjectFloorUnitID.SelectedItem.ToString();
                    }
                }

                if (!txtAmount.Text.Trim().IsNullOrEmpty())
                {
                    aCBankAccountPaymentItemEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
                }

                aCBankAccountPaymentItemEntity.Memo = txtMemoDetail.Text.Trim();

                CurrentACBankAccountPaymentItemList.Add(aCBankAccountPaymentItemEntity);

                BindACBankAccountPaymentItemList();

                pnlAdd.Visible = true;
                pnlUpdate.Visible = false;

                ClearAll();
                BuildTotalValueLabel();
            }
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                ACBankAccountPaymentItem_DetailedEntity acBankAccountPaymentItemEntity = new ACBankAccountPaymentItem_DetailedEntity();

                acBankAccountPaymentItemEntity.BankAccountPaymentItemID = CurrentACBankAccountPaymentItemList.Count + 1;

                if (hdEmpID.Value != "0")
                {
                    acBankAccountPaymentItemEntity.AccountID = Int64.Parse(hdEmpID.Value);
                    acBankAccountPaymentItemEntity.AccountName = txtItemName.Text.ToString().Trim();
                }

                if (ddlItemID.Items.Count > 0)
                {
                    if (ddlItemID.SelectedValue == "0")
                    {
                        acBankAccountPaymentItemEntity.ItemID = null;
                    }
                    else
                    {
                        acBankAccountPaymentItemEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                        acBankAccountPaymentItemEntity.ItemName = ddlItemID.SelectedItem.ToString();
                    }
                }

                if (ddlRequisitionID.Items.Count > 0)
                {
                    if (ddlRequisitionID.SelectedValue == "0")
                    {
                        acBankAccountPaymentItemEntity.RequisitionID = null;
                    }
                    else
                    {
                        acBankAccountPaymentItemEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                        acBankAccountPaymentItemEntity.RequisitionNo = ddlRequisitionID.SelectedItem.ToString();
                    }
                }

                if (ddlWorkOrderID.Items.Count > 0)
                {
                    if (ddlWorkOrderID.SelectedValue == "0")
                    {
                        acBankAccountPaymentItemEntity.WorkOrderID = null;
                    }
                    else
                    {
                        acBankAccountPaymentItemEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                        acBankAccountPaymentItemEntity.WorkOrderNo = ddlWorkOrderID.SelectedItem.ToString();
                    }
                }

                if (ddlBillID.Items.Count > 0)
                {
                    if (ddlBillID.SelectedValue == "0")
                    {
                        acBankAccountPaymentItemEntity.BillID = null;
                    }
                    else
                    {
                        acBankAccountPaymentItemEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                        acBankAccountPaymentItemEntity.BillNo = ddlBillID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                        acBankAccountPaymentItemEntity.ProjectID = null;
                    }
                    else
                    {
                        acBankAccountPaymentItemEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                        acBankAccountPaymentItemEntity.ProjectName = ddlProjectID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectFloorID.Items.Count > 0)
                {
                    if (ddlProjectFloorID.SelectedValue == "0")
                    {
                        acBankAccountPaymentItemEntity.ProjectFloorID = null;
                    }
                    else
                    {
                        acBankAccountPaymentItemEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                        acBankAccountPaymentItemEntity.ProjectFloorName = ddlProjectFloorID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectFloorUnitID.Items.Count > 0)
                {
                    if (ddlProjectFloorUnitID.SelectedValue == "0")
                    {
                        acBankAccountPaymentItemEntity.ProjectFloorUnitID = null;
                    }
                    else
                    {
                        acBankAccountPaymentItemEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                        acBankAccountPaymentItemEntity.ProjectFloorUnitName = ddlProjectFloorUnitID.SelectedItem.ToString();
                    }
                }

                if (!txtAmount.Text.Trim().IsNullOrEmpty())
                {
                    acBankAccountPaymentItemEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
                }

                acBankAccountPaymentItemEntity.Memo = txtMemoDetail.Text.Trim();

                CurrentACBankAccountPaymentItemList.Add(acBankAccountPaymentItemEntity);

                BindACBankAccountPaymentItemList();

                ClearAll();
                BuildTotalValueLabel();
            }
        }

        private void ClearAll()
        {
            txtAmount.Text = String.Empty;
            txtMemoDetail.Text = String.Empty;
            txtItemName.Text = String.Empty;

            //if (ddlProjectID.Items.Count > 0)
            //{
            //    ddlProjectID.SelectedValue = "0";
            //    BuildProjectWiseDropdownInfo();
            //}

            //if (ddlItemID.Items.Count > 0)
            //{
            //    ddlItemID.SelectedValue = "0";
            //}

            hdEmpID.Value = "0";
        }

        #endregion

        #region DropDownList Event

        protected void ddlPayToID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildReferenceByPayTo();
        }

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildProjectWiseDropdownInfo();
        }

        protected void ddlRequisitionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildRequisitionWiseInfo();    
        }

        protected void ddlWorkOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildWorkorderWiseInfo();
        }

        protected void ddlProjectFloorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildFloorWiseInfo();
        }

        #endregion

        #endregion Event
    }
}
