// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-May-2012, 10:19:19




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMBOQDetailHistory_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMBOQDetailHistory_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _BOQDetailHistoryID;
        private Int64 _BOQDetailID;
        private Decimal _Rate;
        private Decimal _TotalQty;
        private DateTime _EntryDate;
        private Int64 _BrandID;
        private Int64 _SupplierID;
        private Int64 _RegionID;
        private Int64 _CountryID;
        private Int64 _ProjectID;
        private String _ParentCategoryName;
        private String _CategoryName;
        private Int64 _ItemID;
        private String _ItemName;
        private Int64 _ItemCategoryID;
        private String _UnitName;
        private String _BrandName;
        private String _RegionName;
        private String _SupplierName;
        private String _CountryName;


        [DataMember]
        public Int64 BOQDetailHistoryID
        {
            get { return _BOQDetailHistoryID; }
            set { _BOQDetailHistoryID = value; }
        }

        [DataMember]
        public Int64 BOQDetailID
        {
            get { return _BOQDetailID; }
            set { _BOQDetailID = value; }
        }

        [DataMember]
        public Decimal Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public Decimal TotalQty
        {
            get { return _TotalQty; }
            set { _TotalQty = value; }
        }

        [DataMember]
        public DateTime EntryDate
        {
            get { return _EntryDate; }
            set { _EntryDate = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public Int64 RegionID
        {
            get { return _RegionID; }
            set { _RegionID = value; }
        }

        [DataMember]
        public Int64 CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String ParentCategoryName
        {
            get { return _ParentCategoryName; }
            set { _ParentCategoryName = value; }
        }

        [DataMember]
        public String CategoryName
        {
            get { return _CategoryName; }
            set { _CategoryName = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public Int64 ItemCategoryID
        {
            get { return _ItemCategoryID; }
            set { _ItemCategoryID = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
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
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
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
                return (BOQDetailHistoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMBOQDetailHistory_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BOQDetailHistoryID = "BOQDetailHistoryID";
        public const String FLD_NAME_BOQDetailID = "BOQDetailID";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_TotalQty = "TotalQty";
        public const String FLD_NAME_EntryDate = "EntryDate";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ParentCategoryName = "ParentCategoryName";
        public const String FLD_NAME_CategoryName = "CategoryName";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_ItemCategoryID = "ItemCategoryID";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_RegionName = "RegionName";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_CountryName = "CountryName";

        #endregion
    }
}
