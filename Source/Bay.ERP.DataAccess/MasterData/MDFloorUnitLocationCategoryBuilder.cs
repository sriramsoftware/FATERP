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
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDFloorUnitLocationCategoryBuilder : IEntityBuilder<MDFloorUnitLocationCategoryEntity>
    {
        IList<MDFloorUnitLocationCategoryEntity> IEntityBuilder<MDFloorUnitLocationCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDFloorUnitLocationCategoryEntity> MDFloorUnitLocationCategoryEntityList = new List<MDFloorUnitLocationCategoryEntity>();

            while (reader.Read())
            {
                MDFloorUnitLocationCategoryEntityList.Add(((IEntityBuilder<MDFloorUnitLocationCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDFloorUnitLocationCategoryEntityList.Count > 0) ? MDFloorUnitLocationCategoryEntityList : null;
        }

        MDFloorUnitLocationCategoryEntity IEntityBuilder<MDFloorUnitLocationCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_FLOORUNITLOCATIONCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity = new MDFloorUnitLocationCategoryEntity();

            mDFloorUnitLocationCategoryEntity.FloorUnitLocationCategoryID = reader.GetInt64(FLD_FLOORUNITLOCATIONCATEGORYID);
            mDFloorUnitLocationCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDFloorUnitLocationCategoryEntity.Description = String.Empty; } else { mDFloorUnitLocationCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDFloorUnitLocationCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDFloorUnitLocationCategoryEntity;
        }
    }
}
