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
    [DataContract(Name = "HRSalaryAdjustment", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRSalaryAdjustmentEntity : BaseEntity
    {
        #region Properties


        private Int64 _SalaryAdjustmentID;
        private Int64 _FiscalYearID;
        private Int64 _SalarySessionID;
        private Int64 _EmployeeID;
        private Int32? _SalaryLevel;
        private Int64? _DesignationID;
        private String _EmployeeCode;
        private Int64 _EmployeeJobTypeID;
        private Decimal _AdjustmentAmount;
        private String _Remarks;


        [DataMember]
        public Int64 SalaryAdjustmentID
        {
            get { return _SalaryAdjustmentID; }
            set { _SalaryAdjustmentID = value; }
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
        public Int32? SalaryLevel
        {
            get { return _SalaryLevel; }
            set { _SalaryLevel = value; }
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
        public Decimal AdjustmentAmount
        {
            get { return _AdjustmentAmount; }
            set { _AdjustmentAmount = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SalaryAdjustmentID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HRSalaryAdjustmentEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SalaryAdjustmentID = "SalaryAdjustmentID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_SalaryLevel = "SalaryLevel";
        public const String FLD_NAME_DesignationID = "DesignationID";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_EmployeeJobTypeID = "EmployeeJobTypeID";
        public const String FLD_NAME_AdjustmentAmount = "AdjustmentAmount";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
