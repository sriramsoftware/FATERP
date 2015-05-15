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
    internal sealed class MDEvaluationSessionCategoryBuilder : IEntityBuilder<MDEvaluationSessionCategoryEntity>
    {
        IList<MDEvaluationSessionCategoryEntity> IEntityBuilder<MDEvaluationSessionCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEvaluationSessionCategoryEntity> MDEvaluationSessionCategoryEntityList = new List<MDEvaluationSessionCategoryEntity>();

            while (reader.Read())
            {
                MDEvaluationSessionCategoryEntityList.Add(((IEntityBuilder<MDEvaluationSessionCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDEvaluationSessionCategoryEntityList.Count > 0) ? MDEvaluationSessionCategoryEntityList : null;
        }

        MDEvaluationSessionCategoryEntity IEntityBuilder<MDEvaluationSessionCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SESSIONCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDEvaluationSessionCategoryEntity mDEvaluationSessionCategoryEntity = new MDEvaluationSessionCategoryEntity();

            mDEvaluationSessionCategoryEntity.SessionCategoryID = reader.GetInt64(FLD_SESSIONCATEGORYID);
            mDEvaluationSessionCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEvaluationSessionCategoryEntity.Description = String.Empty; } else { mDEvaluationSessionCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDEvaluationSessionCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEvaluationSessionCategoryEntity;
        }
    }
}
