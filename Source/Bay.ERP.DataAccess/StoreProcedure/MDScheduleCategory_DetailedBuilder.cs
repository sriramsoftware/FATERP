// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2011, 05:48:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDScheduleCategory_DetailedBuilder : IEntityBuilder<MDScheduleCategory_DetailedEntity>
    {
        IList<MDScheduleCategory_DetailedEntity> IEntityBuilder<MDScheduleCategory_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<MDScheduleCategory_DetailedEntity> MDScheduleCategory_DetailedEntityList = new List<MDScheduleCategory_DetailedEntity>();

            while (reader.Read())
            {
                MDScheduleCategory_DetailedEntityList.Add(((IEntityBuilder<MDScheduleCategory_DetailedEntity>)this).BuildEntity(reader));
            }

            return (MDScheduleCategory_DetailedEntityList.Count > 0) ? MDScheduleCategory_DetailedEntityList : null;
        }

        MDScheduleCategory_DetailedEntity IEntityBuilder<MDScheduleCategory_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SCHEDULECATEGORYID = 0;
            const Int32 FLD_SCHEDULEIDENTITYCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISREMOVED = 4;
            const Int32 FLD_SCHEDULEIDENTITYCATEGORYNAME = 5;
            const Int32 FLD_ROWNUMBER = 6;

            MDScheduleCategory_DetailedEntity mDScheduleCategory_DetailedEntity = new MDScheduleCategory_DetailedEntity();

            mDScheduleCategory_DetailedEntity.ScheduleCategoryID = reader.GetInt64(FLD_SCHEDULECATEGORYID);
            mDScheduleCategory_DetailedEntity.ScheduleIdentityCategoryID = reader.GetInt64(FLD_SCHEDULEIDENTITYCATEGORYID);
            mDScheduleCategory_DetailedEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDScheduleCategory_DetailedEntity.Description = String.Empty; } else { mDScheduleCategory_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDScheduleCategory_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_SCHEDULEIDENTITYCATEGORYNAME)) { mDScheduleCategory_DetailedEntity.ScheduleIdentityCategoryName = String.Empty; } else { mDScheduleCategory_DetailedEntity.ScheduleIdentityCategoryName = reader.GetString(FLD_SCHEDULEIDENTITYCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { mDScheduleCategory_DetailedEntity.RowNumber = null; } else { mDScheduleCategory_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return mDScheduleCategory_DetailedEntity;
        }
    }
}
