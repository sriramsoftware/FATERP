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
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.CustomAttribute;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDItemCategory", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDItemCategoryEntity : BaseEntity
    {
        #region Properties


        private Int64 _ItemCategoryID;
        private Int64? _ParentItemCategoryID;
        private String _CategoryName;
        private String _Description;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ItemCategoryID
        {
            get { return _ItemCategoryID; }
            set { _ItemCategoryID = value; }
        }

        [DataMember]
        public Int64? ParentItemCategoryID
        {
            get { return _ParentItemCategoryID; }
            set { _ParentItemCategoryID = value; }
        }

        [DataMember]
        public String CategoryName
        {
            get { return _CategoryName; }
            set { _CategoryName = value; }
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
                return (ItemCategoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDItemCategoryEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ItemCategoryID = "ItemCategoryID";
        public const String FLD_NAME_ParentItemCategoryID = "ParentItemCategoryID";
        [CustomSearchAttribute("Category Name", "CategoryName", true, SearchConstants.SearchDataType.String)]
        public const String FLD_NAME_CategoryName = "CategoryName";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
