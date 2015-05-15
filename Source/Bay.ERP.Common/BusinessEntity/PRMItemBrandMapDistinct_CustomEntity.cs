// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2012, 03:36:37




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMItemBrandMapDistinct_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMItemBrandMapDistinct_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _BrandID;
        private String _BrandName;
        private Int64? _SupplierID;


        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public String BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        [DataMember]
        public Int64? SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (BrandID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMItemBrandMapDistinct_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_BrandName = "BrandName";
        public const String FLD_NAME_SupplierID = "SupplierID";

        #endregion
    }
}