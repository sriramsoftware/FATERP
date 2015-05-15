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
    internal sealed class ACMDPaidFromBuilder : IEntityBuilder<ACMDPaidFromEntity>
    {
        IList<ACMDPaidFromEntity> IEntityBuilder<ACMDPaidFromEntity>.BuildEntities(IDataReader reader)
        {
            List<ACMDPaidFromEntity> ACMDPaidFromEntityList = new List<ACMDPaidFromEntity>();

            while (reader.Read())
            {
                ACMDPaidFromEntityList.Add(((IEntityBuilder<ACMDPaidFromEntity>)this).BuildEntity(reader));
            }

            return (ACMDPaidFromEntityList.Count > 0) ? ACMDPaidFromEntityList : null;
        }

        ACMDPaidFromEntity IEntityBuilder<ACMDPaidFromEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAIDFROMID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            ACMDPaidFromEntity aCMDPaidFromEntity = new ACMDPaidFromEntity();

            aCMDPaidFromEntity.PaidFromID = reader.GetInt64(FLD_PAIDFROMID);
            aCMDPaidFromEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCMDPaidFromEntity.Description = String.Empty; } else { aCMDPaidFromEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCMDPaidFromEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCMDPaidFromEntity;
        }
    }
}
