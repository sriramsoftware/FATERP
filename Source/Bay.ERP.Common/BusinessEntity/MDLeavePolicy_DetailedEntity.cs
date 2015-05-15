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
    [DataContract(Name = "MDLeavePolicy_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDLeavePolicy_DetailedEntity : BaseEntity
    {
        #region Properties

        private Int64 _LeavePolicyID;
        private Int64 _FiscalYearID;
        private Int64 _EmployeeJobTypeID;
        private Int64 _LeaveCategoryID;
        private Decimal _LeaveInDays;
        private String _Remarks;
        private Boolean _IsRemoved;
        private String _ExtraField1;
        private String _ExtraField2;
        private DateTime _FiscalYearBeginDate;
        private DateTime _FiscalYearEndDate;
        private String _EmployeeJobTypeName;
        private String _LeaveCategoryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 LeavePolicyID
        {
            get { return _LeavePolicyID; }
            set { _LeavePolicyID = value; }
        }

        [DataMember]
        public Int64 FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [DataMember]
        public Int64 EmployeeJobTypeID
        {
            get { return _EmployeeJobTypeID; }
            set { _EmployeeJobTypeID = value; }
        }

        [DataMember]
        public Int64 LeaveCategoryID
        {
            get { return _LeaveCategoryID; }
            set { _LeaveCategoryID = value; }
        }

        [DataMember]
        public Decimal LeaveInDays
        {
            get { return _LeaveInDays; }
            set { _LeaveInDays = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String ExtraField1
        {
            get { return _ExtraField1; }
            set { _ExtraField1 = value; }
        }

        [DataMember]
        public String ExtraField2
        {
            get { return _ExtraField2; }
            set { _ExtraField2 = value; }
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
        public String EmployeeJobTypeName
        {
            get { return _EmployeeJobTypeName; }
            set { _EmployeeJobTypeName = value; }
        }

        [DataMember]
        public String LeaveCategoryName
        {
            get { return _LeaveCategoryName; }
            set { _LeaveCategoryName = value; }
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
                return (LeavePolicyID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDLeavePolicy_DetailedEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_LeavePolicyID = "LeavePolicyID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_EmployeeJobTypeID = "EmployeeJobTypeID";
        public const String FLD_NAME_LeaveCategoryID = "LeaveCategoryID";
        public const String FLD_NAME_LeaveInDays = "LeaveInDays";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_ExtraField1 = "ExtraField1";
        public const String FLD_NAME_ExtraField2 = "ExtraField";
        public const String FLD_NAME_FiscalYearBeginDate = "FiscalYearBeginDate";
        public const String FLD_NAME_FiscalYearEndDate = "FiscalYearEndDate";
        public const String FLD_NAME_EmployeeJobTypeName = "EmployeeJobTypeName";
        public const String FLD_NAME_LeaveCategoryName = "LeaveCategoryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
