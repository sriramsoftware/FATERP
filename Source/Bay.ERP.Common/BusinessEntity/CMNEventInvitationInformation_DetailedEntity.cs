// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Feb-2012, 12:56:26




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMNEventInvitationInformation_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMNEventInvitationInformation_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _EventInvitationInformationID;
        private Int64 _EventID;
        private Int64 _InitationGivenByMemberID;
        private DateTime _SharedDateTime;
        private String _Message;
        private Int64 _InitationGivenToMemberID;
        private Boolean _IsGuestGoing;
        private String _IP;
        private Int64 _Rownumber;
        private String _InitationGivenByMember;
        private String _InitationGivenToMember;
        private String _Title;


        [DataMember]
        public Int64 EventInvitationInformationID
        {
            get { return _EventInvitationInformationID; }
            set { _EventInvitationInformationID = value; }
        }

        [DataMember]
        public Int64 EventID
        {
            get { return _EventID; }
            set { _EventID = value; }
        }

        [DataMember]
        public Int64 InitationGivenByMemberID
        {
            get { return _InitationGivenByMemberID; }
            set { _InitationGivenByMemberID = value; }
        }

        [DataMember]
        public DateTime SharedDateTime
        {
            get { return _SharedDateTime; }
            set { _SharedDateTime = value; }
        }

        [DataMember]
        public String Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        [DataMember]
        public Int64 InitationGivenToMemberID
        {
            get { return _InitationGivenToMemberID; }
            set { _InitationGivenToMemberID = value; }
        }

        [DataMember]
        public Boolean IsGuestGoing
        {
            get { return _IsGuestGoing; }
            set { _IsGuestGoing = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public Int64 Rownumber
        {
            get { return _Rownumber; }
            set { _Rownumber = value; }
        }

        [DataMember]
        public String InitationGivenByMember
        {
            get { return _InitationGivenByMember; }
            set { _InitationGivenByMember = value; }
        }

        [DataMember]
        public String InitationGivenToMember
        {
            get { return _InitationGivenToMember; }
            set { _InitationGivenToMember = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (EventInvitationInformationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMNEventInvitationInformation_DetailedEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EventInvitationInformationID = "EventInvitationInformationID";
        public const String FLD_NAME_EventID = "EventID";
        public const String FLD_NAME_InitationGivenByMemberID = "InitationGivenByMemberID";
        public const String FLD_NAME_SharedDateTime = "SharedDateTime";
        public const String FLD_NAME_Message = "Message";
        public const String FLD_NAME_InitationGivenToMemberID = "InitationGivenToMemberID";
        public const String FLD_NAME_IsGuestGoing = "IsGuestGoing";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_InitationGivenByMember = "InitationGivenByMember";
        public const String FLD_InitationGivenToMember = "InitationGivenToMember";
        public const String FLD_Title = "Title";
        public const String FLD_Rownumber = "Rownumber";

        #endregion
        
    }
}
