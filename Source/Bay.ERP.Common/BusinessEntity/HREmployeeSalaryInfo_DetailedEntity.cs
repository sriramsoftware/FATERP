// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeSalaryInfo_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeSalaryInfo_DetailedEntity : BaseEntity
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
        private DateTime _FiscalYearBeginDate;
        private DateTime _FiscalYearEndDate;
        private String _EmployeeFullName;
        private String _PayCycleName;
        private String _PayscaleName;
        private String _ProjectName;
        private String _ProjectCode;
        private String _DepartmentCode;
        private String _DesignaitonName;

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

        [DataMember]
        public DateTime FiscalYearBeginDate
        {
            get { return _FiscalYearBeginDate; }
            set { _FiscalYearBeginDate = value; }
        }

        [DataMember]
        public DateTime FiscalYearEndDate
        {
            get { return _FiscalYearEndDate; }
            set { _FiscalYearEndDate = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String PayCycleName
        {
            get { return _PayCycleName; }
            set { _PayCycleName = value; }
        }

        [DataMember]
        public String PayscaleName
        {
            get { return _PayscaleName; }
            set { _PayscaleName = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public String DepartmentCode
        {
            get { return _DepartmentCode; }
            set { _DepartmentCode = value; }
        }

        [DataMember]
        public String DesignaitonName
        {
            get { return _DesignaitonName; }
            set { _DesignaitonName = value; }
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

        public HREmployeeSalaryInfo_DetailedEntity()
            : base()
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
        public const String FLD_NAME_FiscalYearBeginDate = "FiscalYearBeginDate";
        public const String FLD_NAME_FiscalYearEndDate= "FiscalYearEndDate";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_PayCycleName = "PayCycleName";
        public const String FLD_NAME_PayscaleName = "PayscaleName";
        public const String FLD_NAME_ProjectName ="ProjectName";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_DepartmentCode = "DepartmentCode";
        public const String FLD_NAME_DesignaitonName ="DesignaitonName";

        #endregion
    }
}
