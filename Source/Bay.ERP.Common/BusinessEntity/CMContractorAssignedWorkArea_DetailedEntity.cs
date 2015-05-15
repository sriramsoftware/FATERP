// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Nov-2012, 03:38:14




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMContractorAssignedWorkArea_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMContractorAssignedWorkArea_DetailedEntity : BaseEntity
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
        private String _ContractorName;
        private String _ProjectName;
        private String _WorkAreaStatusName;
        private Int64? _RowNumber;


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

        [DataMember]
        public String ContractorName
        {
            get { return _ContractorName; }
            set { _ContractorName = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String WorkAreaStatusName
        {
            get { return _WorkAreaStatusName; }
            set { _WorkAreaStatusName = value; }
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
                return (ContractorAssignedWorkAreaID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMContractorAssignedWorkArea_DetailedEntity() : base()
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
        public const String FLD_NAME_ContractorName = "ContractorName";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_WorkAreaStatusName = "WorkAreaStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
