// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jun-2012, 10:09:58




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "REQRequisitionItem_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class REQRequisitionItem_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _RequisitionID;
        private Int64 _ProjectID;
        private String _RequisitionNo;
        private DateTime _RequisitionDate;
        private String _Remarks;
        private Int64 _RequisitionStatusID;
        private Int64 _RequisitionItemID;
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
        private String _ItemName;
        private Int64? _UnitID;
        private String _UnitName;
        private String _ProjectCode;
        private String _ProjectName;
        private String _BrandName;
        private String _SupplierName;
        private String _RegionName;
        private String _CountryName;


        [DataMember]
        public Int64 RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public DateTime RequisitionDate
        {
            get { return _RequisitionDate; }
            set { _RequisitionDate = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 RequisitionStatusID
        {
            get { return _RequisitionStatusID; }
            set { _RequisitionStatusID = value; }
        }

        [DataMember]
        public Int64 RequisitionItemID
        {
            get { return _RequisitionItemID; }
            set { _RequisitionItemID = value; }
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
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public Int64? UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
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
                return (RequisitionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public REQRequisitionItem_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_RequisitionDate = "RequisitionDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_RequisitionStatusID = "RequisitionStatusID";
        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
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
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_UnitID = "UnitID";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_RegionName = "RegionName";
        public const String FLD_NAME_CountryName = "CountryName";

        #endregion
    }
}
