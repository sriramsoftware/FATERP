// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;
using Bay.ERP.Common.CustomAttribute;
using Bay.ERP.Common.Shared;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDItem", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDItemEntity : BaseEntity
    {
        #region Properties


        private Int64 _ItemID;
        private Int64 _ItemCategoryID;
        private String _ItemName;
        private Int64? _UnitID;
        private String _Description;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Int64 ItemCategoryID
        {
            get { return _ItemCategoryID; }
            set { _ItemCategoryID = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public Int64? UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
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
                return (ItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDItemEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_ItemCategoryID = "ItemCategoryID";
        [CustomSearchAttribute("Item Name", "ItemName", true, SearchConstants.SearchDataType.String)]
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_UnitID = "UnitID";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
