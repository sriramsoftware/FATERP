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
    public partial class ACBalanceSheetControl : BaseControl
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

        private void PrepareInitialView()
        {
            BuildDropDownList();
            MiscUtil.PopulateACFiscalYear(ddlFiscalYearID, false);

            txtAsAt.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);

            if (ddlFiscalYearID.Items.Count > 0)
            {
                Int64 activeFiscalYearID = MiscUtil.GetActiveFiscalYear();

                if (activeFiscalYearID > 0)
                {
                    ddlFiscalYearID.SelectedValue = activeFiscalYearID.ToString();
                }
            }

            BindList();

            BuildLabel();
        }

        private void BuildLabel()
        {
            DateTime asAt=MiscUtil.ParseToDateTime(txtAsAt.Text.ToString());
            String fe=SqlExpressionBuilder.PrepareFilterExpression(ACJournalEntity.FLD_NAME_ClassTypeID,MasterDataConstants.ACClassType.ASSETS.ToString(),SQLMatchType.Equal);
            String fe_date = ACJournalEntity.FLD_NAME_TransactionDateTime+" <= '"+asAt.ToString()+"'";
            String fe_fiscalYear = SqlExpressionBuilder.PrepareFilterExpression(ACJournalEntity.FLD_NAME_FiscalYearID, ddlFiscalYearID.SelectedValue.ToString(), SQLMatchType.Equal);
            String fe_common = SqlExpressionBuilder.PrepareFilterExpression(fe_fiscalYear, SQLJoinType.AND, fe_date);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe_date);
            IList<ACJournalEntity> lstAsset=FCCACJournal.GetFacadeCreate().GetIL(null,null,String.Empty,fe,DatabaseOperationType.LoadWithFilterExpression);

            Decimal totalAsset=0, totalLiabilities;
            if (lstAsset != null && lstAsset.Count > 0)
            {
                Decimal tempDebit, tempCredit;
                var resultDebit = (from s in lstAsset
                                    where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.DEBIT
                                    select s.Amount).Sum(val => val);

                var resultCredit = (from s in lstAsset
                                     where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.CREDIT
                                     select s.Amount).Sum(val => val);

                tempDebit = resultDebit;
                tempCredit = resultCredit;
                totalAsset = tempDebit - tempCredit;

                lblTotalAsset.Text = Math.Round(totalAsset, 2).ToString();
            }

            else
            {
                totalAsset = 0;
                lblTotalAsset.Text = Math.Round(totalAsset, 2).ToString();
            }

            String fe_liabilities = SqlExpressionBuilder.PrepareFilterExpression(ACJournalEntity.FLD_NAME_ClassTypeID, MasterDataConstants.ACClassType.LIABILITIES.ToString(), SQLMatchType.Equal);
            fe_liabilities = SqlExpressionBuilder.PrepareFilterExpression(fe_liabilities, SQLJoinType.AND, fe_common);
            IList<ACJournalEntity> lstliabilities= FCCACJournal.GetFacadeCreate().GetIL(null, null, String.Empty, fe_liabilities, DatabaseOperationType.LoadWithFilterExpression);

            if (lstliabilities != null && lstliabilities.Count > 0)
            {
                Decimal tempDebit, tempCredit;
                var resultDebit = (from s in lstliabilities
                                   where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.DEBIT
                                   select s.Amount).Sum(val => val);

                var resultCredit = (from s in lstliabilities
                                    where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.CREDIT
                                    select s.Amount).Sum(val => val);

                tempDebit = resultDebit;
                tempCredit = resultCredit;
                totalLiabilities = tempDebit - tempCredit;

                lblTotalLiabilities.Text = Math.Round(totalLiabilities, 2).ToString();

                lblTotalReturn.Text = Math.Round((totalAsset - totalLiabilities), 2).ToString();
            }

            else
            {
                totalLiabilities = 0;
                lblTotalLiabilities.Text = Math.Round(totalLiabilities, 2).ToString();
            }

            
        }

        private void BindList()
        {
            BindACJournalList();
        }

        private void BindACJournalList()
        {   

            DateTime asAtDate = MiscUtil.ParseToDateTime(txtAsAt.Text.ToString());
            
            IList<ACAccountGroupBalanceSheet_CustomEntity> lst = FCCACAccountGroupBalanceSheet_Custom.GetFacadeCreate().GetIL(Int64.Parse(ddlFiscalYearID.SelectedValue), asAtDate);
            lvACJournal.DataSource = lst;
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
        
        protected void lvACJournal_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACAccountGroupBalanceSheet_CustomEntity ent = (ACAccountGroupBalanceSheet_CustomEntity)dataItem.DataItem;

                HyperLink hypAccountGroupLV = (HyperLink)e.Item.FindControl("hypAccountGroupLV");
                DateTime asAtDate = MiscUtil.ParseToDateTime(txtAsAt.Text);
                hypAccountGroupLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/AC/ACAccountBalanceSheet.aspx", String.Empty, UrlConstants.OVERVIEW_ACCOUNT_GROUP_ID, ent.AccountGroupID.ToString(), UrlConstants.OVERVIEW_ACTIVE_FISCAL_YEAR_ID, ddlFiscalYearID.SelectedValue, UrlConstants.OVERVIEW_BALANCE_SHEET_FROM_DATE, asAtDate.ToString()).ToString();
            }   
        }
   

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACJournal_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {   
            e.InputParameters["filterExpression"] = String.Empty;
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
