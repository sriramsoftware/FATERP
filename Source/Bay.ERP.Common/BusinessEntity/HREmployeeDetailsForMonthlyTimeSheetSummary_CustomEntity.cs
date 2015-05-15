// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jan-2014, 04:42:27




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HREmployeeDetailsForMonthlyTimeSheetSummary_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _SalarySessionID;
        private Int64 _OnJob;
        private Int64 _Holiday;
        private Int64 _LeaveDay;
        private Int64 _ActualWorkingDay;


        [DataMember]
        public Int64 SalarySessionID
        {
            get { return _SalarySessionID; }
            set { _SalarySessionID = value; }
        }

        [DataMember]
        public Int64 OnJob
        {
            get { return _OnJob; }
            set { _OnJob = value; }
        }

        [DataMember]
        public Int64 Holiday
        {
            get { return _Holiday; }
            set { _Holiday = value; }
        }

        [DataMember]
        public Int64 LeaveDay
        {
            get { return _LeaveDay; }
            set { _LeaveDay = value; }
        }

        [DataMember]
        public Int64 ActualWorkingDay
        {
            get { return _ActualWorkingDay; }
            set { _ActualWorkingDay = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SalarySessionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_OnJob = "OnJob";
        public const String FLD_NAME_Holiday = "Holiday";
        public const String FLD_NAME_LeaveDay = "LeaveDay";
        public const String FLD_NAME_ActualWorkingDay = "ActualWorkingDay";

        
        #endregion
    }
}
