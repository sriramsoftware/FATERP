// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectDocumentTemplateMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectDocumentTemplateMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectDocumentTemplateMapID;
        private Int64 _ProjectDocumentTemplateID;
        private Int64 _ProjectDocumentID;


        [DataMember]
        public Int64 ProjectDocumentTemplateMapID
        {
            get { return _ProjectDocumentTemplateMapID; }
            set { _ProjectDocumentTemplateMapID = value; }
        }

        [DataMember]
        public Int64 ProjectDocumentTemplateID
        {
            get { return _ProjectDocumentTemplateID; }
            set { _ProjectDocumentTemplateID = value; }
        }

        [DataMember]
        public Int64 ProjectDocumentID
        {
            get { return _ProjectDocumentID; }
            set { _ProjectDocumentID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectDocumentTemplateMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectDocumentTemplateMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectDocumentTemplateMapID = "ProjectDocumentTemplateMapID";
        public const String FLD_NAME_ProjectDocumentTemplateID = "ProjectDocumentTemplateID";
        public const String FLD_NAME_ProjectDocumentID = "ProjectDocumentID";

        #endregion
    }
}
