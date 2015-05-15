// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2013, 03:21:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDEvaluationSessionStatusBuilder : IEntityBuilder<MDEvaluationSessionStatusEntity>
    {
        IList<MDEvaluationSessionStatusEntity> IEntityBuilder<MDEvaluationSessionStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEvaluationSessionStatusEntity> MDEvaluationSessionStatusEntityList = new List<MDEvaluationSessionStatusEntity>();

            while (reader.Read())
            {
                MDEvaluationSessionStatusEntityList.Add(((IEntityBuilder<MDEvaluationSessionStatusEntity>)this).BuildEntity(reader));
            }

            return (MDEvaluationSessionStatusEntityList.Count > 0) ? MDEvaluationSessionStatusEntityList : null;
        }

        MDEvaluationSessionStatusEntity IEntityBuilder<MDEvaluationSessionStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EVALUATIONSESSIONSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDEvaluationSessionStatusEntity mDEvaluationSessionStatusEntity = new MDEvaluationSessionStatusEntity();

            mDEvaluationSessionStatusEntity.EvaluationSessionStatusID = reader.GetInt64(FLD_EVALUATIONSESSIONSTATUSID);
            mDEvaluationSessionStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEvaluationSessionStatusEntity.Description = String.Empty; } else { mDEvaluationSessionStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDEvaluationSessionStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEvaluationSessionStatusEntity;
        }
    }
}
