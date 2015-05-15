// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Feb-2013, 02:12:00




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACAccountsHelper_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACAccountsHelper_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _AccountID;
        private Int64 _ClassTypeID;
        private String _AccountCode;
        private String _AccountCode2;
        private String _AccountName;
        private String _Description;
        private Int64 _AccountStatusID;
        private Int64 _TaxTypeID;
        private Boolean _IsRemoved;
        private String _AccountClassTypeName;
        private Int64 _ClassID;
        private Int64 _AccountGroupID;
        private String _AccountGroupName;
        private String _AccountClassName;
        private Int64? _BankAccountID;
        private String _BankAccountName;


        [DataMember]
        public Int64 AccountID
        {
            get { return _AccountID; }
            set { _AccountID = value; }
        }

        [DataMember]
        public Int64 ClassTypeID
        {
            get { return _ClassTypeID; }
            set { _ClassTypeID = value; }
        }

        [DataMember]
        public String AccountCode
        {
            get { return _AccountCode; }
            set { _AccountCode = value; }
        }

        [DataMember]
        public String AccountCode2
        {
            get { return _AccountCode2; }
            set { _AccountCode2 = value; }
        }

        [DataMember]
        public String AccountName
        {
            get { return _AccountName; }
            set { _AccountName = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Int64 AccountStatusID
        {
            get { return _AccountStatusID; }
            set { _AccountStatusID = value; }
        }

        [DataMember]
        public Int64 TaxTypeID
        {
            get { return _TaxTypeID; }
            set { _TaxTypeID = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String AccountClassTypeName
        {
            get { return _AccountClassTypeName; }
            set { _AccountClassTypeName = value; }
        }

        [DataMember]
        public Int64 ClassID
        {
            get { return _ClassID; }
            set { _ClassID = value; }
        }

        [DataMember]
        public Int64 AccountGroupID
        {
            get { return _AccountGroupID; }
            set { _AccountGroupID = value; }
        }

        [DataMember]
        public String AccountGroupName
        {
            get { return _AccountGroupName; }
            set { _AccountGroupName = value; }
        }

        [DataMember]
        public String AccountClassName
        {
            get { return _AccountClassName; }
            set { _AccountClassName = value; }
        }

        [DataMember]
        public Int64? BankAccountID
        {
            get { return _BankAccountID; }
            set { _BankAccountID = value; }
        }

        [DataMember]
        public String BankAccountName
        {
            get { return _BankAccountName; }
            set { _BankAccountName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (AccountID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACAccountsHelper_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AccountID = "AccountID";
        public const String FLD_NAME_ClassTypeID = "ClassTypeID";
        public const String FLD_NAME_AccountCode = "AccountCode";
        public const String FLD_NAME_AccountCode2 = "AccountCode2";
        public const String FLD_NAME_AccountName = "AccountName";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_AccountStatusID = "AccountStatusID";
        public const String FLD_NAME_TaxTypeID = "TaxTypeID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_AccountClassTypeName = "AccountClassTypeName";
        public const String FLD_NAME_ClassID = "ClassID";
        public const String FLD_NAME_AccountGroupID = "AccountGroupID";
        public const String FLD_NAME_AccountGroupName = "AccountGroupName";
        public const String FLD_NAME_AccountClassName = "AccountClassName";
        public const String FLD_NAME_BankAccountID = "BankAccountID";
        public const String FLD_NAME_BankAccountName = "BankAccountName";

        #endregion
    }
}
