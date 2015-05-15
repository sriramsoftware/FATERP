// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Feb-2012, 04:20:01




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ResourceContractor_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ResourceContractor_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _ResourceID;
        private Int64 _ReferenceID;
        private Int64 _ResourceCategoryID;
        private String _ResourceCategoryName;
        private String _ContractorName;


        [DataMember]
        public Int64 ResourceID
        {
            get { return _ResourceID; }
            set { _ResourceID = value; }
        }

        [DataMember]
        public Int64 ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public Int64 ResourceCategoryID
        {
            get { return _ResourceCategoryID; }
            set { _ResourceCategoryID = value; }
        }

        [DataMember]
        public String ResourceCategoryName
        {
            get { return _ResourceCategoryName; }
            set { _ResourceCategoryName = value; }
        }

        [DataMember]
        public String ContractorName
        {
            get { return _ContractorName; }
            set { _ContractorName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ResourceID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ResourceContractor_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ResourceID = "ResourceID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_ResourceCategoryID = "ResourceCategoryID";
        public const String FLD_NAME_ResourceCategoryName = "ResourceCategoryName";
        public const String FLD_NAME_ContractorName = "ContractorName";

        #endregion
    }
}
