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
    internal sealed class MDScheduleIdentityCategoryBuilder : IEntityBuilder<MDScheduleIdentityCategoryEntity>
    {
        IList<MDScheduleIdentityCategoryEntity> IEntityBuilder<MDScheduleIdentityCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDScheduleIdentityCategoryEntity> MDScheduleIdentityCategoryEntityList = new List<MDScheduleIdentityCategoryEntity>();

            while (reader.Read())
            {
                MDScheduleIdentityCategoryEntityList.Add(((IEntityBuilder<MDScheduleIdentityCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDScheduleIdentityCategoryEntityList.Count > 0) ? MDScheduleIdentityCategoryEntityList : null;
        }

        MDScheduleIdentityCategoryEntity IEntityBuilder<MDScheduleIdentityCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SCHEDULEIDENTITYCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDScheduleIdentityCategoryEntity mDScheduleIdentityCategoryEntity = new MDScheduleIdentityCategoryEntity();

            mDScheduleIdentityCategoryEntity.ScheduleIdentityCategoryID = reader.GetInt64(FLD_SCHEDULEIDENTITYCATEGORYID);
            mDScheduleIdentityCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDScheduleIdentityCategoryEntity.Description = String.Empty; } else { mDScheduleIdentityCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDScheduleIdentityCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDScheduleIdentityCategoryEntity;
        }
    }
}
