// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 12:08:49




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeAllowance", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeAllowanceEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeAllowanceID;
        private Int64 _EmployeeID;
        private Int64 _FiscalYearID;
        private Int64 _AllowanceCategoryID;
        private Decimal _Amount;
        private String _Remarks;
        private DateTime _CreateDate;


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

        public HREmployeeAllowanceEntity() : base()
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
        public const String FLD_NAME_CreateDate = "CreateDate";

        #endregion
    }
}
