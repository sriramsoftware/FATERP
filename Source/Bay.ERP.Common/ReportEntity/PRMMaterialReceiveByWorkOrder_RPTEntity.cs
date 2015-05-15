// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Oct-2012, 01:00:56




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMMaterialReceiveByWorkOrder_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMMaterialReceiveByWorkOrder_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _MaterialReceiveID;
        private DateTime _MRRDate;
        private String _MRRNo;
        private Int64 _ProjectID;
        private String _Remarks;
        private Int64 _SupplierID;
        private Int64 _WorkOrderID;
        private Int64? _MaterialReceiveItemMapID;
        private DateTime? _ReceiveDate;
        private Int64? _RequisitionItemID;
        private String _ChallanNo;
        private Decimal? _ReceiveQty;
        private String _ProjectCode;
        private String _ProjectName;
        private String _SupplierCode;
        private String _SupplierName;
        private String _Phone;
        private String _MobileNo;
        private String _WorkOrderNo;
        private DateTime _WorkOrderDate;
        private String _RequisitionNo;
        private DateTime _RequisitionDate;
        private Int64? _ItemID;
        private Int64? _BrandID;
        private Int64? _CountryID;
        private Int64? _RegionID;
        private String _ItemName;
        private String _BrandName;
        private String _OriginCountryName;
        private String _OriginRegionName;
        private String _UnitName;
        private String _AddressLine1;


        [DataMember]
        public Int64 MaterialReceiveID
        {
            get { return _MaterialReceiveID; }
            set { _MaterialReceiveID = value; }
        }

        [DataMember]
        public DateTime MRRDate
        {
            get { return _MRRDate; }
            set { _MRRDate = value; }
        }

        [DataMember]
        public String MRRNo
        {
            get { return _MRRNo; }
            set { _MRRNo = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public Int64 WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public Int64? MaterialReceiveItemMapID
        {
            get { return _MaterialReceiveItemMapID; }
            set { _MaterialReceiveItemMapID = value; }
        }

        [DataMember]
        public DateTime? ReceiveDate
        {
            get { return _ReceiveDate; }
            set { _ReceiveDate = value; }
        }

        [DataMember]
        public Int64? RequisitionItemID
        {
            get { return _RequisitionItemID; }
            set { _RequisitionItemID = value; }
        }

        [DataMember]
        public String ChallanNo
        {
            get { return _ChallanNo; }
            set { _ChallanNo = value; }
        }

        [DataMember]
        public Decimal? ReceiveQty
        {
            get { return _ReceiveQty; }
            set { _ReceiveQty = value; }
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
        public String SupplierCode
        {
            get { return _SupplierCode; }
            set { _SupplierCode = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }

        [DataMember]
        public String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        [DataMember]
        public String MobileNo
        {
            get { return _MobileNo; }
            set { _MobileNo = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public DateTime WorkOrderDate
        {
            get { return _WorkOrderDate; }
            set { _WorkOrderDate = value; }
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
        public Int64? ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Int64? BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64? CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public Int64? RegionID
        {
            get { return _RegionID; }
            set { _RegionID = value; }
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
        public String OriginCountryName
        {
            get { return _OriginCountryName; }
            set { _OriginCountryName = value; }
        }

        [DataMember]
        public String OriginRegionName
        {
            get { return _OriginRegionName; }
            set { _OriginRegionName = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        [DataMember]
        public String AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (MaterialReceiveID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMMaterialReceiveByWorkOrder_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MaterialReceiveID = "MaterialReceiveID";
        public const String FLD_NAME_MRRDate = "MRRDate";
        public const String FLD_NAME_MRRNo = "MRRNo";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_MaterialReceiveItemMapID = "MaterialReceiveItemMapID";
        public const String FLD_NAME_ReceiveDate = "ReceiveDate";
        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_ChallanNo = "ChallanNo";
        public const String FLD_NAME_ReceiveQty = "ReceiveQty";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_SupplierCode = "SupplierCode";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_MobileNo = "MobileNo";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_WorkOrderDate = "WorkOrderDate";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_RequisitionDate = "RequisitionDate";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_OriginCountryName = "OriginCountryName";
        public const String FLD_NAME_OriginRegionName = "OriginRegionName";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";

        #endregion
    }
}
