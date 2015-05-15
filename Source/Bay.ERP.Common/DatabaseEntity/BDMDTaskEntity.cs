// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDMDTask", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDMDTaskEntity : BaseEntity
    {
        #region Properties


        private Int64 _TaskID;
        private Int64 _TaskCategoryID;
        private String _Name;
        private Int32? _RequiredStandardTime;
        private Int32? _ReminderTime;
        private Boolean _IsRepeat;
        private String _Remarks;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 TaskID
        {
            get { return _TaskID; }
            set { _TaskID = value; }
        }

        [DataMember]
        public Int64 TaskCategoryID
        {
            get { return _TaskCategoryID; }
            set { _TaskCategoryID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public Int32? RequiredStandardTime
        {
            get { return _RequiredStandardTime; }
            set { _RequiredStandardTime = value; }
        }

        [DataMember]
        public Int32? ReminderTime
        {
            get { return _ReminderTime; }
            set { _ReminderTime = value; }
        }

        [DataMember]
        public Boolean IsRepeat
        {
            get { return _IsRepeat; }
            set { _IsRepeat = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (TaskID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDMDTaskEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TaskID = "TaskID";
        public const String FLD_NAME_TaskCategoryID = "TaskCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_RequiredStandardTime = "RequiredStandardTime";
        public const String FLD_NAME_ReminderTime = "ReminderTime";
        public const String FLD_NAME_IsRepeat = "IsRepeat";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
