// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2013, 04:18:32




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployee", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeID;
        private Int64 _MemberID;
        private Int64? _ProjectID;
        private Int64? _DepartmentID;
        private Int64? _DesignationID;
        private String _EmployeeCode;
        private Int64 _EmployeeJobTypeID;
        private DateTime? _ConfirmDate;
        private DateTime? _JoinDate;
        private DateTime? _DOB;
        private Int32? _SalaryLevel;
        private Int64? _BloodGroupID;
        private String _PrimaryEmail;
        private String _SecondaryEmail;
        private String _Initials;
        private Boolean _IsRemoved;
        private Int64 _EmploymentStatusID;
        private DateTime? _DiscontinuedDate; 


        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 MemberID
        {
            get { return _MemberID; }
            set { _MemberID = value; }
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
        public Int64 EmployeeJobTypeID
        {
            get { return _EmployeeJobTypeID; }
            set { _EmployeeJobTypeID = value; }
        }

        [DataMember]
        public DateTime? ConfirmDate
        {
            get { return _ConfirmDate; }
            set { _ConfirmDate = value; }
        }

        [DataMember]
        public DateTime? JoinDate
        {
            get { return _JoinDate; }
            set { _JoinDate = value; }
        }

        [DataMember]
        public DateTime? DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        [DataMember]
        public Int32? SalaryLevel
        {
            get { return _SalaryLevel; }
            set { _SalaryLevel = value; }
        }

        [DataMember]
        public Int64? BloodGroupID
        {
            get { return _BloodGroupID; }
            set { _BloodGroupID = value; }
        }

        [DataMember]
        public String PrimaryEmail
        {
            get { return _PrimaryEmail; }
            set { _PrimaryEmail = value; }
        }

        [DataMember]
        public String SecondaryEmail
        {
            get { return _SecondaryEmail; }
            set { _SecondaryEmail = value; }
        }

        [DataMember]
        public String Initials
        {
            get { return _Initials; }
            set { _Initials = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public Int64 EmploymentStatusID
        {
            get { return _EmploymentStatusID; }
            set { _EmploymentStatusID = value; }
        }

        [DataMember]
        public DateTime? DiscontinuedDate
        {
            get { return _DiscontinuedDate; }
            set { _DiscontinuedDate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_MemberID = "MemberID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_DesignationID = "DesignationID";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_EmployeeJobTypeID = "EmployeeJobTypeID";
        public const String FLD_NAME_ConfirmDate = "ConfirmDate";
        public const String FLD_NAME_JoinDate = "JoinDate";
        public const String FLD_NAME_DOB = "DOB";
        public const String FLD_NAME_SalaryLevel = "SalaryLevel";
        public const String FLD_NAME_BloodGroupID = "BloodGroupID";
        public const String FLD_NAME_PrimaryEmail = "PrimaryEmail";
        public const String FLD_NAME_SecondaryEmail = "SecondaryEmail";
        public const String FLD_NAME_Initials = "Initials";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_EmploymentStatusID = "EmploymentStatusID";

        #endregion
    }
}
