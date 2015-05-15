// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-May-2012, 02:13:26




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDApprovalRuleDesignationMap_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDApprovalRuleDesignationMap_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ApprovalRuleDesignationMapID;
        private Int64 _ApprovalRuleID;
        private Int64 _DesignationID;
        private Int32 _SequeenceNo;
        private String _ApprovalRuleName;
        private String _MDDesignationName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ApprovalRuleDesignationMapID
        {
            get { return _ApprovalRuleDesignationMapID; }
            set { _ApprovalRuleDesignationMapID = value; }
        }

        [DataMember]
        public Int64 ApprovalRuleID
        {
            get { return _ApprovalRuleID; }
            set { _ApprovalRuleID = value; }
        }

        [DataMember]
        public Int64 DesignationID
        {
            get { return _DesignationID; }
            set { _DesignationID = value; }
        }

        [DataMember]
        public Int32 SequeenceNo
        {
            get { return _SequeenceNo; }
            set { _SequeenceNo = value; }
        }

        [DataMember]
        public String ApprovalRuleName
        {
            get { return _ApprovalRuleName; }
            set { _ApprovalRuleName = value; }
        }

        [DataMember]
        public String MDDesignationName
        {
            get { return _MDDesignationName; }
            set { _MDDesignationName = value; }
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
                return (ApprovalRuleDesignationMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDApprovalRuleDesignationMap_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ApprovalRuleDesignationMapID = "ApprovalRuleDesignationMapID";
        public const String FLD_NAME_ApprovalRuleID = "ApprovalRuleID";
        public const String FLD_NAME_DesignationID = "DesignationID";
        public const String FLD_NAME_SequeenceNo = "SequeenceNo";
        public const String FLD_NAME_ApprovalRuleName = "ApprovalRuleName";
        public const String FLD_NAME_MDDesignationName = "MDDesignationName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
