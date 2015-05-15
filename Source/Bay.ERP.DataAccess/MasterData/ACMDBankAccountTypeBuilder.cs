// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACMDBankAccountTypeBuilder : IEntityBuilder<ACMDBankAccountTypeEntity>
    {
        IList<ACMDBankAccountTypeEntity> IEntityBuilder<ACMDBankAccountTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<ACMDBankAccountTypeEntity> ACMDBankAccountTypeEntityList = new List<ACMDBankAccountTypeEntity>();

            while (reader.Read())
            {
                ACMDBankAccountTypeEntityList.Add(((IEntityBuilder<ACMDBankAccountTypeEntity>)this).BuildEntity(reader));
            }

            return (ACMDBankAccountTypeEntityList.Count > 0) ? ACMDBankAccountTypeEntityList : null;
        }

        ACMDBankAccountTypeEntity IEntityBuilder<ACMDBankAccountTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            ACMDBankAccountTypeEntity aCMDBankAccountTypeEntity = new ACMDBankAccountTypeEntity();

            aCMDBankAccountTypeEntity.BankAccountTypeID = reader.GetInt64(FLD_BANKACCOUNTTYPEID);
            aCMDBankAccountTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCMDBankAccountTypeEntity.Description = String.Empty; } else { aCMDBankAccountTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCMDBankAccountTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCMDBankAccountTypeEntity;
        }
    }
}
