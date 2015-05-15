// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jul-2013, 10:18:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ActivityLogBuilder : IEntityBuilder<ActivityLogEntity>
    {
        IList<ActivityLogEntity> IEntityBuilder<ActivityLogEntity>.BuildEntities(IDataReader reader)
        {
            List<ActivityLogEntity> ActivityLogEntityList = new List<ActivityLogEntity>();

            while (reader.Read())
            {
                ActivityLogEntityList.Add(((IEntityBuilder<ActivityLogEntity>)this).BuildEntity(reader));
            }

            return (ActivityLogEntityList.Count > 0) ? ActivityLogEntityList : null;
        }

        ActivityLogEntity IEntityBuilder<ActivityLogEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACTIVITYLOGID = 0;
            const Int32 FLD_USERID = 1;
            const Int32 FLD_ACTIVITY = 2;
            const Int32 FLD_PAGEURL = 3;
            const Int32 FLD_ACTIVITYDATE = 4;

            ActivityLogEntity activityLogEntity = new ActivityLogEntity();

            activityLogEntity.ActivityLogID = reader.GetInt64(FLD_ACTIVITYLOGID);
            activityLogEntity.UserId = reader.GetGuid(FLD_USERID);
            activityLogEntity.Activity = reader.GetString(FLD_ACTIVITY);
            if (reader.IsDBNull(FLD_PAGEURL)) { activityLogEntity.PageUrl = String.Empty; } else { activityLogEntity.PageUrl = reader.GetString(FLD_PAGEURL); }
            if (reader.IsDBNull(FLD_ACTIVITYDATE)) { activityLogEntity.ActivityDate = null; } else { activityLogEntity.ActivityDate = reader.GetDateTime(FLD_ACTIVITYDATE); }

            return activityLogEntity;
        }
    }
}
