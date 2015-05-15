// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDItemGroupItemCategoryMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDItemGroupItemCategoryMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _ItemGroupItemCategoryMapID;
        private Int64 _ItemGroupID;
        private Int64 _ItemCategoryID;


        [DataMember]
        public Int64 ItemGroupItemCategoryMapID
        {
            get { return _ItemGroupItemCategoryMapID; }
            set { _ItemGroupItemCategoryMapID = value; }
        }

        [DataMember]
        public Int64 ItemGroupID
        {
            get { return _ItemGroupID; }
            set { _ItemGroupID = value; }
        }

        [DataMember]
        public Int64 ItemCategoryID
        {
            get { return _ItemCategoryID; }
            set { _ItemCategoryID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ItemGroupItemCategoryMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDItemGroupItemCategoryMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ItemGroupItemCategoryMapID = "ItemGroupItemCategoryMapID";
        public const String FLD_NAME_ItemGroupID = "ItemGroupID";
        public const String FLD_NAME_ItemCategoryID = "ItemCategoryID";

        #endregion
    }
}
