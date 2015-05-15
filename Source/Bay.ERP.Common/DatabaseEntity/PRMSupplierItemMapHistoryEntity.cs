// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMSupplierItemMapHistory", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMSupplierItemMapHistoryEntity : BaseEntity
    {
        #region Properties


        private Int64 _SupplierItemMapHistoryID;
        private Int64 _SupplierItemMapID;
        private Decimal _ActualPrice;
        private Decimal _DiscountPercentage;
        private Decimal _Price;
        private DateTime _EntryDate;


        [DataMember]
        public Int64 SupplierItemMapHistoryID
        {
            get { return _SupplierItemMapHistoryID; }
            set { _SupplierItemMapHistoryID = value; }
        }

        [DataMember]
        public Int64 SupplierItemMapID
        {
            get { return _SupplierItemMapID; }
            set { _SupplierItemMapID = value; }
        }

        [DataMember]
        public Decimal ActualPrice
        {
            get { return _ActualPrice; }
            set { _ActualPrice = value; }
        }

        [DataMember]
        public Decimal DiscountPercentage
        {
            get { return _DiscountPercentage; }
            set { _DiscountPercentage = value; }
        }

        [DataMember]
        public Decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        [DataMember]
        public DateTime EntryDate
        {
            get { return _EntryDate; }
            set { _EntryDate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SupplierItemMapHistoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMSupplierItemMapHistoryEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SupplierItemMapHistoryID = "SupplierItemMapHistoryID";
        public const String FLD_NAME_SupplierItemMapID = "SupplierItemMapID";
        public const String FLD_NAME_ActualPrice = "ActualPrice";
        public const String FLD_NAME_DiscountPercentage = "DiscountPercentage";
        public const String FLD_NAME_Price = "Price";
        public const String FLD_NAME_EntryDate = "EntryDate";

        #endregion
    }
}
