// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Jun-2013, 04:10:14




using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable]
    [DataContract(Name = "BDProjectCutom_RPT", Namespace = "http://www.e-p-m-s.com/types")]
    public partial class BDProjectCutom_RPTEntity : BaseEntity
    {
        #region Properties


        private Int64 _ProjectID;
        private String _ProjectCode;
        private String _ProjectName;
        private Decimal? _LandAreaKatha;
        private Decimal? _LandAreaSft;
        private Decimal? _RoadWidth;
        private Int64? _RoadWidthUnitID;
        private Int32? _NoOfStoried;
        private Int32? _NoOfBasement;
        private String _Description;
        private Decimal? _ClientPercentage;
        private Decimal? _CompanyPercentage;
        private Int64 _ProjectCategoryID;
        private Int64 _ProjectStatusID;
        private Decimal? _NumberOfStorey;
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
        private String _AddressLine1;
        private String _AddressLine2;
        private Int64? _CountryID;
        private Int64? _CityID;
        private String _ZipCode;
        private Decimal? _NumberOfLift;
        private Decimal? _NumberOfPassengerLift;
        private Decimal? _CapacityOfPassengerLift;
        private Decimal? _NumberOfServiceLift;
        private Decimal? _CapacityOfServiceLift;
        private Decimal? _NumberOfFireFighterLift;
        private Int64? _BrandID;
        private Decimal? _Ground;
        private Decimal? _LowerGround;
        private Decimal? _Basement1;
        private Decimal? _Basement2;
        private Decimal? _Basement3;
        private Decimal? _Basement4;
        private Decimal? _Basement5;
        private Decimal? _Basement6;
        private Decimal? _Outdoor;
        private Decimal? _Total;
        private Decimal? _GuestParking;
        private Decimal? _DisableParking;
        private String _Name;
        private Int32? _Size;
        private String _ProjectFloorName;
        private Decimal? _CapacityOfSubstation;
        private Decimal? _TotalNumberOfGenerator;
        private Decimal? _CapacityOfGenerator1;
        private Decimal? _CapacityOfGenerator2;
        private Decimal? _CapacityOfGenerator3;
        private Decimal? _CapacityOfGenerator4;
        private Decimal? _CapacityOfGenerator5;
        private Int64? _BDProjectSubstationAndGeneratorBrandID;
        private Decimal? _TBA;
        private Int64? _TBAUnitID;
        private Decimal? _FAR;
        private Decimal? _FARBonus;
        private Decimal? _FIA;
        private Int64? _FIAUnitID;
        private Decimal? _FIAAchieved;
        private Int64? _FIAAchievedUnitID;
        private Decimal? _GSA;
        private Int64? _GSAUnitID;
        private Decimal? _MGCPercentages;
        private Decimal? _MGCArea;
        private Int64? _MGCAreaUnitID;
        private String _GroundCoverage;
        private DateTime? _DateOfAgreement;
        private DateTime? _DateOfHandover;
        private String _DelayClause;
        private String _ProjectFloorUnitName;
        private Int64? _ProjectFloorUnitStatusID;
        private Decimal? _UnitArea;
        private Decimal? _TotalArea;
        private Decimal? _RegisteredArea;
        private String _BDProjectFloorUnitFacing;
        private Decimal? _Toilet;
        private Decimal? _Kitchen;
        private Decimal? _Parking;
        private Decimal? _BathRoom;
        private Decimal? _BedRoom;
        private Boolean _IsIDServiceAvailable;
        private Boolean _ElectricityService;
        private Boolean _CommonGenerator;
        private Decimal? _PricePerSft;
        private Decimal? _AreaPrice;
        private Decimal? _IDPrice;
        private Decimal? _AdditionalCharges;
        private String _Features;
        private String _LiftBrandName;
        private String _GeneratorBrandName;
        private String _CountryName;
        private String _CityName;
        private String _FloorUnitTypeName;
        private String _FloorUnitStatusName;
        private String _TBAUnitName;
        private String _FIAUnitName;
        private String _GSAUnitName;
        private String _MGCAreaUnitName;
        private String _FIAArchivedUnitName;
        private String _RoadWidthUnitName;
        private String _TypicalFloorAreaUnitName;
        private String _ProjectStatus;
        private String _ProjectType;


        [DataMember]
        public Int64 ProjectID
        {
            get { return _ProjectID; }
            set { _ProjectID = value; }
        }

        [DataMember]
        public String ProjectCode
        {
            get { return _ProjectCode; }
            set { _ProjectCode = value; }
        }

        [DataMember]
        public String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        [DataMember]
        public Decimal? LandAreaKatha
        {
            get { return _LandAreaKatha; }
            set { _LandAreaKatha = value; }
        }

        [DataMember]
        public Decimal? LandAreaSft
        {
            get { return _LandAreaSft; }
            set { _LandAreaSft = value; }
        }

        [DataMember]
        public Decimal? RoadWidth
        {
            get { return _RoadWidth; }
            set { _RoadWidth = value; }
        }

        [DataMember]
        public Int64? RoadWidthUnitID
        {
            get { return _RoadWidthUnitID; }
            set { _RoadWidthUnitID = value; }
        }

        [DataMember]
        public Int32? NoOfStoried
        {
            get { return _NoOfStoried; }
            set { _NoOfStoried = value; }
        }

        [DataMember]
        public Int32? NoOfBasement
        {
            get { return _NoOfBasement; }
            set { _NoOfBasement = value; }
        }

        [DataMember]
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [DataMember]
        public Decimal? ClientPercentage
        {
            get { return _ClientPercentage; }
            set { _ClientPercentage = value; }
        }

        [DataMember]
        public Decimal? CompanyPercentage
        {
            get { return _CompanyPercentage; }
            set { _CompanyPercentage = value; }
        }

        [DataMember]
        public Int64 ProjectCategoryID
        {
            get { return _ProjectCategoryID; }
            set { _ProjectCategoryID = value; }
        }

        [DataMember]
        public Int64 ProjectStatusID
        {
            get { return _ProjectStatusID; }
            set { _ProjectStatusID = value; }
        }

        [DataMember]
        public Decimal? NumberOfStorey
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
        public String AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        [DataMember]
        public String AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; }
        }

        [DataMember]
        public Int64? CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

        [DataMember]
        public Int64? CityID
        {
            get { return _CityID; }
            set { _CityID = value; }
        }

        [DataMember]
        public String ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }
        }

        [DataMember]
        public Decimal? NumberOfLift
        {
            get { return _NumberOfLift; }
            set { _NumberOfLift = value; }
        }

        [DataMember]
        public Decimal? NumberOfPassengerLift
        {
            get { return _NumberOfPassengerLift; }
            set { _NumberOfPassengerLift = value; }
        }

        [DataMember]
        public Decimal? CapacityOfPassengerLift
        {
            get { return _CapacityOfPassengerLift; }
            set { _CapacityOfPassengerLift = value; }
        }

        [DataMember]
        public Decimal? NumberOfServiceLift
        {
            get { return _NumberOfServiceLift; }
            set { _NumberOfServiceLift = value; }
        }

        [DataMember]
        public Decimal? CapacityOfServiceLift
        {
            get { return _CapacityOfServiceLift; }
            set { _CapacityOfServiceLift = value; }
        }

        [DataMember]
        public Decimal? NumberOfFireFighterLift
        {
            get { return _NumberOfFireFighterLift; }
            set { _NumberOfFireFighterLift = value; }
        }

        [DataMember]
        public Int64? BrandID
        {
            get { return _BrandID; }
            set { _BrandID = value; }
        }

        [DataMember]
        public Decimal? Ground
        {
            get { return _Ground; }
            set { _Ground = value; }
        }

        [DataMember]
        public Decimal? LowerGround
        {
            get { return _LowerGround; }
            set { _LowerGround = value; }
        }

        [DataMember]
        public Decimal? Basement1
        {
            get { return _Basement1; }
            set { _Basement1 = value; }
        }

        [DataMember]
        public Decimal? Basement2
        {
            get { return _Basement2; }
            set { _Basement2 = value; }
        }

        [DataMember]
        public Decimal? Basement3
        {
            get { return _Basement3; }
            set { _Basement3 = value; }
        }

        [DataMember]
        public Decimal? Basement4
        {
            get { return _Basement4; }
            set { _Basement4 = value; }
        }

        [DataMember]
        public Decimal? Basement5
        {
            get { return _Basement5; }
            set { _Basement5 = value; }
        }

        [DataMember]
        public Decimal? Basement6
        {
            get { return _Basement6; }
            set { _Basement6 = value; }
        }

        [DataMember]
        public Decimal? Outdoor
        {
            get { return _Outdoor; }
            set { _Outdoor = value; }
        }

        [DataMember]
        public Decimal? Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        [DataMember]
        public Decimal? GuestParking
        {
            get { return _GuestParking; }
            set { _GuestParking = value; }
        }

        [DataMember]
        public Decimal? DisableParking
        {
            get { return _DisableParking; }
            set { _DisableParking = value; }
        }

        [DataMember]
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [DataMember]
        public Int32? Size
        {
            get { return _Size; }
            set { _Size = value; }
        }

        [DataMember]
        public String ProjectFloorName
        {
            get { return _ProjectFloorName; }
            set { _ProjectFloorName = value; }
        }

        [DataMember]
        public Decimal? CapacityOfSubstation
        {
            get { return _CapacityOfSubstation; }
            set { _CapacityOfSubstation = value; }
        }

        [DataMember]
        public Decimal? TotalNumberOfGenerator
        {
            get { return _TotalNumberOfGenerator; }
            set { _TotalNumberOfGenerator = value; }
        }

        [DataMember]
        public Decimal? CapacityOfGenerator1
        {
            get { return _CapacityOfGenerator1; }
            set { _CapacityOfGenerator1 = value; }
        }

        [DataMember]
        public Decimal? CapacityOfGenerator2
        {
            get { return _CapacityOfGenerator2; }
            set { _CapacityOfGenerator2 = value; }
        }

        [DataMember]
        public Decimal? CapacityOfGenerator3
        {
            get { return _CapacityOfGenerator3; }
            set { _CapacityOfGenerator3 = value; }
        }

        [DataMember]
        public Decimal? CapacityOfGenerator4
        {
            get { return _CapacityOfGenerator4; }
            set { _CapacityOfGenerator4 = value; }
        }

        [DataMember]
        public Decimal? CapacityOfGenerator5
        {
            get { return _CapacityOfGenerator5; }
            set { _CapacityOfGenerator5 = value; }
        }

        [DataMember]
        public Int64? BDProjectSubstationAndGeneratorBrandID
        {
            get { return _BDProjectSubstationAndGeneratorBrandID; }
            set { _BDProjectSubstationAndGeneratorBrandID = value; }
        }

        [DataMember]
        public Decimal? TBA
        {
            get { return _TBA; }
            set { _TBA = value; }
        }

        [DataMember]
        public Int64? TBAUnitID
        {
            get { return _TBAUnitID; }
            set { _TBAUnitID = value; }
        }

        [DataMember]
        public Decimal? FAR
        {
            get { return _FAR; }
            set { _FAR = value; }
        }

        [DataMember]
        public Decimal? FARBonus
        {
            get { return _FARBonus; }
            set { _FARBonus = value; }
        }

        [DataMember]
        public Decimal? FIA
        {
            get { return _FIA; }
            set { _FIA = value; }
        }

        [DataMember]
        public Int64? FIAUnitID
        {
            get { return _FIAUnitID; }
            set { _FIAUnitID = value; }
        }

        [DataMember]
        public Decimal? FIAAchieved
        {
            get { return _FIAAchieved; }
            set { _FIAAchieved = value; }
        }

        [DataMember]
        public Int64? FIAAchievedUnitID
        {
            get { return _FIAAchievedUnitID; }
            set { _FIAAchievedUnitID = value; }
        }

        [DataMember]
        public Decimal? GSA
        {
            get { return _GSA; }
            set { _GSA = value; }
        }

        [DataMember]
        public Int64? GSAUnitID
        {
            get { return _GSAUnitID; }
            set { _GSAUnitID = value; }
        }

        [DataMember]
        public Decimal? MGCPercentages
        {
            get { return _MGCPercentages; }
            set { _MGCPercentages = value; }
        }

        [DataMember]
        public Decimal? MGCArea
        {
            get { return _MGCArea; }
            set { _MGCArea = value; }
        }

        [DataMember]
        public Int64? MGCAreaUnitID
        {
            get { return _MGCAreaUnitID; }
            set { _MGCAreaUnitID = value; }
        }

        [DataMember]
        public String GroundCoverage
        {
            get { return _GroundCoverage; }
            set { _GroundCoverage = value; }
        }

        [DataMember]
        public DateTime? DateOfAgreement
        {
            get { return _DateOfAgreement; }
            set { _DateOfAgreement = value; }
        }

        [DataMember]
        public DateTime? DateOfHandover
        {
            get { return _DateOfHandover; }
            set { _DateOfHandover = value; }
        }

        [DataMember]
        public String DelayClause
        {
            get { return _DelayClause; }
            set { _DelayClause = value; }
        }

        [DataMember]
        public String ProjectFloorUnitName
        {
            get { return _ProjectFloorUnitName; }
            set { _ProjectFloorUnitName = value; }
        }

        [DataMember]
        public Int64? ProjectFloorUnitStatusID
        {
            get { return _ProjectFloorUnitStatusID; }
            set { _ProjectFloorUnitStatusID = value; }
        }

        [DataMember]
        public Decimal? UnitArea
        {
            get { return _UnitArea; }
            set { _UnitArea = value; }
        }

        [DataMember]
        public Decimal? TotalArea
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
        public String BDProjectFloorUnitFacing
        {
            get { return _BDProjectFloorUnitFacing; }
            set { _BDProjectFloorUnitFacing = value; }
        }

        [DataMember]
        public Decimal? Toilet
        {
            get { return _Toilet; }
            set { _Toilet = value; }
        }

        [DataMember]
        public Decimal? Kitchen
        {
            get { return _Kitchen; }
            set { _Kitchen = value; }
        }

        [DataMember]
        public Decimal? Parking
        {
            get { return _Parking; }
            set { _Parking = value; }
        }

        [DataMember]
        public Decimal? BathRoom
        {
            get { return _BathRoom; }
            set { _BathRoom = value; }
        }

        [DataMember]
        public Decimal? BedRoom
        {
            get { return _BedRoom; }
            set { _BedRoom = value; }
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
        public String LiftBrandName
        {
            get { return _LiftBrandName; }
            set { _LiftBrandName = value; }
        }

        [DataMember]
        public String GeneratorBrandName
        {
            get { return _GeneratorBrandName; }
            set { _GeneratorBrandName = value; }
        }

        [DataMember]
        public String CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
        }

        [DataMember]
        public String CityName
        {
            get { return _CityName; }
            set { _CityName = value; }
        }

        [DataMember]
        public String FloorUnitTypeName
        {
            get { return _FloorUnitTypeName; }
            set { _FloorUnitTypeName = value; }
        }

        [DataMember]
        public String FloorUnitStatusName
        {
            get { return _FloorUnitStatusName; }
            set { _FloorUnitStatusName = value; }
        }

        [DataMember]
        public String TBAUnitName
        {
            get { return _TBAUnitName; }
            set { _TBAUnitName = value; }
        }

        [DataMember]
        public String FIAUnitName
        {
            get { return _FIAUnitName; }
            set { _FIAUnitName = value; }
        }

        [DataMember]
        public String GSAUnitName
        {
            get { return _GSAUnitName; }
            set { _GSAUnitName = value; }
        }

        [DataMember]
        public String MGCAreaUnitName
        {
            get { return _MGCAreaUnitName; }
            set { _MGCAreaUnitName = value; }
        }

        [DataMember]
        public String FIAArchivedUnitName
        {
            get { return _FIAArchivedUnitName; }
            set { _FIAArchivedUnitName = value; }
        }

        [DataMember]
        public String RoadWidthUnitName
        {
            get { return _RoadWidthUnitName; }
            set { _RoadWidthUnitName = value; }
        }

        [DataMember]
        public String TypicalFloorAreaUnitName
        {
            get { return _TypicalFloorAreaUnitName; }
            set { _TypicalFloorAreaUnitName = value; }
        }

        [DataMember]
        public String ProjectStatus
        {
            get { return _ProjectStatus; }
            set { _ProjectStatus = value; }
        }

        [DataMember]
        public String ProjectType
        {
            get { return _ProjectType; }
            set { _ProjectType = value; }
        }

        [XmlIgnore()]
        public override bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return (ProjectID <= 0);
            }
        }


        #endregion

        #region Constructor

        public BDProjectCutom_RPTEntity() : base()
        {
        }

        #endregion

        #region Constant

        public const String FLD_NAME_ProjectID = "ProjectID";
        public const String FLD_NAME_ProjectCode = "ProjectCode";
        public const String FLD_NAME_ProjectName = "ProjectName";
        public const String FLD_NAME_LandAreaKatha = "LandAreaKatha";
        public const String FLD_NAME_LandAreaSft = "LandAreaSft";
        public const String FLD_NAME_RoadWidth = "RoadWidth";
        public const String FLD_NAME_RoadWidthUnitID = "RoadWidthUnitID";
        public const String FLD_NAME_NoOfStoried = "NoOfStoried";
        public const String FLD_NAME_NoOfBasement = "NoOfBasement";
        public const String FLD_NAME_Description = "Description";
        public const String FLD_NAME_ClientPercentage = "ClientPercentage";
        public const String FLD_NAME_CompanyPercentage = "CompanyPercentage";
        public const String FLD_NAME_ProjectCategoryID = "ProjectCategoryID";
        public const String FLD_NAME_ProjectStatusID = "ProjectStatusID";
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
        public const String FLD_NAME_AddressLine1 = "AddressLine1";
        public const String FLD_NAME_AddressLine2 = "AddressLine2";
        public const String FLD_NAME_CountryID = "CountryID";
        public const String FLD_NAME_CityID = "CityID";
        public const String FLD_NAME_ZipCode = "ZipCode";
        public const String FLD_NAME_NumberOfLift = "NumberOfLift";
        public const String FLD_NAME_NumberOfPassengerLift = "NumberOfPassengerLift";
        public const String FLD_NAME_CapacityOfPassengerLift = "CapacityOfPassengerLift";
        public const String FLD_NAME_NumberOfServiceLift = "NumberOfServiceLift";
        public const String FLD_NAME_CapacityOfServiceLift = "CapacityOfServiceLift";
        public const String FLD_NAME_NumberOfFireFighterLift = "NumberOfFireFighterLift";
        public const String FLD_NAME_BrandID = "BrandID";
        public const String FLD_NAME_Ground = "Ground";
        public const String FLD_NAME_LowerGround = "LowerGround";
        public const String FLD_NAME_Basement1 = "Basement1";
        public const String FLD_NAME_Basement2 = "Basement2";
        public const String FLD_NAME_Basement3 = "Basement3";
        public const String FLD_NAME_Basement4 = "Basement4";
        public const String FLD_NAME_Basement5 = "Basement5";
        public const String FLD_NAME_Basement6 = "Basement6";
        public const String FLD_NAME_Outdoor = "Outdoor";
        public const String FLD_NAME_Total = "Total";
        public const String FLD_NAME_GuestParking = "GuestParking";
        public const String FLD_NAME_DisableParking = "DisableParking";
        public const String FLD_NAME_Name = "Name";
        public const String FLD_NAME_Size = "Size";
        public const String FLD_NAME_ProjectFloorName = "ProjectFloorName";
        public const String FLD_NAME_CapacityOfSubstation = "CapacityOfSubstation";
        public const String FLD_NAME_TotalNumberOfGenerator = "TotalNumberOfGenerator";
        public const String FLD_NAME_CapacityOfGenerator1 = "CapacityOfGenerator1";
        public const String FLD_NAME_CapacityOfGenerator2 = "CapacityOfGenerator2";
        public const String FLD_NAME_CapacityOfGenerator3 = "CapacityOfGenerator3";
        public const String FLD_NAME_CapacityOfGenerator4 = "CapacityOfGenerator4";
        public const String FLD_NAME_CapacityOfGenerator5 = "CapacityOfGenerator5";
        public const String FLD_NAME_BDProjectSubstationAndGeneratorBrandID = "BDProjectSubstationAndGeneratorBrandID";
        public const String FLD_NAME_TBA = "TBA";
        public const String FLD_NAME_TBAUnitID = "TBAUnitID";
        public const String FLD_NAME_FAR = "FAR";
        public const String FLD_NAME_FARBonus = "FARBonus";
        public const String FLD_NAME_FIA = "FIA";
        public const String FLD_NAME_FIAUnitID = "FIAUnitID";
        public const String FLD_NAME_FIAAchieved = "FIAAchieved";
        public const String FLD_NAME_FIAAchievedUnitID = "FIAAchievedUnitID";
        public const String FLD_NAME_GSA = "GSA";
        public const String FLD_NAME_GSAUnitID = "GSAUnitID";
        public const String FLD_NAME_MGCPercentages = "MGCPercentages";
        public const String FLD_NAME_MGCArea = "MGCArea";
        public const String FLD_NAME_MGCAreaUnitID = "MGCAreaUnitID";
        public const String FLD_NAME_GroundCoverage = "GroundCoverage";
        public const String FLD_NAME_DateOfAgreement = "DateOfAgreement";
        public const String FLD_NAME_DateOfHandover = "DateOfHandover";
        public const String FLD_NAME_DelayClause = "DelayClause";
        public const String FLD_NAME_ProjectFloorUnitName = "ProjectFloorUnitName";
        public const String FLD_NAME_ProjectFloorUnitStatusID = "ProjectFloorUnitStatusID";
        public const String FLD_NAME_UnitArea = "UnitArea";
        public const String FLD_NAME_TotalArea = "TotalArea";
        public const String FLD_NAME_RegisteredArea = "RegisteredArea";
        public const String FLD_NAME_BDProjectFloorUnitFacing = "BDProjectFloorUnitFacing";
        public const String FLD_NAME_Toilet = "Toilet";
        public const String FLD_NAME_Kitchen = "Kitchen";
        public const String FLD_NAME_Parking = "Parking";
        public const String FLD_NAME_BathRoom = "BathRoom";
        public const String FLD_NAME_BedRoom = "BedRoom";
        public const String FLD_NAME_IsIDServiceAvailable = "IsIDServiceAvailable";
        public const String FLD_NAME_ElectricityService = "ElectricityService";
        public const String FLD_NAME_CommonGenerator = "CommonGenerator";
        public const String FLD_NAME_PricePerSft = "PricePerSft";
        public const String FLD_NAME_AreaPrice = "AreaPrice";
        public const String FLD_NAME_IDPrice = "IDPrice";
        public const String FLD_NAME_AdditionalCharges = "AdditionalCharges";
        public const String FLD_NAME_Features = "Features";
        public const String FLD_NAME_LiftBrandName = "LiftBrandName";
        public const String FLD_NAME_GeneratorBrandName = "GeneratorBrandName";
        public const String FLD_NAME_CountryName = "CountryName";
        public const String FLD_NAME_CityName = "CityName";
        public const String FLD_NAME_FloorUnitTypeName = "FloorUnitTypeName";
        public const String FLD_NAME_FloorUnitStatusName = "FloorUnitStatusName";
        public const String FLD_NAME_TBAUnitName = "TBAUnitName";
        public const String FLD_NAME_FIAUnitName = "FIAUnitName";
        public const String FLD_NAME_GSAUnitName = "GSAUnitName";
        public const String FLD_NAME_MGCAreaUnitName = "MGCAreaUnitName";
        public const String FLD_NAME_FIAArchivedUnitName = "FIAArchivedUnitName";
        public const String FLD_NAME_RoadWidthUnitName = "RoadWidthUnitName";
        public const String FLD_NAME_TypicalFloorAreaUnitName = "TypicalFloorAreaUnitName";
        public const String FLD_NAME_ProjectStatus = "ProjectStatus";
        public const String FLD_NAME_ProjectType = "ProjectType";

        #endregion
    }
}
