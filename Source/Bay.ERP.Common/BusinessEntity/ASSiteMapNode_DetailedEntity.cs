// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:34:29




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ASSiteMapNode_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ASSiteMapNode_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _ASSiteMapNodeID;
        private Int64 _ASSiteMapID;
        private Int64? _ASPhysicalSiteMapID;
        private String _MenuTitle;
        private String _ToolTip;
        private String _UniqueKey;
        private Int64? _ParentASSiteMapNodeID;
        private Int64 _SequenceNumber;
        private String _SiteMapName;
        private String _ASPhysicalSiteMapName;
        private String _PhysicalPath;
        private String _NavigationURL;
        private String _ASPhysicalSiteMapUniqueKey;
        private Int64? _MDASNodeTypeID;
        private Int64? _ParentASPhysicalSiteMapID;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 ASSiteMapNodeID
        {
            get { return _ASSiteMapNodeID; }
            set { _ASSiteMapNodeID = value; }
        }

        [DataMember]
        public Int64 ASSiteMapID
        {
            get { return _ASSiteMapID; }
            set { _ASSiteMapID = value; }
        }

        [DataMember]
        public Int64? ASPhysicalSiteMapID
        {
            get { return _ASPhysicalSiteMapID; }
            set { _ASPhysicalSiteMapID = value; }
        }

        [DataMember]
        public String MenuTitle
        {
            get { return _MenuTitle; }
            set { _MenuTitle = value; }
        }

        [DataMember]
        public String ToolTip
        {
            get { return _ToolTip; }
            set { _ToolTip = value; }
        }

        [DataMember]
        public String UniqueKey
        {
            get { return _UniqueKey; }
            set { _UniqueKey = value; }
        }

        [DataMember]
        public Int64? ParentASSiteMapNodeID
        {
            get { return _ParentASSiteMapNodeID; }
            set { _ParentASSiteMapNodeID = value; }
        }

        [DataMember]
        public Int64 SequenceNumber
        {
            get { return _SequenceNumber; }
            set { _SequenceNumber = value; }
        }

        [DataMember]
        public String SiteMapName
        {
            get { return _SiteMapName; }
            set { _SiteMapName = value; }
        }

        [DataMember]
        public String ASPhysicalSiteMapName
        {
            get { return _ASPhysicalSiteMapName; }
            set { _ASPhysicalSiteMapName = value; }
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
        public String ASPhysicalSiteMapUniqueKey
        {
            get { return _ASPhysicalSiteMapUniqueKey; }
            set { _ASPhysicalSiteMapUniqueKey = value; }
        }

        [DataMember]
        public Int64? MDASNodeTypeID
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

        [DataMember]
        public Int64? RowNumber
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ASSiteMapNodeID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ASSiteMapNode_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ASSiteMapNodeID = "ASSiteMapNodeID";
        public const String FLD_NAME_ASSiteMapID = "ASSiteMapID";
        public const String FLD_NAME_ASPhysicalSiteMapID = "ASPhysicalSiteMapID";
        public const String FLD_NAME_MenuTitle = "MenuTitle";
        public const String FLD_NAME_ToolTip = "ToolTip";
        public const String FLD_NAME_UniqueKey = "UniqueKey";
        public const String FLD_NAME_ParentASSiteMapNodeID = "ParentASSiteMapNodeID";
        public const String FLD_NAME_SequenceNumber = "SequenceNumber";
        public const String FLD_NAME_SiteMapName = "SiteMapName";
        public const String FLD_NAME_ASPhysicalSiteMapName = "ASPhysicalSiteMapName";
        public const String FLD_NAME_PhysicalPath = "PhysicalPath";
        public const String FLD_NAME_NavigationURL = "NavigationURL";
        public const String FLD_NAME_ASPhysicalSiteMapUniqueKey = "ASPhysicalSiteMapUniqueKey";
        public const String FLD_NAME_MDASNodeTypeID = "MDASNodeTypeID";
        public const String FLD_NAME_ParentASPhysicalSiteMapID = "ParentASPhysicalSiteMapID";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
