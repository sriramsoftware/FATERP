// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 04:44:22




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACCurrencyExchangeRates_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACCurrencyExchangeRates_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _CurrencyExchangeRatesID;
        private Int64 _CurrencyID;
        private Int64 _StandardCurrencyID;
        private Decimal _ExchangeRate;
        private DateTime _DateUsedFrom;
        private DateTime? _DateUsedUpTo;
        private Boolean _IsCurrent;
        private String _CurrencyName;
        private String _StandardCurrencyName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 CurrencyExchangeRatesID
        {
            get { return _CurrencyExchangeRatesID; }
            set { _CurrencyExchangeRatesID = value; }
        }

        [DataMember]
        public Int64 CurrencyID
        {
            get { return _CurrencyID; }
            set { _CurrencyID = value; }
        }

        [DataMember]
        public Int64 StandardCurrencyID
        {
            get { return _StandardCurrencyID; }
            set { _StandardCurrencyID = value; }
        }

        [DataMember]
        public Decimal ExchangeRate
        {
            get { return _ExchangeRate; }
            set { _ExchangeRate = value; }
        }

        [DataMember]
        public DateTime DateUsedFrom
        {
            get { return _DateUsedFrom; }
            set { _DateUsedFrom = value; }
        }

        [DataMember]
        public DateTime? DateUsedUpTo
        {
            get { return _DateUsedUpTo; }
            set { _DateUsedUpTo = value; }
        }

        [DataMember]
        public Boolean IsCurrent
        {
            get { return _IsCurrent; }
            set { _IsCurrent = value; }
        }

        [DataMember]
        public String CurrencyName
        {
            get { return _CurrencyName; }
            set { _CurrencyName = value; }
        }

        [DataMember]
        public String StandardCurrencyName
        {
            get { return _StandardCurrencyName; }
            set { _StandardCurrencyName = value; }
        }

        [DataMember]
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (CurrencyExchangeRatesID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACCurrencyExchangeRates_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_CurrencyExchangeRatesID = "CurrencyExchangeRatesID";
        public const String FLD_NAME_CurrencyID = "CurrencyID";
        public const String FLD_NAME_StandardCurrencyID = "StandardCurrencyID";
        public const String FLD_NAME_ExchangeRate = "ExchangeRate";
        public const String FLD_NAME_DateUsedFrom = "DateUsedFrom";
        public const String FLD_NAME_DateUsedUpTo = "DateUsedUpTo";
        public const String FLD_NAME_IsCurrent = "IsCurrent";
        public const String FLD_NAME_CurrencyName = "CurrencyName";
        public const String FLD_NAME_StandardCurrencyName = "StandardCurrencyName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
