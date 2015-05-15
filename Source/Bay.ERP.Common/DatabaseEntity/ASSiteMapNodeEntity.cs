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
    [DataContract(Name = "ASSiteMapNode", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ASSiteMapNodeEntity : BaseEntity
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

        public ASSiteMapNodeEntity() : base()
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

        #endregion
    }
}
