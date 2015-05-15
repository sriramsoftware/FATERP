// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDHolidayAppliedStatus", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDHolidayAppliedStatusEntity : BaseEntity
    {
        #region Properties


        private Int64 _HolidayAppliedStatusID;
        private String _Name;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 HolidayAppliedStatusID
        {
            get { return _HolidayAppliedStatusID; }
            set { _HolidayAppliedStatusID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
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
                return (HolidayAppliedStatusID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDHolidayAppliedStatusEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_HolidayAppliedStatusID = "HolidayAppliedStatusID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
