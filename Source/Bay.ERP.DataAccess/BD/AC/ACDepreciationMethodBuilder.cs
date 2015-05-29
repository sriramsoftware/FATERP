// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACDepreciationMethodBuilder : IEntityBuilder<ACDepreciationMethodEntity>
    {
        IList<ACDepreciationMethodEntity> IEntityBuilder<ACDepreciationMethodEntity>.BuildEntities(IDataReader reader)
        {
            List<ACDepreciationMethodEntity> ACDepreciationMethodEntityList = new List<ACDepreciationMethodEntity>();

            while (reader.Read())
            {
                ACDepreciationMethodEntityList.Add(((IEntityBuilder<ACDepreciationMethodEntity>)this).BuildEntity(reader));
            }

            return (ACDepreciationMethodEntityList.Count > 0) ? ACDepreciationMethodEntityList : null;
        }

        ACDepreciationMethodEntity IEntityBuilder<ACDepreciationMethodEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DEPRECIATIONMETHODID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            ACDepreciationMethodEntity aCDepreciationMethodEntity = new ACDepreciationMethodEntity();

            aCDepreciationMethodEntity.DepreciationMethodID = reader.GetInt64(FLD_DEPRECIATIONMETHODID);
            aCDepreciationMethodEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCDepreciationMethodEntity.Description = String.Empty; } else { aCDepreciationMethodEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCDepreciationMethodEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCDepreciationMethodEntity;
        }
    }
}
