// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:02:34




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDFloorBuilder : IEntityBuilder<MDFloorEntity>
    {
        IList<MDFloorEntity> IEntityBuilder<MDFloorEntity>.BuildEntities(IDataReader reader)
        {
            List<MDFloorEntity> MDFloorEntityList = new List<MDFloorEntity>();

            while (reader.Read())
            {
                MDFloorEntityList.Add(((IEntityBuilder<MDFloorEntity>)this).BuildEntity(reader));
            }

            return (MDFloorEntityList.Count > 0) ? MDFloorEntityList : null;
        }

        MDFloorEntity IEntityBuilder<MDFloorEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_FLOORID = 0;
            const Int32 FLD_FLOORCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISREMOVED = 4;

            MDFloorEntity mDFloorEntity = new MDFloorEntity();

            mDFloorEntity.FloorID = reader.GetInt64(FLD_FLOORID);
            mDFloorEntity.FloorCategoryID = reader.GetInt64(FLD_FLOORCATEGORYID);
            mDFloorEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDFloorEntity.Description = String.Empty; } else { mDFloorEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDFloorEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDFloorEntity;
        }
    }
}
