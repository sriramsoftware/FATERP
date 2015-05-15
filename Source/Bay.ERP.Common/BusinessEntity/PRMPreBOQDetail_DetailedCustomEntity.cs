// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2012, 04:17:30




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMPreBOQDetail_DetailedCustom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMPreBOQDetail_DetailedCustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _PreBOQDetailID;
        private Int64 _PreBOQID;
        private Int64 _ItemID;
        private Decimal _Rate;
        private Decimal _TotalQty;
        private String _Remarks;
        private Boolean _IsRemoved;
        private DateTime _EntryDate;
        private Int64 _BrandID;
        private Int64 _SupplierID;
        private Int64 _RegionID;
        private Int64 _CountryID;
        private Int64? _PreBOQProjectID;
        private String _ItemName;
        private String _BrandName;
        private String _SupplierName;
        private String _RegionName;
        private String _CountryName;


        [DataMember]
        public Int64 PreBOQDetailID
        {
            get { return _PreBOQDetailID; }
            set { _PreBOQDetailID = value; }
        }

        [DataMember]
        public Int64 PreBOQID
        {
            get { return _PreBOQID; }
            set { _PreBOQID = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Decimal Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public Decimal TotalQty
        {
            get { return _TotalQty; }
            set { _TotalQty = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public DateTime EntryDate
        {
            get { return _EntryDate; }
            set { _EntryDate = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
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
        public Int64? PreBOQProjectID
        {
            get { return _PreBOQProjectID; }
            set { _PreBOQProjectID = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public String BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }

        [DataMember]
        public String RegionName
        {
            get { return _RegionName; }
            set { _RegionName = value; }
        }

        [DataMember]
        public String CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (PreBOQDetailID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMPreBOQDetail_DetailedCustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PreBOQDetailID = "PreBOQDetailID";
        public const String FLD_NAME_PreBOQID = "PreBOQID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_TotalQty = "TotalQty";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_EntryDate = "EntryDate";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_PreBOQProjectID = "PreBOQProjectID";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_RegionName = "RegionName";
        public const String FLD_NAME_CountryName = "CountryName";

        #endregion
    }
}
