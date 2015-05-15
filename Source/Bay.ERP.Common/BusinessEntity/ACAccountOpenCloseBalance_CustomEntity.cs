// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Feb-2013, 12:02:49




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACAccountOpenCloseBalance_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACAccountOpenCloseBalance_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64? _AccountID;
        private Decimal _CloseDebitAmount;
        private Decimal _CloseCreditAmount;
        private Decimal? _CloseBalance;
        private String _AccountName;
        private String _AccountGroupName;
        private String _ClassName;
        private String _ClassTypeName;
        private String _AccountCode;
        private Decimal _OpenBalance;
        private Decimal? _OpenDebitAmount;
        private Decimal? _OpenCreditAmount;


        [DataMember]
        public Int64? AccountID
        {
            get { return _AccountID; }
            set { _AccountID = value; }
        }

        [DataMember]
        public Decimal CloseDebitAmount
        {
            get { return _CloseDebitAmount; }
            set { _CloseDebitAmount = value; }
        }

        [DataMember]
        public Decimal CloseCreditAmount
        {
            get { return _CloseCreditAmount; }
            set { _CloseCreditAmount = value; }
        }

        [DataMember]
        public Decimal? CloseBalance
        {
            get { return _CloseBalance; }
            set { _CloseBalance = value; }
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
        public String ClassName
        {
            get { return _ClassName; }
            set { _ClassName = value; }
        }

        [DataMember]
        public String ClassTypeName
        {
            get { return _ClassTypeName; }
            set { _ClassTypeName = value; }
        }

        [DataMember]
        public String AccountCode
        {
            get { return _AccountCode; }
            set { _AccountCode = value; }
        }

        [DataMember]
        public Decimal OpenBalance
        {
            get { return _OpenBalance; }
            set { _OpenBalance = value; }
        }

        [DataMember]
        public Decimal? OpenDebitAmount
        {
            get { return _OpenDebitAmount; }
            set { _OpenDebitAmount = value; }
        }

        [DataMember]
        public Decimal? OpenCreditAmount
        {
            get { return _OpenCreditAmount; }
            set { _OpenCreditAmount = value; }
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

        public ACAccountOpenCloseBalance_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AccountID = "AccountID";
        public const String FLD_NAME_CloseDebitAmount = "CloseDebitAmount";
        public const String FLD_NAME_CloseCreditAmount = "CloseCreditAmount";
        public const String FLD_NAME_CloseBalance = "CloseBalance";
        public const String FLD_NAME_AccountName = "AccountName";
        public const String FLD_NAME_AccountGroupName = "AccountGroupName";
        public const String FLD_NAME_ClassName = "ClassName";
        public const String FLD_NAME_ClassTypeName = "ClassTypeName";
        public const String FLD_NAME_AccountCode = "AccountCode";
        public const String FLD_NAME_OpenBalance = "OpenBalance";
        public const String FLD_NAME_OpenDebitAmount = "OpenDebitAmount";
        public const String FLD_NAME_OpenCreditAmount = "OpenCreditAmount";

        #endregion
    }
}
