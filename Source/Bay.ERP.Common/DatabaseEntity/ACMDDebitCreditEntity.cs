// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACMDDebitCredit", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACMDDebitCreditEntity : BaseEntity
    {
        #region Properties


        private Int64 _MDDebitCreditID;
        private String _Name;
        private Boolean _IsDebit;
        private Boolean _IsCredit;


        [DataMember]
        public Int64 MDDebitCreditID
        {
            get { return _MDDebitCreditID; }
            set { _MDDebitCreditID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public Boolean IsDebit
        {
            get { return _IsDebit; }
            set { _IsDebit = value; }
        }

        [DataMember]
        public Boolean IsCredit
        {
            get { return _IsCredit; }
            set { _IsCredit = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (MDDebitCreditID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACMDDebitCreditEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MDDebitCreditID = "MDDebitCreditID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_IsDebit = "IsDebit";
        public const String FLD_NAME_IsCredit = "IsCredit";

        #endregion
    }
}
