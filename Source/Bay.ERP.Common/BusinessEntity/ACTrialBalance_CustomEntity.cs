// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Apr-2013, 11:16:54




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACTrialBalance_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACTrialBalance_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64? _AccountID;
        private Decimal _DebitAmount;
        private Decimal _CreditAmount;
        private Decimal? _Balance;
        private Int64? _ClassID;
        private Int64? _ClassTypeID;
        private Int64? _ProjectID;
        private String _AccountCode;
        private String _AccountName;
        private String _AccountGroupName;
        private Int64? _AccountGroupID;
        private String _ClassName;
        private String _ClassTypeName;
        private String _ProjectCode;
        private String _ProjectName;


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
        public Int64? ClassID
        {
            get { return _ClassID; }
            set { _ClassID = value; }
        }

        [DataMember]
        public Int64? ClassTypeID
        {
            get { return _ClassTypeID; }
            set { _ClassTypeID = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String AccountCode
        {
            get { return _AccountCode; }
            set { _AccountCode = value; }
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
        public Int64? AccountGroupID
        {
            get { return _AccountGroupID; }
            set { _AccountGroupID = value; }
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
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
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

        public ACTrialBalance_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AccountID = "AccountID";
        public const String FLD_NAME_DebitAmount = "DebitAmount";
        public const String FLD_NAME_CreditAmount = "CreditAmount";
        public const String FLD_NAME_Balance = "Balance";
        public const String FLD_NAME_ClassID = "ClassID";
        public const String FLD_NAME_ClassTypeID = "ClassTypeID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_AccountCode = "AccountCode";
        public const String FLD_NAME_AccountName = "AccountName";
        public const String FLD_NAME_AccountGroupName = "AccountGroupName";
        public const String FLD_NAME_AccountGroupID = "AccountGroupID";
        public const String FLD_NAME_ClassName = "ClassName";
        public const String FLD_NAME_ClassTypeName = "ClassTypeName";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";

        #endregion
    }
}
