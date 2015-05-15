// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 03:04:35




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDProjectFloorUnitTypeBuilder : IEntityBuilder<MDProjectFloorUnitTypeEntity>
    {
        IList<MDProjectFloorUnitTypeEntity> IEntityBuilder<MDProjectFloorUnitTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDProjectFloorUnitTypeEntity> MDProjectFloorUnitTypeEntityList = new List<MDProjectFloorUnitTypeEntity>();

            while (reader.Read())
            {
                MDProjectFloorUnitTypeEntityList.Add(((IEntityBuilder<MDProjectFloorUnitTypeEntity>)this).BuildEntity(reader));
            }

            return (MDProjectFloorUnitTypeEntityList.Count > 0) ? MDProjectFloorUnitTypeEntityList : null;
        }

        MDProjectFloorUnitTypeEntity IEntityBuilder<MDProjectFloorUnitTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTFLOORUNITTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDProjectFloorUnitTypeEntity mDProjectFloorUnitTypeEntity = new MDProjectFloorUnitTypeEntity();

            mDProjectFloorUnitTypeEntity.ProjectFloorUnitTypeID = reader.GetInt64(FLD_PROJECTFLOORUNITTYPEID);
            mDProjectFloorUnitTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDProjectFloorUnitTypeEntity.Description = String.Empty; } else { mDProjectFloorUnitTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDProjectFloorUnitTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDProjectFloorUnitTypeEntity;
        }
    }
}
