// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACAccountBuilder : IEntityBuilder<ACAccountEntity>
    {
        IList<ACAccountEntity> IEntityBuilder<ACAccountEntity>.BuildEntities(IDataReader reader)
        {
            List<ACAccountEntity> ACAccountEntityList = new List<ACAccountEntity>();

            while (reader.Read())
            {
                ACAccountEntityList.Add(((IEntityBuilder<ACAccountEntity>)this).BuildEntity(reader));
            }

            return (ACAccountEntityList.Count > 0) ? ACAccountEntityList : null;
        }

        ACAccountEntity IEntityBuilder<ACAccountEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTID = 0;
            const Int32 FLD_ACCOUNTGROUPID = 1;
            const Int32 FLD_ACCOUNTCODE = 2;
            const Int32 FLD_ACCOUNTCODE2 = 3;
            const Int32 FLD_ACCOUNTNAME = 4;
            const Int32 FLD_DESCRIPTION = 5;
            const Int32 FLD_ACCOUNTSTATUSID = 6;
            const Int32 FLD_TAXTYPEID = 7;
            const Int32 FLD_ISREMOVED = 8;

            ACAccountEntity aCAccountEntity = new ACAccountEntity();

            aCAccountEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCAccountEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID);
            aCAccountEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE);
            if (reader.IsDBNull(FLD_ACCOUNTCODE2)) { aCAccountEntity.AccountCode2 = String.Empty; } else { aCAccountEntity.AccountCode2 = reader.GetString(FLD_ACCOUNTCODE2); }
            aCAccountEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCAccountEntity.Description = String.Empty; } else { aCAccountEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCAccountEntity.AccountStatusID = reader.GetInt64(FLD_ACCOUNTSTATUSID);
            aCAccountEntity.TaxTypeID = reader.GetInt64(FLD_TAXTYPEID);
            aCAccountEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCAccountEntity;
        }
    }
}
