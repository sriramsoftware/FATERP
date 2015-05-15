// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 03:14:39




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HRWorkingDay", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRWorkingDayEntity : BaseEntity
    {
        #region Properties


        private Int64 _WorkingDayID;
        private Int64 _FiscalYearID;
        private Int64 _SalarySessionID;
        private Int64 _AttendanceLeaveAndHolidayCategoryID;
        private String _Note;
        private DateTime _WorkingDay;
        private Int32 _Year;
        private Int32 _Month;
        private Int32 _Day;
        private String _Remarks;
        private DateTime _Date;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 WorkingDayID
        {
            get { return _WorkingDayID; }
            set { _WorkingDayID = value; }
        }

        [DataMember]
        public Int64 FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [DataMember]
        public Int64 SalarySessionID
        {
            get { return _SalarySessionID; }
            set { _SalarySessionID = value; }
        }

        [DataMember]
        public Int64 AttendanceLeaveAndHolidayCategoryID
        {
            get { return _AttendanceLeaveAndHolidayCategoryID; }
            set { _AttendanceLeaveAndHolidayCategoryID = value; }
        }

        [DataMember]
        public String Note
        {
            get { return _Note; }
            set { _Note = value; }
        }

        [DataMember]
        public DateTime WorkingDay
        {
            get { return _WorkingDay; }
            set { _WorkingDay = value; }
        }

        [DataMember]
        public Int32 Year
        {
            get { return _Year; }
            set { _Year = value; }
        }

        [DataMember]
        public Int32 Month
        {
            get { return _Month; }
            set { _Month = value; }
        }

        [DataMember]
        public Int32 Day
        {
            get { return _Day; }
            set { _Day = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (WorkingDayID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HRWorkingDayEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_WorkingDayID = "WorkingDayID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_AttendanceLeaveAndHolidayCategoryID = "AttendanceLeaveAndHolidayCategoryID";
        public const String FLD_NAME_Note = "Note";
        public const String FLD_NAME_WorkingDay = "WorkingDay";
        public const String FLD_NAME_Year = "Year";
        public const String FLD_NAME_Month = "Month";
        public const String FLD_NAME_Day = "Day";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Date = "Date";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
