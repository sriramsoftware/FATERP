// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jan-2014, 04:20:23




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeLeaveStatus_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeLeaveStatus_RPTEntity : BaseEntity
    {
        #region Properties


        private String _EmployeeFullName;
        private String _EmployeeCode;
        private DateTime? _ConfirmDate;
        private DateTime? _JoinDate;
        private Int32? _ServiceAgeMonth;
        private String _ProjectCode;
        private String _ProjectName;
        private String _DepartmentCode;
        private String _DepartmentName;
        private String _DesignationName;
        private Int64 _EmployeeLeaveApplicationID;
        private Int64 _EmployeeID;
        private DateTime _ApplicationDate;
        private DateTime _RequestStartDate;
        private DateTime _RequestEndDate;
        private Decimal _TotalLeaveDays;
        private String _Description;
        private Int64 _LeaveApplicationApplicationStatusID;
        private Int64? _LeaveCategoryID;
        private Int64? _FiscalYearID;
        private String _LeaveApplicationApplicationStatusName;
        private String _LeaveCategoryName;
        private Decimal? _CasualLeaveEarned;
        private Decimal? _MedicalLeaveEarned;
        private Decimal? _EarnLeaveEarned;
        private Decimal? _LWPLeaveEarned;
        private Decimal? _CasualLeaveEnjoyed;
        private Decimal? _MedicalLeaveEnjoyed;
        private Decimal? _EarnLeaveEnjoyed;
        private Decimal? _LWPLeaveEnjoyed;


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
        public DateTime? ConfirmDate
        {
            get { return _ConfirmDate; }
            set { _ConfirmDate = value; }
        }

        [DataMember]
        public DateTime? JoinDate
        {
            get { return _JoinDate; }
            set { _JoinDate = value; }
        }

        [DataMember]
        public Int32? ServiceAgeMonth
        {
            get { return _ServiceAgeMonth; }
            set { _ServiceAgeMonth = value; }
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

        [DataMember]
        public String DepartmentCode
        {
            get { return _DepartmentCode; }
            set { _DepartmentCode = value; }
        }

        [DataMember]
        public String DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }

        [DataMember]
        public String DesignationName
        {
            get { return _DesignationName; }
            set { _DesignationName = value; }
        }

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
        public Int64? FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [DataMember]
        public String LeaveApplicationApplicationStatusName
        {
            get { return _LeaveApplicationApplicationStatusName; }
            set { _LeaveApplicationApplicationStatusName = value; }
        }

        [DataMember]
        public String LeaveCategoryName
        {
            get { return _LeaveCategoryName; }
            set { _LeaveCategoryName = value; }
        }

        [DataMember]
        public Decimal? CasualLeaveEarned
        {
            get { return _CasualLeaveEarned; }
            set { _CasualLeaveEarned = value; }
        }

        [DataMember]
        public Decimal? MedicalLeaveEarned
        {
            get { return _MedicalLeaveEarned; }
            set { _MedicalLeaveEarned = value; }
        }

        [DataMember]
        public Decimal? EarnLeaveEarned
        {
            get { return _EarnLeaveEarned; }
            set { _EarnLeaveEarned = value; }
        }

        [DataMember]
        public Decimal? LWPLeaveEarned
        {
            get { return _LWPLeaveEarned; }
            set { _LWPLeaveEarned = value; }
        }

        [DataMember]
        public Decimal? CasualLeaveEnjoyed
        {
            get { return _CasualLeaveEnjoyed; }
            set { _CasualLeaveEnjoyed = value; }
        }

        [DataMember]
        public Decimal? MedicalLeaveEnjoyed
        {
            get { return _MedicalLeaveEnjoyed; }
            set { _MedicalLeaveEnjoyed = value; }
        }

        [DataMember]
        public Decimal? EarnLeaveEnjoyed
        {
            get { return _EarnLeaveEnjoyed; }
            set { _EarnLeaveEnjoyed = value; }
        }

        [DataMember]
        public Decimal? LWPLeaveEnjoyed
        {
            get { return _LWPLeaveEnjoyed; }
            set { _LWPLeaveEnjoyed = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeLeaveStatus_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_ConfirmDate = "ConfirmDate";
        public const String FLD_NAME_JoinDate = "JoinDate";
        public const String FLD_NAME_ServiceAgeMonth = "ServiceAgeMonth";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_DepartmentCode = "DepartmentCode";
        public const String FLD_NAME_DepartmentName = "DepartmentName";
        public const String FLD_NAME_DesignationName = "DesignationName";
        public const String FLD_NAME_EmployeeLeaveApplicationID = "EmployeeLeaveApplicationID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_ApplicationDate = "ApplicationDate";
        public const String FLD_NAME_RequestStartDate = "RequestStartDate";
        public const String FLD_NAME_RequestEndDate = "RequestEndDate";
        public const String FLD_NAME_TotalLeaveDays = "TotalLeaveDays";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_LeaveApplicationApplicationStatusID = "LeaveApplicationApplicationStatusID";
        public const String FLD_NAME_LeaveCategoryID = "LeaveCategoryID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_LeaveApplicationApplicationStatusName = "LeaveApplicationApplicationStatusName";
        public const String FLD_NAME_LeaveCategoryName = "LeaveCategoryName";
        public const String FLD_NAME_CasualLeaveEarned = "CasualLeaveEarned";
        public const String FLD_NAME_MedicalLeaveEarned = "MedicalLeaveEarned";
        public const String FLD_NAME_EarnLeaveEarned = "EarnLeaveEarned";
        public const String FLD_NAME_LWPLeaveEarned = "LWPLeaveEarned";
        public const String FLD_NAME_CasualLeaveEnjoyed = "CasualLeaveEnjoyed";
        public const String FLD_NAME_MedicalLeaveEnjoyed = "MedicalLeaveEnjoyed";
        public const String FLD_NAME_EarnLeaveEnjoyed = "EarnLeaveEnjoyed";
        public const String FLD_NAME_LWPLeaveEnjoyed = "LWPLeaveEnjoyed";

        #endregion
    }
}
