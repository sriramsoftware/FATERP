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
    [DataContract(Name = "ACBudget_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACBudget_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _BudgetID;
        private Int64 _FiscalYearID;
        private Int64 _AccountID;
        private DateTime _Period;
        private Decimal _Amount;
        private DateTime? _BeginDate;
        private DateTime? _EndDate;
        private DateTime? _ACFiscalYear;
        private String _AccountName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 BudgetID
        {
            get { return _BudgetID; }
            set { _BudgetID = value; }
        }

        [DataMember]
        public Int64 FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [DataMember]
        public Int64 AccountID
        {
            get { return _AccountID; }
            set { _AccountID = value; }
        }

        [DataMember]
        public DateTime Period
        {
            get { return _Period; }
            set { _Period = value; }
        }

        [DataMember]
        public Decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        [DataMember]
        public DateTime? BeginDate
        {
            get { return _BeginDate; }
            set { _BeginDate = value; }
        }

        [DataMember]
        public DateTime? EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        [DataMember]
        public DateTime? ACFiscalYear
        {
            get { return _ACFiscalYear; }
            set { _ACFiscalYear = value; }
        }

        [DataMember]
        public String AccountName
        {
            get { return _AccountName; }
            set { _AccountName = value; }
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
                return (BudgetID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACBudget_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BudgetID = "BudgetID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_AccountID = "AccountID";
        public const String FLD_NAME_Period = "Period";
        public const String FLD_NAME_Amount = "Amount";
        public const String FLD_NAME_BeginDate = "BeginDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_ACFiscalYear = "ACFiscalYear";
        public const String FLD_NAME_AccountName = "AccountName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
