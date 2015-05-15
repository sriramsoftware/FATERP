using System;
using System.IO;
using System.Collections.Generic;

namespace Bay.ERP.Web.UI
{
    public static class MasterDataConstants
    {
        public static class IssueIdentityCategory
        {
            public const Int64 PROJECT_TASK = 1;
            public const Int64 ADHOC_ISSUE = 2;
            public const Int64 PROJECT_ADHOC_ISSUE = 4;
        }

        public static class ResourceCategory
        {
            public const Int64 EMPLOYEE = 1;
            public const Int64 CONSULTANT = 2;
            public const Int64 CONTRACTOR = 3;
            public const Int64 TOOL = 4;
            public const Int64 LANDOWNER = 5;
            public const Int64 VENDOR = 6;
        }

        public static class MemberType
        {
            public const Int64 HR_MEMBER = 1;
            public const Int64 CONTRACTOR = 2;
            public const Int64 CONSULATANT = 3;
        }

        public static class ItemDefaults
        {
            public const Int64 DEFAULT_BRAD = 51;
            public const Int64 DEFAULT_SUPPLIER = 104;
            public const Int64 DEFAULT_REGION = 12;
            public const Int64 DEFAULT_COUNTRY = 116;
            public const Int64 DEFAULT_WORKORDER = 16;
            public const Int64 DEFAULT_ADVERTIESMENT_ITEM_CATEGORY = 10147;
        }

        public static class PreBOQStatus
        {
            public const Int64 NOT_STARTED = 1;
            public const Int64 IN_PROCESS = 2;
            public const Int64 COMPLETED = 3;
            public const Int64 ON_HOLD = 4;
        }

        public static class BOQStatus
        {
            public const Int64 NOT_STARTED = 1;
            public const Int64 IN_PROCESS = 2;
            public const Int64 COMPLETED = 3;
            public const Int64 ON_HOLD = 4;
        }

        public static class FloorCategory
        {
            public const Int64 BASEMENT = 1;
            public const Int64 FLOOR = 2;
            public const Int64 PENTHOUSE = 3;
            public const Int64 HEAD_ROOM = 4;
        }

        public static class Project
        {
            public const Int64 DEFAULT_PROJECT = 49;
        }

        public static class ProjectAssignedTeamRole
        {
            public const Int64 CHECKED_BY = 1;
            public const Int64 SITE_INCHARGE = 2;
            public const Int64 PROJECT_COORDINATOR = 3;
            public const Int64 PROCUREMENT = 4;
            public const Int64 MIS = 5;
            public const Int64 HOD = 6;
            public const Int64 PROJECT_MEMBER = 7;
        }

        public static class DMSDocumentStorageType
        {
            public const Int64 REGULAR_NODE = 1;
            public const Int64 SYSTEM_NODE = 2;
        }

        public static class DMSOwnerType
        {
            public const Int64 EMPLOYEE = 1;
            public const Int64 CONTRACTOR = 2;
            public const Int64 CONSULTANT = 3;
            public const Int64 PROJECT = 4;
        }

        public static class RequisitionStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 5;
            public const Int64 CANCELED = 6;
            public const Int64 MIGRATE_TO_TRF = 7;
        }

        public static class WorkOrderStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 5;
            public const Int64 CANCELED = 6;
        }

        public static class AdvanceSearchCriteria
        {
            public const Int64 START_WITH = 1;
            public const Int64 CONTAINS = 2;
            public const Int64 END_WITH = 3;
            public const Int64 EQUALS = 4;
        }

        public static class DMSCommonDocumentNode
        {
            public const String MY_DRIVE = "My Drive";
            public const String SHARED_WITH_ME = "Shared with me";
            public const String STARRED = "Starred";
            public const String DESIGN = "Design";
            public const String ALL_ITEMS = "All Items";
            public const String BIN = "Bin";
        }

        public static class APFeedback
        {
            public const Int64 NOT_YET_REQUESTED = 1;
            public const Int64 FEEDBACK_REQUESTED = 2;
            public const Int64 WORKING_ON_FEEDBACK = 3;
            public const Int64 ON_HOLD_BY_APPROVAL_PANEL_MEMBER = 4;
            public const Int64 APPROVED = 5;
            public const Int64 REJECTED = 6;
            public const Int64 CANCELED = 7;
            public const Int64 FORWARDED = 8;
            public const Int64 FORWARD_RESPONSE_RECEIVED = 9;
        }

        public static class APStatus
        {
            public const Int64 NEW = 1;
            public const Int64 IN_PROCESS = 2;
            public const Int64 ON_HOLD = 3;
            public const Int64 COMPLETED = 4;
            public const Int64 CANCELED = 5;
        }

        public static class APType
        {
            public const Int64 REQUISITION = 1;
            public const Int64 WORK_ORDER = 2;
            public const Int64 CUSTOM = 3;
            public const Int64 BILL = 4;
            public const Int64 PAYABLE_STATEMENT = 5;
            public const Int64 TRF = 6;
            public const Int64 BANK_DEPOSIT = 9;
            public const Int64 BANK_PAYMENT= 10;
            public const Int64 TEMPORARY_JOURNAL = 11;
            public const Int64 BANK_ACCOUNT_TRANSFER = 12;
            public const Int64 MRR = 13;
            public const Int64 AGREEMENT = 14;
            public const Int64 CONTACT_LIST = 15;
            public const Int64 LEAVE_APPLICATION = 16;
            public const Int64 LOAN_APPLICATION = 17;
        }

        public static class CM_Bill_VendorCategory
        {
            public const String CONTRACTOR = "1";
            public const String CONSULTANT = "2";
            public const String VENDOR = "3";
        }

        public static class MDBillStatus
        {
            public const Int64 RUNNING_BILL = 1;
            public const Int64 FINAL_BILL = 2;
        }

        public static class MailConstants
        {
            public const String DEFAULT_FROM = "erp@baydevelopments.com";
            public const String DEFAULT_CREDENTIALS = "b@y.1212";
            public const Int32 DEFAULT_PORT = 25;
            public const String DEFAULT_SMT = "mail.baydevelopments.com";
        }

        public static class BillApprovalStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 5;
            public const Int64 APPROVED_AND_IN_PAYABLE = 6;
        }

        public static class AutoAssigned
        {
            public const String DEFAULT_AUTO_ASSIGNED = "Auto Assigned";
        }

        public static class ACCPrePayableStatementApprovalStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 4;
        }

        public static class ACCPostPayableStatementApprovalStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 4;
        }

        public static class MDACCPayablePaymentStatus
        {  
            public const Int64 CURRENT = 1;
            public const Int64 POSTPOND_DATE = 2;
            public const Int64 DELETED = 5;
            public const Int64 PARTIAL_PAYMENT = 6;
        }

        public static class MDAccountPaybleStatementDetailCategory
        {
            public const Int64 REGULAR = 1;
            public const Int64 SECURED = 2;
        }

        public static class MDPayableClassification
        {
            public const Int64 AS = 1;
            public const Int64 ASC = 2;
            public const Int64 PC = 3;
            public const Int64 PSC = 4;
            public const Int64 PS = 5;
        }

        public static class SINAddOperation
        {
            public const String REQUEST_ITEM = "RequestItem";
            public const String ISSUE_ITEM = "IssueItem";
            public const String RETURN_ITEM = "ReturnItem";
        }

        public static class DeafultAPPanel
        {
            public const Int64 DEFAULT_AP_PANEL = 10009;
        }

        public static class INVTransferApprovalStatus
        {
            public const Int64 REQUESTED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 CANCELED = 5;
            public const Int64 COMPLETED = 6;
        }

        public static class INVStoreIssueNoteApprovalStatus
        {
            public const Int64 REQUESTED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 ISSUED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 5;
        }

        public static class MDIssuePriority
        {
            public const Int64 CRITICAL = 1;
            public const Int64 EMERGENCY = 2;
            public const Int64 HIGH = 3;
            public const Int64 MEDIUM = 4;
            public const Int64 LOW = 5;
        }

        public static class MDIssueIdentityCategory
        {
            public const Int64 PROJECTTASK = 1;
            public const Int64 ADHOCISSUE = 2;
            public const Int64 NOTDECIDED1 =3;
            public const Int64 PROJECTADHOCISSUE = 4;
            public const Int64 HRMETTINGWITHEMPLOYEE = 7; // 7 in live 5 in local
        }

        public static class MDIssueStatus
        {
            public const Int64 NEW = 1;
            public const Int64 ASSIGNED = 2;
            public const Int64 IN_PROCESS = 4;
            public const Int64 COMPLETED = 5;
            public const Int64 IN_PROGRESS = 6;
            public const Int64 ON_HOLD = 7;
        }

        public static class IssuePageType
        {
            public const Int64 ADHOC_ISSUE = 1;
            public const Int64 PROJECT_ADHOC_ISSUE = 2;
            public const Int64 MY_ISSUE_LIST = 3;
        }

        public static class ACCPayableDefault
        {
            public const Int64 ACC_PRE_PAYABLE_STATEMENT_DEFAULT = 30;
            public const Int64 ACC_POST_PAYABLE_STATEMENT_DEFAULT = 30;
        }

        public static class MDVendorCategory
        {
            public const Int64 CONTRACTOR = 1;
            public const Int64 CONSULTANT = 2;
            public const Int64 VENDOR = 3;
        }

        public static class ERPDeploymentAddressIP
        {
            public const String LOCAL_IP = "http://192.168.0.9:9999";
            public const String REAL_IP = "http://180.234.210.114:8888";
        }

        public static class ACMDPaidFrom
        {   
            public const Int64 MISCELLANEOUS = 1;
            public const Int64 CONTRACTOR = 2;
            public const Int64 CONSULTANT = 3;
            public const Int64 VENDOR = 4;
            public const Int64 CUSTOMER = 5;
        }

        public static class ACMDPaidTo
        {
            public const Int64 MISCELLANEOUS = 1;
            public const Int64 CONTRACTOR = 2;
            public const Int64 CONSULTANT = 3;
            public const Int64 VENDOR = 4;
            public const Int64 CUSTOMER = 5;
        }

        public static class MDSupplierType
        {
            public const Int64 LOCAL = 1;
            public const Int64 IMPORTER = 2;
            public const Int64 LOCAL_AND_IMPORTER = 3;
            public const Int64 CONTRACTOR = 4;
            public const Int64 CONSULTANT = 5;
        }

        public static class MDDebitCredit
        {
            public const Int64 DEBIT = 1;
            public const Int64 CREDIT = 2;
        }

        public static class ACMDAccountResourceCategory
        {
            public const Int64 CONTRACTOR = 1;
            public const Int64 CONSULTANT = 2;
            public const Int64 VENDOR = 3;
            public const Int64 CUSTOMER = 4;
            public const Int64 EMPLOYEE = 5;
        }

        public static class ACMDBankAccountDepositApprovalStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 5;
            public const Int64 CANCELED = 6;
            public const Int64 CANCELED_AND_RETURN_TO_INITIATOR = 7;
        }

        public static class ACMDBankAccountPaymentApprovalStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 5;
            public const Int64 CANCELED = 6;
            public const Int64 CANCELED_AND_RETURN_TO_INITIATOR = 7;
        }

        public static class ACMDTemporaryJournalApprovalStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 5;
            public const Int64 CANCELED = 6;
            public const Int64 CANCELED_AND_RETURN_TO_INITIATOR = 7;
        }

        public static class ACClassType
        {
            public const Int64 ASSETS = 1;
            public const Int64 LIABILITIES = 2;
            public const Int64 EQUITY = 3;
            public const Int64 INCOME = 4;
            public const Int64 COST_OF_GOODS_SOLD = 5;
            public const Int64 EXPENSE = 6;
        }

        public static class ACMDBankAccountTransferApprovalStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 5;
            public const Int64 CANCELED = 6;
        }

        public static class APPanelStartWith
        {
            public const String ACCOUNTS = "Account";
            public const String BILL = "Bill";
            public const String MRR = "MRR";
            public const String PAYABLE = "Payable";
            public const String CRM = "CRM";
            public const String HR = "HR";
            public const String HRLEAVE = "HR Leave";
            //public const String DESIGN = "Design";
            //public const String ALL_ITEMS = "All Items";
            //public const String BIN = "Bin";
        }

        public static class MDMaterialReceiveApprovalStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 5;
            public const Int64 CANCELED = 6;
            public const Int64 APPROVED_BL = 7;
        }

        public static class KBMDUserTreeStatus
        {
            public const Int64 REGULAR = 1;
            public const Int64 ARCHIEVED = 2;
            public const Int64 ARCHIEVED_AND_UNSHARE = 3;
            public const Int64 REGULAR_AND_SHARED = 4;
            public const Int64 MAKE_NOT_IN_USE = 5;
            public const Int64 TRANSFER_OWNERSHIP = 6;//This may not need to use in code area
            public const Int64 MAKE_IT_PUBLIC = 7;
        }

        public static class CMNProcessCategory
        {
            public const Int64 KNOWLEDGE_BASE = 1;
            public const Int64 REQUISITION = 2;
            public const Int64 WORK_ORDER = 3;
            public const Int64 BILL = 4;
            public const Int64 PAYABLE = 5;
            public const Int64 DOCUMENT = 6;
            public const Int64 ISSUE_AND_TASK = 7;
            public const Int64 SALES = 8;
            public const Int64 LAND = 9;
            public const Int64 INTERVIEW_PERSON = 10;
            public const Int64 EVENT = 11;
        }

        public static class KBMDUserTreeSetting
        {
            public const Int64 OPEN = 1;
            public const Int64 CLOSE = 2;
        }

        public static class KBMDUserTreeSharedPermission
        {
            public const Int64 CAN_EDIT = 1;
            public const Int64 CAN_VIEW = 2;
            public const Int64 CAN_SHARE = 3;
        }

        public static class KBUserTreeDefault
        {
            public const Int64 BAYS_WIKI = 1;
            public const Int64 MARK_NOT_IN_USE = 2;
            public const Int64 ARCHIEVE = 3;
        }

        public static class MDProjectFloorUnitStatus
        {
            public const Int64 AVAILABLE = 1;
            public const Int64 TEMPORARY_BOOKED = 2;
            public const Int64 ALLOCATED = 3;
            public const Int64 READY_FOR_HANDOVER = 4;
            public const Int64 HANDLED_OVER = 5;
        }

        public static class CRMMDAgreementApprovalStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 5;
            public const Int64 CANCELED = 6;
        }

        public static class CRMMDAgreementType
        {
            public const Int64 AGREEMENT_A = 1;
            public const Int64 AGREEMENT_B = 2;
            public const Int64 AGREEMENT_C = 3;
            public const Int64 ANNEX_I_B_BAY_PACKAGE = 4;
            public const Int64 AGREEMENT_A_ANNEXIII = 5;
            public const Int64 SPECS = 6;
        }

        public static class CRMMDBookingStatus
        {
            public const Int64 CONVERTED = 1;
            public const Int64 CANCELLED = 2;
            public const Int64 ON_GOING = 3;
            public const Int64 BOOKED = 4;
        }

        public static class CRMMDPaymentApprovalStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 5;
            public const Int64 CANCELED = 6;
        }

        public static class CRMMDPaymentCategory
        {
            public const Int64 COMPLETED = 1;
            public const Int64 PARTIAL_PAYMENT = 2;
            public const Int64 PAYMENT_EXCEDED = 3;
        }

        public static class ACAccountGroup
        {
            public const Int64 CAPITAL_AND_RESERVE = 1;
            public const Int64 NON_CURRENT_LIABILITIES = 9;
            public const Int64 CURRENT_LIABILITIES = 57;
            public const Int64 NON_CURRENT_ASSETS = 300;
            public const Int64 CURRENT_ASSETS = 301;
            public const Int64 PROJECT_INCOMES = 302;
            public const Int64 PROJECT_EXPENSES = 303;
            public const Int64 CORPORATE_INCOMES = 304;
            public const Int64 CORPORATE_EXPENSES = 305;
        }

        public static class BDMDProcessAssignedResourceApprovalStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 IN_APPROVE_PROCESS = 2;
            public const Int64 APPROVED = 3;
            public const Int64 REJECTED = 4;
            public const Int64 ON_HOLD = 5;
            public const Int64 CANCELED = 6;
        }

        public static class CMMDBillBillFloorDetailCategory
        {
            public const Int64 MB = 1;
            public const Int64 MRR = 2;
        }

        public static class MDEvaluationSessionStatus
        {
            public const Int64 INITIATED = 1;
            public const Int64 OPEN = 2;
            public const Int64 CLOSED = 3;
            public const Int64 ON_HOLD = 4;
            public const Int64 ARCHIVED = 5;
        }

        public static class MDEvaluationCriteriaCategory
        {
            public const Int64 SELECTION = 1;
            public const Int64 VERBAL = 2;
            public const Int64 MCQ = 3;
            public const Int64 WRITTEN = 4;
            public const Int64 YES_NO = 5;
        }

        public static class MDEvaluationSessionCategory
        {
            public const Int64 QUARTERLY_EVALUATIONS = 1;
            public const Int64 YEARLY = 2;
            public const Int64 SURVEY = 3;
            public const Int64 EVALUATION_2013 = 4;
            public const Int64 HR_SURVEY = 5;
            public const Int64 HEALTH_CHECKUP= 6;
            public const Int64 PBR = 8;
            public const Int64 FISCAL_YEAR = 9; // live 9 local 10
        }

        public static class MDDepartment
        {
            public const long MIS_DEPARTMENTID = 1;
            public const long HR_DEPARTMENTID = 5;
            public const long IS_DEPARTMENTID = 33;
            public const long NO_DEPARTMENTID = 0;
            public const long SECURITY_DEPARTMENTID = 20;
        }

        public static class MDCountryForHRM
        {
            public const Int32 DEFAULT_COUNTRY = 4;
        }

        public static class ACPaymentType
        {
            public const Int64 BANK_ACCOUNT_PAYMENT = 1;
            public const Int64 CASH_PAYMENT = 2;
        }

        public static class MDOutsourceCategory
        {
            public const Int64 ARTIST = 1;
        }

        public static class CMNMDEventStatus
        {
            public const Int64 New = 1;
            public const Int64 UP_COMING = 2;
            public const Int64 ON_GOING = 3;
            public const Int64 COMPLETED = 4;
            public const Int64 POSTPOND = 5;
            public const Int64 ON_HOLD = 6;
        }

        public static class CMNMDEventIdentityCategory
        {
            public const Int64 ART_GALLERY_EVENT = 1;
            public const Int64 BAY_S_OFFICIAL_EVENT = 2;
            public const Int64 FRONT_DESK_EVENT = 3;
            public const Int64 EVENT_FROM_WORKORDER = 4;
        }

        public static class CMNMDEventCategory
        {
            public const Int64 ART_GALLERY_EVENT = 1;
            public const Int64 BAY_S_OFFICIAL_EVENT = 2;
            public const Int64 FRONT_DESK_EVENT = 3;
            public const Int64 EVENT_FROM_WORKORDER = 4;
        }

        public static class CMNMDEventOption
        {
            public const Int64 GUEST_CAN_INVIATE_PEOPLE_AND_UPLOAD = 1;
            public const Int64 GUEST_CAN_INIVATE_PEOPLE_ONLY = 2;
        }

        public static class CMNMDSharedSetting
        {
            public const Int64 DEFAULT = 1;
            public const Int64 SHARED_PRIVATELY = 2;
            public const Int64 SHARED_PUBLICLY = 3;
        }

        public static class MDEventLocationCategory
        {
            public const Int64 LOCATION_NOT_AVAILABLE = 1;
            public const Int64 OFFICIAL_ROOM = 2;
            public const Int64 ART_GALLERIA = 3;
        }

        public static class EventPageType
        {
            public const Int64 EVENT = 1;
            public const Int64 EVENT_SCHEDULE = 2;
        }

        public static class EventInvitationPersonType
        {
            public const Int64 GUEST = 1;
            public const Int64 HOST = 2;
        }

        public static class BDMDRepeatCategory
        {
            public const Int64 DAILY = 1;
            public const Int64 WEEKLY = 2;
            public const Int64 MONTHLY = 3;
            public const Int64 YEARLY = 4;
            public const Int64 ONE_TIME_EVENT = 5;
        }

        public static class CRMMDBuyerType
        {
            public const Int64 PROSPECTIVE_BUYER = 1;
            public const Int64 EXISTING_BUYER = 2;
        }

        public static class MDLeaveApplicatoinStatus
        {
            public const Int64 PENDING = 1;
            public const Int64 APPROVED = 2;
            public const Int64 DECLINED = 3;
        }

        public static class MDLoanApplicatoinStatus
        {
            public const Int64 PENDING = 1;
            public const Int64 APPROVED = 2;
            public const Int64 DECLINED = 3;
        }

        public static class MDAttendanceLeaveAndHolidayCategory
        {
            public const Int64 WORK_DAY = 1;
            public const Int64 LEAVE_DAY = 2;
            public const Int64 HOLIDAY = 3;
        }

        public static class MDSalaryDeducationCategory
        {
            public const Int64 ADVANCE = 1;
            public const Int64 FINE = 2;
            public const Int64 MEALS = 8;
            public const Int64 AIT = 4;
            public const Int64 PHONE_CEILLING_LIMIT = 5;
            public const Int64 PROVIDENT_FUND = 6;
            public const Int64 TAX = 7;
        }

        public static class MDEmploymentStatus
        {
            public const Int64 ACTIVE = 1;
            public const Int64 SUSPENDED = 2;
            public const Int64 FORMER = 3;
            public const Int64 IN_PROBATION = 4;
            public const Int64 DISCONTINUED = 5;
        }

        public static class MDEmployeeJobType
        {
            public const Int64 FULLTIME = 1;
            public const Int64 CONTRACT = 2;
            public const Int64 PARTTIMENOTLESS75PERCENT= 3;
            public const Int64 PARTTIMENOTLESS50PERCENT = 4;
            public const Int64 PARTTIMEOTHER = 5;
            public const Int64 PARMANENT = 6;
        }

        public static class MDLeaveCategory
        {
            public const Int64 CASUAL = 1;
            public const Int64 MEDICAL = 2;
            public const Int64 EARN = 3;
            public const Int64 LWP = 4;
        }

        public static class HREmployeeNoticeTemplate
        {
            public const Int64 OFFICEMEMO = 6;
            public const Int64 JOINLETTER = 8;
            public const Int64 APPOINTMENTLETTER = 9;
            public const Int64 CHANGEOFDESIGNATIONLETTER = 10;
            public const Int64 SALARYENHANCEMENTLETTER= 11;
            public const Int64 CONFIRMATIONLETTER= 12;
            
        }

        public static class HREmployeeSalaryLevel
        {
            public const Int64 Level1 = 1;
            public const Int64 Level3 = 3;
            public const Int64 Level4 = 4;
            public const Int64 Level20 = 20;
        }

        public static class MDDocumentCategory
        {
            public const Int64 CV = 23;
        }

        public static class MDAllowanceCategory
        {
            public const Int64 PHONE_BILL = 1;
            public const Int64 OTHER = 2;
        }

        public static class HREvaluationCategoryPercent
        {
            public const Int64 TBR = 2;
            public const Int64 EBR = 5;
        }

        public static class APPanel
        {
            public const Int64 HR_LEAVE_APPROVAL_PANEL = 10033; // 10033 live 10025 local
        }

        public static class MDIssueCategory
        {
            public const Int64 MEETING = 10170; // 10129 for local 10170 for live
        }
    }

    public static class SearchDropdownConstants
    {
        public static class HRMemberSearchType
        {
            public const Int64 EMPLOYEE_CODE = 1;
            public const Int64 FIRST_NAME = 2;
        }
    }

    public static class SecurityConstants
    {
        public const String KEY_GLUE = "_KEYGLUE_";
        public const String ROOT_FOLDER_NAME = "ERP";
        public const String MASTER_ROLE = "Admin";
        
        public static class SileMap
        {
            public const Int64 MASTER_NAVEGATION_MENU = 1;
            public const Int64 APPLICANT_DATA_ACCESS_MENU = 2;
            public const Int64 CLIENT_DATA_ACCESS_MENU = 3;
            public const Int64 COMPANY_DATA_ACCESS_MENU = 4;
            public const Int64 EMPLOYEE_DATA_ACCESS_MENU = 5;
            public const Int64 ORGANIZATIONAL_DATA_ACCESS_MENU = 6;
            public const Int64 PARTNETOVERVIEWMENU = 7;
            public const Int64 PROJECT_DATA_ACCESS_MENU = 8;
            public const Int64 REQUISITION_BUILDER_MENU = 9;
            public const Int64 REQUISITOIN_DATA_ACCESS_MENU = 10;
            public const Int64 SALES_CAMPAIGN_DATA_ACCESS_MENU = 11;
            public const Int64 VENDOR_DATA_ACCESS_MENU = 12;
        }

        public static class MDASNodeType
        {   
            public const Int64 FOLDER = 1;
            public const Int64 WEB_PAGE = 2;
        }

        public static class MDASControlType
        {
            public const Int64 BUTTON_EPMS = 1;
            public const Int64 TAB_EPMS = 2;
            public const Int64 TAB_STRIP = 3;
            public const Int64 GRID = 4;
            public const Int64 LINK_BUTTON_EPMS = 5;
            public const Int64 GRID_BUTTON_COLUMN_EPMS = 6; 
        }

        public static class MasterTemplate
        {
            public const long NewUser = 1;
        }

        public static class ASSiteMap
        {
            public const Int64 MASTER_NAVIGATION_MENU = 1;
            public const Int64 MASTER_DATA_MENU = 2;
            public const Int64 APPLICANT_MENU = 3;
            public const Int64 CAREER_PORTAL_MENU = 4;
            public const Int64 EMPLOYEE_MENU = 5;
            public const Int64 EMPLOYEE_SELF_SERVICE_MENU = 6;
            public const Int64 CRM_MENU = 7;
            public const Int64 CRM_PORTAL_MENU = 8;
            public const Int64 VMS_MENU = 9;
            public const Int64 VMS_PORTAL_MENU = 10;
            public const Int64 REQUISITION_MENU = 11;
            public const Int64 PROJECT_MENU = 12;
            public const Int64 ORGANIZATION_MENU = 13;
            public const Int64 LMS_MENU = 14;
            public const Int64 SFA_MENU = 15;
            public const Int64 NEW_MENU_1 = 16;
            public const Int64 NEW_MENU_2 = 17;
            public const Int64 NEW_MENU_3 = 18;
            public const Int64 NEW_MENU_4 = 19;
            public const Int64 NEW_MENU_5 = 20;
            public const Int64 NEW_MENU_6 = 21;
            public const Int64 NEW_MENU_7 = 22;
            public const Int64 NEW_MENU_8 = 23;
            public const Int64 NEW_MENU_9 = 24;
            public const Int64 NEW_MENU_10 = 25;
        }
    }

    public static class CustomControlConstants
    {
        public static class DocumentNodeType
        {
            public const String RootNode = "RootNode";
            public const String DocumentCategory = "DocumentCategory";
            public const String Document = "Document";
        }

        public static class HRNodeType
        {
            public const String RootNode = "RootNode";
            public const String Department = "Department";
            public const String Designation = "Designation";
            public const String Employee = "Employee";
        }
    }
    
    
}