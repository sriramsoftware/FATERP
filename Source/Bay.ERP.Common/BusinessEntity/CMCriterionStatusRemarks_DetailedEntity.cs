// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2012, 11:54:12




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMCriterionStatusRemarks_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMCriterionStatusRemarks_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _CriterionStatusRemarksID;
        private Int64 _ContractorID;
        private Int64 _ReferenceCriterionCategoryID;
        private Int64? _ContractorCriterionStatusID;
        private Int64 _MemberID;
        private String _Remarks;
        private String _ContractorName;
        private String _CriterionCategoryName;
        private String _ContractorCriterionStatusName;
        private String _MemberFullName;
        private Int64? _RowNumber;


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

        [DataMember]
        public String ContractorName
        {
            get { return _ContractorName; }
            set { _ContractorName = value; }
        }

        [DataMember]
        public String CriterionCategoryName
        {
            get { return _CriterionCategoryName; }
            set { _CriterionCategoryName = value; }
        }

        [DataMember]
        public String ContractorCriterionStatusName
        {
            get { return _ContractorCriterionStatusName; }
            set { _ContractorCriterionStatusName = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
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
                return (CriterionStatusRemarksID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMCriterionStatusRemarks_DetailedEntity() : base()
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
        public const String FLD_NAME_ContractorName = "ContractorName";
        public const String FLD_NAME_CriterionCategoryName = "CriterionCategoryName";
        public const String FLD_NAME_ContractorCriterionStatusName = "ContractorCriterionStatusName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
