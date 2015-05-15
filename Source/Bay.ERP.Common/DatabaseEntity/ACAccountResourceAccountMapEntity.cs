// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jun-2013, 03:54:41




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACAccountResourceAccountMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACAccountResourceAccountMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _ResourceAccountMapID;
        private Int64 _AccountID;
        private Int64 _AccountResourceCategoryID;
        private Int64 _ReferenceID;
        private String _Remarks;


        [DataMember]
        public Int64 ResourceAccountMapID
        {
            get { return _ResourceAccountMapID; }
            set { _ResourceAccountMapID = value; }
        }

        [DataMember]
        public Int64 AccountID
        {
            get { return _AccountID; }
            set { _AccountID = value; }
        }

        [DataMember]
        public Int64 AccountResourceCategoryID
        {
            get { return _AccountResourceCategoryID; }
            set { _AccountResourceCategoryID = value; }
        }

        [DataMember]
        public Int64 ReferenceID
        {
            get { return _ReferenceID; }
            set { _ReferenceID = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ResourceAccountMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACAccountResourceAccountMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ResourceAccountMapID = "ResourceAccountMapID";
        public const String FLD_NAME_AccountID = "AccountID";
        public const String FLD_NAME_AccountResourceCategoryID = "AccountResourceCategoryID";
        public const String FLD_NAME_ReferenceID = "ReferenceID";
        public const String FLD_NAME_Remarks = "Remarks";

        #endregion
    }
}
