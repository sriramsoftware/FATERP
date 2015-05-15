// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Feb-2013, 04:16:42




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMBill", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMBillEntity : BaseEntity
    {
        #region Properties


        private Int64 _BillID;
        private Int64 _ProjectID;
        private String _BillNo;
        private Int64 _VendorCategory;
        private Int64 _Vendor;
        private Int64 _WorkOrderID;
        private Decimal? _DiscountAddition;
        private Decimal? _Vat;
        private Decimal? _Tax;
        private Decimal? _CarryingCharge;
        private Decimal _Amount;
        private String _AdditionRemarks;
        private DateTime _CreateDate;
        private DateTime _BillDate;
        private String _Remarks;
        private Int64 _BillStatusID;
        private Int64 _BillApprovalStatusID;


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
        public Decimal? DiscountAddition
        {
            get { return _DiscountAddition; }
            set { _DiscountAddition = value; }
        }

        [DataMember]
        public Decimal? Vat
        {
            get { return _Vat; }
            set { _Vat = value; }
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
        public Decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        [DataMember]
        public String AdditionRemarks
        {
            get { return _AdditionRemarks; }
            set { _AdditionRemarks = value; }
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

        public CMBillEntity() : base()
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
        public const String FLD_NAME_DiscountAddition = "DiscountAddition";
        public const String FLD_NAME_Vat = "Vat";
        public const String FLD_NAME_Tax = "Tax";
        public const String FLD_NAME_CarryingCharge = "CarryingCharge";
        public const String FLD_NAME_Amount = "Amount";
        public const String FLD_NAME_AdditionRemarks = "AdditionRemarks";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_BillDate = "BillDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_BillStatusID = "BillStatusID";
        public const String FLD_NAME_BillApprovalStatusID = "BillApprovalStatusID";

        #endregion
    }
}
