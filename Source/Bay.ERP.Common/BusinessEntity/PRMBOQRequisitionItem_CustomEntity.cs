// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Oct-2012, 01:09:23




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMBOQRequisitionItem_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMBOQRequisitionItem_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _BOQDetailID;
        private Int64 _BOQID;
        private Int64 _ItemID;
        private Decimal _Rate;
        private Decimal _TotalQty;
        private String _Remarks;
        private Boolean _IsRemoved;
        private Int64? _PreBOQID;
        private Int64? _PRMPreBOQProjectID;
        private String _MDItemItemName;
        private Int64? _ItemCategoryID;
        private String _UnitName;
        private Int64? _BrandID;
        private String _BrandName;
        private Int64? _SupplierID;
        private String _SupplierName;
        private Int64? _RegionID;
        private String _RegionName;
        private Int64? _CountryID;
        private String _CountryName;
        private String _CategoryName;
        private Int64? _ParentItemCategoryID;
        private String _ParentCategoryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 BOQDetailID
        {
            get { return _BOQDetailID; }
            set { _BOQDetailID = value; }
        }

        [DataMember]
        public Int64 BOQID
        {
            get { return _BOQID; }
            set { _BOQID = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
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
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public Int64? PreBOQID
        {
            get { return _PreBOQID; }
            set { _PreBOQID = value; }
        }

        [DataMember]
        public Int64? PRMPreBOQProjectID
        {
            get { return _PRMPreBOQProjectID; }
            set { _PRMPreBOQProjectID = value; }
        }

        [DataMember]
        public String MDItemItemName
        {
            get { return _MDItemItemName; }
            set { _MDItemItemName = value; }
        }

        [DataMember]
        public Int64? ItemCategoryID
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
        public Int64? BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public String BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        [DataMember]
        public Int64? SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }

        [DataMember]
        public Int64? RegionID
        {
            get { return _RegionID; }
            set { _RegionID = value; }
        }

        [DataMember]
        public String RegionName
        {
            get { return _RegionName; }
            set { _RegionName = value; }
        }

        [DataMember]
        public Int64? CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public String CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
        }

        [DataMember]
        public String CategoryName
        {
            get { return _CategoryName; }
            set { _CategoryName = value; }
        }

        [DataMember]
        public Int64? ParentItemCategoryID
        {
            get { return _ParentItemCategoryID; }
            set { _ParentItemCategoryID = value; }
        }

        [DataMember]
        public String ParentCategoryName
        {
            get { return _ParentCategoryName; }
            set { _ParentCategoryName = value; }
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
                return (BOQDetailID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMBOQRequisitionItem_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BOQDetailID = "BOQDetailID";
        public const String FLD_NAME_BOQID = "BOQID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_TotalQty = "TotalQty";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_PreBOQID = "PreBOQID";
        public const String FLD_NAME_PRMPreBOQProjectID = "PRMPreBOQProjectID";
        public const String FLD_NAME_MDItemItemName = "MDItemItemName";
        public const String FLD_NAME_ItemCategoryID = "ItemCategoryID";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_RegionName = "RegionName";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_CountryName = "CountryName";
        public const String FLD_NAME_CategoryName = "CategoryName";
        public const String FLD_NAME_ParentItemCategoryID = "ParentItemCategoryID";
        public const String FLD_NAME_ParentCategoryName = "ParentCategoryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
