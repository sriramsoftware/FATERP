// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Mar-2013, 04:43:03




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "KBUserTreeShared_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class KBUserTreeShared_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _UserTreeSharedID;
        private Int64 _UserTreeID;
        private Int64 _UserTreeSettingID;
        private String _Message;
        private Int64 _SharedGivenByEmployeeID;
        private DateTime _SharedDateTime;
        private Int64 _SharedGivenToEmployeeID;
        private String _IP;
        private Int64 _UserTreePermissionID;
        private Int64? _KBUserTreeParentUserTreeID;
        private String _KBMDUserTreeSettingName;
        private String _SharedGivenByEmployeeFullName;
        private String _SharedGivenToEmployeeFullName;
        private String _KBMDUserTreeSharedPermissionName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 UserTreeSharedID
        {
            get { return _UserTreeSharedID; }
            set { _UserTreeSharedID = value; }
        }

        [DataMember]
        public Int64 UserTreeID
        {
            get { return _UserTreeID; }
            set { _UserTreeID = value; }
        }

        [DataMember]
        public Int64 UserTreeSettingID
        {
            get { return _UserTreeSettingID; }
            set { _UserTreeSettingID = value; }
        }

        [DataMember]
        public String Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        [DataMember]
        public Int64 SharedGivenByEmployeeID
        {
            get { return _SharedGivenByEmployeeID; }
            set { _SharedGivenByEmployeeID = value; }
        }

        [DataMember]
        public DateTime SharedDateTime
        {
            get { return _SharedDateTime; }
            set { _SharedDateTime = value; }
        }

        [DataMember]
        public Int64 SharedGivenToEmployeeID
        {
            get { return _SharedGivenToEmployeeID; }
            set { _SharedGivenToEmployeeID = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [DataMember]
        public Int64 UserTreePermissionID
        {
            get { return _UserTreePermissionID; }
            set { _UserTreePermissionID = value; }
        }

        [DataMember]
        public Int64? KBUserTreeParentUserTreeID
        {
            get { return _KBUserTreeParentUserTreeID; }
            set { _KBUserTreeParentUserTreeID = value; }
        }

        [DataMember]
        public String KBMDUserTreeSettingName
        {
            get { return _KBMDUserTreeSettingName; }
            set { _KBMDUserTreeSettingName = value; }
        }

        [DataMember]
        public String SharedGivenByEmployeeFullName
        {
            get { return _SharedGivenByEmployeeFullName; }
            set { _SharedGivenByEmployeeFullName = value; }
        }

        [DataMember]
        public String SharedGivenToEmployeeFullName
        {
            get { return _SharedGivenToEmployeeFullName; }
            set { _SharedGivenToEmployeeFullName = value; }
        }

        [DataMember]
        public String KBMDUserTreeSharedPermissionName
        {
            get { return _KBMDUserTreeSharedPermissionName; }
            set { _KBMDUserTreeSharedPermissionName = value; }
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
                return (UserTreeSharedID <= 0);
            }
        }


        #endregion

        #region Constructor

        public KBUserTreeShared_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_UserTreeSharedID = "UserTreeSharedID";
        public const String FLD_NAME_UserTreeID = "UserTreeID";
        public const String FLD_NAME_UserTreeSettingID = "UserTreeSettingID";
        public const String FLD_NAME_Message = "Message";
        public const String FLD_NAME_SharedGivenByEmployeeID = "SharedGivenByEmployeeID";
        public const String FLD_NAME_SharedDateTime = "SharedDateTime";
        public const String FLD_NAME_SharedGivenToEmployeeID = "SharedGivenToEmployeeID";
        public const String FLD_NAME_IP = "IP";
        public const String FLD_NAME_UserTreePermissionID = "UserTreePermissionID";
        public const String FLD_NAME_KBUserTreeParentUserTreeID = "KBUserTreeParentUserTreeID";
        public const String FLD_NAME_KBMDUserTreeSettingName = "KBMDUserTreeSettingName";
        public const String FLD_NAME_SharedGivenByEmployeeFullName = "SharedGivenByEmployeeFullName";
        public const String FLD_NAME_SharedGivenToEmployeeFullName = "SharedGivenToEmployeeFullName";
        public const String FLD_NAME_KBMDUserTreeSharedPermissionName = "KBMDUserTreeSharedPermissionName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}