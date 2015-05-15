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
    [DataContract(Name = "MDSupplierItemCategory", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDSupplierItemCategoryEntity : BaseEntity
    {
        #region Properties


        private Int64 _SupplierItemCategoryID;
        private String _Name;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 SupplierItemCategoryID
        {
            get { return _SupplierItemCategoryID; }
            set { _SupplierItemCategoryID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
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
                return (SupplierItemCategoryID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDSupplierItemCategoryEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SupplierItemCategoryID = "SupplierItemCategoryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
