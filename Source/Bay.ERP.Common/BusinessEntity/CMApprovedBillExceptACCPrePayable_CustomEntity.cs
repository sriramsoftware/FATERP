// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 01:29:48




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMApprovedBillExceptACCPrePayable_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMApprovedBillExceptACCPrePayable_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _BillID;
        private String _BillNo;
        private DateTime _BillDate;
        private Decimal _Amount;
        private Int64 _ProjectID;
        private Int64 _VendorCategory;
        private Int64 _Vendor;
        private Int64 _BillStatusID;
        private Int64 _BillApprovalStatusID;


        [DataMember]
        public Int64 BillID
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
        public DateTime BillDate
        {
            get { return _BillDate; }
            set { _BillDate = value; }
        }

        [DataMember]
        public Decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
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

        public CMApprovedBillExceptACCPrePayable_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_BillNo = "BillNo";
        public const String FLD_NAME_BillDate = "BillDate";
        public const String FLD_NAME_Amount = "Amount";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_VendorCategory = "VendorCategory";
        public const String FLD_NAME_Vendor = "Vendor";
        public const String FLD_NAME_BillStatusID = "BillStatusID";
        public const String FLD_NAME_BillApprovalStatusID = "BillApprovalStatusID";

        #endregion
    }
}
