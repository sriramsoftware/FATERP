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
    [DataContract(Name = "CMBill_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMBill_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _BillID;
        private Int64 _ProjectID;
        private String _BillNo;
        private Int64 _VendorCategory;
        private Int64 _Vendor;
        private Int64 _WorkOrderID;
        private Int64 _DiscountAddition;
        private Int64 _Vat;
        private Int64 _Tax;
        private Int64 _CarryingCharge;
        private Decimal _Amount;
        private String _AdditionRemarks;
        private DateTime _CreateDate;
        private DateTime _BillDate;
        private String _Remarks;
        private Int64 _BillStatusID;
        private Int64 _BillApprovalStatusID;
        private Int64 _BillMaterialReceiveMeasurementBookMapID;
        private Int64 _MaterialReceiveID;
        private Int64 _MaterialReceiveItemMapID;
        private Int64 _MeasurementBookID;
        private Int64 _MeasurementBookDetailID;
        private Int64 _BillPrice;
        private Int64? _BillUploadInfoID;
        private String _Extension;
        private String _BillUploadInfoRemaks;
        private String _Path;
        private String _OriginalFileName;
        private String _CurrentFileName;
        private String _FileType;
        private String _ProjectCode;
        private String _ProjectName;
        private Int64 _SupplierID;
        private String _SupplierCode;
        private String _SupplierName;
        private String _Relationship;
        private String _Phone;
        private String _MobileNo;
        private String _Fax;
        private String _Email;
        private String _WebLink;
        private DateTime _SupplierCreateDate;
        private String _SupplierRemarks;
        private Int64 _SupplierTypeID;
        private Int64 _SupplierStatusID;
        private String _Reason;
        private Boolean _IsRemoved;
        private String _WorkOrderNo;

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
        public Int64 DiscountAddition
        {
            get { return _DiscountAddition; }
            set { _DiscountAddition = value; }
        }

        [DataMember]
        public Int64 Vat
        {
            get { return _Vat; }
            set { _Vat = value; }
        }

        [DataMember]
        public Int64 Tax
        {
            get { return _Tax; }
            set { _Tax = value; }
        }

        [DataMember]
        public Int64 CarryingCharge
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

        [DataMember]
        public Int64 BillMaterialReceiveMeasurementBookMapID
        {
            get { return _BillMaterialReceiveMeasurementBookMapID; }
            set { _BillMaterialReceiveMeasurementBookMapID = value; }
        }

        [DataMember]
        public Int64 MaterialReceiveID
        {
            get { return _MaterialReceiveID; }
            set { _MaterialReceiveID = value; }
        }

        [DataMember]
        public Int64 MaterialReceiveItemMapID
        {
            get { return _MaterialReceiveItemMapID; }
            set { _MaterialReceiveItemMapID = value; }
        }

        [DataMember]
        public Int64 MeasurementBookID
        {
            get { return _MeasurementBookID; }
            set { _MeasurementBookID = value; }
        }

        [DataMember]
        public Int64 MeasurementBookDetailID
        {
            get { return _MeasurementBookDetailID; }
            set { _MeasurementBookDetailID = value; }
        }

        [DataMember]
        public Int64 BillPrice
        {
            get { return _BillPrice; }
            set { _BillPrice = value; }
        }

        [DataMember]
        public Int64? BillUploadInfoID
        {
            get { return _BillUploadInfoID; }
            set { _BillUploadInfoID = value; }
        }

        [DataMember]
        public String Extension
        {
            get { return _Extension; }
            set { _Extension = value; }
        }

        [DataMember]
        public String BillUploadInfoRemaks
        {
            get { return _BillUploadInfoRemaks; }
            set { _BillUploadInfoRemaks = value; }
        }

        [DataMember]
        public String Path
        {
            get { return _Path; }
            set { _Path = value; }
        }

        [DataMember]
        public String OriginalFileName
        {
            get { return _OriginalFileName; }
            set { _OriginalFileName = value; }
        }

        [DataMember]
        public String CurrentFileName
        {
            get { return _CurrentFileName; }
            set { _CurrentFileName = value; }
        }

        [DataMember]
        public String FileType
        {
            get { return _FileType; }
            set { _FileType = value; }
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
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
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
        public DateTime SupplierCreateDate
        {
            get { return _SupplierCreateDate; }
            set { _SupplierCreateDate = value; }
        }

        [DataMember]
        public String SupplierRemarks
        {
            get { return _SupplierRemarks; }
            set { _SupplierRemarks = value; }
        }

        [DataMember]
        public Int64 SupplierTypeID
        {
            get { return _SupplierTypeID; }
            set { _SupplierTypeID = value; }
        }

        [DataMember]
        public Int64 SupplierStatusID
        {
            get { return _SupplierStatusID; }
            set { _SupplierStatusID = value; }
        }

        [DataMember]
        public String Reason
        {
            get { return _Reason; }
            set { _Reason = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
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

        public CMBill_RPTEntity() : base()
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
        public const String FLD_NAME_BillMaterialReceiveMeasurementBookMapID = "BillMaterialReceiveMeasurementBookMapID";
        public const String FLD_NAME_MaterialReceiveID = "MaterialReceiveID";
        public const String FLD_NAME_MaterialReceiveItemMapID = "MaterialReceiveItemMapID";
        public const String FLD_NAME_MeasurementBookID = "MeasurementBookID";
        public const String FLD_NAME_MeasurementBookDetailID = "MeasurementBookDetailID";
        public const String FLD_NAME_BillPrice = "BillPrice";
        public const String FLD_NAME_BillUploadInfoID = "BillUploadInfoID";
        public const String FLD_NAME_Extension = "Extension";
        public const String FLD_NAME_BillUploadInfoRemaks = "BillUploadInfoRemaks";
        //public const String FLD_NAME_FileUploadRemarks = "FileUploadRemarks";
        public const String FLD_NAME_Path = "Path";
        public const String FLD_NAME_OriginalFileName = "OriginalFileName";
        public const String FLD_NAME_CurrentFileName = "CurrentFileName";
        public const String FLD_NAME_FileType = "FileType";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_SupplierCode = "SupplierCode";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_Relationship = "Relationship";
        public const String FLD_NAME_Phone = "Phone";
        public const String FLD_NAME_MobileNo = "MobileNo";
        public const String FLD_NAME_Fax = "Fax";
        public const String FLD_NAME_Email = "Email";
        public const String FLD_NAME_WebLink = "WebLink";
        public const String FLD_NAME_SupplierCreateDate = "SupplierCreateDate";
        public const String FLD_NAME_SupplierRemarks = "SupplierRemarks";
        public const String FLD_NAME_SupplierTypeID = "SupplierTypeID";
        public const String FLD_NAME_SupplierStatusID = "SupplierStatusID";
        public const String FLD_NAME_Reason = "Reason";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";

        #endregion
    }
}
