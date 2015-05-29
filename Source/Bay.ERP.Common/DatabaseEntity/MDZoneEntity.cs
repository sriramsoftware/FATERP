// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 07:14:37




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDZone", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDZoneEntity : BaseEntity
    {
        #region Properties


        private Int64 _ZoneID;
        private String _ZoneCode;
        private String _ZoneName;
        private String _Descripton;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 ZoneID
        {
            get { return _ZoneID; }
            set { _ZoneID = value; }
        }

        [DataMember]
        public String ZoneCode
        {
            get { return _ZoneCode; }
            set { _ZoneCode = value; }
        }

        [DataMember]
        public String ZoneName
        {
            get { return _ZoneName; }
            set { _ZoneName = value; }
        }

        [DataMember]
        public String Descripton
        {
            get { return _Descripton; }
            set { _Descripton = value; }
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
                return (ZoneID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDZoneEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ZoneID = "ZoneID";
        public const String FLD_NAME_ZoneCode = "ZoneCode";
        public const String FLD_NAME_ZoneName = "ZoneName";
        public const String FLD_NAME_Descripton = "Descripton";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
