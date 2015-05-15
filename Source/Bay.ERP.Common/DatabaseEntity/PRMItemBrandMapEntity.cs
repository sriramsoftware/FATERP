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
    [DataContract(Name = "PRMItemBrandMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMItemBrandMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _ItemBrandMapID;
        private Int64 _ItemID;
        private Int64 _BrandID;


        [DataMember]
        public Int64 ItemBrandMapID
        {
            get { return _ItemBrandMapID; }
            set { _ItemBrandMapID = value; }
        }

        [DataMember]
        public Int64 ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
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

        public PRMItemBrandMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ItemBrandMapID = "ItemBrandMapID";
        public const String FLD_NAME_ItemID = "ItemID";
        public const String FLD_NAME_BrandID = "BrandID";

        #endregion
    }
}
