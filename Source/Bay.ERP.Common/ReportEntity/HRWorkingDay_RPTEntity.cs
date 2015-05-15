// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 06:06:24




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HRWorkingDay_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRWorkingDay_RPTEntity : BaseEntity
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
        private DateTime? _BeginDate;
        private DateTime? _EndDate;
        private Boolean _IsClosed;
        private Boolean _IsLocked;
        private String _Name;
        private DateTime? _SessionStartDate;
        private DateTime? _SessionEndDate;
        private String _SalarySessionRemarks;
        private Int64? _SalarySessionStatusID;
        private Boolean _IsCurrentSession;
        private String _AttendanceLeaveAndHolidayCategoryName;
        private String _Description;
        private String _SalarySessionStatusName;


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

        [DataMember]
        public DateTime? BeginDate
        {
            get { return _BeginDate; }
            set { _BeginDate = value; }
        }

        [DataMember]
        public DateTime? EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        [DataMember]
        public Boolean IsClosed
        {
            get { return _IsClosed; }
            set { _IsClosed = value; }
        }

        [DataMember]
        public Boolean IsLocked
        {
            get { return _IsLocked; }
            set { _IsLocked = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
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
        public String SalarySessionRemarks
        {
            get { return _SalarySessionRemarks; }
            set { _SalarySessionRemarks = value; }
        }

        [DataMember]
        public Int64? SalarySessionStatusID
        {
            get { return _SalarySessionStatusID; }
            set { _SalarySessionStatusID = value; }
        }

        [DataMember]
        public Boolean IsCurrentSession
        {
            get { return _IsCurrentSession; }
            set { _IsCurrentSession = value; }
        }

        [DataMember]
        public String AttendanceLeaveAndHolidayCategoryName
        {
            get { return _AttendanceLeaveAndHolidayCategoryName; }
            set { _AttendanceLeaveAndHolidayCategoryName = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public String SalarySessionStatusName
        {
            get { return _SalarySessionStatusName; }
            set { _SalarySessionStatusName = value; }
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

        public HRWorkingDay_RPTEntity() : base()
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
        public const String FLD_NAME_BeginDate = "BeginDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_IsClosed = "IsClosed";
        public const String FLD_NAME_IsLocked = "IsLocked";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_SessionStartDate = "SessionStartDate";
        public const String FLD_NAME_SessionEndDate = "SessionEndDate";
        public const String FLD_NAME_SalarySessionRemarks = "SalarySessionRemarks";
        public const String FLD_NAME_SalarySessionStatusID = "SalarySessionStatusID";
        public const String FLD_NAME_IsCurrentSession = "IsCurrentSession";
        public const String FLD_NAME_AttendanceLeaveAndHolidayCategoryName = "AttendanceLeaveAndHolidayCategoryName";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_SalarySessionStatusName = "SalarySessionStatusName";

        #endregion
    }
}
