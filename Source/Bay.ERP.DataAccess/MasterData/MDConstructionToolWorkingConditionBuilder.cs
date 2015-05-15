// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDConstructionToolWorkingConditionBuilder : IEntityBuilder<MDConstructionToolWorkingConditionEntity>
    {
        IList<MDConstructionToolWorkingConditionEntity> IEntityBuilder<MDConstructionToolWorkingConditionEntity>.BuildEntities(IDataReader reader)
        {
            List<MDConstructionToolWorkingConditionEntity> MDConstructionToolWorkingConditionEntityList = new List<MDConstructionToolWorkingConditionEntity>();

            while (reader.Read())
            {
                MDConstructionToolWorkingConditionEntityList.Add(((IEntityBuilder<MDConstructionToolWorkingConditionEntity>)this).BuildEntity(reader));
            }

            return (MDConstructionToolWorkingConditionEntityList.Count > 0) ? MDConstructionToolWorkingConditionEntityList : null;
        }

        MDConstructionToolWorkingConditionEntity IEntityBuilder<MDConstructionToolWorkingConditionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSTRUCTIONTOOLWORKINGCONDITIONID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDConstructionToolWorkingConditionEntity mDConstructionToolWorkingConditionEntity = new MDConstructionToolWorkingConditionEntity();

            mDConstructionToolWorkingConditionEntity.ConstructionToolWorkingConditionID = reader.GetInt64(FLD_CONSTRUCTIONTOOLWORKINGCONDITIONID);
            mDConstructionToolWorkingConditionEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDConstructionToolWorkingConditionEntity.Description = String.Empty; } else { mDConstructionToolWorkingConditionEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDConstructionToolWorkingConditionEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDConstructionToolWorkingConditionEntity;
        }
    }
}
