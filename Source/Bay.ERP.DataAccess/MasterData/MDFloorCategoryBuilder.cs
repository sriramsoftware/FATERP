// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 02:43:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDFloorCategoryBuilder : IEntityBuilder<MDFloorCategoryEntity>
    {
        IList<MDFloorCategoryEntity> IEntityBuilder<MDFloorCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDFloorCategoryEntity> MDFloorCategoryEntityList = new List<MDFloorCategoryEntity>();

            while (reader.Read())
            {
                MDFloorCategoryEntityList.Add(((IEntityBuilder<MDFloorCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDFloorCategoryEntityList.Count > 0) ? MDFloorCategoryEntityList : null;
        }

        MDFloorCategoryEntity IEntityBuilder<MDFloorCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_FLOORCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDFloorCategoryEntity mDFloorCategoryEntity = new MDFloorCategoryEntity();

            mDFloorCategoryEntity.FloorCategoryID = reader.GetInt64(FLD_FLOORCATEGORYID);
            mDFloorCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDFloorCategoryEntity.Description = String.Empty; } else { mDFloorCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDFloorCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDFloorCategoryEntity;
        }
    }
}
