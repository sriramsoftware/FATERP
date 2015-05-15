// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jul-2012, 02:21:44




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMBrandByItem_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMBrandByItem_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _ItemBrandMapID;
        private Int64 _BrandID;
        private Int64 _ItemID;
        private String _BrandName;


        [DataMember]
        public Int64 ItemBrandMapID
        {
            get { return _ItemBrandMapID; }
            set { _ItemBrandMapID = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public String BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ItemBrandMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMBrandByItem_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ItemBrandMapID = "ItemBrandMapID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_BrandName = "BrandName";

        #endregion
    }
}
