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
    internal sealed class APStatusBuilder : IEntityBuilder<APStatusEntity>
    {
        IList<APStatusEntity> IEntityBuilder<APStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<APStatusEntity> APStatusEntityList = new List<APStatusEntity>();

            while (reader.Read())
            {
                APStatusEntityList.Add(((IEntityBuilder<APStatusEntity>)this).BuildEntity(reader));
            }

            return (APStatusEntityList.Count > 0) ? APStatusEntityList : null;
        }

        APStatusEntity IEntityBuilder<APStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            APStatusEntity aPStatusEntity = new APStatusEntity();

            aPStatusEntity.APStatusID = reader.GetInt64(FLD_APSTATUSID);
            aPStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aPStatusEntity.Description = String.Empty; } else { aPStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aPStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aPStatusEntity;
        }
    }
}
