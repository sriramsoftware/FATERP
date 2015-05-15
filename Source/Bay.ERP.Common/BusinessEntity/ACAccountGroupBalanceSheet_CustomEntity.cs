// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Feb-2013, 02:55:23




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACAccountGroupBalanceSheet_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACAccountGroupBalanceSheet_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64? _AccountGroupID;
        private Decimal _DebitAmount;
        private Decimal _CreditAmount;
        private Decimal? _Balance;
        private String _AccountGroup;


        [DataMember]
        public Int64? AccountGroupID
        {
            get { return _AccountGroupID; }
            set { _AccountGroupID = value; }
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
        public String AccountGroup
        {
            get { return _AccountGroup; }
            set { _AccountGroup = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (AccountGroupID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACAccountGroupBalanceSheet_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AccountGroupID = "AccountGroupID";
        public const String FLD_NAME_DebitAmount = "DebitAmount";
        public const String FLD_NAME_CreditAmount = "CreditAmount";
        public const String FLD_NAME_Balance = "Balance";
        public const String FLD_NAME_AccountGroup = "AccountGroup";

        #endregion
    }
}
