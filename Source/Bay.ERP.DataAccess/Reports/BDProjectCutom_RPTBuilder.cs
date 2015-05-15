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
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectCutom_RPTBuilder : IEntityBuilder<BDProjectCutom_RPTEntity>
    {
        IList<BDProjectCutom_RPTEntity> IEntityBuilder<BDProjectCutom_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectCutom_RPTEntity> BDProjectCutom_RPTEntityList = new List<BDProjectCutom_RPTEntity>();

            while (reader.Read())
            {
                BDProjectCutom_RPTEntityList.Add(((IEntityBuilder<BDProjectCutom_RPTEntity>)this).BuildEntity(reader));
            }

            return (BDProjectCutom_RPTEntityList.Count > 0) ? BDProjectCutom_RPTEntityList : null;
        }

        BDProjectCutom_RPTEntity IEntityBuilder<BDProjectCutom_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTID = 0;
            const Int32 FLD_PROJECTCODE = 1;
            const Int32 FLD_PROJECTNAME = 2;
            const Int32 FLD_LANDAREAKATHA = 3;
            const Int32 FLD_LANDAREASFT = 4;
            const Int32 FLD_ROADWIDTH = 5;
            const Int32 FLD_ROADWIDTHUNITID = 6;
            const Int32 FLD_NOOFSTORIED = 7;
            const Int32 FLD_NOOFBASEMENT = 8;
            const Int32 FLD_DESCRIPTION = 9;
            const Int32 FLD_CLIENTPERCENTAGE = 10;
            const Int32 FLD_COMPANYPERCENTAGE = 11;
            const Int32 FLD_PROJECTCATEGORYID = 12;
            const Int32 FLD_PROJECTSTATUSID = 13;
            const Int32 FLD_NUMBEROFSTOREY = 14;
            const Int32 FLD_NUMBEROFBLOCK = 15;
            const Int32 FLD_TYPICALFLOORAREA = 16;
            const Int32 FLD_TYPICALFLOORAREAUNITID = 17;
            const Int32 FLD_GCARCHIEVED = 18;
            const Int32 FLD_NUMBEROFBASEMENT = 19;
            const Int32 FLD_NUMBEROFRESIDENTIALFLOOR = 20;
            const Int32 FLD_NUMBEROFCOMMERCIALFLOOR = 21;
            const Int32 FLD_NOOFRESIDENTIALUNITPERFLOOR = 22;
            const Int32 FLD_FACING = 23;
            const Int32 FLD_TOTALNUMBEROFUNIT = 24;
            const Int32 FLD_NUMBEROFPENTHOUSE = 25;
            const Int32 FLD_NUMBEROFSTAIR = 26;
            const Int32 FLD_POSITIONATBUILDING = 27;
            const Int32 FLD_COOLINGSYSTEM = 28;
            const Int32 FLD_GEYSERSYSTEM = 29;
            const Int32 FLD_FACILITIESATMEZZANINEFLOOR = 30;
            const Int32 FLD_FACILITIESATROOFFLOOR = 31;
            const Int32 FLD_APPROVALREQUIRED = 32;
            const Int32 FLD_ADDRESSLINE1 = 33;
            const Int32 FLD_ADDRESSLINE2 = 34;
            const Int32 FLD_COUNTRYID = 35;
            const Int32 FLD_CITYID = 36;
            const Int32 FLD_ZIPCODE = 37;
            const Int32 FLD_NUMBEROFLIFT = 38;
            const Int32 FLD_NUMBEROFPASSENGERLIFT = 39;
            const Int32 FLD_CAPACITYOFPASSENGERLIFT = 40;
            const Int32 FLD_NUMBEROFSERVICELIFT = 41;
            const Int32 FLD_CAPACITYOFSERVICELIFT = 42;
            const Int32 FLD_NUMBEROFFIREFIGHTERLIFT = 43;
            const Int32 FLD_BRANDID = 44;
            const Int32 FLD_GROUND = 45;
            const Int32 FLD_LOWERGROUND = 46;
            const Int32 FLD_BASEMENT1 = 47;
            const Int32 FLD_BASEMENT2 = 48;
            const Int32 FLD_BASEMENT3 = 49;
            const Int32 FLD_BASEMENT4 = 50;
            const Int32 FLD_BASEMENT5 = 51;
            const Int32 FLD_BASEMENT6 = 52;
            const Int32 FLD_OUTDOOR = 53;
            const Int32 FLD_TOTAL = 54;
            const Int32 FLD_GUESTPARKING = 55;
            const Int32 FLD_DISABLEPARKING = 56;
            const Int32 FLD_NAME = 57;
            const Int32 FLD_SIZE = 58;
            const Int32 FLD_PROJECTFLOORNAME = 59;
            const Int32 FLD_CAPACITYOFSUBSTATION = 60;
            const Int32 FLD_TOTALNUMBEROFGENERATOR = 61;
            const Int32 FLD_CAPACITYOFGENERATOR1 = 62;
            const Int32 FLD_CAPACITYOFGENERATOR2 = 63;
            const Int32 FLD_CAPACITYOFGENERATOR3 = 64;
            const Int32 FLD_CAPACITYOFGENERATOR4 = 65;
            const Int32 FLD_CAPACITYOFGENERATOR5 = 66;
            const Int32 FLD_BDPROJECTSUBSTATIONANDGENERATORBRANDID = 67;
            const Int32 FLD_TBA = 68;
            const Int32 FLD_TBAUNITID = 69;
            const Int32 FLD_FAR = 70;
            const Int32 FLD_FARBONUS = 71;
            const Int32 FLD_FIA = 72;
            const Int32 FLD_FIAUNITID = 73;
            const Int32 FLD_FIAACHIEVED = 74;
            const Int32 FLD_FIAACHIEVEDUNITID = 75;
            const Int32 FLD_GSA = 76;
            const Int32 FLD_GSAUNITID = 77;
            const Int32 FLD_MGCPERCENTAGES = 78;
            const Int32 FLD_MGCAREA = 79;
            const Int32 FLD_MGCAREAUNITID = 80;
            const Int32 FLD_GROUNDCOVERAGE = 81;
            const Int32 FLD_DATEOFAGREEMENT = 82;
            const Int32 FLD_DATEOFHANDOVER = 83;
            const Int32 FLD_DELAYCLAUSE = 84;
            const Int32 FLD_PROJECTFLOORUNITNAME = 85;
            const Int32 FLD_PROJECTFLOORUNITSTATUSID = 86;
            const Int32 FLD_UNITAREA = 87;
            const Int32 FLD_TOTALAREA = 88;
            const Int32 FLD_REGISTEREDAREA = 89;
            const Int32 FLD_BDPROJECTFLOORUNITFACING = 90;
            const Int32 FLD_TOILET = 91;
            const Int32 FLD_KITCHEN = 92;
            const Int32 FLD_PARKING = 93;
            const Int32 FLD_BATHROOM = 94;
            const Int32 FLD_BEDROOM = 95;
            const Int32 FLD_ISIDSERVICEAVAILABLE = 96;
            const Int32 FLD_ELECTRICITYSERVICE = 97;
            const Int32 FLD_COMMONGENERATOR = 98;
            const Int32 FLD_PRICEPERSFT = 99;
            const Int32 FLD_AREAPRICE = 100;
            const Int32 FLD_IDPRICE = 101;
            const Int32 FLD_ADDITIONALCHARGES = 102;
            const Int32 FLD_FEATURES = 103;
            const Int32 FLD_LIFTBRANDNAME = 104;
            const Int32 FLD_GENERATORBRANDNAME = 105;
            const Int32 FLD_COUNTRYNAME = 106;
            const Int32 FLD_CITYNAME = 107;
            const Int32 FLD_FLOORUNITTYPENAME = 108;
            const Int32 FLD_FLOORUNITSTATUSNAME = 109;
            const Int32 FLD_TBAUNITNAME = 110;
            const Int32 FLD_FIAUNITNAME = 111;
            const Int32 FLD_GSAUNITNAME = 112;
            const Int32 FLD_MGCAREAUNITNAME = 113;
            const Int32 FLD_FIAARCHIVEDUNITNAME = 114;
            const Int32 FLD_ROADWIDTHUNITNAME = 115;
            const Int32 FLD_TYPICALFLOORAREAUNITNAME = 116;
            const Int32 FLD_PROJECTSTATUS = 117;
            const Int32 FLD_PROJECTTYPE = 118;

            BDProjectCutom_RPTEntity bDProjectCutom_RPTEntity = new BDProjectCutom_RPTEntity();

            bDProjectCutom_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectCutom_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            bDProjectCutom_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_LANDAREAKATHA)) { bDProjectCutom_RPTEntity.LandAreaKatha = null; } else { bDProjectCutom_RPTEntity.LandAreaKatha = reader.GetDecimal(FLD_LANDAREAKATHA); }
            if (reader.IsDBNull(FLD_LANDAREASFT)) { bDProjectCutom_RPTEntity.LandAreaSft = null; } else { bDProjectCutom_RPTEntity.LandAreaSft = reader.GetDecimal(FLD_LANDAREASFT); }
            if (reader.IsDBNull(FLD_ROADWIDTH)) { bDProjectCutom_RPTEntity.RoadWidth = null; } else { bDProjectCutom_RPTEntity.RoadWidth = reader.GetDecimal(FLD_ROADWIDTH); }
            if (reader.IsDBNull(FLD_ROADWIDTHUNITID)) { bDProjectCutom_RPTEntity.RoadWidthUnitID = null; } else { bDProjectCutom_RPTEntity.RoadWidthUnitID = reader.GetInt64(FLD_ROADWIDTHUNITID); }
            if (reader.IsDBNull(FLD_NOOFSTORIED)) { bDProjectCutom_RPTEntity.NoOfStoried = null; } else { bDProjectCutom_RPTEntity.NoOfStoried = reader.GetInt32(FLD_NOOFSTORIED); }
            if (reader.IsDBNull(FLD_NOOFBASEMENT)) { bDProjectCutom_RPTEntity.NoOfBasement = null; } else { bDProjectCutom_RPTEntity.NoOfBasement = reader.GetInt32(FLD_NOOFBASEMENT); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDProjectCutom_RPTEntity.Description = String.Empty; } else { bDProjectCutom_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_CLIENTPERCENTAGE)) { bDProjectCutom_RPTEntity.ClientPercentage = null; } else { bDProjectCutom_RPTEntity.ClientPercentage = reader.GetDecimal(FLD_CLIENTPERCENTAGE); }
            if (reader.IsDBNull(FLD_COMPANYPERCENTAGE)) { bDProjectCutom_RPTEntity.CompanyPercentage = null; } else { bDProjectCutom_RPTEntity.CompanyPercentage = reader.GetDecimal(FLD_COMPANYPERCENTAGE); }
            bDProjectCutom_RPTEntity.ProjectCategoryID = reader.GetInt64(FLD_PROJECTCATEGORYID);
            bDProjectCutom_RPTEntity.ProjectStatusID = reader.GetInt64(FLD_PROJECTSTATUSID);
            if (reader.IsDBNull(FLD_NUMBEROFSTOREY)) { bDProjectCutom_RPTEntity.NumberOfStorey = null; } else { bDProjectCutom_RPTEntity.NumberOfStorey = reader.GetDecimal(FLD_NUMBEROFSTOREY); }
            if (reader.IsDBNull(FLD_NUMBEROFBLOCK)) { bDProjectCutom_RPTEntity.NumberOfBlock = null; } else { bDProjectCutom_RPTEntity.NumberOfBlock = reader.GetDecimal(FLD_NUMBEROFBLOCK); }
            if (reader.IsDBNull(FLD_TYPICALFLOORAREA)) { bDProjectCutom_RPTEntity.TypicalFloorArea = null; } else { bDProjectCutom_RPTEntity.TypicalFloorArea = reader.GetDecimal(FLD_TYPICALFLOORAREA); }
            if (reader.IsDBNull(FLD_TYPICALFLOORAREAUNITID)) { bDProjectCutom_RPTEntity.TypicalFloorAreaUnitID = null; } else { bDProjectCutom_RPTEntity.TypicalFloorAreaUnitID = reader.GetInt64(FLD_TYPICALFLOORAREAUNITID); }
            if (reader.IsDBNull(FLD_GCARCHIEVED)) { bDProjectCutom_RPTEntity.GCArchieved = null; } else { bDProjectCutom_RPTEntity.GCArchieved = reader.GetDecimal(FLD_GCARCHIEVED); }
            if (reader.IsDBNull(FLD_NUMBEROFBASEMENT)) { bDProjectCutom_RPTEntity.NumberOfBasement = null; } else { bDProjectCutom_RPTEntity.NumberOfBasement = reader.GetDecimal(FLD_NUMBEROFBASEMENT); }
            if (reader.IsDBNull(FLD_NUMBEROFRESIDENTIALFLOOR)) { bDProjectCutom_RPTEntity.NumberOfResidentialFloor = null; } else { bDProjectCutom_RPTEntity.NumberOfResidentialFloor = reader.GetDecimal(FLD_NUMBEROFRESIDENTIALFLOOR); }
            if (reader.IsDBNull(FLD_NUMBEROFCOMMERCIALFLOOR)) { bDProjectCutom_RPTEntity.NumberOfCommercialFloor = null; } else { bDProjectCutom_RPTEntity.NumberOfCommercialFloor = reader.GetDecimal(FLD_NUMBEROFCOMMERCIALFLOOR); }
            if (reader.IsDBNull(FLD_NOOFRESIDENTIALUNITPERFLOOR)) { bDProjectCutom_RPTEntity.NoOfResidentialUnitPerFloor = null; } else { bDProjectCutom_RPTEntity.NoOfResidentialUnitPerFloor = reader.GetDecimal(FLD_NOOFRESIDENTIALUNITPERFLOOR); }
            if (reader.IsDBNull(FLD_FACING)) { bDProjectCutom_RPTEntity.Facing = String.Empty; } else { bDProjectCutom_RPTEntity.Facing = reader.GetString(FLD_FACING); }
            if (reader.IsDBNull(FLD_TOTALNUMBEROFUNIT)) { bDProjectCutom_RPTEntity.TotalNumberOfUnit = null; } else { bDProjectCutom_RPTEntity.TotalNumberOfUnit = reader.GetDecimal(FLD_TOTALNUMBEROFUNIT); }
            if (reader.IsDBNull(FLD_NUMBEROFPENTHOUSE)) { bDProjectCutom_RPTEntity.NumberOfPenthouse = null; } else { bDProjectCutom_RPTEntity.NumberOfPenthouse = reader.GetDecimal(FLD_NUMBEROFPENTHOUSE); }
            if (reader.IsDBNull(FLD_NUMBEROFSTAIR)) { bDProjectCutom_RPTEntity.NumberOfStair = null; } else { bDProjectCutom_RPTEntity.NumberOfStair = reader.GetDecimal(FLD_NUMBEROFSTAIR); }
            if (reader.IsDBNull(FLD_POSITIONATBUILDING)) { bDProjectCutom_RPTEntity.PositionAtBuilding = String.Empty; } else { bDProjectCutom_RPTEntity.PositionAtBuilding = reader.GetString(FLD_POSITIONATBUILDING); }
            if (reader.IsDBNull(FLD_COOLINGSYSTEM)) { bDProjectCutom_RPTEntity.CoolingSystem = String.Empty; } else { bDProjectCutom_RPTEntity.CoolingSystem = reader.GetString(FLD_COOLINGSYSTEM); }
            if (reader.IsDBNull(FLD_GEYSERSYSTEM)) { bDProjectCutom_RPTEntity.GeyserSystem = String.Empty; } else { bDProjectCutom_RPTEntity.GeyserSystem = reader.GetString(FLD_GEYSERSYSTEM); }
            if (reader.IsDBNull(FLD_FACILITIESATMEZZANINEFLOOR)) { bDProjectCutom_RPTEntity.FacilitiesAtMezzanineFloor = String.Empty; } else { bDProjectCutom_RPTEntity.FacilitiesAtMezzanineFloor = reader.GetString(FLD_FACILITIESATMEZZANINEFLOOR); }
            if (reader.IsDBNull(FLD_FACILITIESATROOFFLOOR)) { bDProjectCutom_RPTEntity.FacilitiesAtRoofFloor = String.Empty; } else { bDProjectCutom_RPTEntity.FacilitiesAtRoofFloor = reader.GetString(FLD_FACILITIESATROOFFLOOR); }
            if (reader.IsDBNull(FLD_APPROVALREQUIRED)) { bDProjectCutom_RPTEntity.ApprovalRequired = String.Empty; } else { bDProjectCutom_RPTEntity.ApprovalRequired = reader.GetString(FLD_APPROVALREQUIRED); }
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { bDProjectCutom_RPTEntity.AddressLine1 = String.Empty; } else { bDProjectCutom_RPTEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { bDProjectCutom_RPTEntity.AddressLine2 = String.Empty; } else { bDProjectCutom_RPTEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { bDProjectCutom_RPTEntity.CountryID = null; } else { bDProjectCutom_RPTEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { bDProjectCutom_RPTEntity.CityID = null; } else { bDProjectCutom_RPTEntity.CityID = reader.GetInt64(FLD_CITYID); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { bDProjectCutom_RPTEntity.ZipCode = String.Empty; } else { bDProjectCutom_RPTEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_NUMBEROFLIFT)) { bDProjectCutom_RPTEntity.NumberOfLift = null; } else { bDProjectCutom_RPTEntity.NumberOfLift = reader.GetDecimal(FLD_NUMBEROFLIFT); }
            if (reader.IsDBNull(FLD_NUMBEROFPASSENGERLIFT)) { bDProjectCutom_RPTEntity.NumberOfPassengerLift = null; } else { bDProjectCutom_RPTEntity.NumberOfPassengerLift = reader.GetDecimal(FLD_NUMBEROFPASSENGERLIFT); }
            if (reader.IsDBNull(FLD_CAPACITYOFPASSENGERLIFT)) { bDProjectCutom_RPTEntity.CapacityOfPassengerLift = null; } else { bDProjectCutom_RPTEntity.CapacityOfPassengerLift = reader.GetDecimal(FLD_CAPACITYOFPASSENGERLIFT); }
            if (reader.IsDBNull(FLD_NUMBEROFSERVICELIFT)) { bDProjectCutom_RPTEntity.NumberOfServiceLift = null; } else { bDProjectCutom_RPTEntity.NumberOfServiceLift = reader.GetDecimal(FLD_NUMBEROFSERVICELIFT); }
            if (reader.IsDBNull(FLD_CAPACITYOFSERVICELIFT)) { bDProjectCutom_RPTEntity.CapacityOfServiceLift = null; } else { bDProjectCutom_RPTEntity.CapacityOfServiceLift = reader.GetDecimal(FLD_CAPACITYOFSERVICELIFT); }
            if (reader.IsDBNull(FLD_NUMBEROFFIREFIGHTERLIFT)) { bDProjectCutom_RPTEntity.NumberOfFireFighterLift = null; } else { bDProjectCutom_RPTEntity.NumberOfFireFighterLift = reader.GetDecimal(FLD_NUMBEROFFIREFIGHTERLIFT); }
            if (reader.IsDBNull(FLD_BRANDID)) { bDProjectCutom_RPTEntity.BrandID = null; } else { bDProjectCutom_RPTEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_GROUND)) { bDProjectCutom_RPTEntity.Ground = null; } else { bDProjectCutom_RPTEntity.Ground = reader.GetDecimal(FLD_GROUND); }
            if (reader.IsDBNull(FLD_LOWERGROUND)) { bDProjectCutom_RPTEntity.LowerGround = null; } else { bDProjectCutom_RPTEntity.LowerGround = reader.GetDecimal(FLD_LOWERGROUND); }
            if (reader.IsDBNull(FLD_BASEMENT1)) { bDProjectCutom_RPTEntity.Basement1 = null; } else { bDProjectCutom_RPTEntity.Basement1 = reader.GetDecimal(FLD_BASEMENT1); }
            if (reader.IsDBNull(FLD_BASEMENT2)) { bDProjectCutom_RPTEntity.Basement2 = null; } else { bDProjectCutom_RPTEntity.Basement2 = reader.GetDecimal(FLD_BASEMENT2); }
            if (reader.IsDBNull(FLD_BASEMENT3)) { bDProjectCutom_RPTEntity.Basement3 = null; } else { bDProjectCutom_RPTEntity.Basement3 = reader.GetDecimal(FLD_BASEMENT3); }
            if (reader.IsDBNull(FLD_BASEMENT4)) { bDProjectCutom_RPTEntity.Basement4 = null; } else { bDProjectCutom_RPTEntity.Basement4 = reader.GetDecimal(FLD_BASEMENT4); }
            if (reader.IsDBNull(FLD_BASEMENT5)) { bDProjectCutom_RPTEntity.Basement5 = null; } else { bDProjectCutom_RPTEntity.Basement5 = reader.GetDecimal(FLD_BASEMENT5); }
            if (reader.IsDBNull(FLD_BASEMENT6)) { bDProjectCutom_RPTEntity.Basement6 = null; } else { bDProjectCutom_RPTEntity.Basement6 = reader.GetDecimal(FLD_BASEMENT6); }
            if (reader.IsDBNull(FLD_OUTDOOR)) { bDProjectCutom_RPTEntity.Outdoor = null; } else { bDProjectCutom_RPTEntity.Outdoor = reader.GetDecimal(FLD_OUTDOOR); }
            if (reader.IsDBNull(FLD_TOTAL)) { bDProjectCutom_RPTEntity.Total = null; } else { bDProjectCutom_RPTEntity.Total = reader.GetDecimal(FLD_TOTAL); }
            if (reader.IsDBNull(FLD_GUESTPARKING)) { bDProjectCutom_RPTEntity.GuestParking = null; } else { bDProjectCutom_RPTEntity.GuestParking = reader.GetDecimal(FLD_GUESTPARKING); }
            if (reader.IsDBNull(FLD_DISABLEPARKING)) { bDProjectCutom_RPTEntity.DisableParking = null; } else { bDProjectCutom_RPTEntity.DisableParking = reader.GetDecimal(FLD_DISABLEPARKING); }
            if (reader.IsDBNull(FLD_NAME)) { bDProjectCutom_RPTEntity.Name = String.Empty; } else { bDProjectCutom_RPTEntity.Name = reader.GetString(FLD_NAME); }
            if (reader.IsDBNull(FLD_SIZE)) { bDProjectCutom_RPTEntity.Size = null; } else { bDProjectCutom_RPTEntity.Size = reader.GetInt32(FLD_SIZE); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { bDProjectCutom_RPTEntity.ProjectFloorName = String.Empty; } else { bDProjectCutom_RPTEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_CAPACITYOFSUBSTATION)) { bDProjectCutom_RPTEntity.CapacityOfSubstation = null; } else { bDProjectCutom_RPTEntity.CapacityOfSubstation = reader.GetDecimal(FLD_CAPACITYOFSUBSTATION); }
            if (reader.IsDBNull(FLD_TOTALNUMBEROFGENERATOR)) { bDProjectCutom_RPTEntity.TotalNumberOfGenerator = null; } else { bDProjectCutom_RPTEntity.TotalNumberOfGenerator = reader.GetDecimal(FLD_TOTALNUMBEROFGENERATOR); }
            if (reader.IsDBNull(FLD_CAPACITYOFGENERATOR1)) { bDProjectCutom_RPTEntity.CapacityOfGenerator1 = null; } else { bDProjectCutom_RPTEntity.CapacityOfGenerator1 = reader.GetDecimal(FLD_CAPACITYOFGENERATOR1); }
            if (reader.IsDBNull(FLD_CAPACITYOFGENERATOR2)) { bDProjectCutom_RPTEntity.CapacityOfGenerator2 = null; } else { bDProjectCutom_RPTEntity.CapacityOfGenerator2 = reader.GetDecimal(FLD_CAPACITYOFGENERATOR2); }
            if (reader.IsDBNull(FLD_CAPACITYOFGENERATOR3)) { bDProjectCutom_RPTEntity.CapacityOfGenerator3 = null; } else { bDProjectCutom_RPTEntity.CapacityOfGenerator3 = reader.GetDecimal(FLD_CAPACITYOFGENERATOR3); }
            if (reader.IsDBNull(FLD_CAPACITYOFGENERATOR4)) { bDProjectCutom_RPTEntity.CapacityOfGenerator4 = null; } else { bDProjectCutom_RPTEntity.CapacityOfGenerator4 = reader.GetDecimal(FLD_CAPACITYOFGENERATOR4); }
            if (reader.IsDBNull(FLD_CAPACITYOFGENERATOR5)) { bDProjectCutom_RPTEntity.CapacityOfGenerator5 = null; } else { bDProjectCutom_RPTEntity.CapacityOfGenerator5 = reader.GetDecimal(FLD_CAPACITYOFGENERATOR5); }
            if (reader.IsDBNull(FLD_BDPROJECTSUBSTATIONANDGENERATORBRANDID)) { bDProjectCutom_RPTEntity.BDProjectSubstationAndGeneratorBrandID = null; } else { bDProjectCutom_RPTEntity.BDProjectSubstationAndGeneratorBrandID = reader.GetInt64(FLD_BDPROJECTSUBSTATIONANDGENERATORBRANDID); }
            if (reader.IsDBNull(FLD_TBA)) { bDProjectCutom_RPTEntity.TBA = null; } else { bDProjectCutom_RPTEntity.TBA = reader.GetDecimal(FLD_TBA); }
            if (reader.IsDBNull(FLD_TBAUNITID)) { bDProjectCutom_RPTEntity.TBAUnitID = null; } else { bDProjectCutom_RPTEntity.TBAUnitID = reader.GetInt64(FLD_TBAUNITID); }
            if (reader.IsDBNull(FLD_FAR)) { bDProjectCutom_RPTEntity.FAR = null; } else { bDProjectCutom_RPTEntity.FAR = reader.GetDecimal(FLD_FAR); }
            if (reader.IsDBNull(FLD_FARBONUS)) { bDProjectCutom_RPTEntity.FARBonus = null; } else { bDProjectCutom_RPTEntity.FARBonus = reader.GetDecimal(FLD_FARBONUS); }
            if (reader.IsDBNull(FLD_FIA)) { bDProjectCutom_RPTEntity.FIA = null; } else { bDProjectCutom_RPTEntity.FIA = reader.GetDecimal(FLD_FIA); }
            if (reader.IsDBNull(FLD_FIAUNITID)) { bDProjectCutom_RPTEntity.FIAUnitID = null; } else { bDProjectCutom_RPTEntity.FIAUnitID = reader.GetInt64(FLD_FIAUNITID); }
            if (reader.IsDBNull(FLD_FIAACHIEVED)) { bDProjectCutom_RPTEntity.FIAAchieved = null; } else { bDProjectCutom_RPTEntity.FIAAchieved = reader.GetDecimal(FLD_FIAACHIEVED); }
            if (reader.IsDBNull(FLD_FIAACHIEVEDUNITID)) { bDProjectCutom_RPTEntity.FIAAchievedUnitID = null; } else { bDProjectCutom_RPTEntity.FIAAchievedUnitID = reader.GetInt64(FLD_FIAACHIEVEDUNITID); }
            if (reader.IsDBNull(FLD_GSA)) { bDProjectCutom_RPTEntity.GSA = null; } else { bDProjectCutom_RPTEntity.GSA = reader.GetDecimal(FLD_GSA); }
            if (reader.IsDBNull(FLD_GSAUNITID)) { bDProjectCutom_RPTEntity.GSAUnitID = null; } else { bDProjectCutom_RPTEntity.GSAUnitID = reader.GetInt64(FLD_GSAUNITID); }
            if (reader.IsDBNull(FLD_MGCPERCENTAGES)) { bDProjectCutom_RPTEntity.MGCPercentages = null; } else { bDProjectCutom_RPTEntity.MGCPercentages = reader.GetDecimal(FLD_MGCPERCENTAGES); }
            if (reader.IsDBNull(FLD_MGCAREA)) { bDProjectCutom_RPTEntity.MGCArea = null; } else { bDProjectCutom_RPTEntity.MGCArea = reader.GetDecimal(FLD_MGCAREA); }
            if (reader.IsDBNull(FLD_MGCAREAUNITID)) { bDProjectCutom_RPTEntity.MGCAreaUnitID = null; } else { bDProjectCutom_RPTEntity.MGCAreaUnitID = reader.GetInt64(FLD_MGCAREAUNITID); }
            if (reader.IsDBNull(FLD_GROUNDCOVERAGE)) { bDProjectCutom_RPTEntity.GroundCoverage = String.Empty; } else { bDProjectCutom_RPTEntity.GroundCoverage = reader.GetString(FLD_GROUNDCOVERAGE); }
            if (reader.IsDBNull(FLD_DATEOFAGREEMENT)) { bDProjectCutom_RPTEntity.DateOfAgreement = null; } else { bDProjectCutom_RPTEntity.DateOfAgreement = reader.GetDateTime(FLD_DATEOFAGREEMENT); }
            if (reader.IsDBNull(FLD_DATEOFHANDOVER)) { bDProjectCutom_RPTEntity.DateOfHandover = null; } else { bDProjectCutom_RPTEntity.DateOfHandover = reader.GetDateTime(FLD_DATEOFHANDOVER); }
            if (reader.IsDBNull(FLD_DELAYCLAUSE)) { bDProjectCutom_RPTEntity.DelayClause = String.Empty; } else { bDProjectCutom_RPTEntity.DelayClause = reader.GetString(FLD_DELAYCLAUSE); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { bDProjectCutom_RPTEntity.ProjectFloorUnitName = String.Empty; } else { bDProjectCutom_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITSTATUSID)) { bDProjectCutom_RPTEntity.ProjectFloorUnitStatusID = null; } else { bDProjectCutom_RPTEntity.ProjectFloorUnitStatusID = reader.GetInt64(FLD_PROJECTFLOORUNITSTATUSID); }
            if (reader.IsDBNull(FLD_UNITAREA)) { bDProjectCutom_RPTEntity.UnitArea = null; } else { bDProjectCutom_RPTEntity.UnitArea = reader.GetDecimal(FLD_UNITAREA); }
            if (reader.IsDBNull(FLD_TOTALAREA)) { bDProjectCutom_RPTEntity.TotalArea = null; } else { bDProjectCutom_RPTEntity.TotalArea = reader.GetDecimal(FLD_TOTALAREA); }
            if (reader.IsDBNull(FLD_REGISTEREDAREA)) { bDProjectCutom_RPTEntity.RegisteredArea = null; } else { bDProjectCutom_RPTEntity.RegisteredArea = reader.GetDecimal(FLD_REGISTEREDAREA); }
            if (reader.IsDBNull(FLD_BDPROJECTFLOORUNITFACING)) { bDProjectCutom_RPTEntity.BDProjectFloorUnitFacing = String.Empty; } else { bDProjectCutom_RPTEntity.BDProjectFloorUnitFacing = reader.GetString(FLD_BDPROJECTFLOORUNITFACING); }
            if (reader.IsDBNull(FLD_TOILET)) { bDProjectCutom_RPTEntity.Toilet = null; } else { bDProjectCutom_RPTEntity.Toilet = reader.GetDecimal(FLD_TOILET); }
            if (reader.IsDBNull(FLD_KITCHEN)) { bDProjectCutom_RPTEntity.Kitchen = null; } else { bDProjectCutom_RPTEntity.Kitchen = reader.GetDecimal(FLD_KITCHEN); }
            if (reader.IsDBNull(FLD_PARKING)) { bDProjectCutom_RPTEntity.Parking = null; } else { bDProjectCutom_RPTEntity.Parking = reader.GetDecimal(FLD_PARKING); }
            if (reader.IsDBNull(FLD_BATHROOM)) { bDProjectCutom_RPTEntity.BathRoom = null; } else { bDProjectCutom_RPTEntity.BathRoom = reader.GetDecimal(FLD_BATHROOM); }
            if (reader.IsDBNull(FLD_BEDROOM)) { bDProjectCutom_RPTEntity.BedRoom = null; } else { bDProjectCutom_RPTEntity.BedRoom = reader.GetDecimal(FLD_BEDROOM); }
            if (reader.IsDBNull(FLD_ISIDSERVICEAVAILABLE)) { bDProjectCutom_RPTEntity.IsIDServiceAvailable = false; } else { bDProjectCutom_RPTEntity.IsIDServiceAvailable = reader.GetBoolean(FLD_ISIDSERVICEAVAILABLE); }
            if (reader.IsDBNull(FLD_ELECTRICITYSERVICE)) { bDProjectCutom_RPTEntity.ElectricityService = false; } else { bDProjectCutom_RPTEntity.ElectricityService = reader.GetBoolean(FLD_ELECTRICITYSERVICE); }
            if (reader.IsDBNull(FLD_COMMONGENERATOR)) { bDProjectCutom_RPTEntity.CommonGenerator = false; } else { bDProjectCutom_RPTEntity.CommonGenerator = reader.GetBoolean(FLD_COMMONGENERATOR); }
            if (reader.IsDBNull(FLD_PRICEPERSFT)) { bDProjectCutom_RPTEntity.PricePerSft = null; } else { bDProjectCutom_RPTEntity.PricePerSft = reader.GetDecimal(FLD_PRICEPERSFT); }
            if (reader.IsDBNull(FLD_AREAPRICE)) { bDProjectCutom_RPTEntity.AreaPrice = null; } else { bDProjectCutom_RPTEntity.AreaPrice = reader.GetDecimal(FLD_AREAPRICE); }
            if (reader.IsDBNull(FLD_IDPRICE)) { bDProjectCutom_RPTEntity.IDPrice = null; } else { bDProjectCutom_RPTEntity.IDPrice = reader.GetDecimal(FLD_IDPRICE); }
            if (reader.IsDBNull(FLD_ADDITIONALCHARGES)) { bDProjectCutom_RPTEntity.AdditionalCharges = null; } else { bDProjectCutom_RPTEntity.AdditionalCharges = reader.GetDecimal(FLD_ADDITIONALCHARGES); }
            if (reader.IsDBNull(FLD_FEATURES)) { bDProjectCutom_RPTEntity.Features = String.Empty; } else { bDProjectCutom_RPTEntity.Features = reader.GetString(FLD_FEATURES); }
            if (reader.IsDBNull(FLD_LIFTBRANDNAME)) { bDProjectCutom_RPTEntity.LiftBrandName = String.Empty; } else { bDProjectCutom_RPTEntity.LiftBrandName = reader.GetString(FLD_LIFTBRANDNAME); }
            if (reader.IsDBNull(FLD_GENERATORBRANDNAME)) { bDProjectCutom_RPTEntity.GeneratorBrandName = String.Empty; } else { bDProjectCutom_RPTEntity.GeneratorBrandName = reader.GetString(FLD_GENERATORBRANDNAME); }
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { bDProjectCutom_RPTEntity.CountryName = String.Empty; } else { bDProjectCutom_RPTEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_CITYNAME)) { bDProjectCutom_RPTEntity.CityName = String.Empty; } else { bDProjectCutom_RPTEntity.CityName = reader.GetString(FLD_CITYNAME); }
            if (reader.IsDBNull(FLD_FLOORUNITTYPENAME)) { bDProjectCutom_RPTEntity.FloorUnitTypeName = String.Empty; } else { bDProjectCutom_RPTEntity.FloorUnitTypeName = reader.GetString(FLD_FLOORUNITTYPENAME); }
            if (reader.IsDBNull(FLD_FLOORUNITSTATUSNAME)) { bDProjectCutom_RPTEntity.FloorUnitStatusName = String.Empty; } else { bDProjectCutom_RPTEntity.FloorUnitStatusName = reader.GetString(FLD_FLOORUNITSTATUSNAME); }
            if (reader.IsDBNull(FLD_TBAUNITNAME)) { bDProjectCutom_RPTEntity.TBAUnitName = String.Empty; } else { bDProjectCutom_RPTEntity.TBAUnitName = reader.GetString(FLD_TBAUNITNAME); }
            if (reader.IsDBNull(FLD_FIAUNITNAME)) { bDProjectCutom_RPTEntity.FIAUnitName = String.Empty; } else { bDProjectCutom_RPTEntity.FIAUnitName = reader.GetString(FLD_FIAUNITNAME); }
            if (reader.IsDBNull(FLD_GSAUNITNAME)) { bDProjectCutom_RPTEntity.GSAUnitName = String.Empty; } else { bDProjectCutom_RPTEntity.GSAUnitName = reader.GetString(FLD_GSAUNITNAME); }
            if (reader.IsDBNull(FLD_MGCAREAUNITNAME)) { bDProjectCutom_RPTEntity.MGCAreaUnitName = String.Empty; } else { bDProjectCutom_RPTEntity.MGCAreaUnitName = reader.GetString(FLD_MGCAREAUNITNAME); }
            if (reader.IsDBNull(FLD_FIAARCHIVEDUNITNAME)) { bDProjectCutom_RPTEntity.FIAArchivedUnitName = String.Empty; } else { bDProjectCutom_RPTEntity.FIAArchivedUnitName = reader.GetString(FLD_FIAARCHIVEDUNITNAME); }
            if (reader.IsDBNull(FLD_ROADWIDTHUNITNAME)) { bDProjectCutom_RPTEntity.RoadWidthUnitName = String.Empty; } else { bDProjectCutom_RPTEntity.RoadWidthUnitName = reader.GetString(FLD_ROADWIDTHUNITNAME); }
            if (reader.IsDBNull(FLD_TYPICALFLOORAREAUNITNAME)) { bDProjectCutom_RPTEntity.TypicalFloorAreaUnitName = String.Empty; } else { bDProjectCutom_RPTEntity.TypicalFloorAreaUnitName = reader.GetString(FLD_TYPICALFLOORAREAUNITNAME); }
            bDProjectCutom_RPTEntity.ProjectStatus = reader.GetString(FLD_PROJECTSTATUS);
            bDProjectCutom_RPTEntity.ProjectType = reader.GetString(FLD_PROJECTTYPE);

            return bDProjectCutom_RPTEntity;
        }
    }
}
