using System;
using System.IO;
using System.Configuration;
using System.Web;
using System.Web.UI;

namespace Bay.ERP.Web.UI
{
    public static class UrlConstants
    {
        public const string OVERVIEW_ISSUE_ID = "OverviewIssueID";
        public const string REQUISITION_ID = "OverviewRequisitionID";
        public const string OVERVIEW_EMPLOYEE_ID = "OverviewEmployeeID";
        public const string OVERVIEW_CONSTRUCTION_TOOL_ID = "OverviewConstructionToolID";
        
        
        public const string OVERVIEW_PROJECT_ID = "OverviewProjectID";
        public const string OVERVIEW_MEMBER_ID = "OverviewMemberID";
        public const string OVERVIEW_SUPPLIER_ID = "OverviewSupplierID";
        public const string OVERVIEW_CONTRACTOR_ID = "OverviewContractorID";
        public const string OVERVIEW_CONSULTANT_ID = "OverviewConsultantID";
        public const string OVERVIEW_DASHBOARD_ITEM_ID = "OverviewDashboardItemID";
        public const string OVERVIEW_WORKORDER_ID = "OverviewWorkOrderID";
        public const string OVERVIEW_MATERIAL_RECEIVE_ID= "OverviewMaterialReceiveID";
        public const string OVERVIEW_DMS_REFERENCE_ID = "OverviewDMSReferenceID";
        public const string OVERVIEW_DMS_DOCUMENT_NODE_ID = "OverviewDMSDocumentNodeID";
        public const string OVERVIEW_CM_MEASUREMENT_BOOK_ID= "OverviewCMMeasurementBookID";
        public const string OVERVIEW_CM_BILL_ID = "OverviewCMBillID";
        public const string OVERVIEW_CM_BILL_NO = "OverviewCMBillNo";
        public const string OVERVIEW_PRM_WORK_ORDER_NO = "OverviewPRMWorkOrderNo";
        public const string OVERVIEW_MD_ITEM_NAME = "OverviewMDItemName";
        public const string OVERVIEW_REQUISITION_ID = "OverviewREQRequisitionID";
        public const string OVERVIEW_PROJECT_CODE = "OverviewProjectCode";
        public const string OVERVIEW_PRE_PAYABLE_STATEMENT_ID = "OverviewACCPrePayableStatementID";
        public const string OVERVIEW_POST_PAYABLE_STATEMENT_ID = "OverviewACCPostPayableStatementID";
        public const string OVERVIEW_POST_PAYABLE_STATEMENT_DETAIL_ID = "OverviewACCPostPayableStatementDetailID";
        public const string OVERVIEW_STORE_ISSUE_NOTE_ID = "OverviewStoreIssueNoteID";
        public const string OVERVIEW_ITEM_ID = "OverviewItemID";
        public const string OVERVIEW_STORE_UNIT_ID = "OverviewStoreUnitID";
        public const string OVERVIEW_TRANSFER_ID = "OverviewTransferID";
        public const string OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID = "OverviewBankAccountDepositID";
        public const string OVERVIEW_BANK_ACCOUNT_PAYMENT_ID = "OverviewBankAccountPaymentID";
        public const string OVERVIEW_TEMPORARY_JOURNAL_ID = "OverviewTemporaryJournalID";
        public const string OVERVIEW_ACCOUNT_GROUP_ID = "OverviewAccountGroupID";
        public const string OVERVIEW_TRIAL_BALANCE_FROM_DATE = "OverviewTrialBalanceFromDate";
        public const string OVERVIEW_TRIAL_BALANCE_TO_DATE = "OverviewTrialBalanceToDate";
        public const string OVERVIEW_ACTIVE_FISCAL_YEAR_ID = "OverviewActiveFiscalYearID";
        public const string OVERVIEW_BALANCE_SHEET_FROM_DATE = "OverviewBalanceSheetFromDate";
        public const string OVERVIEW_BALANCE_SHEET_TO_DATE = "OverviewBalanceSheetToDate";
        public const string OVERVIEW_TEMPORARY_JOURNAL_MASTER_ID = "OverviewTemporaryJournalMasterID";
        public const string OVERVIEW_BANK_ACCOUNT_TRANSFER_ID = "OverviewBankAccountTransferID";
        public const string OVERVIEW_USER_TREE_ID= "OverviewKBUserTreeID";
        public const string OVERVIEW_BUYER_BASIC_INFO_ID= "OverviewBuyerBasicInfoID";
        public const string OVERVIEW_LAND_BASIC_INFO_ID = "OverviewLandBasicInfoID";
        public const string OVERVIEW_AGREEMENT_ID = "OverviewAgreementID";
        public const string OVERVIEW_PAYMENT_SCHEDULE_ID = "OverviewPaymentScheduleID";
        public const string OVERVIEW_PAYMENT_COLLECTION_ID = "OverviewPaymentCollectionID";
        public const string OVERVIEW_TO_DATE_DUE_PAYMENT_SCHEDULE = "OverviewToDateDuePaymentSchedule";
        public const string OVERVIEW_TO_DATE_ENCASHED = "OverviewToDateEncashed";
        public const string OVERVIEW_IS_ENCASHED = "OverviewIsEncashed";
        public const string OVERVIEW_TASK_TEMPLATE_ID = "OverviewTaskTemplateID";
        public const string OVERVIEW_PROCESS_ASSIGNED_RESOURCE_ID = "OverviewProcessAssignedResourceID";
        public const string OVERVIEW_BANK_ACCOUNT_ID = "OverviewBankAccountID";
        public const string OVERVIEW_PAYABLE_AMOUNT= "OverviewPaybleAmount";
        public const string OVERVIEW_PAYABLE_ACCOUNT_ID = "OverviewPayableAccountID";
        public const string OVERVIEW_ASP_NET_USER_ID = "OverviewAspnetUserID";
        public const string OVERVIEW_ISSUE_FROM_DATE = "OverviewIssueFromDate";
        public const string OVERVIEW_ISSUE_TO_DATE = "OverviewIssueToDate";
        public const string OVERVIEW_PROCESS_ASSIGNED_RESOURCE_MAP_ID = "OverviewProcessAssignedResourceMapID";
        public const string OVERVIEW_REGISTER_FROM_DATE = "OverviewRegisterFromDate";
        public const string OVERVIEW_REGISTER_TO_DATE = "OverviewRegisterToDate";
        public const string OVERVIEW_FILTER_EXPRESSION_FLOOR_WISE_COST = "OverviewFilterExpressionFloorWiseCost";
        public const string OVERVIEW_EVALUATION_SESSION_ID = "OverviewEvaluationSessionID";
        public const string OVERVIEW_SUEPRVISOR_EMPLOYEE_ID= "OverviewSupervisorEmployeeID";
        public const string OVERVIEW_EVENT_IDENTITY_CATEGORY_ID = "OverviewEventIdentityCategoryID";
        public const string OVERVIEW_EVENT_ID = "OverviewEventID";
        public const string OVERVIEW_SURVEY_OWNER_ID = "OverviewSurveyOwnerID";
        public const string OVERVIEW_ASSET_ID = "AssetID";
        public const string OVERVIEW_SURVEY_ID = "OverviewSurveyID";
        public const string OVERVIEW_SURVEY_MASTER_ID = "OverviewSurveyMasterID";
        public const string OVERVIEW_BOOK_SPACE_ID = "OverviewBookSpaceID";
        public const string OVERVIEW_LOAN_APPLICATION_ID = "OverviewLoanApplicationID";
        public const string OVERVIEW_LEAVE_APPLICATION_ID = "OverviewLeaveApplicationID";
        public const string OVERVIEW_HR_SALARY_SESSION_ID = "OverviewSalarySessionID";
        public const string OVERVIEW_HR_EMPLOYEE_SALARY_INFO_ID = "OverviewEmployeeSalaryInfoID";
        public const string OVERVIEW_HR_EMPLOYEE_NOTICE_ID = "OverviewHREmployeeNoticeID";
        public const string OVERVIEW_FISCALYEAR_ID = "OverviewFiscalYearID";
        public const string OVERVIEW_FROM_LEVEL = "OverviewFromLevel";
        public const string OVERVIEW_TO_LEVEL = "OverviewToLevel";
        public const string OVERVIEW_PROJECTFLOORUNITID = "OverviewProjectFloorUnitID";
        public const string OVERVIEW_MDDEPARTMENT_FROMID = "OverviewMDDepartmentFromID";
        public const string OVERVIEW_MDDEPARTMENT_TOID = "OverviewMDDepartmentToID";
        public const string OVERVIEW_MDDEPARTMENT_OTHERID = "OverviewMDDepartmentOtherID";


        //Report
        public const string OVERVIEW_SUPPLIERPRICE_ITEM_ID = "OverviewSupplierPriceItemID";


        //Security
        public const string OVERVIEW_ROLE = "OverviewRole";



        // OLD
        public const string PARAM_SITEMAP_ID = "sitemapid";
        public const string PARAM_SITEMAP_PARENT_ID = "sitemapparentid";

        public static readonly string ApplicationPath = AppDomain.CurrentDomain.BaseDirectory;       
        public static readonly string WEB_FOLDER_SEP = Path.AltDirectorySeparatorChar.ToString();
        public static readonly string ApplicationBaseUrl = "http://" + HttpContext.Current.Request.Url.Authority + GetApplicationPath() + WEB_FOLDER_SEP;

        
        
        public static string GetApplicationPath()
        {
            string applicationPath = "/";

            if (HttpContext.Current != null)
            {
                applicationPath = HttpContext.Current.Request.ApplicationPath;
            }

            // Are we in an application?
            //
            if (applicationPath == "/")
            {
                return string.Empty;
            }
            else
            {
                return applicationPath;
            }
        }        

        public static string GetCurrentDomainName(Page currentPage)
        {
            string domainName = string.Empty;
            domainName = "http://" + currentPage.Request.Url.Host + "/";
            return domainName;
        }

        public static class CommonSite
        {
            public const string DIR = "";

            public const string LOGIN_PAGE = DIR + "Login.aspx";
            public const string HOME_PAGE = "~/" + DIR + "Default.aspx";
            public const string REGISTER_PAGE = "~/" + DIR + "Registration.aspx";            
        }
    }
}