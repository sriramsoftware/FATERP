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
    internal sealed class MDSupervisorTypeBuilder : IEntityBuilder<MDSupervisorTypeEntity>
    {
        IList<MDSupervisorTypeEntity> IEntityBuilder<MDSupervisorTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSupervisorTypeEntity> MDSupervisorTypeEntityList = new List<MDSupervisorTypeEntity>();

            while (reader.Read())
            {
                MDSupervisorTypeEntityList.Add(((IEntityBuilder<MDSupervisorTypeEntity>)this).BuildEntity(reader));
            }

            return (MDSupervisorTypeEntityList.Count > 0) ? MDSupervisorTypeEntityList : null;
        }

        MDSupervisorTypeEntity IEntityBuilder<MDSupervisorTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPERVISORTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDSupervisorTypeEntity mDSupervisorTypeEntity = new MDSupervisorTypeEntity();

            mDSupervisorTypeEntity.SupervisorTypeID = reader.GetInt64(FLD_SUPERVISORTYPEID);
            mDSupervisorTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDSupervisorTypeEntity.Description = String.Empty; } else { mDSupervisorTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDSupervisorTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSupervisorTypeEntity;
        }
    }
}
