// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2012, 04:57:13




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMWorkOrderItemDetail", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMWorkOrderItemDetailEntity : BaseEntity
    {
        #region Properties


        private Int64 _WorkOrderItemDetailID;
        private Int64 _WorkOrderItemMapID;
        private String _Description;
        private Int64? _UnitID;
        private Decimal _Rate;
        private Decimal _Qty;


        [DataMember]
        public Int64 WorkOrderItemDetailID
        {
            get { return _WorkOrderItemDetailID; }
            set { _WorkOrderItemDetailID = value; }
        }

        [DataMember]
        public Int64 WorkOrderItemMapID
        {
            get { return _WorkOrderItemMapID; }
            set { _WorkOrderItemMapID = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Int64? UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
        }

        [DataMember]
        public Decimal Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public Decimal Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
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

        public PRMWorkOrderItemDetailEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_WorkOrderItemDetailID = "WorkOrderItemDetailID";
        public const String FLD_NAME_WorkOrderItemMapID = "WorkOrderItemMapID";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_UnitID = "UnitID";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_Qty = "Qty";

        #endregion
    }
}
