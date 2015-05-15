// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2013, 03:32:47




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectFloorUnit", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectFloorUnitEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectFloorUnitID;
        private Int64 _ProjectFloorID;
        private Int64 _ProjectFloorUnitTypeID;
        private String _ProjectFloorUnitName;
        private Int64 _ProjectFloorUnitStatusID;
        private Decimal _UnitArea;
        private Decimal _TotalArea;
        private Decimal? _RegisteredArea;
        private String _Facing;
        private Decimal _Toilet;
        private Decimal _Kitchen;
        private Decimal _Parking;
        private Decimal _BathRoom;
        private Decimal _BedRoom;
        private Decimal _ServantBed;
        private Decimal _ServantToilet;
        private Decimal _Corridor;
        private Decimal _TapasGarden;
        private Decimal _SwimmingPool;
        private Boolean _IsIDServiceAvailable;
        private Boolean _ElectricityService;
        private Boolean _CommonGenerator;
        private Decimal? _PricePerSft;
        private Decimal? _AreaPrice;
        private Decimal? _IDPrice;
        private Decimal? _AdditionalCharges;
        private String _Features;
        private String _CivilDrawingImageUrl;
        private String _ElectricalDrawingImageUrl;
        private String _InteriorDrawingImageUrl;
        private String _MechanicalDrawingImageUrl;
        private String _PlumbingDrawingImageUrl;
        private String _OthersDrawingImageUrl;
        private Decimal? _Foyer;
        private Decimal? _SittingRoom;
        private Decimal? _DiningRoom;
        private Decimal? _Pantry;
        private Decimal? _BreakfastCorner;
        private Decimal? _StudyRoom;
        private Decimal? _Study;
        private Decimal? _Verandah;
        private Boolean? _WaterSupplyAvailable;
        private Boolean _IsRemoved;

        [DataMember]
        public Int64 ProjectFloorUnitID
        {
            get { return _ProjectFloorUnitID; }
            set { _ProjectFloorUnitID = value; }
        }

        [DataMember]
        public Int64 ProjectFloorID
        {
            get { return _ProjectFloorID; }
            set { _ProjectFloorID = value; }
        }

        [DataMember]
        public Int64 ProjectFloorUnitTypeID
        {
            get { return _ProjectFloorUnitTypeID; }
            set { _ProjectFloorUnitTypeID = value; }
        }

        [DataMember]
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
        }

        [DataMember]
        public Int64 ProjectFloorUnitStatusID
        {
            get { return _ProjectFloorUnitStatusID; }
            set { _ProjectFloorUnitStatusID = value; }
        }

        [DataMember]
        public Decimal UnitArea
        {
            get { return _UnitArea; }
            set { _UnitArea = value; }
        }

        [DataMember]
        public Decimal TotalArea
        {
            get { return _TotalArea; }
            set { _TotalArea = value; }
        }

        [DataMember]
        public Decimal? RegisteredArea
        {
            get { return _RegisteredArea; }
            set { _RegisteredArea = value; }
        }

        [DataMember]
        public String Facing
        {
            get { return _Facing; }
            set { _Facing = value; }
        }

        [DataMember]
        public Decimal Toilet
        {
            get { return _Toilet; }
            set { _Toilet = value; }
        }

        [DataMember]
        public Decimal Kitchen
        {
            get { return _Kitchen; }
            set { _Kitchen = value; }
        }

        [DataMember]
        public Decimal Parking
        {
            get { return _Parking; }
            set { _Parking = value; }
        }

        [DataMember]
        public Decimal BathRoom
        {
            get { return _BathRoom; }
            set { _BathRoom = value; }
        }

        [DataMember]
        public Decimal BedRoom
        {
            get { return _BedRoom; }
            set { _BedRoom = value; }
        }

        [DataMember]
        public Decimal ServantBed
        {
            get { return _ServantBed; }
            set { _ServantBed = value; }
        }

        [DataMember]
        public Decimal ServantToilet
        {
            get { return _ServantToilet; }
            set { _ServantToilet = value; }
        }

        [DataMember]
        public Decimal Corridor
        {
            get { return _Corridor; }
            set { _Corridor = value; }
        }

        [DataMember]
        public Decimal TapasGarden
        {
            get { return _TapasGarden; }
            set { _TapasGarden = value; }
        }

        [DataMember]
        public Decimal SwimmingPool
        {
            get { return _SwimmingPool; }
            set { _SwimmingPool = value; }
        }

        [DataMember]
        public Boolean IsIDServiceAvailable
        {
            get { return _IsIDServiceAvailable; }
            set { _IsIDServiceAvailable = value; }
        }

        [DataMember]
        public Boolean ElectricityService
        {
            get { return _ElectricityService; }
            set { _ElectricityService = value; }
        }

        [DataMember]
        public Boolean CommonGenerator
        {
            get { return _CommonGenerator; }
            set { _CommonGenerator = value; }
        }

        [DataMember]
        public Decimal? PricePerSft
        {
            get { return _PricePerSft; }
            set { _PricePerSft = value; }
        }

        [DataMember]
        public Decimal? AreaPrice
        {
            get { return _AreaPrice; }
            set { _AreaPrice = value; }
        }

        [DataMember]
        public Decimal? IDPrice
        {
            get { return _IDPrice; }
            set { _IDPrice = value; }
        }

        [DataMember]
        public Decimal? AdditionalCharges
        {
            get { return _AdditionalCharges; }
            set { _AdditionalCharges = value; }
        }

        [DataMember]
        public String Features
        {
            get { return _Features; }
            set { _Features = value; }
        }

        [DataMember]
        public String CivilDrawingImageUrl
        {
            get { return _CivilDrawingImageUrl; }
            set { _CivilDrawingImageUrl = value; }
        }

        [DataMember]
        public String ElectricalDrawingImageUrl
        {
            get { return _ElectricalDrawingImageUrl; }
            set { _ElectricalDrawingImageUrl = value; }
        }

        [DataMember]
        public String InteriorDrawingImageUrl
        {
            get { return _InteriorDrawingImageUrl; }
            set { _InteriorDrawingImageUrl = value; }
        }

        [DataMember]
        public String MechanicalDrawingImageUrl
        {
            get { return _MechanicalDrawingImageUrl; }
            set { _MechanicalDrawingImageUrl = value; }
        }

        [DataMember]
        public String PlumbingDrawingImageUrl
        {
            get { return _PlumbingDrawingImageUrl; }
            set { _PlumbingDrawingImageUrl = value; }
        }

        [DataMember]
        public String OthersDrawingImageUrl
        {
            get { return _OthersDrawingImageUrl; }
            set { _OthersDrawingImageUrl = value; }
        }

        [DataMember]
        public Decimal? Foyer
        {
            get { return _Foyer; }
            set { _Foyer = value; }
        }

        [DataMember]
        public Decimal? SittingRoom
        {
            get { return _SittingRoom; }
            set { _SittingRoom = value; }
        }

        [DataMember]
        public Decimal? DiningRoom
        {
            get { return _DiningRoom; }
            set { _DiningRoom = value; }
        }

        [DataMember]
        public Decimal? Pantry
        {
            get { return _Pantry; }
            set { _Pantry = value; }
        }

        [DataMember]
        public Decimal? BreakfastCorner
        {
            get { return _BreakfastCorner; }
            set { _BreakfastCorner = value; }
        }

        [DataMember]
        public Decimal? StudyRoom
        {
            get { return _StudyRoom; }
            set { _StudyRoom = value; }
        }

        [DataMember]
        public Decimal? Study
        {
            get { return _Study; }
            set { _Study = value; }
        }

        [DataMember]
        public Decimal? Verandah
        {
            get { return _Verandah; }
            set { _Verandah = value; }
        }

        [DataMember]
        public Boolean? WaterSupplyAvailable
        {
            get { return _WaterSupplyAvailable; }
            set { _WaterSupplyAvailable = value; }
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
                return (ProjectFloorUnitID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectFloorUnitEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectFloorUnitID = "ProjectFloorUnitID";
        public const String FLD_NAME_ProjectFloorID = "ProjectFloorID";
        public const String FLD_NAME_ProjectFloorUnitTypeID = "ProjectFloorUnitTypeID";
        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_ProjectFloorUnitStatusID = "ProjectFloorUnitStatusID";
        public const String FLD_NAME_UnitArea = "UnitArea";
        public const String FLD_NAME_TotalArea = "TotalArea";
        public const String FLD_NAME_RegisteredArea = "RegisteredArea";
        public const String FLD_NAME_Facing = "Facing";
        public const String FLD_NAME_Toilet = "Toilet";
        public const String FLD_NAME_Kitchen = "Kitchen";
        public const String FLD_NAME_Parking = "Parking";
        public const String FLD_NAME_BathRoom = "BathRoom";
        public const String FLD_NAME_BedRoom = "BedRoom";
        public const String FLD_NAME_ServantBed = "ServantBed";
        public const String FLD_NAME_ServantToilet = "ServantToilet";
        public const String FLD_NAME_Corridor = "Corridor";
        public const String FLD_NAME_TapasGarden = "TapasGarden";
        public const String FLD_NAME_SwimmingPool = "SwimmingPool";
        public const String FLD_NAME_IsIDServiceAvailable = "IsIDServiceAvailable";
        public const String FLD_NAME_ElectricityService = "ElectricityService";
        public const String FLD_NAME_CommonGenerator = "CommonGenerator";
        public const String FLD_NAME_PricePerSft = "PricePerSft";
        public const String FLD_NAME_AreaPrice = "AreaPrice";
        public const String FLD_NAME_IDPrice = "IDPrice";
        public const String FLD_NAME_AdditionalCharges = "AdditionalCharges";
        public const String FLD_NAME_Features = "Features";
        public const String FLD_NAME_CivilDrawingImageUrl = "CivilDrawingImageUrl";
        public const String FLD_NAME_ElectricalDrawingImageUrl = "ElectricalDrawingImageUrl";
        public const String FLD_NAME_InteriorDrawingImageUrl = "InteriorDrawingImageUrl";
        public const String FLD_NAME_MechanicalDrawingImageUrl = "MechanicalDrawingImageUrl";
        public const String FLD_NAME_PlumbingDrawingImageUrl = "PlumbingDrawingImageUrl";
        public const String FLD_NAME_OthersDrawingImageUrl = "OthersDrawingImageUrl";
        public const String FLD_NAME_Foyer = "Foyer";
        public const String FLD_NAME_SittingRoom = "SittingRoom"; 
        public const String FLD_NAME_DiningRoom = "DiningRoom"; 
        public const String FLD_NAME_Pantry = "Pantry"; 
        public const String FLD_NAME_BreakfastCorner = "BreakfastCorner"; 
        public const String FLD_NAME_StudyRoom = "StudyRoom";
        public const String FLD_NAME_Study = "Study";
        public const String FLD_NAME_Verandah = "Verandah";
        public const String FLD_NAME_WaterSupplyAvailable = "WaterSupplyAvailable";
        public const String FLD_NAME_IsRemoved = "IsRemoved";

        #endregion
    }
}
