// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Dec-2012, 12:17:40




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACCPrePayableStatement_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACCPrePayableStatement_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _PrePayableStatementDetailID;
        private Int64 _ProjectID;
        private String _ProjectCode;
        private Int64? _WorkOrderID;
        private String _WorkOrderNo;
        private Decimal? _WorkOrderAmount;
        private DateTime? _WorkOrderDate;
        private Decimal? _PaidAmount;
        private Decimal? _SecurityMoney;
        private Decimal? _TDSAmount;
        private Decimal? _PayableAgainstWorkOrder;
        private Decimal? _ApprovedBillAmount;
        private Decimal? _NetPayableConsideringBillAndSecurity;
        private Boolean _PartyReconcile;
        private Int64? _RequisitionID;
        private String _RequisitionNo;
        private DateTime? _RequisitionDate;
        private Int64? _BillID;
        private String _BillNo;
        private DateTime? _BillDate;
        private String _Remarks;
        private String _ACCPrePayableStatementDetailRef;
        private Int64 _VendorCategoryID;
        private Int64 _FromVendorID;
        private DateTime _CreateDate;
        private DateTime _DueDate;
        private DateTime? _PlannedDate;
        private String _AdditionalRemarks;
        private Int64 _ACCPayablePaymentStatusID;
        private Int64 _ACCPayableApprovalStatusID;
        private Int64? _AccountPaybleStatementDetailCategoryID;
        private Int64? _PayableClassificationID;
        private Int64 _CreateByEmployeeID;
        private Int64 _APPanelID;
        private String _IPAddress;
        private Boolean _IsRemoved;
        private Boolean _IsLocked;
        private Int64 _ACCPrePayableStatementID;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private String _ACCPrePayableStatementRef;
        private Int64 _ACCPrePayableStatementDetailPrePayableStatementID;
        private String _BDProjectProjectName;
        private String _SupplierName;
        private String _MDACCPayablePaymentStatusName;
        private String _MDACCPayableApprovalStatusName;
        private String _MDAccountPaybleStatementDetailCategoryName;
        private String _MDPayableClassificationName;
        private String _EmployeeMemberFullName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 PrePayableStatementDetailID
        {
            get { return _PrePayableStatementDetailID; }
            set { _PrePayableStatementDetailID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public Int64? WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public Decimal? WorkOrderAmount
        {
            get { return _WorkOrderAmount; }
            set { _WorkOrderAmount = value; }
        }

        [DataMember]
        public DateTime? WorkOrderDate
        {
            get { return _WorkOrderDate; }
            set { _WorkOrderDate = value; }
        }

        [DataMember]
        public Decimal? PaidAmount
        {
            get { return _PaidAmount; }
            set { _PaidAmount = value; }
        }

        [DataMember]
        public Decimal? SecurityMoney
        {
            get { return _SecurityMoney; }
            set { _SecurityMoney = value; }
        }

        [DataMember]
        public Decimal? TDSAmount
        {
            get { return _TDSAmount; }
            set { _TDSAmount = value; }
        }

        [DataMember]
        public Decimal? PayableAgainstWorkOrder
        {
            get { return _PayableAgainstWorkOrder; }
            set { _PayableAgainstWorkOrder = value; }
        }

        [DataMember]
        public Decimal? ApprovedBillAmount
        {
            get { return _ApprovedBillAmount; }
            set { _ApprovedBillAmount = value; }
        }

        [DataMember]
        public Decimal? NetPayableConsideringBillAndSecurity
        {
            get { return _NetPayableConsideringBillAndSecurity; }
            set { _NetPayableConsideringBillAndSecurity = value; }
        }

        [DataMember]
        public Boolean PartyReconcile
        {
            get { return _PartyReconcile; }
            set { _PartyReconcile = value; }
        }

        [DataMember]
        public Int64? RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public DateTime? RequisitionDate
        {
            get { return _RequisitionDate; }
            set { _RequisitionDate = value; }
        }

        [DataMember]
        public Int64? BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }

        [DataMember]
        public String BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        [DataMember]
        public DateTime? BillDate
        {
            get { return _BillDate; }
            set { _BillDate = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String ACCPrePayableStatementDetailRef
        {
            get { return _ACCPrePayableStatementDetailRef; }
            set { _ACCPrePayableStatementDetailRef = value; }
        }

        [DataMember]
        public Int64 VendorCategoryID
        {
            get { return _VendorCategoryID; }
            set { _VendorCategoryID = value; }
        }

        [DataMember]
        public Int64 FromVendorID
        {
            get { return _FromVendorID; }
            set { _FromVendorID = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public DateTime DueDate
        {
            get { return _DueDate; }
            set { _DueDate = value; }
        }

        [DataMember]
        public DateTime? PlannedDate
        {
            get { return _PlannedDate; }
            set { _PlannedDate = value; }
        }

        [DataMember]
        public String AdditionalRemarks
        {
            get { return _AdditionalRemarks; }
            set { _AdditionalRemarks = value; }
        }

        [DataMember]
        public Int64 ACCPayablePaymentStatusID
        {
            get { return _ACCPayablePaymentStatusID; }
            set { _ACCPayablePaymentStatusID = value; }
        }

        [DataMember]
        public Int64 ACCPayableApprovalStatusID
        {
            get { return _ACCPayableApprovalStatusID; }
            set { _ACCPayableApprovalStatusID = value; }
        }

        [DataMember]
        public Int64? AccountPaybleStatementDetailCategoryID
        {
            get { return _AccountPaybleStatementDetailCategoryID; }
            set { _AccountPaybleStatementDetailCategoryID = value; }
        }

        [DataMember]
        public Int64? PayableClassificationID
        {
            get { return _PayableClassificationID; }
            set { _PayableClassificationID = value; }
        }

        [DataMember]
        public Int64 CreateByEmployeeID
        {
            get { return _CreateByEmployeeID; }
            set { _CreateByEmployeeID = value; }
        }

        [DataMember]
        public Int64 APPanelID
        {
            get { return _APPanelID; }
            set { _APPanelID = value; }
        }

        [DataMember]
        public String IPAddress
        {
            get { return _IPAddress; }
            set { _IPAddress = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public Boolean IsLocked
        {
            get { return _IsLocked; }
            set { _IsLocked = value; }
        }

        [DataMember]
        public Int64 ACCPrePayableStatementID
        {
            get { return _ACCPrePayableStatementID; }
            set { _ACCPrePayableStatementID = value; }
        }

        [DataMember]
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        [DataMember]
        public String ACCPrePayableStatementRef
        {
            get { return _ACCPrePayableStatementRef; }
            set { _ACCPrePayableStatementRef = value; }
        }

        [DataMember]
        public Int64 ACCPrePayableStatementDetailPrePayableStatementID
        {
            get { return _ACCPrePayableStatementDetailPrePayableStatementID; }
            set { _ACCPrePayableStatementDetailPrePayableStatementID = value; }
        }

        [DataMember]
        public String BDProjectProjectName
        {
            get { return _BDProjectProjectName; }
            set { _BDProjectProjectName = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }

        [DataMember]
        public String MDACCPayablePaymentStatusName
        {
            get { return _MDACCPayablePaymentStatusName; }
            set { _MDACCPayablePaymentStatusName = value; }
        }

        [DataMember]
        public String MDACCPayableApprovalStatusName
        {
            get { return _MDACCPayableApprovalStatusName; }
            set { _MDACCPayableApprovalStatusName = value; }
        }

        [DataMember]
        public String MDAccountPaybleStatementDetailCategoryName
        {
            get { return _MDAccountPaybleStatementDetailCategoryName; }
            set { _MDAccountPaybleStatementDetailCategoryName = value; }
        }

        [DataMember]
        public String MDPayableClassificationName
        {
            get { return _MDPayableClassificationName; }
            set { _MDPayableClassificationName = value; }
        }

        [DataMember]
        public String EmployeeMemberFullName
        {
            get { return _EmployeeMemberFullName; }
            set { _EmployeeMemberFullName = value; }
        }

        [DataMember]
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (PrePayableStatementDetailID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACCPrePayableStatement_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PrePayableStatementDetailID = "PrePayableStatementDetailID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_WorkOrderAmount = "WorkOrderAmount";
        public const String FLD_NAME_WorkOrderDate = "WorkOrderDate";
        public const String FLD_NAME_PaidAmount = "PaidAmount";
        public const String FLD_NAME_SecurityMoney = "SecurityMoney";
        public const String FLD_NAME_TDSAmount = "TDSAmount";
        public const String FLD_NAME_PayableAgainstWorkOrder = "PayableAgainstWorkOrder";
        public const String FLD_NAME_ApprovedBillAmount = "ApprovedBillAmount";
        public const String FLD_NAME_NetPayableConsideringBillAndSecurity = "NetPayableConsideringBillAndSecurity";
        public const String FLD_NAME_PartyReconcile = "PartyReconcile";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_RequisitionDate = "RequisitionDate";
        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_BillNo = "BillNo";
        public const String FLD_NAME_BillDate = "BillDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_ACCPrePayableStatementDetailRef = "ACCPrePayableStatementDetailRef";
        public const String FLD_NAME_VendorCategoryID = "VendorCategoryID";
        public const String FLD_NAME_FromVendorID = "FromVendorID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_DueDate = "DueDate";
        public const String FLD_NAME_PlannedDate = "PlannedDate";
        public const String FLD_NAME_AdditionalRemarks = "AdditionalRemarks";
        public const String FLD_NAME_ACCPayablePaymentStatusID = "ACCPayablePaymentStatusID";
        public const String FLD_NAME_ACCPayableApprovalStatusID = "ACCPayableApprovalStatusID";
        public const String FLD_NAME_AccountPaybleStatementDetailCategoryID = "AccountPaybleStatementDetailCategoryID";
        public const String FLD_NAME_PayableClassificationID = "PayableClassificationID";
        public const String FLD_NAME_CreateByEmployeeID = "CreateByEmployeeID";
        public const String FLD_NAME_APPanelID = "APPanelID";
        public const String FLD_NAME_IPAddress = "IPAddress";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_IsLocked = "IsLocked";
        public const String FLD_NAME_ACCPrePayableStatementID = "ACCPrePayableStatementID";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_ACCPrePayableStatementRef = "ACCPrePayableStatementRef";
        public const String FLD_NAME_ACCPrePayableStatementDetailPrePayableStatementID = "ACCPrePayableStatementDetailPrePayableStatementID";
        public const String FLD_NAME_BDProjectProjectName = "BDProjectProjectName";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_MDACCPayablePaymentStatusName = "MDACCPayablePaymentStatusName";
        public const String FLD_NAME_MDACCPayableApprovalStatusName = "MDACCPayableApprovalStatusName";
        public const String FLD_NAME_MDAccountPaybleStatementDetailCategoryName = "MDAccountPaybleStatementDetailCategoryName";
        public const String FLD_NAME_MDPayableClassificationName = "MDPayableClassificationName";
        public const String FLD_NAME_EmployeeMemberFullName = "EmployeeMemberFullName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
