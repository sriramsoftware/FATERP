// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jun-2013, 05:57:56




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "APApprovalProcessPanelMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class APApprovalProcessPanelMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _ApprovalProcessPanelMapID;
        private Int64 _APApprovalProcessID;
        private Int64 _APPanelID;
        private String _Remarks;


        [DataMember]
        public Int64 ApprovalProcessPanelMapID
        {
            get { return _ApprovalProcessPanelMapID; }
            set { _ApprovalProcessPanelMapID = value; }
        }

        [DataMember]
        public Int64 APApprovalProcessID
        {
            get { return _APApprovalProcessID; }
            set { _APApprovalProcessID = value; }
        }

        [DataMember]
        public Int64 APPanelID
        {
            get { return _APPanelID; }
            set { _APPanelID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ApprovalProcessPanelMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public APApprovalProcessPanelMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ApprovalProcessPanelMapID = "ApprovalProcessPanelMapID";
        public const String FLD_NAME_APApprovalProcessID = "APApprovalProcessID";
        public const String FLD_NAME_APPanelID = "APPanelID";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
