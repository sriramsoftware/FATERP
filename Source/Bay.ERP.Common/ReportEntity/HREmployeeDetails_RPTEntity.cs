// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2014, 04:10:32




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeDetails_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeDetails_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeID;
        private Int64 _MemberID;
        private Int64? _ProjectID;
        private Int64? _DesignationID;
        private String _EmployeeCode;
        private Int64 _EmployeeJobTypeID;
        private DateTime? _ConfirmDate;
        private DateTime? _JoinDate;
        private Int32? _SalaryLevel;
        private String _OfficialEmail;
        private Int64? _DepartmentID;
        private Int64? _EmploymentStatusID;
        private String _Initials;
        private String _SecondaryEmail;
        private String _EmployeeFullName;
        private Int64? _BloodGroupID;
        private DateTime? _DOB;
        private String _ProjectCode;
        private String _ProjectName;
        private String _DepartmentCode;
        private String _EmployeeJobTypeName;
        private String _DesignationName;
        private String _EmploymentStatusName;
        private Int64? _EmployeePhotoID;
        private String _CurrentFileName;
        private String _Extension;
        private String _Remarks;
        private String _Path;
        private String _OriginalFileName;
        private String _FileType;
        private Boolean _IsCurrent;
        private String _BloodGroup;
        private String _CurrentAddressLine1;
        private String _CurrentAddressLine2;
        private String _PermanentAddressLine1;
        private String _PermanentAddressLine2;
        private String _BankAccountNo;
        private String _Mobile;
        private String _OfficialPhone;
        private String _ResidencePhone;
        private String _LastEducation;


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
        public Int32? SalaryLevel
        {
            get { return _SalaryLevel; }
            set { _SalaryLevel = value; }
        }

        [DataMember]
        public String OfficialEmail
        {
            get { return _OfficialEmail; }
            set { _OfficialEmail = value; }
        }

        [DataMember]
        public Int64? DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        [DataMember]
        public Int64? EmploymentStatusID
        {
            get { return _EmploymentStatusID; }
            set { _EmploymentStatusID = value; }
        }

        [DataMember]
        public String Initials
        {
            get { return _Initials; }
            set { _Initials = value; }
        }

        [DataMember]
        public String SecondaryEmail
        {
            get { return _SecondaryEmail; }
            set { _SecondaryEmail = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public Int64? BloodGroupID
        {
            get { return _BloodGroupID; }
            set { _BloodGroupID = value; }
        }

        [DataMember]
        public DateTime? DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String DepartmentCode
        {
            get { return _DepartmentCode; }
            set { _DepartmentCode = value; }
        }

        [DataMember]
        public String EmployeeJobTypeName
        {
            get { return _EmployeeJobTypeName; }
            set { _EmployeeJobTypeName = value; }
        }

        [DataMember]
        public String DesignationName
        {
            get { return _DesignationName; }
            set { _DesignationName = value; }
        }

        [DataMember]
        public String EmploymentStatusName
        {
            get { return _EmploymentStatusName; }
            set { _EmploymentStatusName = value; }
        }

        [DataMember]
        public Int64? EmployeePhotoID
        {
            get { return _EmployeePhotoID; }
            set { _EmployeePhotoID = value; }
        }

        [DataMember]
        public String CurrentFileName
        {
            get { return _CurrentFileName; }
            set { _CurrentFileName = value; }
        }

        [DataMember]
        public String Extension
        {
            get { return _Extension; }
            set { _Extension = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String Path
        {
            get { return _Path; }
            set { _Path = value; }
        }

        [DataMember]
        public String OriginalFileName
        {
            get { return _OriginalFileName; }
            set { _OriginalFileName = value; }
        }

        [DataMember]
        public String FileType
        {
            get { return _FileType; }
            set { _FileType = value; }
        }

        [DataMember]
        public Boolean IsCurrent
        {
            get { return _IsCurrent; }
            set { _IsCurrent = value; }
        }

        [DataMember]
        public String BloodGroup
        {
            get { return _BloodGroup; }
            set { _BloodGroup = value; }
        }

        [DataMember]
        public String CurrentAddressLine1
        {
            get { return _CurrentAddressLine1; }
            set { _CurrentAddressLine1 = value; }
        }

        [DataMember]
        public String CurrentAddressLine2
        {
            get { return _CurrentAddressLine2; }
            set { _CurrentAddressLine2 = value; }
        }

        [DataMember]
        public String PermanentAddressLine1
        {
            get { return _PermanentAddressLine1; }
            set { _PermanentAddressLine1 = value; }
        }

        [DataMember]
        public String PermanentAddressLine2
        {
            get { return _PermanentAddressLine2; }
            set { _PermanentAddressLine2 = value; }
        }

        [DataMember]
        public String BankAccountNo
        {
            get { return _BankAccountNo; }
            set { _BankAccountNo = value; }
        }

        [DataMember]
        public String Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }

        [DataMember]
        public String OfficialPhone
        {
            get { return _OfficialPhone; }
            set { _OfficialPhone = value; }
        }

        [DataMember]
        public String ResidencePhone
        {
            get { return _ResidencePhone; }
            set { _ResidencePhone = value; }
        }

        [DataMember]
        public String LastEducation
        {
            get { return _LastEducation; }
            set { _LastEducation = value; }
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

        public HREmployeeDetails_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_MemberID = "MemberID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_DesignationID = "DesignationID";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_EmployeeJobTypeID = "EmployeeJobTypeID";
        public const String FLD_NAME_ConfirmDate = "ConfirmDate";
        public const String FLD_NAME_JoinDate = "JoinDate";
        public const String FLD_NAME_SalaryLevel = "SalaryLevel";
        public const String FLD_NAME_OfficialEmail = "OfficialEmail";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_EmploymentStatusID = "EmploymentStatusID";
        public const String FLD_NAME_Initials = "Initials";
        public const String FLD_NAME_SecondaryEmail = "SecondaryEmail";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_BloodGroupID = "BloodGroupID";
        public const String FLD_NAME_DOB = "DOB";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_DepartmentCode = "DepartmentCode";
        public const String FLD_NAME_EmployeeJobTypeName = "EmployeeJobTypeName";
        public const String FLD_NAME_DesignationName = "DesignationName";
        public const String FLD_NAME_EmploymentStatusName = "EmploymentStatusName";
        public const String FLD_NAME_EmployeePhotoID = "EmployeePhotoID";
        public const String FLD_NAME_CurrentFileName = "CurrentFileName";
        public const String FLD_NAME_Extension = "Extension";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_Path = "Path";
        public const String FLD_NAME_OriginalFileName = "OriginalFileName";
        public const String FLD_NAME_FileType = "FileType";
        public const String FLD_NAME_IsCurrent = "IsCurrent";
        public const String FLD_NAME_BloodGroup = "BloodGroup";
        public const String FLD_NAME_CurrentAddressLine1 = "CurrentAddressLine1";
        public const String FLD_NAME_CurrentAddressLine2 = "CurrentAddressLine2";
        public const String FLD_NAME_PermanentAddressLine1 = "PermanentAddressLine1";
        public const String FLD_NAME_PermanentAddressLine2 = "PermanentAddressLine2";
        public const String FLD_NAME_BankAccountNo = "BankAccountNo";
        public const String FLD_NAME_Mobile = "Mobile";
        public const String FLD_NAME_OfficialPhone = "OfficialPhone";
        public const String FLD_NAME_ResidencePhone = "ResidencePhone";
        public const String FLD_NAME_LastEducation = "LastEducation";

        #endregion
    }
}
