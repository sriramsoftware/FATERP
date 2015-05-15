// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMProjectScheduleTemplate", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMProjectScheduleTemplateEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectScheduleTemplateID;
        private String _TemplateName;
        private String _Description;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ProjectScheduleTemplateID
        {
            get { return _ProjectScheduleTemplateID; }
            set { _ProjectScheduleTemplateID = value; }
        }

        [DataMember]
        public String TemplateName
        {
            get { return _TemplateName; }
            set { _TemplateName = value; }
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
                return (ProjectScheduleTemplateID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMProjectScheduleTemplateEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectScheduleTemplateID = "ProjectScheduleTemplateID";
        public const String FLD_NAME_TemplateName = "TemplateName";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
