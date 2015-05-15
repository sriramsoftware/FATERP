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
    public partial class ACAccountVendorPortfolioControl : BaseControl
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
            MiscUtil.PopulateACMDAccountResourceCategory(ddlAccountResourceCategoryID, false);

            BuildReferenceByResourceCategory();
        }

        private void PrepareValidator()
        {
        }

        private void BuildReferenceByResourceCategory()
        {
            if (ddlAccountResourceCategoryID != null && ddlAccountResourceCategoryID.Items.Count > 0)
            {
                lblReference.Text = ddlAccountResourceCategoryID.SelectedItem.ToString() + " :";

                switch (Int64.Parse(ddlAccountResourceCategoryID.SelectedValue))
                {
                    case MasterDataConstants.ACMDAccountResourceCategory.CONTRACTOR:
                        MiscUtil.PopulateCMContractor(ddlReferenceID, false);
                        break;
                    case MasterDataConstants.ACMDAccountResourceCategory.CONSULTANT:
                        MiscUtil.PopulateCMConsultant(ddlReferenceID, false);
                        break;
                    case MasterDataConstants.ACMDAccountResourceCategory.VENDOR:
                        MiscUtil.PopulatePRMSupplier(ddlReferenceID, false);
                        break;
                    case MasterDataConstants.ACMDAccountResourceCategory.CUSTOMER:
                        MiscUtil.PopulateCRMCustomer(ddlReferenceID, false);
                        break;
                }
            }
        }

        private String MergeAllString()
        {
            String fe = String.Empty;

            String fe_account =String.Empty;

            if (ddlReferenceID != null && ddlReferenceID.Items.Count > 0)
            {
                String feResourceCategory = SqlExpressionBuilder.PrepareFilterExpression(ACAccountResourceAccountMapEntity.FLD_NAME_AccountResourceCategoryID, ddlAccountResourceCategoryID.SelectedValue, SQLMatchType.Equal);
                String feResource = SqlExpressionBuilder.PrepareFilterExpression(ACAccountResourceAccountMapEntity.FLD_NAME_ReferenceID, ddlReferenceID.SelectedValue, SQLMatchType.Equal);
                fe_account=SqlExpressionBuilder.PrepareFilterExpression(feResourceCategory,SQLJoinType.AND,feResource);
                IList<ACAccountResourceAccountMapEntity> lst = FCCACAccountResourceAccountMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_account, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankStatement_CustomEntity.FLD_NAME_AccountID, lst[0].AccountID.ToString(), SQLMatchType.Equal);
                }
            }

            if (!String.IsNullOrWhiteSpace(txtTransactionFromDate.Text.Trim()))
            {
                if (!String.IsNullOrWhiteSpace(txtTransactionToDate.Text.Trim()))
                {
                    String fe1 = "TransactionDateTime between '" + MiscUtil.ParseToDateTime(txtTransactionFromDate.Text) + "' and '" + MiscUtil.ParseToDateTime(txtTransactionToDate.Text) + "'";
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
                }
            }

            return fe;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtTransactionFromDate.Text = System.DateTime.Now.AddDays(30).ToString(UIConstants.SHORT_DATE_FORMAT);
            txtTransactionToDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);

            BindList();
            BuildLabel();
        }

        private void BuildLabel()
        {
            //String fe = MergeAllString();
          

            //if (lst != null && lst.Count > 0)
            //{
            //    var resultDebit = (from s in lst
            //                       where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.DEBIT
            //                       select s.Amount).Sum(val => val);

            //    var resultCredit = (from s in lst
            //                        where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.CREDIT
            //                        select s.Amount).Sum(val => val);

            //    lbltotalDebitAmount.Text = Math.Round(resultDebit,2).ToString();
            //    lbltotalCreditAmount.Text = Math.Round(resultCredit,2).ToString();

            //    lbltotalBalance.Text = Math.Round((resultDebit - resultCredit),2).ToString();
            //}
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

                Decimal balance, currentBalance;
                Decimal.TryParse(ent.Amount.ToString(), out currentBalance);

                switch (ent.MDDebitCreditID)
                {
                    case MasterDataConstants.MDDebitCredit.DEBIT:
                        lblDebitAmount.Text = Math.Round(ent.Amount, 2).ToString();
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
                        lblBalanceLV.Text = Math.Round(previousBalance, 2).ToString();
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

        #region DropDownList Event

        protected void ddlAccountResourceCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildReferenceByResourceCategory();
        }

        #endregion

        #endregion Event
    }
}
