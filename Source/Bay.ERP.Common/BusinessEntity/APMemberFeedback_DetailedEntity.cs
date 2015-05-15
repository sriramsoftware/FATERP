// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:49:00




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "APMemberFeedback_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class APMemberFeedback_DetailedEntity : BaseEntity
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
        private String _DepartmentName;
        private String _DesignationName;
        private String _MemberFullName;
        private String _APFeedbackName;
        private String _ProxyMemberFullName;
        private Int64? _RowNumber;


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

        [DataMember]
        public String DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }

        [DataMember]
        public String DesignationName
        {
            get { return _DesignationName; }
            set { _DesignationName = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public String APFeedbackName
        {
            get { return _APFeedbackName; }
            set { _APFeedbackName = value; }
        }

        [DataMember]
        public String ProxyMemberFullName
        {
            get { return _ProxyMemberFullName; }
            set { _ProxyMemberFullName = value; }
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
                return (APMemberFeedbackID <= 0);
            }
        }


        #endregion

        #region Constructor

        public APMemberFeedback_DetailedEntity() : base()
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
        public const String FLD_NAME_DepartmentName = "DepartmentName";
        public const String FLD_NAME_DesignationName = "DesignationName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_APFeedbackName = "APFeedbackName";
        public const String FLD_NAME_ProxyMemberFullName = "ProxyMemberFullName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
