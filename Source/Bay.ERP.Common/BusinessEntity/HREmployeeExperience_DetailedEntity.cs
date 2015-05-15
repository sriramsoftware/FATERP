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
    [DataContract(Name = "HREmployeeExperience_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeExperience_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeExperienceID;
        private Int64 _EmployeeID;
        private Int64 _CompanyCountryID;
        private String _CompanyName;
        private String _Address;
        private Int64 _EmployeeJobTypeID;
        private DateTime? _JobEndDate;
        private DateTime _JobStartDate;
        private String _ContactNo;
        private String _WebLink;
        private Boolean _IsLastCompany;
        private String _EmployeeFullName;
        private String _CountryName;
        private String _EmployeeJobTypeName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 EmployeeExperienceID
        {
            get { return _EmployeeExperienceID; }
            set { _EmployeeExperienceID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 CompanyCountryID
        {
            get { return _CompanyCountryID; }
            set { _CompanyCountryID = value; }
        }

        [DataMember]
        public String CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }

        [DataMember]
        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        [DataMember]
        public Int64 EmployeeJobTypeID
        {
            get { return _EmployeeJobTypeID; }
            set { _EmployeeJobTypeID = value; }
        }

        [DataMember]
        public DateTime? JobEndDate
        {
            get { return _JobEndDate; }
            set { _JobEndDate = value; }
        }

        [DataMember]
        public DateTime JobStartDate
        {
            get { return _JobStartDate; }
            set { _JobStartDate = value; }
        }

        [DataMember]
        public String ContactNo
        {
            get { return _ContactNo; }
            set { _ContactNo = value; }
        }

        [DataMember]
        public String WebLink
        {
            get { return _WebLink; }
            set { _WebLink = value; }
        }

        [DataMember]
        public Boolean IsLastCompany
        {
            get { return _IsLastCompany; }
            set { _IsLastCompany = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
        }

        [DataMember]
        public String EmployeeJobTypeName
        {
            get { return _EmployeeJobTypeName; }
            set { _EmployeeJobTypeName = value; }
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
                return (EmployeeExperienceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeExperience_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeExperienceID = "EmployeeExperienceID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_CompanyCountryID = "CompanyCountryID";
        public const String FLD_NAME_CompanyName = "CompanyName";
        public const String FLD_NAME_Address = "Address";
        public const String FLD_NAME_EmployeeJobTypeID = "EmployeeJobTypeID";
        public const String FLD_NAME_JobEndDate = "JobEndDate";
        public const String FLD_NAME_JobStartDate = "JobStartDate";
        public const String FLD_NAME_ContactNo = "ContactNo";
        public const String FLD_NAME_WebLink = "WebLink";
        public const String FLD_NAME_IsLastCompany = "IsLastCompany";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_CountryName = "CountryName";
        public const String FLD_NAME_EmployeeJobTypeName = "EmployeeJobTypeName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
