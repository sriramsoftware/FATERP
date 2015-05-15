// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Nov-2012, 01:32:58




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMWorkOrderItemMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMWorkOrderItemMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _WorkOrderItemMapID;
        private Int64 _WorkOrderID;
        private Int64 _RequisitionID;
        private Int64 _RequisitionItemID;
        private Decimal _RequiredQty;
        private Decimal _Rate;
        private String _DeliveryAddress;
        private String _Description;
        private Int64 _WorkOrderStatusID;


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
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Int64 WorkOrderStatusID
        {
            get { return _WorkOrderStatusID; }
            set { _WorkOrderStatusID = value; }
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

        public PRMWorkOrderItemMapEntity() : base()
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
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_WorkOrderStatusID = "WorkOrderStatusID";

        #endregion
    }
}
