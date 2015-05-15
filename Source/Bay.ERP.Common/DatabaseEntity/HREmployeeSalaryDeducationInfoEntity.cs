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
    [DataContract(Name = "HREmployeeSalaryDeducationInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeSalaryDeducationInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeSalaryDeducationInfoID;
        private Int64 _SalaryDeducationCategoryID;
        private Int64 _SalarySessionID;
        private Int64 _FiscalYearID;
        private Int64 _EmployeeID;
        private Decimal _DeductionAmount;
        private Decimal _PercentageOfBasicSalary;
        private Int64 _PayCycleID;
        private DateTime _EffectiveDate;
        private DateTime? _EndDate;
        private Decimal _NumberOfPayments;
        private String _Note;
        private Boolean _IsRemoved;
        private Decimal? _NextInstallMent;


        [DataMember]
        public Int64 EmployeeSalaryDeducationInfoID
        {
            get { return _EmployeeSalaryDeducationInfoID; }
            set { _EmployeeSalaryDeducationInfoID = value; }
        }

        [DataMember]
        public Int64 SalaryDeducationCategoryID
        {
            get { return _SalaryDeducationCategoryID; }
            set { _SalaryDeducationCategoryID = value; }
        }

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
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Decimal DeductionAmount
        {
            get { return _DeductionAmount; }
            set { _DeductionAmount = value; }
        }

        [DataMember]
        public Decimal PercentageOfBasicSalary
        {
            get { return _PercentageOfBasicSalary; }
            set { _PercentageOfBasicSalary = value; }
        }

        [DataMember]
        public Int64 PayCycleID
        {
            get { return _PayCycleID; }
            set { _PayCycleID = value; }
        }

        [DataMember]
        public DateTime EffectiveDate
        {
            get { return _EffectiveDate; }
            set { _EffectiveDate = value; }
        }

        [DataMember]
        public DateTime? EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        [DataMember]
        public Decimal NumberOfPayments
        {
            get { return _NumberOfPayments; }
            set { _NumberOfPayments = value; }
        }

        [DataMember]
        public String Note
        {
            get { return _Note; }
            set { _Note = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public Decimal? NextInstallMent
        {
            get { return _NextInstallMent; }
            set { _NextInstallMent = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeSalaryDeducationInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeSalaryDeducationInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeSalaryDeducationInfoID = "EmployeeSalaryDeducationInfoID";
        public const String FLD_NAME_SalaryDeducationCategoryID = "SalaryDeducationCategoryID";
        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_DeductionAmount = "DeductionAmount";
        public const String FLD_NAME_PercentageOfBasicSalary = "PercentageOfBasicSalary";
        public const String FLD_NAME_PayCycleID = "PayCycleID";
        public const String FLD_NAME_EffectiveDate = "EffectiveDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_NumberOfPayments = "NumberOfPayments";
        public const String FLD_NAME_Note = "Note";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_NextInstallMent = "NextInstallMent";

        #endregion
    }
}
