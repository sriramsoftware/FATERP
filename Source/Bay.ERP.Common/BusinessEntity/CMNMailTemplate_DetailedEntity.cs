// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Nov-2013, 10:24:45




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMNMailTemplate_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMNMailTemplate_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _MailTemplateID;
        private Int64 _MailTemplateTypeID;
        private String _TemplateName;
        private String _Subject;
        private String _BodyMessage;
        private String _Signature;
        private Int64 _MailTextTypeID;
        private String _Remarks;
        private String _MailTextTypeName;
        private String _MailTemplateTypeName;


        [DataMember]
        public Int64 MailTemplateID
        {
            get { return _MailTemplateID; }
            set { _MailTemplateID = value; }
        }

        [DataMember]
        public Int64 MailTemplateTypeID
        {
            get { return _MailTemplateTypeID; }
            set { _MailTemplateTypeID = value; }
        }

        [DataMember]
        public String TemplateName
        {
            get { return _TemplateName; }
            set { _TemplateName = value; }
        }

        [DataMember]
        public String Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }

        [DataMember]
        public String BodyMessage
        {
            get { return _BodyMessage; }
            set { _BodyMessage = value; }
        }

        [DataMember]
        public String Signature
        {
            get { return _Signature; }
            set { _Signature = value; }
        }

        [DataMember]
        public Int64 MailTextTypeID
        {
            get { return _MailTextTypeID; }
            set { _MailTextTypeID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public String MailTextTypeName
        {
            get { return _MailTextTypeName; }
            set { _MailTextTypeName = value; }
        }

        [DataMember]
        public String MailTemplateTypeName
        {
            get { return _MailTemplateTypeName; }
            set { _MailTemplateTypeName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (MailTemplateID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMNMailTemplate_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MailTemplateID = "MailTemplateID";
        public const String FLD_NAME_MailTemplateTypeID = "MailTemplateTypeID";
        public const String FLD_NAME_TemplateName = "TemplateName";
        public const String FLD_NAME_Subject = "Subject";
        public const String FLD_NAME_BodyMessage = "BodyMessage";
        public const String FLD_NAME_Signature = "Signature";
        public const String FLD_NAME_MailTextTypeID = "MailTextTypeID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_MailTextTypeName = "MailTextTypeName";
        public const String FLD_NAME_MailTemplateTypeName = "MailTemplateTypeName";

        #endregion
    }
}
