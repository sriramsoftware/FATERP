// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Aug-2013, 02:50:27




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMWorkOrder_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMWorkOrder_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _WorkOrderID;
        private String _WorkOrderNo;
        private Int64 _PreparedByID;
        private Int64 _SupplierID;
        private Int64 _WorkOrderItemMapID;
        private Int64 _WorkOrderStatusID;
        private Int64 _RequisitionItemID;
        private Int64 _RequisitionID;
        private Decimal _RequiredQty;
        private Decimal _Rate;
        private Int64? _ProjectID;
        private String _SupplierName;
        private String _ProjectName;
        private String _RequisitionNo;
        private Decimal? _RequisitionQty;
        private Decimal? _ReceivedQty;
        private Int64? _MaterialReceiveProjectID;
        private String _OriginBrandName;
        private String _OriginSupplierName;
        private String _OriginRegionName;
        private String _OriginCountryName;
        private Int64? _ItemID;
        private String _ItemName;
        private String _UnitName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 WorkOrderID
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
        public Int64 PreparedByID
        {
            get { return _PreparedByID; }
            set { _PreparedByID = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public Int64 WorkOrderItemMapID
        {
            get { return _WorkOrderItemMapID; }
            set { _WorkOrderItemMapID = value; }
        }

        [DataMember]
        public Int64 WorkOrderStatusID
        {
            get { return _WorkOrderStatusID; }
            set { _WorkOrderStatusID = value; }
        }

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
        public Decimal RequiredQty
        {
            get { return _RequiredQty; }
            set { _RequiredQty = value; }
        }

        [DataMember]
        public Decimal Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public Int64? ProjectID
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

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public Decimal? RequisitionQty
        {
            get { return _RequisitionQty; }
            set { _RequisitionQty = value; }
        }

        [DataMember]
        public Decimal? ReceivedQty
        {
            get { return _ReceivedQty; }
            set { _ReceivedQty = value; }
        }

        [DataMember]
        public Int64? MaterialReceiveProjectID
        {
            get { return _MaterialReceiveProjectID; }
            set { _MaterialReceiveProjectID = value; }
        }

        [DataMember]
        public String OriginBrandName
        {
            get { return _OriginBrandName; }
            set { _OriginBrandName = value; }
        }

        [DataMember]
        public String OriginSupplierName
        {
            get { return _OriginSupplierName; }
            set { _OriginSupplierName = value; }
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
        public Int64? ItemID
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
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
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
                return (WorkOrderID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMWorkOrder_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_PreparedByID = "PreparedByID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_WorkOrderItemMapID = "WorkOrderItemMapID";
        public const String FLD_NAME_WorkOrderStatusID = "WorkOrderStatusID";
        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_RequiredQty = "RequiredQty";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_RequisitionQty = "RequisitionQty";
        public const String FLD_NAME_ReceivedQty = "ReceivedQty";
        public const String FLD_NAME_MaterialReceiveProjectID = "MaterialReceiveProjectID";
        public const String FLD_NAME_OriginBrandName = "OriginBrandName";
        public const String FLD_NAME_OriginSupplierName = "OriginSupplierName";
        public const String FLD_NAME_OriginRegionName = "OriginRegionName";
        public const String FLD_NAME_OriginCountryName = "OriginCountryName";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
