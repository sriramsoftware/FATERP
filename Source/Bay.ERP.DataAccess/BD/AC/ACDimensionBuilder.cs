// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACDimensionBuilder : IEntityBuilder<ACDimensionEntity>
    {
        IList<ACDimensionEntity> IEntityBuilder<ACDimensionEntity>.BuildEntities(IDataReader reader)
        {
            List<ACDimensionEntity> ACDimensionEntityList = new List<ACDimensionEntity>();

            while (reader.Read())
            {
                ACDimensionEntityList.Add(((IEntityBuilder<ACDimensionEntity>)this).BuildEntity(reader));
            }

            return (ACDimensionEntityList.Count > 0) ? ACDimensionEntityList : null;
        }

        ACDimensionEntity IEntityBuilder<ACDimensionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DIMENSIONID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISINACTIVE = 3;

            ACDimensionEntity aCDimensionEntity = new ACDimensionEntity();

            aCDimensionEntity.DimensionID = reader.GetInt64(FLD_DIMENSIONID);
            aCDimensionEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCDimensionEntity.Description = String.Empty; } else { aCDimensionEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCDimensionEntity.IsInActive = reader.GetBoolean(FLD_ISINACTIVE);

            return aCDimensionEntity;
        }
    }
}
