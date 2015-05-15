// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Dec-2011, 02:17:33




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDCity_Detailed", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDCity_DetailedEntity : BaseEntity
    {
        #region Properties


        private Int64 _CityID;
        private Int64 _CountryID;
        private String _Name;
        private Boolean _IsRemoved;
        private String _CountryName;
        private Int64? _RowNumber;


        [DataMember]
        public Int64 CityID
        {
            get { return _CityID; }
            set { _CityID = value; }
        }

        [DataMember]
        public Int64 CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
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

        [DataMember]
        public String CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
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
                return (CityID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDCity_DetailedEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_IsRemoved = "IsRemoved";
        public const String FLD_NAME_CountryName = "CountryName";
        public const String FLD_NAME_RowNumber = "RowNumber";

        #endregion
    }
}
