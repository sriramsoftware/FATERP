using System;
using System.IO;

namespace Bay.ERP.Common.Shared
{
    public static class CommonConstants
    {
        public const String MESSAGE_ON_ERROR = "Server is busy. Try Again Later";
        public const String DefaultDateFormat = "dd-MM-yyyy";

        public const String ITEM_FC = "Item_FC";
        public const String ITEM_CATEGORY_FC = "Item_Category_FC";
        public const String DEPARTMENT_FC = "Department_FC";
        public const String DESIGNATION_FC = "Designation_FC";
        public const String ASSET_CATEGORY_FC = "Asset_Category_FC";

        public const Int32 PreBOQItemMapTableInfo = 1;
        public const Int32 PreBOQDetailTableInfo = 2;
        public const Int32 RequisitionItemInfo = 3;
        public const Int32 BOQDetailTableInfo = 4;
        public const Int32 BOQItemMapTableInfo = 5;
        public const Int32 TaskTemplateInfo = 6;
        public const Int32 CreateSixTaskForHR = 7;
        public const Int32 HREmployeeMonthlyTimeSheetSummary = 8;
        public const Int32 HREmployeeSalaryPayment = 9;

        public const Int32 NEXT_SEQUENCENO_APPROVALRULE_DESIGNATIONMAP = 1;
        public const Int32 NEXT_REQUSITION_NO= 2;

        public const String IMPORT_RATE_INFO = "Price Info";
        public const String IMPORT_QTY_INFO = "Qty Info";
    }
}