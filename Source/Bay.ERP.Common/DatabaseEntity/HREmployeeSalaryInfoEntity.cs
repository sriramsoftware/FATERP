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
    [DataContract(Name = "HREmployeeSalaryInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeSalaryInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeSalaryInfoID;
        private Int64 _FiscalYearID;
        private Int64 _SalarySessionID;
        private Int64 _EmployeeID;
        private Boolean _IsDeposite;
        private Decimal _SalaryAmount;
        private Int64? _PayCycleID;
        private Int64? _PayscaleID;
        private String _EmployeeCode;
        private Int64? _ProjectID;
        private Int64? _DepartmentID;
        private Int64? _DesignationID;


        [DataMember]
        public Int64 EmployeeSalaryInfoID
        {
            get { return _EmployeeSalaryInfoID; }
            set { _EmployeeSalaryInfoID = value; }
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
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Boolean IsDeposite
        {
            get { return _IsDeposite; }
            set { _IsDeposite = value; }
        }

        [DataMember]
        public Decimal SalaryAmount
        {
            get { return _SalaryAmount; }
            set { _SalaryAmount = value; }
        }

        [DataMember]
        public Int64? PayCycleID
        {
            get { return _PayCycleID; }
            set { _PayCycleID = value; }
        }

        [DataMember]
        public Int64? PayscaleID
        {
            get { return _PayscaleID; }
            set { _PayscaleID = value; }
        }

        [DataMember]
        public String EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeSalaryInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeSalaryInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeSalaryInfoID = "EmployeeSalaryInfoID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_IsDeposite = "IsDeposite";
        public const String FLD_NAME_SalaryAmount = "SalaryAmount";
        public const String FLD_NAME_PayCycleID = "PayCycleID";
        public const String FLD_NAME_PayscaleID = "PayscaleID";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_DesignationID = "DesignationID";

        #endregion
    }
}
