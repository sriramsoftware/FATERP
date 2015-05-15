// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 04:56:23




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectStatusWiseFloorUnit_RPTBuilder : IEntityBuilder<BDProjectStatusWiseFloorUnit_RPTEntity>
    {
        IList<BDProjectStatusWiseFloorUnit_RPTEntity> IEntityBuilder<BDProjectStatusWiseFloorUnit_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectStatusWiseFloorUnit_RPTEntity> BDProjectStatusWiseFloorUnit_RPTEntityList = new List<BDProjectStatusWiseFloorUnit_RPTEntity>();

            while (reader.Read())
            {
                BDProjectStatusWiseFloorUnit_RPTEntityList.Add(((IEntityBuilder<BDProjectStatusWiseFloorUnit_RPTEntity>)this).BuildEntity(reader));
            }

            return (BDProjectStatusWiseFloorUnit_RPTEntityList.Count > 0) ? BDProjectStatusWiseFloorUnit_RPTEntityList : null;
        }

        BDProjectStatusWiseFloorUnit_RPTEntity IEntityBuilder<BDProjectStatusWiseFloorUnit_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTFLOORUNITNAME = 0;
            const Int32 FLD_UNITAREA = 1;
            const Int32 FLD_TOTALAREA = 2;
            const Int32 FLD_FACING = 3;
            const Int32 FLD_TOILET = 4;
            const Int32 FLD_KITCHEN = 5;
            const Int32 FLD_PARKING = 6;
            const Int32 FLD_BATHROOM = 7;
            const Int32 FLD_BEDROOM = 8;
            const Int32 FLD_ISIDSERVICEAVAILABLE = 9;
            const Int32 FLD_ELECTRICITYSERVICE = 10;
            const Int32 FLD_COMMONGENERATOR = 11;
            const Int32 FLD_PRICEPERSFT = 12;
            const Int32 FLD_AREAPRICE = 13;
            const Int32 FLD_IDPRICE = 14;
            const Int32 FLD_ADDITIONALCHARGES = 15;
            const Int32 FLD_FEATURES = 16;
            const Int32 FLD_FLOORNAME = 17;
            const Int32 FLD_PROJECTCODE = 18;
            const Int32 FLD_PROJECTNAME = 19;
            const Int32 FLD_PROJECTID = 20;
            const Int32 FLD_PROJECTFLOORUNITSTATUSID = 21;
            const Int32 FLD_NAME = 22;

            BDProjectStatusWiseFloorUnit_RPTEntity bDProjectStatusWiseFloorUnit_RPTEntity = new BDProjectStatusWiseFloorUnit_RPTEntity();

            bDProjectStatusWiseFloorUnit_RPTEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME);
            bDProjectStatusWiseFloorUnit_RPTEntity.UnitArea = reader.GetDecimal(FLD_UNITAREA);
            bDProjectStatusWiseFloorUnit_RPTEntity.TotalArea = reader.GetDecimal(FLD_TOTALAREA);
            bDProjectStatusWiseFloorUnit_RPTEntity.Facing = reader.GetString(FLD_FACING);
            bDProjectStatusWiseFloorUnit_RPTEntity.Toilet = reader.GetDecimal(FLD_TOILET);
            bDProjectStatusWiseFloorUnit_RPTEntity.Kitchen = reader.GetDecimal(FLD_KITCHEN);
            bDProjectStatusWiseFloorUnit_RPTEntity.Parking = reader.GetDecimal(FLD_PARKING);
            bDProjectStatusWiseFloorUnit_RPTEntity.BathRoom = reader.GetDecimal(FLD_BATHROOM);
            bDProjectStatusWiseFloorUnit_RPTEntity.BedRoom = reader.GetDecimal(FLD_BEDROOM);
            bDProjectStatusWiseFloorUnit_RPTEntity.IsIDServiceAvailable = reader.GetBoolean(FLD_ISIDSERVICEAVAILABLE);
            bDProjectStatusWiseFloorUnit_RPTEntity.ElectricityService = reader.GetBoolean(FLD_ELECTRICITYSERVICE);
            bDProjectStatusWiseFloorUnit_RPTEntity.CommonGenerator = reader.GetBoolean(FLD_COMMONGENERATOR);
            if (reader.IsDBNull(FLD_PRICEPERSFT)) { bDProjectStatusWiseFloorUnit_RPTEntity.PricePerSft = null; } else { bDProjectStatusWiseFloorUnit_RPTEntity.PricePerSft = reader.GetDecimal(FLD_PRICEPERSFT); }
            if (reader.IsDBNull(FLD_AREAPRICE)) { bDProjectStatusWiseFloorUnit_RPTEntity.AreaPrice = null; } else { bDProjectStatusWiseFloorUnit_RPTEntity.AreaPrice = reader.GetDecimal(FLD_AREAPRICE); }
            if (reader.IsDBNull(FLD_IDPRICE)) { bDProjectStatusWiseFloorUnit_RPTEntity.IDPrice = null; } else { bDProjectStatusWiseFloorUnit_RPTEntity.IDPrice = reader.GetDecimal(FLD_IDPRICE); }
            if (reader.IsDBNull(FLD_ADDITIONALCHARGES)) { bDProjectStatusWiseFloorUnit_RPTEntity.AdditionalCharges = null; } else { bDProjectStatusWiseFloorUnit_RPTEntity.AdditionalCharges = reader.GetDecimal(FLD_ADDITIONALCHARGES); }
            if (reader.IsDBNull(FLD_FEATURES)) { bDProjectStatusWiseFloorUnit_RPTEntity.Features = String.Empty; } else { bDProjectStatusWiseFloorUnit_RPTEntity.Features = reader.GetString(FLD_FEATURES); }
            if (reader.IsDBNull(FLD_FLOORNAME)) { bDProjectStatusWiseFloorUnit_RPTEntity.FloorName = String.Empty; } else { bDProjectStatusWiseFloorUnit_RPTEntity.FloorName = reader.GetString(FLD_FLOORNAME); }
            bDProjectStatusWiseFloorUnit_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            bDProjectStatusWiseFloorUnit_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            bDProjectStatusWiseFloorUnit_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectStatusWiseFloorUnit_RPTEntity.ProjectFloorUnitStatusID = reader.GetInt64(FLD_PROJECTFLOORUNITSTATUSID);
            bDProjectStatusWiseFloorUnit_RPTEntity.Name = reader.GetString(FLD_NAME);

            return bDProjectStatusWiseFloorUnit_RPTEntity;
        }
    }
}
