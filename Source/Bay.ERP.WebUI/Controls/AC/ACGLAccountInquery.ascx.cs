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
    public partial class ACGLAccountInqueryControl : BaseControl
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
  
        }

        private void PrepareValidator()
        {
        }

        private String MergeAllString()
        {
            String fe = String.Empty;

            if (hdEmpID.Value != "0")
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankStatement_CustomEntity.FLD_NAME_AccountID, hdEmpID.Value.ToString(), SQLMatchType.Equal);
            }

            if(!String.IsNullOrWhiteSpace(txtTransactionFromDate.Text.Trim()))
            {
                if(!String.IsNullOrWhiteSpace(txtTransactionToDate.Text.Trim())){
                    String fe1="TransactionDateTime between '" + MiscUtil.ParseToDateTime(txtTransactionFromDate.Text) + "' and '" + MiscUtil.ParseToDateTime(txtTransactionToDate.Text)+"'";
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

            txtTransactionFromDate.Text = System.DateTime.Now.AddDays(-30).ToString(UIConstants.SHORT_DATE_FORMAT);
            txtTransactionToDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);

            //BuildLabel();
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
                //lbltotalBalance.Text = MiscUtil.NumericCommaSeperatedFormat((resultDebit - resultCredit));
            }

            else
            {
                lbltotalBalance.Text = "0.00";
            }

            Int64 accountID=0, activefiscalYearID=0;
            DateTime fromDate, ToDate;

            if (hdEmpID.Value != "0")
            { 
                accountID = Int64.Parse(hdEmpID.Value.ToString());
            }

            activefiscalYearID = MiscUtil.GetActiveFiscalYear();
            fromDate = MiscUtil.ParseToDateTime(txtTransactionFromDate.Text.ToString());
            ToDate = MiscUtil.ParseToDateTime(txtTransactionToDate.Text.ToString());

            IList<ACAccountOpenCloseBalance_CustomEntity> lstOpenClose = FCCACAccountOpenCloseBalance_Custom.GetFacadeCreate().GetIL(accountID, activefiscalYearID, fromDate, ToDate);

            if (lstOpenClose != null && lstOpenClose.Count > 0)
            {

                lblOpeningBalance.Text = Math.Round(lstOpenClose[0].OpenBalance,2).ToString();
                //lblOpeningBalance.Text = MiscUtil.NumericCommaSeperatedFormat(lstOpenClose[0].OpenBalance);
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
                Label lblParticularsLV = (Label)e.Item.FindControl("lblParticularsLV");

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


                if (ent.ReferenceOrMemoOrID.IsNotNullOrEmpty())
                {
                    String fe_journal1 = SqlExpressionBuilder.PrepareFilterExpression("ACJournal." + ACJournalEntity.FLD_NAME_ReferenceOrMemoOrID, ent.ReferenceOrMemoOrID.ToString(), SQLMatchType.Equal);
                    String fe_journal2 = "ACJournal." + ACJournalEntity.FLD_NAME_JournalID+" <> "+ ent.JournalID.ToString();
                    String fe_journal = SqlExpressionBuilder.PrepareFilterExpression(fe_journal1, SQLJoinType.AND, fe_journal2);

                    IList<ACJournal_DetailedEntity> lstACJournal_Detailed = FCCACJournal_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_journal);

                    if (lstACJournal_Detailed != null && lstACJournal_Detailed.Count > 0)
                    {
                        String processedString=String.Empty;

                        foreach (ACJournal_DetailedEntity aCJournal_DetailedEntity in lstACJournal_Detailed)
                        {
                            processedString += "<b>"+aCJournal_DetailedEntity.ACAccountAccountName.ToString() + "</b> - " + MiscUtil.NumericCommaSeperatedFormat(aCJournal_DetailedEntity.Amount).ToString() +" "+ (aCJournal_DetailedEntity.MDDebitCreditID == 1 ? "Dr" : "Cr").ToString() + "<br>" + aCJournal_DetailedEntity.Note.ToString() + "<br>";
                        }

                        lblParticularsLV.Text = processedString;
                    }

                }
            }
        }
   

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACJournal_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            Int64 accountID = 0;

            Int64.TryParse(hdEmpID.Value.ToString(), out accountID);

            if (accountID > 0)
            {
              fe = MergeAllString();
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (hdEmpID.Value != "0")
            {
                BindList();
                BuildLabel();
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Please Choose Account", true);
            }
        }

        #endregion

        #endregion Event
    }
}
