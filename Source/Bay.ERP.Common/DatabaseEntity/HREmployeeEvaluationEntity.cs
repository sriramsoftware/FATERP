// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Sep-2013, 01:42:20




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeEvaluation", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeEvaluationEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeEvaluationID;
        private Int64 _SessionID;
        private String _EvaluationName;
        private Int64? _EmployeeID;
        private String _EmployeeFullName;
        private String _EmployeeCode;
        private String _EmployeeDepartmentName;
        private String _EmployeeLevel;
        private Int64? _SupervisorEmployeeID;
        private String _SupervisorFullName;
        private String _SupervisorEmployeeCode;
        private String _SupervisorEmployeeDepartmentName;
        private String _SupervisorEmployeeLevel;
        private DateTime? _EmployeeSubmitDate;
        private DateTime? _SupervisorSubmitDate;
        private DateTime? _CreateDate;
        private Int64 _EvaluatedByID;
        private String _Remarks;
        private String _Extra;


        [DataMember]
        public Int64 EmployeeEvaluationID
        {
            get { return _EmployeeEvaluationID; }
            set { _EmployeeEvaluationID = value; }
        }

        [DataMember]
        public Int64 SessionID
        {
            get { return _SessionID; }
            set { _SessionID = value; }
        }

        [DataMember]
        public String EvaluationName
        {
            get { return _EvaluationName; }
            set { _EvaluationName = value; }
        }

        [DataMember]
        public Int64? EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }

        [DataMember]
        public String EmployeeDepartmentName
        {
            get { return _EmployeeDepartmentName; }
            set { _EmployeeDepartmentName = value; }
        }

        [DataMember]
        public String EmployeeLevel
        {
            get { return _EmployeeLevel; }
            set { _EmployeeLevel = value; }
        }

        [DataMember]
        public Int64? SupervisorEmployeeID
        {
            get { return _SupervisorEmployeeID; }
            set { _SupervisorEmployeeID = value; }
        }

        [DataMember]
        public String SupervisorFullName
        {
            get { return _SupervisorFullName; }
            set { _SupervisorFullName = value; }
        }

        [DataMember]
        public String SupervisorEmployeeCode
        {
            get { return _SupervisorEmployeeCode; }
            set { _SupervisorEmployeeCode = value; }
        }

        [DataMember]
        public String SupervisorEmployeeDepartmentName
        {
            get { return _SupervisorEmployeeDepartmentName; }
            set { _SupervisorEmployeeDepartmentName = value; }
        }

        [DataMember]
        public String SupervisorEmployeeLevel
        {
            get { return _SupervisorEmployeeLevel; }
            set { _SupervisorEmployeeLevel = value; }
        }

        [DataMember]
        public DateTime? EmployeeSubmitDate
        {
            get { return _EmployeeSubmitDate; }
            set { _EmployeeSubmitDate = value; }
        }

        [DataMember]
        public DateTime? SupervisorSubmitDate
        {
            get { return _SupervisorSubmitDate; }
            set { _SupervisorSubmitDate = value; }
        }

        [DataMember]
        public DateTime? CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public Int64 EvaluatedByID
        {
            get { return _EvaluatedByID; }
            set { _EvaluatedByID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String Extra
        {
            get { return _Extra; }
            set { _Extra = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeEvaluationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeEvaluationEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeEvaluationID = "EmployeeEvaluationID";
        public const String FLD_NAME_SessionID = "SessionID";
        public const String FLD_NAME_EvaluationName = "EvaluationName";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_EmployeeDepartmentName = "EmployeeDepartmentName";
        public const String FLD_NAME_EmployeeLevel = "EmployeeLevel";
        public const String FLD_NAME_SupervisorEmployeeID = "SupervisorEmployeeID";
        public const String FLD_NAME_SupervisorFullName = "SupervisorFullName";
        public const String FLD_NAME_SupervisorEmployeeCode = "SupervisorEmployeeCode";
        public const String FLD_NAME_SupervisorEmployeeDepartmentName = "SupervisorEmployeeDepartmentName";
        public const String FLD_NAME_SupervisorEmployeeLevel = "SupervisorEmployeeLevel";
        public const String FLD_NAME_EmployeeSubmitDate = "EmployeeSubmitDate";
        public const String FLD_NAME_SupervisorSubmitDate = "SupervisorSubmitDate";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_EvaluatedByID = "EvaluatedByID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Extra = "Extra";

        #endregion
    }
}
