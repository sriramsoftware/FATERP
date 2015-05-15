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
    [DataContract(Name = "APMemberFeedbackRemarks", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class APMemberFeedbackRemarksEntity : BaseEntity
    {
        #region Properties


        private Int64 _APMemberFeedbackRemarksID;
        private Int64 _APApprovalProcessID;
        private String _Remarks;
        private DateTime _RemarksDateTime;
        private Int64 _EmployeeID;
        private Int64 _APFeedbackID;
        private Int64? _ProxyEmployeeID;
        private Boolean _IsProxyEmployeeRemarks;
        private String _ProxyEmployeeRemarks;


        [DataMember]
        public Int64 APMemberFeedbackRemarksID
        {
            get { return _APMemberFeedbackRemarksID; }
            set { _APMemberFeedbackRemarksID = value; }
        }

        [DataMember]
        public Int64 APApprovalProcessID
        {
            get { return _APApprovalProcessID; }
            set { _APApprovalProcessID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime RemarksDateTime
        {
            get { return _RemarksDateTime; }
            set { _RemarksDateTime = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int64 APFeedbackID
        {
            get { return _APFeedbackID; }
            set { _APFeedbackID = value; }
        }

        [DataMember]
        public Int64? ProxyEmployeeID
        {
            get { return _ProxyEmployeeID; }
            set { _ProxyEmployeeID = value; }
        }

        [DataMember]
        public Boolean IsProxyEmployeeRemarks
        {
            get { return _IsProxyEmployeeRemarks; }
            set { _IsProxyEmployeeRemarks = value; }
        }

        [DataMember]
        public String ProxyEmployeeRemarks
        {
            get { return _ProxyEmployeeRemarks; }
            set { _ProxyEmployeeRemarks = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (APMemberFeedbackRemarksID <= 0);
            }
        }


        #endregion

        #region Constructor

        public APMemberFeedbackRemarksEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_APMemberFeedbackRemarksID = "APMemberFeedbackRemarksID";
        public const String FLD_NAME_APApprovalProcessID = "APApprovalProcessID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_RemarksDateTime = "RemarksDateTime";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_APFeedbackID = "APFeedbackID";
        public const String FLD_NAME_ProxyEmployeeID = "ProxyEmployeeID";
        public const String FLD_NAME_IsProxyEmployeeRemarks = "IsProxyEmployeeRemarks";
        public const String FLD_NAME_ProxyEmployeeRemarks = "ProxyEmployeeRemarks";

        #endregion
    }
}
