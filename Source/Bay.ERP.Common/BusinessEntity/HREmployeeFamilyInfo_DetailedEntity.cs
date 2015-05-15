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
    [DataContract(Name = "HREmployeeFamilyInfo_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeFamilyInfo_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _HREmployeeFamilyInfoID;
        private Int64 _EmployeeID;
        private Int64 _FamilyRelationTypeID;
        private String _FirstName;
        private String _MiddleName;
        private String _LastName;
        private String _Profession;
        private Boolean _IsDependent;
        private Int64 _LastEducationAcquired;
        private Boolean _IsEmployed;
        private Decimal? _Age;
        private String _EmailAddress;
        private String _Phone;
        private String _EmployeeFullName;
        private String _FamilyRelationTypeName;
        private String _EducationalDegreeName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 HREmployeeFamilyInfoID
        {
            get { return _HREmployeeFamilyInfoID; }
            set { _HREmployeeFamilyInfoID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 FamilyRelationTypeID
        {
            get { return _FamilyRelationTypeID; }
            set { _FamilyRelationTypeID = value; }
        }

        [DataMember]
        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        [DataMember]
        public String MiddleName
        {
            get { return _MiddleName; }
            set { _MiddleName = value; }
        }

        [DataMember]
        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        [DataMember]
        public String Profession
        {
            get { return _Profession; }
            set { _Profession = value; }
        }

        [DataMember]
        public Boolean IsDependent
        {
            get { return _IsDependent; }
            set { _IsDependent = value; }
        }

        [DataMember]
        public Int64 LastEducationAcquired
        {
            get { return _LastEducationAcquired; }
            set { _LastEducationAcquired = value; }
        }

        [DataMember]
        public Boolean IsEmployed
        {
            get { return _IsEmployed; }
            set { _IsEmployed = value; }
        }

        [DataMember]
        public Decimal? Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        [DataMember]
        public String EmailAddress
        {
            get { return _EmailAddress; }
            set { _EmailAddress = value; }
        }

        [DataMember]
        public String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String FamilyRelationTypeName
        {
            get { return _FamilyRelationTypeName; }
            set { _FamilyRelationTypeName = value; }
        }

        [DataMember]
        public String EducationalDegreeName
        {
            get { return _EducationalDegreeName; }
            set { _EducationalDegreeName = value; }
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
                return (HREmployeeFamilyInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeFamilyInfo_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_HREmployeeFamilyInfoID = "HREmployeeFamilyInfoID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_FamilyRelationTypeID = "FamilyRelationTypeID";
        public const String FLD_NAME_FirstName = "FirstName";
        public const String FLD_NAME_MiddleName = "MiddleName";
        public const String FLD_NAME_LastName = "LastName";
        public const String FLD_NAME_Profession = "Profession";
        public const String FLD_NAME_IsDependent = "IsDependent";
        public const String FLD_NAME_LastEducationAcquired = "LastEducationAcquired";
        public const String FLD_NAME_IsEmployed = "IsEmployed";
        public const String FLD_NAME_Age = "Age";
        public const String FLD_NAME_EmailAddress = "EmailAddress";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_FamilyRelationTypeName = "FamilyRelationTypeName";
        public const String FLD_NAME_EducationalDegreeName = "EducationalDegreeName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
