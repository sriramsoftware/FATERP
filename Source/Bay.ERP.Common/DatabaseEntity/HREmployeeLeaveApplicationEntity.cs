// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 06:33:35




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeLeaveApplication", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeLeaveApplicationEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeLeaveApplicationID;
        private Int64 _EmployeeID;
        private DateTime _ApplicationDate;
        private DateTime _RequestStartDate;
        private DateTime _RequestEndDate;
        private Decimal _TotalLeaveDays;
        private String _Description;
        private Int64? _BackupEmployeeID;
        private Int64 _LeaveApplicationApplicationStatusID;
        private Int64? _LeaveCategoryID;
        private Int64? _SalarySessionID;
        private String _LeaveLocation;
        private Int64? _FiscalYearID;


        [DataMember]
        public Int64 EmployeeLeaveApplicationID
        {
            get { return _EmployeeLeaveApplicationID; }
            set { _EmployeeLeaveApplicationID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public DateTime ApplicationDate
        {
            get { return _ApplicationDate; }
            set { _ApplicationDate = value; }
        }

        [DataMember]
        public DateTime RequestStartDate
        {
            get { return _RequestStartDate; }
            set { _RequestStartDate = value; }
        }

        [DataMember]
        public DateTime RequestEndDate
        {
            get { return _RequestEndDate; }
            set { _RequestEndDate = value; }
        }

        [DataMember]
        public Decimal TotalLeaveDays
        {
            get { return _TotalLeaveDays; }
            set { _TotalLeaveDays = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Int64? BackupEmployeeID
        {
            get { return _BackupEmployeeID; }
            set { _BackupEmployeeID = value; }
        }

        [DataMember]
        public Int64 LeaveApplicationApplicationStatusID
        {
            get { return _LeaveApplicationApplicationStatusID; }
            set { _LeaveApplicationApplicationStatusID = value; }
        }

        [DataMember]
        public Int64? LeaveCategoryID
        {
            get { return _LeaveCategoryID; }
            set { _LeaveCategoryID = value; }
        }

        [DataMember]
        public Int64? SalarySessionID
        {
            get { return _SalarySessionID; }
            set { _SalarySessionID = value; }
        }

        [DataMember]
        public String LeaveLocation
        {
            get { return _LeaveLocation; }
            set { _LeaveLocation = value; }
        }

        [DataMember]
        public Int64? FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeLeaveApplicationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeLeaveApplicationEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeLeaveApplicationID = "EmployeeLeaveApplicationID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_ApplicationDate = "ApplicationDate";
        public const String FLD_NAME_RequestStartDate = "RequestStartDate";
        public const String FLD_NAME_RequestEndDate = "RequestEndDate";
        public const String FLD_NAME_TotalLeaveDays = "TotalLeaveDays";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_BackupEmployeeID = "BackupEmployeeID";
        public const String FLD_NAME_LeaveApplicationApplicationStatusID = "LeaveApplicationApplicationStatusID";
        public const String FLD_NAME_LeaveCategoryID = "LeaveCategoryID";
        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_LeaveLocation = "LeaveLocation";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";

        #endregion
    }
}
