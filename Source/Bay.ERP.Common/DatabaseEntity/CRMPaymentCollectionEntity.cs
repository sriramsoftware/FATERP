// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 02:30:30




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMPaymentCollection", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMPaymentCollectionEntity : BaseEntity
    {
        #region Properties


        private Int64 _PaymentCollectionID;
        private Int64 _PaymentScheduleMapID;
        private Int64 _PaymentScheduleID;
        private Int64 _AgreementTypeID;
        private Decimal _MoneyReceiptNo;
        private DateTime? _ActualPaymentDate;
        private String _PaymentDescription;
        private Decimal? _InstallmentPaymentAmount;
        private String _InstallmentPaymentInWord;
        private Decimal? _InitialAmountInAgreement;
        private Decimal? _OverDueAmount;
        private Decimal? _DelayDayOnPayment;
        private Decimal? _DelayDayOnOverDue;
        private Decimal? _PaymentReceivedInBank;
        private String _PaymentNotReceivedNote;
        private Int64 _AgreementID;
        private Int64 _ProjectID;
        private Boolean _ReverseEntry;
        private Boolean _LastPayment;
        private Decimal? _DiscountAmount;
        private Decimal? _Vat;
        private Decimal? _Tax;
        private Decimal? _ServiceCharge;
        private Decimal? _AdditionalFee;
        private Decimal? _GrossAmount;
        private Decimal? _NetAmount;
        private Int64 _PaymentApprovalStatusID;
        private Int64 _PaymentCategoryID;
        private String _ExtraField;
        private String _CashOrChequeNo;
        private DateTime? _CashOrChequeDate;
        private String _BankName;
        private String _BranchName;
        private Boolean _ChequeInCashConfirmation;
        private String _Remarks;
        private DateTime _CreateDate;
        private Int64 _CreateByEmployeeID;
        private String _IP;


        [DataMember]
        public Int64 PaymentCollectionID
        {
            get { return _PaymentCollectionID; }
            set { _PaymentCollectionID = value; }
        }

        [DataMember]
        public Int64 PaymentScheduleMapID
        {
            get { return _PaymentScheduleMapID; }
            set { _PaymentScheduleMapID = value; }
        }

        [DataMember]
        public Int64 PaymentScheduleID
        {
            get { return _PaymentScheduleID; }
            set { _PaymentScheduleID = value; }
        }

        [DataMember]
        public Int64 AgreementTypeID
        {
            get { return _AgreementTypeID; }
            set { _AgreementTypeID = value; }
        }

        [DataMember]
        public Decimal MoneyReceiptNo
        {
            get { return _MoneyReceiptNo; }
            set { _MoneyReceiptNo = value; }
        }

        [DataMember]
        public DateTime? ActualPaymentDate
        {
            get { return _ActualPaymentDate; }
            set { _ActualPaymentDate = value; }
        }

        [DataMember]
        public String PaymentDescription
        {
            get { return _PaymentDescription; }
            set { _PaymentDescription = value; }
        }

        [DataMember]
        public Decimal? InstallmentPaymentAmount
        {
            get { return _InstallmentPaymentAmount; }
            set { _InstallmentPaymentAmount = value; }
        }

        [DataMember]
        public String InstallmentPaymentInWord
        {
            get { return _InstallmentPaymentInWord; }
            set { _InstallmentPaymentInWord = value; }
        }

        [DataMember]
        public Decimal? InitialAmountInAgreement
        {
            get { return _InitialAmountInAgreement; }
            set { _InitialAmountInAgreement = value; }
        }

        [DataMember]
        public Decimal? OverDueAmount
        {
            get { return _OverDueAmount; }
            set { _OverDueAmount = value; }
        }

        [DataMember]
        public Decimal? DelayDayOnPayment
        {
            get { return _DelayDayOnPayment; }
            set { _DelayDayOnPayment = value; }
        }

        [DataMember]
        public Decimal? DelayDayOnOverDue
        {
            get { return _DelayDayOnOverDue; }
            set { _DelayDayOnOverDue = value; }
        }

        [DataMember]
        public Decimal? PaymentReceivedInBank
        {
            get { return _PaymentReceivedInBank; }
            set { _PaymentReceivedInBank = value; }
        }

        [DataMember]
        public String PaymentNotReceivedNote
        {
            get { return _PaymentNotReceivedNote; }
            set { _PaymentNotReceivedNote = value; }
        }

        [DataMember]
        public Int64 AgreementID
        {
            get { return _AgreementID; }
            set { _AgreementID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Boolean ReverseEntry
        {
            get { return _ReverseEntry; }
            set { _ReverseEntry = value; }
        }

        [DataMember]
        public Boolean LastPayment
        {
            get { return _LastPayment; }
            set { _LastPayment = value; }
        }

        [DataMember]
        public Decimal? DiscountAmount
        {
            get { return _DiscountAmount; }
            set { _DiscountAmount = value; }
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
        public Decimal? ServiceCharge
        {
            get { return _ServiceCharge; }
            set { _ServiceCharge = value; }
        }

        [DataMember]
        public Decimal? AdditionalFee
        {
            get { return _AdditionalFee; }
            set { _AdditionalFee = value; }
        }

        [DataMember]
        public Decimal? GrossAmount
        {
            get { return _GrossAmount; }
            set { _GrossAmount = value; }
        }

        [DataMember]
        public Decimal? NetAmount
        {
            get { return _NetAmount; }
            set { _NetAmount = value; }
        }

        [DataMember]
        public Int64 PaymentApprovalStatusID
        {
            get { return _PaymentApprovalStatusID; }
            set { _PaymentApprovalStatusID = value; }
        }

        [DataMember]
        public Int64 PaymentCategoryID
        {
            get { return _PaymentCategoryID; }
            set { _PaymentCategoryID = value; }
        }

        [DataMember]
        public String ExtraField
        {
            get { return _ExtraField; }
            set { _ExtraField = value; }
        }

        [DataMember]
        public String CashOrChequeNo
        {
            get { return _CashOrChequeNo; }
            set { _CashOrChequeNo = value; }
        }

        [DataMember]
        public DateTime? CashOrChequeDate
        {
            get { return _CashOrChequeDate; }
            set { _CashOrChequeDate = value; }
        }

        [DataMember]
        public String BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }

        [DataMember]
        public String BranchName
        {
            get { return _BranchName; }
            set { _BranchName = value; }
        }

        [DataMember]
        public Boolean ChequeInCashConfirmation
        {
            get { return _ChequeInCashConfirmation; }
            set { _ChequeInCashConfirmation = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public Int64 CreateByEmployeeID
        {
            get { return _CreateByEmployeeID; }
            set { _CreateByEmployeeID = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (PaymentCollectionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMPaymentCollectionEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PaymentCollectionID = "PaymentCollectionID";
        public const String FLD_NAME_PaymentScheduleMapID = "PaymentScheduleMapID";
        public const String FLD_NAME_PaymentScheduleID = "PaymentScheduleID";
        public const String FLD_NAME_AgreementTypeID = "AgreementTypeID";
        public const String FLD_NAME_MoneyReceiptNo = "MoneyReceiptNo";
        public const String FLD_NAME_ActualPaymentDate = "ActualPaymentDate";
        public const String FLD_NAME_PaymentDescription = "PaymentDescription";
        public const String FLD_NAME_InstallmentPaymentAmount = "InstallmentPaymentAmount";
        public const String FLD_NAME_InstallmentPaymentInWord = "InstallmentPaymentInWord";
        public const String FLD_NAME_InitialAmountInAgreement = "InitialAmountInAgreement";
        public const String FLD_NAME_OverDueAmount = "OverDueAmount";
        public const String FLD_NAME_DelayDayOnPayment = "DelayDayOnPayment";
        public const String FLD_NAME_DelayDayOnOverDue = "DelayDayOnOverDue";
        public const String FLD_NAME_PaymentReceivedInBank = "PaymentReceivedInBank";
        public const String FLD_NAME_PaymentNotReceivedNote = "PaymentNotReceivedNote";
        public const String FLD_NAME_AgreementID = "AgreementID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ReverseEntry = "ReverseEntry";
        public const String FLD_NAME_LastPayment = "LastPayment";
        public const String FLD_NAME_DiscountAmount = "DiscountAmount";
        public const String FLD_NAME_Vat = "Vat";
        public const String FLD_NAME_Tax = "Tax";
        public const String FLD_NAME_ServiceCharge = "ServiceCharge";
        public const String FLD_NAME_AdditionalFee = "AdditionalFee";
        public const String FLD_NAME_GrossAmount = "GrossAmount";
        public const String FLD_NAME_NetAmount = "NetAmount";
        public const String FLD_NAME_PaymentApprovalStatusID = "PaymentApprovalStatusID";
        public const String FLD_NAME_PaymentCategoryID = "PaymentCategoryID";
        public const String FLD_NAME_ExtraField = "ExtraField";
        public const String FLD_NAME_CashOrChequeNo = "CashOrChequeNo";
        public const String FLD_NAME_CashOrChequeDate = "CashOrChequeDate";
        public const String FLD_NAME_BankName = "BankName";
        public const String FLD_NAME_BranchName = "BranchName";
        public const String FLD_NAME_ChequeInCashConfirmation = "ChequeInCashConfirmation";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_CreateByEmployeeID = "CreateByEmployeeID";
        public const String FLD_NAME_IP = "IP";

        #endregion
    }
}
