// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Feb-2012, 04:08:22




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDStandardTimeUnitBuilder : IEntityBuilder<MDStandardTimeUnitEntity>
    {
        IList<MDStandardTimeUnitEntity> IEntityBuilder<MDStandardTimeUnitEntity>.BuildEntities(IDataReader reader)
        {
            List<MDStandardTimeUnitEntity> MDStandardTimeUnitEntityList = new List<MDStandardTimeUnitEntity>();

            while (reader.Read())
            {
                MDStandardTimeUnitEntityList.Add(((IEntityBuilder<MDStandardTimeUnitEntity>)this).BuildEntity(reader));
            }

            return (MDStandardTimeUnitEntityList.Count > 0) ? MDStandardTimeUnitEntityList : null;
        }

        MDStandardTimeUnitEntity IEntityBuilder<MDStandardTimeUnitEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_STANDARDTIMEUNITID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDStandardTimeUnitEntity mDStandardTimeUnitEntity = new MDStandardTimeUnitEntity();

            mDStandardTimeUnitEntity.StandardTimeUnitID = reader.GetInt64(FLD_STANDARDTIMEUNITID);
            mDStandardTimeUnitEntity.Name = reader.GetString(FLD_NAME);
            mDStandardTimeUnitEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDStandardTimeUnitEntity;
        }
    }
}
