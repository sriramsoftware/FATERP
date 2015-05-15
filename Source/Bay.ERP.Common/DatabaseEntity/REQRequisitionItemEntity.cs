// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jun-2012, 11:52:40




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "REQRequisitionItem", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class REQRequisitionItemEntity : BaseEntity
    {
        #region Properties


        private Int64 _RequisitionItemID;
        private Int64 _RequisitionID;
        private String _AccountsCode;
        private Int64 _ItemID;
        private Int64 _BrandID;
        private Int64 _SupplierID;
        private Int64 _RegionID;
        private Int64 _CountryID;
        private Decimal _Rate;
        private Decimal _TotalRequiredQty;
        private Decimal? _PurchasedQtyTillToDate;
        private Decimal _PresentRequiredQty;
        private DateTime _RequiredDate;
        private String _Remarks;


        [DataMember]
        public Int64 RequisitionItemID
        {
            get { return _RequisitionItemID; }
            set { _RequisitionItemID = value; }
        }

        [DataMember]
        public Int64 RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
        }

        [DataMember]
        public String AccountsCode
        {
            get { return _AccountsCode; }
            set { _AccountsCode = value; }
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
        public Decimal Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public Decimal TotalRequiredQty
        {
            get { return _TotalRequiredQty; }
            set { _TotalRequiredQty = value; }
        }

        [DataMember]
        public Decimal? PurchasedQtyTillToDate
        {
            get { return _PurchasedQtyTillToDate; }
            set { _PurchasedQtyTillToDate = value; }
        }

        [DataMember]
        public Decimal PresentRequiredQty
        {
            get { return _PresentRequiredQty; }
            set { _PresentRequiredQty = value; }
        }

        [DataMember]
        public DateTime RequiredDate
        {
            get { return _RequiredDate; }
            set { _RequiredDate = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (RequisitionItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public REQRequisitionItemEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_AccountsCode = "AccountsCode";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_TotalRequiredQty = "TotalRequiredQty";
        public const String FLD_NAME_PurchasedQtyTillToDate = "PurchasedQtyTillToDate";
        public const String FLD_NAME_PresentRequiredQty = "PresentRequiredQty";
        public const String FLD_NAME_RequiredDate = "RequiredDate";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
