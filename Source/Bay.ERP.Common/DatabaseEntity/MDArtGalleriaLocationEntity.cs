// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Oct-2013, 01:39:59




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDArtGalleriaLocation", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDArtGalleriaLocationEntity : BaseEntity
    {
        #region Properties


        private Int64 _ArtGalleriaLocationID;
        private Int64? _ParentArtGalleriaLocationID;
        private Int64 _CountryID;
        private Int64 _CityID;
        private String _Name;
        private String _Description;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ArtGalleriaLocationID
        {
            get { return _ArtGalleriaLocationID; }
            set { _ArtGalleriaLocationID = value; }
        }

        [DataMember]
        public Int64? ParentArtGalleriaLocationID
        {
            get { return _ParentArtGalleriaLocationID; }
            set { _ParentArtGalleriaLocationID = value; }
        }

        [DataMember]
        public Int64 CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public Int64 CityID
        {
            get { return _CityID; }
            set { _CityID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
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
                return (ArtGalleriaLocationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDArtGalleriaLocationEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ArtGalleriaLocationID = "ArtGalleriaLocationID";
        public const String FLD_NAME_ParentArtGalleriaLocationID = "ParentArtGalleriaLocationID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
