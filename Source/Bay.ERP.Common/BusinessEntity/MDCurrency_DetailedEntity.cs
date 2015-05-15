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
    [DataContract(Name = "MDCurrency_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDCurrency_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _CurrencyID;
        private String _Abbreviation;
        private String _Symbol;
        private String _CurrencyName;
        private String _HundredthsName;
        private Int64 _CountryID;
        private Boolean _IsStandardCurrency;
        private Boolean _IsRemoved;
        private String _CountryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 CurrencyID
        {
            get { return _CurrencyID; }
            set { _CurrencyID = value; }
        }

        [DataMember]
        public String Abbreviation
        {
            get { return _Abbreviation; }
            set { _Abbreviation = value; }
        }

        [DataMember]
        public String Symbol
        {
            get { return _Symbol; }
            set { _Symbol = value; }
        }

        [DataMember]
        public String CurrencyName
        {
            get { return _CurrencyName; }
            set { _CurrencyName = value; }
        }

        [DataMember]
        public String HundredthsName
        {
            get { return _HundredthsName; }
            set { _HundredthsName = value; }
        }

        [DataMember]
        public Int64 CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public Boolean IsStandardCurrency
        {
            get { return _IsStandardCurrency; }
            set { _IsStandardCurrency = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
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
                return (CurrencyID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDCurrency_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_CurrencyID = "CurrencyID";
        public const String FLD_NAME_Abbreviation = "Abbreviation";
        public const String FLD_NAME_Symbol = "Symbol";
        public const String FLD_NAME_CurrencyName = "CurrencyName";
        public const String FLD_NAME_HundredthsName = "HundredthsName";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_IsStandardCurrency = "IsStandardCurrency";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_CountryName = "CountryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
