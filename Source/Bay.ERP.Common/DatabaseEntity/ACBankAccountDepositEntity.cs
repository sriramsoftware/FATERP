// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2013, 11:20:53




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACBankAccountDeposit", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACBankAccountDepositEntity : BaseEntity
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

        public ACBankAccountDepositEntity() : base()
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

        #endregion
    }
}
