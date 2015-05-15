// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jun-2013, 02:33:32




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMCustomerPortfolioSummary_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMCustomerPortfolioSummary_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _BuyerBasicInfoID;
        private Int64? _ProjectFloorUnitID;
        private Int64 _AgreementTypeID;
        private Decimal? _TotalAgreementAmount;
        private Decimal? _TotalReceivableAmountWithFees;
        private Decimal? _TotalReceivableAgreementAAmount;
        private Decimal? _TotalReceivableAgreementBAmount;
        private Decimal? _TotalReceivableAgreementCAmount;
        private Decimal? _TotalReceivedAmount;
        private Decimal? _TotalOverDueAmount;


        [DataMember]
        public Int64 BuyerBasicInfoID
        {
            get { return _BuyerBasicInfoID; }
            set { _BuyerBasicInfoID = value; }
        }

        [DataMember]
        public Int64? ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public Int64 AgreementTypeID
        {
            get { return _AgreementTypeID; }
            set { _AgreementTypeID = value; }
        }

        [DataMember]
        public Decimal? TotalAgreementAmount
        {
            get { return _TotalAgreementAmount; }
            set { _TotalAgreementAmount = value; }
        }

        [DataMember]
        public Decimal? TotalReceivableAmountWithFees
        {
            get { return _TotalReceivableAmountWithFees; }
            set { _TotalReceivableAmountWithFees = value; }
        }

        [DataMember]
        public Decimal? TotalReceivableAgreementAAmount
        {
            get { return _TotalReceivableAgreementAAmount; }
            set { _TotalReceivableAgreementAAmount = value; }
        }

        [DataMember]
        public Decimal? TotalReceivableAgreementBAmount
        {
            get { return _TotalReceivableAgreementBAmount; }
            set { _TotalReceivableAgreementBAmount = value; }
        }

        [DataMember]
        public Decimal? TotalReceivableAgreementCAmount
        {
            get { return _TotalReceivableAgreementCAmount; }
            set { _TotalReceivableAgreementCAmount = value; }
        }

        [DataMember]
        public Decimal? TotalReceivedAmount
        {
            get { return _TotalReceivedAmount; }
            set { _TotalReceivedAmount = value; }
        }

        [DataMember]
        public Decimal? TotalOverDueAmount
        {
            get { return _TotalOverDueAmount; }
            set { _TotalOverDueAmount = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BuyerBasicInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMCustomerPortfolioSummary_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BuyerBasicInfoID = "BuyerBasicInfoID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_AgreementTypeID = "AgreementTypeID";
        public const String FLD_NAME_TotalAgreementAmount = "TotalAgreementAmount";
        public const String FLD_NAME_TotalReceivableAmountWithFees = "TotalReceivableAmountWithFees";
        public const String FLD_NAME_TotalReceivableAgreementAAmount = "TotalReceivableAgreementAAmount";
        public const String FLD_NAME_TotalReceivableAgreementBAmount = "TotalReceivableAgreementBAmount";
        public const String FLD_NAME_TotalReceivableAgreementCAmount = "TotalReceivableAgreementCAmount";
        public const String FLD_NAME_TotalReceivedAmount = "TotalReceivedAmount";
        public const String FLD_NAME_TotalOverDueAmount = "TotalOverDueAmount";

        #endregion
    }
}
