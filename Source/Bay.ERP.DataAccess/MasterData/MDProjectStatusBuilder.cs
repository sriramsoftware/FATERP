// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDProjectStatusBuilder : IEntityBuilder<MDProjectStatusEntity>
    {
        IList<MDProjectStatusEntity> IEntityBuilder<MDProjectStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDProjectStatusEntity> MDProjectStatusEntityList = new List<MDProjectStatusEntity>();

            while (reader.Read())
            {
                MDProjectStatusEntityList.Add(((IEntityBuilder<MDProjectStatusEntity>)this).BuildEntity(reader));
            }

            return (MDProjectStatusEntityList.Count > 0) ? MDProjectStatusEntityList : null;
        }

        MDProjectStatusEntity IEntityBuilder<MDProjectStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDProjectStatusEntity mDProjectStatusEntity = new MDProjectStatusEntity();

            mDProjectStatusEntity.ProjectStatusID = reader.GetInt64(FLD_PROJECTSTATUSID);
            mDProjectStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDProjectStatusEntity.Description = String.Empty; } else { mDProjectStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDProjectStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDProjectStatusEntity;
        }
    }
}
