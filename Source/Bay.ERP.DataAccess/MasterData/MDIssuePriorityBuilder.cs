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
    internal sealed class MDIssuePriorityBuilder : IEntityBuilder<MDIssuePriorityEntity>
    {
        IList<MDIssuePriorityEntity> IEntityBuilder<MDIssuePriorityEntity>.BuildEntities(IDataReader reader)
        {
            List<MDIssuePriorityEntity> MDIssuePriorityEntityList = new List<MDIssuePriorityEntity>();

            while (reader.Read())
            {
                MDIssuePriorityEntityList.Add(((IEntityBuilder<MDIssuePriorityEntity>)this).BuildEntity(reader));
            }

            return (MDIssuePriorityEntityList.Count > 0) ? MDIssuePriorityEntityList : null;
        }

        MDIssuePriorityEntity IEntityBuilder<MDIssuePriorityEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUEPRIORITYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDIssuePriorityEntity mDIssuePriorityEntity = new MDIssuePriorityEntity();

            mDIssuePriorityEntity.IssuePriorityID = reader.GetInt64(FLD_ISSUEPRIORITYID);
            mDIssuePriorityEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDIssuePriorityEntity.Description = String.Empty; } else { mDIssuePriorityEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDIssuePriorityEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDIssuePriorityEntity;
        }
    }
}
