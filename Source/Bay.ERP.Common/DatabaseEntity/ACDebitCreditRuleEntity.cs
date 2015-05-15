// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACDebitCreditRule", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACDebitCreditRuleEntity : BaseEntity
    {
        #region Properties


        private Int64 _ACDebitCreditRuleID;
        private Int64 _DebitCreditActionID;
        private Boolean _IsUp;
        private Boolean _IsDown;
        private Int64 _MDDebitCreditID;


        [DataMember]
        public Int64 ACDebitCreditRuleID
        {
            get { return _ACDebitCreditRuleID; }
            set { _ACDebitCreditRuleID = value; }
        }

        [DataMember]
        public Int64 DebitCreditActionID
        {
            get { return _DebitCreditActionID; }
            set { _DebitCreditActionID = value; }
        }

        [DataMember]
        public Boolean IsUp
        {
            get { return _IsUp; }
            set { _IsUp = value; }
        }

        [DataMember]
        public Boolean IsDown
        {
            get { return _IsDown; }
            set { _IsDown = value; }
        }

        [DataMember]
        public Int64 MDDebitCreditID
        {
            get { return _MDDebitCreditID; }
            set { _MDDebitCreditID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ACDebitCreditRuleID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACDebitCreditRuleEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ACDebitCreditRuleID = "ACDebitCreditRuleID";
        public const String FLD_NAME_DebitCreditActionID = "DebitCreditActionID";
        public const String FLD_NAME_IsUp = "IsUp";
        public const String FLD_NAME_IsDown = "IsDown";
        public const String FLD_NAME_MDDebitCreditID = "MDDebitCreditID";

        #endregion
    }
}
