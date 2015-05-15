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
    internal sealed class MDUnitBuilder : IEntityBuilder<MDUnitEntity>
    {
        IList<MDUnitEntity> IEntityBuilder<MDUnitEntity>.BuildEntities(IDataReader reader)
        {
            List<MDUnitEntity> MDUnitEntityList = new List<MDUnitEntity>();

            while (reader.Read())
            {
                MDUnitEntityList.Add(((IEntityBuilder<MDUnitEntity>)this).BuildEntity(reader));
            }

            return (MDUnitEntityList.Count > 0) ? MDUnitEntityList : null;
        }

        MDUnitEntity IEntityBuilder<MDUnitEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_UNITID = 0;
            const Int32 FLD_UNITCODE = 1;
            const Int32 FLD_UNITNAME = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDUnitEntity mDUnitEntity = new MDUnitEntity();

            mDUnitEntity.UnitID = reader.GetInt64(FLD_UNITID);
            mDUnitEntity.UnitCode = reader.GetString(FLD_UNITCODE);
            mDUnitEntity.UnitName = reader.GetString(FLD_UNITNAME);
            mDUnitEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDUnitEntity;
        }
    }
}
