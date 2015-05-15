// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:00:20




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACMDBankAccountPaymentApprovalStatus", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACMDBankAccountPaymentApprovalStatusEntity : BaseEntity
    {
        #region Properties


        private Int64 _BankAccountPaymentApprovalStatusID;
        private String _Name;
        private String _Description;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 BankAccountPaymentApprovalStatusID
        {
            get { return _BankAccountPaymentApprovalStatusID; }
            set { _BankAccountPaymentApprovalStatusID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Description
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
                return (BankAccountPaymentApprovalStatusID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACMDBankAccountPaymentApprovalStatusEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BankAccountPaymentApprovalStatusID = "BankAccountPaymentApprovalStatusID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
