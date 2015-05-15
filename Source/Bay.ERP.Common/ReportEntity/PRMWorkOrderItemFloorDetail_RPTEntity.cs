// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Aug-2013, 02:00:59




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMWorkOrderItemFloorDetail_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMWorkOrderItemFloorDetail_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _WorkOrderItemFloorDetailID;
        private Int64 _WorkOrderItemMapID;
        private Int64 _RequisitionID;
        private Int64 _RequisitionItemID;
        private Int64 _ProjectFloorID;
        private Int64? _ProjectFloorUnitID;
        private Decimal? _Qty;
        private Decimal? _Rate;
        private String _Remarks;
        private DateTime _EntryDate;
        private String _RequisitionNo;
        private String _ProjectCode;
        private String _ProjectName;
        private String _BDProjectFloorName;
        private String _ProjectFloorUnitName;
        private String _ItemName;
        private Int64? _ItemID;
        private Int64? _WorkOrderID;
        private String _WorkOrderNo;


        [DataMember]
        public Int64 WorkOrderItemFloorDetailID
        {
            get { return _WorkOrderItemFloorDetailID; }
            set { _WorkOrderItemFloorDetailID = value; }
        }

        [DataMember]
        public Int64 WorkOrderItemMapID
        {
            get { return _WorkOrderItemMapID; }
            set { _WorkOrderItemMapID = value; }
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
        public Int64 ProjectFloorID
        {
            get { return _ProjectFloorID; }
            set { _ProjectFloorID = value; }
        }

        [DataMember]
        public Int64? ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public Decimal? Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        [DataMember]
        public Decimal? Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime EntryDate
        {
            get { return _EntryDate; }
            set { _EntryDate = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
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
        public String BDProjectFloorName
        {
            get { return _BDProjectFloorName; }
            set { _BDProjectFloorName = value; }
        }

        [DataMember]
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public Int64? ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (WorkOrderItemFloorDetailID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMWorkOrderItemFloorDetail_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_WorkOrderItemFloorDetailID = "WorkOrderItemFloorDetailID";
        public const String FLD_NAME_WorkOrderItemMapID = "WorkOrderItemMapID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_Qty = "Qty";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_EntryDate = "EntryDate";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_BDProjectFloorName = "BDProjectFloorName";
        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";

        #endregion
    }
}
