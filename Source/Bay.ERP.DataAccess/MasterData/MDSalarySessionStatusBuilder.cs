// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDSalarySessionStatusBuilder : IEntityBuilder<MDSalarySessionStatusEntity>
    {
        IList<MDSalarySessionStatusEntity> IEntityBuilder<MDSalarySessionStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSalarySessionStatusEntity> MDSalarySessionStatusEntityList = new List<MDSalarySessionStatusEntity>();

            while (reader.Read())
            {
                MDSalarySessionStatusEntityList.Add(((IEntityBuilder<MDSalarySessionStatusEntity>)this).BuildEntity(reader));
            }

            return (MDSalarySessionStatusEntityList.Count > 0) ? MDSalarySessionStatusEntityList : null;
        }

        MDSalarySessionStatusEntity IEntityBuilder<MDSalarySessionStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SALARYSESSIONSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDSalarySessionStatusEntity mDSalarySessionStatusEntity = new MDSalarySessionStatusEntity();

            mDSalarySessionStatusEntity.SalarySessionStatusID = reader.GetInt64(FLD_SALARYSESSIONSTATUSID);
            mDSalarySessionStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDSalarySessionStatusEntity.Description = String.Empty; } else { mDSalarySessionStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDSalarySessionStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSalarySessionStatusEntity;
        }
    }
}
