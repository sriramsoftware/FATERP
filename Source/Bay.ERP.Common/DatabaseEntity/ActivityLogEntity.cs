// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jul-2013, 10:18:14




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ActivityLog", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ActivityLogEntity : BaseEntity
    {
        #region Properties


        private Int64 _ActivityLogID;
        private Guid _UserId;
        private String _Activity;
        private String _PageUrl;
        private DateTime? _ActivityDate;


        [DataMember]
        public Int64 ActivityLogID
        {
            get { return _ActivityLogID; }
            set { _ActivityLogID = value; }
        }

        [DataMember]
        public Guid UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        [DataMember]
        public String Activity
        {
            get { return _Activity; }
            set { _Activity = value; }
        }

        [DataMember]
        public String PageUrl
        {
            get { return _PageUrl; }
            set { _PageUrl = value; }
        }

        [DataMember]
        public DateTime? ActivityDate
        {
            get { return _ActivityDate; }
            set { _ActivityDate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ActivityLogID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ActivityLogEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ActivityLogID = "ActivityLogID";
        public const String FLD_NAME_UserId = "UserId";
        public const String FLD_NAME_Activity = "Activity";
        public const String FLD_NAME_PageUrl = "PageUrl";
        public const String FLD_NAME_ActivityDate = "ActivityDate";

        #endregion
    }
}
