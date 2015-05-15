// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Feb-2013, 03:02:44




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMWorkOrderItemDetail_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMWorkOrderItemDetail_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _WorkOrderItemDetailID;
        private String _Description;
        private Decimal _Rate;
        private String _UnitName;
        private Decimal _Qty;
        private Int64 _WorkOrderID;
        private String _ItemName;


        [DataMember]
        public Int64 WorkOrderItemDetailID
        {
            get { return _WorkOrderItemDetailID; }
            set { _WorkOrderItemDetailID = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Decimal Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        [DataMember]
        public Decimal Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        [DataMember]
        public Int64 WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (WorkOrderItemDetailID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMWorkOrderItemDetail_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_WorkOrderItemDetailID = "WorkOrderItemDetailID";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_Qty = "Qty";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_ItemName = "ItemName";

        #endregion
    }
}
