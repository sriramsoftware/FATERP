// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Dec-2013, 03:44:05




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMPaymentSchedule_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMPaymentSchedule_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _PaymentScheduleID;
        private Int64 _BuyerBookSpaceID;
        private DateTime _HandoverDate;
        private DateTime? _ActualHandoverDate;
        private String _ProjectCode;
        private Int64 _BuyerBasicInfoID;
        private Decimal? _TotalAgreementAmount;
        private Decimal? _EarnestMoney;
        private Decimal? _Reservation;
        private Decimal? _CommonService;
        private Decimal? _UtilityConnectionCost;
        private Decimal? _ReservedFund;
        private Decimal? _TotalInstallment;
        private String _Remarks;
        private Int64 _CreateByEmployeeID;
        private DateTime _CreateDate;
        private Int64? _ProjectID;
        private Int64 _ProjectFloorUnitID;
        private String _BookingNote;
        private String _ImageUrl;
        private String _BDProjectCode;
        private String _ProjectName;
        private String _ProjectFloorUnitName;
        private Int64? _LinkPaymentScheduleMapID;
        private String _InstallmentName;
        private DateTime? _InstallmentDueDate;
        private DateTime? _InstallmentDueDateNew;
        private Decimal? _AgreementAAmount;
        private Decimal? _AgreementBAmount;
        private Decimal? _AgreementCAmount;
        private Decimal? _AgreementDAmount;
        private Decimal? _AgreementEAmount;
        private DateTime? _PaymentDueDate;
        private Boolean _FinalPayment;
        private DateTime? _PaymentScheduleMapCreateDate;
        private String _ContactFullName;


        [DataMember]
        public Int64 PaymentScheduleID
        {
            get { return _PaymentScheduleID; }
            set { _PaymentScheduleID = value; }
        }

        [DataMember]
        public Int64 BuyerBookSpaceID
        {
            get { return _BuyerBookSpaceID; }
            set { _BuyerBookSpaceID = value; }
        }

        [DataMember]
        public DateTime HandoverDate
        {
            get { return _HandoverDate; }
            set { _HandoverDate = value; }
        }

        [DataMember]
        public DateTime? ActualHandoverDate
        {
            get { return _ActualHandoverDate; }
            set { _ActualHandoverDate = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public Int64 BuyerBasicInfoID
        {
            get { return _BuyerBasicInfoID; }
            set { _BuyerBasicInfoID = value; }
        }

        [DataMember]
        public Decimal? TotalAgreementAmount
        {
            get { return _TotalAgreementAmount; }
            set { _TotalAgreementAmount = value; }
        }

        [DataMember]
        public Decimal? EarnestMoney
        {
            get { return _EarnestMoney; }
            set { _EarnestMoney = value; }
        }

        [DataMember]
        public Decimal? Reservation
        {
            get { return _Reservation; }
            set { _Reservation = value; }
        }

        [DataMember]
        public Decimal? CommonService
        {
            get { return _CommonService; }
            set { _CommonService = value; }
        }

        [DataMember]
        public Decimal? UtilityConnectionCost
        {
            get { return _UtilityConnectionCost; }
            set { _UtilityConnectionCost = value; }
        }

        [DataMember]
        public Decimal? ReservedFund
        {
            get { return _ReservedFund; }
            set { _ReservedFund = value; }
        }

        [DataMember]
        public Decimal? TotalInstallment
        {
            get { return _TotalInstallment; }
            set { _TotalInstallment = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 CreateByEmployeeID
        {
            get { return _CreateByEmployeeID; }
            set { _CreateByEmployeeID = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public String BookingNote
        {
            get { return _BookingNote; }
            set { _BookingNote = value; }
        }

        [DataMember]
        public String ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }

        [DataMember]
        public String BDProjectCode
        {
            get { return _BDProjectCode; }
            set { _BDProjectCode = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
        }

        [DataMember]
        public Int64? LinkPaymentScheduleMapID
        {
            get { return _LinkPaymentScheduleMapID; }
            set { _LinkPaymentScheduleMapID = value; }
        }

        [DataMember]
        public String InstallmentName
        {
            get { return _InstallmentName; }
            set { _InstallmentName = value; }
        }

        [DataMember]
        public DateTime? InstallmentDueDate
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
        public DateTime? PaymentScheduleMapCreateDate
        {
            get { return _PaymentScheduleMapCreateDate; }
            set { _PaymentScheduleMapCreateDate = value; }
        }

        [DataMember]
        public String ContactFullName
        {
            get { return _ContactFullName; }
            set { _ContactFullName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (PaymentScheduleID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMPaymentSchedule_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_PaymentScheduleID = "PaymentScheduleID";
        public const String FLD_NAME_BuyerBookSpaceID = "BuyerBookSpaceID";
        public const String FLD_NAME_HandoverDate = "HandoverDate";
        public const String FLD_NAME_ActualHandoverDate = "ActualHandoverDate";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_BuyerBasicInfoID = "BuyerBasicInfoID";
        public const String FLD_NAME_TotalAgreementAmount = "TotalAgreementAmount";
        public const String FLD_NAME_EarnestMoney = "EarnestMoney";
        public const String FLD_NAME_Reservation = "Reservation";
        public const String FLD_NAME_CommonService = "CommonService";
        public const String FLD_NAME_UtilityConnectionCost = "UtilityConnectionCost";
        public const String FLD_NAME_ReservedFund = "ReservedFund";
        public const String FLD_NAME_TotalInstallment = "TotalInstallment";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreateByEmployeeID = "CreateByEmployeeID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_BookingNote = "BookingNote";
        public const String FLD_NAME_ImageUrl = "ImageUrl";
        public const String FLD_NAME_BDProjectCode = "BDProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_LinkPaymentScheduleMapID = "LinkPaymentScheduleMapID";
        public const String FLD_NAME_InstallmentName = "InstallmentName";
        public const String FLD_NAME_InstallmentDueDate = "InstallmentDueDate";
        public const String FLD_NAME_InstallmentDueDateNew = "InstallmentDueDateNew";
        public const String FLD_NAME_AgreementAAmount = "AgreementAAmount";
        public const String FLD_NAME_AgreementBAmount = "AgreementBAmount";
        public const String FLD_NAME_AgreementCAmount = "AgreementCAmount";
        public const String FLD_NAME_AgreementDAmount = "AgreementDAmount";
        public const String FLD_NAME_AgreementEAmount = "AgreementEAmount";
        public const String FLD_NAME_PaymentDueDate = "PaymentDueDate";
        public const String FLD_NAME_FinalPayment = "FinalPayment";
        public const String FLD_NAME_PaymentScheduleMapCreateDate = "PaymentScheduleMapCreateDate";
        public const String FLD_NAME_ContactFullName = "ContactFullName";

        #endregion
    }
}
