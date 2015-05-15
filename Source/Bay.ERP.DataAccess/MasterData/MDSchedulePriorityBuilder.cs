// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDSchedulePriorityBuilder : IEntityBuilder<MDSchedulePriorityEntity>
    {
        IList<MDSchedulePriorityEntity> IEntityBuilder<MDSchedulePriorityEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSchedulePriorityEntity> MDSchedulePriorityEntityList = new List<MDSchedulePriorityEntity>();

            while (reader.Read())
            {
                MDSchedulePriorityEntityList.Add(((IEntityBuilder<MDSchedulePriorityEntity>)this).BuildEntity(reader));
            }

            return (MDSchedulePriorityEntityList.Count > 0) ? MDSchedulePriorityEntityList : null;
        }

        MDSchedulePriorityEntity IEntityBuilder<MDSchedulePriorityEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SCHEDULEPRIORITYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDSchedulePriorityEntity mDSchedulePriorityEntity = new MDSchedulePriorityEntity();

            mDSchedulePriorityEntity.SchedulePriorityID = reader.GetInt64(FLD_SCHEDULEPRIORITYID);
            mDSchedulePriorityEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDSchedulePriorityEntity.Description = String.Empty; } else { mDSchedulePriorityEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDSchedulePriorityEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSchedulePriorityEntity;
        }
    }
}
