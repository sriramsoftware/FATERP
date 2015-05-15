// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDEvaluationCriteria", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDEvaluationCriteriaEntity : BaseEntity
    {
        #region Properties


        private Int64 _EvaluationCriteriaID;
        private Int64 _EvaluationCriteriaCategoryID;
        private Int64 _SupervisorTypeID;
        private Int64 _EvaluationSessionCategoryID;
        private String _Question;
        private String _Description;
        private String _CorrectAnswerIfAny;
        private Int32? _CorrectAnswerMarkOrPoint;
        private String _ImageUrl;
        private Int32? _QuestionOrderInDisplay;
        private Boolean _SupervisorWillAnswer;
        private Boolean _IsRemoved;
        private Int64 _CreatedByEmployeeID;
        private DateTime _CreateDate;


        [DataMember]
        public Int64 EvaluationCriteriaID
        {
            get { return _EvaluationCriteriaID; }
            set { _EvaluationCriteriaID = value; }
        }

        [DataMember]
        public Int64 EvaluationCriteriaCategoryID
        {
            get { return _EvaluationCriteriaCategoryID; }
            set { _EvaluationCriteriaCategoryID = value; }
        }

        [DataMember]
        public Int64 SupervisorTypeID
        {
            get { return _SupervisorTypeID; }
            set { _SupervisorTypeID = value; }
        }

        [DataMember]
        public Int64 EvaluationSessionCategoryID
        {
            get { return _EvaluationSessionCategoryID; }
            set { _EvaluationSessionCategoryID = value; }
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
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public Int64 CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EvaluationCriteriaID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDEvaluationCriteriaEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EvaluationCriteriaID = "EvaluationCriteriaID";
        public const String FLD_NAME_EvaluationCriteriaCategoryID = "EvaluationCriteriaCategoryID";
        public const String FLD_NAME_SupervisorTypeID = "SupervisorTypeID";
        public const String FLD_NAME_EvaluationSessionCategoryID = "EvaluationSessionCategoryID";
        public const String FLD_NAME_Question = "Question";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_CorrectAnswerIfAny = "CorrectAnswerIfAny";
        public const String FLD_NAME_CorrectAnswerMarkOrPoint = "CorrectAnswerMarkOrPoint";
        public const String FLD_NAME_ImageUrl = "ImageUrl";
        public const String FLD_NAME_QuestionOrderInDisplay = "QuestionOrderInDisplay";
        public const String FLD_NAME_SupervisorWillAnswer = "SupervisorWillAnswer";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_CreateDate = "CreateDate";

        #endregion
    }
}
