// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jul-2013, 02:08:47




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACJournal_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACJournal_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _JournalID;
        private Int64 _AccountID;
        private Int64 _AccountGroupID;
        private Int64 _ClassID;
        private Int64 _ClassTypeID;
        private DateTime _TransactionDateTime;
        private Decimal _Amount;
        private Int64 _EnteredByEmployeeID;
        private String _ReferenceOrMemoOrID;
        private String _Note;
        private Int64 _MDDebitCreditID;
        private Int64? _DimensionID;
        private Int64? _ProjectID;
        private Int64 _FiscalYearID;
        private Boolean _IsReverseTransaction;
        private Int64? _ReverseTransactionJournalID;
        private String _VoucherType;
        private String _AccountCode;
        private String _ACAccountAccountName;
        private String _ACAccountGroupName;
        private String _ACClassName;
        private String _ACClassTypeName;
        private Int64? _HREmployeeMemberID;
        private String _ACMDDebitCreditName;
        private String _ACDimensionName;
        private String _BDProjectProjectName;
        private String _ACFiscalYear;
        private String _MemberFullName;
        private Int64? _WorkOrderID;
        private Int64? _BillID;
        private Int64? _ProjectFloorID;
        private Int64? _ProjectFloorUnitID;
        private String _BillNo;
        private String _RequisitionNo;
        private String _ProjectFloorName;
        private String _WorkOrderNo;
        private String _ProjectFloorUnitName;
        private Int64? _ItemID;
        private String _ItemName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 JournalID
        {
            get { return _JournalID; }
            set { _JournalID = value; }
        }

        [DataMember]
        public Int64 AccountID
        {
            get { return _AccountID; }
            set { _AccountID = value; }
        }

        [DataMember]
        public Int64 AccountGroupID
        {
            get { return _AccountGroupID; }
            set { _AccountGroupID = value; }
        }

        [DataMember]
        public Int64 ClassID
        {
            get { return _ClassID; }
            set { _ClassID = value; }
        }

        [DataMember]
        public Int64 ClassTypeID
        {
            get { return _ClassTypeID; }
            set { _ClassTypeID = value; }
        }

        [DataMember]
        public DateTime TransactionDateTime
        {
            get { return _TransactionDateTime; }
            set { _TransactionDateTime = value; }
        }

        [DataMember]
        public Decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        [DataMember]
        public Int64 EnteredByEmployeeID
        {
            get { return _EnteredByEmployeeID; }
            set { _EnteredByEmployeeID = value; }
        }

        [DataMember]
        public String ReferenceOrMemoOrID
        {
            get { return _ReferenceOrMemoOrID; }
            set { _ReferenceOrMemoOrID = value; }
        }

        [DataMember]
        public String Note
        {
            get { return _Note; }
            set { _Note = value; }
        }

        [DataMember]
        public Int64 MDDebitCreditID
        {
            get { return _MDDebitCreditID; }
            set { _MDDebitCreditID = value; }
        }

        [DataMember]
        public Int64? DimensionID
        {
            get { return _DimensionID; }
            set { _DimensionID = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [DataMember]
        public Boolean IsReverseTransaction
        {
            get { return _IsReverseTransaction; }
            set { _IsReverseTransaction = value; }
        }

        [DataMember]
        public Int64? ReverseTransactionJournalID
        {
            get { return _ReverseTransactionJournalID; }
            set { _ReverseTransactionJournalID = value; }
        }

        [DataMember]
        public String VoucherType
        {
            get { return _VoucherType; }
            set { _VoucherType = value; }
        }

        [DataMember]
        public String AccountCode
        {
            get { return _AccountCode; }
            set { _AccountCode = value; }
        }

        [DataMember]
        public String ACAccountAccountName
        {
            get { return _ACAccountAccountName; }
            set { _ACAccountAccountName = value; }
        }

        [DataMember]
        public String ACAccountGroupName
        {
            get { return _ACAccountGroupName; }
            set { _ACAccountGroupName = value; }
        }

        [DataMember]
        public String ACClassName
        {
            get { return _ACClassName; }
            set { _ACClassName = value; }
        }

        [DataMember]
        public String ACClassTypeName
        {
            get { return _ACClassTypeName; }
            set { _ACClassTypeName = value; }
        }

        [DataMember]
        public Int64? HREmployeeMemberID
        {
            get { return _HREmployeeMemberID; }
            set { _HREmployeeMemberID = value; }
        }

        [DataMember]
        public String ACMDDebitCreditName
        {
            get { return _ACMDDebitCreditName; }
            set { _ACMDDebitCreditName = value; }
        }

        [DataMember]
        public String ACDimensionName
        {
            get { return _ACDimensionName; }
            set { _ACDimensionName = value; }
        }

        [DataMember]
        public String BDProjectProjectName
        {
            get { return _BDProjectProjectName; }
            set { _BDProjectProjectName = value; }
        }

        [DataMember]
        public String ACFiscalYear
        {
            get { return _ACFiscalYear; }
            set { _ACFiscalYear = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public Int64? WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public Int64? BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }

        [DataMember]
        public Int64? ProjectFloorID
        {
            get { return _ProjectFloorID; }
            set { _ProjectFloorID = value; }
        }

        [DataMember]
        public Int64? ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public String BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public String ProjectFloorName
        {
            get { return _ProjectFloorName; }
            set { _ProjectFloorName = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
        }

        [DataMember]
        public Int64? ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
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
                return (JournalID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACJournal_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_JournalID = "JournalID";
        public const String FLD_NAME_AccountID = "AccountID";
        public const String FLD_NAME_AccountGroupID = "AccountGroupID";
        public const String FLD_NAME_ClassID = "ClassID";
        public const String FLD_NAME_ClassTypeID = "ClassTypeID";
        public const String FLD_NAME_TransactionDateTime = "TransactionDateTime";
        public const String FLD_NAME_Amount = "Amount";
        public const String FLD_NAME_EnteredByEmployeeID = "EnteredByEmployeeID";
        public const String FLD_NAME_ReferenceOrMemoOrID = "ReferenceOrMemoOrID";
        public const String FLD_NAME_Note = "Note";
        public const String FLD_NAME_MDDebitCreditID = "MDDebitCreditID";
        public const String FLD_NAME_DimensionID = "DimensionID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_IsReverseTransaction = "IsReverseTransaction";
        public const String FLD_NAME_ReverseTransactionJournalID = "ReverseTransactionJournalID";
        public const String FLD_NAME_VoucherType = "VoucherType";
        public const String FLD_NAME_AccountCode = "AccountCode";
        public const String FLD_NAME_ACAccountAccountName = "ACAccountAccountName";
        public const String FLD_NAME_ACAccountGroupName = "ACAccountGroupName";
        public const String FLD_NAME_ACClassName = "ACClassName";
        public const String FLD_NAME_ACClassTypeName = "ACClassTypeName";
        public const String FLD_NAME_HREmployeeMemberID = "HREmployeeMemberID";
        public const String FLD_NAME_ACMDDebitCreditName = "ACMDDebitCreditName";
        public const String FLD_NAME_ACDimensionName = "ACDimensionName";
        public const String FLD_NAME_BDProjectProjectName = "BDProjectProjectName";
        public const String FLD_NAME_ACFiscalYear = "ACFiscalYear";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_BillNo = "BillNo";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_ProjectFloorName = "ProjectFloorName";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
