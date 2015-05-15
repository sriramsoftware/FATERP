// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 11:49:03




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMBillRequisitionItemMap_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMBillRequisitionItemMap_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _BillRequisitionItemMapID;
        private Int64 _BillID;
        private Int64 _RequisitionID;
        private Int64 _RequisitionItemID;
        private Decimal _RequisitionPrice;
        private Decimal? _BillPrice;
        private String _BillNo;
        private String _RequisitionNo;
        private String _ItemName;


        [DataMember]
        public Int64 BillRequisitionItemMapID
        {
            get { return _BillRequisitionItemMapID; }
            set { _BillRequisitionItemMapID = value; }
        }

        [DataMember]
        public Int64 BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
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
        public Decimal RequisitionPrice
        {
            get { return _RequisitionPrice; }
            set { _RequisitionPrice = value; }
        }

        [DataMember]
        public Decimal? BillPrice
        {
            get { return _BillPrice; }
            set { _BillPrice = value; }
        }

        [DataMember]
        public String BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
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

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BillRequisitionItemMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMBillRequisitionItemMap_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BillRequisitionItemMapID = "BillRequisitionItemMapID";
        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_RequisitionPrice = "RequisitionPrice";
        public const String FLD_NAME_BillPrice = "BillPrice";
        public const String FLD_NAME_BillNo = "BillNo";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_ItemName = "ItemName";

        #endregion
    }
}
