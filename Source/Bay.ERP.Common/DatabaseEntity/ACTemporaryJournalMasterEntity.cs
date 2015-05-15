// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 02:08:21




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACTemporaryJournalMaster", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACTemporaryJournalMasterEntity : BaseEntity
    {
        #region Properties


        private Int64 _TemporaryJournalMasterID;
        private String _Remarks;
        private DateTime _CreateDate;
        private Int64 _TemporyJournalApprovalStatusID;


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

        public ACTemporaryJournalMasterEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_TemporaryJournalMasterID = "TemporaryJournalMasterID";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_CreateDate = "CreateDate";
        public const String FLD_NAME_TemporyJournalApprovalStatusID = "TemporyJournalApprovalStatusID";

        #endregion
    }
}
