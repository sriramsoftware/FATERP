// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 04:44:22




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACBankAccount_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACBankAccount_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _BankAccountID;
        private Int64 _ACCAccountID;
        private String _BankAccountName;
        private String _BankAccountNumber;
        private Int64 _BankAccountTypeID;
        private Int64 _CurrencyID;
        private Boolean _IsDefaultCurrencyAccount;
        private String _BankName;
        private String _BankAddress;
        private String _AccountName;
        private String _BankAccountTypeName;
        private String _CurrencyName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 BankAccountID
        {
            get { return _BankAccountID; }
            set { _BankAccountID = value; }
        }

        [DataMember]
        public Int64 ACCAccountID
        {
            get { return _ACCAccountID; }
            set { _ACCAccountID = value; }
        }

        [DataMember]
        public String BankAccountName
        {
            get { return _BankAccountName; }
            set { _BankAccountName = value; }
        }

        [DataMember]
        public String BankAccountNumber
        {
            get { return _BankAccountNumber; }
            set { _BankAccountNumber = value; }
        }

        [DataMember]
        public Int64 BankAccountTypeID
        {
            get { return _BankAccountTypeID; }
            set { _BankAccountTypeID = value; }
        }

        [DataMember]
        public Int64 CurrencyID
        {
            get { return _CurrencyID; }
            set { _CurrencyID = value; }
        }

        [DataMember]
        public Boolean IsDefaultCurrencyAccount
        {
            get { return _IsDefaultCurrencyAccount; }
            set { _IsDefaultCurrencyAccount = value; }
        }

        [DataMember]
        public String BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }

        [DataMember]
        public String BankAddress
        {
            get { return _BankAddress; }
            set { _BankAddress = value; }
        }

        [DataMember]
        public String AccountName
        {
            get { return _AccountName; }
            set { _AccountName = value; }
        }

        [DataMember]
        public String BankAccountTypeName
        {
            get { return _BankAccountTypeName; }
            set { _BankAccountTypeName = value; }
        }

        [DataMember]
        public String CurrencyName
        {
            get { return _CurrencyName; }
            set { _CurrencyName = value; }
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
                return (BankAccountID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACBankAccount_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BankAccountID = "BankAccountID";
        public const String FLD_NAME_ACCAccountID = "ACCAccountID";
        public const String FLD_NAME_BankAccountName = "BankAccountName";
        public const String FLD_NAME_BankAccountNumber = "BankAccountNumber";
        public const String FLD_NAME_BankAccountTypeID = "BankAccountTypeID";
        public const String FLD_NAME_CurrencyID = "CurrencyID";
        public const String FLD_NAME_IsDefaultCurrencyAccount = "IsDefaultCurrencyAccount";
        public const String FLD_NAME_BankName = "BankName";
        public const String FLD_NAME_BankAddress = "BankAddress";
        public const String FLD_NAME_AccountName = "AccountName";
        public const String FLD_NAME_BankAccountTypeName = "BankAccountTypeName";
        public const String FLD_NAME_CurrencyName = "CurrencyName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
