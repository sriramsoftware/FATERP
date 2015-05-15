// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 12:39:02




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREvaluation_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREvaluation_RPTEntity : BaseEntity
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
        private DateTime? _EmployeeSubmitDate;
        private DateTime? _SupervisorSubmitDate;
        private DateTime? _CreateDate;
        private Int64 _EvaluatedByID;
        private String _Remarks;
        private String _Extra;
        private String _SupervisorEmployeeLevel;
        private Int64 _EvaluationCriteriaCategoryID;
        private String _Question;
        private String _Description;
        private Int64 _EmployeeEvaluationCriteriaID;
        private String _AnswerGivenByEmployeeDepartmentName;
        private Int64? _SupervisorEvaluationCriteriaID;
        private String _SupervisorDepartmentName;
        private String _AnswerGivenBySupervisorEmployeeFullName;
        private Int32? _EmployeeResult;
        private Int32? _Result;
        private Int32? _PointInThisQuestion;
        private String _HREmployeeEvaluationResultRemarks;
        private String _Extra1;
        private String _Extra2;


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

        [DataMember]
        public String SupervisorEmployeeLevel
        {
            get { return _SupervisorEmployeeLevel; }
            set { _SupervisorEmployeeLevel = value; }
        }

        [DataMember]
        public Int64 EvaluationCriteriaCategoryID
        {
            get { return _EvaluationCriteriaCategoryID; }
            set { _EvaluationCriteriaCategoryID = value; }
        }

        [DataMember]
        public String Question
        {
            get { return _Question; }
            set { _Question = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Int64 EmployeeEvaluationCriteriaID
        {
            get { return _EmployeeEvaluationCriteriaID; }
            set { _EmployeeEvaluationCriteriaID = value; }
        }

        [DataMember]
        public String AnswerGivenByEmployeeDepartmentName
        {
            get { return _AnswerGivenByEmployeeDepartmentName; }
            set { _AnswerGivenByEmployeeDepartmentName = value; }
        }

        [DataMember]
        public Int64? SupervisorEvaluationCriteriaID
        {
            get { return _SupervisorEvaluationCriteriaID; }
            set { _SupervisorEvaluationCriteriaID = value; }
        }

        [DataMember]
        public String SupervisorDepartmentName
        {
            get { return _SupervisorDepartmentName; }
            set { _SupervisorDepartmentName = value; }
        }

        [DataMember]
        public String AnswerGivenBySupervisorEmployeeFullName
        {
            get { return _AnswerGivenBySupervisorEmployeeFullName; }
            set { _AnswerGivenBySupervisorEmployeeFullName = value; }
        }

        [DataMember]
        public Int32? EmployeeResult
        {
            get { return _EmployeeResult; }
            set { _EmployeeResult = value; }
        }

        [DataMember]
        public Int32? Result
        {
            get { return _Result; }
            set { _Result = value; }
        }

        [DataMember]
        public Int32? PointInThisQuestion
        {
            get { return _PointInThisQuestion; }
            set { _PointInThisQuestion = value; }
        }

        [DataMember]
        public String HREmployeeEvaluationResultRemarks
        {
            get { return _HREmployeeEvaluationResultRemarks; }
            set { _HREmployeeEvaluationResultRemarks = value; }
        }

        [DataMember]
        public String Extra1
        {
            get { return _Extra1; }
            set { _Extra1 = value; }
        }

        [DataMember]
        public String Extra2
        {
            get { return _Extra2; }
            set { _Extra2 = value; }
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

        public HREvaluation_RPTEntity() : base()
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
        public const String FLD_NAME_EmployeeSubmitDate = "EmployeeSubmitDate";
        public const String FLD_NAME_SupervisorSubmitDate = "SupervisorSubmitDate";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_EvaluatedByID = "EvaluatedByID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Extra = "Extra";
        public const String FLD_NAME_SupervisorEmployeeLevel = "SupervisorEmployeeLevel";
        public const String FLD_NAME_EvaluationCriteriaCategoryID = "EvaluationCriteriaCategoryID";
        public const String FLD_NAME_Question = "Question";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_EmployeeEvaluationCriteriaID = "EmployeeEvaluationCriteriaID";
        public const String FLD_NAME_AnswerGivenByEmployeeDepartmentName = "AnswerGivenByEmployeeDepartmentName";
        public const String FLD_NAME_SupervisorEvaluationCriteriaID = "SupervisorEvaluationCriteriaID";
        public const String FLD_NAME_SupervisorDepartmentName = "SupervisorDepartmentName";
        public const String FLD_NAME_AnswerGivenBySupervisorEmployeeFullName = "AnswerGivenBySupervisorEmployeeFullName";
        public const String FLD_NAME_EmployeeResult = "EmployeeResult";
        public const String FLD_NAME_Result = "Result";
        public const String FLD_NAME_PointInThisQuestion = "PointInThisQuestion";
        public const String FLD_NAME_HREmployeeEvaluationResultRemarks = "HREmployeeEvaluationResultRemarks";
        public const String FLD_NAME_Extra1 = "Extra1";
        public const String FLD_NAME_Extra2 = "Extra2";

        #endregion
    }
}
