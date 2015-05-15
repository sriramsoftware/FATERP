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
    internal sealed class BDProjectFloorBuilder : IEntityBuilder<BDProjectFloorEntity>
    {
        IList<BDProjectFloorEntity> IEntityBuilder<BDProjectFloorEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectFloorEntity> BDProjectFloorEntityList = new List<BDProjectFloorEntity>();

            while (reader.Read())
            {
                BDProjectFloorEntityList.Add(((IEntityBuilder<BDProjectFloorEntity>)this).BuildEntity(reader));
            }

            return (BDProjectFloorEntityList.Count > 0) ? BDProjectFloorEntityList : null;
        }

        BDProjectFloorEntity IEntityBuilder<BDProjectFloorEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTFLOORID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_FLOORCATEGORYID = 2;
            const Int32 FLD_FLOORID = 3;
            const Int32 FLD_NAME = 4;
            const Int32 FLD_SIZE = 5;
            const Int32 FLD_DESCRIPTION = 6;
            const Int32 FLD_ISREMOVED = 7;

            BDProjectFloorEntity bDProjectFloorEntity = new BDProjectFloorEntity();

            bDProjectFloorEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID);
            bDProjectFloorEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectFloorEntity.FloorCategoryID = reader.GetInt64(FLD_FLOORCATEGORYID);
            bDProjectFloorEntity.FloorID = reader.GetInt64(FLD_FLOORID);
            if (reader.IsDBNull(FLD_NAME)) { bDProjectFloorEntity.Name = String.Empty; } else { bDProjectFloorEntity.Name = reader.GetString(FLD_NAME); }
            bDProjectFloorEntity.Size = reader.GetInt32(FLD_SIZE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDProjectFloorEntity.Description = String.Empty; } else { bDProjectFloorEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            bDProjectFloorEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return bDProjectFloorEntity;
        }
    }
}
