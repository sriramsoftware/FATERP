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
    [DataContract(Name = "ASPhysicalSiteMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ASPhysicalSiteMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _ASPhysicalSiteMapID;
        private String _Name;
        private String _PhysicalPath;
        private String _NavigationURL;
        private String _UniqueKey;
        private Int64 _MDASNodeTypeID;
        private Int64? _ParentASPhysicalSiteMapID;


        [DataMember]
        public Int64 ASPhysicalSiteMapID
        {
            get { return _ASPhysicalSiteMapID; }
            set { _ASPhysicalSiteMapID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String PhysicalPath
        {
            get { return _PhysicalPath; }
            set { _PhysicalPath = value; }
        }

        [DataMember]
        public String NavigationURL
        {
            get { return _NavigationURL; }
            set { _NavigationURL = value; }
        }

        [DataMember]
        public String UniqueKey
        {
            get { return _UniqueKey; }
            set { _UniqueKey = value; }
        }

        [DataMember]
        public Int64 MDASNodeTypeID
        {
            get { return _MDASNodeTypeID; }
            set { _MDASNodeTypeID = value; }
        }

        [DataMember]
        public Int64? ParentASPhysicalSiteMapID
        {
            get { return _ParentASPhysicalSiteMapID; }
            set { _ParentASPhysicalSiteMapID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ASPhysicalSiteMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ASPhysicalSiteMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ASPhysicalSiteMapID = "ASPhysicalSiteMapID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_PhysicalPath = "PhysicalPath";
        public const String FLD_NAME_NavigationURL = "NavigationURL";
        public const String FLD_NAME_UniqueKey = "UniqueKey";
        public const String FLD_NAME_MDASNodeTypeID = "MDASNodeTypeID";
        public const String FLD_NAME_ParentASPhysicalSiteMapID = "ParentASPhysicalSiteMapID";

        #endregion
    }
}
