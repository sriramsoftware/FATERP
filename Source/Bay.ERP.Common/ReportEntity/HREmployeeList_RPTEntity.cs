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
    [DataContract(Name = "HREmployeeList_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeList_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeID;
        private Int64 _MemberID;
        private Int64? _ProjectID;
        private Int64? _DesignationID;
        private String _EmployeeCode;
        private DateTime? _ConfirmDate;
        private DateTime? _JoinDate;
        private Int32? _SalaryLevel;
        private String _EmployeeFullName;
        private String _ProjectCode;
        private String _ProjectName;
        private String _DepartmentCode;
        private String _DepartmentName;
        private String _DesignationName;
        private String _Description;
        private Decimal? _SalaryAmount;
        private String _Allowance;
        private DateTime _Discontinuation;


        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 MemberID
        {
            get { return _MemberID; }
            set { _MemberID = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
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
        public Int32? SalaryLevel
        {
            get { return _SalaryLevel; }
            set { _SalaryLevel = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
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
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Decimal? SalaryAmount
        {
            get { return _SalaryAmount; }
            set { _SalaryAmount = value; }
        }

        [DataMember]
        public String Allowance
        {
            get { return _Allowance; }
            set { _Allowance = value; }
        }

        [DataMember]
        public DateTime Discontinuation
        {
            get { return _Discontinuation; }
            set { _Discontinuation = value; }
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

        public HREmployeeList_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_MemberID = "MemberID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_DesignationID = "DesignationID";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_ConfirmDate = "ConfirmDate";
        public const String FLD_NAME_JoinDate = "JoinDate";
        public const String FLD_NAME_SalaryLevel = "SalaryLevel";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_DepartmentCode = "DepartmentCode";
        public const String FLD_NAME_DepartmentName = "DepartmentName";
        public const String FLD_NAME_DesignationName = "DesignationName";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_SalaryAmount = "SalaryAmount";
        public const String FLD_NAME_Allowance = "Allowance";
        public const String FLD_NAME_Discontinuation = "Discontinuation";

        #endregion
    }
}
