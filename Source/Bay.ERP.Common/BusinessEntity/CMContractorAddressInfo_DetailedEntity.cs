// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 06:01:25




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMContractorAddressInfo_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMContractorAddressInfo_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ContractorAddressInfoID;
        private Int64 _ContractorID;
        private Int64 _AddressTypeID;
        private Int64? _CountryID;
        private Int64? _CityID;
        private String _AddressLine1;
        private String _AddressLine2;
        private String _Fax;
        private String _ZipCode;
        private String _Phone;
        private String _ContractorName;
        private String _AddressTypeName;
        private String _CountryName;
        private String _CityName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ContractorAddressInfoID
        {
            get { return _ContractorAddressInfoID; }
            set { _ContractorAddressInfoID = value; }
        }

        [DataMember]
        public Int64 ContractorID
        {
            get { return _ContractorID; }
            set { _ContractorID = value; }
        }

        [DataMember]
        public Int64 AddressTypeID
        {
            get { return _AddressTypeID; }
            set { _AddressTypeID = value; }
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
        public String Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }

        [DataMember]
        public String ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }
        }

        [DataMember]
        public String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        [DataMember]
        public String ContractorName
        {
            get { return _ContractorName; }
            set { _ContractorName = value; }
        }

        [DataMember]
        public String AddressTypeName
        {
            get { return _AddressTypeName; }
            set { _AddressTypeName = value; }
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
                return (ContractorAddressInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMContractorAddressInfo_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ContractorAddressInfoID = "ContractorAddressInfoID";
        public const String FLD_NAME_ContractorID = "ContractorID";
        public const String FLD_NAME_AddressTypeID = "AddressTypeID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_Fax = "Fax";
        public const String FLD_NAME_ZipCode = "ZipCode";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_ContractorName = "ContractorName";
        public const String FLD_NAME_AddressTypeName = "AddressTypeName";
        public const String FLD_NAME_CountryName = "CountryName";
        public const String FLD_NAME_CityName = "CityName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
