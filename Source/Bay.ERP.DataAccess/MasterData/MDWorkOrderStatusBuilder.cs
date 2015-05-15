// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDWorkOrderStatusBuilder : IEntityBuilder<MDWorkOrderStatusEntity>
    {
        IList<MDWorkOrderStatusEntity> IEntityBuilder<MDWorkOrderStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDWorkOrderStatusEntity> MDWorkOrderStatusEntityList = new List<MDWorkOrderStatusEntity>();

            while (reader.Read())
            {
                MDWorkOrderStatusEntityList.Add(((IEntityBuilder<MDWorkOrderStatusEntity>)this).BuildEntity(reader));
            }

            return (MDWorkOrderStatusEntityList.Count > 0) ? MDWorkOrderStatusEntityList : null;
        }

        MDWorkOrderStatusEntity IEntityBuilder<MDWorkOrderStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDWorkOrderStatusEntity mDWorkOrderStatusEntity = new MDWorkOrderStatusEntity();

            mDWorkOrderStatusEntity.WorkOrderStatusID = reader.GetInt64(FLD_WORKORDERSTATUSID);
            mDWorkOrderStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDWorkOrderStatusEntity.Description = String.Empty; } else { mDWorkOrderStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDWorkOrderStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDWorkOrderStatusEntity;
        }
    }
}
