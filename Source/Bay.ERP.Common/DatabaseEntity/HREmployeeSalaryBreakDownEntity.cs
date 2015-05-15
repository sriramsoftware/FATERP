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
    [DataContract(Name = "HREmployeeSalaryBreakDown", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeSalaryBreakDownEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeSalaryBreakDownID;
        private Int64 _EmployeeSalaryInfoID;
        private Int64 _EmployeeID;
        private Decimal _YearlyRate;
        private Decimal _MonthlyRate;
        private Decimal _DailyRate;
        private Decimal _OTHourlyRate;
        private Decimal _HoulryRate;


        [DataMember]
        public Int64 EmployeeSalaryBreakDownID
        {
            get { return _EmployeeSalaryBreakDownID; }
            set { _EmployeeSalaryBreakDownID = value; }
        }

        [DataMember]
        public Int64 EmployeeSalaryInfoID
        {
            get { return _EmployeeSalaryInfoID; }
            set { _EmployeeSalaryInfoID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Decimal YearlyRate
        {
            get { return _YearlyRate; }
            set { _YearlyRate = value; }
        }

        [DataMember]
        public Decimal MonthlyRate
        {
            get { return _MonthlyRate; }
            set { _MonthlyRate = value; }
        }

        [DataMember]
        public Decimal DailyRate
        {
            get { return _DailyRate; }
            set { _DailyRate = value; }
        }

        [DataMember]
        public Decimal OTHourlyRate
        {
            get { return _OTHourlyRate; }
            set { _OTHourlyRate = value; }
        }

        [DataMember]
        public Decimal HoulryRate
        {
            get { return _HoulryRate; }
            set { _HoulryRate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeSalaryBreakDownID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeSalaryBreakDownEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeSalaryBreakDownID = "EmployeeSalaryBreakDownID";
        public const String FLD_NAME_EmployeeSalaryInfoID = "EmployeeSalaryInfoID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_YearlyRate = "YearlyRate";
        public const String FLD_NAME_MonthlyRate = "MonthlyRate";
        public const String FLD_NAME_DailyRate = "DailyRate";
        public const String FLD_NAME_OTHourlyRate = "OTHourlyRate";
        public const String FLD_NAME_HoulryRate = "HoulryRate";

        #endregion
    }
}
