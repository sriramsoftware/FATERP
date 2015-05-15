// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDApprovalRule", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDApprovalRuleEntity : BaseEntity
    {
        #region Properties


        private Int64 _ApprovalRuleID;
        private String _ApprovalRuleName;
        private String _Description;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ApprovalRuleID
        {
            get { return _ApprovalRuleID; }
            set { _ApprovalRuleID = value; }
        }

        [DataMember]
        public String ApprovalRuleName
        {
            get { return _ApprovalRuleName; }
            set { _ApprovalRuleName = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ApprovalRuleID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDApprovalRuleEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ApprovalRuleID = "ApprovalRuleID";
        public const String FLD_NAME_ApprovalRuleName = "ApprovalRuleName";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
