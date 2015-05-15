// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMPreBOQDetail", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMPreBOQDetailEntity : BaseEntity
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

        public PRMPreBOQDetailEntity() : base()
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

        #endregion
    }
}
