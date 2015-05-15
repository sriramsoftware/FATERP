// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-May-2013, 10:12:36




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMPaymentScheduleMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMPaymentScheduleMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _PaymentScheduleMapID;
        private Int64? _LinkPaymentScheduleMapID;
        private Int64 _PaymentScheduleID;
        private String _InstallmentName;
        private DateTime _InstallmentDueDate;
        private DateTime? _InstallmentDueDateNew;
        private Int64? _AgreementID;
        private Decimal? _AgreementAAmount;
        private Decimal? _AgreementBAmount;
        private Decimal? _AgreementCAmount;
        private Decimal? _AgreementDAmount;
        private Decimal? _AgreementEAmount;
        private DateTime? _PaymentDueDate;
        private Boolean _FinalPayment;
        private Boolean _Revised;
        private String _RevisedIP;
        private Int64? _LastRevisedByEmployeeID;
        private DateTime? _LastRevisedDate;
        private String _Remarks;
        private DateTime _CreateDate;
        private Int64 _CreateByEmployeeID;
        private String _IP;


        [DataMember]
        public Int64 PaymentScheduleMapID
        {
            get { return _PaymentScheduleMapID; }
            set { _PaymentScheduleMapID = value; }
        }

        [DataMember]
        public Int64? LinkPaymentScheduleMapID
        {
            get { return _LinkPaymentScheduleMapID; }
            set { _LinkPaymentScheduleMapID = value; }
        }

        [DataMember]
        public Int64 PaymentScheduleID
        {
            get { return _PaymentScheduleID; }
            set { _PaymentScheduleID = value; }
        }

        [DataMember]
        public String InstallmentName
        {
            get { return _InstallmentName; }
            set { _InstallmentName = value; }
        }

        [DataMember]
        public DateTime InstallmentDueDate
        {
            get { return _InstallmentDueDate; }
            set { _InstallmentDueDate = value; }
        }

        [DataMember]
        public DateTime? InstallmentDueDateNew
        {
            get { return _InstallmentDueDateNew; }
            set { _InstallmentDueDateNew = value; }
        }

        [DataMember]
        public Int64? AgreementID
        {
            get { return _AgreementID; }
            set { _AgreementID = value; }
        }

        [DataMember]
        public Decimal? AgreementAAmount
        {
            get { return _AgreementAAmount; }
            set { _AgreementAAmount = value; }
        }

        [DataMember]
        public Decimal? AgreementBAmount
        {
            get { return _AgreementBAmount; }
            set { _AgreementBAmount = value; }
        }

        [DataMember]
        public Decimal? AgreementCAmount
        {
            get { return _AgreementCAmount; }
            set { _AgreementCAmount = value; }
        }

        [DataMember]
        public Decimal? AgreementDAmount
        {
            get { return _AgreementDAmount; }
            set { _AgreementDAmount = value; }
        }

        [DataMember]
        public Decimal? AgreementEAmount
        {
            get { return _AgreementEAmount; }
            set { _AgreementEAmount = value; }
        }

        [DataMember]
        public DateTime? PaymentDueDate
        {
            get { return _PaymentDueDate; }
            set { _PaymentDueDate = value; }
        }

        [DataMember]
        public Boolean FinalPayment
        {
            get { return _FinalPayment; }
            set { _FinalPayment = value; }
        }

        [DataMember]
        public Boolean Revised
        {
            get { return _Revised; }
            set { _Revised = value; }
        }

        [DataMember]
        public String RevisedIP
        {
            get { return _RevisedIP; }
            set { _RevisedIP = value; }
        }

        [DataMember]
        public Int64? LastRevisedByEmployeeID
        {
            get { return _LastRevisedByEmployeeID; }
            set { _LastRevisedByEmployeeID = value; }
        }

        [DataMember]
        public DateTime? LastRevisedDate
        {
            get { return _LastRevisedDate; }
            set { _LastRevisedDate = value; }
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
                return (PaymentScheduleMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMPaymentScheduleMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PaymentScheduleMapID = "PaymentScheduleMapID";
        public const String FLD_NAME_LinkPaymentScheduleMapID = "LinkPaymentScheduleMapID";
        public const String FLD_NAME_PaymentScheduleID = "PaymentScheduleID";
        public const String FLD_NAME_InstallmentName = "InstallmentName";
        public const String FLD_NAME_InstallmentDueDate = "InstallmentDueDate";
        public const String FLD_NAME_InstallmentDueDateNew = "InstallmentDueDateNew";
        public const String FLD_NAME_AgreementID = "AgreementID";
        public const String FLD_NAME_AgreementAAmount = "AgreementAAmount";
        public const String FLD_NAME_AgreementBAmount = "AgreementBAmount";
        public const String FLD_NAME_AgreementCAmount = "AgreementCAmount";
        public const String FLD_NAME_AgreementDAmount = "AgreementDAmount";
        public const String FLD_NAME_AgreementEAmount = "AgreementEAmount";
        public const String FLD_NAME_PaymentDueDate = "PaymentDueDate";
        public const String FLD_NAME_FinalPayment = "FinalPayment";
        public const String FLD_NAME_Revised = "Revised";
        public const String FLD_NAME_RevisedIP = "RevisedIP";
        public const String FLD_NAME_LastRevisedByEmployeeID = "LastRevisedByEmployeeID";
        public const String FLD_NAME_LastRevisedDate = "LastRevisedDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_CreateByEmployeeID = "CreateByEmployeeID";
        public const String FLD_NAME_IP = "IP";

        #endregion
    }
}