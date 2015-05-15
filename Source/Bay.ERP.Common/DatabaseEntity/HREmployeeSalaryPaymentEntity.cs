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
    [DataContract(Name = "HREmployeeSalaryPayment", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeSalaryPaymentEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeSalaryPaymentID;
        private Int64 _EmployeeID;
        private Int64 _EmployeeJobTypeID;
        private Int64? _ProjectID;
        private Int64? _DepartmentID;
        private Int64? _DesignationID;
        private String _EmployeeCode;
        private Int64? _SalarySessionID;
        private DateTime _SalarySessionStartDate;
        private DateTime? _SalarySessionEndDate;
        private Decimal _ConsolidateSalaryAmount;
        private Decimal _Workdays;
        private Decimal _Advance;
        private Decimal _Fine;
        private Decimal _Meals;
        private Decimal _AIT;
        private Decimal _Adjustment;
        private Decimal _NetPayable;
        private Decimal _Note;
        private Decimal _Cash;
        private Decimal _BankAmount;
        private Decimal _SalaryPayable;
        private Decimal _Allowance;
        private Decimal _ProjectActual;
        private Decimal _Bonus;
        private Decimal _PhoneCeiling;
        private Decimal _PhoneActualBill;
        private Decimal _PhoneBillAdjustment;
        private Decimal _ProvidentFundDeductedAmount;
        private Decimal _PBR;
        private Decimal _EBR;
        private Decimal _PhoneBill;
        private Int64 _EmployeeSalaryPaymentStatusID;
        private Int64? _SalaryLevel;
        private String _Field2;
        private String _Field3;
        private String _Field4;
        private Decimal? _TBR;
        private Decimal? _TAX;
        


        [DataMember]
        public Int64 EmployeeSalaryPaymentID
        {
            get { return _EmployeeSalaryPaymentID; }
            set { _EmployeeSalaryPaymentID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 EmployeeJobTypeID
        {
            get { return _EmployeeJobTypeID; }
            set { _EmployeeJobTypeID = value; }
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
        public String EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }

        [DataMember]
        public Int64? SalarySessionID
        {
            get { return _SalarySessionID; }
            set { _SalarySessionID = value; }
        }

        [DataMember]
        public DateTime SalarySessionStartDate
        {
            get { return _SalarySessionStartDate; }
            set { _SalarySessionStartDate = value; }
        }

        [DataMember]
        public DateTime? SalarySessionEndDate
        {
            get { return _SalarySessionEndDate; }
            set { _SalarySessionEndDate = value; }
        }

        [DataMember]
        public Decimal ConsolidateSalaryAmount
        {
            get { return _ConsolidateSalaryAmount; }
            set { _ConsolidateSalaryAmount = value; }
        }

        [DataMember]
        public Decimal Workdays
        {
            get { return _Workdays; }
            set { _Workdays = value; }
        }

        [DataMember]
        public Decimal Advance
        {
            get { return _Advance; }
            set { _Advance = value; }
        }

        [DataMember]
        public Decimal Fine
        {
            get { return _Fine; }
            set { _Fine = value; }
        }

        [DataMember]
        public Decimal Meals
        {
            get { return _Meals; }
            set { _Meals = value; }
        }

        [DataMember]
        public Decimal AIT
        {
            get { return _AIT; }
            set { _AIT = value; }
        }

        [DataMember]
        public Decimal Adjustment
        {
            get { return _Adjustment; }
            set { _Adjustment = value; }
        }

        [DataMember]
        public Decimal NetPayable
        {
            get { return _NetPayable; }
            set { _NetPayable = value; }
        }

        [DataMember]
        public Decimal Note
        {
            get { return _Note; }
            set { _Note = value; }
        }

        [DataMember]
        public Decimal Cash
        {
            get { return _Cash; }
            set { _Cash = value; }
        }

        [DataMember]
        public Decimal BankAmount
        {
            get { return _BankAmount; }
            set { _BankAmount = value; }
        }

        [DataMember]
        public Decimal SalaryPayable
        {
            get { return _SalaryPayable; }
            set { _SalaryPayable = value; }
        }

        [DataMember]
        public Decimal Allowance
        {
            get { return _Allowance; }
            set { _Allowance = value; }
        }

        [DataMember]
        public Decimal ProjectActual
        {
            get { return _ProjectActual; }
            set { _ProjectActual = value; }
        }

        [DataMember]
        public Decimal Bonus
        {
            get { return _Bonus; }
            set { _Bonus = value; }
        }

        [DataMember]
        public Decimal PhoneCeiling
        {
            get { return _PhoneCeiling; }
            set { _PhoneCeiling = value; }
        }

        [DataMember]
        public Decimal PhoneActualBill
        {
            get { return _PhoneActualBill; }
            set { _PhoneActualBill = value; }
        }

        [DataMember]
        public Decimal PhoneBillAdjustment
        {
            get { return _PhoneBillAdjustment; }
            set { _PhoneBillAdjustment = value; }
        }

        [DataMember]
        public Decimal ProvidentFundDeductedAmount
        {
            get { return _ProvidentFundDeductedAmount; }
            set { _ProvidentFundDeductedAmount = value; }
        }

        [DataMember]
        public Decimal PBR
        {
            get { return _PBR; }
            set { _PBR = value; }
        }

        [DataMember]
        public Decimal EBR
        {
            get { return _EBR; }
            set { _EBR = value; }
        }

        [DataMember]
        public Decimal PhoneBill
        {
            get { return _PhoneBill; }
            set { _PhoneBill = value; }
        }

        [DataMember]
        public Int64 EmployeeSalaryPaymentStatusID
        {
            get { return _EmployeeSalaryPaymentStatusID; }
            set { _EmployeeSalaryPaymentStatusID = value; }
        }

        [DataMember]
        public Int64? SalaryLevel
        {
            get { return _SalaryLevel; }
            set { _SalaryLevel = value; }
        }

        [DataMember]
        public String Field2
        {
            get { return _Field2; }
            set { _Field2 = value; }
        }

        [DataMember]
        public String Field3
        {
            get { return _Field3; }
            set { _Field3 = value; }
        }

        [DataMember]
        public String Field4
        {
            get { return _Field4; }
            set { _Field4 = value; }
        }

        [DataMember]
        public Decimal? TBR
        {
            get { return _TBR; }
            set { _TBR = value; }
        }

        [DataMember]
        public Decimal? TAX
        {
            get { return _TAX; }
            set { _TAX = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeSalaryPaymentID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeSalaryPaymentEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeSalaryPaymentID = "EmployeeSalaryPaymentID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_EmployeeJobTypeID = "EmployeeJobTypeID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_DesignationID = "DesignationID";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_SalarySessionStartDate = "SalarySessionStartDate";
        public const String FLD_NAME_SalarySessionEndDate = "SalarySessionEndDate";
        public const String FLD_NAME_ConsolidateSalaryAmount = "ConsolidateSalaryAmount";
        public const String FLD_NAME_Workdays = "Workdays";
        public const String FLD_NAME_Advance = "Advance";
        public const String FLD_NAME_Fine = "Fine";
        public const String FLD_NAME_Meals = "Meals";
        public const String FLD_NAME_AIT = "AIT";
        public const String FLD_NAME_Adjustment = "Adjustment";
        public const String FLD_NAME_NetPayable = "NetPayable";
        public const String FLD_NAME_Note = "Note";
        public const String FLD_NAME_Cash = "Cash";
        public const String FLD_NAME_BankAmount = "BankAmount";
        public const String FLD_NAME_SalaryPayable = "SalaryPayable";
        public const String FLD_NAME_Allowance = "Allowance";
        public const String FLD_NAME_ProjectActual = "ProjectActual";
        public const String FLD_NAME_Bonus = "Bonus";
        public const String FLD_NAME_PhoneCeiling = "PhoneCeiling";
        public const String FLD_NAME_PhoneActualBill = "PhoneActualBill";
        public const String FLD_NAME_PhoneBillAdjustment = "PhoneBillAdjustment";
        public const String FLD_NAME_ProvidentFundDeductedAmount = "ProvidentFundDeductedAmount";
        public const String FLD_NAME_PBR = "PBR";
        public const String FLD_NAME_EBR = "EBR";
        public const String FLD_NAME_PhoneBill = "PhoneBill";
        public const String FLD_NAME_EmployeeSalaryPaymentStatusID = "EmployeeSalaryPaymentStatusID";
        public const String FLD_NAME_SalaryLevel = "SalaryLevel";
        public const String FLD_NAME_Field2 = "Field2";
        public const String FLD_NAME_Field3 = "Field3";
        public const String FLD_NAME_Field4 = "Field4";
        public const String FLD_NAME_TBR = "TBR";
        public const String FLD_NAME_TAX = "TAX";

        #endregion
    }
}
