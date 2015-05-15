using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using System.Data;
using Bay.ERP.Common.Helper;
using System.IO;
using Bay.ERP.Web.UI.Manager;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class Reports_ReportViewer : BasePage
    {
        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "Reports_ReportViewer_Page";
            }
        }

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

        public Int64 REQRequisitionID
        {
            get
            {
                Int64 rEQRequisitionID = 0;

                if (Action == ReportConstants.REQUISITION_REPORT || Action == ReportConstants.CRM_AD_REQUISITION_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.REQUISITION_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.REQUISITION_ID], out rEQRequisitionID);
                    }
                }

                return rEQRequisitionID;
            }
        }

        public Int64 BDProjectID
        {
            get
            {
                Int64 _BDProjectID = 0;

                if (Action == ReportConstants.PROJECT_REPORT || Action == ReportConstants.PROJECT_HISTORY_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROJECT_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROJECT_ID], out _BDProjectID);
                    }
                }

                return _BDProjectID;
            }
        }

        public Int64 BDProjectFloorUnitID
        {
            get
            {
                Int64 _BDProjectFloorUnitID = 0;

                if (Action == ReportConstants.BDPROJECTFLOORUNIT_REPROT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROJECTFLOORUNITID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROJECTFLOORUNITID], out _BDProjectFloorUnitID);
                    }
                }

                return _BDProjectFloorUnitID;
            }
        }

        public Int64 PRMSupplierPriceItemID
        {
            get
            {
                Int64 _pRMSupplierPriceItemID = 0;

                if (Action == ReportConstants.PROJECT_HISTORY_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SUPPLIERPRICE_ITEM_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SUPPLIERPRICE_ITEM_ID], out _pRMSupplierPriceItemID);
                    }
                }

                return _pRMSupplierPriceItemID;
            }
        }

        public Int64 OTIssueID
        {
            get
            {
                Int64 _oTIssueID = 0;

                if (Action == ReportConstants.ISSUE_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_ID], out _oTIssueID);
                    }
                }

                return _oTIssueID;
            }
        }

        public Int64 PRMWorkOrderID
        {
            get
            {
                Int64 _pRMWorkOrderID = 0;

                if (Action == ReportConstants.WORK_ORDER_REPORT||
                    Action == ReportConstants.WORK_ORDER_REPORT_WITH_ANNEXURE ||
                    Action == ReportConstants.WORK_ORDER_ITEM_FLOOR_DETAIL)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_WORKORDER_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_WORKORDER_ID], out _pRMWorkOrderID);
                    }
                }

                return _pRMWorkOrderID;
            }
        }
        
        public Int64 PRMMaterialReceiveID
        {
            get
            {
                Int64 _pRMMaterialReceiveID = 0;

                if (Action == ReportConstants.MATERIAL_RECEIVE_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID], out _pRMMaterialReceiveID);
                    }
                }

                return _pRMMaterialReceiveID;
            }
        }

        public Int64 CMBillID
        {
            get
            {
                Int64 _cMBillID = 0;

                if (Action == ReportConstants.BILL_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CM_BILL_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CM_BILL_ID], out _cMBillID);
                    }
                }

                return _cMBillID;
            }
        }


        public CMBillEntity cmCurrentBillEntity
        {
            get
            {
                CMBillEntity _cmCurrentBillEntity = null;

                if (CMBillID > 0)
                {
                    _cmCurrentBillEntity = FCCCMBill.GetFacadeCreate().GetByID(CMBillID);
                }

                return _cmCurrentBillEntity!=null?_cmCurrentBillEntity:new CMBillEntity();
            }
        }

        public Int64 ACCPostPayableStatementID
        {
            get
            {
                Int64 _aCCPostPayableStatementID = 0;

                if (Action == ReportConstants.POST_PAYABLE_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_ID], out _aCCPostPayableStatementID);
                    }
                }

                return _aCCPostPayableStatementID;
            }
        }

        public Int64 ACCPrePayableStatementID
        {
            get
            {
                Int64 _aCCPrePayableStatementID = 0;

                if (Action == ReportConstants.PRE_PAYABLE_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID], out _aCCPrePayableStatementID);
                    }
                }

                return _aCCPrePayableStatementID;
            }
        }

        public DateTime ACTrialBalanceFromDate
        {
            get
            {
                DateTime fromDate = System.DateTime.Now;

                if (Action == ReportConstants.TRIAL_BALANCE_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TRIAL_BALANCE_FROM_DATE]))
                    {
                        //fromDate = MiscUtil.ParseToDateTime(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TRIAL_BALANCE_FROM_DATE].ToString());
                        DateTime.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TRIAL_BALANCE_FROM_DATE], out fromDate);
                    }
                }

                return fromDate;
            }
        }

        public DateTime ACTrialBalanceToDate
        {
            get
            {
                DateTime toDate = System.DateTime.Now;

                if (Action == ReportConstants.TRIAL_BALANCE_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TRIAL_BALANCE_TO_DATE]))
                    {
                       // toDate = MiscUtil.ParseToDateTime(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TRIAL_BALANCE_TO_DATE].ToString());
                        DateTime.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TRIAL_BALANCE_TO_DATE], out toDate);
                    }
                }

                return toDate;
            }
        }

        public Int64 ACTrialBalanceActiveFiscalYearID
        {
            get
            {
                Int64 trialBalanceActiveFiscalYearID = 0;

                if (Action == ReportConstants.TRIAL_BALANCE_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ACTIVE_FISCAL_YEAR_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ACTIVE_FISCAL_YEAR_ID], out trialBalanceActiveFiscalYearID);
                    }
                }

                return trialBalanceActiveFiscalYearID;
            }
        }


        public DateTime ACBalanceSheetFromDate
        {
            get
            {
                DateTime fromDate = System.DateTime.Now;

                if (Action == ReportConstants.BALANCE_SHEET_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BALANCE_SHEET_FROM_DATE]))
                    {
                        //fromDate = MiscUtil.ParseToDateTime(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BALANCE_SHEET_FROM_DATE].ToString());
                        DateTime.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BALANCE_SHEET_FROM_DATE], out fromDate);
                    }
                }

                return fromDate;
            }
        }

        public DateTime ACBalanceSheetToDate
        {
            get
            {
                DateTime toDate = System.DateTime.Now;

                if (Action == ReportConstants.BALANCE_SHEET_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BALANCE_SHEET_TO_DATE]))
                    {
                        //toDate = MiscUtil.ParseToDateTime(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BALANCE_SHEET_TO_DATE].ToString());
                        DateTime.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BALANCE_SHEET_TO_DATE], out toDate);
                    }
                }

                return toDate;
            }
        }

        public Int64 ACBalanceSheetActiveFiscalYearID
        {
            get
            {
                Int64 balanceSheetActiveFiscalYearID = 0;

                if (Action == ReportConstants.BALANCE_SHEET_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ACTIVE_FISCAL_YEAR_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ACTIVE_FISCAL_YEAR_ID], out balanceSheetActiveFiscalYearID);
                    }
                }

                return balanceSheetActiveFiscalYearID;
            }
        }


        public Int64 ACBankAccountDepositID
        {
            get
            {
                Int64 acBankAccountDepositID = 0;

                if (Action == ReportConstants.BANK_ACCOUNT_DEPOSIT_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID], out acBankAccountDepositID);
                    }
                }

                return acBankAccountDepositID;
            }
        }

        public Int64 ACBankAccountPaymentID
        {
            get
            {
                Int64 acBankAccountPaymentID = 0;

                if (Action == ReportConstants.BANK_ACCOUNT_PAYMENT_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID], out acBankAccountPaymentID);
                    }
                }

                return acBankAccountPaymentID;
            }
        }

        public Int64 ACTemporaryJournalID
        {
            get
            {
                Int64 acTemporaryJournalID = 0;

                if (Action == ReportConstants.MANUAL_JOURNAL_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_MASTER_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_MASTER_ID], out acTemporaryJournalID);
                    }
                }

                return acTemporaryJournalID;
            }
        }

        public Int64 CRMAgreementID
        {
            get
            {
                Int64 cRMAgreementID = 0;

                if (Action == ReportConstants.AGREEMENT_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_AGREEMENT_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_AGREEMENT_ID], out cRMAgreementID);
                    }
                }

                return cRMAgreementID;
            }
        }

        public Int64 CRMPaymentScheduleID
        {
            get
            {
                Int64 cRMPaymentScheduleID = 0;

                if (Action == ReportConstants.PAYMENT_SCHEDULE_REPORT || Action == ReportConstants.PAYMENT_COLLECTION_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PAYMENT_SCHEDULE_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PAYMENT_SCHEDULE_ID], out cRMPaymentScheduleID);
                    }
                }

                return cRMPaymentScheduleID;
            }
        }

        public Int64 CRMPaymentCollectionID
        {
            get
            {
                Int64 cRMPaymentCollectionID = 0;

                if (Action == ReportConstants.MONEY_RECEIPT_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PAYMENT_COLLECTION_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PAYMENT_COLLECTION_ID], out cRMPaymentCollectionID);
                    }
                }

                return cRMPaymentCollectionID;
            }
        }

        public DateTime CRMDuePaymentScheduleToDate
        {
            get
            {
                DateTime toDate = System.DateTime.Now;

                if (Action == ReportConstants.DUE_PAYMENT_SCHEDULE_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TO_DATE_DUE_PAYMENT_SCHEDULE]))
                    {
                        //toDate = MiscUtil.ParseToDateTime(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TO_DATE_DUE_PAYMENT_SCHEDULE].ToString());
                        DateTime.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TO_DATE_DUE_PAYMENT_SCHEDULE], out toDate);
                    }
                }

                return toDate;
            }
        }

        public DateTime CRMEncashedToDate
        {
            get
            {
                DateTime toDate = System.DateTime.Now;

                if (Action == ReportConstants.ENCASHED_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TO_DATE_ENCASHED]))
                    {
                        //toDate = MiscUtil.ParseToDateTime(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TO_DATE_ENCASHED].ToString());
                        DateTime.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TO_DATE_ENCASHED], out toDate);
                    }
                }

                return toDate;
            }
        }

        public Boolean IsEncashed
        {
            get
            {
                Boolean isEncahsed= false;

                if (Action == ReportConstants.ENCASHED_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_IS_ENCASHED]))
                    {
                        Boolean.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_IS_ENCASHED].ToString(),out isEncahsed);
                    }
                }

                return isEncahsed;
            }
        }

        public DateTime OTIssueFromDate
        {
            get
            {
                DateTime fromDate = System.DateTime.Now;

                if (Action == ReportConstants.ISSUE_DATEWISE_REPORT||
                    Action == ReportConstants.ISSUE_EMPLOYEE_AND_DATEWISE_REPORT||
                    Action == ReportConstants.WEEKLY_DTL_INDIVIDUAL_REPORT||
                    Action == ReportConstants.HR_DTL_SUBMISSION_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_FROM_DATE]))
                    {
                        fromDate = MiscUtil.ParseToDateTime(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_FROM_DATE].ToString());
                        //DateTime.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_FROM_DATE], out fromDate);
                    }
                }

                return fromDate;
            }
        }

        public DateTime OTIssueToDate
        {
            get
            {
                DateTime toDate = System.DateTime.Now;

                if (Action == ReportConstants.ISSUE_DATEWISE_REPORT||
                    Action == ReportConstants.ISSUE_EMPLOYEE_AND_DATEWISE_REPORT||
                    Action == ReportConstants.WEEKLY_DTL_INDIVIDUAL_REPORT ||
                    Action == ReportConstants.HR_DTL_SUBMISSION_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_TO_DATE]))
                    {
                        toDate = MiscUtil.ParseToDateTime(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_TO_DATE].ToString());
                        //DateTime.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_TO_DATE], out toDate);
                    }
                }

                return toDate;
            }
        }

        public Int64 overviewEmployeeID
        {
            get
            {
                Int64 employeeID = 0;

                if (Action == ReportConstants.ISSUE_EMPLOYEE_AND_DATEWISE_REPORT||
                    Action == ReportConstants.WEEKLY_DTL_INDIVIDUAL_REPORT  ||
                    Action == ReportConstants.HR_EMPLOYEE_DETAILS_REPORT||
                    Action == ReportConstants.HR_EMPLOYEE_RESUME_REPORT )
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID], out employeeID);
                    }
                }

                return employeeID;
            }
        }

        public Int64 BDAssignedResourceMapID
        {
            get
            {
                Int64 bDAssignedResourceMapID = 0;

                if (Action == ReportConstants.ENVELOP_REPORT||
                    Action == ReportConstants.TRANSMISSION_SHEET_REPORT||
                    Action == ReportConstants.LARGE_ENVELOP_REPORT||
                    Action == ReportConstants.LEGEL_ENVELOP_REPORT||
                    Action == ReportConstants.CASH_PAYMENT_REGISTER_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_MAP_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_MAP_ID], out bDAssignedResourceMapID);
                    }
                }

                return bDAssignedResourceMapID;
            }
        }

        public DateTime ACRegisterFromDate
        {
            get
            {
                DateTime fromDate = System.DateTime.Now;

                if (Action == ReportConstants.BANK_ACCOUNT_DEPOSIT_REGISTER_REPORT||
                    Action == ReportConstants.BANK_ACCOUNT_PAYMENT_REGISTER_REPORT||
                    Action == ReportConstants.TEMPORARY_JOURNAL_REGISTER_REPORT||
                    Action == ReportConstants.DAY_BOOK_REPORT||
                    Action == ReportConstants.CASH_PAYMENT_REGISTER_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_REGISTER_FROM_DATE]))
                    {
                        fromDate = MiscUtil.ParseToDateTime(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_REGISTER_FROM_DATE].ToString());
                        //DateTime.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_REGISTER_FROM_DATE], out fromDate);
                    }
                }

                return fromDate;
            }
        }

        public DateTime ACRegisterToDate
        {
            get
            {
                DateTime toDate = System.DateTime.Now;

                if (Action == ReportConstants.BANK_ACCOUNT_DEPOSIT_REGISTER_REPORT||
                    Action == ReportConstants.BANK_ACCOUNT_PAYMENT_REGISTER_REPORT||
                    Action == ReportConstants.TEMPORARY_JOURNAL_REGISTER_REPORT||
                    Action == ReportConstants.DAY_BOOK_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_REGISTER_TO_DATE]))
                    {
                        toDate = MiscUtil.ParseToDateTime(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_REGISTER_TO_DATE].ToString());
                        //DateTime.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_REGISTER_TO_DATE], out toDate);
                    }
                }

                return toDate;
            }
        }

        public Int64 HRSessionID
        {
            get
            {
                Int64 hRSessionID = 0;

                if (Action == ReportConstants.HR_EMPLOYEE_EVALUATION_REPORT 
                    || Action == ReportConstants.HR_EMPLOYEE_EVALUATIONREPORT_REPORT 
                    || Action == ReportConstants.HR_EMPLOYEE_EVALUATIONREPORT_REPORT_FOR_ALL_EMPLOYEE)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVALUATION_SESSION_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVALUATION_SESSION_ID], out hRSessionID);
                    }
                }

                return hRSessionID;
            }
        }

        public Int64 HRSessionEvaluationEmployeeID
        {
            get
            {
                Int64 hRSessionEvaluationEmployeeID = 0;

                if (Action == ReportConstants.HR_EMPLOYEE_EVALUATION_REPORT || Action == ReportConstants.HR_EMPLOYEE_EVALUATIONREPORT_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID], out hRSessionEvaluationEmployeeID);
                    }
                }

                return hRSessionEvaluationEmployeeID;
            }
        }

        public Int64 CRMSurveyID
        {
            get
            {
                Int64 cRMSurveyID = 0;

                if (Action == ReportConstants.SURVEY_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SURVEY_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SURVEY_ID], out cRMSurveyID);
                    }
                }

                return cRMSurveyID;
            }
        }

        public Int64 CRMSurveyOwnerID
        {
            get
            {
                Int64 cRMSurveyOwnerID = 0;

                if (Action == ReportConstants.SURVEY_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SURVEY_OWNER_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SURVEY_OWNER_ID], out cRMSurveyOwnerID);
                    }
                }

                return cRMSurveyOwnerID;
            }
        }

        public Int64 CRMSurveyMasterID
        {
            get
            {
                Int64 cRMSurveyMasterID = 0;

                if (Action == ReportConstants.SURVEY_MASTER_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SURVEY_MASTER_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SURVEY_MASTER_ID], out cRMSurveyMasterID);
                    }
                }

                return cRMSurveyMasterID;
            }
        }

        public Int64 OverviewHRSalarySessionID
        {
            get
            {
                Int64 overviewHRSalarySessionID = 0;

                if (Action == ReportConstants.HR_TIME_SHEET ||
                    Action == ReportConstants.HR_EMPLOYEE_MONTHLY_TIME_SHEET_SUMMARY_REPORT ||
                    Action == ReportConstants.HR_EMPLOYEE_SALARY_PAYMENT_REPORT ||
                    Action == ReportConstants.HR_EMPLOYEE_SALARY_STATEMENT_REPORT ||
                    Action == ReportConstants.HR_EMPLOYEE_SALARY_DISBURSEMENT_BANK ||
                    Action == ReportConstants.HR_EMPLOYEE_LEAVE_APPLICATIONS_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_HR_SALARY_SESSION_ID], out overviewHRSalarySessionID);
                    }
                }

                return overviewHRSalarySessionID;
            }
        }

        public Int64 OverviewFiscalYearID
        {
            get
            {
                Int64 overviewFiscalYearID = 0;

                if (Action == ReportConstants.HR_EMPLOYEE_LEAVE_STATUS_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_FISCALYEAR_ID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_FISCALYEAR_ID], out overviewFiscalYearID);
                    }
                }

                return overviewFiscalYearID;
            }
        }

        public Int64 OverviewFromLevel
        {
            get
            {
                Int64 overviewFromLevel = 0;

                if (Action == ReportConstants.HR_EMPLOYEE_SALARY_DISBURSEMENT_BANK)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_FROM_LEVEL]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_FROM_LEVEL], out overviewFromLevel);
                    }
                }

                return overviewFromLevel;
            }
        }

        public Int64 OverviewToLevel
        {
            get
            {
                Int64 overviewToLevel = 0;

                if (Action == ReportConstants.HR_EMPLOYEE_SALARY_DISBURSEMENT_BANK)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TO_LEVEL]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TO_LEVEL], out overviewToLevel);
                    }
                }

                return overviewToLevel;
            }
        }

        public Int64 OverviewMDDepartmentFromID
        {
            get
            {
                Int64 overviewMDDepartmentFromID = 0;

                if ( Action == ReportConstants.HR_EMPLOYEE_MONTHLY_TIME_SHEET_SUMMARY_REPORT
                    || Action == ReportConstants.HR_EMPLOYEE_SALARY_STATEMENT_REPORT
                    || Action == ReportConstants.HR_EMPLOYEE_SALARY_PAYMENT_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MDDEPARTMENT_FROMID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MDDEPARTMENT_FROMID], out overviewMDDepartmentFromID);
                    }
                }

                return overviewMDDepartmentFromID;
            }
        }

        public Int64 OverviewMDDepartmentToID
        {
            get
            {
                Int64 overviewMDDepartmentToID = 0;

                if (Action == ReportConstants.HR_EMPLOYEE_MONTHLY_TIME_SHEET_SUMMARY_REPORT
                    || Action == ReportConstants.HR_EMPLOYEE_SALARY_STATEMENT_REPORT
                    || Action == ReportConstants.HR_EMPLOYEE_SALARY_PAYMENT_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MDDEPARTMENT_TOID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MDDEPARTMENT_TOID], out overviewMDDepartmentToID);
                    }
                }

                return overviewMDDepartmentToID;
            }
        }

        public Int64 OverviewMDDepartmentOtherID
        {
            get
            {
                Int64 overviewMDDepartmentOtherID = 0;

                if (Action == ReportConstants.HR_EMPLOYEE_MONTHLY_TIME_SHEET_SUMMARY_REPORT
                    || Action == ReportConstants.HR_EMPLOYEE_SALARY_STATEMENT_REPORT
                    || Action == ReportConstants.HR_EMPLOYEE_SALARY_PAYMENT_REPORT)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MDDEPARTMENT_OTHERID]))
                    {
                        Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MDDEPARTMENT_OTHERID], out overviewMDDepartmentOtherID);
                    }
                }

                return overviewMDDepartmentOtherID;
            }
        }

        #endregion

        ReportDocument myReportDocument;
        String ReportName;

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                reportViewer.DisplayGroupTree = false;
                reportViewer.HasCrystalLogo = false;

                myReportDocument = new ReportDocument();
                DataTable dt=null;

                if (Action == ReportConstants.REQUISITION_REPORT)
                {
                    //ReportName = "NewRequisition.rpt";
                    ReportName = "NewRequisition.rpt";
                    //--Initializing CrystalReport
                    myReportDocument.Load(Server.MapPath("~/Reports/Requisition/" + ReportName));
                    dt = FCCREQRequisition_RPT.GetFacadeCreate().GetDT(REQRequisitionID);

                    DataTable dtRequisitionSubReport = FCCREQRequisitionItemFloorDetail_RPT.GetFacadeCreate().GetDT(REQRequisitionID);
                    myReportDocument.Subreports[0].DataSourceConnections.Clear();
                    myReportDocument.Subreports[0].SetDataSource(dtRequisitionSubReport);

                    APApprovalProcessEntity ent = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.REQUISITION, REQRequisitionID);

                    IList<APMemberFeedback_DetailedEntity> lst = APRobot.GetAllMemberFeedbacks_Detailed(ent.APApprovalProcessID);

                    String strAPStatus = String.Empty;
                    String strDash = String.Empty;
                    String strEmployeeName = String.Empty;
                    String strEmployeeDesignation = String.Empty;
                    String strEmployeeRemarks = String.Empty;
                    String strDate = String.Empty;
                    String strPadAll = "     ";

                    CrystalDecisions.CrystalReports.Engine.TextObject txtApprovalStatus = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["sectionFooter"].ReportObjects["txtApprovalStatus"]);
                    CrystalDecisions.CrystalReports.Engine.TextObject txtSecondApprovalPanel = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["sectionFooter"].ReportObjects["txtSecondApprovalPanel"]);

                    if (lst != null && lst.Count > 0)
                    {
                        int i = 0;
                        Int64 firstLimit = 1;

                        if (lst.Count > 4)
                        {
                            firstLimit = 2;
                        }

                        foreach (APMemberFeedback_DetailedEntity apmf in lst)
                        {
                            strEmployeeName += (i + 1).ToString() + ". " + apmf.MemberFullName.PadRight(35) + strPadAll + "\n";
                            strEmployeeDesignation += "    " + apmf.DesignationName.PadRight(30) + strPadAll + "\n";
                            strAPStatus += "    (" + apmf.APFeedbackName + ")";
                            strDate += " Dt: " + apmf.FeedbackSubmitDate.ToString(UIConstants.SHORT_DATE_FORMAT).PadRight(45) + strPadAll + "\n";
                            //strDash += "".PadRight(50) + strPadAll + " ]";


                            if (i <= firstLimit)
                            {
                                txtApprovalStatus.Text += strEmployeeName;
                                txtApprovalStatus.Text += strEmployeeDesignation;
                                txtApprovalStatus.Text += strAPStatus;
                                //txtApprovalStatus.Text += strDash;
                                txtApprovalStatus.Text += strDate+"\n";
                            }
                            else
                            {
                                txtSecondApprovalPanel.Text += strEmployeeName;
                                txtSecondApprovalPanel.Text += strEmployeeDesignation;
                                txtSecondApprovalPanel.Text += strAPStatus;
                                //txtSecondApprovalPanel.Text += strDash;
                                txtSecondApprovalPanel.Text += strDate + "\n";
                            }

                            strAPStatus = String.Empty;
                            strDash = String.Empty;
                            strEmployeeName = String.Empty;
                            strEmployeeDesignation = String.Empty;
                            strDate = String.Empty;
                            i++;
                        }
                    }
                }

                else if (Action == ReportConstants.CRM_AD_REQUISITION_REPORT)
                {
                    //ReportName = "NewRequisition.rpt";
                    ReportName = "CRMAdvertisementRequisition.rpt";
                    //--Initializing CrystalReport
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCCRMAdvertisementRequisition_RPT.GetFacadeCreate().GetDT(REQRequisitionID);

                    DataTable dtRequisitionSubReport = FCCREQRequisitionItemFloorDetail_RPT.GetFacadeCreate().GetDT(REQRequisitionID);
                    //myReportDocument.Subreports[0].DataSourceConnections.Clear();
                    //myReportDocument.Subreports[0].SetDataSource(dtRequisitionSubReport);

                    APApprovalProcessEntity ent = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.REQUISITION, REQRequisitionID);

                    IList<APMemberFeedback_DetailedEntity> lst = APRobot.GetAllMemberFeedbacks_Detailed(ent.APApprovalProcessID);

                    String strAPStatus = String.Empty;
                    String strDash = String.Empty;
                    String strEmployeeName = String.Empty;
                    String strEmployeeDesignation = String.Empty;
                    String strEmployeeRemarks = String.Empty;
                    String strDate = String.Empty;
                    String strPadAll = "     ";

                    CrystalDecisions.CrystalReports.Engine.TextObject txtApprovalStatus = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["sectionFooter"].ReportObjects["txtApprovalStatus"]);
                    CrystalDecisions.CrystalReports.Engine.TextObject txtSecondApprovalPanel = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["sectionFooter"].ReportObjects["txtSecondApprovalPanel"]);

                    if (lst != null && lst.Count > 0)
                    {
                        int i = 0;
                        Int64 firstLimit = 1;

                        if (lst.Count > 4)
                        {
                            firstLimit = 2;
                        }

                        foreach (APMemberFeedback_DetailedEntity apmf in lst)
                        {
                            strEmployeeName += (i + 1).ToString() + ". " + apmf.MemberFullName.PadRight(35) + strPadAll + "\n";
                            strEmployeeDesignation += "    " + apmf.DesignationName.PadRight(30) + strPadAll + "\n";
                            strAPStatus += "    (" + apmf.APFeedbackName + ")";
                            strDate += " Dt: " + apmf.FeedbackSubmitDate.ToString(UIConstants.SHORT_DATE_FORMAT).PadRight(45) + strPadAll + "\n";
                            //strDash += "".PadRight(50) + strPadAll + " ]";


                            if (i <= firstLimit)
                            {
                                txtApprovalStatus.Text += strEmployeeName;
                                txtApprovalStatus.Text += strEmployeeDesignation;
                                txtApprovalStatus.Text += strAPStatus;
                                //txtApprovalStatus.Text += strDash;
                                txtApprovalStatus.Text += strDate + "\n";
                            }
                            else
                            {
                                txtSecondApprovalPanel.Text += strEmployeeName;
                                txtSecondApprovalPanel.Text += strEmployeeDesignation;
                                txtSecondApprovalPanel.Text += strAPStatus;
                                //txtSecondApprovalPanel.Text += strDash;
                                txtSecondApprovalPanel.Text += strDate + "\n";
                            }

                            strAPStatus = String.Empty;
                            strDash = String.Empty;
                            strEmployeeName = String.Empty;
                            strEmployeeDesignation = String.Empty;
                            strDate = String.Empty;
                            i++;
                        }
                    }
                }

                else if (Action == ReportConstants.PROJECT_REPORT)
                {
                    ReportName = "ProjectCustom.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/Project/" + ReportName));
                    dt = FCCBDProjectCutom_RPT.GetFacadeCreate().GetDT(BDProjectID);

                    DataTable dtBDProjectCollectedDocumentCustom = FCCBDProjectCollectedDocumentCustom_RPT.GetFacadeCreate().GetDT(BDProjectID);
                    myReportDocument.Subreports[0].DataSourceConnections.Clear();
                    myReportDocument.Subreports[0].SetDataSource(dtBDProjectCollectedDocumentCustom);

                }
                else if (Action == ReportConstants.PROJECT_HISTORY_REPORT)
                {
                    ReportName = "ProjectHistory.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Project/" + ReportName));
                    dt = FCCBDProjectHistory_RPT.GetFacadeCreate().GetDT(BDProjectID);
                }
                else if (Action == ReportConstants.BDPROJECTFLOORUNIT_REPROT)
                {
                    ReportName = "ProjectFloorUnit.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Project/" + ReportName));
                    dt = FCCBDProjectFloorUnit_RPT.GetFacadeCreate().GetDT(BDProjectFloorUnitID);
                }

                else if(Action == ReportConstants.PRICE_HISTORY_REPORT)
                {
                    ReportName = "PriceHistory.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Price/" + ReportName));
                    dt = FCCPRMSupplierItemMapHistory_RPT.GetFacadeCreate().GetDT(PRMSupplierPriceItemID);
                }

                else if (Action == ReportConstants.ITEM_REPORT)
                {
                    ReportName = "Item.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Project/" + ReportName));
                    dt = FCCMDItem_RPT.GetFacadeCreate().GetDT(1,1);
                    reportViewer.DisplayGroupTree = true;
                }

                else if (Action == ReportConstants.MISSED_ISSUE_REPORT)
                {
                    ReportName = "MissedIssue.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Issue/" + ReportName));
                    dt = FCCOTMissedIssue_RPT.GetFacadeCreate().GetDT();
                    reportViewer.DisplayGroupTree = true;
                    reportViewer.HasCrystalLogo = false;
                }

                else if (Action == ReportConstants.UPCOMING_ISSUE_REPORT)
                {
                    ReportName = "UpcomingIssue.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Issue/" + ReportName));
                    dt = FCCOTUpcomingIssue_RPT.GetFacadeCreate().GetDT();
                }

                else if (Action == ReportConstants.ISSUE_REPORT)
                {
                    ReportName = "Issue.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Issue/" + ReportName));
                    dt = FCCOTIssue_RPT.GetFacadeCreate().GetDT(OTIssueID);
                }

                else if (Action == ReportConstants.WORK_ORDER_REPORT_WITH_ANNEXURE)
                {
                    //ReportName = "WorkOrderWithAnnexureLatest.rpt";
                    //myReportDocument.Load(Server.MapPath(@"./WorkOrder/" + ReportName));

                    //dt = FCCPRMWorkOrder_RPT.GetFacadeCreate().GetDT(PRMWorkOrderID);

                    //DataTable dtSubReport = FCCPRMWorkOrderItemDetail_RPT.GetFacadeCreate().GetDT(PRMWorkOrderID);
                    //myReportDocument.Subreports[1].DataSourceConnections.Clear();
                    //myReportDocument.Subreports[1].SetDataSource(dtSubReport);

                    //DataTable dtWOPaymentTermSubReport = FCCPRMWorkOrderPaymentTerm_RPT.GetFacadeCreate().GetDT(PRMWorkOrderID);
                    //myReportDocument.Subreports[0].DataSourceConnections.Clear();
                    //myReportDocument.Subreports[0].SetDataSource(dtWOPaymentTermSubReport);

                    ReportName = "WorkOrderWithAnnexureLatest.rpt";
                    myReportDocument.Load(Server.MapPath(@"./WorkOrder/" + ReportName));
                    dt = FCCPRMWorkOrderItemDetail_RPT.GetFacadeCreate().GetDT(PRMWorkOrderID);

                    #region Work Order Appoval

                    APApprovalProcessEntity ent = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.WORK_ORDER, PRMWorkOrderID);

                    IList<APMemberFeedback_DetailedEntity> lst = APRobot.GetAllMemberFeedbacks_Detailed(ent.APApprovalProcessID);

                    if (lst != null && lst.Count > 0)
                    {
                        String strAPStatus = String.Empty;
                        String strDash = String.Empty;
                        String strEmployeeName = String.Empty;
                        String strEmployeeDesignation = String.Empty;
                        String strEmployeeRemarks = String.Empty;
                        String strDate = String.Empty;
                        String strPadAll = " ";

                        CrystalDecisions.CrystalReports.Engine.TextObject txtApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section4"].ReportObjects["txtApproval"]);
                        CrystalDecisions.CrystalReports.Engine.TextObject txtSecondApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section4"].ReportObjects["txtSecondApproval"]);
                        CrystalDecisions.CrystalReports.Engine.TextObject txtThirdApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section4"].ReportObjects["txtThirdApproval"]);

                        int i = 0;
                        foreach (APMemberFeedback_DetailedEntity apmf in lst)
                        {
                            //strAPStatus += (i + 1).ToString() + ". " + apmf.APFeedbackName + " ";
                            //strDash += "By -".PadRight(50) + strPadAll + "\n";
                            strEmployeeName += apmf.MemberFullName.PadRight(5) + strPadAll + "\n";
                            strEmployeeDesignation += apmf.DesignationName.PadRight(30) + strPadAll + "\n";
                            //strDate += "   Dated" + apmf.FeedbackSubmitDate.ToString(UIConstants.SHORT_DATE_FORMAT).PadRight(45) + strPadAll + "\n";

                            String _memberName = String.Empty;
                            String[] memberFullName = strEmployeeName.Split(' ');

                            foreach (string word in memberFullName)
                            {
                                if (!word.StartsWith("(") || !word.Contains(")"))
                                {
                                    _memberName += word + " ";
                                }
                            }
                            strEmployeeName = _memberName;


                            if (i == 0)
                            {
                                //txtApproval.Text += "\n" + strAPStatus;
                                //txtApproval.Text += strDash;
                                txtApproval.Text += " " + strEmployeeName;
                                txtApproval.Text += strEmployeeDesignation;
                                //txtApproval.Text += strDate;
                            }
                            else if (i == 1)
                            {
                                //txtSecondApproval.Text += "\n" + strAPStatus;
                                //txtSecondApproval.Text += strDash;
                                txtSecondApproval.Text += " " + strEmployeeName;
                                txtSecondApproval.Text += strEmployeeDesignation;
                                //txtSecondApproval.Text += strDate;
                            }
                            else
                            {
                                //txtThirdApproval.Text += "\n" + strAPStatus;
                                //     txtThirdApproval.Text += strDash;
                                txtThirdApproval.Text += " " + strEmployeeName;
                                txtThirdApproval.Text += strEmployeeDesignation;
                                //txtThirdApproval.Text += strDate;
                            }

                            strAPStatus = String.Empty;
                            strDash = String.Empty;
                            strEmployeeName = String.Empty;
                            strEmployeeDesignation = String.Empty;
                            strDate = String.Empty;
                            i++;
                        }
                    }

                    #endregion

                  

                }

                else if (Action == ReportConstants.WORK_ORDER_ITEM_FLOOR_DETAIL)
                {
                    ReportName = "WorkOrderItemFloorWise.rpt";
                    myReportDocument.Load(Server.MapPath(@"./WorkOrder/" + ReportName));
                    dt = FCCPRMWorkOrderItemFloorDetail_RPT.GetFacadeCreate().GetDT(PRMWorkOrderID);

                    //#region Work Order Appoval

                    //APApprovalProcessEntity ent = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.WORK_ORDER, PRMWorkOrderID);

                    //IList<APMemberFeedback_DetailedEntity> lst = APRobot.GetAllMemberFeedbacks_Detailed(ent.APApprovalProcessID);

                    //if (lst != null && lst.Count > 0)
                    //{
                    //    String strAPStatus = String.Empty;
                    //    String strDash = String.Empty;
                    //    String strEmployeeName = String.Empty;
                    //    String strEmployeeDesignation = String.Empty;
                    //    String strEmployeeRemarks = String.Empty;
                    //    String strDate = String.Empty;
                    //    String strPadAll = " ";

                    //    CrystalDecisions.CrystalReports.Engine.TextObject txtApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section4"].ReportObjects["txtApproval"]);
                    //    CrystalDecisions.CrystalReports.Engine.TextObject txtSecondApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section4"].ReportObjects["txtSecondApproval"]);
                    //    CrystalDecisions.CrystalReports.Engine.TextObject txtThirdApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section4"].ReportObjects["txtThirdApproval"]);

                    //    int i = 0;
                    //    foreach (APMemberFeedback_DetailedEntity apmf in lst)
                    //    {
                    //        //strAPStatus += (i + 1).ToString() + ". " + apmf.APFeedbackName + " ";
                    //        //strDash += "By -".PadRight(50) + strPadAll + "\n";
                    //        strEmployeeName += apmf.MemberFullName.PadRight(5) + strPadAll + "\n";
                    //        strEmployeeDesignation += apmf.DesignationName.PadRight(30) + strPadAll + "\n";
                    //        //strDate += "   Dated" + apmf.FeedbackSubmitDate.ToString(UIConstants.SHORT_DATE_FORMAT).PadRight(45) + strPadAll + "\n";

                    //        String _memberName = String.Empty;
                    //        String[] memberFullName = strEmployeeName.Split(' ');

                    //        foreach (string word in memberFullName)
                    //        {
                    //            if (!word.StartsWith("(") || !word.Contains(")"))
                    //            {
                    //                _memberName += word + " ";
                    //            }
                    //        }
                    //        strEmployeeName = _memberName;


                    //        if (i == 0)
                    //        {
                    //            //txtApproval.Text += "\n" + strAPStatus;
                    //            //txtApproval.Text += strDash;
                    //            txtApproval.Text += " " + strEmployeeName;
                    //            txtApproval.Text += strEmployeeDesignation;
                    //            //txtApproval.Text += strDate;
                    //        }
                    //        else if (i == 1)
                    //        {
                    //            //txtSecondApproval.Text += "\n" + strAPStatus;
                    //            //txtSecondApproval.Text += strDash;
                    //            txtSecondApproval.Text += " " + strEmployeeName;
                    //            txtSecondApproval.Text += strEmployeeDesignation;
                    //            //txtSecondApproval.Text += strDate;
                    //        }
                    //        else
                    //        {
                    //            //txtThirdApproval.Text += "\n" + strAPStatus;
                    //            //     txtThirdApproval.Text += strDash;
                    //            txtThirdApproval.Text += " " + strEmployeeName;
                    //            txtThirdApproval.Text += strEmployeeDesignation;
                    //            //txtThirdApproval.Text += strDate;
                    //        }

                    //        strAPStatus = String.Empty;
                    //        strDash = String.Empty;
                    //        strEmployeeName = String.Empty;
                    //        strEmployeeDesignation = String.Empty;
                    //        strDate = String.Empty;
                    //        i++;
                    //    }
                    //}

                    //#endregion



                }

                else if (Action ==  ReportConstants.WORK_ORDER_REPORT)
                {
                    ReportName = "WorkOrder.rpt";
                    myReportDocument.Load(Server.MapPath(@"./WorkOrder/" + ReportName));

                    dt = FCCPRMWorkOrder_RPT.GetFacadeCreate().GetDT(PRMWorkOrderID);

                    DataTable dtWOPaymentTermSubReport = FCCPRMWorkOrderPaymentTerm_RPT.GetFacadeCreate().GetDT(PRMWorkOrderID);
                    myReportDocument.Subreports[0].DataSourceConnections.Clear();
                    myReportDocument.Subreports[0].SetDataSource(dtWOPaymentTermSubReport);

                    #region Work Order Appoval

                    APApprovalProcessEntity ent = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.WORK_ORDER, PRMWorkOrderID);

                    IList<APMemberFeedback_DetailedEntity> lst = APRobot.GetAllMemberFeedbacks_Detailed(ent.APApprovalProcessID);

                    if (lst != null && lst.Count > 0)
                    {
                        String strAPStatus = String.Empty;
                        String strDash = String.Empty;
                        String strEmployeeName = String.Empty;
                        String strEmployeeDesignation = String.Empty;
                        String strEmployeeRemarks = String.Empty;
                        String strDate = String.Empty;
                        String strPadAll = " ";

                        CrystalDecisions.CrystalReports.Engine.TextObject txtApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["secPageFooter"].ReportObjects["txtApproval"]);
                        CrystalDecisions.CrystalReports.Engine.TextObject txtSecondApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["secPageFooter"].ReportObjects["txtSecondApproval"]);
                        CrystalDecisions.CrystalReports.Engine.TextObject txtThirdApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["secPageFooter"].ReportObjects["txtThirdApproval"]);
                        
                        int i = 0;
                        //foreach (APMemberFeedback_DetailedEntity apmf in lst)
                        //{
                            //strAPStatus += apmf.APFeedbackName + " ";
                        strEmployeeName = lst[lst.Count-1].MemberFullName+ "\n";
                        strEmployeeDesignation = lst[lst.Count - 1].DesignationName + "\n";
                        strDate += "   Dated" + lst[lst.Count - 1].FeedbackSubmitDate.ToString(UIConstants.SHORT_DATE_FORMAT).PadRight(45) + strPadAll + "\n";

                            String _memberName = String.Empty;
                            String[] memberFullName = strEmployeeName.Split(' ');

                            foreach (string word in memberFullName)
                            {
                                if (!word.StartsWith("(") || !word.Contains(")"))
                                {
                                    _memberName += word+" ";
                                }
                            }
                            strEmployeeName = _memberName;
                            

                            //if (i == 0)
                            //{
                               // txtApproval.Text += "\n" + strAPStatus;
                               // txtApproval.Text += strDash;
                                txtApproval.Text += strEmployeeName;
                                txtApproval.Text += strEmployeeDesignation.TrimStart();
                                //txtApproval.Text += strDate;
                            //}
                           // else if (i == 1)
                           // {
                           //     //txtSecondApproval.Text += "\n" + strAPStatus;
                           //  //   txtSecondApproval.Text += strDash;
                           //     txtSecondApproval.Text += " " + strEmployeeName;
                           //     txtSecondApproval.Text += strEmployeeDesignation;
                           //     //txtSecondApproval.Text += strDate;
                           // }
                           // else 
                           // {
                           //     //txtThirdApproval.Text += "\n" + strAPStatus;
                           ////     txtThirdApproval.Text += strDash;
                           //     txtThirdApproval.Text += " " + strEmployeeName;
                           //     txtThirdApproval.Text += strEmployeeDesignation;
                           //     //txtThirdApproval.Text += strDate;
                           // }

                            strAPStatus = String.Empty;
                            strDash = String.Empty;
                            strEmployeeName = String.Empty;
                            strEmployeeDesignation = String.Empty;
                            strDate = String.Empty;
                            i++;

                            txtSecondApproval.Border.BorderColor = System.Drawing.Color.White;
                            txtThirdApproval.Border.BorderColor = System.Drawing.Color.White;
                        }
                        //switch (i)
                        //{
                        //    case 1:
                        //        txtSecondApproval.Border.BorderColor = System.Drawing.Color.White;
                        //        txtThirdApproval.Border.BorderColor = System.Drawing.Color.White;
                        //        break;
                        //    case 2:
                        //        txtThirdApproval.Border.BorderColor = System.Drawing.Color.White;
                        //        break;
                            
                        //}

                    //}
                    
                    #region Previous Code

                    //String strAPStatus = String.Empty;
                    //String strDash = String.Empty;
                    //String strEmployeeName = String.Empty;
                    //String strEmployeeDesignation = String.Empty;
                    //String strEmployeeRemarks = String.Empty;
                    //String strDate = String.Empty;
                    //String strPadAll = "     ";

                    //if (lst != null && lst.Count > 0)
                    //{
                    //    if (lst[lst.Count - 1].APFeedbackID == MasterDataConstants.APFeedback.APPROVED)
                    //    {
                    //    CrystalDecisions.CrystalReports.Engine.TextObject txtApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["secPageFooter"].ReportObjects["txtApproval"]);

                    //        String _memberName = String.Empty;
                    //        String[] memberFullName = lst[lst.Count - 1].MemberFullName.Split(' ');

                    //        foreach (string word in memberFullName)
                    //        {
                    //            if (!word.StartsWith("(") || !word.Contains(")"))
                    //            {
                    //                _memberName += word + " ";
                    //            }
                    //        }
                    //        lst[lst.Count - 1].MemberFullName = _memberName;

                    //    strEmployeeName += "\n   " + lst[lst.Count - 1].MemberFullName+ "\n";
                    //    strEmployeeDesignation += "   " + lst[lst.Count - 1].DesignationName+ "\n";
                        
                    //    txtApproval.Text += strEmployeeName;
                    //    txtApproval.Text += strEmployeeDesignation;
                    //    }
                    //}
                    #endregion

                    #endregion
                }


                else if (Action == ReportConstants.MATERIAL_RECEIVE_REPORT)
                {
                    ReportName = "MaterialReceive.rpt";
                    myReportDocument.Load(Server.MapPath(@"./WorkOrder/" + ReportName));
                    dt = FCCPRMMaterialReceive_RPT.GetFacadeCreate().GetDT(PRMMaterialReceiveID);

                    #region Approval

                    APApprovalProcessEntity ent = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.MRR, PRMMaterialReceiveID);

                    IList<APMemberFeedback_DetailedEntity> lst = APRobot.GetAllMemberFeedbacks_Detailed(ent.APApprovalProcessID);

                    String strAPStatus = String.Empty;
                    String strDash = String.Empty;
                    String strEmployeeName = String.Empty;
                    String strEmployeeDesignation = String.Empty;
                    String strEmployeeRemarks = String.Empty;
                    String strDate = String.Empty;
                    String strPadAll = "     ";

                    CrystalDecisions.CrystalReports.Engine.TextObject txtApprovalStatus = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["sectionFooter"].ReportObjects["txtApprovalStatus"]);
                    CrystalDecisions.CrystalReports.Engine.TextObject txtSecondApprovalPanel = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["sectionFooter"].ReportObjects["txtSecondApprovalPanel"]);

                    if (lst != null && lst.Count > 0)
                    {
                        int i = 0;
                        foreach (APMemberFeedback_DetailedEntity apmf in lst)
                        {
                            strEmployeeName += (i + 1).ToString() + ". " + apmf.MemberFullName.PadRight(35) + strPadAll + "\n";
                            strEmployeeDesignation += "    " + apmf.DesignationName.PadRight(30) + strPadAll + "\n";
                            strAPStatus += "    (" + apmf.APFeedbackName + ")";
                            strDate += " Dt: " + apmf.FeedbackSubmitDate.ToString(UIConstants.SHORT_DATE_FORMAT).PadRight(45) + strPadAll + "\n";
                            //strDash += "".PadRight(50) + strPadAll + " ]";


                            if (i <= 1)
                            {
                                txtApprovalStatus.Text += strEmployeeName;
                                txtApprovalStatus.Text += strEmployeeDesignation;
                                txtApprovalStatus.Text += strAPStatus;
                                //txtApprovalStatus.Text += strDash;
                                txtApprovalStatus.Text += strDate + "\n";
                            }
                            else
                            {
                                txtSecondApprovalPanel.Text += strEmployeeName;
                                txtSecondApprovalPanel.Text += strEmployeeDesignation;
                                txtSecondApprovalPanel.Text += strAPStatus;
                                //txtSecondApprovalPanel.Text += strDash;
                                txtSecondApprovalPanel.Text += strDate + "\n";
                            }

                            strAPStatus = String.Empty;
                            strDash = String.Empty;
                            strEmployeeName = String.Empty;
                            strEmployeeDesignation = String.Empty;
                            strDate = String.Empty;
                            i++;
                        }
                    }

                    #endregion
                }

                else if (Action == ReportConstants.BILL_REPORT)
                {
                    ReportName = "Bill.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Bill/" + ReportName));
                    dt = FCCCMBill_RPT.GetFacadeCreate().GetDT(CMBillID);

                    #region Work Order Appoval

                    APApprovalProcessEntity ent = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.BILL, CMBillID);

                    IList<APMemberFeedback_DetailedEntity> lst = APRobot.GetAllMemberFeedbacks_Detailed(ent.APApprovalProcessID);

                    if (lst != null && lst.Count > 0)
                    {
                        String strAPStatus = String.Empty;
                        String strDash = String.Empty;
                        String strEmployeeName = String.Empty;
                        String strEmployeeDesignation = String.Empty;
                        String strEmployeeRemarks = String.Empty;
                        String strDate = String.Empty;
                        String strPadAll = " ";

                        CrystalDecisions.CrystalReports.Engine.TextObject txtApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section5"].ReportObjects["txtApproval"]);
                        CrystalDecisions.CrystalReports.Engine.TextObject txtSecondApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section5"].ReportObjects["txtSecondApproval"]);
                        CrystalDecisions.CrystalReports.Engine.TextObject txtThirdApproval = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section5"].ReportObjects["txtThirdApproval"]);

                        int i = 0;
                        foreach (APMemberFeedback_DetailedEntity apmf in lst)
                        {
                            //strAPStatus += (i + 1).ToString() + ". " + apmf.APFeedbackName + " ";
                            //strDash += "By -".PadRight(50) + strPadAll + "\n";
                            strEmployeeName += apmf.MemberFullName.PadRight(5) + strPadAll + "\n";
                            strEmployeeDesignation += apmf.DesignationName.PadRight(30) + strPadAll + "\n";
                            //strDate += "   Dated" + apmf.FeedbackSubmitDate.ToString(UIConstants.SHORT_DATE_FORMAT).PadRight(45) + strPadAll + "\n";

                            String _memberName = String.Empty;
                            String[] memberFullName = strEmployeeName.Split(' ');

                            foreach (string word in memberFullName)
                            {
                                if (!word.StartsWith("(") || !word.Contains(")"))
                                {
                                    _memberName += word + " ";
                                }
                            }
                            strEmployeeName = _memberName;


                            if (i == 0)
                            {
                                //txtApproval.Text += "\n" + strAPStatus;
                                //txtApproval.Text += strDash;
                                txtApproval.Text += " " + strEmployeeName;
                                txtApproval.Text += strEmployeeDesignation;
                                //txtApproval.Text += strDate;
                            }
                            else if (i == 1)
                            {
                                //txtSecondApproval.Text += "\n" + strAPStatus;
                                //txtSecondApproval.Text += strDash;
                                txtSecondApproval.Text += " " + strEmployeeName;
                                txtSecondApproval.Text += strEmployeeDesignation;
                                //txtSecondApproval.Text += strDate;
                            }
                            else
                            {
                                //txtThirdApproval.Text += "\n" + strAPStatus;
                                //     txtThirdApproval.Text += strDash;
                                txtThirdApproval.Text += " " + strEmployeeName;
                                txtThirdApproval.Text += strEmployeeDesignation;
                                //txtThirdApproval.Text += strDate;
                            }

                            strAPStatus = String.Empty;
                            strDash = String.Empty;
                            strEmployeeName = String.Empty;
                            strEmployeeDesignation = String.Empty;
                            strDate = String.Empty;
                            i++;
                        }
                    }

                    #endregion


                }

                else if (Action == ReportConstants.POST_PAYABLE_REPORT)
                {
                    ReportName = "PayableStatement.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Accounts/" + ReportName));
                    dt = FCCACCPostPayableStatement_RPT.GetFacadeCreate().GetDT(ACCPostPayableStatementID);
                }

                else if (Action == ReportConstants.PRE_PAYABLE_REPORT)
                {
                    ReportName = "PrePayableStatement.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Accounts/" + ReportName));
                    dt = FCCACCPrePayableStatement_RPT.GetFacadeCreate().GetDT(ACCPrePayableStatementID);
                    btnGeneratePayable.Visible = true;
                }

                else if (Action == ReportConstants.TRIAL_BALANCE_REPORT)
                {
                    ReportName = "TrialBalance.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Accounts/" + ReportName));
                    dt = FCCACTrialBalance_Custom.GetFacadeCreate().GetDT(ACTrialBalanceFromDate, ACTrialBalanceToDate, ACTrialBalanceActiveFiscalYearID);

                    CrystalDecisions.CrystalReports.Engine.TextObject txtFiscalYear = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section1"].ReportObjects["txtFiscalYear"]);
                    CrystalDecisions.CrystalReports.Engine.TextObject txtPeriod = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section1"].ReportObjects["txtPeriod"]);

                    txtPeriod.Text = ACTrialBalanceFromDate.ToString(UIConstants.SHORT_DATE_FORMAT) + " to " + ACTrialBalanceToDate.ToString(UIConstants.SHORT_DATE_FORMAT);

                    ACFiscalYearEntity acFiscalYearEntity = FCCACFiscalYear.GetFacadeCreate().GetByID(ACTrialBalanceActiveFiscalYearID);

                    if (acFiscalYearEntity != null && acFiscalYearEntity.FiscalYearID > 0)
                    {
                        txtFiscalYear.Text = acFiscalYearEntity.BeginDate.ToString(UIConstants.SHORT_DATE_FORMAT) + " to " + acFiscalYearEntity.EndDate.ToString(UIConstants.SHORT_DATE_FORMAT) + "(Active)";
                    }


                    DataTable dtFiscalYearBalance = FCCACTrialBalanceForActiveFiscalYear_RPT.GetFacadeCreate().GetDT(ACTrialBalanceActiveFiscalYearID);

                    myReportDocument.Database.Tables["ACTrialBalanceForActiveFiscalYear_RPT"].SetDataSource(dtFiscalYearBalance);
                }

                else if (Action == ReportConstants.BALANCE_SHEET_REPORT)
                {
                    ReportName = "BalanceSheet.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Accounts/" + ReportName));
                    dt = FCCACBalanceSheet_RPT.GetFacadeCreate().GetDT(ACBalanceSheetActiveFiscalYearID,ACBalanceSheetFromDate, ACBalanceSheetToDate);

                    CrystalDecisions.CrystalReports.Engine.TextObject txtFiscalYear = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section1"].ReportObjects["txtFiscalYear"]);
                    CrystalDecisions.CrystalReports.Engine.TextObject txtPeriod = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section1"].ReportObjects["txtPeriod"]);

                    txtPeriod.Text = ACBalanceSheetFromDate.ToString(UIConstants.SHORT_DATE_FORMAT) + " to " + ACBalanceSheetToDate.ToString(UIConstants.SHORT_DATE_FORMAT);

                    ACFiscalYearEntity acFiscalYearEntity = FCCACFiscalYear.GetFacadeCreate().GetByID(ACBalanceSheetActiveFiscalYearID);

                    if (acFiscalYearEntity != null && acFiscalYearEntity.FiscalYearID > 0)
                    {
                        txtFiscalYear.Text = acFiscalYearEntity.BeginDate.ToString(UIConstants.SHORT_DATE_FORMAT) + " to " + acFiscalYearEntity.EndDate.ToString(UIConstants.SHORT_DATE_FORMAT) + "(Active)";
                    }
                }

                else if (Action == ReportConstants.BANK_ACCOUNT_DEPOSIT_REPORT)
                {
                    ReportName = "BankCreditVoucher.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Accounts/" + ReportName));
                    dt = FCCACBankAccountDeposit_RPT.GetFacadeCreate().GetDT(ACBankAccountDepositID);

                    #region Approval

                    APApprovalProcessEntity ent = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.BANK_DEPOSIT, ACBankAccountDepositID);

                    IList<APMemberFeedback_DetailedEntity> lst = APRobot.GetAllMemberFeedbacks_Detailed(ent.APApprovalProcessID);

                    String strAPStatus = String.Empty;
                    String strDash = String.Empty;
                    String strEmployeeName = String.Empty;
                    String strEmployeeDesignation = String.Empty;
                    String strEmployeeRemarks = String.Empty;
                    String strDate = String.Empty;
                    String strPadAll = "     ";

                    CrystalDecisions.CrystalReports.Engine.TextObject txtApprovalStatus = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["sectionFooter"].ReportObjects["txtApprovalStatus"]);
                    CrystalDecisions.CrystalReports.Engine.TextObject txtSecondApprovalPanel = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["sectionFooter"].ReportObjects["txtSecondApprovalPanel"]);

                    if (lst != null && lst.Count > 0)
                    {
                        int i = 0;
                        foreach (APMemberFeedback_DetailedEntity apmf in lst)
                        {
                            strEmployeeName += (i + 1).ToString() + ". " + apmf.MemberFullName.PadRight(35) + strPadAll + "\n";
                            strEmployeeDesignation += "    " + apmf.DesignationName.PadRight(30) + strPadAll + "\n";
                            strAPStatus += "    (" + apmf.APFeedbackName + ")";
                            strDate += " Dt: " + apmf.FeedbackSubmitDate.ToString(UIConstants.SHORT_DATE_FORMAT).PadRight(45) + strPadAll + "\n";
                            //strDash += "".PadRight(50) + strPadAll + " ]";


                            if (i <= 1)
                            {
                                txtApprovalStatus.Text += strEmployeeName;
                                txtApprovalStatus.Text += strEmployeeDesignation;
                                txtApprovalStatus.Text += strAPStatus;
                                //txtApprovalStatus.Text += strDash;
                                txtApprovalStatus.Text += strDate + "\n";
                            }
                            else
                            {
                                txtSecondApprovalPanel.Text += strEmployeeName;
                                txtSecondApprovalPanel.Text += strEmployeeDesignation;
                                txtSecondApprovalPanel.Text += strAPStatus;
                                //txtSecondApprovalPanel.Text += strDash;
                                txtSecondApprovalPanel.Text += strDate + "\n";
                            }

                            strAPStatus = String.Empty;
                            strDash = String.Empty;
                            strEmployeeName = String.Empty;
                            strEmployeeDesignation = String.Empty;
                            strDate = String.Empty;
                            i++;
                        }
                    }

                    #endregion
                }

                else if (Action == ReportConstants.BANK_ACCOUNT_PAYMENT_REPORT)
                {
                    ReportName = "BankDebitVoucher.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Accounts/" + ReportName));
                    dt = FCCACBankAccountPayment_RPT.GetFacadeCreate().GetDT(ACBankAccountPaymentID);
                    CrystalDecisions.CrystalReports.Engine.TextObject txtDebitVoucher = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["Section1"].ReportObjects["txtDebitVoucher"]);
                    IList<ACBankAccountPayment_RPTEntity> lstA = FCCACBankAccountPayment_RPT.GetFacadeCreate().GetIL(ACBankAccountPaymentID);
                    foreach(ACBankAccountPayment_RPTEntity entA in lstA)
                    {
                        if (entA.BankAccountPaymentID == ACBankAccountPaymentID)
                        {
                            if(entA.BankAccountID == 3)
                            {
                                txtDebitVoucher.Text = "CASH DEBIT VOUCHER";
                            }
                            else
                            {
                                txtDebitVoucher.Text = "BANK DEBIT VOUCHER";
                            }
                        }

                    }


                    #region Approval

                    APApprovalProcessEntity ent = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.BANK_PAYMENT, ACBankAccountPaymentID);

                    IList<APMemberFeedback_DetailedEntity> lst = APRobot.GetAllMemberFeedbacks_Detailed(ent.APApprovalProcessID);

                    String strAPStatus = String.Empty;
                    String strDash = String.Empty;
                    String strEmployeeName = String.Empty;
                    String strEmployeeDesignation = String.Empty;
                    String strEmployeeRemarks = String.Empty;
                    String strDate = String.Empty;
                    String strPadAll = "     ";

                    CrystalDecisions.CrystalReports.Engine.TextObject txtApprovalStatus = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["sectionFooter"].ReportObjects["txtApprovalStatus"]);
                    CrystalDecisions.CrystalReports.Engine.TextObject txtSecondApprovalPanel = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["sectionFooter"].ReportObjects["txtSecondApprovalPanel"]);

                    if (lst != null && lst.Count > 0)
                    {
                        int i = 0;
                        foreach (APMemberFeedback_DetailedEntity apmf in lst)
                        {
                            strEmployeeName += (i + 1).ToString() + ". " + apmf.MemberFullName.PadRight(35) + strPadAll + "\n";
                            strEmployeeDesignation += "    " + apmf.DesignationName.PadRight(30) + strPadAll + "\n";
                            strAPStatus += "    (" + apmf.APFeedbackName + ")";
                            strDate += " Dt: " + apmf.FeedbackSubmitDate.ToString(UIConstants.SHORT_DATE_FORMAT).PadRight(45) + strPadAll + "\n";
                            //strDash += "".PadRight(50) + strPadAll + " ]";


                            if (i <= 1)
                            {
                                txtApprovalStatus.Text += strEmployeeName;
                                txtApprovalStatus.Text += strEmployeeDesignation;
                                txtApprovalStatus.Text += strAPStatus;
                                //txtApprovalStatus.Text += strDash;
                                txtApprovalStatus.Text += strDate + "\n";
                            }
                            else
                            {
                                txtSecondApprovalPanel.Text += strEmployeeName;
                                txtSecondApprovalPanel.Text += strEmployeeDesignation;
                                txtSecondApprovalPanel.Text += strAPStatus;
                                //txtSecondApprovalPanel.Text += strDash;
                                txtSecondApprovalPanel.Text += strDate + "\n";
                            }

                            strAPStatus = String.Empty;
                            strDash = String.Empty;
                            strEmployeeName = String.Empty;
                            strEmployeeDesignation = String.Empty;
                            strDate = String.Empty;
                            i++;
                        }
                    }

                    #endregion
                }

                else if (Action == ReportConstants.MANUAL_JOURNAL_REPORT)
                {
                    ReportName = "JournalEntry.rpt";
                    myReportDocument.Load(Server.MapPath(@"./Accounts/" + ReportName));
                    dt = FCCACTemporaryJournal_RPT.GetFacadeCreate().GetDT(ACTemporaryJournalID);

                    #region Approval

                    APApprovalProcessEntity ent = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.TEMPORARY_JOURNAL, ACTemporaryJournalID);

                    IList<APMemberFeedback_DetailedEntity> lst = APRobot.GetAllMemberFeedbacks_Detailed(ent.APApprovalProcessID);

                    String strAPStatus = String.Empty;
                    String strDash = String.Empty;
                    String strEmployeeName = String.Empty;
                    String strEmployeeDesignation = String.Empty;
                    String strEmployeeRemarks = String.Empty;
                    String strDate = String.Empty;
                    String strPadAll = "     ";

                    CrystalDecisions.CrystalReports.Engine.TextObject txtApprovalStatus = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["sectionFooter"].ReportObjects["txtApprovalStatus"]);
                    CrystalDecisions.CrystalReports.Engine.TextObject txtSecondApprovalPanel = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["sectionFooter"].ReportObjects["txtSecondApprovalPanel"]);

                    if (lst != null && lst.Count > 0)
                    {
                        int i = 0;
                        foreach (APMemberFeedback_DetailedEntity apmf in lst)
                        {
                            strEmployeeName += (i + 1).ToString() + ". " + apmf.MemberFullName.PadRight(35) + strPadAll + "\n";
                            strEmployeeDesignation += "    " + apmf.DesignationName.PadRight(30) + strPadAll + "\n";
                            strAPStatus += "    (" + apmf.APFeedbackName + ")";
                            strDate += " Dt: " + apmf.FeedbackSubmitDate.ToString(UIConstants.SHORT_DATE_FORMAT).PadRight(45) + strPadAll + "\n";
                            //strDash += "".PadRight(50) + strPadAll + " ]";


                            if (i <= 1)
                            {
                                txtApprovalStatus.Text += strEmployeeName;
                                txtApprovalStatus.Text += strEmployeeDesignation;
                                txtApprovalStatus.Text += strAPStatus;
                                //txtApprovalStatus.Text += strDash;
                                txtApprovalStatus.Text += strDate + "\n";
                            }
                            else
                            {
                                txtSecondApprovalPanel.Text += strEmployeeName;
                                txtSecondApprovalPanel.Text += strEmployeeDesignation;
                                txtSecondApprovalPanel.Text += strAPStatus;
                                //txtSecondApprovalPanel.Text += strDash;
                                txtSecondApprovalPanel.Text += strDate + "\n";
                            }

                            strAPStatus = String.Empty;
                            strDash = String.Empty;
                            strEmployeeName = String.Empty;
                            strEmployeeDesignation = String.Empty;
                            strDate = String.Empty;
                            i++;
                        }
                    }

                    #endregion
                }

                else if (Action == ReportConstants.AGREEMENT_REPORT)
                {
                    ReportName = "Agreement.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCCRMAgreement_RPT.GetFacadeCreate().GetDT(CRMAgreementID);
                }

                else if (Action == ReportConstants.PAYMENT_SCHEDULE_REPORT)
                {
                    ReportName = "PaymentSchedule.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCCRMPaymentSchedule_RPT.GetFacadeCreate().GetDT(CRMPaymentScheduleID);
                }

                else if (Action == ReportConstants.MONEY_RECEIPT_REPORT)
                {
                    ReportName = "MoneyReceipt.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCCRMPaymentCollectionMoneyRecipt_RPT.GetFacadeCreate().GetDT(CRMPaymentCollectionID);
                }

                else if (Action == ReportConstants.PAYMENT_COLLECTION_REPORT)
                {
                    ReportName = "PaymentCollection.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCCRMPaymentCollection_RPT.GetFacadeCreate().GetDT(CRMPaymentScheduleID);

                    CRMPaymentScheduleEntity cRMPaymentScheduleEntity = FCCCRMPaymentSchedule.GetFacadeCreate().GetByID(CRMPaymentScheduleID);
                    //IList<CRMPaymentSchedule_RPTEntity> list = FCCCRMPaymentSchedule_RPT.GetFacadeCreate().GetIL(CRMPaymentScheduleID);

                    //foreach (CRMPaymentSchedule_RPTEntity ent in list)
                    //{
                    //    if (ent != null && ent.PaymentScheduleID > 0)
                    //    {
                    //        DataTable dtCustomerPortfolioSummarySubReport = FCCCRMCustomerPortfolioSummary_RPT.GetFacadeCreate().GetDT(ent.BuyerBasicInfoID, ent.ProjectFloorUnitID);
                    //        myReportDocument.Subreports[0].DataSourceConnections.Clear();
                    //        myReportDocument.Subreports[0].SetDataSource(dtCustomerPortfolioSummarySubReport);
                    //    }
                    //}
                    //if (cRMPaymentScheduleEntity != null && cRMPaymentScheduleEntity.PaymentScheduleID > 0)
                    //{

                    //    CRMAgreementEntity cRMAgreementEntity = FCCCRMAgreement.GetFacadeCreate().GetByID(Int64.Parse(cRMPaymentScheduleEntity.PaymentScheduleID.ToString()));

                    //    if (cRMPaymentScheduleEntity != null && cRMPaymentScheduleEntity.PaymentScheduleID > 0)
                    //    {
                    //        DataTable dtCustomerPortfolioSummarySubReport = FCCCRMCustomerPortfolioSummary_RPT.GetFacadeCreate().GetDT(cRMPaymentScheduleEntity.BuyerBasicInfoID, cRMPaymentScheduleEntity.);
                    //        myReportDocument.Subreports[0].DataSourceConnections.Clear();
                    //        myReportDocument.Subreports[0].SetDataSource(dtCustomerPortfolioSummarySubReport);
                    //    }
                    //}

                }

                else if (Action == ReportConstants.DUE_PAYMENT_SCHEDULE_REPORT)
                {
                    ReportName = "DuePayment.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCCRMDuePaymentFromPaymentSchedule_RPT.GetFacadeCreate().GetDT(CRMDuePaymentScheduleToDate);
                }
                else if (Action == ReportConstants.FLOOR_UNIT_BOOKING_REPORT)
                {
                    ReportName = "BookingStatus.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCCRMBookingStatus_RPT.GetFacadeCreate().GetDT();
                }
                else if (Action == ReportConstants.PROJECT_FLOOR_UNIT_STATUS_WISE_REPORT)
                {
                    ReportName = "ProjectStatusWiseFloorUnit.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCBDProjectStatusWiseFloorUnit_RPT.GetFacadeCreate().GetDT(MasterDataConstants.MDProjectFloorUnitStatus.AVAILABLE);

                    //Available status will not effect to the query.
                }

                else if (Action == ReportConstants.ENCASHED_REPORT)
                {
                    ReportName = "Encashed.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCCRMPaymentEncashed_RPT.GetFacadeCreate().GetDT(CRMEncashedToDate,IsEncashed);
                }

                else if (Action == ReportConstants.ISSUE_DATEWISE_REPORT)
                {
                    ReportName = "IssueDatewise.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/Issue/" + ReportName));
                    dt = FCCOTIssueDateWise_RPT.GetFacadeCreate().GetDT(OTIssueFromDate,OTIssueToDate);
                }

                else if (Action == ReportConstants.ISSUE_EMPLOYEE_AND_DATEWISE_REPORT)
                {
                    ReportName = "IssueWithEmployeeAndDate.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/Issue/" + ReportName));
                    dt = FCCOTIssueWithEmployeeandDateWise_RPT.GetFacadeCreate().GetDT(OTIssueFromDate,OTIssueToDate,overviewEmployeeID);
                }

                else if (Action == ReportConstants.ENVELOP_REPORT)
                {
                    ReportName = "Envelope.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCBDProcessAssignedResourceMap_RPT.GetFacadeCreate().GetDT(BDAssignedResourceMapID);
                }

                else if (Action == ReportConstants.CHART_OF_ACCOUNTS_REPORT)
                {
                    ReportName = "Accounts.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/Accounts/" + ReportName));
                    dt = FCCACAccount_RPT.GetFacadeCreate().GetDT();
                }

                else if (Action == ReportConstants.LEGEL_ENVELOP_REPORT )
                {
                    ReportName = "LegalEnvelop.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCBDProcessAssignedResourceMap_RPT.GetFacadeCreate().GetDT(BDAssignedResourceMapID);
                }

                else if (Action == ReportConstants.LARGE_ENVELOP_REPORT)
                {
                    ReportName = "LargeEnvelop.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCBDProcessAssignedResourceMap_RPT.GetFacadeCreate().GetDT(BDAssignedResourceMapID);
                }

                else if (Action == ReportConstants.TRANSMISSION_SHEET_REPORT)
                {
                    ReportName = "TransmissionSheet.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCBDProcessAssignedResourceMap_RPT.GetFacadeCreate().GetDT(BDAssignedResourceMapID);
                }

                else if (Action == ReportConstants.SURVEY_REPORT)
                {
                    ReportName = "Survey.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCCRMSurvey_RPT.GetFacadeCreate().GetDT(CRMSurveyOwnerID);
                }

                else if (Action == ReportConstants.SURVEY_MASTER_REPORT)
                {
                    ReportName = "SurveyMaster.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/CRM/" + ReportName));
                    dt = FCCCRMSurveyMaster_RPT.GetFacadeCreate().GetDT(CRMSurveyMasterID);
                }

                else if (Action == ReportConstants.BANK_ACCOUNT_DEPOSIT_REGISTER_REPORT)
                {
                    
                    ReportName = "BankAccountDepositRegister.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/Accounts/" + ReportName));
                    dt = FCCACBankAccountDepositDateWise_RPT.GetFacadeCreate().GetDT(ACRegisterFromDate, ACRegisterToDate);

                    CrystalDecisions.CrystalReports.Engine.TextObject txtDateInfo = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["secReportHeader"].ReportObjects["txtDateInfo"]);
                    txtDateInfo.Text = "Session : " + ACRegisterFromDate.ToString(UIConstants.SHORT_DATE_FORMAT) + " to " + ACRegisterToDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                }
                else if (Action == ReportConstants.BANK_ACCOUNT_PAYMENT_REGISTER_REPORT)
                {
                    
                    ReportName = "BankAccountPaymentRegister.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/Accounts/" + ReportName));
                    dt = FCCACBankAccountPaymentDateWise_RPT.GetFacadeCreate().GetDT(ACRegisterFromDate,ACRegisterToDate);

                    CrystalDecisions.CrystalReports.Engine.TextObject txtDateInfo = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["secReportHeader"].ReportObjects["txtDateInfo"]);
                    txtDateInfo.Text = "Session : " + ACRegisterFromDate.ToString(UIConstants.SHORT_DATE_FORMAT) + " to " + ACRegisterToDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                    
                }
                else if (Action == ReportConstants.TEMPORARY_JOURNAL_REGISTER_REPORT)
                {
                    ReportName = "JournalRegister.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/Accounts/" + ReportName));
                    dt = FCCACTemporaryJournalDateWise_RPT.GetFacadeCreate().GetDT(ACRegisterFromDate, ACRegisterToDate);

                    CrystalDecisions.CrystalReports.Engine.TextObject txtDateInfo = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["secReportHeader"].ReportObjects["txtDateInfo"]);
                    txtDateInfo.Text = "Session : " + ACRegisterFromDate.ToString(UIConstants.SHORT_DATE_FORMAT) + " to " + ACRegisterToDate.ToString(UIConstants.SHORT_DATE_FORMAT);

                }
                else if (Action == ReportConstants.DAY_BOOK_REPORT)
                {
                    ReportName = "DayBookRegister.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/Accounts/" + ReportName));
                    dt = FCCACDayBookJournalDateWise_RPT.GetFacadeCreate().GetDT(ACRegisterFromDate, ACRegisterToDate);

                    CrystalDecisions.CrystalReports.Engine.TextObject txtDateInfo = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["secReportHeader"].ReportObjects["txtDateInfo"]);
                    txtDateInfo.Text = "Session : " + ACRegisterFromDate.ToString(UIConstants.SHORT_DATE_FORMAT) + " to " + ACRegisterToDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                }

                else if (Action == ReportConstants.CASH_PAYMENT_REGISTER_REPORT)
                {   
                    ReportName = "CashPaymentRegister.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/Accounts/" + ReportName));
                    dt = FCCACCashPaymentDateWise_RPT.GetFacadeCreate().GetDT(ACRegisterFromDate, ACRegisterToDate);

                    CrystalDecisions.CrystalReports.Engine.TextObject txtDateInfo = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["secReportHeader"].ReportObjects["txtDateInfo"]);
                    txtDateInfo.Text = "Session : " + ACRegisterFromDate.ToString(UIConstants.SHORT_DATE_FORMAT) + " to " + ACRegisterToDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                }

                else if (Action == ReportConstants.PROJECT_FLOOR_WISE_COST_REPORT)
                {
                    ReportName = "ProjectFloorwise.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/Project/" + ReportName));
                    dt = FCCBDFloorWiseWOBillDetail_RPT.GetFacadeCreate().GetDT(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_FILTER_EXPRESSION_FLOOR_WISE_COST]);
                }

                else if (Action == ReportConstants.WEEKLY_DTL_INDIVIDUAL_REPORT)
                {
                    ReportName = "DTLWeeklyIndividual.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/Issue/" + ReportName));
                    dt = FCCOTIssueCategoryWiseIndividual_RPT.GetFacadeCreate().GetDT(OTIssueFromDate, OTIssueToDate, overviewEmployeeID);
                }
                else if (Action == ReportConstants.HR_DTL_SUBMISSION_REPORT)
                {
                    ReportName = "DTLSubmission.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));
                    dt = FCCHRDTLSubmission_RPT.GetFacadeCreate().GetDT(OTIssueFromDate, OTIssueToDate);
                }

                else if (Action == ReportConstants.HR_EMPLOYEE_EVALUATION_REPORT)
                {
                    ReportName = "EmployeeEvaluation.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));
                    dt = FCCHREvaluation_RPT.GetFacadeCreate().GetDT(HRSessionEvaluationEmployeeID,HRSessionID);
                }

                else if (Action == ReportConstants.HR_EMPLOYEE_EVALUATIONREPORT_REPORT)
                {
                    ReportName = "HRReport.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));
                    dt = FCCHREmployeeEvaluationReport_RPT.GetFacadeCreate().GetDT(HRSessionEvaluationEmployeeID, HRSessionID);
                }

                else if (Action == ReportConstants.HR_EMPLOYEE_EVALUATIONREPORT_REPORT_FOR_ALL_EMPLOYEE)
                {
                    ReportName = "HREmployeeEvaluationReportForAllEmployee.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));
                    dt = FCCHREmployeeEvaluationReportForAllEmployee_RPT.GetFacadeCreate().GetDT(HRSessionID);
                }

                else if (Action == ReportConstants.HR_TIME_SHEET)
                {
                    ReportName = "HREmployeeTimeSheet.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));
                    dt = FCCHREmployeeTimeSheet_RPT.GetFacadeCreate().GetDT(4,20);

                    DataTable dtWorkingDays = FCCHRWorkingDay_RPT.GetFacadeCreate().GetDT(OverviewHRSalarySessionID);
                    myReportDocument.Subreports[0].DataSourceConnections.Clear();
                    myReportDocument.Subreports[0].SetDataSource(dtWorkingDays);

                }

                else if (Action == ReportConstants.HR_EMPLOYEE_DETAILS_REPORT)
                {
                    ReportName = "HREmployeeDetails.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));
                    dt = FCCHREmployeeDetails_RPT.GetFacadeCreate().GetDT(overviewEmployeeID);
                }

                else if (Action == ReportConstants.HR_EMPLOYEE_LIST_REPORT)
                {
                    ReportName = "HREmployeeList.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));
                    dt = FCCHREmployeeList_RPT.GetFacadeCreate().GetDT();
                }

                else if (Action == ReportConstants.HR_EMPLOYEE_MONTHLY_TIME_SHEET_SUMMARY_REPORT)
                {
                    ReportName = "EmployeeTimeSheet.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));
                    dt = FCCHREmployeeMonthlyTimeSheetSummary_RPT.GetFacadeCreate().GetDT(OverviewHRSalarySessionID, OverviewMDDepartmentFromID, OverviewMDDepartmentToID, OverviewMDDepartmentOtherID);
                }

                else if (Action == ReportConstants.HR_EMPLOYEE_SALARY_PAYMENT_REPORT)
                {
                    ReportName = "PayAdvice.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));
                    dt = FCCHREmployeeSalaryPayment_RPT.GetFacadeCreate().GetDT(OverviewHRSalarySessionID, OverviewMDDepartmentFromID, OverviewMDDepartmentToID, OverviewMDDepartmentOtherID);
                }

                else if (Action == ReportConstants.HR_EMPLOYEE_SALARY_STATEMENT_REPORT)
                {
                    ReportName = "HREmployeeSalaryStatement.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));
                    dt = FCCHREmployeeSalaryPayment_RPT.GetFacadeCreate().GetDT(OverviewHRSalarySessionID, OverviewMDDepartmentFromID, OverviewMDDepartmentToID, OverviewMDDepartmentOtherID);
                }

                else if (Action == ReportConstants.HR_EMPLOYEE_LEAVE_STATUS_REPORT)
                {
                    ReportName = "LeaveStatusReport.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/"  + ReportName));
                    dt = FCCHREmployeeLeaveStatus_RPT.GetFacadeCreate().GetDT(OverviewFiscalYearID);
                }

                else if (Action == ReportConstants.HR_EMPLOYEE_RESUME_REPORT)
                {
                    ReportName = "EmployeeResume.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));
                    
                    dt = FCCHREmployeeResume_RPT.GetFacadeCreate().GetDT(overviewEmployeeID);
                }

                else if (Action == ReportConstants.HR_EMPLOYEE_SALARY_DISBURSEMENT_BANK)
                {
                    ReportName = "HREmployeeSalaryDisbursementBank.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));

                    dt = FCCHREmployeeSalaryDisbursementBank_RPT.GetFacadeCreate().GetDT(OverviewHRSalarySessionID, OverviewFromLevel, OverviewToLevel);
                }

                else if (Action == ReportConstants.HR_EMPLOYEE_LEAVE_APPLICATIONS_REPORT)
                {
                    ReportName = "LeaveApplicationsReport.rpt";
                    myReportDocument.Load(Server.MapPath("~/Reports/HR/" + ReportName));

                    dt = FCCHREmployeeLeaveApplications_RPT.GetFacadeCreate().GetDT(OverviewHRSalarySessionID);
                }

                //CrystalDecisions.CrystalReports.Engine.TextObject txtPaymentMethod = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["ReportHeaderSection"].ReportObjects["txtPaymentMethod"]);
                //txtPaymentMethod.Text = sPaymentMethod;

                myReportDocument.SetDataSource(dt);

                //--Binding report with CrystalReportViewer
                reportViewer.ReportSource = myReportDocument;
                reportViewer.DataBind();

                //using (StreamWriter outfile =
                //    new StreamWriter(Server.MapPath("~/ErrorLog.txt")))
                //{
                //    outfile.Write("JNo Exceasdjklfla");
                //}
            }

            catch (Exception ex)
            {
                //DHLLogger dHLLogger = new DHLLogger();

                //dHLLogger.ErrorLog(Server.MapPath("~/ErrorLog/ErrorLog"), ex.Message);
                MiscUtil.ShowMessage(lblMessage, ex.Message, true);

                //using (StreamWriter outfile =
                //    new StreamWriter(Server.MapPath("~/ErrorLog.txt")))
                //{
                //    outfile.Write(ex.Message + ex.InnerException);
                //}
            }
        }

        protected void rptViewerMian_Unload(object sender, EventArgs e)
        {
            try
            {
                myReportDocument.Close();
                myReportDocument.Dispose();
            }
            catch (Exception ex)
            {
            }
        }

        protected void btnGeneratePayable_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    Int64 result = 0;

                    Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                    if (employeeID > 0)
                    {
                        IList<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity> list = FCCACCPrePayableStatementtoACCPostPayableStatementMigrate_Custom.GetFacadeCreate().GetIL(ACCPrePayableStatementID, employeeID);

                        if (list != null && list.Count > 0)
                        {
                            if (list[0].POSTPAYABLESTATEMENTID != null)
                            {
                                result = list[0].POSTPAYABLESTATEMENTID.Value;
                            }
                        }
                    }

                    if (result > 0)
                    {
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPrePayableStatementDetailEntity.FLD_NAME_PrePayableStatementID, ACCPrePayableStatementID.ToString(), SQLMatchType.Equal);
                        IList<ACCPrePayableStatementDetailEntity> lstPrePayableStatementDetail = FCCACCPrePayableStatementDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstPrePayableStatementDetail != null && lstPrePayableStatementDetail.Count > 0)
                        {
                            foreach (ACCPrePayableStatementDetailEntity ent in lstPrePayableStatementDetail)
                            {
                                if (ent.BillID > 0)
                                {
                                    UpdateBillApprovalStatus(Int64.Parse(ent.BillID.ToString()), MasterDataConstants.BillApprovalStatus.APPROVED_AND_IN_PAYABLE);
                                }
                            }
                        }
                        btnGeneratePayable.Enabled = false;
                        String fe_result = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementID, result.ToString(), SQLMatchType.Equal);
                        IList<ACCPostPayableStatementDetailEntity> lstPostPayableDetail = FCCACCPostPayableStatementDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_result, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstPostPayableDetail != null && lstPostPayableDetail.Count > 0)
                        {
                            foreach (ACCPostPayableStatementDetailEntity entPostPayableStatementDetailEntity in lstPostPayableDetail)
                            {
                                #region Approval Process

                                if (entPostPayableStatementDetailEntity.APPanelID != null && entPostPayableStatementDetailEntity.APPanelID > 0)
                                {

                                    Boolean apResult = APRobot.CreateApprovalProcessForNewPayableStatement(entPostPayableStatementDetailEntity.PostPayableStatementDetailID, Int64.Parse(entPostPayableStatementDetailEntity.APPanelID.ToString()));

                                    if (apResult == true)
                                    {
                                        MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                                    }
                                    else
                                    {
                                        MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                                    }

                                }

                                #endregion
                            }
                        }

                        MiscUtil.ShowMessage(lblMessage, "Payable Statement Post is successful.", UIConstants.MessageType.GREEN);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Payable Statement Post Failed.", UIConstants.MessageType.RED);
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, UIConstants.MessageType.RED);
                }
            }
        }

        #region Bill

        public void UpdateBillApprovalStatus(Int64 billID, Int64 billApprovalStatus)
        {
            CMBillEntity ent = FCCCMBill.GetFacadeCreate().GetByID(billID);

            ent.BillApprovalStatusID = billApprovalStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_BillID, billID.ToString(), SQLMatchType.Equal);

            FCCCMBill.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer.Dispose();
                this.reportViewer = null;
                myReportDocument.Close();
                myReportDocument.Dispose();
                GC.Collect();
            }
            catch (Exception ex)
            {
            }
            
        }

    }
}

#region Sample Code

//using System;
//using System.Data;
//using System.Configuration;
//using System.Collections;
//using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
//using System.Web.UI.HtmlControls;

//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;
//using System.IO;

//using KazcomTI.DHLSales.Entity;
//using KazcomTI.DHLSales.BLL;
//using KazcomTI.DHLSales.DAL.DataSet;
//using KazcomTI.DHLSales.Utility.Common;
//using System.Collections.Generic;

//public partial class Controls_ViewReportPopUpUC : System.Web.UI.UserControl
//{
//    ReportDocument myReportDocument;

//    protected void Page_Load(object sender, EventArgs e)
//    {
//        try
//        {
//            SaleBLL saleBLL = new SaleBLL();

//            Int32 counterId = Int32.Parse(Request.QueryString["counterId"].ToString());
//            Int64 userId = Int64.Parse(Request.QueryString["userId"].ToString());
//            Int32 saleCategoryId = Int32.Parse(Request.QueryString["saleCategoryId"].ToString());
//            DateTime toDate = DateTime.Parse(Request.QueryString["toDate"].ToString());
//            DateTime fromDate = DateTime.Parse(Request.QueryString["fromDate"].ToString());
//            Int32 reportStatus = Int32.Parse(Request.QueryString["reportStatus"].ToString());
//            Int32 orderBy = Int32.Parse(Request.QueryString["orderBy"].ToString());
//            Int32 paymentMethodId = Int32.Parse(Request.QueryString["paymentMethodId"].ToString());

//            Int32 temp_saleCategoryId = saleCategoryId;

//            if (saleCategoryId == 16 || saleCategoryId == 17)
//            {
//                saleCategoryId = 0;
//            }

//            DataView dv = saleBLL.GetGeneralReport(counterId, userId, saleCategoryId, toDate, fromDate, reportStatus, paymentMethodId);

//            dv.Sort = "SerialNo";

//            saleCategoryId = temp_saleCategoryId;

//            DataTable dt = dv.Table.Clone();

            

//            if (saleCategoryId == 16)
//            {
//                foreach (DataRowView dvr in dv)
//                {
//                    String val = dvr.Row["Description"].ToString();

//                    if (val == "CASHVX" || val == "CASHSTF" || val == "CASHVIP")
//                    {
//                        dt.ImportRow(dvr.Row);
//                    }
//                }

//                dt.AcceptChanges();

//                //dv.RowFilter = "Description = 'CASHVX' OR Description = 'CASHSTF' OR Description = 'CASHVIP'"; 
//            }
//            else if (saleCategoryId == 17)
//            {
//                foreach (DataRowView dvr in dv)
//                {
//                    String val = dvr.Row["Description"].ToString();

//                    if (val != "CASHVX" && val != "CASHSTF" && val != "CASHVIP")
//                    {
//                        dt.ImportRow(dvr.Row);
//                    }
//                }

//                dt.AcceptChanges();

//                //dv.RowFilter = "Description <> 'CASHVX' AND Description <> 'CASHSTF' AND Description <> 'CASHVIP'"; 
//            }
//            else
//            {
//                foreach (DataRowView dvr in dv)
//                {
//                    dt.ImportRow(dvr.Row);
//                }

//                dt.AcceptChanges();
//            }

//            String sPaymentMethod = "";

//            if (paymentMethodId == 0)
//            {
//                sPaymentMethod = "All";
//            }
//            else if (paymentMethodId == 1)
//            {
//                sPaymentMethod = "Cash";
//            }
//            else if (paymentMethodId == 2)
//            {
//                sPaymentMethod = "Check";
//            }
//            else if (paymentMethodId == 3)
//            {
//                sPaymentMethod = "Credit Card";
//            }


            
//            String ReportName = "GeneralReport.rpt";
            

//            if (orderBy == 1)
//            {

//                if (reportStatus == 1 || reportStatus == 0)
//                {
//                    ReportName = "GeneralReport.rpt";
//                }
//                else if (reportStatus == 2 )
//                {
//                    ReportName = "GeneralReportCancel.rpt";
//                }
//            }
//            else if (orderBy == 2)
//            {
//                if (reportStatus == 1 || reportStatus == 0)
//                {
//                    ReportName = "GeneralReportSerialNoWise.rpt";
//                }
//                else if (reportStatus == 2)
//                {
//                    ReportName = "GeneralReportCancelSerialNoWise.rpt";
//                }
//            }

            

//            rptViewerMian.DisplayGroupTree = false;
//            rptViewerMian.HasCrystalLogo = false;

//            //--Initializing CrystalReport
            

//            myReportDocument = new ReportDocument();
//            myReportDocument.Load(Server.MapPath(@"../Report/" + ReportName));
//            //myReportDocument.Load("../Report/" + ReportName);



//            CrystalDecisions.CrystalReports.Engine.TextObject txtPaymentMethod = ((CrystalDecisions.CrystalReports.Engine.TextObject)myReportDocument.ReportDefinition.Sections["ReportHeaderSection"].ReportObjects["txtPaymentMethod"]);


//            txtPaymentMethod.Text = sPaymentMethod;

//            IList<UserAccount> list = new List<UserAccount>();

//            myReportDocument.SetDataSource(list);
            
//            //--Binding report with CrystalReportViewer
//            rptViewerMian.ReportSource = myReportDocument;
//            rptViewerMian.DataBind();

           
            
            
//        }
//        catch (Exception ex)
//        {
//            DHLLogger dHLLogger = new DHLLogger();

//            dHLLogger.ErrorLog(Server.MapPath("~/ErrorLog/ErrorLog"), ex.Message);
            
//        }
//    }



//    protected void rptViewerMian_Unload(object sender, EventArgs e)
//    {
//        try
//        {
//            myReportDocument.Close();
//            myReportDocument.Dispose();
//        }
//        catch (Exception ex)
//        { }
//    }
//}

#endregion