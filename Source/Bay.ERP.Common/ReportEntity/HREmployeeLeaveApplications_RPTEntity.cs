// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Apr-2013, 01:13:55




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeLeaveApplications_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeLeaveApplications_RPTEntity : BaseEntity
    {
        #region Properties

        private String _EmployeeFullName;
        private String _EmployeeCode;
        private Decimal _TotalLeaveDays;
        private Int64 _LeaveCategoryID;
        private DateTime _ApplicationDate;
        private DateTime _RequestStartDate;
        private DateTime _RequestEndDate;
        private String _LeaveApplicationStatusName;
        private String _LeaveLocation;
        private String _LeavePurpose;
        private DateTime _SessionStartDate;
        private DateTime  _SessionEndDate;
        
        
        [DataMember]
        public String EmployeeFullName
        {
            get { return _EmployeeFullName; }
            set { _EmployeeFullName = value; }
        }

        [DataMember]
        public String EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }

        [DataMember]
        public Decimal TotalLeaveDays
        {
            get { return _TotalLeaveDays; }
            set { _TotalLeaveDays = value; }
        }

        [DataMember]
        public Int64 LeaveCategoryID
        {
            get { return _LeaveCategoryID; }
            set { _LeaveCategoryID = value; }
        }

        [DataMember]
        public DateTime ApplicationDate
        {
            get { return _ApplicationDate; }
            set { _ApplicationDate = value; }
        }

        [DataMember]
        public DateTime RequestStartDate
        {
            get { return _RequestStartDate; }
            set { _RequestStartDate = value; }
        }

        [DataMember]
        public DateTime RequestEndDate
        {
            get { return _RequestEndDate; }
            set { _RequestEndDate = value; }
        }

        [DataMember]
        public String LeaveApplicationStatusName
        {
            get { return _LeaveApplicationStatusName; }
            set { _LeaveApplicationStatusName = value; }
        }

        [DataMember]
        public String LeaveLocation
        {
            get { return _LeaveLocation; }
            set { _LeaveLocation = value; }
        }

        [DataMember]
        public String LeavePurpose
        {
            get { return _LeavePurpose; }
            set { _LeavePurpose = value; }
        }

        [DataMember]
        public DateTime SessionStartDate
        {
            get { return _SessionStartDate; }
            set { _SessionStartDate = value; }
        }

        [DataMember]
        public DateTime SessionEndDate
        {
            get { return _SessionEndDate; }
            set { _SessionEndDate = value; }
        }


        

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (LeaveCategoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeLeaveApplications_RPTEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_EmployeeFullName = "EmployeeFullName";
        public const String FLD_NAME_EmployeeCode = "EmployeeCode";
        public const String FLD_NAME_TotalLeaveDays = "TotalLeaveDays";
        public const String FLD_NAME_LeaveCategoryID = "LeaveCategoryID";
        public const String FLD_NAME_ApplicationDate = "ApplicationDate";
        public const String FLD_NAME_RequestStartDate = "RequestStartDate";
        public const String FLD_NAME_RequestEndDate = "RequestEndDate";
        public const String FLD_NAME_LeaveApplicationStatusName = "LeaveApplicationStatusName";
        public const String FLD_NAME_LeaveLocation = "LeaveLocation";
        public const String FLD_NAME_LeavePurpose = "LeavePurpose";
        public const String FLD_NAME_SessionStartDate = "SessionStartDate";
        public const String FLD_NAME_SessionEndDate = "SessionEndDate";

        #endregion
    }
}
