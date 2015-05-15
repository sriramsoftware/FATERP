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
    [DataContract(Name = "BDMDTaskRepeat", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDMDTaskRepeatEntity : BaseEntity
    {
        #region Properties


        private Int64 _TaskRepeatID;
        private Int64 _TaskID;
        private Int64 _RepeatCategoryID;
        private Int32 _RepeatEvery;
        private DateTime _StartsOn;
        private DateTime? _EndsOn;


        [DataMember]
        public Int64 TaskRepeatID
        {
            get { return _TaskRepeatID; }
            set { _TaskRepeatID = value; }
        }

        [DataMember]
        public Int64 TaskID
        {
            get { return _TaskID; }
            set { _TaskID = value; }
        }

        [DataMember]
        public Int64 RepeatCategoryID
        {
            get { return _RepeatCategoryID; }
            set { _RepeatCategoryID = value; }
        }

        [DataMember]
        public Int32 RepeatEvery
        {
            get { return _RepeatEvery; }
            set { _RepeatEvery = value; }
        }

        [DataMember]
        public DateTime StartsOn
        {
            get { return _StartsOn; }
            set { _StartsOn = value; }
        }

        [DataMember]
        public DateTime? EndsOn
        {
            get { return _EndsOn; }
            set { _EndsOn = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (TaskRepeatID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDMDTaskRepeatEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TaskRepeatID = "TaskRepeatID";
        public const String FLD_NAME_TaskID = "TaskID";
        public const String FLD_NAME_RepeatCategoryID = "RepeatCategoryID";
        public const String FLD_NAME_RepeatEvery = "RepeatEvery";
        public const String FLD_NAME_StartsOn = "StartsOn";
        public const String FLD_NAME_EndsOn = "EndsOn";

        #endregion
    }
}
