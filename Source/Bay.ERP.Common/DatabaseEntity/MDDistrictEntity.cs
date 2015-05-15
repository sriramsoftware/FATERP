// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2014, 11:58:51




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDDistrict", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDDistrictEntity : BaseEntity
    {
        #region Properties


        private Int64 _DistrictID;
        private String _DistrictName;
        private String _Remarks;
        private Int64 _DivisionID;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 DistrictID
        {
            get { return _DistrictID; }
            set { _DistrictID = value; }
        }

        [DataMember]
        public String DistrictName
        {
            get { return _DistrictName; }
            set { _DistrictName = value; }
        }

        [DataMember]
        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        [DataMember]
        public Int64 DivisionID
        {
            get { return _DivisionID; }
            set { _DivisionID = value; }
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
                return (DistrictID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDDistrictEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_DistrictID = "DistrictID";
        public const String FLD_NAME_DistrictName = "DistrictName";
        public const String FLD_NAME_Remarks = "Remarks";
        public const String FLD_NAME_DivisionID = "DivisionID";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
