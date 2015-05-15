// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDEvaluationCriteriaCategoryBuilder : IEntityBuilder<MDEvaluationCriteriaCategoryEntity>
    {
        IList<MDEvaluationCriteriaCategoryEntity> IEntityBuilder<MDEvaluationCriteriaCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEvaluationCriteriaCategoryEntity> MDEvaluationCriteriaCategoryEntityList = new List<MDEvaluationCriteriaCategoryEntity>();

            while (reader.Read())
            {
                MDEvaluationCriteriaCategoryEntityList.Add(((IEntityBuilder<MDEvaluationCriteriaCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDEvaluationCriteriaCategoryEntityList.Count > 0) ? MDEvaluationCriteriaCategoryEntityList : null;
        }

        MDEvaluationCriteriaCategoryEntity IEntityBuilder<MDEvaluationCriteriaCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EVALUATIONCRITERIACATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDEvaluationCriteriaCategoryEntity mDEvaluationCriteriaCategoryEntity = new MDEvaluationCriteriaCategoryEntity();

            mDEvaluationCriteriaCategoryEntity.EvaluationCriteriaCategoryID = reader.GetInt64(FLD_EVALUATIONCRITERIACATEGORYID);
            mDEvaluationCriteriaCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEvaluationCriteriaCategoryEntity.Description = String.Empty; } else { mDEvaluationCriteriaCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDEvaluationCriteriaCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEvaluationCriteriaCategoryEntity;
        }
    }
}
