// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Sep-2013, 02:21:03




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeEvaluationIndividual_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeEvaluationIndividual_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _SessionID;
        private String _SessionName;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private DateTime _DeadlineDate;
        private String _EvaluationSessionCategoryName;
        private String _EvaluationName;
        private Int64? _EmployeeID;
        private Int64? _SupervisorEmployeeID;
        private DateTime? _EmployeeSubmitDate;
        private DateTime? _SupervisorSubmitDate;
        private Int64 _EvaluatedByID;
        private Int64 _EvaluationSessionStatusID;
        private Int64 _SessionCategoryID;
        private String _SupervisorFullName;
        private String _SupervisorEmployeeCode;
        private String _SupervisorEmployeeDepartmentName;
        private String _SupervisorEmployeeLevel;
        private String _EmployeeFullName;
        private Int64 _EmployeeEvaluationID;
        private String _EmployeeCode;
        private String _EmployeeDepartmentName;
        private String _EmployeeLevel;
        private String _EvaluationSessionStatusName;


        [DataMember]
        public Int64 SessionID
        {
            get { return _SessionID; }
            set { _SessionID = value; }
        }

        [DataMember]
        public String SessionName
        {
            get { return _SessionName; }
            set { _SessionName = value; }
        }

        [DataMember]
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        [DataMember]
        public DateTime DeadlineDate
        {
            get { return _DeadlineDate; }
            set { _DeadlineDate = value; }
        }

        [DataMember]
        public String EvaluationSessionCategoryName
        {
            get { return _EvaluationSessionCategoryName; }
            set { _EvaluationSessionCategoryName = value; }
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
        public Int64? SupervisorEmployeeID
        {
            get { return _SupervisorEmployeeID; }
            set { _SupervisorEmployeeID = value; }
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
        public Int64 EvaluatedByID
        {
            get { return _EvaluatedByID; }
            set { _EvaluatedByID = value; }
        }

        [DataMember]
        public Int64 EvaluationSessionStatusID
        {
            get { return _EvaluationSessionStatusID; }
            set { _EvaluationSessionStatusID = value; }
        }

        [DataMember]
        public Int64 SessionCategoryID
        {
            get { return _SessionCategoryID; }
            set { _SessionCategoryID = value; }
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
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public Int64 EmployeeEvaluationID
        {
            get { return _EmployeeEvaluationID; }
            set { _EmployeeEvaluationID = value; }
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
        public String EvaluationSessionStatusName
        {
            get { return _EvaluationSessionStatusName; }
            set { _EvaluationSessionStatusName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SessionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeEvaluationIndividual_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SessionID = "SessionID";
        public const String FLD_NAME_SessionName = "SessionName";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_DeadlineDate = "DeadlineDate";
        public const String FLD_NAME_EvaluationSessionCategoryName = "EvaluationSessionCategoryName";
        public const String FLD_NAME_EvaluationName = "EvaluationName";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_SupervisorEmployeeID = "SupervisorEmployeeID";
        public const String FLD_NAME_EmployeeSubmitDate = "EmployeeSubmitDate";
        public const String FLD_NAME_SupervisorSubmitDate = "SupervisorSubmitDate";
        public const String FLD_NAME_EvaluatedByID = "EvaluatedByID";
        public const String FLD_NAME_EvaluationSessionStatusID = "EvaluationSessionStatusID";
        public const String FLD_NAME_SessionCategoryID = "SessionCategoryID";
        public const String FLD_NAME_SupervisorFullName = "SupervisorFullName";
        public const String FLD_NAME_SupervisorEmployeeCode = "SupervisorEmployeeCode";
        public const String FLD_NAME_SupervisorEmployeeDepartmentName = "SupervisorEmployeeDepartmentName";
        public const String FLD_NAME_SupervisorEmployeeLevel = "SupervisorEmployeeLevel";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_EmployeeEvaluationID = "EmployeeEvaluationID";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_EmployeeDepartmentName = "EmployeeDepartmentName";
        public const String FLD_NAME_EmployeeLevel = "EmployeeLevel";
        public const String FLD_NAME_EvaluationSessionStatusName = "EvaluationSessionStatusName";

        #endregion
    }
}
