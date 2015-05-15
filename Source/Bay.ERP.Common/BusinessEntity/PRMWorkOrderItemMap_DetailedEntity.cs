// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Sep-2013, 02:13:02




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMWorkOrderItemMap_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMWorkOrderItemMap_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _WorkOrderItemMapID;
        private Int64 _WorkOrderID;
        private Int64 _RequisitionID;
        private Int64 _RequisitionItemID;
        private Decimal _RequiredQty;
        private Decimal _Rate;
        private String _DeliveryAddress;
        private Int64 _WorkOrderStatusID;
        private String _WorkOrderNo;
        private String _RequisitionNo;
        private Int64? _ProjectID;
        private Int64? _ItemID;
        private String _ItemName;
        private String _UnitName;
        private String _MDWorkOrderStatusName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 WorkOrderItemMapID
        {
            get { return _WorkOrderItemMapID; }
            set { _WorkOrderItemMapID = value; }
        }

        [DataMember]
        public Int64 WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public Int64 RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
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
        public Decimal Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public String DeliveryAddress
        {
            get { return _DeliveryAddress; }
            set { _DeliveryAddress = value; }
        }

        [DataMember]
        public Int64 WorkOrderStatusID
        {
            get { return _WorkOrderStatusID; }
            set { _WorkOrderStatusID = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
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
        public String MDWorkOrderStatusName
        {
            get { return _MDWorkOrderStatusName; }
            set { _MDWorkOrderStatusName = value; }
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
                return (WorkOrderItemMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMWorkOrderItemMap_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_WorkOrderItemMapID = "WorkOrderItemMapID";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_RequiredQty = "RequiredQty";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_DeliveryAddress = "DeliveryAddress";
        public const String FLD_NAME_WorkOrderStatusID = "WorkOrderStatusID";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_MDWorkOrderStatusName = "MDWorkOrderStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
