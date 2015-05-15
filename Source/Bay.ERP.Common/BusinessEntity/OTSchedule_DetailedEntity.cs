// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2011, 05:48:38




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "OTSchedule_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class OTSchedule_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ScheduleID;
        private Int64 _ScheduleIdentityCategoryID;
        private Int64 _ScheduleCategoryID;
        private Int64? _ReferenceID;
        private String _Title;
        private String _Description;
        private Int64 _SchedulePriorityID;
        private Int64 _CreatedByMemberID;
        private DateTime? _CreateDate;
        private Decimal? _Duration;
        private DateTime? _StartDateTime;
        private DateTime? _EndDateTime;
        private Int32? _NotifyBeforeMin;
        private Boolean _IsNotifyCompleted;
        private String _Remarks;
        private Int64? _ReferenceScheduleID;
        private Boolean _IsRescheduled;
        private Boolean _IsRemoved;
        private String _ScheduleIdentityCategoryName;
        private String _ScheduleCategoryName;
        private String _SchedulePriorityName;
        private String _MemberFullName;
        private Int64 _ScheduleScheduleIdentityCategoryID;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ScheduleID
        {
            get { return _ScheduleID; }
            set { _ScheduleID = value; }
        }

        [DataMember]
        public Int64 ScheduleIdentityCategoryID
        {
            get { return _ScheduleIdentityCategoryID; }
            set { _ScheduleIdentityCategoryID = value; }
        }

        [DataMember]
        public Int64 ScheduleCategoryID
        {
            get { return _ScheduleCategoryID; }
            set { _ScheduleCategoryID = value; }
        }

        [DataMember]
        public Int64? ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
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
        public Int64 SchedulePriorityID
        {
            get { return _SchedulePriorityID; }
            set { _SchedulePriorityID = value; }
        }

        [DataMember]
        public Int64 CreatedByMemberID
        {
            get { return _CreatedByMemberID; }
            set { _CreatedByMemberID = value; }
        }

        [DataMember]
        public DateTime? CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public Decimal? Duration
        {
            get { return _Duration; }
            set { _Duration = value; }
        }

        [DataMember]
        public DateTime? StartDateTime
        {
            get { return _StartDateTime; }
            set { _StartDateTime = value; }
        }

        [DataMember]
        public DateTime? EndDateTime
        {
            get { return _EndDateTime; }
            set { _EndDateTime = value; }
        }

        [DataMember]
        public Int32? NotifyBeforeMin
        {
            get { return _NotifyBeforeMin; }
            set { _NotifyBeforeMin = value; }
        }

        [DataMember]
        public Boolean IsNotifyCompleted
        {
            get { return _IsNotifyCompleted; }
            set { _IsNotifyCompleted = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64? ReferenceScheduleID
        {
            get { return _ReferenceScheduleID; }
            set { _ReferenceScheduleID = value; }
        }

        [DataMember]
        public Boolean IsRescheduled
        {
            get { return _IsRescheduled; }
            set { _IsRescheduled = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String ScheduleIdentityCategoryName
        {
            get { return _ScheduleIdentityCategoryName; }
            set { _ScheduleIdentityCategoryName = value; }
        }

        [DataMember]
        public String ScheduleCategoryName
        {
            get { return _ScheduleCategoryName; }
            set { _ScheduleCategoryName = value; }
        }

        [DataMember]
        public String SchedulePriorityName
        {
            get { return _SchedulePriorityName; }
            set { _SchedulePriorityName = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public Int64 ScheduleScheduleIdentityCategoryID
        {
            get { return _ScheduleScheduleIdentityCategoryID; }
            set { _ScheduleScheduleIdentityCategoryID = value; }
        }

        [DataMember]
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ScheduleID <= 0);
            }
        }


        #endregion

        #region Constructor

        public OTSchedule_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ScheduleID = "ScheduleID";
        public const String FLD_NAME_ScheduleIdentityCategoryID = "ScheduleIdentityCategoryID";
        public const String FLD_NAME_ScheduleCategoryID = "ScheduleCategoryID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_Title = "Title";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_SchedulePriorityID = "SchedulePriorityID";
        public const String FLD_NAME_CreatedByMemberID = "CreatedByMemberID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_Duration = "Duration";
        public const String FLD_NAME_StartDateTime = "StartDateTime";
        public const String FLD_NAME_EndDateTime = "EndDateTime";
        public const String FLD_NAME_NotifyBeforeMin = "NotifyBeforeMin";
        public const String FLD_NAME_IsNotifyCompleted = "IsNotifyCompleted";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_ReferenceScheduleID = "ReferenceScheduleID";
        public const String FLD_NAME_IsRescheduled = "IsRescheduled";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_ScheduleIdentityCategoryName = "ScheduleIdentityCategoryName";
        public const String FLD_NAME_ScheduleCategoryName = "ScheduleCategoryName";
        public const String FLD_NAME_SchedulePriorityName = "SchedulePriorityName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_ScheduleScheduleIdentityCategoryID = "ScheduleScheduleIdentityCategoryID";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
