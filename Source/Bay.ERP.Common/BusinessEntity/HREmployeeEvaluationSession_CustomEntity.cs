// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2013, 10:27:18




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeEvaluationSession_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeEvaluationSession_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _SessionID;
        private String _SessionName;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private DateTime _DeadlineDate;
        private String _EvaluationSessionCategoryName;
        private String _Question;
        private String _Description;
        private Int64 _EvaluationCriteriaID;
        private String _CorrectAnswerIfAny;
        private Int32? _CorrectAnswerMarkOrPoint;
        private String _ImageUrl;
        private Int32? _QuestionOrderInDisplay;
        private Boolean _SupervisorWillAnswer;
        private String _EvaluationName;
        private Int64? _EmployeeID;
        private Int64? _SupervisorEmployeeID;
        private DateTime? _EmployeeSubmitDate;
        private DateTime? _SupervisorSubmitDate;
        private Int64 _EvaluatedByID;
        private Int64 _EvaluationSessionStatusID;
        private Int32? _EmployeeResult;
        private Int32? _Result;
        private Int32? _PointInThisQuestion;
        private String _Remarks;
        private String _SupervisorRemarks;
        private String _EvaluationCriteriaCategoryName;
        private Int64 _SessionCategoryID;
        private Int64 _EvaluationCriteriaCategoryID;
        private Int64? _EmployeeEvaluationResultID;
        private String _SupervisorFullName;
        private String _SupervisorEmployeeCode;
        private String _SupervisorEmployeeDepartmentName;
        private String _SupervisorEmployeeLevel;
        private String _EmployeeFullName;
        private Int64 _EmployeeEvaluationID;
        private String _EmployeeCode;
        private String _EmployeeDepartmentName;
        private String _EmployeeLevel;


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
        public Int64 EvaluationCriteriaID
        {
            get { return _EvaluationCriteriaID; }
            set { _EvaluationCriteriaID = value; }
        }

        [DataMember]
        public String CorrectAnswerIfAny
        {
            get { return _CorrectAnswerIfAny; }
            set { _CorrectAnswerIfAny = value; }
        }

        [DataMember]
        public Int32? CorrectAnswerMarkOrPoint
        {
            get { return _CorrectAnswerMarkOrPoint; }
            set { _CorrectAnswerMarkOrPoint = value; }
        }

        [DataMember]
        public String ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }

        [DataMember]
        public Int32? QuestionOrderInDisplay
        {
            get { return _QuestionOrderInDisplay; }
            set { _QuestionOrderInDisplay = value; }
        }

        [DataMember]
        public Boolean SupervisorWillAnswer
        {
            get { return _SupervisorWillAnswer; }
            set { _SupervisorWillAnswer = value; }
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
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String SupervisorRemarks
        {
            get { return _SupervisorRemarks; }
            set { _SupervisorRemarks = value; }
        }

        [DataMember]
        public String EvaluationCriteriaCategoryName
        {
            get { return _EvaluationCriteriaCategoryName; }
            set { _EvaluationCriteriaCategoryName = value; }
        }

        [DataMember]
        public Int64 SessionCategoryID
        {
            get { return _SessionCategoryID; }
            set { _SessionCategoryID = value; }
        }

        [DataMember]
        public Int64 EvaluationCriteriaCategoryID
        {
            get { return _EvaluationCriteriaCategoryID; }
            set { _EvaluationCriteriaCategoryID = value; }
        }

        [DataMember]
        public Int64? EmployeeEvaluationResultID
        {
            get { return _EmployeeEvaluationResultID; }
            set { _EmployeeEvaluationResultID = value; }
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

        public HREmployeeEvaluationSession_CustomEntity() : base()
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
        public const String FLD_NAME_Question = "Question";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_EvaluationCriteriaID = "EvaluationCriteriaID";
        public const String FLD_NAME_CorrectAnswerIfAny = "CorrectAnswerIfAny";
        public const String FLD_NAME_CorrectAnswerMarkOrPoint = "CorrectAnswerMarkOrPoint";
        public const String FLD_NAME_ImageUrl = "ImageUrl";
        public const String FLD_NAME_QuestionOrderInDisplay = "QuestionOrderInDisplay";
        public const String FLD_NAME_SupervisorWillAnswer = "SupervisorWillAnswer";
        public const String FLD_NAME_EvaluationName = "EvaluationName";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_SupervisorEmployeeID = "SupervisorEmployeeID";
        public const String FLD_NAME_EmployeeSubmitDate = "EmployeeSubmitDate";
        public const String FLD_NAME_SupervisorSubmitDate = "SupervisorSubmitDate";
        public const String FLD_NAME_EvaluatedByID = "EvaluatedByID";
        public const String FLD_NAME_EvaluationSessionStatusID = "EvaluationSessionStatusID";
        public const String FLD_NAME_EmployeeResult = "EmployeeResult";
        public const String FLD_NAME_Result = "Result";
        public const String FLD_NAME_PointInThisQuestion = "PointInThisQuestion";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_SupervisorRemarks = "SupervisorRemarks";
        public const String FLD_NAME_EvaluationCriteriaCategoryName = "EvaluationCriteriaCategoryName";
        public const String FLD_NAME_SessionCategoryID = "SessionCategoryID";
        public const String FLD_NAME_EvaluationCriteriaCategoryID = "EvaluationCriteriaCategoryID";
        public const String FLD_NAME_EmployeeEvaluationResultID = "EmployeeEvaluationResultID";
        public const String FLD_NAME_SupervisorFullName = "SupervisorFullName";
        public const String FLD_NAME_SupervisorEmployeeCode = "SupervisorEmployeeCode";
        public const String FLD_NAME_SupervisorEmployeeDepartmentName = "SupervisorEmployeeDepartmentName";
        public const String FLD_NAME_SupervisorEmployeeLevel = "SupervisorEmployeeLevel";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_EmployeeEvaluationID = "EmployeeEvaluationID";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_EmployeeDepartmentName = "EmployeeDepartmentName";
        public const String FLD_NAME_EmployeeLevel = "EmployeeLevel";

        #endregion
    }
}
