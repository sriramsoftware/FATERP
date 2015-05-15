// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 11:02:33




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMSupplierBrandMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMSupplierBrandMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _SupplierBrandMapID;
        private Int64 _SupplierID;
        private Int64 _BrandID;
        private Int64? _OriginRegionID;
        private Int64? _OriginCountryID;


        [DataMember]
        public Int64 SupplierBrandMapID
        {
            get { return _SupplierBrandMapID; }
            set { _SupplierBrandMapID = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64? OriginRegionID
        {
            get { return _OriginRegionID; }
            set { _OriginRegionID = value; }
        }

        [DataMember]
        public Int64? OriginCountryID
        {
            get { return _OriginCountryID; }
            set { _OriginCountryID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SupplierBrandMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMSupplierBrandMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SupplierBrandMapID = "SupplierBrandMapID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_OriginRegionID = "OriginRegionID";
        public const String FLD_NAME_OriginCountryID = "OriginCountryID";

        #endregion
    }
}
