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
    internal sealed class MDScheduleCategoryBuilder : IEntityBuilder<MDScheduleCategoryEntity>
    {
        IList<MDScheduleCategoryEntity> IEntityBuilder<MDScheduleCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDScheduleCategoryEntity> MDScheduleCategoryEntityList = new List<MDScheduleCategoryEntity>();

            while (reader.Read())
            {
                MDScheduleCategoryEntityList.Add(((IEntityBuilder<MDScheduleCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDScheduleCategoryEntityList.Count > 0) ? MDScheduleCategoryEntityList : null;
        }

        MDScheduleCategoryEntity IEntityBuilder<MDScheduleCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SCHEDULECATEGORYID = 0;
            const Int32 FLD_SCHEDULEIDENTITYCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISREMOVED = 4;

            MDScheduleCategoryEntity mDScheduleCategoryEntity = new MDScheduleCategoryEntity();

            mDScheduleCategoryEntity.ScheduleCategoryID = reader.GetInt64(FLD_SCHEDULECATEGORYID);
            mDScheduleCategoryEntity.ScheduleIdentityCategoryID = reader.GetInt64(FLD_SCHEDULEIDENTITYCATEGORYID);
            mDScheduleCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDScheduleCategoryEntity.Description = String.Empty; } else { mDScheduleCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDScheduleCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDScheduleCategoryEntity;
        }
    }
}
