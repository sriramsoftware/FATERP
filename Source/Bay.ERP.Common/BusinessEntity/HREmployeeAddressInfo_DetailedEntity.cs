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
    [DataContract(Name = "HREmployeeAddressInfo_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeAddressInfo_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _EmployeeAddressInfoID;
        private Int64 _EmployeeAddressTypeID;
        private Int64 _EmployeeID;
        private Int64? _CountryID;
        private Int64? _CityID;
        private String _AddressLine1;
        private String _AddressLine2;
        private String _ZipCode;
        private String _EmployeeFullName;
        private String _EmployeeAddressTypeName;
        private String _CountryName;
        private String _CityName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 EmployeeAddressInfoID
        {
            get { return _EmployeeAddressInfoID; }
            set { _EmployeeAddressInfoID = value; }
        }

        [DataMember]
        public Int64 EmployeeAddressTypeID
        {
            get { return _EmployeeAddressTypeID; }
            set { _EmployeeAddressTypeID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64? CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public Int64? CityID
        {
            get { return _CityID; }
            set { _CityID = value; }
        }

        [DataMember]
        public String AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        [DataMember]
        public String AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; }
        }

        [DataMember]
        public String ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }
        }

        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String EmployeeAddressTypeName
        {
            get { return _EmployeeAddressTypeName; }
            set { _EmployeeAddressTypeName = value; }
        }

        [DataMember]
        public String CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
        }

        [DataMember]
        public String CityName
        {
            get { return _CityName; }
            set { _CityName = value; }
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
                return (EmployeeAddressInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeAddressInfo_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeAddressInfoID = "EmployeeAddressInfoID";
        public const String FLD_NAME_EmployeeAddressTypeID = "EmployeeAddressTypeID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_ZipCode = "ZipCode";
        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_EmployeeAddressTypeName = "EmployeeAddressTypeName";
        public const String FLD_NAME_CountryName = "CountryName";
        public const String FLD_NAME_CityName = "CityName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
