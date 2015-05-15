// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 09:29:16




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACBankAccountTransfer", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACBankAccountTransferEntity : BaseEntity
    {
        #region Properties


        private Int64 _BankAccountTransferID;
        private Int64 _FromBankAccountID;
        private Int64 _ToBankAccountID;
        private DateTime _TransferDate;
        private Decimal _Amount;
        private Decimal? _BankCharge;
        private String _Memo;
        private String _Remarks;
        private Int64 _BankAccountTransferApprovalStatusID;
        private Int64 _CreatedByEmployeeID;


        [DataMember]
        public Int64 BankAccountTransferID
        {
            get { return _BankAccountTransferID; }
            set { _BankAccountTransferID = value; }
        }

        [DataMember]
        public Int64 FromBankAccountID
        {
            get { return _FromBankAccountID; }
            set { _FromBankAccountID = value; }
        }

        [DataMember]
        public Int64 ToBankAccountID
        {
            get { return _ToBankAccountID; }
            set { _ToBankAccountID = value; }
        }

        [DataMember]
        public DateTime TransferDate
        {
            get { return _TransferDate; }
            set { _TransferDate = value; }
        }

        [DataMember]
        public Decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        [DataMember]
        public Decimal? BankCharge
        {
            get { return _BankCharge; }
            set { _BankCharge = value; }
        }

        [DataMember]
        public String Memo
        {
            get { return _Memo; }
            set { _Memo = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 BankAccountTransferApprovalStatusID
        {
            get { return _BankAccountTransferApprovalStatusID; }
            set { _BankAccountTransferApprovalStatusID = value; }
        }

        [DataMember]
        public Int64 CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BankAccountTransferID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACBankAccountTransferEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BankAccountTransferID = "BankAccountTransferID";
        public const String FLD_NAME_FromBankAccountID = "FromBankAccountID";
        public const String FLD_NAME_ToBankAccountID = "ToBankAccountID";
        public const String FLD_NAME_TransferDate = "TransferDate";
        public const String FLD_NAME_Amount = "Amount";
        public const String FLD_NAME_BankCharge = "BankCharge";
        public const String FLD_NAME_Memo = "Memo";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_BankAccountTransferApprovalStatusID = "BankAccountTransferApprovalStatusID";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";

        #endregion
    }
}
