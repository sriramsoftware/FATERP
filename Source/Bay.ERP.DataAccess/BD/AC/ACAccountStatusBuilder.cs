// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 03:28:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACAccountStatusBuilder : IEntityBuilder<ACAccountStatusEntity>
    {
        IList<ACAccountStatusEntity> IEntityBuilder<ACAccountStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<ACAccountStatusEntity> ACAccountStatusEntityList = new List<ACAccountStatusEntity>();

            while (reader.Read())
            {
                ACAccountStatusEntityList.Add(((IEntityBuilder<ACAccountStatusEntity>)this).BuildEntity(reader));
            }

            return (ACAccountStatusEntityList.Count > 0) ? ACAccountStatusEntityList : null;
        }

        ACAccountStatusEntity IEntityBuilder<ACAccountStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            ACAccountStatusEntity aCAccountStatusEntity = new ACAccountStatusEntity();

            aCAccountStatusEntity.AccountStatusID = reader.GetInt64(FLD_ACCOUNTSTATUSID);
            aCAccountStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCAccountStatusEntity.Description = String.Empty; } else { aCAccountStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCAccountStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCAccountStatusEntity;
        }
    }
}
