// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Feb-2013, 06:05:18




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMMaterialRequisitionItem_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMMaterialRequisitionItem_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _RequisitionID;
        private String _RequisitionNo;
        private String _ItemName;
        private String _OriginBrandName;
        private Int64 _SupplierID;
        private Int64 _BrandID;
        private Int64 _RequisitionItemID;
        private Decimal _RequiredQty;
        private Int64 _CountryID;
        private Int64 _RegionID;
        private String _OriginRegionName;
        private String _OriginCountryName;
        private Int64? _WorkOrderID;
        private String _WorkOrderNo;
        private Int64? _PreparedByID;
        private Int64? _WorkOrderItemMapID;
        private Int64? _WorkOrderStatusID;
        private Decimal? _Rate;
        private String _ProjectName;
        private Int64 _ProjectID;
        private String _SupplierName;


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
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public String OriginBrandName
        {
            get { return _OriginBrandName; }
            set { _OriginBrandName = value; }
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
        public Int64 RequisitionItemID
        {
            get { return _RequisitionItemID; }
            set { _RequisitionItemID = value; }
        }

        [DataMember]
        public Decimal RequiredQty
        {
            get { return _RequiredQty; }
            set { _RequiredQty = value; }
        }

        [DataMember]
        public Int64 CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public Int64 RegionID
        {
            get { return _RegionID; }
            set { _RegionID = value; }
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
        public Int64? WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public Int64? PreparedByID
        {
            get { return _PreparedByID; }
            set { _PreparedByID = value; }
        }

        [DataMember]
        public Int64? WorkOrderItemMapID
        {
            get { return _WorkOrderItemMapID; }
            set { _WorkOrderItemMapID = value; }
        }

        [DataMember]
        public Int64? WorkOrderStatusID
        {
            get { return _WorkOrderStatusID; }
            set { _WorkOrderStatusID = value; }
        }

        [DataMember]
        public Decimal? Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
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

        public PRMMaterialRequisitionItem_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_OriginBrandName = "OriginBrandName";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_RequiredQty = "RequiredQty";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_OriginRegionName = "OriginRegionName";
        public const String FLD_NAME_OriginCountryName = "OriginCountryName";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_PreparedByID = "PreparedByID";
        public const String FLD_NAME_WorkOrderItemMapID = "WorkOrderItemMapID";
        public const String FLD_NAME_WorkOrderStatusID = "WorkOrderStatusID";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_SupplierName = "SupplierName";

        #endregion
    }
}
