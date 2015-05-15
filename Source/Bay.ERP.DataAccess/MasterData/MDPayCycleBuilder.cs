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
    internal sealed class MDPayCycleBuilder : IEntityBuilder<MDPayCycleEntity>
    {
        IList<MDPayCycleEntity> IEntityBuilder<MDPayCycleEntity>.BuildEntities(IDataReader reader)
        {
            List<MDPayCycleEntity> MDPayCycleEntityList = new List<MDPayCycleEntity>();

            while (reader.Read())
            {
                MDPayCycleEntityList.Add(((IEntityBuilder<MDPayCycleEntity>)this).BuildEntity(reader));
            }

            return (MDPayCycleEntityList.Count > 0) ? MDPayCycleEntityList : null;
        }

        MDPayCycleEntity IEntityBuilder<MDPayCycleEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYCYCLEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDPayCycleEntity mDPayCycleEntity = new MDPayCycleEntity();

            mDPayCycleEntity.PayCycleID = reader.GetInt64(FLD_PAYCYCLEID);
            mDPayCycleEntity.Name = reader.GetString(FLD_NAME);
            mDPayCycleEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDPayCycleEntity;
        }
    }
}
