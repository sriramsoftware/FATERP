// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMNApprovalProcess", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMNApprovalProcessEntity : BaseEntity
    {
        #region Properties


        private Int64 _ApprovalProcessID;
        private Int64 _ReferenceID;
        private Int64 _ApprovalProcessTypeID;
        private DateTime _CreateDate;
        private Int64 _ApprovalProcessStatusID;
        private Int64 _ApprovalProcessPriorityID;


        [DataMember]
        public Int64 ApprovalProcessID
        {
            get { return _ApprovalProcessID; }
            set { _ApprovalProcessID = value; }
        }

        [DataMember]
        public Int64 ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public Int64 ApprovalProcessTypeID
        {
            get { return _ApprovalProcessTypeID; }
            set { _ApprovalProcessTypeID = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public Int64 ApprovalProcessStatusID
        {
            get { return _ApprovalProcessStatusID; }
            set { _ApprovalProcessStatusID = value; }
        }

        [DataMember]
        public Int64 ApprovalProcessPriorityID
        {
            get { return _ApprovalProcessPriorityID; }
            set { _ApprovalProcessPriorityID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ApprovalProcessID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMNApprovalProcessEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ApprovalProcessID = "ApprovalProcessID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_ApprovalProcessTypeID = "ApprovalProcessTypeID";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_ApprovalProcessStatusID = "ApprovalProcessStatusID";
        public const String FLD_NAME_ApprovalProcessPriorityID = "ApprovalProcessPriorityID";

        #endregion
    }
}
