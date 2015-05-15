// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:43:44




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVTransaction", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVTransactionEntity : BaseEntity
    {
        #region Properties


        private Int64 _TransactionID;
        private Int64 _ItemID;
        private Int64 _BrandID;
        private Int64 _RegionID;
        private Int64 _CountryID;
        private String _BatchNumber;
        private Int64 _TransactionQty;
        private DateTime _TransactionDate;
        private Boolean _TransactionDirection;
        private String _IPAddress;
        private Int64 _EmployeeID;
        private Decimal _UnitPrice;
        private String _RequisitionNumber;
        private String _WordOrderNumber;
        private String _MRRNumber;
        private String _BillNumber;
        private Boolean _IsTransfer;
        private Int64? _ProjectID;
        private Int64? _StoreID;
        private Int64? _StoreUnitID;


        [DataMember]
        public Int64 TransactionID
        {
            get { return _TransactionID; }
            set { _TransactionID = value; }
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
        public String BatchNumber
        {
            get { return _BatchNumber; }
            set { _BatchNumber = value; }
        }

        [DataMember]
        public Int64 TransactionQty
        {
            get { return _TransactionQty; }
            set { _TransactionQty = value; }
        }

        [DataMember]
        public DateTime TransactionDate
        {
            get { return _TransactionDate; }
            set { _TransactionDate = value; }
        }

        [DataMember]
        public Boolean TransactionDirection
        {
            get { return _TransactionDirection; }
            set { _TransactionDirection = value; }
        }

        [DataMember]
        public String IPAddress
        {
            get { return _IPAddress; }
            set { _IPAddress = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Decimal UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }

        [DataMember]
        public String RequisitionNumber
        {
            get { return _RequisitionNumber; }
            set { _RequisitionNumber = value; }
        }

        [DataMember]
        public String WordOrderNumber
        {
            get { return _WordOrderNumber; }
            set { _WordOrderNumber = value; }
        }

        [DataMember]
        public String MRRNumber
        {
            get { return _MRRNumber; }
            set { _MRRNumber = value; }
        }

        [DataMember]
        public String BillNumber
        {
            get { return _BillNumber; }
            set { _BillNumber = value; }
        }

        [DataMember]
        public Boolean IsTransfer
        {
            get { return _IsTransfer; }
            set { _IsTransfer = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64? StoreID
        {
            get { return _StoreID; }
            set { _StoreID = value; }
        }

        [DataMember]
        public Int64? StoreUnitID
        {
            get { return _StoreUnitID; }
            set { _StoreUnitID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (TransactionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVTransactionEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TransactionID = "TransactionID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_RegionID = "RegionID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_BatchNumber = "BatchNumber";
        public const String FLD_NAME_TransactionQty = "TransactionQty";
        public const String FLD_NAME_TransactionDate = "TransactionDate";
        public const String FLD_NAME_TransactionDirection = "TransactionDirection";
        public const String FLD_NAME_IPAddress = "IPAddress";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_UnitPrice = "UnitPrice";
        public const String FLD_NAME_RequisitionNumber = "RequisitionNumber";
        public const String FLD_NAME_WordOrderNumber = "WordOrderNumber";
        public const String FLD_NAME_MRRNumber = "MRRNumber";
        public const String FLD_NAME_BillNumber = "BillNumber";
        public const String FLD_NAME_IsTransfer = "IsTransfer";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_StoreID = "StoreID";
        public const String FLD_NAME_StoreUnitID = "StoreUnitID";

        #endregion
    }
}
