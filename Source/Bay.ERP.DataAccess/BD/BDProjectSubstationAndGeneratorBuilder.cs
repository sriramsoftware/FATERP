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
    internal sealed class BDProjectSubstationAndGeneratorBuilder : IEntityBuilder<BDProjectSubstationAndGeneratorEntity>
    {
        IList<BDProjectSubstationAndGeneratorEntity> IEntityBuilder<BDProjectSubstationAndGeneratorEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectSubstationAndGeneratorEntity> BDProjectSubstationAndGeneratorEntityList = new List<BDProjectSubstationAndGeneratorEntity>();

            while (reader.Read())
            {
                BDProjectSubstationAndGeneratorEntityList.Add(((IEntityBuilder<BDProjectSubstationAndGeneratorEntity>)this).BuildEntity(reader));
            }

            return (BDProjectSubstationAndGeneratorEntityList.Count > 0) ? BDProjectSubstationAndGeneratorEntityList : null;
        }

        BDProjectSubstationAndGeneratorEntity IEntityBuilder<BDProjectSubstationAndGeneratorEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTSUBSTATIONANDGENERATORID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_CAPACITYOFSUBSTATION = 2;
            const Int32 FLD_TOTALNUMBEROFGENERATOR = 3;
            const Int32 FLD_CAPACITYOFGENERATOR1 = 4;
            const Int32 FLD_CAPACITYOFGENERATOR2 = 5;
            const Int32 FLD_CAPACITYOFGENERATOR3 = 6;
            const Int32 FLD_CAPACITYOFGENERATOR4 = 7;
            const Int32 FLD_CAPACITYOFGENERATOR5 = 8;
            const Int32 FLD_BRANDID = 9;

            BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity = new BDProjectSubstationAndGeneratorEntity();

            bDProjectSubstationAndGeneratorEntity.ProjectSubstationAndGeneratorID = reader.GetInt64(FLD_PROJECTSUBSTATIONANDGENERATORID);
            bDProjectSubstationAndGeneratorEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectSubstationAndGeneratorEntity.CapacityOfSubstation = reader.GetDecimal(FLD_CAPACITYOFSUBSTATION);
            bDProjectSubstationAndGeneratorEntity.TotalNumberOfGenerator = reader.GetDecimal(FLD_TOTALNUMBEROFGENERATOR);
            bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator1 = reader.GetDecimal(FLD_CAPACITYOFGENERATOR1);
            if (reader.IsDBNull(FLD_CAPACITYOFGENERATOR2)) { bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator2 = null; } else { bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator2 = reader.GetDecimal(FLD_CAPACITYOFGENERATOR2); }
            if (reader.IsDBNull(FLD_CAPACITYOFGENERATOR3)) { bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator3 = null; } else { bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator3 = reader.GetDecimal(FLD_CAPACITYOFGENERATOR3); }
            if (reader.IsDBNull(FLD_CAPACITYOFGENERATOR4)) { bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator4 = null; } else { bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator4 = reader.GetDecimal(FLD_CAPACITYOFGENERATOR4); }
            if (reader.IsDBNull(FLD_CAPACITYOFGENERATOR5)) { bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator5 = null; } else { bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator5 = reader.GetDecimal(FLD_CAPACITYOFGENERATOR5); }
            bDProjectSubstationAndGeneratorEntity.BrandID = reader.GetInt64(FLD_BRANDID);

            return bDProjectSubstationAndGeneratorEntity;
        }
    }
}
