// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDSalarySession_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDSalarySession_DetailedEntity : BaseEntity
    {
        #region Properties

        private Int64 _SalarySessionID;
        private Int64 _FiscalYearID;
        private String _SalarySessionName;
        private DateTime _SessionStartDate;
        private DateTime _SessionEndDate;
        private String _Remarks;
        private Int64 _SalarySessionStatusID;
        private Boolean _IsCurrentSession;
        private String _SalarySessionStatusName;
        private DateTime _FiscalYearBeginDate;
        private DateTime _FiscalYearEndDate;
        private Int64? _RowNumber;


        

        [DataMember]
        public Int64 SalarySessionID
        {
            get { return _SalarySessionID; }
            set { _SalarySessionID = value; }
        }

        [DataMember]
        public Int64 FiscalYearID
        {
            get { return _FiscalYearID; }
            set { _FiscalYearID = value; }
        }

        [DataMember]
        public String SalarySessionName
        {
            get { return _SalarySessionName; }
            set { _SalarySessionName = value; }
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

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 SalarySessionStatusID
        {
            get { return _SalarySessionStatusID; }
            set { _SalarySessionStatusID = value; }
        }

        [DataMember]
        public Boolean IsCurrentSession
        {
            get { return _IsCurrentSession; }
            set { _IsCurrentSession = value; }
        }

        [DataMember]
        public String SalarySessionStatusName
        {
            get { return _SalarySessionStatusName; }
            set { _SalarySessionStatusName = value; }
        }

        [DataMember]
        public DateTime FiscalYearBeginDate
        {
            get { return _FiscalYearBeginDate; }
            set { _FiscalYearBeginDate = value; }
        }

        [DataMember]
        public DateTime FiscalYearEndDate
        {
            get { return _FiscalYearEndDate; }
            set { _FiscalYearEndDate = value; }
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
                return (SalarySessionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDSalarySession_DetailedEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SalarySessionID = "SalarySessionID";
        public const String FLD_NAME_FiscalYearID = "FiscalYearID";
        public const String FLD_NAME_SalarySessionName = "SalarySessionName";
        public const String FLD_NAME_SessionStartDate = "SessionStartDate";
        public const String FLD_NAME_SessionEndDate = "SessionEndDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_SalarySessionStatusID = "SalarySessionStatusID";
        public const String FLD_NAME_IsCurrentSession = "IsCurrentSession";
        public const String FLD_NAME_SalarySessionStatusName = "SalarySessionStatusName";
        public const String FLD_NAME_FiscalYearBeginDate = "FiscalYearBeginDate";
        public const String FLD_NAME_FiscalYearEndDate = "FiscalYearEndDate";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
