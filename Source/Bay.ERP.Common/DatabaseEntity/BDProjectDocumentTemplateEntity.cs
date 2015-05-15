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
    [DataContract(Name = "BDProjectDocumentTemplate", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectDocumentTemplateEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectDocumentTemplateID;
        private String _TemplateName;
        private String _Remarks;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ProjectDocumentTemplateID
        {
            get { return _ProjectDocumentTemplateID; }
            set { _ProjectDocumentTemplateID = value; }
        }

        [DataMember]
        public String TemplateName
        {
            get { return _TemplateName; }
            set { _TemplateName = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
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
                return (ProjectDocumentTemplateID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectDocumentTemplateEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectDocumentTemplateID = "ProjectDocumentTemplateID";
        public const String FLD_NAME_TemplateName = "TemplateName";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
