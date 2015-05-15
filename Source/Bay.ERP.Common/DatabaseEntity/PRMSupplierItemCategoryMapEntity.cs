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
    [DataContract(Name = "PRMSupplierItemCategoryMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMSupplierItemCategoryMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _SupplierItemCategoryMapID;
        private Int64 _SupplierItemCategoryID;
        private Int64 _SupplierID;


        [DataMember]
        public Int64 SupplierItemCategoryMapID
        {
            get { return _SupplierItemCategoryMapID; }
            set { _SupplierItemCategoryMapID = value; }
        }

        [DataMember]
        public Int64 SupplierItemCategoryID
        {
            get { return _SupplierItemCategoryID; }
            set { _SupplierItemCategoryID = value; }
        }

        [DataMember]
        public Int64 SupplierID
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
                return (SupplierItemCategoryMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMSupplierItemCategoryMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SupplierItemCategoryMapID = "SupplierItemCategoryMapID";
        public const String FLD_NAME_SupplierItemCategoryID = "SupplierItemCategoryID";
        public const String FLD_NAME_SupplierID = "SupplierID";

        #endregion
    }
}
