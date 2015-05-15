// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Feb-2013, 01:42:07




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACTemporaryJournalMaster_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACTemporaryJournalMaster_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _TemporaryJournalMasterID;
        private String _Remarks;
        private DateTime _CreateDate;
        private Int64 _TemporyJournalApprovalStatusID;
        private String _TemporaryJournalApprovalStatusName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 TemporaryJournalMasterID
        {
            get { return _TemporaryJournalMasterID; }
            set { _TemporaryJournalMasterID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        [DataMember]
        public Int64 TemporyJournalApprovalStatusID
        {
            get { return _TemporyJournalApprovalStatusID; }
            set { _TemporyJournalApprovalStatusID = value; }
        }

        [DataMember]
        public String TemporaryJournalApprovalStatusName
        {
            get { return _TemporaryJournalApprovalStatusName; }
            set { _TemporaryJournalApprovalStatusName = value; }
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
                return (TemporaryJournalMasterID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACTemporaryJournalMaster_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TemporaryJournalMasterID = "TemporaryJournalMasterID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_TemporyJournalApprovalStatusID = "TemporyJournalApprovalStatusID";
        public const String FLD_NAME_TemporaryJournalApprovalStatusName = "TemporaryJournalApprovalStatusName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
