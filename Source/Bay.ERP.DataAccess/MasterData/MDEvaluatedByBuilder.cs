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
    internal sealed class MDEvaluatedByBuilder : IEntityBuilder<MDEvaluatedByEntity>
    {
        IList<MDEvaluatedByEntity> IEntityBuilder<MDEvaluatedByEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEvaluatedByEntity> MDEvaluatedByEntityList = new List<MDEvaluatedByEntity>();

            while (reader.Read())
            {
                MDEvaluatedByEntityList.Add(((IEntityBuilder<MDEvaluatedByEntity>)this).BuildEntity(reader));
            }

            return (MDEvaluatedByEntityList.Count > 0) ? MDEvaluatedByEntityList : null;
        }

        MDEvaluatedByEntity IEntityBuilder<MDEvaluatedByEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EVALUATEDBYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDEvaluatedByEntity mDEvaluatedByEntity = new MDEvaluatedByEntity();

            mDEvaluatedByEntity.EvaluatedByID = reader.GetInt64(FLD_EVALUATEDBYID);
            mDEvaluatedByEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEvaluatedByEntity.Description = String.Empty; } else { mDEvaluatedByEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDEvaluatedByEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEvaluatedByEntity;
        }
    }
}
