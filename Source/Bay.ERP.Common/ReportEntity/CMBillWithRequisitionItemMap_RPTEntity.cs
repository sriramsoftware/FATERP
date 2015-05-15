// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 12:10:49




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMBillWithRequisitionItemMap_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMBillWithRequisitionItemMap_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _BillID;
        private Int64 _ProjectID;
        private String _BillNo;
        private Int64 _VendorCategory;
        private Int64 _Vendor;
        private Int64 _WorkOrderID;
        private Decimal _Amount;
        private DateTime _CreateDate;
        private DateTime _BillDate;
        private String _Remarks;
        private Int64 _BillStatusID;
        private Int64 _BillApprovalStatusID;
        private String _ProjectCode;
        private String _ProjectName;
        private String _RequisitionNo;
        private String _ItemName;
        private Decimal? _RequisitionPrice;
        private Decimal? _BillPrice;
        private Decimal? _PresentRequiredQty;
        private String _UnitName;
        private String _VendorCategoryName;
        private String _ResourceName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        [DataMember]
        public Int64 VendorCategory
        {
            get { return _VendorCategory; }
            set { _VendorCategory = value; }
        }

        [DataMember]
        public Int64 Vendor
        {
            get { return _Vendor; }
            set { _Vendor = value; }
        }

        [DataMember]
        public Int64 WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public Decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public DateTime BillDate
        {
            get { return _BillDate; }
            set { _BillDate = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 BillStatusID
        {
            get { return _BillStatusID; }
            set { _BillStatusID = value; }
        }

        [DataMember]
        public Int64 BillApprovalStatusID
        {
            get { return _BillApprovalStatusID; }
            set { _BillApprovalStatusID = value; }
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
        public Decimal? RequisitionPrice
        {
            get { return _RequisitionPrice; }
            set { _RequisitionPrice = value; }
        }

        [DataMember]
        public Decimal? BillPrice
        {
            get { return _BillPrice; }
            set { _BillPrice = value; }
        }

        [DataMember]
        public Decimal? PresentRequiredQty
        {
            get { return _PresentRequiredQty; }
            set { _PresentRequiredQty = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        [DataMember]
        public String VendorCategoryName
        {
            get { return _VendorCategoryName; }
            set { _VendorCategoryName = value; }
        }

        [DataMember]
        public String ResourceName
        {
            get { return _ResourceName; }
            set { _ResourceName = value; }
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
                return (BillID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMBillWithRequisitionItemMap_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_BillNo = "BillNo";
        public const String FLD_NAME_VendorCategory = "VendorCategory";
        public const String FLD_NAME_Vendor = "Vendor";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_Amount = "Amount";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_BillDate = "BillDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_BillStatusID = "BillStatusID";
        public const String FLD_NAME_BillApprovalStatusID = "BillApprovalStatusID";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_RequisitionPrice = "RequisitionPrice";
        public const String FLD_NAME_BillPrice = "BillPrice";
        public const String FLD_NAME_PresentRequiredQty = "PresentRequiredQty";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_VendorCategoryName = "VendorCategoryName";
        public const String FLD_NAME_ResourceName = "ResourceName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
