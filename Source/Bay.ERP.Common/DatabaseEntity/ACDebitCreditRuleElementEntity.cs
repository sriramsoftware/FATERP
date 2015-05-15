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
    [DataContract(Name = "ACDebitCreditRuleElement", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACDebitCreditRuleElementEntity : BaseEntity
    {
        #region Properties


        private Int64 _DebitCreditRuleElementID;
        private String _Action;


        [DataMember]
        public Int64 DebitCreditRuleElementID
        {
            get { return _DebitCreditRuleElementID; }
            set { _DebitCreditRuleElementID = value; }
        }

        [DataMember]
        public String Action
        {
            get { return _Action; }
            set { _Action = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (DebitCreditRuleElementID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACDebitCreditRuleElementEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_DebitCreditRuleElementID = "DebitCreditRuleElementID";
        public const String FLD_NAME_Action = "Action";

        #endregion
    }
}
