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
    [DataContract(Name = "CMNApprovalPanel", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMNApprovalPanelEntity : BaseEntity
    {
        #region Properties


        private Int64 _ApprovalPanelID;
        private Int64 _ApprovalProcessID;
        private Int64 _EmployeeID;
        private Int32 _SequeenceNo;
        private Int64 _ApprovalPanelStatusID;
        private String _Remarks;
        private DateTime _RequestDate;
        private DateTime? _ResponseDate;


        [DataMember]
        public Int64 ApprovalPanelID
        {
            get { return _ApprovalPanelID; }
            set { _ApprovalPanelID = value; }
        }

        [DataMember]
        public Int64 ApprovalProcessID
        {
            get { return _ApprovalProcessID; }
            set { _ApprovalProcessID = value; }
        }

        [DataMember]
        public Int64 EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        [DataMember]
        public Int32 SequeenceNo
        {
            get { return _SequeenceNo; }
            set { _SequeenceNo = value; }
        }

        [DataMember]
        public Int64 ApprovalPanelStatusID
        {
            get { return _ApprovalPanelStatusID; }
            set { _ApprovalPanelStatusID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime RequestDate
        {
            get { return _RequestDate; }
            set { _RequestDate = value; }
        }

        [DataMember]
        public DateTime? ResponseDate
        {
            get { return _ResponseDate; }
            set { _ResponseDate = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ApprovalPanelID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMNApprovalPanelEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ApprovalPanelID = "ApprovalPanelID";
        public const String FLD_NAME_ApprovalProcessID = "ApprovalProcessID";
        public const String FLD_NAME_EmployeeID = "EmployeeID";
        public const String FLD_NAME_SequeenceNo = "SequeenceNo";
        public const String FLD_NAME_ApprovalPanelStatusID = "ApprovalPanelStatusID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_RequestDate = "RequestDate";
        public const String FLD_NAME_ResponseDate = "ResponseDate";

        #endregion
    }
}
