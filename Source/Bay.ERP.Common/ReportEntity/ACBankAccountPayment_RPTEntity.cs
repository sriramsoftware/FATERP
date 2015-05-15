// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Jul-2013, 10:23:15




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACBankAccountPayment_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACBankAccountPayment_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _BankAccountPaymentID;
        private DateTime _PaymentDate;
        private Int64 _PayToID;
        private Int64? _ReferenceID;
        private Int64 _BankAccountID;
        private String _Reference;
        private String _BankAccountDepositName;
        private String _Memo;
        private Int64 _BankAccountPaymentApprovalStatusID;
        private Int64 _PreparedByEmployeeID;
        private String _PaidFromName;
        private String _BankAccountName;
        private String _BankAccountNumber;
        private Int64? _BankAccountTypeID;
        private String _BankName;
        private String _BankAddress;
        private String _BankAccountTypeName;
        private String _BankAccountCode;
        private String _BankAccountAccountName;
        private Int64? _BankAccountPaymentItemID;
        private String _DimensionName;
        private Decimal? _Amount;
        private Int64? _ProjectID;
        private Int64? _ItemID;
        private Int64? _RequisitionID;
        private Int64? _WorkOrderID;
        private Int64? _BillID;
        private Int64? _ProjectFloorID;
        private Int64? _ProjectFloorUnitID;
        private String _BankAccountDepositItemMemo;
        private String _DepositItemAccountCode;
        private String _DepositItemAccountName;
        private String _AccountGroupName;
        private String _SupplierName;
        private String _ItemName;
        private String _RequisitionNo;
        private String _WorkOrderNo;
        private String _BillNo;
        private String _ProjectCode;
        private String _ProjectName;
        private String _ProjectFloorName;
        private String _ProjectFloorUnitName;
        private String _MemberFullName;


        [DataMember]
        public Int64 BankAccountPaymentID
        {
            get { return _BankAccountPaymentID; }
            set { _BankAccountPaymentID = value; }
        }

        [DataMember]
        public DateTime PaymentDate
        {
            get { return _PaymentDate; }
            set { _PaymentDate = value; }
        }

        [DataMember]
        public Int64 PayToID
        {
            get { return _PayToID; }
            set { _PayToID = value; }
        }

        [DataMember]
        public Int64? ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public Int64 BankAccountID
        {
            get { return _BankAccountID; }
            set { _BankAccountID = value; }
        }

        [DataMember]
        public String Reference
        {
            get { return _Reference; }
            set { _Reference = value; }
        }

        [DataMember]
        public String BankAccountDepositName
        {
            get { return _BankAccountDepositName; }
            set { _BankAccountDepositName = value; }
        }

        [DataMember]
        public String Memo
        {
            get { return _Memo; }
            set { _Memo = value; }
        }

        [DataMember]
        public Int64 BankAccountPaymentApprovalStatusID
        {
            get { return _BankAccountPaymentApprovalStatusID; }
            set { _BankAccountPaymentApprovalStatusID = value; }
        }

        [DataMember]
        public Int64 PreparedByEmployeeID
        {
            get { return _PreparedByEmployeeID; }
            set { _PreparedByEmployeeID = value; }
        }

        [DataMember]
        public String PaidFromName
        {
            get { return _PaidFromName; }
            set { _PaidFromName = value; }
        }

        [DataMember]
        public String BankAccountName
        {
            get { return _BankAccountName; }
            set { _BankAccountName = value; }
        }

        [DataMember]
        public String BankAccountNumber
        {
            get { return _BankAccountNumber; }
            set { _BankAccountNumber = value; }
        }

        [DataMember]
        public Int64? BankAccountTypeID
        {
            get { return _BankAccountTypeID; }
            set { _BankAccountTypeID = value; }
        }

        [DataMember]
        public String BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }

        [DataMember]
        public String BankAddress
        {
            get { return _BankAddress; }
            set { _BankAddress = value; }
        }

        [DataMember]
        public String BankAccountTypeName
        {
            get { return _BankAccountTypeName; }
            set { _BankAccountTypeName = value; }
        }

        [DataMember]
        public String BankAccountCode
        {
            get { return _BankAccountCode; }
            set { _BankAccountCode = value; }
        }

        [DataMember]
        public String BankAccountAccountName
        {
            get { return _BankAccountAccountName; }
            set { _BankAccountAccountName = value; }
        }

        [DataMember]
        public Int64? BankAccountPaymentItemID
        {
            get { return _BankAccountPaymentItemID; }
            set { _BankAccountPaymentItemID = value; }
        }

        [DataMember]
        public String DimensionName
        {
            get { return _DimensionName; }
            set { _DimensionName = value; }
        }

        [DataMember]
        public Decimal? Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64? ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Int64? RequisitionID
        {
            get { return _RequisitionID; }
            set { _RequisitionID = value; }
        }

        [DataMember]
        public Int64? WorkOrderID
        {
            get { return _WorkOrderID; }
            set { _WorkOrderID = value; }
        }

        [DataMember]
        public Int64? BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }

        [DataMember]
        public Int64? ProjectFloorID
        {
            get { return _ProjectFloorID; }
            set { _ProjectFloorID = value; }
        }

        [DataMember]
        public Int64? ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public String BankAccountDepositItemMemo
        {
            get { return _BankAccountDepositItemMemo; }
            set { _BankAccountDepositItemMemo = value; }
        }

        [DataMember]
        public String DepositItemAccountCode
        {
            get { return _DepositItemAccountCode; }
            set { _DepositItemAccountCode = value; }
        }

        [DataMember]
        public String DepositItemAccountName
        {
            get { return _DepositItemAccountName; }
            set { _DepositItemAccountName = value; }
        }

        [DataMember]
        public String AccountGroupName
        {
            get { return _AccountGroupName; }
            set { _AccountGroupName = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public String RequisitionNo
        {
            get { return _RequisitionNo; }
            set { _RequisitionNo = value; }
        }

        [DataMember]
        public String WorkOrderNo
        {
            get { return _WorkOrderNo; }
            set { _WorkOrderNo = value; }
        }

        [DataMember]
        public String BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
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
        public String ProjectFloorName
        {
            get { return _ProjectFloorName; }
            set { _ProjectFloorName = value; }
        }

        [DataMember]
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BankAccountPaymentID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACBankAccountPayment_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BankAccountPaymentID = "BankAccountPaymentID";
        public const String FLD_NAME_PaymentDate = "PaymentDate";
        public const String FLD_NAME_PayToID = "PayToID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_BankAccountID = "BankAccountID";
        public const String FLD_NAME_Reference = "Reference";
        public const String FLD_NAME_BankAccountDepositName = "BankAccountDepositName";
        public const String FLD_NAME_Memo = "Memo";
        public const String FLD_NAME_BankAccountPaymentApprovalStatusID = "BankAccountPaymentApprovalStatusID";
        public const String FLD_NAME_PreparedByEmployeeID = "PreparedByEmployeeID";
        public const String FLD_NAME_PaidFromName = "PaidFromName";
        public const String FLD_NAME_BankAccountName = "BankAccountName";
        public const String FLD_NAME_BankAccountNumber = "BankAccountNumber";
        public const String FLD_NAME_BankAccountTypeID = "BankAccountTypeID";
        public const String FLD_NAME_BankName = "BankName";
        public const String FLD_NAME_BankAddress = "BankAddress";
        public const String FLD_NAME_BankAccountTypeName = "BankAccountTypeName";
        public const String FLD_NAME_BankAccountCode = "BankAccountCode";
        public const String FLD_NAME_BankAccountAccountName = "BankAccountAccountName";
        public const String FLD_NAME_BankAccountPaymentItemID = "BankAccountPaymentItemID";
        public const String FLD_NAME_DimensionName = "DimensionName";
        public const String FLD_NAME_Amount = "Amount";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_RequisitionID = "RequisitionID";
        public const String FLD_NAME_WorkOrderID = "WorkOrderID";
        public const String FLD_NAME_BillID = "BillID";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_BankAccountDepositItemMemo = "BankAccountDepositItemMemo";
        public const String FLD_NAME_DepositItemAccountCode = "DepositItemAccountCode";
        public const String FLD_NAME_DepositItemAccountName = "DepositItemAccountName";
        public const String FLD_NAME_AccountGroupName = "AccountGroupName";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_RequisitionNo = "RequisitionNo";
        public const String FLD_NAME_WorkOrderNo = "WorkOrderNo";
        public const String FLD_NAME_BillNo = "BillNo";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ProjectFloorName = "ProjectFloorName";
        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";

        #endregion
    }
}
