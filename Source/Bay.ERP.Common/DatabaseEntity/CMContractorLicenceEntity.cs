// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMContractorLicence", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMContractorLicenceEntity : BaseEntity
    {
        #region Properties


        private Int64 _ContractorLicenceID;
        private Int64 _ContractorID;
        private String _LicenceNo;


        [DataMember]
        public Int64 ContractorLicenceID
        {
            get { return _ContractorLicenceID; }
            set { _ContractorLicenceID = value; }
        }

        [DataMember]
        public Int64 ContractorID
        {
            get { return _ContractorID; }
            set { _ContractorID = value; }
        }

        [DataMember]
        public String LicenceNo
        {
            get { return _LicenceNo; }
            set { _LicenceNo = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ContractorLicenceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMContractorLicenceEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ContractorLicenceID = "ContractorLicenceID";
        public const String FLD_NAME_ContractorID = "ContractorID";
        public const String FLD_NAME_LicenceNo = "LicenceNo";

        #endregion
    }
}
