// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2015, 10:30:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDZoneDesignation", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDZoneDesignationEntity : BaseEntity
    {
        #region Properties


        private Int64 _ZoneDesignationID;
        private String _Name;
        private String _Designation;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ZoneDesignationID
        {
            get { return _ZoneDesignationID; }
            set { _ZoneDesignationID = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public String Designation
        {
            get { return _Designation; }
            set { _Designation = value; }
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
                return (ZoneDesignationID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDZoneDesignationEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ZoneDesignationID = "ZoneDesignationID";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Designation = "Designation";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
