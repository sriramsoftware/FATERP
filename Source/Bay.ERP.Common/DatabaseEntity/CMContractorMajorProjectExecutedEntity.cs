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
    [DataContract(Name = "CMContractorMajorProjectExecuted", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMContractorMajorProjectExecutedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ContractorMajorProjectExecutedID;
        private Int64 _ContractorID;
        private String _Name;


        [DataMember]
        public Int64 ContractorMajorProjectExecutedID
        {
            get { return _ContractorMajorProjectExecutedID; }
            set { _ContractorMajorProjectExecutedID = value; }
        }

        [DataMember]
        public Int64 ContractorID
        {
            get { return _ContractorID; }
            set { _ContractorID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ContractorMajorProjectExecutedID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMContractorMajorProjectExecutedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ContractorMajorProjectExecutedID = "ContractorMajorProjectExecutedID";
        public const String FLD_NAME_ContractorID = "ContractorID";
        public const String FLD_NAME_Name = "Name";

        #endregion
    }
}
