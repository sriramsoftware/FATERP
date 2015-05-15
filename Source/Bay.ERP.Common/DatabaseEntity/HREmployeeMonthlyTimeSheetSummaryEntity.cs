// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeMonthlyTimeSheetSummary", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeMonthlyTimeSheetSummaryEntity : BaseEntity
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
        private String _REMARKS;
        private Decimal _NUMBEROFMEALS;
        private Decimal _PROJECTACTUAL;
        private Decimal _OTHERLEAVE;
        private Decimal? _Field1;
        private Char? _Field11;
        private Char? _Field12;
        private Char? _Field13;
        private Char? _Field14;
        private Char? _Field15;
        private Int64? _DepartmentID;


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
        public String REMARKS
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
        public Decimal? Field1
        {
            get { return _Field1; }
            set { _Field1 = value; }
        }

        [DataMember]
        public Char? Field11
        {
            get { return _Field11; }
            set { _Field11 = value; }
        }

        [DataMember]
        public Char? Field12
        {
            get { return _Field12; }
            set { _Field12 = value; }
        }

        [DataMember]
        public Char? Field13
        {
            get { return _Field13; }
            set { _Field13 = value; }
        }

        [DataMember]
        public Char? Field14
        {
            get { return _Field14; }
            set { _Field14 = value; }
        }

        [DataMember]
        public Char? Field15
        {
            get { return _Field15; }
            set { _Field15 = value; }
        }

        [DataMember]
        public Int64? DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
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

        public HREmployeeMonthlyTimeSheetSummaryEntity() : base()
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
        public const String FLD_NAME_Field1 = "Field1";
        public const String FLD_NAME_Field11 = "Field11";
        public const String FLD_NAME_Field12 = "Field12";
        public const String FLD_NAME_Field13 = "Field13";
        public const String FLD_NAME_Field14 = "Field14";
        public const String FLD_NAME_Field15 = "Field15";
        public const String FLD_NAME_DepartmentID = "DepartmentID";

        #endregion
    }
}
