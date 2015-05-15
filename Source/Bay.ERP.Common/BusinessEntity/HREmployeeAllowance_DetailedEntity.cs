// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 11:16:35




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeAllowance_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeAllowance_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeAllowanceID;
        private Int64 _EmployeeID;
        private Int64 _FiscalYearID;
        private Int64 _AllowanceCategoryID;
        private Decimal _Amount;
        private String _Remarks;
        private DateTime _CreateDate;
        private Int64? _RowNumber;
        private String _EmployeeFullName;
        private DateTime _FiscalYearBeginDate;
        private DateTime _FiscalYearEndDate;
        private String _AllowanceCategoryName;
        private String _EmployeeCode;

        [DataMember]
        public Int64 EmployeeAllowanceID
        {
            get { return _EmployeeAllowanceID; }
            set { _EmployeeAllowanceID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [DataMember]
        public Int64 AllowanceCategoryID
        {
            get { return _AllowanceCategoryID; }
            set { _AllowanceCategoryID = value; }
        }

        [DataMember]
        public Decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
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
        public String AllowanceCategoryName
        {
            get { return _AllowanceCategoryName; }
            set { _AllowanceCategoryName = value; }
        }

        [DataMember]
        public String EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
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
                return (EmployeeAllowanceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeAllowance_DetailedEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeAllowanceID = "EmployeeAllowanceID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_AllowanceCategoryID = "AllowanceCategoryID";
        public const String FLD_NAME_Amount = "Amount";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_FiscalYearBeginDate = "FiscalYearBeginDate";
        public const String FLD_NAME_FiscalYearEndDate = "FiscalYearEndDate";
        public const String FLD_NAME_AllowanceCategoryName = "AllowanceCategoryName";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";


        #endregion
    }
}
