// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Sep-2013, 02:13:02




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMWorkOrder_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMWorkOrder_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _WorkOrderID;
        private Int64 _SupplierID;
        private String _WorkOrderNo;
        private Int64? _AttentionID;
        private String _OtherAttention;
        private DateTime _CreateDate;
        private String _Subject;
        private String _BodyTitle;
        private DateTime _StartDate;
        private DateTime _CompletionDate;
        private String _Warranty;
        private String _DelayCharge;
        private String _RowText;
        private String _Remarks;
        private String _FootNote;
        private Int64 _PreparedByID;
        private Boolean _IsFinalBilled;
        private Decimal? _VAT;
        private Decimal? _Tax;
        private Decimal? _CarryingCharge;
        private Decimal? _Discount;
        private Decimal? _AIT;
        private Decimal? _GrandTotal;
        private Int64 _WorkOrderStatus;
        private Int64? _WorkOrderItemMapID;
        private Int64? _RequisitionID;
        private Int64? _RequisitionItemID;
        private Decimal? _RequiredQty;
        private Decimal? _Rate;
        private String _DeliveryAddress;
        private String _ItemDescription;
        private Int64? _WorkOrderItemMapStatus;
        private String _SupplierCode;
        private String _SupplierName;
        private String _Relationship;
        private String _Phone;
        private String _MobileNo;
        private String _Fax;
        private String _Email;
        private String _WebLink;
        private String _RequisitionNo;
        private String _ItemName;
        private String _OriginBrandName;
        private String _OriginSupplierName;
        private String _OriginRegionName;
        private String _OriginCountryName;
        private String _Attention;
        private String _PreparedByFullName;
        private String _MDWorkOrderStatus;
        private String _MDWorkOrderItemMapStatus;
        private String _AddressLine1;
        private String _AddressLine2;
        private String _UnitName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public Int64? AttentionID
        {
            get { return _AttentionID; }
            set { _AttentionID = value; }
        }

        [DataMember]
        public String OtherAttention
        {
            get { return _OtherAttention; }
            set { _OtherAttention = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public String Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }

        [DataMember]
        public String BodyTitle
        {
            get { return _BodyTitle; }
            set { _BodyTitle = value; }
        }

        [DataMember]
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public DateTime CompletionDate
        {
            get { return _CompletionDate; }
            set { _CompletionDate = value; }
        }

        [DataMember]
        public String Warranty
        {
            get { return _Warranty; }
            set { _Warranty = value; }
        }

        [DataMember]
        public String DelayCharge
        {
            get { return _DelayCharge; }
            set { _DelayCharge = value; }
        }

        [DataMember]
        public String RowText
        {
            get { return _RowText; }
            set { _RowText = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String FootNote
        {
            get { return _FootNote; }
            set { _FootNote = value; }
        }

        [DataMember]
        public Int64 PreparedByID
        {
            get { return _PreparedByID; }
            set { _PreparedByID = value; }
        }

        [DataMember]
        public Boolean IsFinalBilled
        {
            get { return _IsFinalBilled; }
            set { _IsFinalBilled = value; }
        }

        [DataMember]
        public Decimal? VAT
        {
            get { return _VAT; }
            set { _VAT = value; }
        }

        [DataMember]
        public Decimal? Tax
        {
            get { return _Tax; }
            set { _Tax = value; }
        }

        [DataMember]
        public Decimal? CarryingCharge
        {
            get { return _CarryingCharge; }
            set { _CarryingCharge = value; }
        }

        [DataMember]
        public Decimal? Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }

        [DataMember]
        public Decimal? AIT
        {
            get { return _AIT; }
            set { _AIT = value; }
        }

        [DataMember]
        public Decimal? GrandTotal
        {
            get { return _GrandTotal; }
            set { _GrandTotal = value; }
        }

        [DataMember]
        public Int64 WorkOrderStatus
        {
            get { return _WorkOrderStatus; }
            set { _WorkOrderStatus = value; }
        }

        [DataMember]
        public Int64? WorkOrderItemMapID
        {
            get { return _WorkOrderItemMapID; }
            set { _WorkOrderItemMapID = value; }
        }

        [DataMember]
        public Int64? RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
        }

        [DataMember]
        public Int64? RequisitionItemID
        {
            get { return _RequisitionItemID; }
            set { _RequisitionItemID = value; }
        }

        [DataMember]
        public Decimal? RequiredQty
        {
            get { return _RequiredQty; }
            set { _RequiredQty = value; }
        }

        [DataMember]
        public Decimal? Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public String DeliveryAddress
        {
            get { return _DeliveryAddress; }
            set { _DeliveryAddress = value; }
        }

        [DataMember]
        public String ItemDescription
        {
            get { return _ItemDescription; }
            set { _ItemDescription = value; }
        }

        [DataMember]
        public Int64? WorkOrderItemMapStatus
        {
            get { return _WorkOrderItemMapStatus; }
            set { _WorkOrderItemMapStatus = value; }
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
        public String Relationship
        {
            get { return _Relationship; }
            set { _Relationship = value; }
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
        public String Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }

        [DataMember]
        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [DataMember]
        public String WebLink
        {
            get { return _WebLink; }
            set { _WebLink = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public String OriginBrandName
        {
            get { return _OriginBrandName; }
            set { _OriginBrandName = value; }
        }

        [DataMember]
        public String OriginSupplierName
        {
            get { return _OriginSupplierName; }
            set { _OriginSupplierName = value; }
        }

        [DataMember]
        public String OriginRegionName
        {
            get { return _OriginRegionName; }
            set { _OriginRegionName = value; }
        }

        [DataMember]
        public String OriginCountryName
        {
            get { return _OriginCountryName; }
            set { _OriginCountryName = value; }
        }

        [DataMember]
        public String Attention
        {
            get { return _Attention; }
            set { _Attention = value; }
        }

        [DataMember]
        public String PreparedByFullName
        {
            get { return _PreparedByFullName; }
            set { _PreparedByFullName = value; }
        }

        [DataMember]
        public String MDWorkOrderStatus
        {
            get { return _MDWorkOrderStatus; }
            set { _MDWorkOrderStatus = value; }
        }

        [DataMember]
        public String MDWorkOrderItemMapStatus
        {
            get { return _MDWorkOrderItemMapStatus; }
            set { _MDWorkOrderItemMapStatus = value; }
        }

        [DataMember]
        public String AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        [DataMember]
        public String AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; }
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
                return (WorkOrderID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMWorkOrder_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_AttentionID = "AttentionID";
        public const String FLD_NAME_OtherAttention = "OtherAttention";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_Subject = "Subject";
        public const String FLD_NAME_BodyTitle = "BodyTitle";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_CompletionDate = "CompletionDate";
        public const String FLD_NAME_Warranty = "Warranty";
        public const String FLD_NAME_DelayCharge = "DelayCharge";
        public const String FLD_NAME_RowText = "RowText";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_FootNote = "FootNote";
        public const String FLD_NAME_PreparedByID = "PreparedByID";
        public const String FLD_NAME_IsFinalBilled = "IsFinalBilled";
        public const String FLD_NAME_VAT = "VAT";
        public const String FLD_NAME_Tax = "Tax";
        public const String FLD_NAME_CarryingCharge = "CarryingCharge";
        public const String FLD_NAME_Discount = "Discount";
        public const String FLD_NAME_AIT = "AIT";
        public const String FLD_NAME_GrandTotal = "GrandTotal";
        public const String FLD_NAME_WorkOrderStatus = "WorkOrderStatus";
        public const String FLD_NAME_WorkOrderItemMapID = "WorkOrderItemMapID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_RequisitionItemID = "RequisitionItemID";
        public const String FLD_NAME_RequiredQty = "RequiredQty";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_DeliveryAddress = "DeliveryAddress";
        public const String FLD_NAME_ItemDescription = "ItemDescription";
        public const String FLD_NAME_WorkOrderItemMapStatus = "WorkOrderItemMapStatus";
        public const String FLD_NAME_SupplierCode = "SupplierCode";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_Relationship = "Relationship";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_MobileNo = "MobileNo";
        public const String FLD_NAME_Fax = "Fax";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_WebLink = "WebLink";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_OriginBrandName = "OriginBrandName";
        public const String FLD_NAME_OriginSupplierName = "OriginSupplierName";
        public const String FLD_NAME_OriginRegionName = "OriginRegionName";
        public const String FLD_NAME_OriginCountryName = "OriginCountryName";
        public const String FLD_NAME_Attention = "Attention";
        public const String FLD_NAME_PreparedByFullName = "PreparedByFullName";
        public const String FLD_NAME_MDWorkOrderStatus = "MDWorkOrderStatus";
        public const String FLD_NAME_MDWorkOrderItemMapStatus = "MDWorkOrderItemMapStatus";
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
