// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Jan-2013, 03:53:14




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVStoreIssueNote_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVStoreIssueNote_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _StoreIssueNoteID;
        private Int64 _ProjectID;
        private String _StoreIssueNoteNo;
        private String _SRFNo;
        private Int64 _RequestedByEmployeeID;
        private DateTime _RequestDate;
        private String _Remarks;
        private Int64 _StoreIssueNoteApprovalStatusID;
        private Boolean _IsRemoved;
        private String _BDProjectProjectName;
        private String _MemberFullName;
        private String _MDStoreIssueNoteApprovalStatusName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 StoreIssueNoteID
        {
            get { return _StoreIssueNoteID; }
            set { _StoreIssueNoteID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String StoreIssueNoteNo
        {
            get { return _StoreIssueNoteNo; }
            set { _StoreIssueNoteNo = value; }
        }

        [DataMember]
        public String SRFNo
        {
            get { return _SRFNo; }
            set { _SRFNo = value; }
        }

        [DataMember]
        public Int64 RequestedByEmployeeID
        {
            get { return _RequestedByEmployeeID; }
            set { _RequestedByEmployeeID = value; }
        }

        [DataMember]
        public DateTime RequestDate
        {
            get { return _RequestDate; }
            set { _RequestDate = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 StoreIssueNoteApprovalStatusID
        {
            get { return _StoreIssueNoteApprovalStatusID; }
            set { _StoreIssueNoteApprovalStatusID = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [DataMember]
        public String BDProjectProjectName
        {
            get { return _BDProjectProjectName; }
            set { _BDProjectProjectName = value; }
        }

        [DataMember]
        public String MemberFullName
        {
            get { return _MemberFullName; }
            set { _MemberFullName = value; }
        }

        [DataMember]
        public String MDStoreIssueNoteApprovalStatusName
        {
            get { return _MDStoreIssueNoteApprovalStatusName; }
            set { _MDStoreIssueNoteApprovalStatusName = value; }
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
                return (StoreIssueNoteID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVStoreIssueNote_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_StoreIssueNoteID = "StoreIssueNoteID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_StoreIssueNoteNo = "StoreIssueNoteNo";
        public const String FLD_NAME_SRFNo = "SRFNo";
        public const String FLD_NAME_RequestedByEmployeeID = "RequestedByEmployeeID";
        public const String FLD_NAME_RequestDate = "RequestDate";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_StoreIssueNoteApprovalStatusID = "StoreIssueNoteApprovalStatusID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_BDProjectProjectName = "BDProjectProjectName";
        public const String FLD_NAME_MemberFullName = "MemberFullName";
        public const String FLD_NAME_MDStoreIssueNoteApprovalStatusName = "MDStoreIssueNoteApprovalStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
