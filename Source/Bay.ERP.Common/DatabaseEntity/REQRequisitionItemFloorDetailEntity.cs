// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Nov-2013, 10:23:55




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "REQRequisitionItemFloorDetail", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class REQRequisitionItemFloorDetailEntity : BaseEntity
    {
        #region Properties


        private Int64 _RequisitionItemFloorDetailID;
        private Int64 _RequisitionID;
        private Int64 _RequisitionItemID;
        private Int64 _ProjectFloorID;
        private Int64? _ProjectFloorUnitID;
        private Int64? _ProjectUnitLocationID;
        private Decimal? _Qty;
        private Decimal? _Rate;
        private String _Remarks;
        private DateTime _EntryDate;


        [DataMember]
        public Int64 RequisitionItemFloorDetailID
        {
            get { return _RequisitionItemFloorDetailID; }
            set { _RequisitionItemFloorDetailID = value; }
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
        public Int64? ProjectUnitLocationID
        {
            get { return _ProjectUnitLocationID; }
            set { _ProjectUnitLocationID = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (RequisitionItemFloorDetailID <= 0);
            }
        }


        #endregion

        #region Constructor

        public REQRequisitionItemFloorDetailEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_RequisitionItemFloorDetailID = "RequisitionItemFloorDetailID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_ProjectUnitLocationID = "ProjectUnitLocationID";
        public const String FLD_NAME_Qty = "Qty";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_EntryDate = "EntryDate";

        #endregion
    }
}
