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
    [DataContract(Name = "HRMemberLeaveOpeningBalance", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRMemberLeaveOpeningBalanceEntity : BaseEntity
    {
        #region Properties


        private Int64 _MemberLeaveOpeningBalanceID;
        private Int64 _AttendanceLeaveHolidayListID;
        private Int64 _EmployeeID;
        private Decimal? _BalanceDays;
        private DateTime? _BalanceAsOffDate;
        private String _Remarks;


        [DataMember]
        public Int64 MemberLeaveOpeningBalanceID
        {
            get { return _MemberLeaveOpeningBalanceID; }
            set { _MemberLeaveOpeningBalanceID = value; }
        }

        [DataMember]
        public Int64 AttendanceLeaveHolidayListID
        {
            get { return _AttendanceLeaveHolidayListID; }
            set { _AttendanceLeaveHolidayListID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Decimal? BalanceDays
        {
            get { return _BalanceDays; }
            set { _BalanceDays = value; }
        }

        [DataMember]
        public DateTime? BalanceAsOffDate
        {
            get { return _BalanceAsOffDate; }
            set { _BalanceAsOffDate = value; }
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
                return (MemberLeaveOpeningBalanceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HRMemberLeaveOpeningBalanceEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_MemberLeaveOpeningBalanceID = "MemberLeaveOpeningBalanceID";
        public const String FLD_NAME_AttendanceLeaveHolidayListID = "AttendanceLeaveHolidayListID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_BalanceDays = "BalanceDays";
        public const String FLD_NAME_BalanceAsOffDate = "BalanceAsOffDate";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
