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
    [DataContract(Name = "CMContractorEquipmentList", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMContractorEquipmentListEntity : BaseEntity
    {
        #region Properties


        private Int64 _ContractorEquipmentID;
        private Int64 _ContractorID;
        private Int64 _ConstructionToolID;


        [DataMember]
        public Int64 ContractorEquipmentID
        {
            get { return _ContractorEquipmentID; }
            set { _ContractorEquipmentID = value; }
        }

        [DataMember]
        public Int64 ContractorID
        {
            get { return _ContractorID; }
            set { _ContractorID = value; }
        }

        [DataMember]
        public Int64 ConstructionToolID
        {
            get { return _ConstructionToolID; }
            set { _ConstructionToolID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ContractorEquipmentID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMContractorEquipmentListEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ContractorEquipmentID = "ContractorEquipmentID";
        public const String FLD_NAME_ContractorID = "ContractorID";
        public const String FLD_NAME_ConstructionToolID = "ConstructionToolID";

        #endregion
    }
}
