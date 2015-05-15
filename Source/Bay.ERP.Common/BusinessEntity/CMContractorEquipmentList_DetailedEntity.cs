// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 06:01:25




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "CMContractorEquipmentList_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class CMContractorEquipmentList_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ContractorEquipmentID;
        private Int64 _ContractorID;
        private Int64 _ConstructionToolID;
        private String _ContractorName;
        private String _ConstructionToolName;
        private Int64? _RowNumber;


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

        [DataMember]
        public String ContractorName
        {
            get { return _ContractorName; }
            set { _ContractorName = value; }
        }

        [DataMember]
        public String ConstructionToolName
        {
            get { return _ConstructionToolName; }
            set { _ConstructionToolName = value; }
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
                return (ContractorEquipmentID <= 0);
            }
        }


        #endregion

        #region Constructor

        public CMContractorEquipmentList_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ContractorEquipmentID = "ContractorEquipmentID";
        public const String FLD_NAME_ContractorID = "ContractorID";
        public const String FLD_NAME_ConstructionToolID = "ConstructionToolID";
        public const String FLD_NAME_ContractorName = "ContractorName";
        public const String FLD_NAME_ConstructionToolName = "ConstructionToolName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
