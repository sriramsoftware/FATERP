// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-May-2012, 10:39:09




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectFloor_DetailedBuilder : IEntityBuilder<BDProjectFloor_DetailedEntity>
    {
        IList<BDProjectFloor_DetailedEntity> IEntityBuilder<BDProjectFloor_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectFloor_DetailedEntity> BDProjectFloor_DetailedEntityList = new List<BDProjectFloor_DetailedEntity>();

            while (reader.Read())
            {
                BDProjectFloor_DetailedEntityList.Add(((IEntityBuilder<BDProjectFloor_DetailedEntity>)this).BuildEntity(reader));
            }

            return (BDProjectFloor_DetailedEntityList.Count > 0) ? BDProjectFloor_DetailedEntityList : null;
        }

        BDProjectFloor_DetailedEntity IEntityBuilder<BDProjectFloor_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTFLOORID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_FLOORCATEGORYID = 2;
            const Int32 FLD_FLOORID = 3;
            const Int32 FLD_NAME = 4;
            const Int32 FLD_SIZE = 5;
            const Int32 FLD_DESCRIPTION = 6;
            const Int32 FLD_ISREMOVED = 7;
            const Int32 FLD_PROJECTNAME = 8;
            const Int32 FLD_FLOORCATEGORYNAME = 9;
            const Int32 FLD_FLOORNAME = 10;
            const Int32 FLD_ROWNUMBER = 11;

            BDProjectFloor_DetailedEntity bDProjectFloor_DetailedEntity = new BDProjectFloor_DetailedEntity();

            bDProjectFloor_DetailedEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            bDProjectFloor_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectFloor_DetailedEntity.FloorCategoryID = reader.GetInt64(FLD_FLOORCATEGORYID);
            bDProjectFloor_DetailedEntity.FloorID = reader.GetInt64(FLD_FLOORID);
            if (reader.IsDBNull(FLD_NAME)) { bDProjectFloor_DetailedEntity.Name = String.Empty; } else { bDProjectFloor_DetailedEntity.Name = reader.GetString(FLD_NAME); }
            bDProjectFloor_DetailedEntity.Size = reader.GetInt32(FLD_SIZE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDProjectFloor_DetailedEntity.Description = String.Empty; } else { bDProjectFloor_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            bDProjectFloor_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_PROJECTNAME)) { bDProjectFloor_DetailedEntity.ProjectName = String.Empty; } else { bDProjectFloor_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_FLOORCATEGORYNAME)) { bDProjectFloor_DetailedEntity.FloorCategoryName = String.Empty; } else { bDProjectFloor_DetailedEntity.FloorCategoryName = reader.GetString(FLD_FLOORCATEGORYNAME); }
            if (reader.IsDBNull(FLD_FLOORNAME)) { bDProjectFloor_DetailedEntity.FloorName = String.Empty; } else { bDProjectFloor_DetailedEntity.FloorName = reader.GetString(FLD_FLOORNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { bDProjectFloor_DetailedEntity.RowNumber = null; } else { bDProjectFloor_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return bDProjectFloor_DetailedEntity;
        }
    }
}
