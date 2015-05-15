// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Oct-2012, 04:39:52




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "APForwardInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class APForwardInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _APForwardInfoID;
        private Int64 _APMemberFeedbackID;
        private Int64 _APApprovalProcessID;
        private Int64 _APMemberFeedbackRemarksID;
        private Int64 _DepartmentID;
        private Int64 _EmployeeID;
        private DateTime _CommentRequestDate;
        private DateTime? _CommentSubmitDate;
        private String _APMemberComment;
        private String _APForwardMemberComment;


        [DataMember]
        public Int64 APForwardInfoID
        {
            get { return _APForwardInfoID; }
            set { _APForwardInfoID = value; }
        }

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
        public Int64 APMemberFeedbackRemarksID
        {
            get { return _APMemberFeedbackRemarksID; }
            set { _APMemberFeedbackRemarksID = value; }
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
        public DateTime CommentRequestDate
        {
            get { return _CommentRequestDate; }
            set { _CommentRequestDate = value; }
        }

        [DataMember]
        public DateTime? CommentSubmitDate
        {
            get { return _CommentSubmitDate; }
            set { _CommentSubmitDate = value; }
        }

        [DataMember]
        public String APMemberComment
        {
            get { return _APMemberComment; }
            set { _APMemberComment = value; }
        }

        [DataMember]
        public String APForwardMemberComment
        {
            get { return _APForwardMemberComment; }
            set { _APForwardMemberComment = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (APForwardInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public APForwardInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_APForwardInfoID = "APForwardInfoID";
        public const String FLD_NAME_APMemberFeedbackID = "APMemberFeedbackID";
        public const String FLD_NAME_APApprovalProcessID = "APApprovalProcessID";
        public const String FLD_NAME_APMemberFeedbackRemarksID = "APMemberFeedbackRemarksID";
        public const String FLD_NAME_DepartmentID = "DepartmentID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_CommentRequestDate = "CommentRequestDate";
        public const String FLD_NAME_CommentSubmitDate = "CommentSubmitDate";
        public const String FLD_NAME_APMemberComment = "APMemberComment";
        public const String FLD_NAME_APForwardMemberComment = "APForwardMemberComment";

        #endregion
    }
}
