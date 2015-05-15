// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Dec-2012, 01:47:00




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACCPrePayableStatementDetail_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACCPrePayableStatementDetail_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64? _BillID;
        private String _BillNo;
        private Decimal? _BillAmount;
        private DateTime? _billlDate;
        private Int64? _ProjectID;
        private Int64? _VendorCategory;
        private Int64? _Vendor;
        private Decimal? _WOAmount;
        private Int64? _WorkOrderID;
        private Int64? _RequisitionID;
        private String _RequisitionNo;
        private DateTime? _RequisitionDate;
        private String _WorkOrderNo;
        private String _ProjectName;
        private String _ProjectCode;
        private Int64? _BillApprovalStatusID;
        private DateTime? _StartDate;


        [DataMember]
        public Int64? BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }

        [DataMember]
        public String BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        [DataMember]
        public Decimal? BillAmount
        {
            get { return _BillAmount; }
            set { _BillAmount = value; }
        }

        [DataMember]
        public DateTime? billlDate
        {
            get { return _billlDate; }
            set { _billlDate = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64? VendorCategory
        {
            get { return _VendorCategory; }
            set { _VendorCategory = value; }
        }

        [DataMember]
        public Int64? Vendor
        {
            get { return _Vendor; }
            set { _Vendor = value; }
        }

        [DataMember]
        public Decimal? WOAmount
        {
            get { return _WOAmount; }
            set { _WOAmount = value; }
        }

        [DataMember]
        public Int64? WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public Int64? RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public DateTime? RequisitionDate
        {
            get { return _RequisitionDate; }
            set { _RequisitionDate = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public Int64? BillApprovalStatusID
        {
            get { return _BillApprovalStatusID; }
            set { _BillApprovalStatusID = value; }
        }

        [DataMember]
        public DateTime? StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
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

        public ACCPrePayableStatementDetail_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_BillNo = "BillNo";
        public const String FLD_NAME_BillAmount = "BillAmount";
        public const String FLD_NAME_billlDate = "billlDate";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_VendorCategory = "VendorCategory";
        public const String FLD_NAME_Vendor = "Vendor";
        public const String FLD_NAME_WOAmount = "WOAmount";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_RequisitionDate = "RequisitionDate";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_BillApprovalStatusID = "BillApprovalStatusID";
        public const String FLD_NAME_StartDate = "StartDate";

        #endregion
    }
}
