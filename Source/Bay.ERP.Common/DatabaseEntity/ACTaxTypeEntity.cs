// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACTaxType", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACTaxTypeEntity : BaseEntity
    {
        #region Properties


        private Int64 _TaxTypeID;
        private String _Name;
        private Decimal _Rate;
        private String _Description;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 TaxTypeID
        {
            get { return _TaxTypeID; }
            set { _TaxTypeID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public Decimal Rate
        {
            get { return _Rate; }
            set { _Rate = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (TaxTypeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACTaxTypeEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TaxTypeID = "TaxTypeID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Rate = "Rate";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
