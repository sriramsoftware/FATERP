// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectWaterReservior", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectWaterReserviorEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectWaterReserviorID;
        private Int64 _ProjectID;
        private Decimal? _CapacityOfUndergroundReservior;
        private Int64? _UndergroundReserviorUnitID;
        private Decimal? _CapacityOfOverheadReservior;
        private Int64? _OverheadReserviorUnitID;


        [DataMember]
        public Int64 ProjectWaterReserviorID
        {
            get { return _ProjectWaterReserviorID; }
            set { _ProjectWaterReserviorID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Decimal? CapacityOfUndergroundReservior
        {
            get { return _CapacityOfUndergroundReservior; }
            set { _CapacityOfUndergroundReservior = value; }
        }

        [DataMember]
        public Int64? UndergroundReserviorUnitID
        {
            get { return _UndergroundReserviorUnitID; }
            set { _UndergroundReserviorUnitID = value; }
        }

        [DataMember]
        public Decimal? CapacityOfOverheadReservior
        {
            get { return _CapacityOfOverheadReservior; }
            set { _CapacityOfOverheadReservior = value; }
        }

        [DataMember]
        public Int64? OverheadReserviorUnitID
        {
            get { return _OverheadReserviorUnitID; }
            set { _OverheadReserviorUnitID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectWaterReserviorID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectWaterReserviorEntity()
            : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectWaterReserviorID = "ProjectWaterReserviorID";                    
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_CapacityOfUndergroundReservior = "CapacityOfUndergroundReservior";
        public const String FLD_NAME_UndergroundReserviorUnitID = "UndergroundReserviorUnitID;";
        public const String FLD_NAME_CapacityOfOverheadReservior = "CapacityOfOverheadReservior";
        public const String FLD_NAME_OverheadReserviorUnitID = "OverheadReserviorUnitID";             

        #endregion
    }
}
