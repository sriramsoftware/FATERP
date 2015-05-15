// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDConstructionToolCategoryBuilder : IEntityBuilder<MDConstructionToolCategoryEntity>
    {
        IList<MDConstructionToolCategoryEntity> IEntityBuilder<MDConstructionToolCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDConstructionToolCategoryEntity> MDConstructionToolCategoryEntityList = new List<MDConstructionToolCategoryEntity>();

            while (reader.Read())
            {
                MDConstructionToolCategoryEntityList.Add(((IEntityBuilder<MDConstructionToolCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDConstructionToolCategoryEntityList.Count > 0) ? MDConstructionToolCategoryEntityList : null;
        }

        MDConstructionToolCategoryEntity IEntityBuilder<MDConstructionToolCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSTRUCTIONTOOLCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDConstructionToolCategoryEntity mDConstructionToolCategoryEntity = new MDConstructionToolCategoryEntity();

            mDConstructionToolCategoryEntity.ConstructionToolCategoryID = reader.GetInt64(FLD_CONSTRUCTIONTOOLCATEGORYID);
            mDConstructionToolCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDConstructionToolCategoryEntity.Description = String.Empty; } else { mDConstructionToolCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDConstructionToolCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDConstructionToolCategoryEntity;
        }
    }
}
