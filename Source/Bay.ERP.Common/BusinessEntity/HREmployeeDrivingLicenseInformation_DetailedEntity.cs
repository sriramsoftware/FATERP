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
    [DataContract(Name = "HREmployeeDrivingLicenseInformation_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeDrivingLicenseInformation_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeDrivingLicenseInformationID;
        private Int64 _EmployeeID;
        private Int64 _DrivingLicenseCategoryID;
        private String _LicenseNumber;
        private Int64 _CountryID;
        private String _CityName;
        private DateTime _IssuedDate;
        private DateTime? _ExpiryDate;
        private DateTime? _RenewDate;
        private Boolean _IsDefaultLicense;
        private String _EmployeeFullName;
        private String _DrivingLicenseCategoryName;
        private String _CountryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 EmployeeDrivingLicenseInformationID
        {
            get { return _EmployeeDrivingLicenseInformationID; }
            set { _EmployeeDrivingLicenseInformationID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 DrivingLicenseCategoryID
        {
            get { return _DrivingLicenseCategoryID; }
            set { _DrivingLicenseCategoryID = value; }
        }

        [DataMember]
        public String LicenseNumber
        {
            get { return _LicenseNumber; }
            set { _LicenseNumber = value; }
        }

        [DataMember]
        public Int64 CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public String CityName
        {
            get { return _CityName; }
            set { _CityName = value; }
        }

        [DataMember]
        public DateTime IssuedDate
        {
            get { return _IssuedDate; }
            set { _IssuedDate = value; }
        }

        [DataMember]
        public DateTime? ExpiryDate
        {
            get { return _ExpiryDate; }
            set { _ExpiryDate = value; }
        }

        [DataMember]
        public DateTime? RenewDate
        {
            get { return _RenewDate; }
            set { _RenewDate = value; }
        }

        [DataMember]
        public Boolean IsDefaultLicense
        {
            get { return _IsDefaultLicense; }
            set { _IsDefaultLicense = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String DrivingLicenseCategoryName
        {
            get { return _DrivingLicenseCategoryName; }
            set { _DrivingLicenseCategoryName = value; }
        }

        [DataMember]
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
        }

        [DataMember]
        public String CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeDrivingLicenseInformationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeDrivingLicenseInformation_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeDrivingLicenseInformationID = "EmployeeDrivingLicenseInformationID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_DrivingLicenseCategoryID = "DrivingLicenseCategoryID";
        public const String FLD_NAME_LicenseNumber = "LicenseNumber";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_CityName = "CityName";
        public const String FLD_NAME_IssuedDate = "IssuedDate";
        public const String FLD_NAME_ExpiryDate = "ExpiryDate";
        public const String FLD_NAME_RenewDate = "RenewDate";
        public const String FLD_NAME_IsDefaultLicense = "IsDefaultLicense";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_DrivingLicenseCategoryName = "DrivingLicenseCategoryName";
        public const String FLD_NAME_CountryName = "CountryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
