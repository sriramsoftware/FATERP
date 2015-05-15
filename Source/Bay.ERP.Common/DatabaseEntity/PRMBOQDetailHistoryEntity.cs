// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 11:06:52




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMBOQDetailHistory", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMBOQDetailHistoryEntity : BaseEntity
    {
        #region Properties


        private Int64 _BOQDetailHistoryID;
        private Int64 _BOQDetailID;
        private Decimal _Rate;
        private Decimal _TotalQty;
        private DateTime _EntryDate;
        private Int64 _BrandID;
        private Int64 _SupplierID;
        private Int64 _RegionID;
        private Int64 _CountryID;
        private Int64 _MemberID;
        private String _UserPCIP;
        private DateTime _UpdatedDate;


        [DataMember]
        public Int64 BOQDetailHistoryID
        {
            get { return _BOQDetailHistoryID; }
            set { _BOQDetailHistoryID = value; }
        }

        [DataMember]
        public Int64 BOQDetailID
        {
            get { return _BOQDetailID; }
            set { _BOQDetailID = value; }
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
        public Int64 MemberID
        {
            get { return _MemberID; }
            set { _MemberID = value; }
        }

        [DataMember]
        public String UserPCIP
        {
            get { return _UserPCIP; }
            set { _UserPCIP = value; }
        }

        [DataMember]
        public DateTime UpdatedDate
        {
            get { return _UpdatedDate; }
            set { _UpdatedDate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BOQDetailHistoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMBOQDetailHistoryEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BOQDetailHistoryID = "BOQDetailHistoryID";
        public const String FLD_NAME_BOQDetailID = "BOQDetailID";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_TotalQty = "TotalQty";
        public const String FLD_NAME_EntryDate = "EntryDate";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_MemberID = "MemberID";
        public const String FLD_NAME_UserPCIP = "UserPCIP";
        public const String FLD_NAME_UpdatedDate = "UpdatedDate";

        #endregion
    }
}
