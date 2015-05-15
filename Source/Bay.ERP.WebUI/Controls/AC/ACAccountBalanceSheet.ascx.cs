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
    public partial class ACAccountBalanceSheetControl : BaseControl
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

        public DateTime ACBalanceSheetAsDate
        {
            get
            {
                DateTime asDate = System.DateTime.Now;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BALANCE_SHEET_FROM_DATE]))
                {
                    DateTime.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BALANCE_SHEET_FROM_DATE], out asDate);
                }

                return asDate;
            }
        }

        public Int64 ACBalanceSheetActiveFiscalYearID
        {
            get
            {
                Int64 balanceSheetActiveFiscalYearID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ACTIVE_FISCAL_YEAR_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ACTIVE_FISCAL_YEAR_ID], out balanceSheetActiveFiscalYearID);
                }

                return balanceSheetActiveFiscalYearID;
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

            txtAsDate.Text = ACBalanceSheetAsDate.ToString(UIConstants.SHORT_DATE_FORMAT);
           
            BindList();
        }

        private void BindList()
        {
            BindACJournalList();
        }

        private void BindACJournalList()
        {   
            DateTime asAtDate=MiscUtil.ParseToDateTime(txtAsDate.Text);
            IList<ACAccountBalanceSheet_CustomEntity> lst = FCCACAccountBalanceSheet_Custom.GetFacadeCreate().GetIL(OverviewAccountGroupID,ACBalanceSheetActiveFiscalYearID,asAtDate);
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
        }

        #endregion

        #endregion Event
    }
}
