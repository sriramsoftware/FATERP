// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Jul-2013, 04:33:39




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
    [DataContract(Name = "MDItem_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDItem_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _ItemID;
        private String _ParentCategoryName;
        private String _CategoryName;
        private String _ItemName;
        private String _UnitName;
        private String _Description;
        private Boolean _IsRemoved;
        private Int64? _UnitID;
        private Int64? _ParentItemCategoryID;
        private Int64 _ItemCategoryID;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public String ParentCategoryName
        {
            get { return _ParentCategoryName; }
            set { _ParentCategoryName = value; }
        }

        [DataMember]
        public String CategoryName
        {
            get { return _CategoryName; }
            set { _CategoryName = value; }
        }

        [DataMember]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
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

        [DataMember]
        public Int64? UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
        }

        [DataMember]
        public Int64? ParentItemCategoryID
        {
            get { return _ParentItemCategoryID; }
            set { _ParentItemCategoryID = value; }
        }

        [DataMember]
        public Int64 ItemCategoryID
        {
            get { return _ItemCategoryID; }
            set { _ItemCategoryID = value; }
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
                return (ItemID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDItem_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_ParentCategoryName = "ParentCategoryName";
        public const String FLD_NAME_CategoryName = "CategoryName";
        [CustomSearchAttribute("Item Name", "ItemName", true, SearchConstants.SearchDataType.String)]
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_UnitID = "UnitID";
        public const String FLD_NAME_ParentItemCategoryID = "ParentItemCategoryID";
        public const String FLD_NAME_ItemCategoryID = "ItemCategoryID";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
