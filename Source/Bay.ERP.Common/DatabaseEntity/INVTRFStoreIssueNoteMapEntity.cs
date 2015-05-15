// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Jan-2013, 04:16:20




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "INVTRFStoreIssueNoteMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class INVTRFStoreIssueNoteMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _TRFStoreIssueNoteMapID;
        private Int64 _StoreIssueNoteID;
        private Int64 _TransferID;
        private String _Remarks;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 TRFStoreIssueNoteMapID
        {
            get { return _TRFStoreIssueNoteMapID; }
            set { _TRFStoreIssueNoteMapID = value; }
        }

        [DataMember]
        public Int64 StoreIssueNoteID
        {
            get { return _StoreIssueNoteID; }
            set { _StoreIssueNoteID = value; }
        }

        [DataMember]
        public Int64 TransferID
        {
            get { return _TransferID; }
            set { _TransferID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Boolean IsRemoved
        {
            get { return _IsRemoved; }
            set { _IsRemoved = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (TRFStoreIssueNoteMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public INVTRFStoreIssueNoteMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TRFStoreIssueNoteMapID = "TRFStoreIssueNoteMapID";
        public const String FLD_NAME_StoreIssueNoteID = "StoreIssueNoteID";
        public const String FLD_NAME_TransferID = "TransferID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
