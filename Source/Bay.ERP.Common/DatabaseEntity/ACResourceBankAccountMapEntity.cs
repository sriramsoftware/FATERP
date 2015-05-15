// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Jun-2013, 05:04:04




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACResourceBankAccountMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACResourceBankAccountMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _ResourceBankAccountMapID;
        private Int64 _AccountResourceCategoryID;
        private Int64 _ReferenceID;
        private String _BankAccountName;
        private String _BankAccountNumber;
        private Boolean _IsDefaultCurrencyAccount;
        private String _BankName;
        private String _BankAddress;
        private String _Remarks;


        [DataMember]
        public Int64 ResourceBankAccountMapID
        {
            get { return _ResourceBankAccountMapID; }
            set { _ResourceBankAccountMapID = value; }
        }

        [DataMember]
        public Int64 AccountResourceCategoryID
        {
            get { return _AccountResourceCategoryID; }
            set { _AccountResourceCategoryID = value; }
        }

        [DataMember]
        public Int64 ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
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
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ResourceBankAccountMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACResourceBankAccountMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ResourceBankAccountMapID = "ResourceBankAccountMapID";
        public const String FLD_NAME_AccountResourceCategoryID = "AccountResourceCategoryID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_BankAccountName = "BankAccountName";
        public const String FLD_NAME_BankAccountNumber = "BankAccountNumber";
        public const String FLD_NAME_IsDefaultCurrencyAccount = "IsDefaultCurrencyAccount";
        public const String FLD_NAME_BankName = "BankName";
        public const String FLD_NAME_BankAddress = "BankAddress";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
