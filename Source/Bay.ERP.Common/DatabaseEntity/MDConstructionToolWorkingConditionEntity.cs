// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDConstructionToolWorkingCondition", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDConstructionToolWorkingConditionEntity : BaseEntity
    {
        #region Properties


        private Int64 _ConstructionToolWorkingConditionID;
        private String _Name;
        private String _Description;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ConstructionToolWorkingConditionID
        {
            get { return _ConstructionToolWorkingConditionID; }
            set { _ConstructionToolWorkingConditionID = value; }
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
                return (ConstructionToolWorkingConditionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDConstructionToolWorkingConditionEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ConstructionToolWorkingConditionID = "ConstructionToolWorkingConditionID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
