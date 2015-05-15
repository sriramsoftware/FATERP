// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMCriterionStatusRemarks", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMCriterionStatusRemarksEntity : BaseEntity
    {
        #region Properties


        private Int64 _CriterionStatusRemarksID;
        private Int64 _ContractorID;
        private Int64 _ReferenceCriterionCategoryID;
        private Int64? _ContractorCriterionStatusID;
        private Int64 _MemberID;
        private String _Remarks;


        [DataMember]
        public Int64 CriterionStatusRemarksID
        {
            get { return _CriterionStatusRemarksID; }
            set { _CriterionStatusRemarksID = value; }
        }

        [DataMember]
        public Int64 ContractorID
        {
            get { return _ContractorID; }
            set { _ContractorID = value; }
        }

        [DataMember]
        public Int64 ReferenceCriterionCategoryID
        {
            get { return _ReferenceCriterionCategoryID; }
            set { _ReferenceCriterionCategoryID = value; }
        }

        [DataMember]
        public Int64? ContractorCriterionStatusID
        {
            get { return _ContractorCriterionStatusID; }
            set { _ContractorCriterionStatusID = value; }
        }

        [DataMember]
        public Int64 MemberID
        {
            get { return _MemberID; }
            set { _MemberID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (CriterionStatusRemarksID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMCriterionStatusRemarksEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_CriterionStatusRemarksID = "CriterionStatusRemarksID";
        public const String FLD_NAME_ContractorID = "ContractorID";
        public const String FLD_NAME_ReferenceCriterionCategoryID = "ReferenceCriterionCategoryID";
        public const String FLD_NAME_ContractorCriterionStatusID = "ContractorCriterionStatusID";
        public const String FLD_NAME_MemberID = "MemberID";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
