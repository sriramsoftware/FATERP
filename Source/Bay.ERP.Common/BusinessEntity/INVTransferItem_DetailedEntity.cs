// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jan-2013, 02:54:50




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVTransferItem_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVTransferItem_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _TransferItemID;
        private Int64 _TransferID;
        private Int64 _ItemID;
        private Int64 _BrandID;
        private Int64 _RegionID;
        private Int64 _CountryID;
        private Decimal _RequestQty;
        private String _Remarks;
        private String _INVTransferTRFNo;
        private String _MDItemItemName;
        private String _MDBrandBrandName;
        private String _MDRegionName;
        private String _MDCountryName;
        private String _UnitName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 TransferItemID
        {
            get { return _TransferItemID; }
            set { _TransferItemID = value; }
        }

        [DataMember]
        public Int64 TransferID
        {
            get { return _TransferID; }
            set { _TransferID = value; }
        }

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
        public Decimal RequestQty
        {
            get { return _RequestQty; }
            set { _RequestQty = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String INVTransferTRFNo
        {
            get { return _INVTransferTRFNo; }
            set { _INVTransferTRFNo = value; }
        }

        [DataMember]
        public String MDItemItemName
        {
            get { return _MDItemItemName; }
            set { _MDItemItemName = value; }
        }

        [DataMember]
        public String MDBrandBrandName
        {
            get { return _MDBrandBrandName; }
            set { _MDBrandBrandName = value; }
        }

        [DataMember]
        public String MDRegionName
        {
            get { return _MDRegionName; }
            set { _MDRegionName = value; }
        }

        [DataMember]
        public String MDCountryName
        {
            get { return _MDCountryName; }
            set { _MDCountryName = value; }
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
                return (TransferItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVTransferItem_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TransferItemID = "TransferItemID";
        public const String FLD_NAME_TransferID = "TransferID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_RequestQty = "RequestQty";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_INVTransferTRFNo = "INVTransferTRFNo";
        public const String FLD_NAME_MDItemItemName = "MDItemItemName";
        public const String FLD_NAME_MDBrandBrandName = "MDBrandBrandName";
        public const String FLD_NAME_MDRegionName = "MDRegionName";
        public const String FLD_NAME_MDCountryName = "MDCountryName";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
