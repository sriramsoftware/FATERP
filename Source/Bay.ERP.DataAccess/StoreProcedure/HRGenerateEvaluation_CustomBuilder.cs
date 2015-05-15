// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 06:31:16




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRGenerateEvaluation_CustomBuilder : IEntityBuilder<HRGenerateEvaluation_CustomEntity>
    {
        IList<HRGenerateEvaluation_CustomEntity> IEntityBuilder<HRGenerateEvaluation_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<HRGenerateEvaluation_CustomEntity> HRGenerateEvaluation_CustomEntityList = new List<HRGenerateEvaluation_CustomEntity>();

            while (reader.Read())
            {
                HRGenerateEvaluation_CustomEntityList.Add(((IEntityBuilder<HRGenerateEvaluation_CustomEntity>)this).BuildEntity(reader));
            }

            return (HRGenerateEvaluation_CustomEntityList.Count > 0) ? HRGenerateEvaluation_CustomEntityList : null;
        }

        HRGenerateEvaluation_CustomEntity IEntityBuilder<HRGenerateEvaluation_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESULT = 0;

            HRGenerateEvaluation_CustomEntity hRGenerateEvaluation_CustomEntity = new HRGenerateEvaluation_CustomEntity();

            if (reader.IsDBNull(FLD_RESULT)) { hRGenerateEvaluation_CustomEntity.Result = null; } else { hRGenerateEvaluation_CustomEntity.Result = reader.GetInt64(FLD_RESULT); }

            return hRGenerateEvaluation_CustomEntity;
        }
    }
}
