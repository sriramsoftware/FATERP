// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jul-2012, 03:56:56




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "PRMSupplierByProjectDistinct_Custom", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class PRMSupplierByProjectDistinct_CustomEntity : BaseEntity
    {
        #region Properties


        private Int64 _SupplierID;
        private String _SupplierName;
        private Int64? _ProjectID;


        [DataMember]
        public Int64 SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }

        [DataMember]
        public String SupplierName
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }

        [DataMember]
        public Int64? ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (SupplierID <= 0);
            }
        }


        #endregion

        #region Constructor

        public PRMSupplierByProjectDistinct_CustomEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_SupplierID = "SupplierID";
        public const String FLD_NAME_SupplierName = "SupplierName";
        public const String FLD_NAME_ProjectID = "ProjectID";

        #endregion
    }
}
