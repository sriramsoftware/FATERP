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
    [DataContract(Name = "INVStoreUnitItem_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVStoreUnitItem_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _StoreUnitItemID;
        private Int64 _StoreUnitID;
        private Int64 _ItemID;
        private Int64 _BrandID;
        private Int64 _RegionID;
        private Int64 _CountryID;
        private Int64 _UnitCurrentStock;
        private Int64? _INVStoreUnitStoreID;
        private String _UnitTrackNumber;
        private Boolean _IsDefault;
        private String _StoreUnitLocation;
        private String _StoreName;
        private String _StoreTrackNumber;
        private Int64? _ProjectID;
        private String _INVStoreLocation;
        private String _ProjectName;
        private String _DepartmentName;
        private String _MemberFullName;
        private String _MDItemItemName;
        private String _MDBrandBrandName;
        private String _MDRegionName;
        private String _MDCountryName;
        private String _UnitName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 StoreUnitItemID
        {
            get { return _StoreUnitItemID; }
            set { _StoreUnitItemID = value; }
        }

        [DataMember]
        public Int64 StoreUnitID
        {
            get { return _StoreUnitID; }
            set { _StoreUnitID = value; }
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
        public Int64? INVStoreUnitStoreID
        {
            get { return _INVStoreUnitStoreID; }
            set { _INVStoreUnitStoreID = value; }
        }

        [DataMember]
        public String UnitTrackNumber
        {
            get { return _UnitTrackNumber; }
            set { _UnitTrackNumber = value; }
        }

        [DataMember]
        public Boolean IsDefault
        {
            get { return _IsDefault; }
            set { _IsDefault = value; }
        }

        [DataMember]
        public String StoreUnitLocation
        {
            get { return _StoreUnitLocation; }
            set { _StoreUnitLocation = value; }
        }

        [DataMember]
        public String StoreName
        {
            get { return _StoreName; }
            set { _StoreName = value; }
        }

        [DataMember]
        public String StoreTrackNumber
        {
            get { return _StoreTrackNumber; }
            set { _StoreTrackNumber = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String INVStoreLocation
        {
            get { return _INVStoreLocation; }
            set { _INVStoreLocation = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
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
                return (StoreUnitItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVStoreUnitItem_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_StoreUnitItemID = "StoreUnitItemID";
        public const String FLD_NAME_StoreUnitID = "StoreUnitID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_UnitCurrentStock = "UnitCurrentStock";
        public const String FLD_NAME_INVStoreUnitStoreID = "INVStoreUnitStoreID";
        public const String FLD_NAME_UnitTrackNumber = "UnitTrackNumber";
        public const String FLD_NAME_IsDefault = "IsDefault";
        public const String FLD_NAME_StoreUnitLocation = "StoreUnitLocation";
        public const String FLD_NAME_StoreName = "StoreName";
        public const String FLD_NAME_StoreTrackNumber = "StoreTrackNumber";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_INVStoreLocation = "INVStoreLocation";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_DepartmentName = "DepartmentName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_MDItemItemName = "MDItemItemName";
        public const String FLD_NAME_MDBrandBrandName = "MDBrandBrandName";
        public const String FLD_NAME_MDRegionName = "MDRegionName";
        public const String FLD_NAME_MDCountryName = "MDCountryName";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
