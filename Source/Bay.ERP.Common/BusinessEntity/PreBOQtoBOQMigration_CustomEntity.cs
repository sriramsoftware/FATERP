// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-May-2012, 04:28:13




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PreBOQtoBOQMigration_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PreBOQtoBOQMigration_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64? _BOQID;


        [DataMember]
        public Int64? BOQID
        {
            get { return _BOQID; }
            set { _BOQID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BOQID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PreBOQtoBOQMigration_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BOQID = "BOQID";

        #endregion
    }
}
