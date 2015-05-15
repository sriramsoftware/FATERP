// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 01:14:46




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACCPrePayableStatementtoACCPostPayableStatementMigrate_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64? _POSTPAYABLESTATEMENTID;


        [DataMember]
        public Int64? POSTPAYABLESTATEMENTID
        {
            get { return _POSTPAYABLESTATEMENTID; }
            set { _POSTPAYABLESTATEMENTID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (POSTPAYABLESTATEMENTID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_POSTPAYABLESTATEMENTID = "POSTPAYABLESTATEMENTID";

        #endregion
    }
}
