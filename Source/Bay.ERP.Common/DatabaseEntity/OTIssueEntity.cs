// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Aug-2013, 04:20:37




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "OTIssue", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class OTIssueEntity : BaseEntity
    {
        #region Properties


        private Int64 _IssueID;
        private Int64 _IssueIdentityCategoryID;
        private Int64 _IssueCategoryID;
        private Int64? _ParentIssueID;
        private Int64? _ReferenceID;
        private String _Title;
        private String _Description;
        private Int64 _IssuePriorityID;
        private Decimal? _CompletionPercentage;
        private Int64 _IssueStatusID;
        private Int64 _CreatedByMemberID;
        private DateTime? _CreateDate;
        private Decimal? _Duration;
        private DateTime? _ExpectedStartDate;
        private DateTime? _ExpectedEndDate;
        private DateTime? _ActualStartDate;
        private DateTime? _ActualEndDate;
        private Int32? _NotifyBeforeMin;
        private Boolean _IsNotifyCompleted;
        private Int64 _SupervisorEmployeeID;
        private Int64 _AssignedToEmployeeID;
        private String _Remarks;
        private Int64? _ReferenceIssueID;
        private Boolean _IsRemoved;
        private Boolean _SupervisorAgreed;
        private DateTime _ModifiedBySupervisorDateTime;
        private String _IP;
        private String _DTLDuration;
        private Int64? _ProjectID;
        private Int64? _ProjectFloorID;
        private Int64? _ProjectFloorUnitID;
        private Int64? _ProjectFloorUnitLocationID;


        [DataMember]
        public Int64 IssueID
        {
            get { return _IssueID; }
            set { _IssueID = value; }
        }

        [DataMember]
        public Int64 IssueIdentityCategoryID
        {
            get { return _IssueIdentityCategoryID; }
            set { _IssueIdentityCategoryID = value; }
        }

        [DataMember]
        public Int64 IssueCategoryID
        {
            get { return _IssueCategoryID; }
            set { _IssueCategoryID = value; }
        }

        [DataMember]
        public Int64? ParentIssueID
        {
            get { return _ParentIssueID; }
            set { _ParentIssueID = value; }
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
        public Int64 IssuePriorityID
        {
            get { return _IssuePriorityID; }
            set { _IssuePriorityID = value; }
        }

        [DataMember]
        public Decimal? CompletionPercentage
        {
            get { return _CompletionPercentage; }
            set { _CompletionPercentage = value; }
        }

        [DataMember]
        public Int64 IssueStatusID
        {
            get { return _IssueStatusID; }
            set { _IssueStatusID = value; }
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
        public DateTime? ExpectedStartDate
        {
            get { return _ExpectedStartDate; }
            set { _ExpectedStartDate = value; }
        }

        [DataMember]
        public DateTime? ExpectedEndDate
        {
            get { return _ExpectedEndDate; }
            set { _ExpectedEndDate = value; }
        }

        [DataMember]
        public DateTime? ActualStartDate
        {
            get { return _ActualStartDate; }
            set { _ActualStartDate = value; }
        }

        [DataMember]
        public DateTime? ActualEndDate
        {
            get { return _ActualEndDate; }
            set { _ActualEndDate = value; }
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
        public Int64 SupervisorEmployeeID
        {
            get { return _SupervisorEmployeeID; }
            set { _SupervisorEmployeeID = value; }
        }

        [DataMember]
        public Int64 AssignedToEmployeeID
        {
            get { return _AssignedToEmployeeID; }
            set { _AssignedToEmployeeID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64? ReferenceIssueID
        {
            get { return _ReferenceIssueID; }
            set { _ReferenceIssueID = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public Boolean SupervisorAgreed
        {
            get { return _SupervisorAgreed; }
            set { _SupervisorAgreed = value; }
        }

        [DataMember]
        public DateTime ModifiedBySupervisorDateTime
        {
            get { return _ModifiedBySupervisorDateTime; }
            set { _ModifiedBySupervisorDateTime = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public String DTLDuration
        {
            get { return _DTLDuration; }
            set { _DTLDuration = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64? ProjectFloorID
        {
            get { return _ProjectFloorID; }
            set { _ProjectFloorID = value; }
        }

        [DataMember]
        public Int64? ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public Int64? ProjectFloorUnitLocationID
        {
            get { return _ProjectFloorUnitLocationID; }
            set { _ProjectFloorUnitLocationID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (IssueID <= 0);
            }
        }


        #endregion

        #region Constructor

        public OTIssueEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_IssueID = "IssueID";
        public const String FLD_NAME_IssueIdentityCategoryID = "IssueIdentityCategoryID";
        public const String FLD_NAME_IssueCategoryID = "IssueCategoryID";
        public const String FLD_NAME_ParentIssueID = "ParentIssueID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_Title = "Title";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IssuePriorityID = "IssuePriorityID";
        public const String FLD_NAME_CompletionPercentage = "CompletionPercentage";
        public const String FLD_NAME_IssueStatusID = "IssueStatusID";
        public const String FLD_NAME_CreatedByMemberID = "CreatedByMemberID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_Duration = "Duration";
        public const String FLD_NAME_ExpectedStartDate = "ExpectedStartDate";
        public const String FLD_NAME_ExpectedEndDate = "ExpectedEndDate";
        public const String FLD_NAME_ActualStartDate = "ActualStartDate";
        public const String FLD_NAME_ActualEndDate = "ActualEndDate";
        public const String FLD_NAME_NotifyBeforeMin = "NotifyBeforeMin";
        public const String FLD_NAME_IsNotifyCompleted = "IsNotifyCompleted";
        public const String FLD_NAME_SupervisorEmployeeID = "SupervisorEmployeeID";
        public const String FLD_NAME_AssignedToEmployeeID = "AssignedToEmployeeID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_ReferenceIssueID = "ReferenceIssueID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_SupervisorAgreed = "SupervisorAgreed";
        public const String FLD_NAME_ModifiedBySupervisorDateTime = "ModifiedBySupervisorDateTime";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_DTLDuration = "DTLDuration";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_ProjectFloorUnitLocationID = "ProjectUnitLocationID";

        #endregion
    }
}
