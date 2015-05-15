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
    [DataContract(Name = "HREmployeePassportInformation_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeePassportInformation_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeePassportInformationID;
        private Int64 _EmployeeID;
        private Int64 _PassportCountry;
        private String _CityName;
        private String _PassportNumber;
        private DateTime _IssuedDate;
        private DateTime _ExpireDate;
        private String _PassportProfession;
        private String _Note;
        private String _EmployeeFullName;
        private String _CountryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 EmployeePassportInformationID
        {
            get { return _EmployeePassportInformationID; }
            set { _EmployeePassportInformationID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 PassportCountry
        {
            get { return _PassportCountry; }
            set { _PassportCountry = value; }
        }

        [DataMember]
        public String CityName
        {
            get { return _CityName; }
            set { _CityName = value; }
        }

        [DataMember]
        public String PassportNumber
        {
            get { return _PassportNumber; }
            set { _PassportNumber = value; }
        }

        [DataMember]
        public DateTime IssuedDate
        {
            get { return _IssuedDate; }
            set { _IssuedDate = value; }
        }

        [DataMember]
        public DateTime ExpireDate
        {
            get { return _ExpireDate; }
            set { _ExpireDate = value; }
        }

        [DataMember]
        public String PassportProfession
        {
            get { return _PassportProfession; }
            set { _PassportProfession = value; }
        }

        [DataMember]
        public String Note
        {
            get { return _Note; }
            set { _Note = value; }
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
                return (EmployeePassportInformationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeePassportInformation_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeePassportInformationID = "EmployeePassportInformationID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_PassportCountry = "PassportCountry";
        public const String FLD_NAME_CityName = "CityName";
        public const String FLD_NAME_PassportNumber = "PassportNumber";
        public const String FLD_NAME_IssuedDate = "IssuedDate";
        public const String FLD_NAME_ExpireDate = "ExpireDate";
        public const String FLD_NAME_PassportProfession = "PassportProfession";
        public const String FLD_NAME_Note = "Note";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_CountryName = "CountryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
