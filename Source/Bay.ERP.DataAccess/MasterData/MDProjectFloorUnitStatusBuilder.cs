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
    internal sealed class MDProjectFloorUnitStatusBuilder : IEntityBuilder<MDProjectFloorUnitStatusEntity>
    {
        IList<MDProjectFloorUnitStatusEntity> IEntityBuilder<MDProjectFloorUnitStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDProjectFloorUnitStatusEntity> MDProjectFloorUnitStatusEntityList = new List<MDProjectFloorUnitStatusEntity>();

            while (reader.Read())
            {
                MDProjectFloorUnitStatusEntityList.Add(((IEntityBuilder<MDProjectFloorUnitStatusEntity>)this).BuildEntity(reader));
            }

            return (MDProjectFloorUnitStatusEntityList.Count > 0) ? MDProjectFloorUnitStatusEntityList : null;
        }

        MDProjectFloorUnitStatusEntity IEntityBuilder<MDProjectFloorUnitStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTFLOORUNITSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDProjectFloorUnitStatusEntity mDProjectFloorUnitStatusEntity = new MDProjectFloorUnitStatusEntity();

            mDProjectFloorUnitStatusEntity.ProjectFloorUnitStatusID = reader.GetInt64(FLD_PROJECTFLOORUNITSTATUSID);
            mDProjectFloorUnitStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDProjectFloorUnitStatusEntity.Description = String.Empty; } else { mDProjectFloorUnitStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDProjectFloorUnitStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDProjectFloorUnitStatusEntity;
        }
    }
}
