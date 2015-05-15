// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACPettyCash", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACPettyCashEntity : BaseEntity
    {
        #region Properties


        private Int64 _ACPettyCashID;
        private Decimal _CurrentBalance;


        [DataMember]
        public Int64 ACPettyCashID
        {
            get { return _ACPettyCashID; }
            set { _ACPettyCashID = value; }
        }

        [DataMember]
        public Decimal CurrentBalance
        {
            get { return _CurrentBalance; }
            set { _CurrentBalance = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ACPettyCashID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACPettyCashEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ACPettyCashID = "ACPettyCashID";
        public const String FLD_NAME_CurrentBalance = "CurrentBalance";

        #endregion
    }
}
