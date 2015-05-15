// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APTypeBuilder : IEntityBuilder<APTypeEntity>
    {
        IList<APTypeEntity> IEntityBuilder<APTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<APTypeEntity> APTypeEntityList = new List<APTypeEntity>();

            while (reader.Read())
            {
                APTypeEntityList.Add(((IEntityBuilder<APTypeEntity>)this).BuildEntity(reader));
            }

            return (APTypeEntityList.Count > 0) ? APTypeEntityList : null;
        }

        APTypeEntity IEntityBuilder<APTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            APTypeEntity aPTypeEntity = new APTypeEntity();

            aPTypeEntity.APTypeID = reader.GetInt64(FLD_APTYPEID);
            aPTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aPTypeEntity.Description = String.Empty; } else { aPTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aPTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aPTypeEntity;
        }
    }
}
