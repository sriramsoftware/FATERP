// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Sep-2013, 12:52:44




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HRDTLSubmission_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRDTLSubmission_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _AssignedToEmployeeID;
        private Int32? _TotalSubmited;
        private Decimal? _TotalHoursWorked;
        private String _Description;
        private String _EmployeeCode;
        private String _DepartmentName;
        private String _MemberFullName;
        private Int32? _SalaryLevel;
        private String _DesignaitonName;


        [DataMember]
        public Int64 AssignedToEmployeeID
        {
            get { return _AssignedToEmployeeID; }
            set { _AssignedToEmployeeID = value; }
        }

        [DataMember]
        public Int32? TotalSubmited
        {
            get { return _TotalSubmited; }
            set { _TotalSubmited = value; }
        }

        [DataMember]
        public Decimal? TotalHoursWorked
        {
            get { return _TotalHoursWorked; }
            set { _TotalHoursWorked = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public String EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }

        [DataMember]
        public String DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public Int32? SalaryLevel
        {
            get { return _SalaryLevel; }
            set { _SalaryLevel = value; }
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
                return (AssignedToEmployeeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HRDTLSubmission_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AssignedToEmployeeID = "AssignedToEmployeeID";
        public const String FLD_NAME_TotalSubmited = "TotalSubmited";
        public const String FLD_NAME_TotalHoursWorked = "TotalHoursWorked";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_DepartmentName = "DepartmentName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_SalaryLevel = "SalaryLevel";
        public const String FLD_NAME_DesignaitonName = "DesignaitonName";

        #endregion
    }
}
