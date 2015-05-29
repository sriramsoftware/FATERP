// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 08:31:04




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDOperatorAddressInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDOperatorAddressInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _OperatorAddressInfoID;
        private Int64 _OperatorID;
        private String _WebLink;
        private Int64 _OperatorAddressTypeID;
        private String _AddressLine1;
        private String _AddressLine2;
        private Int64? _CountryID;
        private Int64? _CityID;
        private String _ZipCode;
        private String _Phone;
        private String _Email;


        [DataMember]
        public Int64 OperatorAddressInfoID
        {
            get { return _OperatorAddressInfoID; }
            set { _OperatorAddressInfoID = value; }
        }

        [DataMember]
        public Int64 OperatorID
        {
            get { return _OperatorID; }
            set { _OperatorID = value; }
        }

        [DataMember]
        public String WebLink
        {
            get { return _WebLink; }
            set { _WebLink = value; }
        }

        [DataMember]
        public Int64 OperatorAddressTypeID
        {
            get { return _OperatorAddressTypeID; }
            set { _OperatorAddressTypeID = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (OperatorAddressInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDOperatorAddressInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_OperatorAddressInfoID = "OperatorAddressInfoID";
        public const String FLD_NAME_OperatorID = "OperatorID";
        public const String FLD_NAME_WebLink = "WebLink";
        public const String FLD_NAME_OperatorAddressTypeID = "OperatorAddressTypeID";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_ZipCode = "ZipCode";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_Email = "Email";

        #endregion
    }
}
