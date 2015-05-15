// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMSupplierAddressInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMSupplierAddressInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _SupplierAddressInfoID;
        private Int64 _SupplierID;
        private Int64 _SupplierAddressTypeID;
        private String _AddressLine1;
        private String _AddressLine2;
        private Int64? _CountryID;
        private Int64? _CityID;
        private String _ZipCode;
        private String _Phone;
        private String _Email;
        private String _WebLink;


        [DataMember]
        public Int64 SupplierAddressInfoID
        {
            get { return _SupplierAddressInfoID; }
            set { _SupplierAddressInfoID = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public Int64 SupplierAddressTypeID
        {
            get { return _SupplierAddressTypeID; }
            set { _SupplierAddressTypeID = value; }
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
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [DataMember]
        public String WebLink
        {
            get { return _WebLink; }
            set { _WebLink = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SupplierAddressInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMSupplierAddressInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SupplierAddressInfoID = "SupplierAddressInfoID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_SupplierAddressTypeID = "SupplierAddressTypeID";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_ZipCode = "ZipCode";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_WebLink = "WebLink";

        #endregion
    }
}
