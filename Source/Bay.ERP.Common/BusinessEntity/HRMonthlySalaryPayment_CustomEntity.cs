// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Jan-2014, 04:17:08




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HRMonthlySalaryPayment_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRMonthlySalaryPayment_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _SalarySessionID;
        private Int64 _FiscalYearID;
        private String _Name;
        private DateTime _SessionStartDate;
        private DateTime _SessionEndDate;
        private String _Remarks;
        private Int64 _SalarySessionStatusID;
        private Boolean _IsCurrentSession;
        private Int64 _EmployeeID;
        private String _FirstName;
        private String _MiddleName;
        private String _LastName;
        private Decimal _SalaryAmount;
        private Decimal _ACTUALWORKDAYS;
        private Int64 _MemberID;
        private Int64? _EmploymentStatusID;
        private Int64? _ProjectID;
        private String _ProjectCode;
        private String _ProjectName;
        private String _DepartmentCode;
        private String _DepartmentName;
        private String _DesignationName;
        private Int64? _DepartmentID;
        private Int64? _DesignationID;
        private String _EmployeeCode;
        private Int64 _EmployeeJobTypeID;
        private String _EmployeeJobTypeName;
        private Int32? _SalaryLevel;
        private Int64? _ServiceDays;


        [DataMember]
        public Int64 SalarySessionID
        {
            get { return _SalarySessionID; }
            set { _SalarySessionID = value; }
        }

        [DataMember]
        public Int64 FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public DateTime SessionStartDate
        {
            get { return _SessionStartDate; }
            set { _SessionStartDate = value; }
        }

        [DataMember]
        public DateTime SessionEndDate
        {
            get { return _SessionEndDate; }
            set { _SessionEndDate = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 SalarySessionStatusID
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
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        [DataMember]
        public String MiddleName
        {
            get { return _MiddleName; }
            set { _MiddleName = value; }
        }

        [DataMember]
        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        [DataMember]
        public Decimal SalaryAmount
        {
            get { return _SalaryAmount; }
            set { _SalaryAmount = value; }
        }

        [DataMember]
        public Decimal ACTUALWORKDAYS
        {
            get { return _ACTUALWORKDAYS; }
            set { _ACTUALWORKDAYS = value; }
        }

        [DataMember]
        public Int64 MemberID
        {
            get { return _MemberID; }
            set { _MemberID = value; }
        }

        [DataMember]
        public Int64? EmploymentStatusID
        {
            get { return _EmploymentStatusID; }
            set { _EmploymentStatusID = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
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
        public Int64? DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        [DataMember]
        public Int64? DesignationID
        {
            get { return _DesignationID; }
            set { _DesignationID = value; }
        }

        [DataMember]
        public String EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }

        [DataMember]
        public Int64 EmployeeJobTypeID
        {
            get { return _EmployeeJobTypeID; }
            set { _EmployeeJobTypeID = value; }
        }

        [DataMember]
        public String EmployeeJobTypeName
        {
            get { return _EmployeeJobTypeName; }
            set { _EmployeeJobTypeName = value; }
        }

        [DataMember]
        public Int32? SalaryLevel
        {
            get { return _SalaryLevel; }
            set { _SalaryLevel = value; }
        }

        [DataMember]
        public Int64? ServiceDays
        {
            get { return _ServiceDays; }
            set { _ServiceDays = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SalarySessionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HRMonthlySalaryPayment_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_SessionStartDate = "SessionStartDate";
        public const String FLD_NAME_SessionEndDate = "SessionEndDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_SalarySessionStatusID = "SalarySessionStatusID";
        public const String FLD_NAME_IsCurrentSession = "IsCurrentSession";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_FirstName = "FirstName";
        public const String FLD_NAME_MiddleName = "MiddleName";
        public const String FLD_NAME_LastName = "LastName";
        public const String FLD_NAME_SalaryAmount = "SalaryAmount";
        public const String FLD_NAME_ACTUALWORKDAYS = "ACTUALWORKDAYS";
        public const String FLD_NAME_MemberID = "MemberID";
        public const String FLD_NAME_EmploymentStatusID = "EmploymentStatusID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_DepartmentCode = "DepartmentCode";
        public const String FLD_NAME_DepartmentName = "DepartmentName";
        public const String FLD_NAME_DesignationName = "DesignationName";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_DesignationID = "DesignationID";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_EmployeeJobTypeID = "EmployeeJobTypeID";
        public const String FLD_NAME_EmployeeJobTypeName = "EmployeeJobTypeName";
        public const String FLD_NAME_SalaryLevel = "SalaryLevel";
        public const String FLD_NAME_ServiceDays = "ServiceDays";

        #endregion
    }
}
