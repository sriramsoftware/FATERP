// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 02:11:24




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMSupplierBrandMap_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMSupplierBrandMap_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _SupplierBrandMapID;
        private Int64 _SupplierID;
        private Int64 _BrandID;
        private Int64? _OriginRegionID;
        private Int64? _OriginCountryID;
        private String _SupplierName;
        private String _BrandName;
        private String _RegionName;
        private String _CountryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 SupplierBrandMapID
        {
            get { return _SupplierBrandMapID; }
            set { _SupplierBrandMapID = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64? OriginRegionID
        {
            get { return _OriginRegionID; }
            set { _OriginRegionID = value; }
        }

        [DataMember]
        public Int64? OriginCountryID
        {
            get { return _OriginCountryID; }
            set { _OriginCountryID = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }

        [DataMember]
        public String BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        [DataMember]
        public String RegionName
        {
            get { return _RegionName; }
            set { _RegionName = value; }
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
                return (SupplierBrandMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMSupplierBrandMap_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SupplierBrandMapID = "SupplierBrandMapID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_OriginRegionID = "OriginRegionID";
        public const String FLD_NAME_OriginCountryID = "OriginCountryID";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_RegionName = "RegionName";
        public const String FLD_NAME_CountryName = "CountryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
