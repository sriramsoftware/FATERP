// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jul-2013, 02:28:49




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACTemporaryJournal", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACTemporaryJournalEntity : BaseEntity
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
        private Int64? _ItemID;
        private Int64? _ProjectID;
        private Int64 _FiscalYearID;
        private Boolean _IsReverseTransaction;
        private Int64? _ReverseTransactionJournalID;
        private Int64? _RequisitionID;
        private Int64? _WorkOrderID;
        private Int64? _BillID;
        private Int64? _ProjectFloorID;
        private Int64? _ProjectFloorUnitID;


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
        public Int64? ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
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
        public Int64? RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
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

        public ACTemporaryJournalEntity() : base()
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
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_IsReverseTransaction = "IsReverseTransaction";
        public const String FLD_NAME_ReverseTransactionJournalID = "ReverseTransactionJournalID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";

        #endregion
    }
}
