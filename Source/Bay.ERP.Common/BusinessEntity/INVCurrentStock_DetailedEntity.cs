// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2012, 12:03:10




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVCurrentStock_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVCurrentStock_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _CurrentStockID;
        private Int64 _ItemID;
        private Int64 _BrandID;
        private Int64 _RegionID;
        private Int64 _CountryID;
        private Int64 _UnitCurrentStock;
        private String _MDItemName;
        private String _MDBrandName;
        private String _MDRegionName;
        private String _MDCountryName;
        private String _UnitName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 CurrentStockID
        {
            get { return _CurrentStockID; }
            set { _CurrentStockID = value; }
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
        public Int64 UnitCurrentStock
        {
            get { return _UnitCurrentStock; }
            set { _UnitCurrentStock = value; }
        }

        [DataMember]
        public String MDItemName
        {
            get { return _MDItemName; }
            set { _MDItemName = value; }
        }

        [DataMember]
        public String MDBrandName
        {
            get { return _MDBrandName; }
            set { _MDBrandName = value; }
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
                return (CurrentStockID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVCurrentStock_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_CurrentStockID = "CurrentStockID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_UnitCurrentStock = "UnitCurrentStock";
        public const String FLD_NAME_MDItemName = "MDItemName";
        public const String FLD_NAME_MDBrandName = "MDBrandName";
        public const String FLD_NAME_MDRegionName = "MDRegionName";
        public const String FLD_NAME_MDCountryName = "MDCountryName";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
