// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Nov-2012, 10:26:04




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMBill_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMBill_DetailedEntity : BaseEntity
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
        private String _SupplierCode;
        private String _SupplierName;
        private String _BDProjectProjectName;
        private String _WorkOrderNo;
        private String _MDBillStatusName;
        private String _MDBillApprovalStatusName;
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
        public String BDProjectProjectName
        {
            get { return _BDProjectProjectName; }
            set { _BDProjectProjectName = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public String MDBillStatusName
        {
            get { return _MDBillStatusName; }
            set { _MDBillStatusName = value; }
        }

        [DataMember]
        public String MDBillApprovalStatusName
        {
            get { return _MDBillApprovalStatusName; }
            set { _MDBillApprovalStatusName = value; }
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

        public CMBill_DetailedEntity() : base()
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
        public const String FLD_NAME_SupplierCode = "SupplierCode";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_BDProjectProjectName = "BDProjectProjectName";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_MDBillStatusName = "MDBillStatusName";
        public const String FLD_NAME_MDBillApprovalStatusName = "MDBillApprovalStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
