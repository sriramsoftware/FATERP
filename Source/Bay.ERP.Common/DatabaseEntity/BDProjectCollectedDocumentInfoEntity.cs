// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Mar-2012, 03:28:59




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectCollectedDocumentInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectCollectedDocumentInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectCollectedDocumentInfoID;
        private Int64 _ProjectID;
        private Int64 _ProjectDocumentID;
        private DateTime? _StartDate;
        private Int32? _RequiredTime;
        private Int64? _RequiredTimeStandardTimeUnitID;
        private Int32? _ReminderBefore;
        private Int64? _ReminderBeforeStandardTimeUnitID;
        private Int64? _ProjectCollectedDocumentStatusID;
        private String _Remarks;


        [DataMember]
        public Int64 ProjectCollectedDocumentInfoID
        {
            get { return _ProjectCollectedDocumentInfoID; }
            set { _ProjectCollectedDocumentInfoID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Int64 ProjectDocumentID
        {
            get { return _ProjectDocumentID; }
            set { _ProjectDocumentID = value; }
        }

        [DataMember]
        public DateTime? StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public Int32? RequiredTime
        {
            get { return _RequiredTime; }
            set { _RequiredTime = value; }
        }

        [DataMember]
        public Int64? RequiredTimeStandardTimeUnitID
        {
            get { return _RequiredTimeStandardTimeUnitID; }
            set { _RequiredTimeStandardTimeUnitID = value; }
        }

        [DataMember]
        public Int32? ReminderBefore
        {
            get { return _ReminderBefore; }
            set { _ReminderBefore = value; }
        }

        [DataMember]
        public Int64? ReminderBeforeStandardTimeUnitID
        {
            get { return _ReminderBeforeStandardTimeUnitID; }
            set { _ReminderBeforeStandardTimeUnitID = value; }
        }

        [DataMember]
        public Int64? ProjectCollectedDocumentStatusID
        {
            get { return _ProjectCollectedDocumentStatusID; }
            set { _ProjectCollectedDocumentStatusID = value; }
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
                return (ProjectCollectedDocumentInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectCollectedDocumentInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectCollectedDocumentInfoID = "ProjectCollectedDocumentInfoID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectDocumentID = "ProjectDocumentID";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_RequiredTime = "RequiredTime";
        public const String FLD_NAME_RequiredTimeStandardTimeUnitID = "RequiredTimeStandardTimeUnitID";
        public const String FLD_NAME_ReminderBefore = "ReminderBefore";
        public const String FLD_NAME_ReminderBeforeStandardTimeUnitID = "ReminderBeforeStandardTimeUnitID";
        public const String FLD_NAME_ProjectCollectedDocumentStatusID = "ProjectCollectedDocumentStatusID";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
