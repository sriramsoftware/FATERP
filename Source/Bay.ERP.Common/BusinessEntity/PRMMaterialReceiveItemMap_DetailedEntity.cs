// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Aug-2013, 05:41:48




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMMaterialReceiveItemMap_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMMaterialReceiveItemMap_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _MaterialReceiveItemMapID;
        private Int64 _MaterialReceiveID;
        private Int64 _RequisitionItemID;
        private DateTime _ReceiveDate;
        private Decimal _ReceiveQty;
        private Decimal _ItemRate;
        private String _ChallanNo;
        private Decimal _WOItemTotalRate;
        private String _MRRNo;
        private Int64? _ProjectID;
        private String _ItemName;
        private String _BrandName;
        private String _SupplierName;
        private String _OriginCountry;
        private String _OriginRegion;
        private String _UnitName;
        private Int64? _WorkOrderID;
        private Int64? _ItemID;
        private Int64? _RequisitionID;
        private Int64 _WorkOrderItemMapID;


        [DataMember]
        public Int64 MaterialReceiveItemMapID
        {
            get { return _MaterialReceiveItemMapID; }
            set { _MaterialReceiveItemMapID = value; }
        }

        [DataMember]
        public Int64 MaterialReceiveID
        {
            get { return _MaterialReceiveID; }
            set { _MaterialReceiveID = value; }
        }

        [DataMember]
        public Int64 RequisitionItemID
        {
            get { return _RequisitionItemID; }
            set { _RequisitionItemID = value; }
        }

        [DataMember]
        public DateTime ReceiveDate
        {
            get { return _ReceiveDate; }
            set { _ReceiveDate = value; }
        }

        [DataMember]
        public Decimal ReceiveQty
        {
            get { return _ReceiveQty; }
            set { _ReceiveQty = value; }
        }

        [DataMember]
        public Decimal ItemRate
        {
            get { return _ItemRate; }
            set { _ItemRate = value; }
        }

        [DataMember]
        public String ChallanNo
        {
            get { return _ChallanNo; }
            set { _ChallanNo = value; }
        }

        [DataMember]
        public Decimal WOItemTotalRate
        {
            get { return _WOItemTotalRate; }
            set { _WOItemTotalRate = value; }
        }

        [DataMember]
        public String MRRNo
        {
            get { return _MRRNo; }
            set { _MRRNo = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public String BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }

        [DataMember]
        public String OriginCountry
        {
            get { return _OriginCountry; }
            set { _OriginCountry = value; }
        }

        [DataMember]
        public String OriginRegion
        {
            get { return _OriginRegion; }
            set { _OriginRegion = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        [DataMember]
        public Int64? WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public Int64? ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Int64? RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
        }

        [DataMember]
        public Int64 WorkOrderItemMapID
        {
            get { return _WorkOrderItemMapID; }
            set { _WorkOrderItemMapID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (MaterialReceiveItemMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMMaterialReceiveItemMap_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MaterialReceiveItemMapID = "MaterialReceiveItemMapID";
        public const String FLD_NAME_MaterialReceiveID = "MaterialReceiveID";
        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_ReceiveDate = "ReceiveDate";
        public const String FLD_NAME_ReceiveQty = "ReceiveQty";
        public const String FLD_NAME_ItemRate = "ItemRate";
        public const String FLD_NAME_ChallanNo = "ChallanNo";
        public const String FLD_NAME_WOItemTotalRate = "WOItemTotalRate";
        public const String FLD_NAME_MRRNo = "MRRNo";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_OriginCountry = "OriginCountry";
        public const String FLD_NAME_OriginRegion = "OriginRegion";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_WorkOrderItemMapID = "WorkOrderItemMapID";

        #endregion
    }
}
