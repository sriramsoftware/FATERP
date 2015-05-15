// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "ACDimension", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class ACDimensionEntity : BaseEntity
    {
        #region Properties


        private Int64 _DimensionID;
        private String _Name;
        private String _Description;
        private Boolean _IsInActive;


        [DataMember]
        public Int64 DimensionID
        {
            get { return _DimensionID; }
            set { _DimensionID = value; }
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
        public Boolean IsInActive
        {
            get { return _IsInActive; }
            set { _IsInActive = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (DimensionID <= 0);
            }
        }


        #endregion

        #region Constructor

        public ACDimensionEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_DimensionID = "DimensionID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_IsInActive = "IsInActive";

        #endregion
    }
}
