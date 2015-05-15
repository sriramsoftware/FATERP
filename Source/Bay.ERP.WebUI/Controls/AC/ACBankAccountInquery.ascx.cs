// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




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
    public partial class ACBankAccountInqueryControl : BaseControl
    {       
        #region Properties

        public Int64 _JournalID
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

        public ACJournalEntity _ACJournalEntity
        {
            get
            {
                ACJournalEntity entity = new ACJournalEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACJournalEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACJournalEntity CurrentACJournalEntity
        {
            get
            {
                if (_JournalID > 0)
                {
                    if (_ACJournalEntity.JournalID != _JournalID)
                    {
                        _ACJournalEntity = FCCACJournal.GetFacadeCreate().GetByID(_JournalID);
                    }
                }

                return _ACJournalEntity;
            }
            set
            {
                _ACJournalEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACBankAccount(ddlBankAccountID, false);
        }

        private void PrepareValidator()
        {
        }

        private String MergeAllString()
        {
            String fe = String.Empty;

            if (ddlBankAccountID.Items.Count > 0)
            {
                String fe_account = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccount." + ACAccountsHelper_CustomEntity.FLD_NAME_BankAccountID, ddlBankAccountID.SelectedValue.ToString(), SQLMatchType.Equal);
                IList<ACAccountsHelper_CustomEntity> lst = FCCACAccountsHelper_Custom.GetFacadeCreate().GetIL(1000, 1, fe_account);

                if (lst != null && lst.Count > 0)
                {
                    fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankStatement_CustomEntity.FLD_NAME_AccountID, lst[0].AccountID.ToString(), SQLMatchType.Equal);
                }
            }

            if(!String.IsNullOrWhiteSpace(txtTransactionFromDate.Text.Trim()))
            {
                if(!String.IsNullOrWhiteSpace(txtTransactionToDate.Text.Trim())){
                    String fe1="TransactionDateTime between '"+MiscUtil.ParseToDateTime(txtTransactionFromDate.Text) + "' and '" + MiscUtil.ParseToDateTime(txtTransactionToDate.Text)+"'";
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
                }
            }

            Int64 activeFiscalYearID = MiscUtil.GetActiveFiscalYear();

            //if (activeFiscalYearID > 0)
            //{
            //    String fe2 = SqlExpressionBuilder.PrepareFilterExpression("ACFiscalYear", activeFiscalYearID.ToString(), SQLMatchType.Equal);
            //    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe2);
            //}

            return fe;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            txtTransactionFromDate.Text = System.DateTime.Now.AddDays(30).ToString(UIConstants.SHORT_DATE_FORMAT);
            txtTransactionToDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);

            BuildLabel();
        }

        private void BuildLabel()
        {
            String fe = MergeAllString();
            IList<ACBankStatement_CustomEntity> lst = FCCACBankStatement_Custom.GetFacadeCreate().GetIL(1000000, 1, String.Empty, fe);

            if (lst != null && lst.Count > 0)
            {
                var resultDebit = (from s in lst
                                   where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.DEBIT
                                   select s.Amount).Sum(val => val);

                var resultCredit = (from s in lst
                                    where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.CREDIT
                                    select s.Amount).Sum(val => val);

                //lbltotalDebitAmount.Text = Math.Round(resultDebit, 2).ToString();
                //lbltotalCreditAmount.Text = Math.Round(resultCredit, 2).ToString();

                lbltotalBalance.Text = Math.Round((resultDebit - resultCredit), 2).ToString();
            }

            else
            {
                lbltotalBalance.Text = "0.00";
            }

            Int64 accountID=0, activefiscalYearID=0;
            DateTime fromDate, ToDate;

            if (ddlBankAccountID.Items.Count > 0)
            {
                String fe_account = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccount." + ACAccountsHelper_CustomEntity.FLD_NAME_BankAccountID, ddlBankAccountID.SelectedValue.ToString(), SQLMatchType.Equal);
                IList<ACAccountsHelper_CustomEntity> lstAccountHelper = FCCACAccountsHelper_Custom.GetFacadeCreate().GetIL(1000, 1, fe_account);

                if (lstAccountHelper != null && lstAccountHelper.Count > 0)
                {
                    accountID = lstAccountHelper[0].AccountID;
                }
            }

            activefiscalYearID = MiscUtil.GetActiveFiscalYear();
            fromDate = MiscUtil.ParseToDateTime(txtTransactionFromDate.Text.ToString());
            ToDate = MiscUtil.ParseToDateTime(txtTransactionToDate.Text.ToString());

            IList<ACAccountOpenCloseBalance_CustomEntity> lstOpenClose = FCCACAccountOpenCloseBalance_Custom.GetFacadeCreate().GetIL(accountID, activefiscalYearID, fromDate, ToDate);

            if (lstOpenClose != null && lstOpenClose.Count > 0)
            {
                lblOpeningBalance.Text = Math.Round(lstOpenClose[0].OpenBalance,2).ToString();
            }

            else
            {
                lblOpeningBalance.Text = "0.00";
            }
        }

        private void PrepareEditView()
        {
            ACJournalEntity aCJournalEntity = CurrentACJournalEntity;


            if (!aCJournalEntity.IsNew)
            {
                //if (ddlAccountID.Items.Count > 0 && aCJournalEntity.AccountID != null)
                //{
                //    ddlAccountID.SelectedValue = aCJournalEntity.AccountID.ToString();
                //}

                //if (ddlAccountGroupID.Items.Count > 0 && aCJournalEntity.AccountGroupID != null)
                //{
                //    ddlAccountGroupID.SelectedValue = aCJournalEntity.AccountGroupID.ToString();
                //}

                //if (ddlClassID.Items.Count > 0 && aCJournalEntity.ClassID != null)
                //{
                //    ddlClassID.SelectedValue = aCJournalEntity.ClassID.ToString();
                //}

                //if (ddlClassTypeID.Items.Count > 0 && aCJournalEntity.ClassTypeID != null)
                //{
                //    ddlClassTypeID.SelectedValue = aCJournalEntity.ClassTypeID.ToString();
                //}

                //txtTransactionDateTime.Text = aCJournalEntity.TransactionDateTime.ToStringDefault();
                //txtAmount.Text = aCJournalEntity.Amount.ToString();
                //if (ddlEnteredByEmployeeID.Items.Count > 0 && aCJournalEntity.EnteredByEmployeeID != null)
                //{
                //    ddlEnteredByEmployeeID.SelectedValue = aCJournalEntity.EnteredByEmployeeID.ToString();
                //}

                //txtReferenceOrMemoOrID.Text = aCJournalEntity.ReferenceOrMemoOrID.ToString();
                //txtNote.Text = aCJournalEntity.Note.ToString();
                //if (ddlMDDebitCreditID.Items.Count > 0 && aCJournalEntity.MDDebitCreditID != null)
                //{
                //    ddlMDDebitCreditID.SelectedValue = aCJournalEntity.MDDebitCreditID.ToString();
                //}

                //if (ddlDimensionID.Items.Count > 0 && aCJournalEntity.DimensionID != null)
                //{
                //    ddlDimensionID.SelectedValue = aCJournalEntity.DimensionID.ToString();
                //}

                //if (ddlProjectID.Items.Count > 0 && aCJournalEntity.ProjectID != null)
                //{
                //    ddlProjectID.SelectedValue = aCJournalEntity.ProjectID.ToString();
                //}

                //if (ddlFiscalYearID.Items.Count > 0 && aCJournalEntity.FiscalYearID != null)
                //{
                //    ddlFiscalYearID.SelectedValue = aCJournalEntity.FiscalYearID.ToString();
                //}

                //chkIsReverseTransaction.Checked = aCJournalEntity.IsReverseTransaction;
                //if (ddlReverseTransactionJournalID.Items.Count > 0 && aCJournalEntity.ReverseTransactionJournalID != null)
                //{
                //    ddlReverseTransactionJournalID.SelectedValue = aCJournalEntity.ReverseTransactionJournalID.ToString();
                //}


             
            }
        }

        private void BindList()
        {
            BindACJournalList();
        }

        private void BindACJournalList()
        {   
            lvACJournal.DataBind();
        }

        private ACJournalEntity BuildACJournalEntity()
        {
            ACJournalEntity aCJournalEntity = CurrentACJournalEntity;

            return aCJournalEntity;
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

        Decimal previousValue = 0;
        Int64 previousType = 0;
        Decimal previousBalance = 0;
        Decimal totalDebitAmount, totalCreditAmount;
        protected void lvACJournal_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {   
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACBankStatement_CustomEntity ent = (ACBankStatement_CustomEntity)dataItem.DataItem;

                Label lblDebitAmount = (Label)e.Item.FindControl("lblDebitAmountLV");
                Label lblCreditAmount = (Label)e.Item.FindControl("lblCreditAmountLV");
                Label lblBalanceLV = (Label)e.Item.FindControl("lblBalanceLV");

                Decimal balance,currentBalance;
                Decimal.TryParse(ent.Amount.ToString(), out currentBalance);

                switch (ent.MDDebitCreditID)
                {
                    case MasterDataConstants.MDDebitCredit.DEBIT:
                        lblDebitAmount.Text = Math.Round(ent.Amount,2).ToString();
                        previousType = MasterDataConstants.MDDebitCredit.DEBIT;
                        balance = previousBalance + currentBalance;
                        previousBalance = balance;
                        totalDebitAmount += currentBalance;
                        lblBalanceLV.Text = Math.Round(previousBalance, 2).ToString();
                        break;
                    case MasterDataConstants.MDDebitCredit.CREDIT:
                        lblCreditAmount.Text = Math.Round(ent.Amount, 2).ToString();
                        previousType = MasterDataConstants.MDDebitCredit.CREDIT;       
                        balance = previousBalance - currentBalance;
                        previousBalance = balance;
                        totalCreditAmount += currentBalance;
                        lblBalanceLV.Text = Math.Round(previousBalance,2).ToString();
                        break;
                    default:
                        break;
                }
            }
        }
   

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACJournal_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = MergeAllString();
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindList();
            BuildLabel();
        }

        #endregion

        #endregion Event
    }
}
