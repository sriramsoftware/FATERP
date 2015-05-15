// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Apr-2012, 10:30:24




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMSupplierItemMapHistory_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMSupplierItemMapHistory_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _SupplierItemMapHistoryID;
        private Int64 _SupplierItemMapID;
        private Decimal _ActualPrice;
        private Decimal _DiscountPercentage;
        private Decimal _Price;
        private DateTime _EntryDate;
        private Int64 _ItemID;
        private Int64 _SupplierID;
        private Int64? _OriginRegionID;
        private Int64? _OriginCountryID;
        private Int64? _WarrantyPeriod;
        private Int64 _BrandID;
        private String _ItemName;
        private String _SupplierName;
        private String _Phone;
        private String _Relationship;
        private String _BrandName;
        private String _RegionName;
        private String _CountryName;


        [DataMember]
        public Int64 SupplierItemMapHistoryID
        {
            get { return _SupplierItemMapHistoryID; }
            set { _SupplierItemMapHistoryID = value; }
        }

        [DataMember]
        public Int64 SupplierItemMapID
        {
            get { return _SupplierItemMapID; }
            set { _SupplierItemMapID = value; }
        }

        [DataMember]
        public Decimal ActualPrice
        {
            get { return _ActualPrice; }
            set { _ActualPrice = value; }
        }

        [DataMember]
        public Decimal DiscountPercentage
        {
            get { return _DiscountPercentage; }
            set { _DiscountPercentage = value; }
        }

        [DataMember]
        public Decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        [DataMember]
        public DateTime EntryDate
        {
            get { return _EntryDate; }
            set { _EntryDate = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
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
        public Int64? WarrantyPeriod
        {
            get { return _WarrantyPeriod; }
            set { _WarrantyPeriod = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }

        [DataMember]
        public String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        [DataMember]
        public String Relationship
        {
            get { return _Relationship; }
            set { _Relationship = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SupplierItemMapHistoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMSupplierItemMapHistory_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SupplierItemMapHistoryID = "SupplierItemMapHistoryID";
        public const String FLD_NAME_SupplierItemMapID = "SupplierItemMapID";
        public const String FLD_NAME_ActualPrice = "ActualPrice";
        public const String FLD_NAME_DiscountPercentage = "DiscountPercentage";
        public const String FLD_NAME_Price = "Price";
        public const String FLD_NAME_EntryDate = "EntryDate";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_OriginRegionID = "OriginRegionID";
        public const String FLD_NAME_OriginCountryID = "OriginCountryID";
        public const String FLD_NAME_WarrantyPeriod = "WarrantyPeriod";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_Relationship = "Relationship";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_RegionName = "RegionName";
        public const String FLD_NAME_CountryName = "CountryName";

        #endregion
    }
}
