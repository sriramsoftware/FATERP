// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jun-2013, 02:26:08




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACBankAccountPaymentPostPayableStatementDetailMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACBankAccountPaymentPostPayableStatementDetailMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _BankAccountPaymentPostPayableStatementDetailMapID;
        private Int64 _BankAccountPaymentID;
        private Int64 _PostPayableStatementDetailID;
        private String _Remarks;


        [DataMember]
        public Int64 BankAccountPaymentPostPayableStatementDetailMapID
        {
            get { return _BankAccountPaymentPostPayableStatementDetailMapID; }
            set { _BankAccountPaymentPostPayableStatementDetailMapID = value; }
        }

        [DataMember]
        public Int64 BankAccountPaymentID
        {
            get { return _BankAccountPaymentID; }
            set { _BankAccountPaymentID = value; }
        }

        [DataMember]
        public Int64 PostPayableStatementDetailID
        {
            get { return _PostPayableStatementDetailID; }
            set { _PostPayableStatementDetailID = value; }
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
                return (BankAccountPaymentPostPayableStatementDetailMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACBankAccountPaymentPostPayableStatementDetailMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BankAccountPaymentPostPayableStatementDetailMapID = "BankAccountPaymentPostPayableStatementDetailMapID";
        public const String FLD_NAME_BankAccountPaymentID = "BankAccountPaymentID";
        public const String FLD_NAME_PostPayableStatementDetailID = "PostPayableStatementDetailID";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
