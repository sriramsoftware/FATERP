// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "MDUnit", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class MDUnitEntity : BaseEntity
    {
        #region Properties


        private Int64 _UnitID;
        private String _UnitCode;
        private String _UnitName;
        private Boolean _IsRemoved;


        [DataMember]
        public Int64 UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
        }

        [DataMember]
        public String UnitCode
        {
            get { return _UnitCode; }
            set { _UnitCode = value; }
        }

        [DataMember]
        public String UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
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
                return (UnitID <= 0);
            }
        }


        #endregion

        #region Constructor

        public MDUnitEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_UnitID = "UnitID";
        public const String FLD_NAME_UnitCode = "UnitCode";
        public const String FLD_NAME_UnitName = "UnitName";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
