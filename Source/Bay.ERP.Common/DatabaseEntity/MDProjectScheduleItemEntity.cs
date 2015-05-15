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
    [DataContract(Name = "MDProjectScheduleItem", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDProjectScheduleItemEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectScheduleItemID;
        private Int64? _ParentProjectScheduleItemID;
        private String _Title;
        private String _Description;
        private Int64 _IssuePriorityID;
        private Decimal? _Duration;
        private Int32? _NotifyBeforeMin;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ProjectScheduleItemID
        {
            get { return _ProjectScheduleItemID; }
            set { _ProjectScheduleItemID = value; }
        }

        [DataMember]
        public Int64? ParentProjectScheduleItemID
        {
            get { return _ParentProjectScheduleItemID; }
            set { _ParentProjectScheduleItemID = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
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

        [DataMember]
        public Int32? NotifyBeforeMin
        {
            get { return _NotifyBeforeMin; }
            set { _NotifyBeforeMin = value; }
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
                return (ProjectScheduleItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDProjectScheduleItemEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectScheduleItemID = "ProjectScheduleItemID";
        public const String FLD_NAME_ParentProjectScheduleItemID = "ParentProjectScheduleItemID";
        public const String FLD_NAME_Title = "Title";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IssuePriorityID = "IssuePriorityID";
        public const String FLD_NAME_Duration = "Duration";
        public const String FLD_NAME_NotifyBeforeMin = "NotifyBeforeMin";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
