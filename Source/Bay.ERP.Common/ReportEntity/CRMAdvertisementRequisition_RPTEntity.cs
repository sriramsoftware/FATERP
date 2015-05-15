// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2013, 10:33:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMAdvertisementRequisition_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMAdvertisementRequisition_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _RequisitionID;
        private String _RequisitionNo;
        private DateTime _RequisitionDate;
        private Int64 _RequisitionStatusID;
        private Int64 _PreparedByMemberID;
        private String _InitiatedBy;
        private String _Remarks;
        private Boolean _IsCashPayment;
        private Boolean _IsRCS;
        private String _accountsCode;
        private Int64 _ProjectID;
        private String _ItemCategory;
        private String _ItemName;
        private String _UnitName;
        private Int64? _RequisitionItemID;
        private Int64? _ItemID;
        private Decimal? _TotalRequiredQtyFromBOQorProjectCost;
        private Decimal? _TotalRequiredQty;
        private Decimal? _PurchasedQtyTillToDate;
        private Decimal? _PurchasedQtyTillToDateNew;
        private Decimal? _PresentRequiredQty;
        private Decimal? _Rate;
        private DateTime? _RequiredDate;
        private Int64? _BrandID;
        private Int64? _SupplierID;
        private Int64? _RegionID;
        private Int64? _CountryID;
        private String _RequisitionItemRemarks;
        private String _ProjectCode;
        private String _ProjectName;
        private Int64? _ParentItemCategoryID;
        private String _BrandName;
        private String _OriginRegionName;
        private String _OriginCountryName;
        private String _DiscountPercentage;
        private Decimal _ActualPrice;


        [DataMember]
        public Int64 RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public DateTime RequisitionDate
        {
            get { return _RequisitionDate; }
            set { _RequisitionDate = value; }
        }

        [DataMember]
        public Int64 RequisitionStatusID
        {
            get { return _RequisitionStatusID; }
            set { _RequisitionStatusID = value; }
        }

        [DataMember]
        public Int64 PreparedByMemberID
        {
            get { return _PreparedByMemberID; }
            set { _PreparedByMemberID = value; }
        }

        [DataMember]
        public String InitiatedBy
        {
            get { return _InitiatedBy; }
            set { _InitiatedBy = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Boolean IsCashPayment
        {
            get { return _IsCashPayment; }
            set { _IsCashPayment = value; }
        }

        [DataMember]
        public Boolean IsRCS
        {
            get { return _IsRCS; }
            set { _IsRCS = value; }
        }

        [DataMember]
        public String accountsCode
        {
            get { return _accountsCode; }
            set { _accountsCode = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String ItemCategory
        {
            get { return _ItemCategory; }
            set { _ItemCategory = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        [DataMember]
        public Int64? RequisitionItemID
        {
            get { return _RequisitionItemID; }
            set { _RequisitionItemID = value; }
        }

        [DataMember]
        public Int64? ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Decimal? TotalRequiredQtyFromBOQorProjectCost
        {
            get { return _TotalRequiredQtyFromBOQorProjectCost; }
            set { _TotalRequiredQtyFromBOQorProjectCost = value; }
        }

        [DataMember]
        public Decimal? TotalRequiredQty
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
        public Decimal? PresentRequiredQty
        {
            get { return _PresentRequiredQty; }
            set { _PresentRequiredQty = value; }
        }

        [DataMember]
        public Decimal? Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public DateTime? RequiredDate
        {
            get { return _RequiredDate; }
            set { _RequiredDate = value; }
        }

        [DataMember]
        public Int64? BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64? SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public Int64? RegionID
        {
            get { return _RegionID; }
            set { _RegionID = value; }
        }

        [DataMember]
        public Int64? CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public String RequisitionItemRemarks
        {
            get { return _RequisitionItemRemarks; }
            set { _RequisitionItemRemarks = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public Int64? ParentItemCategoryID
        {
            get { return _ParentItemCategoryID; }
            set { _ParentItemCategoryID = value; }
        }

        [DataMember]
        public String BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        [DataMember]
        public String OriginRegionName
        {
            get { return _OriginRegionName; }
            set { _OriginRegionName = value; }
        }

        [DataMember]
        public String OriginCountryName
        {
            get { return _OriginCountryName; }
            set { _OriginCountryName = value; }
        }

        [DataMember]
        public String DiscountPercentage
        {
            get { return _DiscountPercentage; }
            set { _DiscountPercentage = value; }
        }

        [DataMember]
        public Decimal ActualPrice
        {
            get { return _ActualPrice; }
            set { _ActualPrice = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (RequisitionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMAdvertisementRequisition_RPTEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_RequisitionDate = "RequisitionDate";
        public const String FLD_NAME_RequisitionStatusID = "RequisitionStatusID";
        public const String FLD_NAME_PreparedByMemberID = "PreparedByMemberID";
        public const String FLD_NAME_InitiatedBy = "InitiatedBy";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsCashPayment = "IsCashPayment";
        public const String FLD_NAME_IsRCS = "IsRCS";
        public const String FLD_NAME_accountsCode = "accountsCode";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ItemCategory = "ItemCategory";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_TotalRequiredQtyFromBOQorProjectCost = "TotalRequiredQtyFromBOQorProjectCost";
        public const String FLD_NAME_TotalRequiredQty = "TotalRequiredQty";
        public const String FLD_NAME_PurchasedQtyTillToDate = "PurchasedQtyTillToDate";
        public const String FLD_NAME_PurchasedQtyTillToDateNew = "PurchasedQtyTillToDateNew";
        public const String FLD_NAME_PresentRequiredQty = "PresentRequiredQty";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_RequiredDate = "RequiredDate";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_RequisitionItemRemarks = "RequisitionItemRemarks";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ParentItemCategoryID = "ParentItemCategoryID";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_OriginRegionName = "OriginRegionName";
        public const String FLD_NAME_OriginCountryName = "OriginCountryName";
        public const String FLD_NAME_DiscountPercentage = "DiscountPercentage";
        public const String FLD_NAME_ActualPrice = "ActualPrice";

        #endregion
    }
}
