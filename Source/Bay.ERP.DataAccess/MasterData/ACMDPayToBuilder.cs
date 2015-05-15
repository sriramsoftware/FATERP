// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACMDPayToBuilder : IEntityBuilder<ACMDPayToEntity>
    {
        IList<ACMDPayToEntity> IEntityBuilder<ACMDPayToEntity>.BuildEntities(IDataReader reader)
        {
            List<ACMDPayToEntity> ACMDPayToEntityList = new List<ACMDPayToEntity>();

            while (reader.Read())
            {
                ACMDPayToEntityList.Add(((IEntityBuilder<ACMDPayToEntity>)this).BuildEntity(reader));
            }

            return (ACMDPayToEntityList.Count > 0) ? ACMDPayToEntityList : null;
        }

        ACMDPayToEntity IEntityBuilder<ACMDPayToEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYTOID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            ACMDPayToEntity aCMDPayToEntity = new ACMDPayToEntity();

            aCMDPayToEntity.PayToID = reader.GetInt64(FLD_PAYTOID);
            aCMDPayToEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCMDPayToEntity.Description = String.Empty; } else { aCMDPayToEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCMDPayToEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCMDPayToEntity;
        }
    }
}
