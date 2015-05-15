// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jan-2012, 12:40:04




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDItem_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDItem_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _ParentItemCategoryID;
        private Int64 _SubCategoryID;
        private String _ParentCategoryName;
        private String _SubCategory;
        private String _ItemName;
        private String _UnitName;
        private String _Description;
        private Int64 _ItemID;


        [DataMember]
        public Int64 ParentItemCategoryID
        {
            get { return _ParentItemCategoryID; }
            set { _ParentItemCategoryID = value; }
        }

        [DataMember]
        public Int64 SubCategoryID
        {
            get { return _SubCategoryID; }
            set { _SubCategoryID = value; }
        }

        [DataMember]
        public String ParentCategoryName
        {
            get { return _ParentCategoryName; }
            set { _ParentCategoryName = value; }
        }

        [DataMember]
        public String SubCategory
        {
            get { return _SubCategory; }
            set { _SubCategory = value; }
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
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ParentItemCategoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDItem_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ParentItemCategoryID = "ParentItemCategoryID";
        public const String FLD_NAME_SubCategoryID = "SubCategoryID";
        public const String FLD_NAME_ParentCategoryName = "ParentCategoryName";
        public const String FLD_NAME_SubCategory = "SubCategory";
        public const String FLD_NAME_ItemName = "ItemName";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_ItemID = "ItemID";

        #endregion
    }
}
