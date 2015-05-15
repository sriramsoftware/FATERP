// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Dec-2013, 10:06:11




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeEvaluationReport_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeEvaluationReport_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeEvaluationReportID;
        private Int64 _SessionID;
        private Int64 _EmployeeID;
        private String _Title1;
        private String _Title1Column1;
        private String _Title1Column2;
        private String _Title1Category1;
        private String _Title1Category1Column1Value;
        private String _Title1Category1Column2Value;
        private String _Title1Category2;
        private String _Title1Category2Column1Value;
        private String _Title1Category2Column2Value;
        private String _Title2;
        private String _Title2Column1;
        private String _Title2Category1;
        private String _Title2Category1Column1Value;
        private String _Title2Category1Column2Value;
        private String _Title2Category2;
        private String _Title2Category2Column1Value;
        private String _Title2Category2Column2Value;
        private String _Title3;
        private String _Title3Column1;
        private String _Title3Category1;
        private String _Title3Category1Column1Value;
        private String _Title3Category1Column2Value;
        private String _Title3Category2;
        private String _Title3Category2Column1Value;
        private String _Title3Category2Column2Value;
        private String _HRReportQuestion1Title;
        private String _HRReportQuestion1TitleValue;
        private Decimal _SupervisorNumberValue;
        private Decimal _ScoreValue;
        private Decimal _DeducationValue;
        private Decimal _ActualScoreValue;
        private String _Title4;
        private Decimal _Title4Column1Value;
        private String _HRReportQuestion2Title;
        private String _HRReportQuestion2TitleValue;
        private String _Extra1;
        private Decimal? _Extra2;
        private String _Extra3;
        private Decimal? _Extra4;
        private String _Extra5;
        private String _EmployeeCode;
        private String _EmployeeFullName;
        private String _DepartmentCode;


        [DataMember]
        public Int64 EmployeeEvaluationReportID
        {
            get { return _EmployeeEvaluationReportID; }
            set { _EmployeeEvaluationReportID = value; }
        }

        [DataMember]
        public Int64 SessionID
        {
            get { return _SessionID; }
            set { _SessionID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public String Title1
        {
            get { return _Title1; }
            set { _Title1 = value; }
        }

        [DataMember]
        public String Title1Column1
        {
            get { return _Title1Column1; }
            set { _Title1Column1 = value; }
        }

        [DataMember]
        public String Title1Column2
        {
            get { return _Title1Column2; }
            set { _Title1Column2 = value; }
        }

        [DataMember]
        public String Title1Category1
        {
            get { return _Title1Category1; }
            set { _Title1Category1 = value; }
        }

        [DataMember]
        public String Title1Category1Column1Value
        {
            get { return _Title1Category1Column1Value; }
            set { _Title1Category1Column1Value = value; }
        }

        [DataMember]
        public String Title1Category1Column2Value
        {
            get { return _Title1Category1Column2Value; }
            set { _Title1Category1Column2Value = value; }
        }

        [DataMember]
        public String Title1Category2
        {
            get { return _Title1Category2; }
            set { _Title1Category2 = value; }
        }

        [DataMember]
        public String Title1Category2Column1Value
        {
            get { return _Title1Category2Column1Value; }
            set { _Title1Category2Column1Value = value; }
        }

        [DataMember]
        public String Title1Category2Column2Value
        {
            get { return _Title1Category2Column2Value; }
            set { _Title1Category2Column2Value = value; }
        }

        [DataMember]
        public String Title2
        {
            get { return _Title2; }
            set { _Title2 = value; }
        }

        [DataMember]
        public String Title2Column1
        {
            get { return _Title2Column1; }
            set { _Title2Column1 = value; }
        }

        [DataMember]
        public String Title2Category1
        {
            get { return _Title2Category1; }
            set { _Title2Category1 = value; }
        }

        [DataMember]
        public String Title2Category1Column1Value
        {
            get { return _Title2Category1Column1Value; }
            set { _Title2Category1Column1Value = value; }
        }

        [DataMember]
        public String Title2Category1Column2Value
        {
            get { return _Title2Category1Column2Value; }
            set { _Title2Category1Column2Value = value; }
        }

        [DataMember]
        public String Title2Category2
        {
            get { return _Title2Category2; }
            set { _Title2Category2 = value; }
        }

        [DataMember]
        public String Title2Category2Column1Value
        {
            get { return _Title2Category2Column1Value; }
            set { _Title2Category2Column1Value = value; }
        }

        [DataMember]
        public String Title2Category2Column2Value
        {
            get { return _Title2Category2Column2Value; }
            set { _Title2Category2Column2Value = value; }
        }

        [DataMember]
        public String Title3
        {
            get { return _Title3; }
            set { _Title3 = value; }
        }

        [DataMember]
        public String Title3Column1
        {
            get { return _Title3Column1; }
            set { _Title3Column1 = value; }
        }

        [DataMember]
        public String Title3Category1
        {
            get { return _Title3Category1; }
            set { _Title3Category1 = value; }
        }

        [DataMember]
        public String Title3Category1Column1Value
        {
            get { return _Title3Category1Column1Value; }
            set { _Title3Category1Column1Value = value; }
        }

        [DataMember]
        public String Title3Category1Column2Value
        {
            get { return _Title3Category1Column2Value; }
            set { _Title3Category1Column2Value = value; }
        }

        [DataMember]
        public String Title3Category2
        {
            get { return _Title3Category2; }
            set { _Title3Category2 = value; }
        }

        [DataMember]
        public String Title3Category2Column1Value
        {
            get { return _Title3Category2Column1Value; }
            set { _Title3Category2Column1Value = value; }
        }

        [DataMember]
        public String Title3Category2Column2Value
        {
            get { return _Title3Category2Column2Value; }
            set { _Title3Category2Column2Value = value; }
        }

        [DataMember]
        public String HRReportQuestion1Title
        {
            get { return _HRReportQuestion1Title; }
            set { _HRReportQuestion1Title = value; }
        }

        [DataMember]
        public String HRReportQuestion1TitleValue
        {
            get { return _HRReportQuestion1TitleValue; }
            set { _HRReportQuestion1TitleValue = value; }
        }

        [DataMember]
        public Decimal SupervisorNumberValue
        {
            get { return _SupervisorNumberValue; }
            set { _SupervisorNumberValue = value; }
        }

        [DataMember]
        public Decimal ScoreValue
        {
            get { return _ScoreValue; }
            set { _ScoreValue = value; }
        }

        [DataMember]
        public Decimal DeducationValue
        {
            get { return _DeducationValue; }
            set { _DeducationValue = value; }
        }

        [DataMember]
        public Decimal ActualScoreValue
        {
            get { return _ActualScoreValue; }
            set { _ActualScoreValue = value; }
        }

        [DataMember]
        public String Title4
        {
            get { return _Title4; }
            set { _Title4 = value; }
        }

        [DataMember]
        public Decimal Title4Column1Value
        {
            get { return _Title4Column1Value; }
            set { _Title4Column1Value = value; }
        }

        [DataMember]
        public String HRReportQuestion2Title
        {
            get { return _HRReportQuestion2Title; }
            set { _HRReportQuestion2Title = value; }
        }

        [DataMember]
        public String HRReportQuestion2TitleValue
        {
            get { return _HRReportQuestion2TitleValue; }
            set { _HRReportQuestion2TitleValue = value; }
        }

        [DataMember]
        public String Extra1
        {
            get { return _Extra1; }
            set { _Extra1 = value; }
        }

        [DataMember]
        public Decimal? Extra2
        {
            get { return _Extra2; }
            set { _Extra2 = value; }
        }

        [DataMember]
        public String Extra3
        {
            get { return _Extra3; }
            set { _Extra3 = value; }
        }

        [DataMember]
        public Decimal? Extra4
        {
            get { return _Extra4; }
            set { _Extra4 = value; }
        }

        [DataMember]
        public String Extra5
        {
            get { return _Extra5; }
            set { _Extra5 = value; }
        }

        [DataMember]
        public String EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String DepartmentCode
        {
            get { return _DepartmentCode; }
            set { _DepartmentCode = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeEvaluationReportID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeEvaluationReport_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeEvaluationReportID = "EmployeeEvaluationReportID";
        public const String FLD_NAME_SessionID = "SessionID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_Title1 = "Title1";
        public const String FLD_NAME_Title1Column1 = "Title1Column1";
        public const String FLD_NAME_Title1Column2 = "Title1Column2";
        public const String FLD_NAME_Title1Category1 = "Title1Category1";
        public const String FLD_NAME_Title1Category1Column1Value = "Title1Category1Column1Value";
        public const String FLD_NAME_Title1Category1Column2Value = "Title1Category1Column2Value";
        public const String FLD_NAME_Title1Category2 = "Title1Category2";
        public const String FLD_NAME_Title1Category2Column1Value = "Title1Category2Column1Value";
        public const String FLD_NAME_Title1Category2Column2Value = "Title1Category2Column2Value";
        public const String FLD_NAME_Title2 = "Title2";
        public const String FLD_NAME_Title2Column1 = "Title2Column1";
        public const String FLD_NAME_Title2Category1 = "Title2Category1";
        public const String FLD_NAME_Title2Category1Column1Value = "Title2Category1Column1Value";
        public const String FLD_NAME_Title2Category1Column2Value = "Title2Category1Column2Value";
        public const String FLD_NAME_Title2Category2 = "Title2Category2";
        public const String FLD_NAME_Title2Category2Column1Value = "Title2Category2Column1Value";
        public const String FLD_NAME_Title2Category2Column2Value = "Title2Category2Column2Value";
        public const String FLD_NAME_Title3 = "Title3";
        public const String FLD_NAME_Title3Column1 = "Title3Column1";
        public const String FLD_NAME_Title3Category1 = "Title3Category1";
        public const String FLD_NAME_Title3Category1Column1Value = "Title3Category1Column1Value";
        public const String FLD_NAME_Title3Category1Column2Value = "Title3Category1Column2Value";
        public const String FLD_NAME_Title3Category2 = "Title3Category2";
        public const String FLD_NAME_Title3Category2Column1Value = "Title3Category2Column1Value";
        public const String FLD_NAME_Title3Category2Column2Value = "Title3Category2Column2Value";
        public const String FLD_NAME_HRReportQuestion1Title = "HRReportQuestion1Title";
        public const String FLD_NAME_HRReportQuestion1TitleValue = "HRReportQuestion1TitleValue";
        public const String FLD_NAME_SupervisorNumberValue = "SupervisorNumberValue";
        public const String FLD_NAME_ScoreValue = "ScoreValue";
        public const String FLD_NAME_DeducationValue = "DeducationValue";
        public const String FLD_NAME_ActualScoreValue = "ActualScoreValue";
        public const String FLD_NAME_Title4 = "Title4";
        public const String FLD_NAME_Title4Column1Value = "Title4Column1Value";
        public const String FLD_NAME_HRReportQuestion2Title = "HRReportQuestion2Title";
        public const String FLD_NAME_HRReportQuestion2TitleValue = "HRReportQuestion2TitleValue";
        public const String FLD_NAME_Extra1 = "Extra1";
        public const String FLD_NAME_Extra2 = "Extra2";
        public const String FLD_NAME_Extra3 = "Extra3";
        public const String FLD_NAME_Extra4 = "Extra4";
        public const String FLD_NAME_Extra5 = "Extra5";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_DepartmentCode = "DepartmentCode";

        #endregion
    }
}
