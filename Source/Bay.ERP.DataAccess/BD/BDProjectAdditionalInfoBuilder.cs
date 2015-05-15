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
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectAdditionalInfoBuilder : IEntityBuilder<BDProjectAdditionalInfoEntity>
    {
        IList<BDProjectAdditionalInfoEntity> IEntityBuilder<BDProjectAdditionalInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectAdditionalInfoEntity> BDProjectAdditionalInfoEntityList = new List<BDProjectAdditionalInfoEntity>();

            while (reader.Read())
            {
                BDProjectAdditionalInfoEntityList.Add(((IEntityBuilder<BDProjectAdditionalInfoEntity>)this).BuildEntity(reader));
            }

            return (BDProjectAdditionalInfoEntityList.Count > 0) ? BDProjectAdditionalInfoEntityList : null;
        }

        BDProjectAdditionalInfoEntity IEntityBuilder<BDProjectAdditionalInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTADDITIONALINFOID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_NUMBEROFSTOREY = 2;
            const Int32 FLD_NUMBEROFBLOCK = 3;
            const Int32 FLD_TYPICALFLOORAREA = 4;
            const Int32 FLD_TYPICALFLOORAREAUNITID = 5;
            const Int32 FLD_GCARCHIEVED = 6;
            const Int32 FLD_NUMBEROFBASEMENT = 7;
            const Int32 FLD_NUMBEROFRESIDENTIALFLOOR = 8;
            const Int32 FLD_NUMBEROFCOMMERCIALFLOOR = 9;
            const Int32 FLD_NOOFRESIDENTIALUNITPERFLOOR = 10;
            const Int32 FLD_FACING = 11;
            const Int32 FLD_TOTALNUMBEROFUNIT = 12;
            const Int32 FLD_NUMBEROFPENTHOUSE = 13;
            const Int32 FLD_NUMBEROFSTAIR = 14;
            const Int32 FLD_POSITIONATBUILDING = 15;
            const Int32 FLD_COOLINGSYSTEM = 16;
            const Int32 FLD_GEYSERSYSTEM = 17;
            const Int32 FLD_FACILITIESATMEZZANINEFLOOR = 18;
            const Int32 FLD_FACILITIESATROOFFLOOR = 19;
            const Int32 FLD_APPROVALREQUIRED = 20;
            const Int32 FLD_POSITIONATBUILDINGFORCOMMERCIAL = 21;
            const Int32 FLD_GROUNDFLOORHEIGHT = 22;
            const Int32 FLD_TYPICALFLOORHEIGHT = 23;
            const Int32 FLD_GROUNDFLOORHEIGHTUNITINFEETID = 24;
            const Int32 FLD_TYPICALFLOORHEIGHTUNITINCHID = 25;
            const Int32 FLD_GROUNDFLOORHEIGHTINCH = 26;
			const Int32 FLD_GROUNDFLOORHEIGHTUNITININCHID = 27;
			const Int32 FLD_TYPICALFLOORHEIGHTFEET = 28;
			const Int32 FLD_TYPICALFLOORHEIGHTUNITFEETID = 29;

            BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity = new BDProjectAdditionalInfoEntity();

            bDProjectAdditionalInfoEntity.ProjectAdditionalInfoID = reader.GetInt64(FLD_PROJECTADDITIONALINFOID);
            bDProjectAdditionalInfoEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectAdditionalInfoEntity.NumberOfStorey = reader.GetDecimal(FLD_NUMBEROFSTOREY);
            if (reader.IsDBNull(FLD_NUMBEROFBLOCK)) { bDProjectAdditionalInfoEntity.NumberOfBlock = null; } else { bDProjectAdditionalInfoEntity.NumberOfBlock = reader.GetDecimal(FLD_NUMBEROFBLOCK); }
            if (reader.IsDBNull(FLD_TYPICALFLOORAREA)) { bDProjectAdditionalInfoEntity.TypicalFloorArea = null; } else { bDProjectAdditionalInfoEntity.TypicalFloorArea = reader.GetDecimal(FLD_TYPICALFLOORAREA); }
            if (reader.IsDBNull(FLD_TYPICALFLOORAREAUNITID)) { bDProjectAdditionalInfoEntity.TypicalFloorAreaUnitID = null; } else { bDProjectAdditionalInfoEntity.TypicalFloorAreaUnitID = reader.GetInt64(FLD_TYPICALFLOORAREAUNITID); }
            if (reader.IsDBNull(FLD_GCARCHIEVED)) { bDProjectAdditionalInfoEntity.GCArchieved = null; } else { bDProjectAdditionalInfoEntity.GCArchieved = reader.GetDecimal(FLD_GCARCHIEVED); }
            if (reader.IsDBNull(FLD_NUMBEROFBASEMENT)) { bDProjectAdditionalInfoEntity.NumberOfBasement = null; } else { bDProjectAdditionalInfoEntity.NumberOfBasement = reader.GetDecimal(FLD_NUMBEROFBASEMENT); }
            if (reader.IsDBNull(FLD_NUMBEROFRESIDENTIALFLOOR)) { bDProjectAdditionalInfoEntity.NumberOfResidentialFloor = null; } else { bDProjectAdditionalInfoEntity.NumberOfResidentialFloor = reader.GetDecimal(FLD_NUMBEROFRESIDENTIALFLOOR); }
            if (reader.IsDBNull(FLD_NUMBEROFCOMMERCIALFLOOR)) { bDProjectAdditionalInfoEntity.NumberOfCommercialFloor = null; } else { bDProjectAdditionalInfoEntity.NumberOfCommercialFloor = reader.GetDecimal(FLD_NUMBEROFCOMMERCIALFLOOR); }
            if (reader.IsDBNull(FLD_NOOFRESIDENTIALUNITPERFLOOR)) { bDProjectAdditionalInfoEntity.NoOfResidentialUnitPerFloor = null; } else { bDProjectAdditionalInfoEntity.NoOfResidentialUnitPerFloor = reader.GetDecimal(FLD_NOOFRESIDENTIALUNITPERFLOOR); }
            if (reader.IsDBNull(FLD_FACING)) { bDProjectAdditionalInfoEntity.Facing = String.Empty; } else { bDProjectAdditionalInfoEntity.Facing = reader.GetString(FLD_FACING); }
            if (reader.IsDBNull(FLD_TOTALNUMBEROFUNIT)) { bDProjectAdditionalInfoEntity.TotalNumberOfUnit = null; } else { bDProjectAdditionalInfoEntity.TotalNumberOfUnit = reader.GetDecimal(FLD_TOTALNUMBEROFUNIT); }
            if (reader.IsDBNull(FLD_NUMBEROFPENTHOUSE)) { bDProjectAdditionalInfoEntity.NumberOfPenthouse = null; } else { bDProjectAdditionalInfoEntity.NumberOfPenthouse = reader.GetDecimal(FLD_NUMBEROFPENTHOUSE); }
            if (reader.IsDBNull(FLD_NUMBEROFSTAIR)) { bDProjectAdditionalInfoEntity.NumberOfStair = null; } else { bDProjectAdditionalInfoEntity.NumberOfStair = reader.GetDecimal(FLD_NUMBEROFSTAIR); }
            if (reader.IsDBNull(FLD_POSITIONATBUILDING)) { bDProjectAdditionalInfoEntity.PositionAtBuilding = String.Empty; } else { bDProjectAdditionalInfoEntity.PositionAtBuilding = reader.GetString(FLD_POSITIONATBUILDING); }
            if (reader.IsDBNull(FLD_COOLINGSYSTEM)) { bDProjectAdditionalInfoEntity.CoolingSystem = String.Empty; } else { bDProjectAdditionalInfoEntity.CoolingSystem = reader.GetString(FLD_COOLINGSYSTEM); }
            if (reader.IsDBNull(FLD_GEYSERSYSTEM)) { bDProjectAdditionalInfoEntity.GeyserSystem = String.Empty; } else { bDProjectAdditionalInfoEntity.GeyserSystem = reader.GetString(FLD_GEYSERSYSTEM); }
            if (reader.IsDBNull(FLD_FACILITIESATMEZZANINEFLOOR)) { bDProjectAdditionalInfoEntity.FacilitiesAtMezzanineFloor = String.Empty; } else { bDProjectAdditionalInfoEntity.FacilitiesAtMezzanineFloor = reader.GetString(FLD_FACILITIESATMEZZANINEFLOOR); }
            if (reader.IsDBNull(FLD_FACILITIESATROOFFLOOR)) { bDProjectAdditionalInfoEntity.FacilitiesAtRoofFloor = String.Empty; } else { bDProjectAdditionalInfoEntity.FacilitiesAtRoofFloor = reader.GetString(FLD_FACILITIESATROOFFLOOR); }
            if (reader.IsDBNull(FLD_APPROVALREQUIRED)) { bDProjectAdditionalInfoEntity.ApprovalRequired = String.Empty; } else { bDProjectAdditionalInfoEntity.ApprovalRequired = reader.GetString(FLD_APPROVALREQUIRED); }
            if (reader.IsDBNull(FLD_POSITIONATBUILDINGFORCOMMERCIAL)) { bDProjectAdditionalInfoEntity.PositionAtBuildingForCommercial = String.Empty; } else { bDProjectAdditionalInfoEntity.PositionAtBuildingForCommercial = reader.GetString(FLD_POSITIONATBUILDINGFORCOMMERCIAL); }
            if (reader.IsDBNull(FLD_GROUNDFLOORHEIGHT)) { bDProjectAdditionalInfoEntity.GroundFloorHeight = null; } else { bDProjectAdditionalInfoEntity.GroundFloorHeight = reader.GetDecimal(FLD_GROUNDFLOORHEIGHT); }
            if (reader.IsDBNull(FLD_TYPICALFLOORHEIGHT)) { bDProjectAdditionalInfoEntity.TypicalFloorHeight = null; } else { bDProjectAdditionalInfoEntity.TypicalFloorHeight = reader.GetDecimal(FLD_TYPICALFLOORHEIGHT); }
            if (reader.IsDBNull(FLD_GROUNDFLOORHEIGHTUNITINFEETID)) { bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInFeetID = null; } else { bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInFeetID = reader.GetInt64(FLD_GROUNDFLOORHEIGHTUNITINFEETID); }
            if (reader.IsDBNull(FLD_TYPICALFLOORHEIGHTUNITINCHID)) { bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitInchID = null; } else { bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitInchID = reader.GetInt64(FLD_TYPICALFLOORHEIGHTUNITINCHID); }
            if (reader.IsDBNull(FLD_GROUNDFLOORHEIGHTINCH)) { bDProjectAdditionalInfoEntity.GroundFloorHeightInch = null; } else { bDProjectAdditionalInfoEntity.GroundFloorHeightInch = reader.GetDecimal(FLD_GROUNDFLOORHEIGHTINCH); }
            if (reader.IsDBNull(FLD_GROUNDFLOORHEIGHTUNITININCHID)) { bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInInchID = null; } else { bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInInchID = reader.GetInt64(FLD_GROUNDFLOORHEIGHTUNITININCHID); }
            if (reader.IsDBNull(FLD_TYPICALFLOORHEIGHTFEET)) { bDProjectAdditionalInfoEntity.TypicalFloorHeightFeet = null; } else { bDProjectAdditionalInfoEntity.TypicalFloorHeightFeet = reader.GetDecimal(FLD_TYPICALFLOORHEIGHTFEET); }
            if (reader.IsDBNull(FLD_TYPICALFLOORHEIGHTUNITFEETID)) { bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitFeetID = null; } else { bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitFeetID = reader.GetInt64(FLD_TYPICALFLOORHEIGHTUNITFEETID); }

            return bDProjectAdditionalInfoEntity;
        }
    }
}
