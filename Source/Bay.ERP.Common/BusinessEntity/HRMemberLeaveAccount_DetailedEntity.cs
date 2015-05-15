// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HRMemberLeaveAccount_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRMemberLeaveAccount_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _MemberLeaveAccountID;
        private Int64? _AttendanceLeaveHolidayListID;
        private Int64? _SalarySessionID;
        private Int64 _EmployeeID;
        private DateTime? _UpdateDate;
        private Decimal? _EarnedDays;
        private Decimal? _AccuredDays;
        private Decimal? _UsedDays;
        private Decimal? _BalanceDays;
        private Boolean _IsRemoved;
        private Int64 _FiscalYearID;
        private String _EmployeeFullName;
        private String _Name;
        private String _Code;
        private String _Color;
        private String _SalarySessionName;
        private DateTime? _BeginDate;
        private DateTime? _EndDate;
        private Boolean _IsClosed;
        private Boolean _IsLocked;
        private Int64? _RowNumber;
        private Int64 _LeaveCategoryID;
        private String _LeaveCategoryName;


        [DataMember]
        public Int64 MemberLeaveAccountID
        {
            get { return _MemberLeaveAccountID; }
            set { _MemberLeaveAccountID = value; }
        }

        [DataMember]
        public Int64? AttendanceLeaveHolidayListID
        {
            get { return _AttendanceLeaveHolidayListID; }
            set { _AttendanceLeaveHolidayListID = value; }
        }

        [DataMember]
        public Int64? SalarySessionID
        {
            get { return _SalarySessionID; }
            set { _SalarySessionID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public DateTime? UpdateDate
        {
            get { return _UpdateDate; }
            set { _UpdateDate = value; }
        }

        [DataMember]
        public Decimal? EarnedDays
        {
            get { return _EarnedDays; }
            set { _EarnedDays = value; }
        }

        [DataMember]
        public Decimal? AccuredDays
        {
            get { return _AccuredDays; }
            set { _AccuredDays = value; }
        }

        [DataMember]
        public Decimal? UsedDays
        {
            get { return _UsedDays; }
            set { _UsedDays = value; }
        }

        [DataMember]
        public Decimal? BalanceDays
        {
            get { return _BalanceDays; }
            set { _BalanceDays = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public Int64 FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        [DataMember]
        public String Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        [DataMember]
        public String SalarySessionName
        {
            get { return _SalarySessionName; }
            set { _SalarySessionName = value; }
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
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
        }

        [DataMember]
        public Int64 LeaveCategoryID
        {
            get { return _LeaveCategoryID; }
            set { _LeaveCategoryID = value; }
        }

        [DataMember]
        public String LeaveCategoryName
        {
            get { return _LeaveCategoryName; }
            set { _LeaveCategoryName = value; }
        }


        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (MemberLeaveAccountID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HRMemberLeaveAccount_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MemberLeaveAccountID = "MemberLeaveAccountID";
        public const String FLD_NAME_AttendanceLeaveHolidayListID = "AttendanceLeaveHolidayListID";
        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_UpdateDate = "UpdateDate";
        public const String FLD_NAME_EarnedDays = "EarnedDays";
        public const String FLD_NAME_AccuredDays = "AccuredDays";
        public const String FLD_NAME_UsedDays = "UsedDays";
        public const String FLD_NAME_BalanceDays = "BalanceDays";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Code = "Code";
        public const String FLD_NAME_Color = "Color";
        public const String FLD_NAME_SalarySessionName = "SalarySessionName";
        public const String FLD_NAME_BeginDate = "BeginDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_IsClosed = "IsClosed";
        public const String FLD_NAME_IsLocked = "IsLocked";
        public const String FLD_NAME_RowNumber = "RowNumber";
        public const String FLD_NAME_LeaveCategoryID = "LeaveCategoryID";
        public const String FLD_NAME_LeaveCategoryName = "LeaveCategoryName";

        #endregion
    }
}
