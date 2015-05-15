// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Mar-2013, 10:57:47




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "OTIssueAssignedResource", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class OTIssueAssignedResourceEntity : BaseEntity
    {
        #region Properties


        private Int64 _IssueAssignedResourceID;
        private Int64 _IssueID;
        private Int64 _ResourceID;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private Int64 _IssueAssignTypeID;
        private String _Remarks;


        [DataMember]
        public Int64 IssueAssignedResourceID
        {
            get { return _IssueAssignedResourceID; }
            set { _IssueAssignedResourceID = value; }
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

        [DataMember]
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        [DataMember]
        public Int64 IssueAssignTypeID
        {
            get { return _IssueAssignTypeID; }
            set { _IssueAssignTypeID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (IssueAssignedResourceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public OTIssueAssignedResourceEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_IssueAssignedResourceID = "IssueAssignedResourceID";
        public const String FLD_NAME_IssueID = "IssueID";
        public const String FLD_NAME_ResourceID = "ResourceID";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_IssueAssignTypeID = "IssueAssignTypeID";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
