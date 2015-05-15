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
    public partial class ACAccountBalanceSheetReportControl : BaseControl
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

        public Int64 OverviewAccountGroupID
        {
            get
            {
                Int64 accountGroupID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ACCOUNT_GROUP_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ACCOUNT_GROUP_ID], out accountGroupID);
                }

                return accountGroupID;
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
            txtTransactionFromDate.Text = System.DateTime.Now.AddDays(30).ToString(UIConstants.SHORT_DATE_FORMAT);
            txtTransactionToDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
        }
     
        private void BindList()
        {
            BindACJournalList();
        }

        private void BindACJournalList()
        { 

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
            }
        }

        #endregion

        #region List View Event

        //Decimal previousValue = 0;
        //Int64 previousType = 0;
        //Decimal previousBalance = 0;
        //Decimal totalDebitAmount, totalCreditAmount;
        //protected void lvACJournal_ItemDataBound(object sender, ListViewItemEventArgs e)
        //{
        //    if (e.Item.ItemType == ListViewItemType.DataItem)
        //    {   
        //        ListViewDataItem dataItem = (ListViewDataItem)e.Item;

        //        ACBankStatement_CustomEntity ent = (ACBankStatement_CustomEntity)dataItem.DataItem;

        //        Label lblDebitAmount = (Label)e.Item.FindControl("lblDebitAmountLV");
        //        Label lblCreditAmount = (Label)e.Item.FindControl("lblCreditAmountLV");
        //        Label lblBalanceLV = (Label)e.Item.FindControl("lblBalanceLV");

        //        Decimal balance,currentBalance;
        //        Decimal.TryParse(ent.Amount.ToString(), out currentBalance);

        //        switch (ent.MDDebitCreditID)
        //        {
        //            case MasterDataConstants.MDDebitCredit.DEBIT:
        //                lblDebitAmount.Text = Math.Round(ent.Amount,2).ToString();
        //                previousType = MasterDataConstants.MDDebitCredit.DEBIT;
        //                balance = previousBalance + currentBalance;
        //                previousBalance = balance;
        //                totalDebitAmount += currentBalance;
        //                lblBalanceLV.Text = Math.Round(previousBalance, 2).ToString();
        //                break;
        //            case MasterDataConstants.MDDebitCredit.CREDIT:
        //                lblCreditAmount.Text = Math.Round(ent.Amount, 2).ToString();
        //                previousType = MasterDataConstants.MDDebitCredit.CREDIT;       
        //                balance = previousBalance - currentBalance;
        //                previousBalance = balance;
        //                totalCreditAmount += currentBalance;
        //                lblBalanceLV.Text = Math.Round(previousBalance,2).ToString();
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}
   

        #endregion List View Event

        #region Button Event

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime fromDate = System.DateTime.Now, toDate = System.DateTime.Now;

            if (!String.IsNullOrWhiteSpace(txtTransactionFromDate.Text.Trim()))
            {
                fromDate = MiscUtil.ParseToDateTime(txtTransactionFromDate.Text.ToString());
            }

            if (!String.IsNullOrWhiteSpace(txtTransactionToDate.Text.Trim()))
            {
                toDate = MiscUtil.ParseToDateTime(txtTransactionToDate.Text.ToString());
            }

            Int64 fiscalyearID = MiscUtil.GetActiveFiscalYear();

            String navUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.BALANCE_SHEET_REPORT, UrlConstants.OVERVIEW_BALANCE_SHEET_FROM_DATE, fromDate.ToString(), UrlConstants.OVERVIEW_BALANCE_SHEET_TO_DATE, toDate.ToString(), UrlConstants.OVERVIEW_ACTIVE_FISCAL_YEAR_ID, fiscalyearID.ToString()).ToString();

            Response.Redirect(navUrl);
        }

        #endregion

        #endregion Event
    }
}
