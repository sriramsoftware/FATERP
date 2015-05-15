// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "HRSession", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class HRSessionEntity : BaseEntity
    {
        #region Properties


        private Int64 _SessionID;
        private Int64 _SessionCategoryID;
        private String _SessionName;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private DateTime _DeadlineDate;
        private Int64 _EvaluationSessionStatusID;
        private String _Remarks;
        private Int64 _CreatedByEmployeeID;
        private DateTime _CreateDate;
        private String _IP;


        [DataMember]
        public Int64 SessionID
        {
            get { return _SessionID; }
            set { _SessionID = value; }
        }

        [DataMember]
        public Int64 SessionCategoryID
        {
            get { return _SessionCategoryID; }
            set { _SessionCategoryID = value; }
        }

        [DataMember]
        public String SessionName
        {
            get { return _SessionName; }
            set { _SessionName = value; }
        }

        [DataMember]
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        [DataMember]
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        [DataMember]
        public DateTime DeadlineDate
        {
            get { return _DeadlineDate; }
            set { _DeadlineDate = value; }
        }

        [DataMember]
        public Int64 EvaluationSessionStatusID
        {
            get { return _EvaluationSessionStatusID; }
            set { _EvaluationSessionStatusID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 CreatedByEmployeeID
        {
            get { return _CreatedByEmployeeID; }
            set { _CreatedByEmployeeID = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public String IP
        {
            get { return _IP; }
            set { _IP = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SessionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public HRSessionEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SessionID = "SessionID";
        public const String FLD_NAME_SessionCategoryID = "SessionCategoryID";
        public const String FLD_NAME_SessionName = "SessionName";
        public const String FLD_NAME_StartDate = "StartDate";
        public const String FLD_NAME_EndDate = "EndDate";
        public const String FLD_NAME_DeadlineDate = "DeadlineDate";
        public const String FLD_NAME_EvaluationSessionStatusID = "EvaluationSessionStatusID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreatedByEmployeeID = "CreatedByEmployeeID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_IP = "IP";

        #endregion
    }
}
