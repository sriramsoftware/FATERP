// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMConsultantAddressInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMConsultantAddressInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _ConsultantAddressInfoID;
        private Int64 _ConsultantID;
        private Int64 _AddressTypeID;
        private String _Phone;
        private Int64? _CountryID;
        private Int64? _CityID;
        private String _AddressLine1;
        private String _AddressLine2;
        private String _Fax;
        private String _ZipCode;


        [DataMember]
        public Int64 ConsultantAddressInfoID
        {
            get { return _ConsultantAddressInfoID; }
            set { _ConsultantAddressInfoID = value; }
        }

        [DataMember]
        public Int64 ConsultantID
        {
            get { return _ConsultantID; }
            set { _ConsultantID = value; }
        }

        [DataMember]
        public Int64 AddressTypeID
        {
            get { return _AddressTypeID; }
            set { _AddressTypeID = value; }
        }

        [DataMember]
        public String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ConsultantAddressInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMConsultantAddressInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ConsultantAddressInfoID = "ConsultantAddressInfoID";
        public const String FLD_NAME_ConsultantID = "ConsultantID";
        public const String FLD_NAME_AddressTypeID = "AddressTypeID";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_Fax = "Fax";
        public const String FLD_NAME_ZipCode = "ZipCode";

        #endregion
    }
}