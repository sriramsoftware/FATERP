// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jun-2012, 10:26:50




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMContractorAssignedWorkArea", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMContractorAssignedWorkAreaEntity : BaseEntity
    {
        #region Properties


        private Int64 _ContractorAssignedWorkAreaID;
        private Int64 _ContractorID;
        private Int64 _ProjectID;
        private String _WorkDescription;
        private Int64 _WorkAreaStatusID;
        private DateTime? _StartDate;
        private DateTime? _EndDate;
        private DateTime? _ActualStartDate;
        private DateTime? _ActualEndDate;
        private String _Remarks;


        [DataMember]
        public Int64 ContractorAssignedWorkAreaID
        {
            get { return _ContractorAssignedWorkAreaID; }
            set { _ContractorAssignedWorkAreaID = value; }
        }

        [DataMember]
        public Int64 ContractorID
        {
            get { return _ContractorID; }
            set { _ContractorID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String WorkDescription
        {
            get { return _WorkDescription; }
            set { _WorkDescription = value; }
        }

        [DataMember]
        public Int64 WorkAreaStatusID
        {
            get { return _WorkAreaStatusID; }
            set { _WorkAreaStatusID = value; }
        }

        [DataMember]
        public DateTime? StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public DateTime? EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        [DataMember]
        public DateTime? ActualStartDate
        {
            get { return _ActualStartDate; }
            set { _ActualStartDate = value; }
        }

        [DataMember]
        public DateTime? ActualEndDate
        {
            get { return _ActualEndDate; }
            set { _ActualEndDate = value; }
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
                return (ContractorAssignedWorkAreaID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMContractorAssignedWorkAreaEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ContractorAssignedWorkAreaID = "ContractorAssignedWorkAreaID";
        public const String FLD_NAME_ContractorID = "ContractorID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_WorkDescription = "WorkDescription";
        public const String FLD_NAME_WorkAreaStatusID = "WorkAreaStatusID";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_ActualStartDate = "ActualStartDate";
        public const String FLD_NAME_ActualEndDate = "ActualEndDate";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}