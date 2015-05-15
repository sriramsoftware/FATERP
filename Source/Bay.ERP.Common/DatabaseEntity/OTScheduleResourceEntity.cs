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
    [DataContract(Name = "OTScheduleResource", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class OTScheduleResourceEntity : BaseEntity
    {
        #region Properties


        private Int64 _OTScheduleResourceID;
        private Int64 _ScheduleID;
        private Int64 _ResourceID;


        [DataMember]
        public Int64 OTScheduleResourceID
        {
            get { return _OTScheduleResourceID; }
            set { _OTScheduleResourceID = value; }
        }

        [DataMember]
        public Int64 ScheduleID
        {
            get { return _ScheduleID; }
            set { _ScheduleID = value; }
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
                return (OTScheduleResourceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public OTScheduleResourceEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_OTScheduleResourceID = "OTScheduleResourceID";
        public const String FLD_NAME_ScheduleID = "ScheduleID";
        public const String FLD_NAME_ResourceID = "ResourceID";

        #endregion
    }
}
