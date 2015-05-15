// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jan-2013, 02:02:12




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ResourceEmployee_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ResourceEmployee_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _ResourceID;
        private Int64 _ReferenceID;
        private Int64 _EmployeeID;
        private String _EmployeeCode;
        private Int64? _DesignationID;
        private DateTime? _DOB;
        private DateTime? _JoinDate;
        private DateTime? _ConfirmDate;
        private Int64? _BloodGroupID;
        private Int64 _EmployeeJobTypeID;
        private String _PrimaryEmail;
        private String _SecondaryEmail;
        private String _ResourceCategoryName;
        private String _MemberFullName;
        private String _DesignationName;
        private String _DepartmentName;
        private String _BloodGroupName;
        private String _EmployeeJobTypeName;


        [DataMember]
        public Int64 ResourceID
        {
            get { return _ResourceID; }
            set { _ResourceID = value; }
        }

        [DataMember]
        public Int64 ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public String EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }

        [DataMember]
        public Int64? DesignationID
        {
            get { return _DesignationID; }
            set { _DesignationID = value; }
        }

        [DataMember]
        public DateTime? DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        [DataMember]
        public DateTime? JoinDate
        {
            get { return _JoinDate; }
            set { _JoinDate = value; }
        }

        [DataMember]
        public DateTime? ConfirmDate
        {
            get { return _ConfirmDate; }
            set { _ConfirmDate = value; }
        }

        [DataMember]
        public Int64? BloodGroupID
        {
            get { return _BloodGroupID; }
            set { _BloodGroupID = value; }
        }

        [DataMember]
        public Int64 EmployeeJobTypeID
        {
            get { return _EmployeeJobTypeID; }
            set { _EmployeeJobTypeID = value; }
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
        public String ResourceCategoryName
        {
            get { return _ResourceCategoryName; }
            set { _ResourceCategoryName = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public String DesignationName
        {
            get { return _DesignationName; }
            set { _DesignationName = value; }
        }

        [DataMember]
        public String DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }

        [DataMember]
        public String BloodGroupName
        {
            get { return _BloodGroupName; }
            set { _BloodGroupName = value; }
        }

        [DataMember]
        public String EmployeeJobTypeName
        {
            get { return _EmployeeJobTypeName; }
            set { _EmployeeJobTypeName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ResourceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ResourceEmployee_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ResourceID = "ResourceID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_DesignationID = "DesignationID";
        public const String FLD_NAME_DOB = "DOB";
        public const String FLD_NAME_JoinDate = "JoinDate";
        public const String FLD_NAME_ConfirmDate = "ConfirmDate";
        public const String FLD_NAME_BloodGroupID = "BloodGroupID";
        public const String FLD_NAME_EmployeeJobTypeID = "EmployeeJobTypeID";
        public const String FLD_NAME_PrimaryEmail = "PrimaryEmail";
        public const String FLD_NAME_SecondaryEmail = "SecondaryEmail";
        public const String FLD_NAME_ResourceCategoryName = "ResourceCategoryName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_DesignationName = "DesignationName";
        public const String FLD_NAME_DepartmentName = "DepartmentName";
        public const String FLD_NAME_BloodGroupName = "BloodGroupName";
        public const String FLD_NAME_EmployeeJobTypeName = "EmployeeJobTypeName";

        #endregion
    }
}
