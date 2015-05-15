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
    internal sealed class MDProjectScheduleItemBuilder : IEntityBuilder<MDProjectScheduleItemEntity>
    {
        IList<MDProjectScheduleItemEntity> IEntityBuilder<MDProjectScheduleItemEntity>.BuildEntities(IDataReader reader)
        {
            List<MDProjectScheduleItemEntity> MDProjectScheduleItemEntityList = new List<MDProjectScheduleItemEntity>();

            while (reader.Read())
            {
                MDProjectScheduleItemEntityList.Add(((IEntityBuilder<MDProjectScheduleItemEntity>)this).BuildEntity(reader));
            }

            return (MDProjectScheduleItemEntityList.Count > 0) ? MDProjectScheduleItemEntityList : null;
        }

        MDProjectScheduleItemEntity IEntityBuilder<MDProjectScheduleItemEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTSCHEDULEITEMID = 0;
            const Int32 FLD_PARENTPROJECTSCHEDULEITEMID = 1;
            const Int32 FLD_TITLE = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISSUEPRIORITYID = 4;
            const Int32 FLD_DURATION = 5;
            const Int32 FLD_NOTIFYBEFOREMIN = 6;
            const Int32 FLD_ISREMOVED = 7;

            MDProjectScheduleItemEntity mDProjectScheduleItemEntity = new MDProjectScheduleItemEntity();

            mDProjectScheduleItemEntity.ProjectScheduleItemID = reader.GetInt64(FLD_PROJECTSCHEDULEITEMID);
            if (reader.IsDBNull(FLD_PARENTPROJECTSCHEDULEITEMID)) { mDProjectScheduleItemEntity.ParentProjectScheduleItemID = null; } else { mDProjectScheduleItemEntity.ParentProjectScheduleItemID = reader.GetInt64(FLD_PARENTPROJECTSCHEDULEITEMID); }
            mDProjectScheduleItemEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDProjectScheduleItemEntity.Description = String.Empty; } else { mDProjectScheduleItemEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDProjectScheduleItemEntity.IssuePriorityID = reader.GetInt64(FLD_ISSUEPRIORITYID);
            if (reader.IsDBNull(FLD_DURATION)) { mDProjectScheduleItemEntity.Duration = null; } else { mDProjectScheduleItemEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { mDProjectScheduleItemEntity.NotifyBeforeMin = null; } else { mDProjectScheduleItemEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            mDProjectScheduleItemEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDProjectScheduleItemEntity;
        }
    }
}
