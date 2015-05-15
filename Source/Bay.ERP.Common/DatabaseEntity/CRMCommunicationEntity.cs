// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Apr-2013, 03:35:56




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CRMCommunication", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CRMCommunicationEntity : BaseEntity
    {
        #region Properties


        private Int64 _CommunicationID;
        private Int64 _ProcessCategoryID;
        private Int64 _ReferenceID;
        private Int64 _CommuicationDiscussionTypeID;
        private DateTime _DiscussionDate;
        private Int64 _CommunicateByEmployeeID;
        private String _Topics;
        private String _Note;
        private Boolean _IsFollowUpNeeded;
        private Boolean _IsIWillCall;
        private Boolean _IsField1;
        private String _NextAction;
        private DateTime? _NextCommunicationDate;
        private Int64 _CommunicationStatusID;
        private Int64 _CreatedByEmployeeID;
        private String _IP;
        private DateTime _CreateDate;


        [DataMember]
        public Int64 CommunicationID
        {
            get { return _CommunicationID; }
            set { _CommunicationID = value; }
        }

        [DataMember]
        public Int64 ProcessCategoryID
        {
            get { return _ProcessCategoryID; }
            set { _ProcessCategoryID = value; }
        }

        [DataMember]
        public Int64 ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public Int64 CommuicationDiscussionTypeID
        {
            get { return _CommuicationDiscussionTypeID; }
            set { _CommuicationDiscussionTypeID = value; }
        }

        [DataMember]
        public DateTime DiscussionDate
        {
            get { return _DiscussionDate; }
            set { _DiscussionDate = value; }
        }

        [DataMember]
        public Int64 CommunicateByEmployeeID
        {
            get { return _CommunicateByEmployeeID; }
            set { _CommunicateByEmployeeID = value; }
        }

        [DataMember]
        public String Topics
        {
            get { return _Topics; }
            set { _Topics = value; }
        }

        [DataMember]
        public String Note
        {
            get { return _Note; }
            set { _Note = value; }
        }

        [DataMember]
        public Boolean IsFollowUpNeeded
        {
            get { return _IsFollowUpNeeded; }
            set { _IsFollowUpNeeded = value; }
        }

        [DataMember]
        public Boolean IsIWillCall
        {
            get { return _IsIWillCall; }
            set { _IsIWillCall = value; }
        }

        [DataMember]
        public Boolean IsField1
        {
            get { return _IsField1; }
            set { _IsField1 = value; }
        }

        [DataMember]
        public String NextAction
        {
            get { return _NextAction; }
            set { _NextAction = value; }
        }

        [DataMember]
        public DateTime? NextCommunicationDate
        {
            get { return _NextCommunicationDate; }
            set { _NextCommunicationDate = value; }
        }

        [DataMember]
        public Int64 CommunicationStatusID
        {
            get { return _CommunicationStatusID; }
            set { _CommunicationStatusID = value; }
        }

        [DataMember]
        public Int64 CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (CommunicationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CRMCommunicationEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_CommunicationID = "CommunicationID";
        public const String FLD_NAME_ProcessCategoryID = "ProcessCategoryID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_CommuicationDiscussionTypeID = "CommuicationDiscussionTypeID";
        public const String FLD_NAME_DiscussionDate = "DiscussionDate";
        public const String FLD_NAME_CommunicateByEmployeeID = "CommunicateByEmployeeID";
        public const String FLD_NAME_Topics = "Topics";
        public const String FLD_NAME_Note = "Note";
        public const String FLD_NAME_IsFollowUpNeeded = "IsFollowUpNeeded";
        public const String FLD_NAME_IsIWillCall = "IsIWillCall";
        public const String FLD_NAME_IsField1 = "IsField1";
        public const String FLD_NAME_NextAction = "NextAction";
        public const String FLD_NAME_NextCommunicationDate = "NextCommunicationDate";
        public const String FLD_NAME_CommunicationStatusID = "CommunicationStatusID";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_CreateDate = "CreateDate";

        #endregion
    }
}
