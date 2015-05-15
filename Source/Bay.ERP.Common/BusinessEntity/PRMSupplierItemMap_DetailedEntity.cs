// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Apr-2012, 11:14:21




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMSupplierItemMap_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMSupplierItemMap_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _SupplierItemMapID;
        private Int64 _SupplierID;
        private Int64 _BrandID;
        private Int64 _ItemID;
        private Int64? _OriginRegionID;
        private Int64? _OriginCountryID;
        private Decimal _ActualPrice;
        private Decimal _DiscountPercentage;
        private Decimal _Price;
        private String _Model;
        private Int64? _WarrantyPeriod;
        private DateTime _EntryDate;
        private Boolean _IsRemoved;
        private String _SupplierName;
        private String _BrandName;
        private String _ItemName;
        private String _RegionName;
        private String _CountryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 SupplierItemMapID
        {
            get { return _SupplierItemMapID; }
            set { _SupplierItemMapID = value; }
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
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
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
        public String Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        [DataMember]
        public Int64? WarrantyPeriod
        {
            get { return _WarrantyPeriod; }
            set { _WarrantyPeriod = value; }
        }

        [DataMember]
        public DateTime EntryDate
        {
            get { return _EntryDate; }
            set { _EntryDate = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
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
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
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
                return (SupplierItemMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMSupplierItemMap_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SupplierItemMapID = "SupplierItemMapID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_OriginRegionID = "OriginRegionID";
        public const String FLD_NAME_OriginCountryID = "OriginCountryID";
        public const String FLD_NAME_ActualPrice = "ActualPrice";
        public const String FLD_NAME_DiscountPercentage = "DiscountPercentage";
        public const String FLD_NAME_Price = "Price";
        public const String FLD_NAME_Model = "Model";
        public const String FLD_NAME_WarrantyPeriod = "WarrantyPeriod";
        public const String FLD_NAME_EntryDate = "EntryDate";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_RegionName = "RegionName";
        public const String FLD_NAME_CountryName = "CountryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
