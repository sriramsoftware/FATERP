// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-May-2013, 01:11:15




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVTransactionINOUT_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVTransactionINOUT_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _ItemID;
        private Int64 _BrandID;
        private Int64 _RegionID;
        private Int64 _CountryID;
        private Boolean _TransactionDirection;
        private Int64? _IN;
        private Int64 _OUT;
        private Int64 _BalanceQty;
        private String _ItemName;
        private String _BrandName;
        private String _RegionName;
        private String _CountryName;


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
        public Boolean TransactionDirection
        {
            get { return _TransactionDirection; }
            set { _TransactionDirection = value; }
        }

        [DataMember]
        public Int64? IN
        {
            get { return _IN; }
            set { _IN = value; }
        }

        [DataMember]
        public Int64 OUT
        {
            get { return _OUT; }
            set { _OUT = value; }
        }

        [DataMember]
        public Int64 BalanceQty
        {
            get { return _BalanceQty; }
            set { _BalanceQty = value; }
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
                return (ItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVTransactionINOUT_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_TransactionDirection = "TransactionDirection";
        public const String FLD_NAME_IN = "IN";
        public const String FLD_NAME_OUT = "OUT";
        public const String FLD_NAME_BalanceQty = "BalanceQty";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_RegionName = "RegionName";
        public const String FLD_NAME_CountryName = "CountryName";

        #endregion
    }
}
