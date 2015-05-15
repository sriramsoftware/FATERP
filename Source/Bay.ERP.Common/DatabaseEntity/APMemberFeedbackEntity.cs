// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "APMemberFeedback", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class APMemberFeedbackEntity : BaseEntity
    {
        #region Properties


        private Int64 _APMemberFeedbackID;
        private Int64 _APApprovalProcessID;
        private Int64 _DepartmentID;
        private Int64 _EmployeeID;
        private Int32 _SequenceNo;
        private Int64 _APFeedbackID;
        private DateTime? _FeedbackRequestDate;
        private DateTime? _FeedbackLastResponseDate;
        private DateTime? _FeedbackSubmitDate;
        private Int64? _ProxyEmployeeID;
        private Boolean _IsProxyEmployeeEnabled;


        [DataMember]
        public Int64 APMemberFeedbackID
        {
            get { return _APMemberFeedbackID; }
            set { _APMemberFeedbackID = value; }
        }

        [DataMember]
        public Int64 APApprovalProcessID
        {
            get { return _APApprovalProcessID; }
            set { _APApprovalProcessID = value; }
        }

        [DataMember]
        public Int64 DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int32 SequenceNo
        {
            get { return _SequenceNo; }
            set { _SequenceNo = value; }
        }

        [DataMember]
        public Int64 APFeedbackID
        {
            get { return _APFeedbackID; }
            set { _APFeedbackID = value; }
        }

        [DataMember]
        public DateTime? FeedbackRequestDate
        {
            get { return _FeedbackRequestDate; }
            set { _FeedbackRequestDate = value; }
        }

        [DataMember]
        public DateTime? FeedbackLastResponseDate
        {
            get { return _FeedbackLastResponseDate; }
            set { _FeedbackLastResponseDate = value; }
        }

        [DataMember]
        public DateTime? FeedbackSubmitDate
        {
            get { return _FeedbackSubmitDate; }
            set { _FeedbackSubmitDate = value; }
        }

        [DataMember]
        public Int64? ProxyEmployeeID
        {
            get { return _ProxyEmployeeID; }
            set { _ProxyEmployeeID = value; }
        }

        [DataMember]
        public Boolean IsProxyEmployeeEnabled
        {
            get { return _IsProxyEmployeeEnabled; }
            set { _IsProxyEmployeeEnabled = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (APMemberFeedbackID <= 0);
            }
        }


        #endregion

        #region Constructor

        public APMemberFeedbackEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_APMemberFeedbackID = "APMemberFeedbackID";
        public const String FLD_NAME_APApprovalProcessID = "APApprovalProcessID";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_SequenceNo = "SequenceNo";
        public const String FLD_NAME_APFeedbackID = "APFeedbackID";
        public const String FLD_NAME_FeedbackRequestDate = "FeedbackRequestDate";
        public const String FLD_NAME_FeedbackLastResponseDate = "FeedbackLastResponseDate";
        public const String FLD_NAME_FeedbackSubmitDate = "FeedbackSubmitDate";
        public const String FLD_NAME_ProxyEmployeeID = "ProxyEmployeeID";
        public const String FLD_NAME_IsProxyEmployeeEnabled = "IsProxyEmployeeEnabled";

        #endregion
    }
}
