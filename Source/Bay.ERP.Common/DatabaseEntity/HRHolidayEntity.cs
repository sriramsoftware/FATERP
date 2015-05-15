// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HRHoliday", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRHolidayEntity : BaseEntity
    {
        #region Properties


        private Int64 _HolidayID;
        private Int64 _HolidayCategoryID;
        private String _Name;
        private DateTime _HolidayDate;
        private String _Remarks;
        private Int64 _HolidayAppliedStatusID;
        private Int64 _FiscalYearID;


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
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 HolidayAppliedStatusID
        {
            get { return _HolidayAppliedStatusID; }
            set { _HolidayAppliedStatusID = value; }
        }

        [DataMember]
        public Int64 FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
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

        public HRHolidayEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_HolidayID = "HolidayID";
        public const String FLD_NAME_HolidayCategoryID = "HolidayCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_HolidayDate = "HolidayDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_HolidayAppliedStatusID = "HolidayAppliedStatusID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";

        #endregion
    }
}
