// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACItemAccountMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACItemAccountMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _ItemAccountMapID;
        private Int64 _ItemID;
        private Int64? _DimensionID;
        private Int64? _SalesAccountID;
        private Int64? _InventoryAccountID;
        private Int64? _COGSAccountID;
        private Int64? _InventoryAdjustmentsAccountID;
        private String _AssetType;
        private DateTime? _PurchaseDate;
        private Decimal? _PurchasePrice;
        private Decimal? _DepreciationRate;
        private Int64? _DepreciationMethodID;
        private Int64? _DepreciationAccountID;


        [DataMember]
        public Int64 ItemAccountMapID
        {
            get { return _ItemAccountMapID; }
            set { _ItemAccountMapID = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Int64? DimensionID
        {
            get { return _DimensionID; }
            set { _DimensionID = value; }
        }

        [DataMember]
        public Int64? SalesAccountID
        {
            get { return _SalesAccountID; }
            set { _SalesAccountID = value; }
        }

        [DataMember]
        public Int64? InventoryAccountID
        {
            get { return _InventoryAccountID; }
            set { _InventoryAccountID = value; }
        }

        [DataMember]
        public Int64? COGSAccountID
        {
            get { return _COGSAccountID; }
            set { _COGSAccountID = value; }
        }

        [DataMember]
        public Int64? InventoryAdjustmentsAccountID
        {
            get { return _InventoryAdjustmentsAccountID; }
            set { _InventoryAdjustmentsAccountID = value; }
        }

        [DataMember]
        public String AssetType
        {
            get { return _AssetType; }
            set { _AssetType = value; }
        }

        [DataMember]
        public DateTime? PurchaseDate
        {
            get { return _PurchaseDate; }
            set { _PurchaseDate = value; }
        }

        [DataMember]
        public Decimal? PurchasePrice
        {
            get { return _PurchasePrice; }
            set { _PurchasePrice = value; }
        }

        [DataMember]
        public Decimal? DepreciationRate
        {
            get { return _DepreciationRate; }
            set { _DepreciationRate = value; }
        }

        [DataMember]
        public Int64? DepreciationMethodID
        {
            get { return _DepreciationMethodID; }
            set { _DepreciationMethodID = value; }
        }

        [DataMember]
        public Int64? DepreciationAccountID
        {
            get { return _DepreciationAccountID; }
            set { _DepreciationAccountID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ItemAccountMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACItemAccountMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ItemAccountMapID = "ItemAccountMapID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_DimensionID = "DimensionID";
        public const String FLD_NAME_SalesAccountID = "SalesAccountID";
        public const String FLD_NAME_InventoryAccountID = "InventoryAccountID";
        public const String FLD_NAME_COGSAccountID = "COGSAccountID";
        public const String FLD_NAME_InventoryAdjustmentsAccountID = "InventoryAdjustmentsAccountID";
        public const String FLD_NAME_AssetType = "AssetType";
        public const String FLD_NAME_PurchaseDate = "PurchaseDate";
        public const String FLD_NAME_PurchasePrice = "PurchasePrice";
        public const String FLD_NAME_DepreciationRate = "DepreciationRate";
        public const String FLD_NAME_DepreciationMethodID = "DepreciationMethodID";
        public const String FLD_NAME_DepreciationAccountID = "DepreciationAccountID";

        #endregion
    }
}
