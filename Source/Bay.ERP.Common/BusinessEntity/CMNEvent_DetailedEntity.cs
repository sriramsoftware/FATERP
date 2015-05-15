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
    [DataContract(Name = "CMNEvent_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMNEvent_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _EventID;
        private Int64 _EventIdentityCategoryID;
        private Int64 _EventCategoryID;
        private Int64? _ParentEventID;
        private Int64? _ReferenceEventID;
        private String _EventReferenceNo;
        private String _Title;
        private String _Details;
        private String _Location;
        private Int64 _EventLocationCategoryID;
        private Int64? _LocationReferenceID;
        private String _WebsiteURL;
        private String _TicketSellerURL;
        private String _YoutubeURL;
        private String _TransitAndParkingInformation;
        private Int64 _EventOptionID;
        private Decimal? _CompletionPercentage;
        private Int64 _EventStatusID;
        private Int64 _RepeatCategoryID;
        private Int64 _CreatedByMemberID;
        private Int64 _OwnerMemberID;
        private DateTime _CreateDate;
        private Decimal? _Duration;
        private DateTime _ExpectedStartDate;
        private DateTime? _ExpectedEndDate;
        private DateTime? _ActualStartDate;
        private DateTime? _ActualEndDate;
        private Boolean _IsAllDay;
        private Int32? _NotifyBeforeMin;
        private Boolean _IsNotifyCompleted;
        private String _Remarks;
        private Int64 _SharedSettingID;
        private DateTime _ModifiedDateTime;
        private String _IP;
        private Boolean _IsOwnerGoing;
        private Boolean _IsRemoved;
        private String _Name;
		private String _Description; 
		private String _EventLocationCategoryName;
		private String _EventOptionName;
		private String _EventStatusName; 
		private String _RepeatCategoryName;
		private String _SharedSettingName;
		private String _LocationName;
        private String _EventIdentityCategoryName;
		private String _CreatedByMemberFullName;
        private String _OwnerMemberFullName;
		private Int64? _RowNumber;


        [DataMember]
        public Int64 EventID
        {
            get { return _EventID; }
            set { _EventID = value; }
        }

        [DataMember]
        public Int64 EventIdentityCategoryID
        {
            get { return _EventIdentityCategoryID; }
            set { _EventIdentityCategoryID = value; }
        }

        [DataMember]
        public Int64 EventCategoryID
        {
            get { return _EventCategoryID; }
            set { _EventCategoryID = value; }
        }

        [DataMember]
        public Int64? ParentEventID
        {
            get { return _ParentEventID; }
            set { _ParentEventID = value; }
        }

        [DataMember]
        public Int64? ReferenceEventID
        {
            get { return _ReferenceEventID; }
            set { _ReferenceEventID = value; }
        }

        [DataMember]
        public String EventReferenceNo
        {
            get { return _EventReferenceNo; }
            set { _EventReferenceNo = value; }
        }

        [DataMember]
        public String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        [DataMember]
        public String Details
        {
            get { return _Details; }
            set { _Details = value; }
        }

        [DataMember]
        public String Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        [DataMember]
        public Int64 EventLocationCategoryID
        {
            get { return _EventLocationCategoryID; }
            set { _EventLocationCategoryID = value; }
        }

        [DataMember]
        public Int64? LocationReferenceID
        {
            get { return _LocationReferenceID; }
            set { _LocationReferenceID = value; }
        }

        [DataMember]
        public String WebsiteURL
        {
            get { return _WebsiteURL; }
            set { _WebsiteURL = value; }
        }

        [DataMember]
        public String TicketSellerURL
        {
            get { return _TicketSellerURL; }
            set { _TicketSellerURL = value; }
        }

        [DataMember]
        public String YoutubeURL
        {
            get { return _YoutubeURL; }
            set { _YoutubeURL = value; }
        }

        [DataMember]
        public String TransitAndParkingInformation
        {
            get { return _TransitAndParkingInformation; }
            set { _TransitAndParkingInformation = value; }
        }

        [DataMember]
        public Int64 EventOptionID
        {
            get { return _EventOptionID; }
            set { _EventOptionID = value; }
        }

        [DataMember]
        public Decimal? CompletionPercentage
        {
            get { return _CompletionPercentage; }
            set { _CompletionPercentage = value; }
        }

        [DataMember]
        public Int64 EventStatusID
        {
            get { return _EventStatusID; }
            set { _EventStatusID = value; }
        }

        [DataMember]
        public Int64 RepeatCategoryID
        {
            get { return _RepeatCategoryID; }
            set { _RepeatCategoryID = value; }
        }

        [DataMember]
        public Int64 CreatedByMemberID
        {
            get { return _CreatedByMemberID; }
            set { _CreatedByMemberID = value; }
        }

        [DataMember]
        public Int64 OwnerMemberID
        {
            get { return _OwnerMemberID; }
            set { _OwnerMemberID = value; }
        }

        [DataMember]
        public DateTime CreateDate
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
        public DateTime ExpectedStartDate
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
        public Boolean IsAllDay
        {
            get { return _IsAllDay; }
            set { _IsAllDay = value; }
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
        public Int64 SharedSettingID
        {
            get { return _SharedSettingID; }
            set { _SharedSettingID = value; }
        }

        [DataMember]
        public DateTime ModifiedDateTime
        {
            get { return _ModifiedDateTime; }
            set { _ModifiedDateTime = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public Boolean IsOwnerGoing
        {
            get { return _IsOwnerGoing; }
            set { _IsOwnerGoing = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public String EventLocationCategoryName
        {
            get { return _EventLocationCategoryName; }
            set { _EventLocationCategoryName = value; }
        }

        [DataMember]
        public String EventOptionName
        {
            get { return _EventOptionName; }
            set { _EventOptionName = value; }
        }

        [DataMember]
        public String EventStatusName
        {
            get { return _EventStatusName; }
            set { _EventStatusName = value; }
        }

        [DataMember]
        public String RepeatCategoryName
        {
            get { return _RepeatCategoryName; }
            set { _RepeatCategoryName = value; }
        }

        [DataMember]
        public String SharedSettingName
        {
            get { return _SharedSettingName; }
            set { _SharedSettingName = value; }
        }

        [DataMember]
        public String LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }

        [DataMember]
        public String EventIdentityCategoryName
        {
            get { return _EventIdentityCategoryName; }
            set { _EventIdentityCategoryName = value; }
        }

        [DataMember]
        public String CreatedByMemberFullName
        {
            get { return _CreatedByMemberFullName; }
            set { _CreatedByMemberFullName = value; }
        }

        [DataMember]
        public String OwnerMemberFullName
        {
            get { return _OwnerMemberFullName; }
            set { _OwnerMemberFullName = value; }
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
                return (EventID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMNEvent_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EventID = "EventID";
        public const String FLD_NAME_EventIdentityCategoryID = "EventIdentityCategoryID";
        public const String FLD_NAME_EventCategoryID = "EventCategoryID";
        public const String FLD_NAME_ParentEventID = "ParentEventID";
        public const String FLD_NAME_ReferenceEventID = "ReferenceEventID";
        public const String FLD_NAME_EventReferenceNo = "EventReferenceNo";
        public const String FLD_NAME_Title = "Title";
        public const String FLD_NAME_Details = "Details";
        public const String FLD_NAME_Location = "Location";
        public const String FLD_NAME_EventLocationCategoryID = "EventLocationCategoryID";
        public const String FLD_NAME_LocationReferenceID = "LocationReferenceID";
        public const String FLD_NAME_WebsiteURL = "WebsiteURL";
        public const String FLD_NAME_TicketSellerURL = "TicketSellerURL";
        public const String FLD_NAME_YoutubeURL = "YoutubeURL";
        public const String FLD_NAME_TransitAndParkingInformation = "TransitAndParkingInformation";
        public const String FLD_NAME_EventOptionID = "EventOptionID";
        public const String FLD_NAME_CompletionPercentage = "CompletionPercentage";
        public const String FLD_NAME_EventStatusID = "EventStatusID";
        public const String FLD_NAME_RepeatCategoryID = "RepeatCategoryID";
        public const String FLD_NAME_CreatedByMemberID = "CreatedByMemberID";
        public const String FLD_NAME_OwnerMemberID = "OwnerMemberID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_Duration = "Duration";
        public const String FLD_NAME_ExpectedStartDate = "ExpectedStartDate";
        public const String FLD_NAME_ExpectedEndDate = "ExpectedEndDate";
        public const String FLD_NAME_ActualStartDate = "ActualStartDate";
        public const String FLD_NAME_ActualEndDate = "ActualEndDate";
        public const String FLD_NAME_IsAllDay = "IsAllDay";
        public const String FLD_NAME_NotifyBeforeMin = "NotifyBeforeMin";
        public const String FLD_NAME_IsNotifyCompleted = "IsNotifyCompleted";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_SharedSettingID = "SharedSettingID";
        public const String FLD_NAME_ModifiedDateTime = "ModifiedDateTime";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_IsOwnerGoing = "IsOwnerGoing";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_EventLocationCategoryName = "EventLocationCategoryName";
        public const String FLD_NAME_EventOptionName = "EventOptionName";
        public const String FLD_NAME_EventStatusName = "EventStatusName";
        public const String FLD_NAME_RepeatCategoryName = "RepeatCategoryName";
        public const String FLD_NAME_SharedSettingName = "SharedSettingName";
        public const String FLD_NAME_LocationName = "LocationName";
        public const String FLD_NAME_EventIdentityCategoryName = "EventIdentityCategoryName";
        public const String FLD_NAME_CreatedByMemberFullName = "CreatedByMemberFullName";
        public const String FLD_NAME_OwnerMemberFullName = "OwnerMemberFullName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
