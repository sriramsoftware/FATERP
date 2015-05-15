// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2012, 10:26:53




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDFloor_DetailedBuilder : IEntityBuilder<MDFloor_DetailedEntity>
    {
        IList<MDFloor_DetailedEntity> IEntityBuilder<MDFloor_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<MDFloor_DetailedEntity> MDFloor_DetailedEntityList = new List<MDFloor_DetailedEntity>();

            while (reader.Read())
            {
                MDFloor_DetailedEntityList.Add(((IEntityBuilder<MDFloor_DetailedEntity>)this).BuildEntity(reader));
            }

            return (MDFloor_DetailedEntityList.Count > 0) ? MDFloor_DetailedEntityList : null;
        }

        MDFloor_DetailedEntity IEntityBuilder<MDFloor_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_FLOORID = 0;
            const Int32 FLD_FLOORCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISREMOVED = 4;
            const Int32 FLD_FLOORCATEGORYNAME = 5;
            const Int32 FLD_ROWNUMBER = 6;

            MDFloor_DetailedEntity mDFloor_DetailedEntity = new MDFloor_DetailedEntity();

            mDFloor_DetailedEntity.FloorID = reader.GetInt64(FLD_FLOORID);
            mDFloor_DetailedEntity.FloorCategoryID = reader.GetInt64(FLD_FLOORCATEGORYID);
            mDFloor_DetailedEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDFloor_DetailedEntity.Description = String.Empty; } else { mDFloor_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDFloor_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_FLOORCATEGORYNAME)) { mDFloor_DetailedEntity.FloorCategoryName = String.Empty; } else { mDFloor_DetailedEntity.FloorCategoryName = reader.GetString(FLD_FLOORCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { mDFloor_DetailedEntity.RowNumber = null; } else { mDFloor_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return mDFloor_DetailedEntity;
        }
    }
}
