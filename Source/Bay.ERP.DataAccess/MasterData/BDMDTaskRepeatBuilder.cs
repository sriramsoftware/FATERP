// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDMDTaskRepeatBuilder : IEntityBuilder<BDMDTaskRepeatEntity>
    {
        IList<BDMDTaskRepeatEntity> IEntityBuilder<BDMDTaskRepeatEntity>.BuildEntities(IDataReader reader)
        {
            List<BDMDTaskRepeatEntity> BDMDTaskRepeatEntityList = new List<BDMDTaskRepeatEntity>();

            while (reader.Read())
            {
                BDMDTaskRepeatEntityList.Add(((IEntityBuilder<BDMDTaskRepeatEntity>)this).BuildEntity(reader));
            }

            return (BDMDTaskRepeatEntityList.Count > 0) ? BDMDTaskRepeatEntityList : null;
        }

        BDMDTaskRepeatEntity IEntityBuilder<BDMDTaskRepeatEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TASKREPEATID = 0;
            const Int32 FLD_TASKID = 1;
            const Int32 FLD_REPEATCATEGORYID = 2;
            const Int32 FLD_REPEATEVERY = 3;
            const Int32 FLD_STARTSON = 4;
            const Int32 FLD_ENDSON = 5;

            BDMDTaskRepeatEntity bDMDTaskRepeatEntity = new BDMDTaskRepeatEntity();

            bDMDTaskRepeatEntity.TaskRepeatID = reader.GetInt64(FLD_TASKREPEATID);
            bDMDTaskRepeatEntity.TaskID = reader.GetInt64(FLD_TASKID);
            bDMDTaskRepeatEntity.RepeatCategoryID = reader.GetInt64(FLD_REPEATCATEGORYID);
            bDMDTaskRepeatEntity.RepeatEvery = reader.GetInt32(FLD_REPEATEVERY);
            bDMDTaskRepeatEntity.StartsOn = reader.GetDateTime(FLD_STARTSON);
            if (reader.IsDBNull(FLD_ENDSON)) { bDMDTaskRepeatEntity.EndsOn = null; } else { bDMDTaskRepeatEntity.EndsOn = reader.GetDateTime(FLD_ENDSON); }

            return bDMDTaskRepeatEntity;
        }
    }
}
