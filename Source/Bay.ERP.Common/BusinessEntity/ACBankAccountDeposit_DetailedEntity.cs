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
    [DataContract(Name = "ACBankAccountDeposit_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACBankAccountDeposit_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _BankAccountDepositID;
        private DateTime _DepositDate;
        private Int64 _PaidFromID;
        private Int64? _ReferenceID;
        private Int64 _BankAccountID;
        private String _Reference;
        private String _Name;
        private String _Memo;
        private Int64 _BankAccountDepositApprovalStatusID;
        private Int64 _PreparedByEmployeeID;
        private String _MemberFullName;
        private String _PaidFromName;
        private String _BankAccountName;
        private String _BankAccountDepositApprovalStatusName;
        private Int64? _RowNumber;
        private String _BankAccountNumber;


        [DataMember]
        public Int64 BankAccountDepositID
        {
            get { return _BankAccountDepositID; }
            set { _BankAccountDepositID = value; }
        }

        [DataMember]
        public DateTime DepositDate
        {
            get { return _DepositDate; }
            set { _DepositDate = value; }
        }

        [DataMember]
        public Int64 PaidFromID
        {
            get { return _PaidFromID; }
            set { _PaidFromID = value; }
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
        public Int64 BankAccountDepositApprovalStatusID
        {
            get { return _BankAccountDepositApprovalStatusID; }
            set { _BankAccountDepositApprovalStatusID = value; }
        }

        [DataMember]
        public Int64 PreparedByEmployeeID
        {
            get { return _PreparedByEmployeeID; }
            set { _PreparedByEmployeeID = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public String PaidFromName
        {
            get { return _PaidFromName; }
            set { _PaidFromName = value; }
        }

        [DataMember]
        public String BankAccountName
        {
            get { return _BankAccountName; }
            set { _BankAccountName = value; }
        }

        [DataMember]
        public String BankAccountDepositApprovalStatusName
        {
            get { return _BankAccountDepositApprovalStatusName; }
            set { _BankAccountDepositApprovalStatusName = value; }
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
                return (BankAccountDepositID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACBankAccountDeposit_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BankAccountDepositID = "BankAccountDepositID";
        public const String FLD_NAME_DepositDate = "DepositDate";
        public const String FLD_NAME_PaidFromID = "PaidFromID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_BankAccountID = "BankAccountID";
        public const String FLD_NAME_Reference = "Reference";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Memo = "Memo";
        public const String FLD_NAME_BankAccountDepositApprovalStatusID = "BankAccountDepositApprovalStatusID";
        public const String FLD_NAME_PreparedByEmployeeID = "PreparedByEmployeeID";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_PaidFromName = "PaidFromName";
        public const String FLD_NAME_BankAccountName = "BankAccountName";
        public const String FLD_NAME_BankAccountDepositApprovalStatusName = "BankAccountDepositApprovalStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";
        public const String FLD_NAME_BankAccountNumber = "BankAccountNumber";

        #endregion
    }
}
