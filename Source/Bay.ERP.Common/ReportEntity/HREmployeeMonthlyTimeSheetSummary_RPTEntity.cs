// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2014, 01:58:57




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeMonthlyTimeSheetSummary_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeMonthlyTimeSheetSummary_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeMonthlyTimeSheetID;
        private Int64 _EmployeeID;
        private Int64? _DesignationID;
        private Int64 _EmployeeJobTypeID;
        private Int32? _SalaryLevel;
        private Int64 _SalarySessionID;
        private Decimal _OnJob;
        private Decimal _Holiday;
        private Decimal _LCASUAL;
        private Decimal _LMEDICAL;
        private Decimal _EARNLEAVE;
        private Decimal _LWP;
        private Decimal _ACTUALWORKDAYS;
        private Decimal _REMARKS;
        private Decimal _NUMBEROFMEALS;
        private Decimal _PROJECTACTUAL;
        private Decimal _OTHERLEAVE;
        private String _EmployeeFullName;
        private String _EmployeeCode;
        private String _EmployeeJobTypeName;
        private String _DesignationName;
        private DateTime? _JoinDate;
        private DateTime? _DISCONTINUTION;
        private Int32? _ServiceAgeMonth;
        private String _SalarySessionName;
        private DateTime? _SessionStartDate;
        private DateTime? _SessionEndDate;
        private String _ProjectCode;
        private String _ProjectName;


        [DataMember]
        public Int64 EmployeeMonthlyTimeSheetID
        {
            get { return _EmployeeMonthlyTimeSheetID; }
            set { _EmployeeMonthlyTimeSheetID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64? DesignationID
        {
            get { return _DesignationID; }
            set { _DesignationID = value; }
        }

        [DataMember]
        public Int64 EmployeeJobTypeID
        {
            get { return _EmployeeJobTypeID; }
            set { _EmployeeJobTypeID = value; }
        }

        [DataMember]
        public Int32? SalaryLevel
        {
            get { return _SalaryLevel; }
            set { _SalaryLevel = value; }
        }

        [DataMember]
        public Int64 SalarySessionID
        {
            get { return _SalarySessionID; }
            set { _SalarySessionID = value; }
        }

        [DataMember]
        public Decimal OnJob
        {
            get { return _OnJob; }
            set { _OnJob = value; }
        }

        [DataMember]
        public Decimal Holiday
        {
            get { return _Holiday; }
            set { _Holiday = value; }
        }

        [DataMember]
        public Decimal LCASUAL
        {
            get { return _LCASUAL; }
            set { _LCASUAL = value; }
        }

        [DataMember]
        public Decimal LMEDICAL
        {
            get { return _LMEDICAL; }
            set { _LMEDICAL = value; }
        }

        [DataMember]
        public Decimal EARNLEAVE
        {
            get { return _EARNLEAVE; }
            set { _EARNLEAVE = value; }
        }

        [DataMember]
        public Decimal LWP
        {
            get { return _LWP; }
            set { _LWP = value; }
        }

        [DataMember]
        public Decimal ACTUALWORKDAYS
        {
            get { return _ACTUALWORKDAYS; }
            set { _ACTUALWORKDAYS = value; }
        }

        [DataMember]
        public Decimal REMARKS
        {
            get { return _REMARKS; }
            set { _REMARKS = value; }
        }

        [DataMember]
        public Decimal NUMBEROFMEALS
        {
            get { return _NUMBEROFMEALS; }
            set { _NUMBEROFMEALS = value; }
        }

        [DataMember]
        public Decimal PROJECTACTUAL
        {
            get { return _PROJECTACTUAL; }
            set { _PROJECTACTUAL = value; }
        }

        [DataMember]
        public Decimal OTHERLEAVE
        {
            get { return _OTHERLEAVE; }
            set { _OTHERLEAVE = value; }
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
        public String EmployeeJobTypeName
        {
            get { return _EmployeeJobTypeName; }
            set { _EmployeeJobTypeName = value; }
        }

        [DataMember]
        public String DesignationName
        {
            get { return _DesignationName; }
            set { _DesignationName = value; }
        }

        [DataMember]
        public DateTime? JoinDate
        {
            get { return _JoinDate; }
            set { _JoinDate = value; }
        }

        [DataMember]
        public DateTime? DISCONTINUTION
        {
            get { return _DISCONTINUTION; }
            set { _DISCONTINUTION = value; }
        }

        [DataMember]
        public Int32? ServiceAgeMonth
        {
            get { return _ServiceAgeMonth; }
            set { _ServiceAgeMonth = value; }
        }

        [DataMember]
        public String SalarySessionName
        {
            get { return _SalarySessionName; }
            set { _SalarySessionName = value; }
        }

        [DataMember]
        public DateTime? SessionStartDate
        {
            get { return _SessionStartDate; }
            set { _SessionStartDate = value; }
        }

        [DataMember]
        public DateTime? SessionEndDate
        {
            get { return _SessionEndDate; }
            set { _SessionEndDate = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeMonthlyTimeSheetID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeMonthlyTimeSheetSummary_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeMonthlyTimeSheetID = "EmployeeMonthlyTimeSheetID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_DesignationID = "DesignationID";
        public const String FLD_NAME_EmployeeJobTypeID = "EmployeeJobTypeID";
        public const String FLD_NAME_SalaryLevel = "SalaryLevel";
        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_OnJob = "OnJob";
        public const String FLD_NAME_Holiday = "Holiday";
        public const String FLD_NAME_LCASUAL = "LCASUAL";
        public const String FLD_NAME_LMEDICAL = "LMEDICAL";
        public const String FLD_NAME_EARNLEAVE = "EARNLEAVE";
        public const String FLD_NAME_LWP = "LWP";
        public const String FLD_NAME_ACTUALWORKDAYS = "ACTUALWORKDAYS";
        public const String FLD_NAME_REMARKS = "REMARKS";
        public const String FLD_NAME_NUMBEROFMEALS = "NUMBEROFMEALS";
        public const String FLD_NAME_PROJECTACTUAL = "PROJECTACTUAL";
        public const String FLD_NAME_OTHERLEAVE = "OTHERLEAVE";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_EmployeeJobTypeName = "EmployeeJobTypeName";
        public const String FLD_NAME_DesignationName = "DesignationName";
        public const String FLD_NAME_JoinDate = "JoinDate";
        public const String FLD_NAME_DISCONTINUTION = "DISCONTINUTION";
        public const String FLD_NAME_ServiceAgeMonth = "ServiceAgeMonth";
        public const String FLD_NAME_SalarySessionName = "SalarySessionName";
        public const String FLD_NAME_SessionStartDate = "SessionStartDate";
        public const String FLD_NAME_SessionEndDate = "SessionEndDate";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";

        #endregion
    }
}
