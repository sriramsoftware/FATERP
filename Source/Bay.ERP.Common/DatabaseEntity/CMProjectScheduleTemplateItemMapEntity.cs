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
    [DataContract(Name = "CMProjectScheduleTemplateItemMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMProjectScheduleTemplateItemMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectScheduleTemplateItemMapID;
        private Int64 _ProjectScheduleTemplateID;
        private Int64 _ProjectScheduleItemID;
        private Int32? _NotifyBeforeMin;
        private Int64 _IssuePriorityID;
        private Decimal? _Duration;


        [DataMember]
        public Int64 ProjectScheduleTemplateItemMapID
        {
            get { return _ProjectScheduleTemplateItemMapID; }
            set { _ProjectScheduleTemplateItemMapID = value; }
        }

        [DataMember]
        public Int64 ProjectScheduleTemplateID
        {
            get { return _ProjectScheduleTemplateID; }
            set { _ProjectScheduleTemplateID = value; }
        }

        [DataMember]
        public Int64 ProjectScheduleItemID
        {
            get { return _ProjectScheduleItemID; }
            set { _ProjectScheduleItemID = value; }
        }

        [DataMember]
        public Int32? NotifyBeforeMin
        {
            get { return _NotifyBeforeMin; }
            set { _NotifyBeforeMin = value; }
        }

        [DataMember]
        public Int64 IssuePriorityID
        {
            get { return _IssuePriorityID; }
            set { _IssuePriorityID = value; }
        }

        [DataMember]
        public Decimal? Duration
        {
            get { return _Duration; }
            set { _Duration = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectScheduleTemplateItemMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMProjectScheduleTemplateItemMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectScheduleTemplateItemMapID = "ProjectScheduleTemplateItemMapID";
        public const String FLD_NAME_ProjectScheduleTemplateID = "ProjectScheduleTemplateID";
        public const String FLD_NAME_ProjectScheduleItemID = "ProjectScheduleItemID";
        public const String FLD_NAME_NotifyBeforeMin = "NotifyBeforeMin";
        public const String FLD_NAME_IssuePriorityID = "IssuePriorityID";
        public const String FLD_NAME_Duration = "Duration";

        #endregion
    }
}
