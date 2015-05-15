// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jul-2013, 03:00:14




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACBankStatement_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACBankStatement_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _JournalID;
        private Int64 _AccountID;
        private DateTime _TransactionDateTime;
        private Decimal _Amount;
        private Int64 _EnteredByEmployeeID;
        private String _ReferenceOrMemoOrID;
        private String _Note;
        private Int64 _MDDebitCreditID;
        private Int64 _FiscalYearID;
        private String _VoucherType;
        private String _ACAccountAccountName;
        private String _ACMDDebitCreditName;
        private String _ACFiscalYear;
        private String _MemberFullName;
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
        public Int64 FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [DataMember]
        public String VoucherType
        {
            get { return _VoucherType; }
            set { _VoucherType = value; }
        }

        [DataMember]
        public String ACAccountAccountName
        {
            get { return _ACAccountAccountName; }
            set { _ACAccountAccountName = value; }
        }

        [DataMember]
        public String ACMDDebitCreditName
        {
            get { return _ACMDDebitCreditName; }
            set { _ACMDDebitCreditName = value; }
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

        public ACBankStatement_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_JournalID = "JournalID";
        public const String FLD_NAME_AccountID = "AccountID";
        public const String FLD_NAME_TransactionDateTime = "TransactionDateTime";
        public const String FLD_NAME_Amount = "Amount";
        public const String FLD_NAME_EnteredByEmployeeID = "EnteredByEmployeeID";
        public const String FLD_NAME_ReferenceOrMemoOrID = "ReferenceOrMemoOrID";
        public const String FLD_NAME_Note = "Note";
        public const String FLD_NAME_MDDebitCreditID = "MDDebitCreditID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_VoucherType = "VoucherType";
        public const String FLD_NAME_ACAccountAccountName = "ACAccountAccountName";
        public const String FLD_NAME_ACMDDebitCreditName = "ACMDDebitCreditName";
        public const String FLD_NAME_ACFiscalYear = "ACFiscalYear";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
