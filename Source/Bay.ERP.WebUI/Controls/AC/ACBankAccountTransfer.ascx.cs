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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class ACBankAccountTransferControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountTransferID
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

        public ACBankAccountTransferEntity _ACBankAccountTransferEntity
        {
            get
            {
                ACBankAccountTransferEntity entity = new ACBankAccountTransferEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACBankAccountTransferEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACBankAccountTransferEntity CurrentACBankAccountTransferEntity
        {
            get
            {
                if (_BankAccountTransferID > 0)
                {
                    if (_ACBankAccountTransferEntity.BankAccountTransferID != _BankAccountTransferID)
                    {
                        _ACBankAccountTransferEntity = FCCACBankAccountTransfer.GetFacadeCreate().GetByID(_BankAccountTransferID);
                    }
                }

                return _ACBankAccountTransferEntity;
            }
            set
            {
                _ACBankAccountTransferEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACBankAccount(ddlFromBankAccountID, false);
            MiscUtil.PopulateACBankAccount(ddlToBankAccountID, false);
            MiscUtil.PopulateStartWithAPPanel(ddlAPPanelID, false,MasterDataConstants.APPanelStartWith.ACCOUNTS);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtTransferDate.Text = String.Empty;
            txtAmount.Text = String.Empty;
            txtBankCharge.Text = String.Empty;
            txtMemo.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Save & Submit For Approval";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACBankAccountTransferEntity aCBankAccountTransferEntity = CurrentACBankAccountTransferEntity;


            if (!aCBankAccountTransferEntity.IsNew)
            {
                if (ddlFromBankAccountID.Items.Count > 0 && aCBankAccountTransferEntity.FromBankAccountID != null)
                {
                    ddlFromBankAccountID.SelectedValue = aCBankAccountTransferEntity.FromBankAccountID.ToString();
                }

                if (ddlToBankAccountID.Items.Count > 0 && aCBankAccountTransferEntity.ToBankAccountID != null)
                {
                    ddlToBankAccountID.SelectedValue = aCBankAccountTransferEntity.ToBankAccountID.ToString();
                }

                txtTransferDate.Text = aCBankAccountTransferEntity.TransferDate.ToStringDefault();
                txtAmount.Text = aCBankAccountTransferEntity.Amount.ToString();
                txtBankCharge.Text = aCBankAccountTransferEntity.BankCharge.ToString();
                txtMemo.Text = aCBankAccountTransferEntity.Memo.ToString();
                txtRemarks.Text = aCBankAccountTransferEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACBankAccountTransferList();
        }

        private void BindACBankAccountTransferList()
        {
            lvACBankAccountTransfer.DataBind();
        }

        private ACBankAccountTransferEntity BuildACBankAccountTransferEntity()
        {
            ACBankAccountTransferEntity aCBankAccountTransferEntity = CurrentACBankAccountTransferEntity;

            if (ddlFromBankAccountID.Items.Count > 0)
            {
                if (ddlFromBankAccountID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountTransferEntity.FromBankAccountID = Int64.Parse(ddlFromBankAccountID.SelectedValue);
                }
            }

            if (ddlToBankAccountID.Items.Count > 0)
            {
                if (ddlToBankAccountID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountTransferEntity.ToBankAccountID = Int64.Parse(ddlToBankAccountID.SelectedValue);
                }
            }

            if (txtTransferDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCBankAccountTransferEntity.TransferDate = MiscUtil.ParseToDateTime(txtTransferDate.Text);
            }

            if (!txtAmount.Text.Trim().IsNullOrEmpty())
            {
                aCBankAccountTransferEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
            }

            if (!txtBankCharge.Text.Trim().IsNullOrEmpty())
            {
                aCBankAccountTransferEntity.BankCharge = Decimal.Parse(txtBankCharge.Text.Trim());
            }
            else
            {
                aCBankAccountTransferEntity.BankCharge = null;
            }

            aCBankAccountTransferEntity.BankAccountTransferApprovalStatusID = MasterDataConstants.ACMDBankAccountTransferApprovalStatus.INITIATED;

            aCBankAccountTransferEntity.Memo = txtMemo.Text.Trim();
            aCBankAccountTransferEntity.Remarks = txtRemarks.Text.Trim();
            aCBankAccountTransferEntity.CreatedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            return aCBankAccountTransferEntity;
        }

        private void SaveACBankAccountTransferEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACBankAccountTransferEntity aCBankAccountTransferEntity = BuildACBankAccountTransferEntity();

                    Int64 result = -1;

                    if (aCBankAccountTransferEntity.IsNew)
                    {
                        result = FCCACBankAccountTransfer.GetFacadeCreate().Add(aCBankAccountTransferEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountTransferEntity.FLD_NAME_BankAccountTransferID, aCBankAccountTransferEntity.BankAccountTransferID.ToString(), SQLMatchType.Equal);
                        result = FCCACBankAccountTransfer.GetFacadeCreate().Update(aCBankAccountTransferEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        #region Approval Process

                        Boolean apResult = APRobot.CreateApprovalProcessForNewBankAccountTransfer(result, Int64.Parse(ddlAPPanelID.SelectedValue));

                        if (apResult == true)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                        }

                        #endregion


                        //try
                        //{
                        //    #region Journal Entry

                        //    //Bank To Bank Tranfer amount 
                        //    //Normal Trnasaction without Charge
                        //    //===================================
                        //    //    From Current amount to pretty cash
                        //    //    Current Accont (-) Credit
                        //    //    Petty Cash Account(+) Debit
                        //    //====================================

                        //    //Transaction with Charge
                        //    //===================================
                        //    //    From Current amount to pretty cash
                        //    //    sum of amount transfer + Charge	Current Accont (-) Credit
                        //    //    Petty Cash Account(+) Debit
                        //    //    Charge also (+) Debit but different account Head {Interest and Bank Charges}

                        //    ACBankAccountTransferEntity acBankAccountTransferEntity = FCCACBankAccountTransfer.GetFacadeCreate().GetByID(result);

                        //    if (acBankAccountTransferEntity != null && acBankAccountTransferEntity.BankAccountTransferID > 0)
                        //    {
                        //        Decimal amount, charge, totalAmount;
                        //        Decimal.TryParse(acBankAccountTransferEntity.Amount.ToString(), out amount);
                        //        Decimal.TryParse(acBankAccountTransferEntity.BankCharge.ToString(), out charge);

                        //        totalAmount = amount + charge;

                        //        if (amount > 0)
                        //        {
                        //            #region From Account(Credit Entry)

                        //            ACJournalEntity acJournalEntity = new ACJournalEntity();


                        //            String fe_account = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccount." + ACAccountsHelper_CustomEntity.FLD_NAME_BankAccountID, acBankAccountTransferEntity.FromBankAccountID.ToString(), SQLMatchType.Equal);
                        //            IList<ACAccountsHelper_CustomEntity> lst = FCCACAccountsHelper_Custom.GetFacadeCreate().GetIL(1000, 1, fe_account);

                        //            if (lst != null && lst.Count > 0)
                        //            {
                        //                acJournalEntity.AccountID = lst[0].AccountID;
                        //                acJournalEntity.AccountGroupID = lst[0].AccountGroupID;
                        //                acJournalEntity.ClassID = lst[0].ClassID;
                        //                acJournalEntity.ClassTypeID = lst[0].ClassTypeID;
                        //            }

                        //            String fe_fiscalYear = SqlExpressionBuilder.PrepareFilterExpression(ACFiscalYearEntity.FLD_NAME_IsClosed, "0", SQLMatchType.Equal);
                        //            IList<ACFiscalYearEntity> lstFiscalYear = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, String.Empty, fe_fiscalYear, DatabaseOperationType.LoadWithFilterExpression);

                        //            if (lstFiscalYear != null && lstFiscalYear.Count > 0)
                        //            {
                        //                acJournalEntity.FiscalYearID = lstFiscalYear[0].FiscalYearID;
                        //            }

                        //            acJournalEntity.TransactionDateTime = acBankAccountTransferEntity.TransferDate;
                        //            acJournalEntity.Amount = totalAmount;
                        //            acJournalEntity.EnteredByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                        //            acJournalEntity.ReferenceOrMemoOrID = acBankAccountTransferEntity.Memo;
                        //            acJournalEntity.Note = acBankAccountTransferEntity.Remarks;
                        //            acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.CREDIT;
                        //            acJournalEntity.DimensionID = null;
                        //            acJournalEntity.ProjectID = null;
                        //            acJournalEntity.IsReverseTransaction = false;

                        //            FCCACJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);

                        //            #endregion

                        //            #region To Account(Debit Entry)

                        //            String fe_TobankAccount = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccount." + ACAccountsHelper_CustomEntity.FLD_NAME_BankAccountID, acBankAccountTransferEntity.ToBankAccountID.ToString(), SQLMatchType.Equal);
                        //            IList<ACAccountsHelper_CustomEntity> lstTobankAccount = FCCACAccountsHelper_Custom.GetFacadeCreate().GetIL(10000, 1, fe_TobankAccount);

                        //            if (lstTobankAccount != null && lstTobankAccount.Count > 0)
                        //            {
                        //                acJournalEntity.AccountID = lstTobankAccount[0].AccountID;
                        //                acJournalEntity.AccountGroupID = lstTobankAccount[0].AccountGroupID;
                        //                acJournalEntity.ClassID = lstTobankAccount[0].ClassID;
                        //                acJournalEntity.ClassTypeID = lstTobankAccount[0].ClassTypeID;
                        //            }

                        //            acJournalEntity.TransactionDateTime = acBankAccountTransferEntity.TransferDate;
                        //            acJournalEntity.Amount = amount;
                        //            acJournalEntity.EnteredByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                        //            acJournalEntity.ReferenceOrMemoOrID = acBankAccountTransferEntity.Memo;
                        //            acJournalEntity.Note = acBankAccountTransferEntity.Remarks;
                        //            acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.DEBIT;
                        //            acJournalEntity.DimensionID = null;
                        //            acJournalEntity.ProjectID = null;
                        //            acJournalEntity.IsReverseTransaction = false;

                        //            FCCACJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);

                        //            if (charge > 0)
                        //            {
                        //                acJournalEntity.Amount = charge;
                        //                acJournalEntity.AccountID = 23;//Should Change Here For Intrest and Loan

                        //                String fe_ChargeAccount = SqlExpressionBuilder.PrepareFilterExpression("ACAccount." + ACAccountsHelper_CustomEntity.FLD_NAME_AccountID, "23".ToString(), SQLMatchType.Equal);
                        //                IList<ACAccountsHelper_CustomEntity> lstChargeAccount = FCCACAccountsHelper_Custom.GetFacadeCreate().GetIL(10000, 1, fe_ChargeAccount);

                        //                if (lstTobankAccount != null && lstTobankAccount.Count > 0)
                        //                {
                        //                    acJournalEntity.AccountID = 23;
                        //                    acJournalEntity.AccountGroupID = lstChargeAccount[0].AccountGroupID;
                        //                    acJournalEntity.ClassID = lstChargeAccount[0].ClassID;
                        //                    acJournalEntity.ClassTypeID = lstChargeAccount[0].ClassTypeID;
                        //                }
                        //                acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.DEBIT;
                        //                FCCACJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        //            }

                        //            #endregion

                        //            acJournalEntity = new ACJournalEntity();
                        //        }
                        //    }

                        //    #endregion
                        //}
                        //catch (Exception ex)
                        //{
                        //    MiscUtil.ShowMessage(lblMessage, "Some Error Occured To Save in Journal Entry", true);
                        //}

                        _BankAccountTransferID = 0;
                        _ACBankAccountTransferEntity = new ACBankAccountTransferEntity();
                        PrepareInitialView();
                        BindACBankAccountTransferList();

                        if (aCBankAccountTransferEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Bank Account Transfer Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Bank Account Transfer Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCBankAccountTransferEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Bank Account Transfer Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Bank Account Transfer Information.", false);
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
            btnSubmit.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnSubmit, "").ToString());

            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvACBankAccountTransfer_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BankAccountTransferID;

            Int64.TryParse(e.CommandArgument.ToString(), out BankAccountTransferID);

            if (BankAccountTransferID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BankAccountTransferID = BankAccountTransferID;

                    PrepareEditView();

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountTransferEntity.FLD_NAME_BankAccountTransferID, BankAccountTransferID.ToString(), SQLMatchType.Equal);

                        ACBankAccountTransferEntity aCBankAccountTransferEntity = new ACBankAccountTransferEntity();


                        result = FCCACBankAccountTransfer.GetFacadeCreate().Delete(aCBankAccountTransferEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BankAccountTransferID = 0;
                            _ACBankAccountTransferEntity = new ACBankAccountTransferEntity();
                            PrepareInitialView();
                            BindACBankAccountTransferList();

                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Transfer has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CBank Account Transfer.", true);
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

        protected void odsACBankAccountTransfer_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACBankAccountTransferEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BankAccountTransferID = 0;
            _ACBankAccountTransferEntity = new ACBankAccountTransferEntity();
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
