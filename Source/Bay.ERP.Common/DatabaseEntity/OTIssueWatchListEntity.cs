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
    [DataContract(Name = "OTIssueWatchList", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class OTIssueWatchListEntity : BaseEntity
    {
        #region Properties


        private Int64 _IssueWatchListID;
        private Int64 _IssueID;
        private Int64 _ResourceID;


        [DataMember]
        public Int64 IssueWatchListID
        {
            get { return _IssueWatchListID; }
            set { _IssueWatchListID = value; }
        }

        [DataMember]
        public Int64 IssueID
        {
            get { return _IssueID; }
            set { _IssueID = value; }
        }

        [DataMember]
        public Int64 ResourceID
        {
            get { return _ResourceID; }
            set { _ResourceID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (IssueWatchListID <= 0);
            }
        }


        #endregion

        #region Constructor

        public OTIssueWatchListEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_IssueWatchListID = "IssueWatchListID";
        public const String FLD_NAME_IssueID = "IssueID";
        public const String FLD_NAME_ResourceID = "ResourceID";

        #endregion
    }
}
