// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Apr-2012, 03:22:36




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMSupplierByBrand_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMSupplierByBrand_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _SupplierBrandMapID;
        private Int64 _BrandID;
        private Int64 _SupplierID;
        private String _SupplierCode;
        private String _SupplierName;


        [DataMember]
        public Int64 SupplierBrandMapID
        {
            get { return _SupplierBrandMapID; }
            set { _SupplierBrandMapID = value; }
        }

        [DataMember]
        public Int64 BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public String SupplierCode
        {
            get { return _SupplierCode; }
            set { _SupplierCode = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
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

        public PRMSupplierByBrand_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SupplierBrandMapID = "SupplierBrandMapID";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_SupplierCode = "SupplierCode";
        public const String FLD_NAME_SupplierName = "SupplierName";

        #endregion
    }
}
