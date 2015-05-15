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
    [DataContract(Name = "BDProjectAdditionalInfo", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectAdditionalInfoEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectAdditionalInfoID;
        private Int64 _ProjectID;
        private Decimal _NumberOfStorey;
        private Decimal? _NumberOfBlock;
        private Decimal? _TypicalFloorArea;
        private Int64? _TypicalFloorAreaUnitID;
        private Decimal? _GCArchieved;
        private Decimal? _NumberOfBasement;
        private Decimal? _NumberOfResidentialFloor;
        private Decimal? _NumberOfCommercialFloor;
        private Decimal? _NoOfResidentialUnitPerFloor;
        private String _Facing;
        private Decimal? _TotalNumberOfUnit;
        private Decimal? _NumberOfPenthouse;
        private Decimal? _NumberOfStair;
        private String _PositionAtBuilding;
        private String _CoolingSystem;
        private String _GeyserSystem;
        private String _FacilitiesAtMezzanineFloor;
        private String _FacilitiesAtRoofFloor;
        private String _ApprovalRequired;
        private String _PositionAtBuildingForCommercial;
        private Decimal? _GroundFloorHeight;
        private Decimal? _TypicalFloorHeight;
        private Int64? _GroundFloorHeightUnitInFeetID;
        private Int64? _TypicalFloorHeightUnitInchID;
        private Decimal? _GroundFloorHeightInch;
		private Int64? _GroundFloorHeightUnitInInchID;
		private Decimal? _TypicalFloorHeightFeet;
        private Int64? _TypicalFloorHeightUnitFeetID;

        
        [DataMember]
        public Int64 ProjectAdditionalInfoID
        {
            get { return _ProjectAdditionalInfoID; }
            set { _ProjectAdditionalInfoID = value; }
        }

        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public Decimal NumberOfStorey
        {
            get { return _NumberOfStorey; }
            set { _NumberOfStorey = value; }
        }

        [DataMember]
        public Decimal? NumberOfBlock
        {
            get { return _NumberOfBlock; }
            set { _NumberOfBlock = value; }
        }

        [DataMember]
        public Decimal? TypicalFloorArea
        {
            get { return _TypicalFloorArea; }
            set { _TypicalFloorArea = value; }
        }

        [DataMember]
        public Int64? TypicalFloorAreaUnitID
        {
            get { return _TypicalFloorAreaUnitID; }
            set { _TypicalFloorAreaUnitID = value; }
        }

        [DataMember]
        public Decimal? GCArchieved
        {
            get { return _GCArchieved; }
            set { _GCArchieved = value; }
        }

        [DataMember]
        public Decimal? NumberOfBasement
        {
            get { return _NumberOfBasement; }
            set { _NumberOfBasement = value; }
        }

        [DataMember]
        public Decimal? NumberOfResidentialFloor
        {
            get { return _NumberOfResidentialFloor; }
            set { _NumberOfResidentialFloor = value; }
        }

        [DataMember]
        public Decimal? NumberOfCommercialFloor
        {
            get { return _NumberOfCommercialFloor; }
            set { _NumberOfCommercialFloor = value; }
        }

        [DataMember]
        public Decimal? NoOfResidentialUnitPerFloor
        {
            get { return _NoOfResidentialUnitPerFloor; }
            set { _NoOfResidentialUnitPerFloor = value; }
        }

        [DataMember]
        public String Facing
        {
            get { return _Facing; }
            set { _Facing = value; }
        }

        [DataMember]
        public Decimal? TotalNumberOfUnit
        {
            get { return _TotalNumberOfUnit; }
            set { _TotalNumberOfUnit = value; }
        }

        [DataMember]
        public Decimal? NumberOfPenthouse
        {
            get { return _NumberOfPenthouse; }
            set { _NumberOfPenthouse = value; }
        }

        [DataMember]
        public Decimal? NumberOfStair
        {
            get { return _NumberOfStair; }
            set { _NumberOfStair = value; }
        }

        [DataMember]
        public String PositionAtBuilding
        {
            get { return _PositionAtBuilding; }
            set { _PositionAtBuilding = value; }
        }

        [DataMember]
        public String CoolingSystem
        {
            get { return _CoolingSystem; }
            set { _CoolingSystem = value; }
        }

        [DataMember]
        public String GeyserSystem
        {
            get { return _GeyserSystem; }
            set { _GeyserSystem = value; }
        }

        [DataMember]
        public String FacilitiesAtMezzanineFloor
        {
            get { return _FacilitiesAtMezzanineFloor; }
            set { _FacilitiesAtMezzanineFloor = value; }
        }

        [DataMember]
        public String FacilitiesAtRoofFloor
        {
            get { return _FacilitiesAtRoofFloor; }
            set { _FacilitiesAtRoofFloor = value; }
        }

        [DataMember]
        public String ApprovalRequired
        {
            get { return _ApprovalRequired; }
            set { _ApprovalRequired = value; }
        }

        [DataMember]
        public String PositionAtBuildingForCommercial
        {
            get { return _PositionAtBuildingForCommercial; }
            set { _PositionAtBuildingForCommercial = value; }
        }

        [DataMember]
        public Decimal? GroundFloorHeight
        {
            get { return _GroundFloorHeight; }
            set { _GroundFloorHeight = value; }
        }

        [DataMember]
        public Decimal? TypicalFloorHeight
        {
            get { return _TypicalFloorHeight; }
            set { _TypicalFloorHeight = value; }
        }

        [DataMember]
        public Int64? GroundFloorHeightUnitInFeetID
        {
            get { return _GroundFloorHeightUnitInFeetID; }
            set { _GroundFloorHeightUnitInFeetID = value; }
        }

        [DataMember]
        public Int64? TypicalFloorHeightUnitInchID
        {
            get { return _TypicalFloorHeightUnitInchID; }
            set { _TypicalFloorHeightUnitInchID = value; }
        }

        [DataMember]
        public Decimal? GroundFloorHeightInch
        {
            get { return _GroundFloorHeightInch; }
            set { _GroundFloorHeightInch = value; }
        }

        [DataMember]
        public Int64? GroundFloorHeightUnitInInchID
        {
            get { return _GroundFloorHeightUnitInInchID; }
            set { _GroundFloorHeightUnitInInchID = value; }
        }

        [DataMember]
        public Decimal? TypicalFloorHeightFeet
        {
            get { return _TypicalFloorHeightFeet; }
            set { _TypicalFloorHeightFeet = value; }
        }

        [DataMember]
        public Int64? TypicalFloorHeightUnitFeetID
        {
            get { return _TypicalFloorHeightUnitFeetID; }
            set { _TypicalFloorHeightUnitFeetID = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectAdditionalInfoID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectAdditionalInfoEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectAdditionalInfoID = "ProjectAdditionalInfoID";
        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_NumberOfStorey = "NumberOfStorey";
        public const String FLD_NAME_NumberOfBlock = "NumberOfBlock";
        public const String FLD_NAME_TypicalFloorArea = "TypicalFloorArea";
        public const String FLD_NAME_TypicalFloorAreaUnitID = "TypicalFloorAreaUnitID";
        public const String FLD_NAME_GCArchieved = "GCArchieved";
        public const String FLD_NAME_NumberOfBasement = "NumberOfBasement";
        public const String FLD_NAME_NumberOfResidentialFloor = "NumberOfResidentialFloor";
        public const String FLD_NAME_NumberOfCommercialFloor = "NumberOfCommercialFloor";
        public const String FLD_NAME_NoOfResidentialUnitPerFloor = "NoOfResidentialUnitPerFloor";
        public const String FLD_NAME_Facing = "Facing";
        public const String FLD_NAME_TotalNumberOfUnit = "TotalNumberOfUnit";
        public const String FLD_NAME_NumberOfPenthouse = "NumberOfPenthouse";
        public const String FLD_NAME_NumberOfStair = "NumberOfStair";
        public const String FLD_NAME_PositionAtBuilding = "PositionAtBuilding";
        public const String FLD_NAME_CoolingSystem = "CoolingSystem";
        public const String FLD_NAME_GeyserSystem = "GeyserSystem";
        public const String FLD_NAME_FacilitiesAtMezzanineFloor = "FacilitiesAtMezzanineFloor";
        public const String FLD_NAME_FacilitiesAtRoofFloor = "FacilitiesAtRoofFloor";
        public const String FLD_NAME_ApprovalRequired = "ApprovalRequired";
        public const String FLD_NAME_PositionAtBuildingForCommercial = "PositionAtBuildingForCommercial";
        public const String FLD_NAME_GroundFloorHeight = "GroundFloorHeight";
        public const String FLD_NAME_TypicalFloorHeight = "TypicalFloorHeight";
        public const String FLD_NAME_GroundFloorHeightUnitInFeetID = "GroundFloorHeightUnitInFeetID";
        public const String FLD_NAME_TypicalFloorHeightUnitInchID = "TypicalFloorHeightUnitInchID";
        public const String FLD_NAME_GroundFloorHeightInch = "GroundFloorHeightInch";
		public const String FLD_NAME_GroundFloorHeightUnitInInchID = "GroundFloorHeightUnitInInchID";
		public const String FLD_NAME_TypicalFloorHeightFeet = "TypicalFloorHeightFeet";
        public const String FLD_NAME_TypicalFloorHeightUnitFeetID = "TypicalFloorHeightUnitFeetID";

        #endregion
    }
}
