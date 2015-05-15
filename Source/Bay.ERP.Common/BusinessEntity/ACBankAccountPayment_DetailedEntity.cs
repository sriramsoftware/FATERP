// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jul-2013, 11:50:30




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACBankAccountPayment_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACBankAccountPayment_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _BankAccountPaymentID;
        private DateTime _PaymentDate;
        private Int64 _PayToID;
        private Int64? _ReferenceID;
        private Int64 _BankAccountID;
        private String _Reference;
        private String _Name;
        private String _Memo;
        private Int64 _PreparedByEmployeeID;
        private Int64 _BankAccountPaymentApprovalStatusID;
        private String _PayToName;
        private String _BankAccountName;
        private String _BankAccountPaymentApprovalStatusName;
        private String _MemberFullName;
        private Int64? _RowNumber;
        private String _BankAccountNumber;


        [DataMember]
        public Int64 BankAccountPaymentID
        {
            get { return _BankAccountPaymentID; }
            set { _BankAccountPaymentID = value; }
        }

        [DataMember]
        public DateTime PaymentDate
        {
            get { return _PaymentDate; }
            set { _PaymentDate = value; }
        }

        [DataMember]
        public Int64 PayToID
        {
            get { return _PayToID; }
            set { _PayToID = value; }
        }

        [DataMember]
        public Int64? ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public Int64 BankAccountID
        {
            get { return _BankAccountID; }
            set { _BankAccountID = value; }
        }

        [DataMember]
        public String Reference
        {
            get { return _Reference; }
            set { _Reference = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Memo
        {
            get { return _Memo; }
            set { _Memo = value; }
        }

        [DataMember]
        public Int64 PreparedByEmployeeID
        {
            get { return _PreparedByEmployeeID; }
            set { _PreparedByEmployeeID = value; }
        }

        [DataMember]
        public Int64 BankAccountPaymentApprovalStatusID
        {
            get { return _BankAccountPaymentApprovalStatusID; }
            set { _BankAccountPaymentApprovalStatusID = value; }
        }

        [DataMember]
        public String PayToName
        {
            get { return _PayToName; }
            set { _PayToName = value; }
        }

        [DataMember]
        public String BankAccountName
        {
            get { return _BankAccountName; }
            set { _BankAccountName = value; }
        }

        [DataMember]
        public String BankAccountPaymentApprovalStatusName
        {
            get { return _BankAccountPaymentApprovalStatusName; }
            set { _BankAccountPaymentApprovalStatusName = value; }
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

        [DataMember]
        public String BankAccountNumber
        {
            get { return _BankAccountNumber; }
            set { _BankAccountNumber = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BankAccountPaymentID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACBankAccountPayment_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BankAccountPaymentID = "BankAccountPaymentID";
        public const String FLD_NAME_PaymentDate = "PaymentDate";
        public const String FLD_NAME_PayToID = "PayToID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_BankAccountID = "BankAccountID";
        public const String FLD_NAME_Reference = "Reference";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Memo = "Memo";
        public const String FLD_NAME_PreparedByEmployeeID = "PreparedByEmployeeID";
        public const String FLD_NAME_BankAccountPaymentApprovalStatusID = "BankAccountPaymentApprovalStatusID";
        public const String FLD_NAME_PayToName = "PayToName";
        public const String FLD_NAME_BankAccountName = "BankAccountName";
        public const String FLD_NAME_BankAccountPaymentApprovalStatusName = "BankAccountPaymentApprovalStatusName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_RowNumber = "RowNumber";
        public const String FLD_NAME_BankAccountNumber = "BankAccountNumber";

        #endregion
    }
}
