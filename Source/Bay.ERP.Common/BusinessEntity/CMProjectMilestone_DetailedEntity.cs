// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jan-2012, 04:26:55




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMProjectMilestone_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMProjectMilestone_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectMilestoneID;
        private Int64 _ProjectID;
        private Int64 _IssueID;
        private String _ProjectName;
        private String _Title;
        private Int64? _RowNumber;


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
        public Int64 IssueID
        {
            get { return _IssueID; }
            set { _IssueID = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
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
                return (ProjectMilestoneID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMProjectMilestone_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectMilestoneID = "ProjectMilestoneID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_IssueID = "IssueID";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_Title = "Title";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
