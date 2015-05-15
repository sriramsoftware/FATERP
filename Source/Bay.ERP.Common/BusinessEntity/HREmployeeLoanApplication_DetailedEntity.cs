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
    [DataContract(Name = "HREmployeeLoanApplication_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeLoanApplication_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeLoanApplicationID;
        private Int64 _EmployeeID;
        private Int64 _LoanCategoryID;
        private Decimal _AppliedLoanAmount;
        private Int64 _CurrencyID;
        private DateTime? _LoanPaymentStartDate;
        private DateTime? _LoanPaymentEndDate;
        private Decimal? _NumberOfInstallment;
        private String _Description;
        private Int64 _EmployeeLoanApprovalStatusID;
        private String _Remarks;
        private String _EmployeeFullName;
        private String _LoanCategoryName;
        private String _CurrencyName;
        private String _EmployeeLoanApprovalStatusName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 EmployeeLoanApplicationID
        {
            get { return _EmployeeLoanApplicationID; }
            set { _EmployeeLoanApplicationID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 LoanCategoryID
        {
            get { return _LoanCategoryID; }
            set { _LoanCategoryID = value; }
        }

        [DataMember]
        public Decimal AppliedLoanAmount
        {
            get { return _AppliedLoanAmount; }
            set { _AppliedLoanAmount = value; }
        }

        [DataMember]
        public Int64 CurrencyID
        {
            get { return _CurrencyID; }
            set { _CurrencyID = value; }
        }

        [DataMember]
        public DateTime? LoanPaymentStartDate
        {
            get { return _LoanPaymentStartDate; }
            set { _LoanPaymentStartDate = value; }
        }

        [DataMember]
        public DateTime? LoanPaymentEndDate
        {
            get { return _LoanPaymentEndDate; }
            set { _LoanPaymentEndDate = value; }
        }

        [DataMember]
        public Decimal? NumberOfInstallment
        {
            get { return _NumberOfInstallment; }
            set { _NumberOfInstallment = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Int64 EmployeeLoanApprovalStatusID
        {
            get { return _EmployeeLoanApprovalStatusID; }
            set { _EmployeeLoanApprovalStatusID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String LoanCategoryName
        {
            get { return _LoanCategoryName; }
            set { _LoanCategoryName = value; }
        }

        [DataMember]
        public String CurrencyName
        {
            get { return _CurrencyName; }
            set { _CurrencyName = value; }
        }

        [DataMember]
        public String EmployeeLoanApprovalStatusName
        {
            get { return _EmployeeLoanApprovalStatusName; }
            set { _EmployeeLoanApprovalStatusName = value; }
        }

        [DataMember]
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeLoanApplicationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeLoanApplication_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeLoanApplicationID = "EmployeeLoanApplicationID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_LoanCategoryID = "LoanCategoryID";
        public const String FLD_NAME_AppliedLoanAmount = "AppliedLoanAmount";
        public const String FLD_NAME_CurrencyID = "CurrencyID";
        public const String FLD_NAME_LoanPaymentStartDate = "LoanPaymentStartDate";
        public const String FLD_NAME_LoanPaymentEndDate = "LoanPaymentEndDate";
        public const String FLD_NAME_NumberOfInstallment = "NumberOfInstallment";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_EmployeeLoanApprovalStatusID = "EmployeeLoanApprovalStatusID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_LoanCategoryName = "LoanCategoryName";
        public const String FLD_NAME_CurrencyName = "CurrencyName";
        public const String FLD_NAME_EmployeeLoanApprovalStatusName = "EmployeeLoanApprovalStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
