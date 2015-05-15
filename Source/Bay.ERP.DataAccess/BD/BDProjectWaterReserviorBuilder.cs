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
    internal sealed class BDProjectWaterReserviorBuilder : IEntityBuilder<BDProjectWaterReserviorEntity>
    {
        IList<BDProjectWaterReserviorEntity> IEntityBuilder<BDProjectWaterReserviorEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectWaterReserviorEntity> BDProjectWaterReserviorEntityList = new List<BDProjectWaterReserviorEntity>();

            while (reader.Read())
            {
                BDProjectWaterReserviorEntityList.Add(((IEntityBuilder<BDProjectWaterReserviorEntity>)this).BuildEntity(reader));
            }

            return (BDProjectWaterReserviorEntityList.Count > 0) ? BDProjectWaterReserviorEntityList : null;
        }

        BDProjectWaterReserviorEntity IEntityBuilder<BDProjectWaterReserviorEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTWATERRESERVIORID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_CAPACITYOFUNDERGROUNDRESERVIOR = 2;
            const Int32 FLD_UNDERGROUNDRESERVIORUNITID = 3;
            const Int32 FLD_CAPACITYOFOVERHEADRESERVIOR = 4;
            const Int32 FLD_OVERHEADRESERVIORUNITID = 5;

            BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity = new BDProjectWaterReserviorEntity();

            bDProjectWaterReserviorEntity.ProjectWaterReserviorID = reader.GetInt64(FLD_PROJECTWATERRESERVIORID);
            bDProjectWaterReserviorEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            if (reader.IsDBNull(FLD_CAPACITYOFUNDERGROUNDRESERVIOR)) { bDProjectWaterReserviorEntity.CapacityOfUndergroundReservior = null; } else { bDProjectWaterReserviorEntity.CapacityOfUndergroundReservior = reader.GetDecimal(FLD_CAPACITYOFUNDERGROUNDRESERVIOR); }
            if (reader.IsDBNull(FLD_UNDERGROUNDRESERVIORUNITID)) { bDProjectWaterReserviorEntity.UndergroundReserviorUnitID = null; } else { bDProjectWaterReserviorEntity.UndergroundReserviorUnitID = reader.GetInt64(FLD_UNDERGROUNDRESERVIORUNITID); }
            if (reader.IsDBNull(FLD_CAPACITYOFOVERHEADRESERVIOR)) { bDProjectWaterReserviorEntity.CapacityOfOverheadReservior = null; } else { bDProjectWaterReserviorEntity.CapacityOfOverheadReservior = reader.GetDecimal(FLD_CAPACITYOFOVERHEADRESERVIOR); }
            if (reader.IsDBNull(FLD_OVERHEADRESERVIORUNITID)) { bDProjectWaterReserviorEntity.OverheadReserviorUnitID = null; } else { bDProjectWaterReserviorEntity.OverheadReserviorUnitID = reader.GetInt64(FLD_OVERHEADRESERVIORUNITID); }

            return bDProjectWaterReserviorEntity;
        }
    }
}
