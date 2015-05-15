// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeSalaryDisbursementBank_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeSalaryDisbursementBank_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeID;
        private Int64? _ProjectID;
        private Int64? _DesignationID;
        private String _EmployeeCode;
        private String _EmployeeFullName;
        private String _ProjectCode;
        private String _ProjectName;
        private String _DepartmentCode;
        private String _DesignationName;
        private String _BankAccountNo;
        private DateTime _SessionStartDate;
        private DateTime _SessionEndDate;
        private Decimal _SalaryAmount;


        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
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
        public String DesignationName
        {
            get { return _DesignationName; }
            set { _DesignationName = value; }
        }

        [DataMember]
        public String BankAccountNo
        {
            get { return _BankAccountNo; }
            set { _BankAccountNo = value; }
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
        public Decimal SalaryAmount
        {
            get { return _SalaryAmount; }
            set { _SalaryAmount = value; }
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

        public HREmployeeSalaryDisbursementBank_RPTEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_DesignationID = "DesignationID";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_DepartmentCode = "DepartmentCode";
        public const String FLD_NAME_DesignationName = "DesignationName";
        public const String FLD_NAME_BankAccountNo = "BankAccountNo";
        public const String FLD_NAME_SessionStartDate = "SessionStartDate";
        public const String FLD_NAME_SessionEndDate = "SessionEndDate";
        public const String FLD_NAME_SalaryAmount = "SalaryAmount";

        #endregion
    }
}
