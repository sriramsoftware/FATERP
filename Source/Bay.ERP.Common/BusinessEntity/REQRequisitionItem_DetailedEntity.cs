// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jul-2013, 02:38:57




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "REQRequisitionItem_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class REQRequisitionItem_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _RequisitionItemID;
        private Int64 _RequisitionID;
        private String _AccountsCode;
        private Int64 _ItemID;
        private Decimal _Rate;
        private Decimal _TotalRequiredQty;
        private Decimal? _PurchasedQtyTillToDate;
        private Decimal? _PurchasedQtyTillToDateNew;
        private Decimal? _AvailableQtyForReqisition;
        private Decimal _PresentRequiredQty;
        private DateTime _RequiredDate;
        private String _Remarks;
        private Int64? _REQRequisitionProjectID;
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
        public Int64 RequisitionItemID
        {
            get { return _RequisitionItemID; }
            set { _RequisitionItemID = value; }
        }

        [DataMember]
        public Int64 RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
        }

        [DataMember]
        public String AccountsCode
        {
            get { return _AccountsCode; }
            set { _AccountsCode = value; }
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
        public Decimal TotalRequiredQty
        {
            get { return _TotalRequiredQty; }
            set { _TotalRequiredQty = value; }
        }

        [DataMember]
        public Decimal? PurchasedQtyTillToDate
        {
            get { return _PurchasedQtyTillToDate; }
            set { _PurchasedQtyTillToDate = value; }
        }

        [DataMember]
        public Decimal? PurchasedQtyTillToDateNew
        {
            get { return _PurchasedQtyTillToDateNew; }
            set { _PurchasedQtyTillToDateNew = value; }
        }

        [DataMember]
        public Decimal? AvailableQtyForReqisition
        {
            get { return _AvailableQtyForReqisition; }
            set { _AvailableQtyForReqisition = value; }
        }

        [DataMember]
        public Decimal PresentRequiredQty
        {
            get { return _PresentRequiredQty; }
            set { _PresentRequiredQty = value; }
        }

        [DataMember]
        public DateTime RequiredDate
        {
            get { return _RequiredDate; }
            set { _RequiredDate = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64? REQRequisitionProjectID
        {
            get { return _REQRequisitionProjectID; }
            set { _REQRequisitionProjectID = value; }
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
                return (RequisitionItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public REQRequisitionItem_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_AccountsCode = "AccountsCode";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_TotalRequiredQty = "TotalRequiredQty";
        public const String FLD_NAME_PurchasedQtyTillToDate = "PurchasedQtyTillToDate";
        public const String FLD_NAME_PurchasedQtyTillToDateNew = "PurchasedQtyTillToDateNew";
        public const String FLD_NAME_AvailableQtyForReqisition = "AvailableQtyForReqisition";
        public const String FLD_NAME_PresentRequiredQty = "PresentRequiredQty";
        public const String FLD_NAME_RequiredDate = "RequiredDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_REQRequisitionProjectID = "REQRequisitionProjectID";
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
