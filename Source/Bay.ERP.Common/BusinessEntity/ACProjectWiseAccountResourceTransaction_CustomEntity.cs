// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACProjectWiseAccountResourceTransaction_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACProjectWiseAccountResourceTransaction_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64? _AccountID;
        private Decimal _DebitAmount;
        private Decimal _CreditAmount;
        private Decimal? _Balance;
        private String _AccountName;
        private String _AccountCode;
        private String _AccountGroupName;
        private String _ClassName;
        private String _ClassTypeName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64? AccountID
        {
            get { return _AccountID; }
            set { _AccountID = value; }
        }

        [DataMember]
        public Decimal DebitAmount
        {
            get { return _DebitAmount; }
            set { _DebitAmount = value; }
        }

        [DataMember]
        public Decimal CreditAmount
        {
            get { return _CreditAmount; }
            set { _CreditAmount = value; }
        }

        [DataMember]
        public Decimal? Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }

        [DataMember]
        public String AccountName
        {
            get { return _AccountName; }
            set { _AccountName = value; }
        }

        [DataMember]
        public String AccountCode
        {
            get { return _AccountCode; }
            set { _AccountCode = value; }
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
                return (AccountID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACProjectWiseAccountResourceTransaction_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AccountID = "AccountID";
        public const String FLD_NAME_DebitAmount = "DebitAmount";
        public const String FLD_NAME_CreditAmount = "CreditAmount";
        public const String FLD_NAME_Balance = "Balance";
        public const String FLD_NAME_AccountName = "AccountName";
        public const String FLD_NAME_AccountCode = "AccountCode";
        public const String FLD_NAME_AccountGroupName = "AccountGroupName";
        public const String FLD_NAME_ClassName = "ClassName";
        public const String FLD_NAME_ClassTypeName = "ClassTypeName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
