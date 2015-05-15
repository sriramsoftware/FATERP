// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2013, 08:24:37




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMPaymentSchedule", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMPaymentScheduleEntity : BaseEntity
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
        private String _IP;
        private DateTime _CreateDate;


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
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
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

        public CRMPaymentScheduleEntity() : base()
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
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_CreateDate = "CreateDate";

        #endregion
    }
}
