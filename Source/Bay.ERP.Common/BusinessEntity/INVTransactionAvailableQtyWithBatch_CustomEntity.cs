// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2013, 12:40:48




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVTransactionAvailableQtyWithBatch_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVTransactionAvailableQtyWithBatch_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _ItemID;
        private Int64 _BrandID;
        private Int64 _RegionID;
        private Int64 _CountryID;
        private String _BatchNumber;
        private Int64? _TotalINQty;
        private Decimal _UnitPrice;
        private Int64? _TotalOUTQty;
        private Int64? _AvailableQty;
        private Int64? _StoreID;
        private Int64? _StoreUnitID;


        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64 RegionID
        {
            get { return _RegionID; }
            set { _RegionID = value; }
        }

        [DataMember]
        public Int64 CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public String BatchNumber
        {
            get { return _BatchNumber; }
            set { _BatchNumber = value; }
        }

        [DataMember]
        public Int64? TotalINQty
        {
            get { return _TotalINQty; }
            set { _TotalINQty = value; }
        }

        [DataMember]
        public Decimal UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }

        [DataMember]
        public Int64? TotalOUTQty
        {
            get { return _TotalOUTQty; }
            set { _TotalOUTQty = value; }
        }

        [DataMember]
        public Int64? AvailableQty
        {
            get { return _AvailableQty; }
            set { _AvailableQty = value; }
        }

        [DataMember]
        public Int64? StoreID
        {
            get { return _StoreID; }
            set { _StoreID = value; }
        }

        [DataMember]
        public Int64? StoreUnitID
        {
            get { return _StoreUnitID; }
            set { _StoreUnitID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVTransactionAvailableQtyWithBatch_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_BatchNumber = "BatchNumber";
        public const String FLD_NAME_TotalINQty = "TotalINQty";
        public const String FLD_NAME_UnitPrice = "UnitPrice";
        public const String FLD_NAME_TotalOUTQty = "TotalOUTQty";
        public const String FLD_NAME_AvailableQty = "AvailableQty";
        public const String FLD_NAME_StoreID = "StoreID";
        public const String FLD_NAME_StoreUnitID = "StoreUnitID";

        #endregion
    }
}
