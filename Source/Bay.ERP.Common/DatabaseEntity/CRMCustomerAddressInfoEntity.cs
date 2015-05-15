// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMCustomerAddressInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMCustomerAddressInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _CustomerAddressInfoID;
        private Int64 _CustomerID;
        private Int64 _CustomerAddressTypeID;
        private String _AddressLine1;
        private String _AddressLine2;
        private Int64? _CountryID;
        private Int64? _CityID;
        private String _ZipCode;
        private String _Phone;
        private String _Email;
        private String _WebLink;


        [DataMember]
        public Int64 CustomerAddressInfoID
        {
            get { return _CustomerAddressInfoID; }
            set { _CustomerAddressInfoID = value; }
        }

        [DataMember]
        public Int64 CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        [DataMember]
        public Int64 CustomerAddressTypeID
        {
            get { return _CustomerAddressTypeID; }
            set { _CustomerAddressTypeID = value; }
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
                return (CustomerAddressInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMCustomerAddressInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_CustomerAddressInfoID = "CustomerAddressInfoID";
        public const String FLD_NAME_CustomerID = "CustomerID";
        public const String FLD_NAME_CustomerAddressTypeID = "CustomerAddressTypeID";
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
