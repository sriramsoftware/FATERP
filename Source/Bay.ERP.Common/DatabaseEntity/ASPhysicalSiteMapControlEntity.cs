// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ASPhysicalSiteMapControl", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ASPhysicalSiteMapControlEntity : BaseEntity
    {
        #region Properties


        private Int64 _ASPhysicalSiteMapControlID;
        private Int64 _ASPhysicalSiteMapID;
        private String _ControlId;
        private String _ControlName;
        private String _UniqueKey;
        private Int64 _MDASControlTypeID;
        private Int64? _ParentASPhysicalSiteMapControlID;
        private String _TabPageReferenceUniqueKey;


        [DataMember]
        public Int64 ASPhysicalSiteMapControlID
        {
            get { return _ASPhysicalSiteMapControlID; }
            set { _ASPhysicalSiteMapControlID = value; }
        }

        [DataMember]
        public Int64 ASPhysicalSiteMapID
        {
            get { return _ASPhysicalSiteMapID; }
            set { _ASPhysicalSiteMapID = value; }
        }

        [DataMember]
        public String ControlId
        {
            get { return _ControlId; }
            set { _ControlId = value; }
        }

        [DataMember]
        public String ControlName
        {
            get { return _ControlName; }
            set { _ControlName = value; }
        }

        [DataMember]
        public String UniqueKey
        {
            get { return _UniqueKey; }
            set { _UniqueKey = value; }
        }

        [DataMember]
        public Int64 MDASControlTypeID
        {
            get { return _MDASControlTypeID; }
            set { _MDASControlTypeID = value; }
        }

        [DataMember]
        public Int64? ParentASPhysicalSiteMapControlID
        {
            get { return _ParentASPhysicalSiteMapControlID; }
            set { _ParentASPhysicalSiteMapControlID = value; }
        }

        [DataMember]
        public String TabPageReferenceUniqueKey
        {
            get { return _TabPageReferenceUniqueKey; }
            set { _TabPageReferenceUniqueKey = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ASPhysicalSiteMapControlID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ASPhysicalSiteMapControlEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ASPhysicalSiteMapControlID = "ASPhysicalSiteMapControlID";
        public const String FLD_NAME_ASPhysicalSiteMapID = "ASPhysicalSiteMapID";
        public const String FLD_NAME_ControlId = "ControlId";
        public const String FLD_NAME_ControlName = "ControlName";
        public const String FLD_NAME_UniqueKey = "UniqueKey";
        public const String FLD_NAME_MDASControlTypeID = "MDASControlTypeID";
        public const String FLD_NAME_ParentASPhysicalSiteMapControlID = "ParentASPhysicalSiteMapControlID";
        public const String FLD_NAME_TabPageReferenceUniqueKey = "TabPageReferenceUniqueKey";

        #endregion
    }
}
