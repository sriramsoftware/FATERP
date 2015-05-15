// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Jan-2012, 02:37:47




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMProjectMilestone_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMProjectMilestone_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectMilestoneID;
        private Int64 _ProjectID;
        private String _Title;
        private Decimal? _CompletionPercentage;
        private String _IssueStatusName;


        [DataMember]
        public Int64 ProjectMilestoneID
        {
            get { return _ProjectMilestoneID; }
            set { _ProjectMilestoneID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [DataMember]
        public Decimal? CompletionPercentage
        {
            get { return _CompletionPercentage; }
            set { _CompletionPercentage = value; }
        }

        [DataMember]
        public String IssueStatusName
        {
            get { return _IssueStatusName; }
            set { _IssueStatusName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectMilestoneID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMProjectMilestone_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectMilestoneID = "ProjectMilestoneID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_Title = "Title";
        public const String FLD_NAME_CompletionPercentage = "CompletionPercentage";
        public const String FLD_NAME_IssueStatusName = "IssueStatusName";

        #endregion
    }
}
