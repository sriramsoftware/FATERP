// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeConfidentialInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeConfidentialInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeConfidentialInfoID;
        private Int64 _EmployeeID;
        private Int32? _NumberofChildren;
        private DateTime? _DateofBirth;
        private Int64? _MaritalStatusID;
        private String _CityofBirth;
        private Int64? _BirthOfStateID;
        private Int64? _CountryOfBirthCountryID;
        private Int64? _ResidenceCountryID;
        private String _PersonlTaxIdNumber;
        private String _NationalIdNumber;
        private Int64? _RegionID;
        private Int64? _ReligionID;
        private String _BirthMark;
        private Int64? _BloodGroupID;
        private String _DisabilityInformation;
        private Int64? _GenderID;
        private DateTime? _AnniversaryDate;
        private String _Height;
        private String _Weight;
        private Int64? _CurrentNationalityCountryID;
        private Int64? _PreviousNationalityCountryID;
        private Boolean _HasPassport;
        private Boolean _HasDrivingLisence;
        private Boolean _IsRemoved;
        private Int64? _District;


        [DataMember]
        public Int64 EmployeeConfidentialInfoID
        {
            get { return _EmployeeConfidentialInfoID; }
            set { _EmployeeConfidentialInfoID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int32? NumberofChildren
        {
            get { return _NumberofChildren; }
            set { _NumberofChildren = value; }
        }

        [DataMember]
        public DateTime? DateofBirth
        {
            get { return _DateofBirth; }
            set { _DateofBirth = value; }
        }

        [DataMember]
        public Int64? MaritalStatusID
        {
            get { return _MaritalStatusID; }
            set { _MaritalStatusID = value; }
        }

        [DataMember]
        public String CityofBirth
        {
            get { return _CityofBirth; }
            set { _CityofBirth = value; }
        }

        [DataMember]
        public Int64? BirthOfStateID
        {
            get { return _BirthOfStateID; }
            set { _BirthOfStateID = value; }
        }

        [DataMember]
        public Int64? CountryOfBirthCountryID
        {
            get { return _CountryOfBirthCountryID; }
            set { _CountryOfBirthCountryID = value; }
        }

        [DataMember]
        public Int64? ResidenceCountryID
        {
            get { return _ResidenceCountryID; }
            set { _ResidenceCountryID = value; }
        }

        [DataMember]
        public String PersonlTaxIdNumber
        {
            get { return _PersonlTaxIdNumber; }
            set { _PersonlTaxIdNumber = value; }
        }

        [DataMember]
        public String NationalIdNumber
        {
            get { return _NationalIdNumber; }
            set { _NationalIdNumber = value; }
        }

        [DataMember]
        public Int64? RegionID
        {
            get { return _RegionID; }
            set { _RegionID = value; }
        }

        [DataMember]
        public Int64? ReligionID
        {
            get { return _ReligionID; }
            set { _ReligionID = value; }
        }

        [DataMember]
        public String BirthMark
        {
            get { return _BirthMark; }
            set { _BirthMark = value; }
        }

        [DataMember]
        public Int64? BloodGroupID
        {
            get { return _BloodGroupID; }
            set { _BloodGroupID = value; }
        }

        [DataMember]
        public String DisabilityInformation
        {
            get { return _DisabilityInformation; }
            set { _DisabilityInformation = value; }
        }

        [DataMember]
        public Int64? GenderID
        {
            get { return _GenderID; }
            set { _GenderID = value; }
        }

        [DataMember]
        public DateTime? AnniversaryDate
        {
            get { return _AnniversaryDate; }
            set { _AnniversaryDate = value; }
        }

        [DataMember]
        public String Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        [DataMember]
        public String Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        [DataMember]
        public Int64? CurrentNationalityCountryID
        {
            get { return _CurrentNationalityCountryID; }
            set { _CurrentNationalityCountryID = value; }
        }

        [DataMember]
        public Int64? PreviousNationalityCountryID
        {
            get { return _PreviousNationalityCountryID; }
            set { _PreviousNationalityCountryID = value; }
        }

        [DataMember]
        public Boolean HasPassport
        {
            get { return _HasPassport; }
            set { _HasPassport = value; }
        }

        [DataMember]
        public Boolean HasDrivingLisence
        {
            get { return _HasDrivingLisence; }
            set { _HasDrivingLisence = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public Int64? District
        {
            get { return _District; }
            set { _District = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EmployeeConfidentialInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeConfidentialInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeConfidentialInfoID = "EmployeeConfidentialInfoID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_NumberofChildren = "NumberofChildren";
        public const String FLD_NAME_DateofBirth = "DateofBirth";
        public const String FLD_NAME_MaritalStatusID = "MaritalStatusID";
        public const String FLD_NAME_CityofBirth = "CityofBirth";
        public const String FLD_NAME_BirthOfStateID = "BirthOfStateID";
        public const String FLD_NAME_CountryOfBirthCountryID = "CountryOfBirthCountryID";
        public const String FLD_NAME_ResidenceCountryID = "ResidenceCountryID";
        public const String FLD_NAME_PersonlTaxIdNumber = "PersonlTaxIdNumber";
        public const String FLD_NAME_NationalIdNumber = "NationalIdNumber";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_ReligionID = "ReligionID";
        public const String FLD_NAME_BirthMark = "BirthMark";
        public const String FLD_NAME_BloodGroupID = "BloodGroupID";
        public const String FLD_NAME_DisabilityInformation = "DisabilityInformation";
        public const String FLD_NAME_GenderID = "GenderID";
        public const String FLD_NAME_AnniversaryDate = "AnniversaryDate";
        public const String FLD_NAME_Height = "Height";
        public const String FLD_NAME_Weight = "Weight";
        public const String FLD_NAME_CurrentNationalityCountryID = "CurrentNationalityCountryID";
        public const String FLD_NAME_PreviousNationalityCountryID = "PreviousNationalityCountryID";
        public const String FLD_NAME_HasPassport = "HasPassport";
        public const String FLD_NAME_HasDrivingLisence = "HasDrivingLisence";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_District = "District";

        #endregion
    }
}
