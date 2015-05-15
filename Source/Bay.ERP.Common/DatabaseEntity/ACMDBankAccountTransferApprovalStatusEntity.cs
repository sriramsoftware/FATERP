// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 10:27:29




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACMDBankAccountTransferApprovalStatus", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACMDBankAccountTransferApprovalStatusEntity : BaseEntity
    {
        #region Properties


        private Int64 _BankAccountTransferApprovalStatusID;
        private String _Name;
        private Char? _Description;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 BankAccountTransferApprovalStatusID
        {
            get { return _BankAccountTransferApprovalStatusID; }
            set { _BankAccountTransferApprovalStatusID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public Char? Description
        {
            get { return _Description; }
            set { _Description = value; }
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
                return (BankAccountTransferApprovalStatusID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACMDBankAccountTransferApprovalStatusEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BankAccountTransferApprovalStatusID = "BankAccountTransferApprovalStatusID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
