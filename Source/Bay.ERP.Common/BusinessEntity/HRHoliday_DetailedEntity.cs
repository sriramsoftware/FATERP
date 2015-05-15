// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Mar-2012, 11:22:12




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HRHoliday_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRHoliday_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _HolidayID;
        private Int64 _HolidayCategoryID;
        private String _Name;
        private DateTime _HolidayDate;
        private String _HolidayCategoryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 HolidayID
        {
            get { return _HolidayID; }
            set { _HolidayID = value; }
        }

        [DataMember]
        public Int64 HolidayCategoryID
        {
            get { return _HolidayCategoryID; }
            set { _HolidayCategoryID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public DateTime HolidayDate
        {
            get { return _HolidayDate; }
            set { _HolidayDate = value; }
        }

        [DataMember]
        public String HolidayCategoryName
        {
            get { return _HolidayCategoryName; }
            set { _HolidayCategoryName = value; }
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
                return (HolidayID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HRHoliday_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_HolidayID = "HolidayID";
        public const String FLD_NAME_HolidayCategoryID = "HolidayCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_HolidayDate = "HolidayDate";
        public const String FLD_NAME_HolidayCategoryName = "HolidayCategoryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
