// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDItemThumbRule", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDItemThumbRuleEntity : BaseEntity
    {
        #region Properties


        private Int64 _MDItemThumbRuleID;
        private Int64 _ItemID;
        private Decimal _FloorRuleVariable;
        private Decimal _FloorQuantity;
        private Decimal _BasementRuleVariable;
        private Decimal _BasementQuantity;
        private Decimal _OverallRuleVariable;
        private Decimal _OverallQuantity;


        [DataMember]
        public Int64 MDItemThumbRuleID
        {
            get { return _MDItemThumbRuleID; }
            set { _MDItemThumbRuleID = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Decimal FloorRuleVariable
        {
            get { return _FloorRuleVariable; }
            set { _FloorRuleVariable = value; }
        }

        [DataMember]
        public Decimal FloorQuantity
        {
            get { return _FloorQuantity; }
            set { _FloorQuantity = value; }
        }

        [DataMember]
        public Decimal BasementRuleVariable
        {
            get { return _BasementRuleVariable; }
            set { _BasementRuleVariable = value; }
        }

        [DataMember]
        public Decimal BasementQuantity
        {
            get { return _BasementQuantity; }
            set { _BasementQuantity = value; }
        }

        [DataMember]
        public Decimal OverallRuleVariable
        {
            get { return _OverallRuleVariable; }
            set { _OverallRuleVariable = value; }
        }

        [DataMember]
        public Decimal OverallQuantity
        {
            get { return _OverallQuantity; }
            set { _OverallQuantity = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (MDItemThumbRuleID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDItemThumbRuleEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MDItemThumbRuleID = "MDItemThumbRuleID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_FloorRuleVariable = "FloorRuleVariable";
        public const String FLD_NAME_FloorQuantity = "FloorQuantity";
        public const String FLD_NAME_BasementRuleVariable = "BasementRuleVariable";
        public const String FLD_NAME_BasementQuantity = "BasementQuantity";
        public const String FLD_NAME_OverallRuleVariable = "OverallRuleVariable";
        public const String FLD_NAME_OverallQuantity = "OverallQuantity";

        #endregion
    }
}
