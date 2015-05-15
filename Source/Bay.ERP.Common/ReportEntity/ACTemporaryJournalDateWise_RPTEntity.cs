// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2013, 11:29:54




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACTemporaryJournalDateWise_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACTemporaryJournalDateWise_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _TemporaryJournalID;
        private Int64 _TemporaryJournalMasterID;
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
        private String _AccountCode;
        private String _AccountName;
        private String _AccountGroupName;
        private String _DimensionName;
        private String _ItemName;
        private String _RequisitionNo;
        private String _WorkOrderNo;
        private String _BillNo;
        private String _ProjectCode;
        private String _ProjectName;
        private String _ProjectFloorName;
        private String _ProjectFloorUnitName;
        private String _MemberFullName;


        [DataMember]
        public Int64 TemporaryJournalID
        {
            get { return _TemporaryJournalID; }
            set { _TemporaryJournalID = value; }
        }

        [DataMember]
        public Int64 TemporaryJournalMasterID
        {
            get { return _TemporaryJournalMasterID; }
            set { _TemporaryJournalMasterID = value; }
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
        public String AccountCode
        {
            get { return _AccountCode; }
            set { _AccountCode = value; }
        }

        [DataMember]
        public String AccountName
        {
            get { return _AccountName; }
            set { _AccountName = value; }
        }

        [DataMember]
        public String AccountGroupName
        {
            get { return _AccountGroupName; }
            set { _AccountGroupName = value; }
        }

        [DataMember]
        public String DimensionName
        {
            get { return _DimensionName; }
            set { _DimensionName = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public String BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String ProjectFloorName
        {
            get { return _ProjectFloorName; }
            set { _ProjectFloorName = value; }
        }

        [DataMember]
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (TemporaryJournalID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACTemporaryJournalDateWise_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TemporaryJournalID = "TemporaryJournalID";
        public const String FLD_NAME_TemporaryJournalMasterID = "TemporaryJournalMasterID";
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
        public const String FLD_NAME_AccountCode = "AccountCode";
        public const String FLD_NAME_AccountName = "AccountName";
        public const String FLD_NAME_AccountGroupName = "AccountGroupName";
        public const String FLD_NAME_DimensionName = "DimensionName";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_BillNo = "BillNo";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ProjectFloorName = "ProjectFloorName";
        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";

        #endregion
    }
}
