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
    [DataContract(Name = "MDAttendanceLeaveHolidayList", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDAttendanceLeaveHolidayListEntity : BaseEntity
    {
        #region Properties


        private Int64 _AttendanceLeaveHolidayListID;
        private Int64 _AttendanceLeaveAndHolidayCategoryID;
        private String _Name;
        private String _Description;
        private String _Code;
        private String _Color;


        [DataMember]
        public Int64 AttendanceLeaveHolidayListID
        {
            get { return _AttendanceLeaveHolidayListID; }
            set { _AttendanceLeaveHolidayListID = value; }
        }

        [DataMember]
        public Int64 AttendanceLeaveAndHolidayCategoryID
        {
            get { return _AttendanceLeaveAndHolidayCategoryID; }
            set { _AttendanceLeaveAndHolidayCategoryID = value; }
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
        public String Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        [DataMember]
        public String Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (AttendanceLeaveHolidayListID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDAttendanceLeaveHolidayListEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_AttendanceLeaveHolidayListID = "AttendanceLeaveHolidayListID";
        public const String FLD_NAME_AttendanceLeaveAndHolidayCategoryID = "AttendanceLeaveAndHolidayCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_Code = "Code";
        public const String FLD_NAME_Color = "Color";

        #endregion
    }
}
