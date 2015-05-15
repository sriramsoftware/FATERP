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
    [DataContract(Name = "ASSiteMap", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ASSiteMapEntity : BaseEntity
    {
        #region Properties


        private Int64 _ASSiteMapID;
        private String _SiteMapName;
        private String _Description;
        private Boolean _IsMasterSiteMap;


        [DataMember]
        public Int64 ASSiteMapID
        {
            get { return _ASSiteMapID; }
            set { _ASSiteMapID = value; }
        }

        [DataMember]
        public String SiteMapName
        {
            get { return _SiteMapName; }
            set { _SiteMapName = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Boolean IsMasterSiteMap
        {
            get { return _IsMasterSiteMap; }
            set { _IsMasterSiteMap = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ASSiteMapID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ASSiteMapEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ASSiteMapID = "ASSiteMapID";
        public const String FLD_NAME_SiteMapName = "SiteMapName";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsMasterSiteMap = "IsMasterSiteMap";

        #endregion
    }
}
