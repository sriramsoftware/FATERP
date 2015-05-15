// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDTaskTemplateItemMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDTaskTemplateItemMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _TaskTemplateItemMap;
        private Int64 _TaskTemplateID;
        private Int64 _TaskID;


        [DataMember]
        public Int64 TaskTemplateItemMap
        {
            get { return _TaskTemplateItemMap; }
            set { _TaskTemplateItemMap = value; }
        }

        [DataMember]
        public Int64 TaskTemplateID
        {
            get { return _TaskTemplateID; }
            set { _TaskTemplateID = value; }
        }

        [DataMember]
        public Int64 TaskID
        {
            get { return _TaskID; }
            set { _TaskID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (TaskTemplateItemMap <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDTaskTemplateItemMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TaskTemplateItemMap = "TaskTemplateItemMap";
        public const String FLD_NAME_TaskTemplateID = "TaskTemplateID";
        public const String FLD_NAME_TaskID = "TaskID";

        #endregion
    }
}
